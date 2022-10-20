using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace ProjetoIntegrador
{
    public partial class AdicionarFossil : Form
    {
        MySqlConnection Conexao;
        Thread t1;
        string origemCompleto = "";
        string foto = "";
        string pastaDestino = Globais.caminhoFoto;
        string destinoCompleto = "";
        byte[] imagem_byte = null;
        public AdicionarFossil()
        {
            InitializeComponent();
        }

        private void AdcFotoFossil_Click(object sender, EventArgs e)
        {
             origemCompleto = "";
             foto = "";
             pastaDestino = Globais.caminhoFoto;
             destinoCompleto = "";

            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                origemCompleto = openFileDialog1.FileName;
                foto = openFileDialog1.SafeFileName;
                destinoCompleto = pastaDestino + foto;
            }

                if (File.Exists(destinoCompleto))
                {
                    if (MessageBox.Show("Arquivo já existe, deseja substituir?", "Substituir", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }

                System.IO.File.Copy(origemCompleto,destinoCompleto,true);
                if (File.Exists(destinoCompleto))
                {
                    FotoFossilTxt.ImageLocation = destinoCompleto;
                    
                }
                else
                {
                    MessageBox.Show("Arquivo não copiado");
                }

            
        }

        private void VoltarJanelaUsu_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirJanela);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
        private void AbrirJanela(object objeto)
        {
            Application.Run(new UsuarioJanela());
        }

        private void SalvarFossil_Click(object sender, EventArgs e)
        {

            try
            {
               
                string data_source = "datasource=localhost;username=root;password=mysql123!;database=ProjetoInt";
                // Criar Conex                                                                                  
                Conexao = new MySqlConnection(data_source);
                string sql = "insert into tb_Fossil (Nome_Fossil,Regiao,fotoFossil,DescricaoFossil) Values ('" + NomeFossilTxt.Text + "','" + BoxRegiões.Text + "','" + destinoCompleto + "','" + DescricaoText.Text + "')";
                
                //Executa Insert
                MySqlCommand comand = new MySqlCommand(sql, Conexao);

                Conexao.Open();

                comand.ExecuteReader();

                MessageBox.Show("Concluido!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }


            if (destinoCompleto == "")
            {
                if(MessageBox.Show("Sem Foto Selecionada, deseja continuar?", "ERRO", MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    return;
                }
            }
            if (destinoCompleto != "")
            {
                System.IO.File.Copy(origemCompleto, destinoCompleto, true);
                if (File.Exists(destinoCompleto))
                {
                    FotoFossilTxt.ImageLocation = destinoCompleto;

                    /*FileStream fstream = new FileStream(this.FotoFossilTxt.Text, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fstream);
                    imagem_byte = br.ReadBytes((int)fstream.Length);*/

                   
                }
                else
                {
                    if (MessageBox.Show("Erro ao Selecionar Foto Selecionada, deseja continuar?", "ERRO", MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
            }
        }



    }
}
