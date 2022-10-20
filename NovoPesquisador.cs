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

namespace ProjetoIntegrador
{
    public partial class NovoPesquisador : Form
    {
        Thread t1;
        MySqlConnection Conexao;
        public NovoPesquisador()
        {
            InitializeComponent();
        }

        private void LoginUsuario_Load(object sender, EventArgs e)
        {

        }

        private void VoltarBtn2_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirJanela);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
        private void AbrirJanela(object objeto)
        {
            Application.Run(new Form1());
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password=mysql123!;database=ProjetoInt";
                // Criar Conex
                Conexao = new MySqlConnection(data_source);
                string sql = "insert into tabela2 (nome,Cpf,senha) Values ('" + NomeTxt.Text + "','" + CpfTxt.Text + "','" + SenhaTxt.Text + "')";

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
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
