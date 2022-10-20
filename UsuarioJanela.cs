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
    public partial class UsuarioJanela : Form
    {
        Thread t1;
        public UsuarioJanela()
        {
            InitializeComponent();
        }

        private void VoltarUsuarioJanela_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirJanelaInicial);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
        private void AbrirJanelaInicial(object objeto)
        {
            Application.Run(new Form1());
        }

        private void AdicinarFossilBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirJanelaAdicionarFossil);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
        private void AbrirJanelaAdicionarFossil(object objeto)
        {
            Application.Run(new AdicionarFossil());
        }

        private void TodosFosseis_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirJanelaTodosFosseis);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
        private void AbrirJanelaTodosFosseis(object objeto)
        {
            Application.Run(new TodosFosseis());
        }

        private void RanksFossilBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirJanelaRankFosseis);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
        private void AbrirJanelaRankFosseis(object objeto)
        {
            Application.Run(new RankFosseis());
        }

        private void RanksFossilDescrição_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirJanelaRankDescricao);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
        private void AbrirJanelaRankDescricao(object objeto)
        {
            Application.Run(new RankDescricao());
        }

        private void FavoritoFossilBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirJanelMeusFavoritos);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
        private void AbrirJanelMeusFavoritos(object objeto)
        {
            Application.Run(new MeusFavos());
        }
    }
}
