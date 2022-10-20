namespace ProjetoIntegrador
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.LoginUsuarioBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SairBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NovoUsuarioButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 33);
            this.button2.TabIndex = 6;
            this.button2.Text = "Novo Pesquisador";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 31);
            this.button3.TabIndex = 7;
            this.button3.Text = "Login Pesquisador";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // LoginUsuarioBtn
            // 
            this.LoginUsuarioBtn.Location = new System.Drawing.Point(12, 142);
            this.LoginUsuarioBtn.Name = "LoginUsuarioBtn";
            this.LoginUsuarioBtn.Size = new System.Drawing.Size(120, 33);
            this.LoginUsuarioBtn.TabIndex = 8;
            this.LoginUsuarioBtn.Text = "Login Usuário";
            this.LoginUsuarioBtn.UseVisualStyleBackColor = true;
            this.LoginUsuarioBtn.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.SairBtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.NovoUsuarioButton);
            this.panel1.Controls.Add(this.LoginUsuarioBtn);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 615);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Location = new System.Drawing.Point(227, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(885, 114);
            this.panel2.TabIndex = 10;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // SairBtn
            // 
            this.SairBtn.Location = new System.Drawing.Point(133, 563);
            this.SairBtn.Name = "SairBtn";
            this.SairBtn.Size = new System.Drawing.Size(74, 35);
            this.SairBtn.TabIndex = 14;
            this.SairBtn.Text = "Sair";
            this.SairBtn.UseVisualStyleBackColor = true;
            this.SairBtn.Click += new System.EventHandler(this.SairBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(3, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Pesquisador";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Usuário";
            // 
            // NovoUsuarioButton
            // 
            this.NovoUsuarioButton.Location = new System.Drawing.Point(12, 108);
            this.NovoUsuarioButton.Name = "NovoUsuarioButton";
            this.NovoUsuarioButton.Size = new System.Drawing.Size(120, 28);
            this.NovoUsuarioButton.TabIndex = 11;
            this.NovoUsuarioButton.Text = "Novo Usuário";
            this.NovoUsuarioButton.UseVisualStyleBackColor = true;
            this.NovoUsuarioButton.Click += new System.EventHandler(this.NovoUsuarioButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel3.Location = new System.Drawing.Point(222, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(876, 375);
            this.panel3.TabIndex = 10;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1101, 611);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjetoIntegrador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Button button2;
        private Button button3;
        private Button LoginUsuarioBtn;
        private Panel panel1;
        private Panel panel2;
        private Button NovoUsuarioButton;
        private Label label2;
        private Label label1;
        private Button SairBtn;
        private Panel panel3;
    }
}