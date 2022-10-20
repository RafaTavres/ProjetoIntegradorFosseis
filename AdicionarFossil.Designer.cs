namespace ProjetoIntegrador
{
    partial class AdicionarFossil
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.SalvarFossil = new System.Windows.Forms.Button();
            this.AdcFotoFossil = new System.Windows.Forms.Button();
            this.FotoFossilTxt = new System.Windows.Forms.PictureBox();
            this.BoxRegiões = new System.Windows.Forms.ComboBox();
            this.ImagemFossil = new System.Windows.Forms.Label();
            this.RegiaoFossil = new System.Windows.Forms.Label();
            this.NomeFossilTxt = new System.Windows.Forms.TextBox();
            this.NomeFossil = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.VoltarJanelaUsu = new System.Windows.Forms.Button();
            this.DescFossil = new System.Windows.Forms.Label();
            this.DescricaoText = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoFossilTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.DescricaoText);
            this.panel1.Controls.Add(this.DescFossil);
            this.panel1.Controls.Add(this.SalvarFossil);
            this.panel1.Controls.Add(this.AdcFotoFossil);
            this.panel1.Controls.Add(this.FotoFossilTxt);
            this.panel1.Controls.Add(this.BoxRegiões);
            this.panel1.Controls.Add(this.ImagemFossil);
            this.panel1.Controls.Add(this.RegiaoFossil);
            this.panel1.Controls.Add(this.NomeFossilTxt);
            this.panel1.Controls.Add(this.NomeFossil);
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 399);
            this.panel1.TabIndex = 0;
            // 
            // SalvarFossil
            // 
            this.SalvarFossil.Location = new System.Drawing.Point(202, 352);
            this.SalvarFossil.Name = "SalvarFossil";
            this.SalvarFossil.Size = new System.Drawing.Size(90, 39);
            this.SalvarFossil.TabIndex = 8;
            this.SalvarFossil.Text = "Salvar";
            this.SalvarFossil.UseVisualStyleBackColor = true;
            this.SalvarFossil.Click += new System.EventHandler(this.SalvarFossil_Click);
            // 
            // AdcFotoFossil
            // 
            this.AdcFotoFossil.Location = new System.Drawing.Point(202, 282);
            this.AdcFotoFossil.Name = "AdcFotoFossil";
            this.AdcFotoFossil.Size = new System.Drawing.Size(72, 39);
            this.AdcFotoFossil.TabIndex = 7;
            this.AdcFotoFossil.Text = "Adicionar Foto";
            this.AdcFotoFossil.UseVisualStyleBackColor = true;
            this.AdcFotoFossil.Click += new System.EventHandler(this.AdcFotoFossil_Click);
            // 
            // FotoFossilTxt
            // 
            this.FotoFossilTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FotoFossilTxt.Location = new System.Drawing.Point(12, 234);
            this.FotoFossilTxt.Name = "FotoFossilTxt";
            this.FotoFossilTxt.Size = new System.Drawing.Size(181, 157);
            this.FotoFossilTxt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FotoFossilTxt.TabIndex = 6;
            this.FotoFossilTxt.TabStop = false;
            // 
            // BoxRegiões
            // 
            this.BoxRegiões.FormattingEnabled = true;
            this.BoxRegiões.Items.AddRange(new object[] {
            "Parque das Dunas, RN;Marcos Antonio Leite do Nascimento; Debora do Carmo Sousa; G" +
                "uilherme Cherem Schwarz Pierri",
            "Marmitas do Rio Carnaúba, Acari, RN;Wendson Dantas de Araújo Medeiros; Marcos Ant" +
                "onio Leite do Nascimento",
            "Parque Estadual dos Três Picos, RJ,Miguel Antonio Tupinambá Araújo Souza; Marcelo" +
                " Ambrosio Ferrassoli;Luiz Guilherme Almeida do Eirado Silva",
            "Sítio Espeleológico Serra do Martins, RN;Reinaldo Antônio Petta ; Joaquim das Vir" +
                "gens Neto ; Thomas Ferreira da Costa Campos; Vanildo Pereira da Fonseca",
            "Cavernas da região de Guarani de Goiás e São Domingos, GO;Ivo Karmann; Lina Bichu" +
                "ette",
            "Astroblema de Cerro do Jarau, RS;Alvaro Penteado Crósta; Fernanda Silva Lourenço"});
            this.BoxRegiões.Location = new System.Drawing.Point(18, 92);
            this.BoxRegiões.Name = "BoxRegiões";
            this.BoxRegiões.Size = new System.Drawing.Size(247, 23);
            this.BoxRegiões.TabIndex = 3;
            // 
            // ImagemFossil
            // 
            this.ImagemFossil.AutoSize = true;
            this.ImagemFossil.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.ImagemFossil.Location = new System.Drawing.Point(15, 210);
            this.ImagemFossil.Name = "ImagemFossil";
            this.ImagemFossil.Size = new System.Drawing.Size(132, 21);
            this.ImagemFossil.TabIndex = 5;
            this.ImagemFossil.Text = "Imagem do Fóssil";
            // 
            // RegiaoFossil
            // 
            this.RegiaoFossil.AutoSize = true;
            this.RegiaoFossil.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.RegiaoFossil.Location = new System.Drawing.Point(15, 68);
            this.RegiaoFossil.Name = "RegiaoFossil";
            this.RegiaoFossil.Size = new System.Drawing.Size(101, 21);
            this.RegiaoFossil.TabIndex = 2;
            this.RegiaoFossil.Text = "Região Fóssil";
            // 
            // NomeFossilTxt
            // 
            this.NomeFossilTxt.Location = new System.Drawing.Point(15, 29);
            this.NomeFossilTxt.Name = "NomeFossilTxt";
            this.NomeFossilTxt.Size = new System.Drawing.Size(250, 23);
            this.NomeFossilTxt.TabIndex = 1;
            // 
            // NomeFossil
            // 
            this.NomeFossil.AutoSize = true;
            this.NomeFossil.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.NomeFossil.Location = new System.Drawing.Point(12, 5);
            this.NomeFossil.Name = "NomeFossil";
            this.NomeFossil.Size = new System.Drawing.Size(144, 21);
            this.NomeFossil.TabIndex = 0;
            this.NomeFossil.Text = "Nome para o Fóssil";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(803, 52);
            this.panel2.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "JPG(*.jpg)|*.jpg|PNG(*.png)|*.png";
            // 
            // VoltarJanelaUsu
            // 
            this.VoltarJanelaUsu.Location = new System.Drawing.Point(707, 384);
            this.VoltarJanelaUsu.Name = "VoltarJanelaUsu";
            this.VoltarJanelaUsu.Size = new System.Drawing.Size(81, 37);
            this.VoltarJanelaUsu.TabIndex = 8;
            this.VoltarJanelaUsu.Text = "Voltar";
            this.VoltarJanelaUsu.UseVisualStyleBackColor = true;
            this.VoltarJanelaUsu.Click += new System.EventHandler(this.VoltarJanelaUsu_Click);
            // 
            // DescFossil
            // 
            this.DescFossil.AutoSize = true;
            this.DescFossil.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.DescFossil.Location = new System.Drawing.Point(15, 129);
            this.DescFossil.Name = "DescFossil";
            this.DescFossil.Size = new System.Drawing.Size(77, 21);
            this.DescFossil.TabIndex = 9;
            this.DescFossil.Text = "Descrição";
            // 
            // DescricaoText
            // 
            this.DescricaoText.Location = new System.Drawing.Point(19, 153);
            this.DescricaoText.Name = "DescricaoText";
            this.DescricaoText.Size = new System.Drawing.Size(246, 23);
            this.DescricaoText.TabIndex = 10;
            // 
            // AdicionarFossil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VoltarJanelaUsu);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AdicionarFossil";
            this.Text = "AdicionarFossil";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FotoFossilTxt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private ComboBox BoxRegiões;
        private Label RegiaoFossil;
        private TextBox NomeFossilTxt;
        private Label NomeFossil;
        private Panel panel2;
        private Label ImagemFossil;
        private Button AdcFotoFossil;
        private PictureBox FotoFossilTxt;
        private OpenFileDialog openFileDialog1;
        private Button VoltarJanelaUsu;
        private Button SalvarFossil;
        private TextBox DescricaoText;
        private Label DescFossil;
    }
}