namespace ProjetoControleFinanceiro.Views
{
    partial class FrmTransacoes
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
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            dtpDataTransacao = new DateTimePicker();
            label3 = new Label();
            cbxStatus = new ComboBox();
            cbxCategoria = new ComboBox();
            label4 = new Label();
            cbxPagamento = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            txtValor = new TextBox();
            label7 = new Label();
            txtDescricao = new TextBox();
            btnAdicionar = new Button();
            btnCancelar = new Button();
            btnExcluir = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(11, 19);
            label2.Name = "label2";
            label2.Size = new Size(552, 65);
            label2.TabIndex = 0;
            label2.Text = "Adicione sua Transação";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(574, 105);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 132);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 2;
            label1.Text = "Data da Transação:";
            // 
            // dtpDataTransacao
            // 
            dtpDataTransacao.Format = DateTimePickerFormat.Short;
            dtpDataTransacao.Location = new Point(120, 128);
            dtpDataTransacao.Name = "dtpDataTransacao";
            dtpDataTransacao.Size = new Size(97, 23);
            dtpDataTransacao.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(223, 132);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 4;
            label3.Text = "Status:";
            // 
            // cbxStatus
            // 
            cbxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Location = new Point(274, 128);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(105, 23);
            cbxStatus.TabIndex = 5;
            // 
            // cbxCategoria
            // 
            cbxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Location = new Point(448, 128);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(115, 23);
            cbxCategoria.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(385, 134);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 6;
            label4.Text = "Categoria:";
            // 
            // cbxPagamento
            // 
            cbxPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPagamento.FormattingEnabled = true;
            cbxPagamento.Location = new Point(149, 171);
            cbxPagamento.Name = "cbxPagamento";
            cbxPagamento.Size = new Size(105, 23);
            cbxPagamento.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 176);
            label5.Name = "label5";
            label5.Size = new Size(128, 15);
            label5.TabIndex = 8;
            label5.Text = "Forma de Pagamento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(270, 174);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 10;
            label6.Text = "Valor:";
            // 
            // txtValor
            // 
            txtValor.Location = new Point(314, 169);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(16, 214);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 12;
            label7.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(86, 208);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(477, 23);
            txtDescricao.TabIndex = 13;
            // 
            // btnAdicionar
            // 
            btnAdicionar.DialogResult = DialogResult.OK;
            btnAdicionar.Location = new Point(488, 247);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(75, 23);
            btnAdicionar.TabIndex = 14;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(12, 249);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 15;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(407, 247);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(75, 23);
            btnExcluir.TabIndex = 16;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            // 
            // FrmTransacoes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 284);
            Controls.Add(btnExcluir);
            Controls.Add(btnCancelar);
            Controls.Add(btnAdicionar);
            Controls.Add(txtDescricao);
            Controls.Add(label7);
            Controls.Add(txtValor);
            Controls.Add(label6);
            Controls.Add(cbxPagamento);
            Controls.Add(label5);
            Controls.Add(cbxCategoria);
            Controls.Add(label4);
            Controls.Add(cbxStatus);
            Controls.Add(label3);
            Controls.Add(dtpDataTransacao);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FrmTransacoes";
            Text = "Transações";
            Load += FrmTransacoes_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnAdicionar;
        private Button btnCancelar;
        private Button btnExcluir;
        public DateTimePicker dtpDataTransacao;
        public ComboBox cbxStatus;
        public ComboBox cbxCategoria;
        public ComboBox cbxPagamento;
        public TextBox txtValor;
        public TextBox txtDescricao;
    }
}