namespace ProjetoIntegrador
{
    partial class RankDescricao
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
            this.ListaRankDescricao = new System.Windows.Forms.ListView();
            this.VoltarJnl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListaRankDescricao
            // 
            this.ListaRankDescricao.Location = new System.Drawing.Point(59, 12);
            this.ListaRankDescricao.Name = "ListaRankDescricao";
            this.ListaRankDescricao.Size = new System.Drawing.Size(665, 441);
            this.ListaRankDescricao.TabIndex = 0;
            this.ListaRankDescricao.UseCompatibleStateImageBehavior = false;
            // 
            // VoltarJnl
            // 
            this.VoltarJnl.Location = new System.Drawing.Point(730, 403);
            this.VoltarJnl.Name = "VoltarJnl";
            this.VoltarJnl.Size = new System.Drawing.Size(61, 31);
            this.VoltarJnl.TabIndex = 1;
            this.VoltarJnl.Text = "Voltar";
            this.VoltarJnl.UseVisualStyleBackColor = true;
            this.VoltarJnl.Click += new System.EventHandler(this.VoltarJnl_Click_1);
            // 
            // RankDescricao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VoltarJnl);
            this.Controls.Add(this.ListaRankDescricao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RankDescricao";
            this.Text = "RankDescricao";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView ListaRankDescricao;
        private Button VoltarJnl;
    }
}