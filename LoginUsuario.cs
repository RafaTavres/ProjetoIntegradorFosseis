using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetoIntegrador
{

    public partial class LoginUsuario : Form
    {
        Thread t1;
        MySqlCommand coman = new MySqlCommand();
        MySqlConnection Conexao;
        public LoginUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Controle cn = new Controle();
            cn.Acessar(Nometxt.Text,Cpftxt2.Text,Senhatxt2.Text);
            if(cn.tem == true)
            {
                this.Close();
                t1 = new Thread(AbrirJanela);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }
        }

        public bool tem = false;
        public string mensagem;
        MySqlDataReader dr;
        public bool VerificarLogin(string NomeTxt, string CpfTxt, string SenhaTxt)
        {
            coman.CommandText = "select * from tabela1 where Nome = @NomeTxt and Cpf = @CpfTxt and Senha = @SenhaTxt";
            coman.Parameters.AddWithValue("@NomeTxt", NomeTxt);
            coman.Parameters.AddWithValue("@CpfTxt", CpfTxt);
            coman.Parameters.AddWithValue("@SenhaTxt", SenhaTxt);


            //Fazer a classe para a conexao
            try
            {
                string data_source = "datasource=localhost;username=root;password=mysql123!;database=ProjetoInt";
                Conexao = new MySqlConnection(data_source);

                coman.Connection = new Conexao(data_source);
                dr = coman.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }

            }catch(MySqlException)
            {
                this.mensagem = "Erro com banco de dados";
            }
            return tem;
        }
        private void AbrirJanela(object objeto)
        {
            Application.Run(new UsuarioJanela());
        }

        private void Nometxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Senhatxt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotaoVoltarLogin_Click(object sender, EventArgs e)
        {

        }
    }
}
