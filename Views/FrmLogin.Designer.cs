namespace ProjetoControleFinanceiro
{
    partial class FrmLogin
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            txtEmailLogin = new TextBox();
            txtSenhaLogin = new TextBox();
            label3 = new Label();
            btnEntrar = new Button();
            btnCadastrar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-3, -4);
            panel1.Name = "panel1";
            panel1.Size = new Size(492, 105);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(15, 26);
            label1.Name = "label1";
            label1.Size = new Size(432, 65);
            label1.TabIndex = 0;
            label1.Text = "Realize seu Login!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(12, 134);
            label2.Name = "label2";
            label2.Size = new Size(105, 37);
            label2.TabIndex = 1;
            label2.Text = "E-mail:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // txtEmailLogin
            // 
            txtEmailLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailLogin.Location = new Point(123, 136);
            txtEmailLogin.Name = "txtEmailLogin";
            txtEmailLogin.Size = new Size(306, 35);
            txtEmailLogin.TabIndex = 1;
            // 
            // txtSenhaLogin
            // 
            txtSenhaLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenhaLogin.Location = new Point(123, 209);
            txtSenhaLogin.Name = "txtSenhaLogin";
            txtSenhaLogin.PasswordChar = '*';
            txtSenhaLogin.Size = new Size(306, 35);
            txtSenhaLogin.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(16, 207);
            label3.Name = "label3";
            label3.Size = new Size(101, 37);
            label3.TabIndex = 3;
            label3.Text = "Senha:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // btnEntrar
            // 
            btnEntrar.BackColor = Color.White;
            btnEntrar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEntrar.Location = new Point(334, 287);
            btnEntrar.Name = "btnEntrar";
            btnEntrar.Size = new Size(95, 38);
            btnEntrar.TabIndex = 4;
            btnEntrar.Text = "Entrar";
            btnEntrar.UseVisualStyleBackColor = false;
            btnEntrar.Click += btnEntrar_Click;
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.White;
            btnCadastrar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrar.Location = new Point(12, 287);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(118, 38);
            btnCadastrar.TabIndex = 3;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.TextAlign = ContentAlignment.TopCenter;
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // FrmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(441, 343);
            Controls.Add(btnCadastrar);
            Controls.Add(btnEntrar);
            Controls.Add(txtSenhaLogin);
            Controls.Add(label3);
            Controls.Add(txtEmailLogin);
            Controls.Add(label2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tela Login ...";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnEntrar;
        private Button btnCadastrar;
        public TextBox txtEmailLogin;
        public TextBox txtSenhaLogin;
    }
}
