namespace ProjetoIntegrador
{
    partial class NovoPesquisador
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
            this.SenhaTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CpfTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NomeTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.VoltarBtn2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SenhaTxt);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.CpfTxt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NomeTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SaveBtn);
            this.panel1.Controls.Add(this.VoltarBtn2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 401);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SenhaTxt
            // 
            this.SenhaTxt.Location = new System.Drawing.Point(26, 197);
            this.SenhaTxt.Name = "SenhaTxt";
            this.SenhaTxt.Size = new System.Drawing.Size(161, 23);
            this.SenhaTxt.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha";
            // 
            // CpfTxt
            // 
            this.CpfTxt.Location = new System.Drawing.Point(26, 116);
            this.CpfTxt.Name = "CpfTxt";
            this.CpfTxt.Size = new System.Drawing.Size(161, 23);
            this.CpfTxt.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cpf";
            // 
            // NomeTxt
            // 
            this.NomeTxt.Location = new System.Drawing.Point(26, 48);
            this.NomeTxt.Name = "NomeTxt";
            this.NomeTxt.Size = new System.Drawing.Size(161, 23);
            this.NomeTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(185, 322);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(91, 33);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "Salvar";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // VoltarBtn2
            // 
            this.VoltarBtn2.Location = new System.Drawing.Point(23, 322);
            this.VoltarBtn2.Name = "VoltarBtn2";
            this.VoltarBtn2.Size = new System.Drawing.Size(103, 33);
            this.VoltarBtn2.TabIndex = 0;
            this.VoltarBtn2.Text = "Voltar";
            this.VoltarBtn2.UseVisualStyleBackColor = true;
            this.VoltarBtn2.Click += new System.EventHandler(this.VoltarBtn2_Click);
            // 
            // NovoPesquisador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NovoPesquisador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Pesquisador";
            this.Load += new System.EventHandler(this.LoginUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button VoltarBtn2;
        private Button SaveBtn;
        private Label label3;
        private TextBox CpfTxt;
        private Label label2;
        private TextBox NomeTxt;
        private Label label1;
        private TextBox SenhaTxt;
    }
}