namespace ProjetoControleFinanceiro.Views
{
    partial class FrmCategoria
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
            label2 = new Label();
            btnCancelar = new Button();
            btnAdicionar = new Button();
            txtCategoria = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-10, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(562, 105);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(22, 24);
            label1.Name = "label1";
            label1.Size = new Size(441, 50);
            label1.TabIndex = 0;
            label1.Text = "Adicione uma Categoria";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 121);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 3;
            label2.Text = "Nome:";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 162);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 5;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAdicionar
            // 
            btnAdicionar.DialogResult = DialogResult.OK;
            btnAdicionar.Location = new Point(373, 162);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 6;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(79, 123);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(369, 23);
            txtCategoria.TabIndex = 7;
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 197);
            Controls.Add(txtCategoria);
            Controls.Add(btnAdicionar);
            Controls.Add(btnCancelar);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "FrmCategoria";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Adicionar Categorias";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Button btnCancelar;
        private Button btnAdicionar;
        public TextBox txtCategoria;
    }
}