namespace ProjetoIntegrador
{
    partial class MenuSobre
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
            this.Sobre1 = new System.Windows.Forms.Label();
            this.Sobre = new System.Windows.Forms.Label();
            this.VoltarSobre = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.VoltarSobre);
            this.panel1.Controls.Add(this.Sobre1);
            this.panel1.Controls.Add(this.Sobre);
            this.panel1.Location = new System.Drawing.Point(6, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 440);
            this.panel1.TabIndex = 0;
            // 
            // Sobre1
            // 
            this.Sobre1.AutoSize = true;
            this.Sobre1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Sobre1.Location = new System.Drawing.Point(17, 49);
            this.Sobre1.Name = "Sobre1";
            this.Sobre1.Size = new System.Drawing.Size(62, 15);
            this.Sobre1.TabIndex = 1;
            this.Sobre1.Text = "Versão: 2.0";
            // 
            // Sobre
            // 
            this.Sobre.AutoSize = true;
            this.Sobre.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.Sobre.Location = new System.Drawing.Point(17, 34);
            this.Sobre.Name = "Sobre";
            this.Sobre.Size = new System.Drawing.Size(161, 15);
            this.Sobre.TabIndex = 0;
            this.Sobre.Text = "Sobre: Criador Rafael Tavares ";
            // 
            // VoltarSobre
            // 
            this.VoltarSobre.Location = new System.Drawing.Point(17, 384);
            this.VoltarSobre.Name = "VoltarSobre";
            this.VoltarSobre.Size = new System.Drawing.Size(95, 37);
            this.VoltarSobre.TabIndex = 2;
            this.VoltarSobre.Text = "Voltar";
            this.VoltarSobre.UseVisualStyleBackColor = true;
            this.VoltarSobre.Click += new System.EventHandler(this.VoltarSobre_Click);
            // 
            // MenuSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuSobre";
            this.Text = "MenuSobre";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label Sobre1;
        private Label Sobre;
        private Button VoltarSobre;
    }
}