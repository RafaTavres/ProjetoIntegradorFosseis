using MySql.Data.MySqlClient;

namespace ProjetoIntegrador
{
    public partial class Form1 : Form
    {

        Thread t1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void ldlHelloWorld_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirJanela2);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
        private void AbrirJanela(object objeto)
        {
            Application.Run(new NovoUsuario());
        }
        private void AbrirJanela2(object objeto)
        {
            Application.Run(new NovoPesquisador());
        }
        private void AbrirJanela3(object objeto)
        {
            Application.Run(new LoginUsuario());
        }

        private void NovoUsuarioButton_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirJanela);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(AbrirJanela3);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void SairBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}