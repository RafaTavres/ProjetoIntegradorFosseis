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
   
    public partial class MeusFavos : Form
    {
        Thread t1;
        MySqlConnection Conexao;
        public MeusFavos()
        {
            InitializeComponent();

            listView1.View = View.Details;
            listView1.LabelEdit = true;
            listView1.AllowColumnReorder = true;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            listView1.Columns.Add("Região", 250, HorizontalAlignment.Left);
            listView1.Columns.Add("descrição", 250, HorizontalAlignment.Left);

            try
            {

                string data_source = "datasource=localhost;username=root;password=mysql123!;database=ProjetoInt";
                // Criar Conex
                Conexao = new MySqlConnection(data_source);
                string sql = "select  Nome_Fossil,Regiao,DescricaoFossil from tb_Fossil_Favorito inner join tb_Fossil on Id = Fossil_Id";

                //Executa Busca
                Conexao.Open();

                MySqlCommand comand = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comand.ExecuteReader();

                listView1.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),

                    };

                    var linhalistview = new ListViewItem(row);

                    listView1.Items.Add(linhalistview);
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

        private void VoltarBtn_Click(object sender, EventArgs e)
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

        private void AdcAosfavoritos_Click(object sender, EventArgs e)
        {
            try
            {
                string b =  "(" + BuscaFavoritos.Text + ")" ;

                string data_source = "datasource=localhost;username=root;password=mysql123!;database=ProjetoInt";
                // Criar Conex
                Conexao = new MySqlConnection(data_source);
                string sql = "insert into tb_Fossil_Favorito (Fossil_id) value " +b;

                //Executa Busca
                Conexao.Open();

                MySqlCommand comand = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comand.ExecuteReader();

                listView1.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),

                    };
                    
                    var linhalistview = new ListViewItem(row);

                    listView1.Items.Add(linhalistview);
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
            try
            {

                string data_source = "datasource=localhost;username=root;password=mysql123!;database=ProjetoInt";
                // Criar Conex
                Conexao = new MySqlConnection(data_source);
                string sql = "select  Nome_Fossil,Regiao,DescricaoFossil from tb_Fossil_Favorito inner join tb_Fossil on Id = Fossil_Id";

                //Executa Busca
                Conexao.Open();

                MySqlCommand comand = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comand.ExecuteReader();

                listView1.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),

                    };

                    var linhalistview = new ListViewItem(row);

                    listView1.Items.Add(linhalistview);
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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
