using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace ProjetoIntegrador
{
    public partial class TodosFosseis : Form
    {
        Thread t1;
        MySqlConnection Conexao;
        public TodosFosseis()
        {
            InitializeComponent();
            ListaFosseis.View = View.Details;
            ListaFosseis.LabelEdit = true;
            ListaFosseis.AllowColumnReorder = true;
            ListaFosseis.FullRowSelect = true;
            ListaFosseis.GridLines = true;

            ListaFosseis.Columns.Add("ID", 25, HorizontalAlignment.Left);
            ListaFosseis.Columns.Add("Nome_Fossil", 100, HorizontalAlignment.Left);
            ListaFosseis.Columns.Add("Regiao", 150, HorizontalAlignment.Left);
            ListaFosseis.Columns.Add("Caminho da Foto", 150, HorizontalAlignment.Left);
            ListaFosseis.Columns.Add("Descrição do Fóssil", 150, HorizontalAlignment.Left);

            try
            {

                string data_source = "datasource=localhost;username=root;password=mysql123!;database=ProjetoInt";
                // Criar Conex
                Conexao = new MySqlConnection(data_source);
                string sql = "select * from tb_Fossil ";

                //Executa Busca
                Conexao.Open();

                MySqlCommand comand = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comand.ExecuteReader();

                ListaFosseis.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetString(5),
                    };
                    /*
                    byte[] imagem_byte = (byte[])(reader["FOTOBLOB"]);
                    if(imagem_byte == null)
                    {
                        PictureFossil.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(imagem_byte);

                        PictureFossil.Image = System.Drawing.Image.FromStream(ms);
                    }
                    */
                    var linhalistview = new ListViewItem(row);

                    ListaFosseis.Items.Add(linhalistview);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void VoltarUsuario_Click(object sender, EventArgs e)
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

        private void BuscarButton_Click(object sender, EventArgs e)
        {
            try
            {
                string b = "'%" + BuscarTxt.Text + "%'";

                string data_source = "datasource=localhost;username=root;password=mysql123!;database=ProjetoInt";
                // Criar Conex
                Conexao = new MySqlConnection(data_source);
                string sql = "select * from tb_Fossil where Nome_Fossil like " + b;

                //Executa Busca
                Conexao.Open();

                MySqlCommand comand = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comand.ExecuteReader();

                ListaFosseis.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),
                        reader.GetString(5),

                    };
                    /*
                    byte[] imagem_byte = (byte[])(reader["FOTOBLOB"]);
                    if(imagem_byte == null)
                    {
                        PictureFossil.Image = null;
                    }
                    else
                    {
                        MemoryStream ms = new MemoryStream(imagem_byte);

                        PictureFossil.Image = System.Drawing.Image.FromStream(ms);
                    }
                    */
                    var linhalistview = new ListViewItem(row);

                    ListaFosseis.Items.Add(linhalistview);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void PictureFossil_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved_1(object sender, SplitterEventArgs e)
        {

        }

        private void BuscarTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void ListaFosseis_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
