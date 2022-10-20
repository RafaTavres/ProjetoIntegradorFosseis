namespace ProjetoIntegrador
{
    partial class UsuarioJanela
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AdicinarFossilBtn = new System.Windows.Forms.Button();
            this.RanksFossilBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TodosFosseis = new System.Windows.Forms.Button();
            this.VoltarUsuarioJanela = new System.Windows.Forms.Button();
            this.FavoritoFossilBtn = new System.Windows.Forms.Button();
            this.RanksFossilDescrição = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InfoText;
            this.panel2.Location = new System.Drawing.Point(267, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 234);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "O\'que deseja Fazer?";
            // 
            // AdicinarFossilBtn
            // 
            this.AdicinarFossilBtn.Location = new System.Drawing.Point(0, 80);
            this.AdicinarFossilBtn.Name = "AdicinarFossilBtn";
            this.AdicinarFossilBtn.Size = new System.Drawing.Size(154, 41);
            this.AdicinarFossilBtn.TabIndex = 3;
            this.AdicinarFossilBtn.Text = "Adicionar Fóssil";
            this.AdicinarFossilBtn.UseVisualStyleBackColor = true;
            this.AdicinarFossilBtn.Click += new System.EventHandler(this.AdicinarFossilBtn_Click);
            // 
            // RanksFossilBtn
            // 
            this.RanksFossilBtn.Location = new System.Drawing.Point(0, 178);
            this.RanksFossilBtn.Name = "RanksFossilBtn";
            this.RanksFossilBtn.Size = new System.Drawing.Size(153, 41);
            this.RanksFossilBtn.TabIndex = 4;
            this.RanksFossilBtn.Text = "Rank das Regiões com Mais Fósseis";
            this.RanksFossilBtn.UseVisualStyleBackColor = true;
            this.RanksFossilBtn.Click += new System.EventHandler(this.RanksFossilBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.TodosFosseis);
            this.panel1.Controls.Add(this.VoltarUsuarioJanela);
            this.panel1.Controls.Add(this.FavoritoFossilBtn);
            this.panel1.Controls.Add(this.RanksFossilDescrição);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.RanksFossilBtn);
            this.panel1.Controls.Add(this.AdicinarFossilBtn);
            this.panel1.Location = new System.Drawing.Point(0, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 456);
            this.panel1.TabIndex = 5;
            // 
            // TodosFosseis
            // 
            this.TodosFosseis.Location = new System.Drawing.Point(0, 131);
            this.TodosFosseis.Name = "TodosFosseis";
            this.TodosFosseis.Size = new System.Drawing.Size(153, 41);
            this.TodosFosseis.TabIndex = 8;
            this.TodosFosseis.Text = "Todos os Fósseis";
            this.TodosFosseis.UseVisualStyleBackColor = true;
            this.TodosFosseis.Click += new System.EventHandler(this.TodosFosseis_Click);
            // 
            // VoltarUsuarioJanela
            // 
            this.VoltarUsuarioJanela.Location = new System.Drawing.Point(3, 401);
            this.VoltarUsuarioJanela.Name = "VoltarUsuarioJanela";
            this.VoltarUsuarioJanela.Size = new System.Drawing.Size(108, 44);
            this.VoltarUsuarioJanela.TabIndex = 7;
            this.VoltarUsuarioJanela.Text = "Voltar ao Menu Principal";
            this.VoltarUsuarioJanela.UseVisualStyleBackColor = true;
            this.VoltarUsuarioJanela.Click += new System.EventHandler(this.VoltarUsuarioJanela_Click);
            // 
            // FavoritoFossilBtn
            // 
            this.FavoritoFossilBtn.Location = new System.Drawing.Point(-2, 290);
            this.FavoritoFossilBtn.Name = "FavoritoFossilBtn";
            this.FavoritoFossilBtn.Size = new System.Drawing.Size(153, 40);
            this.FavoritoFossilBtn.TabIndex = 6;
            this.FavoritoFossilBtn.Text = "Meus Favoritos";
            this.FavoritoFossilBtn.UseVisualStyleBackColor = true;
            this.FavoritoFossilBtn.Click += new System.EventHandler(this.FavoritoFossilBtn_Click);
            // 
            // RanksFossilDescrição
            // 
            this.RanksFossilDescrição.Location = new System.Drawing.Point(-2, 235);
            this.RanksFossilDescrição.Name = "RanksFossilDescrição";
            this.RanksFossilDescrição.Size = new System.Drawing.Size(155, 40);
            this.RanksFossilDescrição.TabIndex = 5;
            this.RanksFossilDescrição.Text = "Rank dos Fósseis com maior Descrição";
            this.RanksFossilDescrição.UseVisualStyleBackColor = true;
            this.RanksFossilDescrição.Click += new System.EventHandler(this.RanksFossilDescrição_Click);
            // 
            // UsuarioJanela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UsuarioJanela";
            this.Text = "UsuarioJanela";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private Label label1;
        private Button AdicinarFossilBtn;
        private Button RanksFossilBtn;
        private Panel panel1;
        private Button FavoritoFossilBtn;
        private Button RanksFossilDescrição;
        private Button VoltarUsuarioJanela;
        private Button TodosFosseis;
    }
}