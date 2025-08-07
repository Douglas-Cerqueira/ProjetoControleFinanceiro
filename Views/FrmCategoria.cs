using System.Drawing;
using ProjetoControleFinanceiro.Models;
using ProjetoControleFinanceiro.Services;

namespace ProjetoControleFinanceiro.Views
{
    public partial class FrmCategoria : Form
    {
        #region Properties
        //Referência ao formulário principal (dashboard).
        private readonly FrmDashBoard _frmPrincipal;
        //Indica se o formulário está em modo de edição(true) ou de adição(false).
        private bool _modoEdicao;
        // Objeto da categoria que será editado (caso esteja em modo de edição).
        private CategoriasModel _categoriaEdicao = new CategoriasModel();
        //Serviço responsável pelas operações com categoria(adicionar, editar).
        private readonly CategoriaService _categoriaService = new CategoriaService();

        #endregion Properties

        #region Constructors

        // Se estiver em modo de edição, preenche os campos com os dados existentes.
        public FrmCategoria(FrmDashBoard frmPrincipal, bool modoEdicao = false, CategoriasModel categoria = null)
        {
            InitializeComponent();
            _frmPrincipal = frmPrincipal;
            _modoEdicao = modoEdicao;
            _categoriaEdicao = categoria;
        }

        #endregion Constructors

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            if (_modoEdicao)
            {
                //Altera o nome do formulario
                this.Text = "Alterar categoria";
                //Altera o nome do botão 
                btnAdicionar.Text = "Alterar";
                //Busca o nome da categoria selecionada no combobox
                txtCategoria.Text = _categoriaEdicao.Nome;
            }

        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_modoEdicao)
                {
                    SalvarCategoria();
                }
                else
                {
                    AlterarCategoria();
                }

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private async void AlterarCategoria()
        {
            if (!Validar())
            {
                return;
            }
            //Coloca o nome da categoria selecionada no combobox para o textbox
            _categoriaEdicao.Nome = txtCategoria.Text;
            await _categoriaService.EditarCategoria(_categoriaEdicao);
            MessageBox.Show("Categoria Alterada com Sucesso!");
        }

        private async void SalvarCategoria()
        {
            if (!Validar())
            {
                return;
            }

            var categoria = CriacaoCategoria();

            await _categoriaService.AdicionarCategoria(categoria);
            MessageBox.Show("Categoria Cadastrada com Sucesso!");
        }

        private bool Validar()
        {
            //verifica se esta com campo sem preencher 
            if (string.IsNullOrWhiteSpace(txtCategoria.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return false;
            }

            return true;
        }

        private CategoriasModel CriacaoCategoria()
        {
            var categoria = new CategoriasModel()
            {
                Nome = txtCategoria.Text,
            };

            return categoria;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }



    }
}
