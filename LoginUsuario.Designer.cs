namespace ProjetoIntegrador
{
    partial class LoginUsuario
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
            this.BotaoLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Nometxt = new System.Windows.Forms.TextBox();
            this.CpfTxt = new System.Windows.Forms.Label();
            this.Cpftxt2 = new System.Windows.Forms.TextBox();
            this.SenhaTxt = new System.Windows.Forms.Label();
            this.Senhatxt2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BotaoVoltarLogin = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BotaoLogin
            // 
            this.BotaoLogin.Location = new System.Drawing.Point(155, 366);
            this.BotaoLogin.Name = "BotaoLogin";
            this.BotaoLogin.Size = new System.Drawing.Size(87, 39);
            this.BotaoLogin.TabIndex = 0;
            this.BotaoLogin.Text = "Login";
            this.BotaoLogin.UseVisualStyleBackColor = true;
            this.BotaoLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // Nometxt
            // 
            this.Nometxt.Location = new System.Drawing.Point(41, 71);
            this.Nometxt.Name = "Nometxt";
            this.Nometxt.Size = new System.Drawing.Size(101, 23);
            this.Nometxt.TabIndex = 2;
            this.Nometxt.TextChanged += new System.EventHandler(this.Nometxt_TextChanged);
            // 
            // CpfTxt
            // 
            this.CpfTxt.AutoSize = true;
            this.CpfTxt.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CpfTxt.Location = new System.Drawing.Point(41, 123);
            this.CpfTxt.Name = "CpfTxt";
            this.CpfTxt.Size = new System.Drawing.Size(42, 25);
            this.CpfTxt.TabIndex = 3;
            this.CpfTxt.Text = "Cpf";
            // 
            // Cpftxt2
            // 
            this.Cpftxt2.Location = new System.Drawing.Point(42, 152);
            this.Cpftxt2.Name = "Cpftxt2";
            this.Cpftxt2.Size = new System.Drawing.Size(100, 23);
            this.Cpftxt2.TabIndex = 4;
            this.Cpftxt2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // SenhaTxt
            // 
            this.SenhaTxt.AutoSize = true;
            this.SenhaTxt.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SenhaTxt.Location = new System.Drawing.Point(42, 208);
            this.SenhaTxt.Name = "SenhaTxt";
            this.SenhaTxt.Size = new System.Drawing.Size(64, 25);
            this.SenhaTxt.TabIndex = 5;
            this.SenhaTxt.Text = "Senha";
            // 
            // Senhatxt2
            // 
            this.Senhatxt2.Location = new System.Drawing.Point(42, 245);
            this.Senhatxt2.Name = "Senhatxt2";
            this.Senhatxt2.PasswordChar = '*';
            this.Senhatxt2.Size = new System.Drawing.Size(100, 23);
            this.Senhatxt2.TabIndex = 6;
            this.Senhatxt2.TextChanged += new System.EventHandler(this.Senhatxt2_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.BotaoVoltarLogin);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BotaoLogin);
            this.panel1.Controls.Add(this.Senhatxt2);
            this.panel1.Controls.Add(this.CpfTxt);
            this.panel1.Controls.Add(this.SenhaTxt);
            this.panel1.Controls.Add(this.Nometxt);
            this.panel1.Controls.Add(this.Cpftxt2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 426);
            this.panel1.TabIndex = 7;
            // 
            // BotaoVoltarLogin
            // 
            this.BotaoVoltarLogin.Location = new System.Drawing.Point(10, 368);
            this.BotaoVoltarLogin.Name = "BotaoVoltarLogin";
            this.BotaoVoltarLogin.Size = new System.Drawing.Size(96, 37);
            this.BotaoVoltarLogin.TabIndex = 7;
            this.BotaoVoltarLogin.Text = "Voltar";
            this.BotaoVoltarLogin.UseVisualStyleBackColor = true;
            this.BotaoVoltarLogin.Click += new System.EventHandler(this.BotaoVoltarLogin_Click);
            // 
            // LoginUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginUsuario";
            this.Text = "LoginUsuario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button BotaoLogin;
        private Label label1;
        private TextBox Nometxt;
        private Label CpfTxt;
        private TextBox Cpftxt2;
        private Label SenhaTxt;
        private TextBox Senhatxt2;
        private Panel panel1;
        private Button BotaoVoltarLogin;
    }
}