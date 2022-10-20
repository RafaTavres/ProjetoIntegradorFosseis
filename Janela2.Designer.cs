namespace ProjetoIntegrador
{
    partial class NovoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovoUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.VoltarBtn = new System.Windows.Forms.Button();
            this.Senha = new System.Windows.Forms.Label();
            this.SenhaTxt = new System.Windows.Forms.TextBox();
            this.Cpf = new System.Windows.Forms.Label();
            this.CpfTxt = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.NomeTxt = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.VoltarBtn);
            this.panel1.Controls.Add(this.Senha);
            this.panel1.Controls.Add(this.SenhaTxt);
            this.panel1.Controls.Add(this.Cpf);
            this.panel1.Controls.Add(this.CpfTxt);
            this.panel1.Controls.Add(this.Save);
            this.panel1.Controls.Add(this.NomeTxt);
            this.panel1.Controls.Add(this.Nome);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // VoltarBtn
            // 
            resources.ApplyResources(this.VoltarBtn, "VoltarBtn");
            this.VoltarBtn.Name = "VoltarBtn";
            this.VoltarBtn.UseVisualStyleBackColor = true;
            this.VoltarBtn.Click += new System.EventHandler(this.VoltarBtn_Click);
            // 
            // Senha
            // 
            resources.ApplyResources(this.Senha, "Senha");
            this.Senha.Name = "Senha";
            this.Senha.Click += new System.EventHandler(this.Senha_Click);
            // 
            // SenhaTxt
            // 
            resources.ApplyResources(this.SenhaTxt, "SenhaTxt");
            this.SenhaTxt.Name = "SenhaTxt";
            // 
            // Cpf
            // 
            resources.ApplyResources(this.Cpf, "Cpf");
            this.Cpf.Name = "Cpf";
            // 
            // CpfTxt
            // 
            resources.ApplyResources(this.CpfTxt, "CpfTxt");
            this.CpfTxt.Name = "CpfTxt";
            this.CpfTxt.TextChanged += new System.EventHandler(this.CpfTxt_TextChanged);
            // 
            // Save
            // 
            resources.ApplyResources(this.Save, "Save");
            this.Save.Name = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // NomeTxt
            // 
            resources.ApplyResources(this.NomeTxt, "NomeTxt");
            this.NomeTxt.Name = "NomeTxt";
            this.NomeTxt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Nome
            // 
            resources.ApplyResources(this.Nome, "Nome");
            this.Nome.Name = "Nome";
            // 
            // NovoUsuario
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NovoUsuario";
            this.Load += new System.EventHandler(this.Janela2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox NomeTxt;
        private Label Nome;
        private Button Save;
        private Label Senha;
        private TextBox SenhaTxt;
        private Label Cpf;
        private TextBox CpfTxt;
        private Button VoltarBtn;
    }
}