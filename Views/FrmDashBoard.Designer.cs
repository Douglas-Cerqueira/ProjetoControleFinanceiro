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
            button1 = new Button();
            textBox1 = new TextBox();
            comboBox3 = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            comboBox2 = new ComboBox();
            label8 = new Label();
            comboBox1 = new ComboBox();
            label7 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label6 = new Label();
            label5 = new Label();
            dgvTransacoes = new DataGridView();
            DataTransacao = new DataGridViewTextBoxColumn();
            Valor = new DataGridViewTextBoxColumn();
            FormaPagamento = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Descricao = new DataGridViewTextBoxColumn();
            button2 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            TabFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransacoes).BeginInit();
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
            TabFiltros.Controls.Add(button1);
            TabFiltros.Controls.Add(textBox1);
            TabFiltros.Controls.Add(comboBox3);
            TabFiltros.Controls.Add(label10);
            TabFiltros.Controls.Add(label9);
            TabFiltros.Controls.Add(comboBox2);
            TabFiltros.Controls.Add(label8);
            TabFiltros.Controls.Add(comboBox1);
            TabFiltros.Controls.Add(label7);
            TabFiltros.Controls.Add(dateTimePicker2);
            TabFiltros.Controls.Add(dateTimePicker1);
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
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(778, 58);
            button1.Name = "button1";
            button1.Size = new Size(154, 30);
            button1.TabIndex = 8;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(464, 63);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(298, 23);
            textBox1.TabIndex = 9;
            // 
            // comboBox3
            // 
            comboBox3.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(195, 63);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(154, 23);
            comboBox3.Sorted = true;
            comboBox3.TabIndex = 17;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(370, 63);
            label10.Name = "label10";
            label10.Size = new Size(88, 21);
            label10.TabIndex = 8;
            label10.Text = "Descrição:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(8, 61);
            label9.Name = "label9";
            label9.Size = new Size(181, 21);
            label9.TabIndex = 16;
            label9.Text = "Forma de Pagamento: ";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(778, 17);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(154, 23);
            comboBox2.Sorted = true;
            comboBox2.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(701, 16);
            label8.Name = "label8";
            label8.Size = new Size(61, 21);
            label8.TabIndex = 14;
            label8.Text = "Status:";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(513, 16);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(154, 23);
            comboBox1.Sorted = true;
            comboBox1.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(419, 15);
            label7.Name = "label7";
            label7.Size = new Size(88, 21);
            label7.TabIndex = 12;
            label7.Text = "Categoria:";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(308, 14);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(96, 23);
            dateTimePicker2.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(109, 13);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(97, 23);
            dateTimePicker1.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(212, 14);
            label6.Name = "label6";
            label6.Size = new Size(97, 21);
            label6.TabIndex = 9;
            label6.Text = "Data Início:";
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
            dgvTransacoes.Columns.AddRange(new DataGridViewColumn[] { DataTransacao, Valor, FormaPagamento, Categoria, Status, Descricao });
            dgvTransacoes.Location = new Point(4, 304);
            dgvTransacoes.Name = "dgvTransacoes";
            dgvTransacoes.ReadOnly = true;
            dgvTransacoes.Size = new Size(945, 340);
            dgvTransacoes.TabIndex = 8;
            // 
            // DataTransacao
            // 
            DataTransacao.HeaderText = "Data Da Transação";
            DataTransacao.Name = "DataTransacao";
            DataTransacao.ReadOnly = true;
            DataTransacao.Width = 150;
            // 
            // Valor
            // 
            Valor.HeaderText = "Valor";
            Valor.Name = "Valor";
            Valor.ReadOnly = true;
            // 
            // FormaPagamento
            // 
            FormaPagamento.HeaderText = "Forma De Pagamento";
            FormaPagamento.Name = "FormaPagamento";
            FormaPagamento.ReadOnly = true;
            FormaPagamento.Width = 150;
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            Categoria.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // Descricao
            // 
            Descricao.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descricao.HeaderText = "Descrição";
            Descricao.Name = "Descricao";
            Descricao.ReadOnly = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(4, 651);
            button2.Name = "button2";
            button2.Size = new Size(239, 30);
            button2.TabIndex = 18;
            button2.Text = "Adicionar Transação";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(249, 651);
            button3.Name = "button3";
            button3.Size = new Size(271, 30);
            button3.TabIndex = 19;
            button3.Text = "Adicionar Categoria";
            button3.UseVisualStyleBackColor = true;
            // 
            // FrmDashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(954, 693);
            Controls.Add(button3);
            Controls.Add(button2);
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            TabFiltros.ResumeLayout(false);
            TabFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTransacoes).EndInit();
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
        private DateTimePicker dateTimePicker1;
        private Label label6;
        private Label label5;
        private Button button1;
        private TextBox textBox1;
        private ComboBox comboBox3;
        private Label label10;
        private Label label9;
        private ComboBox comboBox2;
        private Label label8;
        private ComboBox comboBox1;
        private Label label7;
        private DateTimePicker dateTimePicker2;
        private DataGridView dgvTransacoes;
        private Button button2;
        private Button button3;
        private DataGridViewTextBoxColumn DataTransacao;
        private DataGridViewTextBoxColumn Valor;
        private DataGridViewTextBoxColumn FormaPagamento;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Descricao;
    }
}