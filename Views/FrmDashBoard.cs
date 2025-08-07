using System.Data;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore.Query.Internal;
using ProjetoControleFinanceiro.ColetaInformacoes;
using ProjetoControleFinanceiro.Enums;
using ProjetoControleFinanceiro.Models;
using ProjetoControleFinanceiro.Services;
using Microsoft.EntityFrameworkCore;

namespace ProjetoControleFinanceiro.Views
{

    public partial class FrmDashBoard : Form
    {

        #region Properties

        private readonly TransacoesService _transacoesService = new TransacoesService();
        private readonly CategoriaService _categoriaService = new CategoriaService();
        private List<TransacoesModel> _transacoes = new List<TransacoesModel>();
        // chama o categoriaCOletainfo e inicializa

        #endregion Properties

        #region Constructor
        public FrmDashBoard()
        {
            InitializeComponent();
            _categoriaService = new CategoriaService();
        }
        #endregion



        private async void FrmDashBoard_Load(object sender, EventArgs e)
        {
            CarregaComboBox();
            CarregaStatus();
            CarregaFormasPagamento();
            RecarregaDadosTransacao();

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
            cbxCategoria.DataSource = lista.OrderBy(x => x.IdCategoria).ToList();
            cbxCategoria.DisplayMember = nameof(CategoriasModel.Nome);
            cbxCategoria.ValueMember = nameof(CategoriasModel.IdCategoria);
        }
        private async Task RecarregaDadosTransacao()
        {
            //Obtém as transações do banco de dados
            var lista = await _transacoesService.CarregarTransacoes();
            //Formata os dados para exibição no dgv
            var dadosFormatados = lista.Select(t => new
            {
                t.DataTransacao,
                t.Status,
                t.FormaPagamento,
                t.ValorTransacao,
                t.DescricaoTransacao,
                NomeCategoria = t.Categoria.Nome
            }).ToList();
            //define a fonte de dados do dgv
            dgvTransacoes.DataSource = dadosFormatados;
        }

        private void btnAdicionarCategoria_Click(object sender, EventArgs e)
        {
            FrmCategoria frmCategoria = new FrmCategoria(this);
            if (frmCategoria.ShowDialog() == DialogResult.OK)
            {
                RecarregaDadosTransacao();
            }

            CarregaComboBox();
        }
        private async void btnAdicionarTransacao_Click(object sender, EventArgs e)
        {

            FrmTransacoes frmTransacoes = new FrmTransacoes(this);
            frmTransacoes.ShowDialog();
            dgvTransacoes.DataSource = null;
            dgvTransacoes.DataSource = _transacoes;
            CarregaComboBox();

            await RecarregaDadosTransacao();
        }


        private async void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            //Obtém a categoria selecionada no comboBox
            CategoriasModel categoria = (cbxCategoria.SelectedItem as CategoriasModel);

            FrmCategoria frmCategoria = new FrmCategoria(this, true, categoria);
            frmCategoria.ShowDialog();
            CarregaComboBox();
        }
        private async void btnExcluirCategoria_Click_1(object sender, EventArgs e)
        {
            //Obtém a categoria selecionada no comboBox
            CategoriasModel categoria = cbxCategoria.SelectedItem as CategoriasModel;
            var confirmacao = MessageBox.Show($"Tem certeza que deseja excluir a categoria \"{categoria.Nome}\"?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (confirmacao == DialogResult.No)
            {
                return;
            }
            try
            {
                var categoriaService = new CategoriaService();
                await categoriaService.ExcluirCategoria(categoria);

                MessageBox.Show("Categoria excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Recarrega categorias no ComboBox
                CarregaComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao excluir categoria: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                await RecarregaDadosTransacao();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
