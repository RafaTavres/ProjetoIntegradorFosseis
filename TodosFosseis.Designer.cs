namespace ProjetoIntegrador
{
    partial class TodosFosseis
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ListaFosseis = new System.Windows.Forms.ListView();
            this.VoltarUsuario = new System.Windows.Forms.Button();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.BuscarTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.ListaFosseis);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.VoltarUsuario);
            this.splitContainer1.Panel2.Controls.Add(this.BuscarButton);
            this.splitContainer1.Panel2.Controls.Add(this.BuscarTxt);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 600;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved_1);
            // 
            // ListaFosseis
            // 
            this.ListaFosseis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListaFosseis.Location = new System.Drawing.Point(25, 0);
            this.ListaFosseis.Name = "ListaFosseis";
            this.ListaFosseis.Size = new System.Drawing.Size(568, 450);
            this.ListaFosseis.TabIndex = 0;
            this.ListaFosseis.UseCompatibleStateImageBehavior = false;
            this.ListaFosseis.SelectedIndexChanged += new System.EventHandler(this.ListaFosseis_SelectedIndexChanged);
            // 
            // VoltarUsuario
            // 
            this.VoltarUsuario.Location = new System.Drawing.Point(3, 89);
            this.VoltarUsuario.Name = "VoltarUsuario";
            this.VoltarUsuario.Size = new System.Drawing.Size(78, 23);
            this.VoltarUsuario.TabIndex = 0;
            this.VoltarUsuario.Text = "Voltar";
            this.VoltarUsuario.UseVisualStyleBackColor = true;
            this.VoltarUsuario.Click += new System.EventHandler(this.VoltarUsuario_Click);
            // 
            // BuscarButton
            // 
            this.BuscarButton.Location = new System.Drawing.Point(3, 60);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(78, 23);
            this.BuscarButton.TabIndex = 2;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // BuscarTxt
            // 
            this.BuscarTxt.Location = new System.Drawing.Point(3, 12);
            this.BuscarTxt.Name = "BuscarTxt";
            this.BuscarTxt.Size = new System.Drawing.Size(190, 23);
            this.BuscarTxt.TabIndex = 1;
            this.BuscarTxt.TextChanged += new System.EventHandler(this.BuscarTxt_TextChanged);
            // 
            // TodosFosseis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TodosFosseis";
            this.Text = "TodosFosseis";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SplitContainer splitContainer1;
        private ListView ListaFosseis;
        private Button VoltarUsuario;
        private Button BuscarButton;
        private TextBox BuscarTxt;
    }
}