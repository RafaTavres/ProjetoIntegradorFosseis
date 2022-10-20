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
    public partial class RankFosseis : Form
    {
        Thread t1;
        MySqlConnection Conexao;
        public RankFosseis()
        {
            InitializeComponent();
            ListaRankRegiao.View = View.Details;
            ListaRankRegiao.LabelEdit = true;
            ListaRankRegiao.AllowColumnReorder = true;
            ListaRankRegiao.FullRowSelect = true;
            ListaRankRegiao.GridLines = true;

            ListaRankRegiao.Columns.Add("Regiao", 250, HorizontalAlignment.Left);
            ListaRankRegiao.Columns.Add("Quantidade de Fosseis da Região", 150, HorizontalAlignment.Left);

            try
            {

                string data_source = "datasource=localhost;username=root;password=mysql123!;database=ProjetoInt";
                // Criar Conex
                Conexao = new MySqlConnection(data_source);
                string sql = "select Regiao,count(Regiao) from tb_Fossil group by Regiao order by count(Regiao) desc ";

                //Executa Busca
                Conexao.Open();

                MySqlCommand comand = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comand.ExecuteReader();

                ListaRankRegiao.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),

                    };
                    
                    var linhalistview = new ListViewItem(row);

                    ListaRankRegiao.Items.Add(linhalistview);
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

        private void ListaRankRegiao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VoltarButton_Click(object sender, EventArgs e)
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

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
          
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
