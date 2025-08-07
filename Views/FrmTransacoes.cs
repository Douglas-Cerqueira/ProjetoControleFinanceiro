using System.Data;
using System.Windows.Forms;
using ProjetoControleFinanceiro.ColetaInformacoes;
using ProjetoControleFinanceiro.Enums;
using ProjetoControleFinanceiro.Models;
using ProjetoControleFinanceiro.Services;
using ProjetoControleFinanceiro.Views;

namespace ProjetoControleFinanceiro.Views
{
    public partial class FrmTransacoes : Form
    {

        #region Properties
        private List<TransacoesModel> _transacoes = new List<TransacoesModel>();
        private readonly FrmDashBoard _frmPrincipal;
        private readonly TransacoesService _transacaoService = new TransacoesService();

        #endregion Properties

        #region Constructors

        public FrmTransacoes(FrmDashBoard frmPrincipal)
        {
            InitializeComponent();
            _frmPrincipal = frmPrincipal;
        }

        #endregion Constructors

        private void FrmTransacoes_Load(object sender, EventArgs e)
        {
            CarregaComboBox();
            CarregaStatus();
            CarregaFormasPagamento();
        }
        private void CarregaStatus()
        {
            cbxStatus.Items.AddRange(Enum.GetNames(typeof(StatusEnum)));
            cbxStatus.SelectedIndex = 0;
        }
        private void CarregaFormasPagamento()
        {
            cbxPagamento.Items.AddRange(Enum.GetNames(typeof(FormaPagamento)));
            cbxPagamento.SelectedIndex = 0;
        }
        private void CarregaComboBox()
        {
            var coleta = new CategoriaColetaInformacoes();
            var lista = coleta.ObterCategorias();
            cbxCategoria.DataSource = lista;
            cbxCategoria.DisplayMember = nameof(CategoriasModel.Nome);
            cbxCategoria.ValueMember = nameof(CategoriasModel.IdCategoria);
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {

                SalvarTransacao();



            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private async void SalvarTransacao()
        {
            if (!Validar())
            {
                return;
            }
            var transacao = CriarTransacao();

            await _transacaoService.AdicionarTransacao(transacao);
            _transacoes.Add(transacao);
            ConfigTabela();
            MessageBox.Show("Transação Adicionada com Sucesso!");
        }

        private bool Validar()
        {
            {
                if (string.IsNullOrWhiteSpace(cbxStatus.SelectedItem.ToString()))
                {
                    MessageBox.Show("Preencha todos os campos!");
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(cbxCategoria.SelectedItem.ToString()))
                {
                    MessageBox.Show("Preencha todos os campos!");
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(cbxPagamento.SelectedItem.ToString()))
                {
                    MessageBox.Show("Preencha todos os campos!");
                    return false;
                }
                else if (string.IsNullOrWhiteSpace(txtValor.Text))
                {
                    MessageBox.Show("Preencha todos os campos!");
                    return false;
                }
                return true;
            }
        }

        private TransacoesModel CriarTransacao()
        {

            var transacao = new TransacoesModel
            {
                DataTransacao = Convert.ToDateTime(dtpDataTransacao.Value),
                ValorTransacao = Convert.ToDecimal(txtValor.Text),
                IdCategoria = Convert.ToInt32(cbxCategoria.SelectedValue),
                Status = (StatusEnum)Enum.Parse(typeof(StatusEnum), cbxStatus.SelectedItem.ToString()),
                FormaPagamento = (FormaPagamento)Enum.Parse(typeof(FormaPagamento), cbxPagamento.SelectedItem.ToString()),
                DescricaoTransacao = txtDescricao.Text,
            };
            return transacao;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
            ConfigTabela();
            
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (e.CloseReason == CloseReason.UserClosing)
            {
                this.DialogResult = DialogResult.Cancel;

                
            }
           
        }

        private void ConfigTabela()
        {
            _frmPrincipal.dgvTransacoes.AutoGenerateColumns = false;
            _frmPrincipal.dgvTransacoes.DataSource = null;
            _frmPrincipal.dgvTransacoes.DataSource = _transacoes;
           

        }

       
    }
}
