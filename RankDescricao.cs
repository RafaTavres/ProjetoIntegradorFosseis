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

    public partial class RankDescricao : Form
    {
        Thread t1;
        MySqlConnection Conexao;
        public RankDescricao()
        {
            InitializeComponent();
            ListaRankDescricao.View = View.Details;
            ListaRankDescricao.LabelEdit = true;
            ListaRankDescricao.AllowColumnReorder = true;
            ListaRankDescricao.FullRowSelect = true;
            ListaRankDescricao.GridLines = true;

            ListaRankDescricao.Columns.Add("ID",25, HorizontalAlignment.Left);
            ListaRankDescricao.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            ListaRankDescricao.Columns.Add("Região", 250, HorizontalAlignment.Left);
            ListaRankDescricao.Columns.Add("Descricao do Fossil", 150, HorizontalAlignment.Left);
            ListaRankDescricao.Columns.Add("Tamanho da do DescricaoFossil",100, HorizontalAlignment.Left);

            try
            {

                string data_source = "datasource=localhost;username=root;password=mysql123!;database=ProjetoInt";
                // Criar Conex
                Conexao = new MySqlConnection(data_source);
                string sql = "select Id,Nome_Fossil,Regiao,DescricaoFossil,length(DescricaoFossil)from tb_Fossil group by Id order by length(DescricaoFossil) desc ";

                //Executa Busca
                Conexao.Open();

                MySqlCommand comand = new MySqlCommand(sql, Conexao);

                MySqlDataReader reader = comand.ExecuteReader();

                ListaRankDescricao.Items.Clear();

                while (reader.Read())
                {
                    string[] row =
                    {
                        reader.GetString(0),
                        reader.GetString(1),
                        reader.GetString(2),
                        reader.GetString(3),
                        reader.GetString(4),

                    };

                    var linhalistview = new ListViewItem(row);

                    ListaRankDescricao.Items.Add(linhalistview);
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

        private void VoltarJnl_Click_1(object sender, EventArgs e)
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
    }
}
