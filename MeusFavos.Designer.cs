namespace ProjetoIntegrador
{
    partial class MeusFavos
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
            this.VoltarBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.AdcAosfavoritos = new System.Windows.Forms.Button();
            this.BuscaFavoritos = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // VoltarBtn
            // 
            this.VoltarBtn.Location = new System.Drawing.Point(171, 59);
            this.VoltarBtn.Name = "VoltarBtn";
            this.VoltarBtn.Size = new System.Drawing.Size(89, 50);
            this.VoltarBtn.TabIndex = 0;
            this.VoltarBtn.Text = "Voltar";
            this.VoltarBtn.UseVisualStyleBackColor = true;
            this.VoltarBtn.Click += new System.EventHandler(this.VoltarBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AdcAosfavoritos);
            this.panel1.Controls.Add(this.BuscaFavoritos);
            this.panel1.Controls.Add(this.VoltarBtn);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 131);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(47, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID do Fóssil";
            // 
            // AdcAosfavoritos
            // 
            this.AdcAosfavoritos.Location = new System.Drawing.Point(47, 59);
            this.AdcAosfavoritos.Name = "AdcAosfavoritos";
            this.AdcAosfavoritos.Size = new System.Drawing.Size(90, 50);
            this.AdcAosfavoritos.TabIndex = 1;
            this.AdcAosfavoritos.Text = "Adicionar As Favoritos";
            this.AdcAosfavoritos.UseVisualStyleBackColor = true;
            this.AdcAosfavoritos.Click += new System.EventHandler(this.AdcAosfavoritos_Click);
            // 
            // BuscaFavoritos
            // 
            this.BuscaFavoritos.Location = new System.Drawing.Point(47, 30);
            this.BuscaFavoritos.Name = "BuscaFavoritos";
            this.BuscaFavoritos.Size = new System.Drawing.Size(213, 23);
            this.BuscaFavoritos.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(306, 7);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(482, 410);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // MeusFavos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.panel1);
            this.Name = "MeusFavos";
            this.Text = "MeusFavos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button VoltarBtn;
        private Panel panel1;
        private Label label1;
        private Button AdcAosfavoritos;
        private TextBox BuscaFavoritos;
        private ListView listView1;
    }
}