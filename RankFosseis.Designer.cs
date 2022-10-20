namespace ProjetoIntegrador
{
    partial class RankFosseis
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
            this.ListaRankRegiao = new System.Windows.Forms.ListView();
            this.VoltarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListaRankRegiao
            // 
            this.ListaRankRegiao.Location = new System.Drawing.Point(173, 3);
            this.ListaRankRegiao.Name = "ListaRankRegiao";
            this.ListaRankRegiao.Size = new System.Drawing.Size(441, 449);
            this.ListaRankRegiao.TabIndex = 0;
            this.ListaRankRegiao.UseCompatibleStateImageBehavior = false;
            this.ListaRankRegiao.SelectedIndexChanged += new System.EventHandler(this.ListaRankRegiao_SelectedIndexChanged);
            // 
            // VoltarButton
            // 
            this.VoltarButton.Location = new System.Drawing.Point(620, 414);
            this.VoltarButton.Name = "VoltarButton";
            this.VoltarButton.Size = new System.Drawing.Size(101, 24);
            this.VoltarButton.TabIndex = 1;
            this.VoltarButton.Text = "Voltar";
            this.VoltarButton.UseVisualStyleBackColor = true;
            this.VoltarButton.Click += new System.EventHandler(this.VoltarButton_Click);
            // 
            // RankFosseis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VoltarButton);
            this.Controls.Add(this.ListaRankRegiao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RankFosseis";
            this.Text = "RankFosseis";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView ListaRankRegiao;
        private Button VoltarButton;
    }
}