namespace ProjetoControleFinanceiro.Views
{
    partial class FrmDashBoard
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
            label3 = new Label();
            label4 = new Label();
            txtSaldo = new TextBox();
            txtReceitas = new TextBox();
            txtDespesas = new TextBox();
            tabControl1 = new TabControl();
            TabFiltros = new TabPage();
            btnExcluirCategoria = new Button();
            btnEditarCategoria = new Button();
            btnBuscar = new Button();
            txtDescricao = new TextBox();
            cbxPagamento = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            cbxStatus = new ComboBox();
            label8 = new Label();
            cbxCategoria = new ComboBox();
            label7 = new Label();
            dtpDataFim = new DateTimePicker();
            dtpDataInicio = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            dgvTransacoes = new DataGridView();
            DataTransacao = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            FormaPagamento = new DataGridViewTextBoxColumn();
            NomeCategoria = new DataGridViewTextBoxColumn();
            ValorTransacao = new DataGridViewTextBoxColumn();
            DescricaoTransacao = new DataGridViewTextBoxColumn();
            btnAdicionarTransacao = new Button();
            btnAdicionarCategoria = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            txtData = new ToolStripStatusLabel();
            toolStripStatusLabel3 = new ToolStripStatusLabel();
            toolStripStatusLabel4 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            txtUsuario = new ToolStripStatusLabel();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            TabFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransacoes).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(953, 115);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(134, 9);
            label1.Name = "label1";
            label1.Size = new Size(692, 86);
            label1.TabIndex = 0;
            label1.Text = "DashBoard Financeiro";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(48, 142);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 1;
            label2.Text = "Saldo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(640, 144);
            label3.Name = "label3";
            label3.Size = new Size(126, 21);
            label3.TabIndex = 2;
            label3.Text = "Total Despesas:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Lime;
            label4.Location = new Point(312, 144);
            label4.Name = "label4";
            label4.Size = new Size(119, 21);
            label4.TabIndex = 3;
            label4.Text = "Total Receitas:";
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(120, 142);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(100, 23);
            txtSaldo.TabIndex = 4;
            // 
            // txtReceitas
            // 
            txtReceitas.Location = new Point(451, 144);
            txtReceitas.Name = "txtReceitas";
            txtReceitas.Size = new Size(100, 23);
            txtReceitas.TabIndex = 5;
            // 
            // txtDespesas
            // 
            txtDespesas.Location = new Point(787, 144);
            txtDespesas.Name = "txtDespesas";
            txtDespesas.Size = new Size(100, 23);
            txtDespesas.TabIndex = 6;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TabFiltros);
            tabControl1.Location = new Point(0, 171);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(953, 127);
            tabControl1.TabIndex = 7;
            // 
            // TabFiltros
            // 
            TabFiltros.Controls.Add(btnExcluirCategoria);
            TabFiltros.Controls.Add(btnEditarCategoria);
            TabFiltros.Controls.Add(btnBuscar);
            TabFiltros.Controls.Add(txtDescricao);
            TabFiltros.Controls.Add(cbxPagamento);
            TabFiltros.Controls.Add(label10);
            TabFiltros.Controls.Add(label9);
            TabFiltros.Controls.Add(cbxStatus);
            TabFiltros.Controls.Add(label8);
            TabFiltros.Controls.Add(cbxCategoria);
            TabFiltros.Controls.Add(label7);
            TabFiltros.Controls.Add(dtpDataFim);
            TabFiltros.Controls.Add(dtpDataInicio);
            TabFiltros.Controls.Add(label6);
            TabFiltros.Controls.Add(label5);
            TabFiltros.Location = new Point(4, 24);
            TabFiltros.Name = "TabFiltros";
            TabFiltros.Padding = new Padding(3);
            TabFiltros.Size = new Size(945, 99);
            TabFiltros.TabIndex = 0;
            TabFiltros.Text = "Filtros:";
            TabFiltros.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCategoria
            // 
            btnExcluirCategoria.Image = Properties.Resources.delete__1_;
            btnExcluirCategoria.Location = new Point(748, 14);
            btnExcluirCategoria.Name = "btnExcluirCategoria";
            btnExcluirCategoria.Size = new Size(31, 25);
            btnExcluirCategoria.TabIndex = 19;
            btnExcluirCategoria.UseVisualStyleBackColor = true;
            btnExcluirCategoria.Click += btnExcluirCategoria_Click_1;
            // 
            // btnEditarCategoria
            // 
            btnEditarCategoria.Image = Properties.Resources.edit__1_;
            btnEditarCategoria.Location = new Point(711, 14);
            btnEditarCategoria.Name = "btnEditarCategoria";
            btnEditarCategoria.Size = new Size(31, 25);
            btnEditarCategoria.TabIndex = 18;
            btnEditarCategoria.UseVisualStyleBackColor = true;
            btnEditarCategoria.Click += btnEditarCategoria_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.Location = new Point(818, 9);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(106, 30);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(622, 65);
            txtDescricao.Name = "txtDescricao";
            txtDescricao.Size = new Size(302, 23);
            txtDescricao.TabIndex = 9;
            // 
            // cbxPagamento
            // 
            cbxPagamento.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPagamento.FormattingEnabled = true;
            cbxPagamento.Location = new Point(368, 65);
            cbxPagamento.Name = "cbxPagamento";
            cbxPagamento.Size = new Size(154, 23);
            cbxPagamento.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(528, 65);
            label10.Name = "label10";
            label10.Size = new Size(88, 21);
            label10.TabIndex = 8;
            label10.Text = "Descrição:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(181, 67);
            label9.Name = "label9";
            label9.Size = new Size(181, 21);
            label9.TabIndex = 16;
            label9.Text = "Forma de Pagamento: ";
            // 
            // cbxStatus
            // 
            cbxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxStatus.FormattingEnabled = true;
            cbxStatus.Location = new Point(75, 67);
            cbxStatus.Name = "cbxStatus";
            cbxStatus.Size = new Size(100, 23);
            cbxStatus.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(8, 67);
            label8.Name = "label8";
            label8.Size = new Size(61, 21);
            label8.TabIndex = 14;
            label8.Text = "Status:";
            // 
            // cbxCategoria
            // 
            cbxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxCategoria.FormattingEnabled = true;
            cbxCategoria.Location = new Point(504, 14);
            cbxCategoria.Name = "cbxCategoria";
            cbxCategoria.Size = new Size(201, 23);
            cbxCategoria.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(410, 14);
            label7.Name = "label7";
            label7.Size = new Size(88, 21);
            label7.TabIndex = 12;
            label7.Text = "Categoria:";
            // 
            // dtpDataFim
            // 
            dtpDataFim.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDataFim.Format = DateTimePickerFormat.Short;
            dtpDataFim.Location = new Point(308, 14);
            dtpDataFim.Name = "dtpDataFim";
            dtpDataFim.Size = new Size(96, 23);
            dtpDataFim.TabIndex = 11;
            // 
            // dtpDataInicio
            // 
            dtpDataInicio.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDataInicio.Format = DateTimePickerFormat.Short;
            dtpDataInicio.Location = new Point(109, 13);
            dtpDataInicio.Name = "dtpDataInicio";
            dtpDataInicio.Size = new Size(97, 23);
            dtpDataInicio.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(220, 14);
            label6.Name = "label6";
            label6.Size = new Size(82, 21);
            label6.TabIndex = 9;
            label6.Text = "Data Fim:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(6, 14);
            label5.Name = "label5";
            label5.Size = new Size(97, 21);
            label5.TabIndex = 8;
            label5.Text = "Data Início:";
            // 
            // dgvTransacoes
            // 
            dgvTransacoes.AllowUserToAddRows = false;
            dgvTransacoes.AllowUserToDeleteRows = false;
            dgvTransacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransacoes.Columns.AddRange(new DataGridViewColumn[] { DataTransacao, Status, FormaPagamento, NomeCategoria, ValorTransacao, DescricaoTransacao });
            dgvTransacoes.Location = new Point(0, 305);
            dgvTransacoes.Name = "dgvTransacoes";
            dgvTransacoes.ReadOnly = true;
            dgvTransacoes.Size = new Size(945, 340);
            dgvTransacoes.TabIndex = 8;
            // 
            // DataTransacao
            // 
            DataTransacao.DataPropertyName = "DataTransacao";
            DataTransacao.HeaderText = "Data da Transação";
            DataTransacao.Name = "DataTransacao";
            DataTransacao.ReadOnly = true;
            DataTransacao.Width = 160;
            // 
            // Status
            // 
            Status.DataPropertyName = "Status";
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // FormaPagamento
            // 
            FormaPagamento.DataPropertyName = "FormaPagamento";
            FormaPagamento.HeaderText = "Forma de Pagamento";
            FormaPagamento.Name = "FormaPagamento";
            FormaPagamento.ReadOnly = true;
            FormaPagamento.Width = 160;
            // 
            // NomeCategoria
            // 
            NomeCategoria.DataPropertyName = "NomeCategoria";
            NomeCategoria.HeaderText = "Categoria";
            NomeCategoria.Name = "NomeCategoria";
            NomeCategoria.ReadOnly = true;
            // 
            // ValorTransacao
            // 
            ValorTransacao.DataPropertyName = "ValorTransacao";
            ValorTransacao.HeaderText = "Valor da Transação";
            ValorTransacao.Name = "ValorTransacao";
            ValorTransacao.ReadOnly = true;
            ValorTransacao.Width = 150;
            // 
            // DescricaoTransacao
            // 
            DescricaoTransacao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            DescricaoTransacao.DataPropertyName = "DescricaoTransacao";
            DescricaoTransacao.HeaderText = "Descrição";
            DescricaoTransacao.Name = "DescricaoTransacao";
            DescricaoTransacao.ReadOnly = true;
            // 
            // btnAdicionarTransacao
            // 
            btnAdicionarTransacao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarTransacao.Location = new Point(4, 651);
            btnAdicionarTransacao.Name = "btnAdicionarTransacao";
            btnAdicionarTransacao.Size = new Size(239, 30);
            btnAdicionarTransacao.TabIndex = 18;
            btnAdicionarTransacao.Text = "Adicionar Transação";
            btnAdicionarTransacao.UseVisualStyleBackColor = true;
            btnAdicionarTransacao.Click += btnAdicionarTransacao_Click;
            // 
            // btnAdicionarCategoria
            // 
            btnAdicionarCategoria.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarCategoria.Location = new Point(249, 650);
            btnAdicionarCategoria.Name = "btnAdicionarCategoria";
            btnAdicionarCategoria.Size = new Size(213, 32);
            btnAdicionarCategoria.TabIndex = 19;
            btnAdicionarCategoria.Text = "Adicionar Categoria";
            btnAdicionarCategoria.UseVisualStyleBackColor = true;
            btnAdicionarCategoria.Click += btnAdicionarCategoria_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, txtData, toolStripStatusLabel3, toolStripStatusLabel4, toolStripStatusLabel2, txtUsuario });
            statusStrip1.Location = new Point(0, 686);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(954, 22);
            statusStrip1.TabIndex = 20;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(68, 17);
            toolStripStatusLabel1.Text = "Data Atual: ";
            // 
            // txtData
            // 
            txtData.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtData.Name = "txtData";
            txtData.Size = new Size(73, 17);
            txtData.Text = "10/06/2025";
            // 
            // toolStripStatusLabel3
            // 
            toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            toolStripStatusLabel3.Size = new Size(67, 17);
            toolStripStatusLabel3.Text = "Hora Atual:";
            // 
            // toolStripStatusLabel4
            // 
            toolStripStatusLabel4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            toolStripStatusLabel4.Size = new Size(38, 17);
            toolStripStatusLabel4.Text = "14:16";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(93, 17);
            toolStripStatusLabel2.Text = "Usuário Logado:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(51, 17);
            txtUsuario.Text = "Douglas";
            // 
            // FrmDashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(954, 708);
            Controls.Add(statusStrip1);
            Controls.Add(btnAdicionarCategoria);
            Controls.Add(btnAdicionarTransacao);
            Controls.Add(dgvTransacoes);
            Controls.Add(tabControl1);
            Controls.Add(txtDespesas);
            Controls.Add(txtReceitas);
            Controls.Add(txtSaldo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FrmDashBoard";
            Text = "DashBoard ...";
            Load += FrmDashBoard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            TabFiltros.ResumeLayout(false);
            TabFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransacoes).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtSaldo;
        private TextBox txtReceitas;
        private TextBox txtDespesas;
        private TabControl tabControl1;
        private TabPage TabFiltros;
        private Label label6;
        private Label label5;
        private Button btnBuscar;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btnAdicionarTransacao;
        private Button btnAdicionarCategoria;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel txtData;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel txtUsuario;
        public DateTimePicker dtpDataInicio;
        public TextBox txtDescricao;
        public ComboBox cbxPagamento;
        public ComboBox cbxStatus;
        public ComboBox cbxCategoria;
        public DateTimePicker dtpDataFim;
        private Button btnExcluirCategoria;
        private Button btnEditarCategoria;
        public DataGridView dgvTransacoes;
        private DataGridViewTextBoxColumn DataTransacao;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn FormaPagamento;
        private DataGridViewTextBoxColumn NomeCategoria;
        private DataGridViewTextBoxColumn ValorTransacao;
        private DataGridViewTextBoxColumn DescricaoTransacao;
    }
}