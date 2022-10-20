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
    public partial class NovoUsuario : Form
    {
        Thread t1;
        MySqlConnection Conexao;

        public NovoUsuario()
        {
            InitializeComponent();
        }

        private void Janela2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                string data_source = "datasource=localhost;username=root;password=mysql123!;database=ProjetoInt";
                // Criar Conex
                Conexao = new MySqlConnection(data_source);
                string sql = "insert into tabela1 (nome,Cpf,senha) Values ('" + NomeTxt.Text + "','" + CpfTxt.Text + "','" + SenhaTxt.Text + "')";

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

        private void Senha_Click(object sender, EventArgs e)
        {

        }

        private void CpfTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void VoltarBtn_Click(object sender, EventArgs e)
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

       
    }
}
