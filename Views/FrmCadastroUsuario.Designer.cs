namespace ProjetoControleFinanceiro.Views
{
    partial class FrmCadastroUsuario
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
            panel1 = new Panel();
            label1 = new Label();
            txtSenhaCadastro = new TextBox();
            label3 = new Label();
            txtEmailCadastro = new TextBox();
            label2 = new Label();
            txtUsuario = new TextBox();
            label4 = new Label();
            btnCadastrarUsuario = new Button();
            btnConcluirCadastro = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(521, 105);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(505, 65);
            label1.TabIndex = 0;
            label1.Text = "Realize seu Cadastro!";
            // 
            // txtSenhaCadastro
            // 
            txtSenhaCadastro.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSenhaCadastro.Location = new Point(153, 269);
            txtSenhaCadastro.Name = "txtSenhaCadastro";
            txtSenhaCadastro.PasswordChar = '*';
            txtSenhaCadastro.Size = new Size(306, 35);
            txtSenhaCadastro.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(46, 267);
            label3.Name = "label3";
            label3.Size = new Size(101, 37);
            label3.TabIndex = 7;
            label3.Text = "Senha:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // txtEmailCadastro
            // 
            txtEmailCadastro.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmailCadastro.Location = new Point(153, 196);
            txtEmailCadastro.Name = "txtEmailCadastro";
            txtEmailCadastro.Size = new Size(306, 35);
            txtEmailCadastro.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ImageAlign = ContentAlignment.MiddleLeft;
            label2.Location = new Point(42, 196);
            label2.Name = "label2";
            label2.Size = new Size(105, 37);
            label2.TabIndex = 5;
            label2.Text = "E-mail:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(153, 135);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(306, 35);
            txtUsuario.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(45, 135);
            label4.Name = "label4";
            label4.Size = new Size(102, 37);
            label4.TabIndex = 9;
            label4.Text = "Nome:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // btnCadastrarUsuario
            // 
            btnCadastrarUsuario.BackColor = Color.White;
            btnCadastrarUsuario.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCadastrarUsuario.Location = new Point(46, 356);
            btnCadastrarUsuario.Name = "btnCadastrarUsuario";
            btnCadastrarUsuario.Size = new Size(118, 38);
            btnCadastrarUsuario.TabIndex = 4;
            btnCadastrarUsuario.Text = "Cancelar";
            btnCadastrarUsuario.UseVisualStyleBackColor = false;
            // 
            // btnConcluirCadastro
            // 
            btnConcluirCadastro.BackColor = Color.White;
            btnConcluirCadastro.DialogResult = DialogResult.OK;
            btnConcluirCadastro.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConcluirCadastro.Location = new Point(350, 356);
            btnConcluirCadastro.Name = "btnConcluirCadastro";
            btnConcluirCadastro.Size = new Size(109, 38);
            btnConcluirCadastro.TabIndex = 5;
            btnConcluirCadastro.Text = "Concluir";
            btnConcluirCadastro.UseVisualStyleBackColor = false;
            // 
            // FrmCadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(511, 426);
            Controls.Add(btnCadastrarUsuario);
            Controls.Add(btnConcluirCadastro);
            Controls.Add(txtUsuario);
            Controls.Add(label4);
            Controls.Add(txtSenhaCadastro);
            Controls.Add(label3);
            Controls.Add(txtEmailCadastro);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "FrmCadastroUsuario";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Cadastro de Usuário ...";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Button btnCadastrarUsuario;
        private Button btnConcluirCadastro;
        public TextBox txtSenhaCadastro;
        public TextBox txtEmailCadastro;
        public TextBox txtUsuario;
    }
}