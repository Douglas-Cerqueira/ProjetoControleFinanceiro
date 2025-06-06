using ProjetoControleFinanceiro.Models;
using ProjetoControleFinanceiro.Services;
using ProjetoControleFinanceiro.Views;

namespace ProjetoControleFinanceiro
{
    public partial class FrmLogin : Form
    {


        #region Properties

        private readonly UsuarioService _usuarioService;

        #endregion Properties

        #region Constructors

        public FrmLogin()
        {
            InitializeComponent();
            _usuarioService = new UsuarioService();

        }

        #endregion Constructors

        private async void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var form = new FrmCadastroUsuario())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        if (string.IsNullOrWhiteSpace(form.txtUsuario.Text) ||
                            string.IsNullOrWhiteSpace(form.txtEmailCadastro.Text) ||
                            string.IsNullOrWhiteSpace(form.txtSenhaCadastro.Text))
                        {
                            MessageBox.Show("Preencha todos os campos!");
                            return;
                        }

                        var usuario = CriarUsuario(form);

                        await _usuarioService.CadastrarUsuario(usuario);
                        MessageBox.Show("Usuário Cadastrado com Sucesso!");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private UsuarioModel CriarUsuario(FrmCadastroUsuario form)
        {
            return new UsuarioModel
            {
                Nome = form.txtUsuario.Text,
                Email = form.txtEmailCadastro.Text,
                Senha = form.txtSenhaCadastro.Text
            };
        }

        private async void btnEntrar_Click(object sender, EventArgs e)
        {
            string email = txtEmailLogin.Text;
            string senha = txtSenhaLogin.Text;
            var usuario = await _usuarioService.ObterUsuarioPorEmailESenha(email, senha);
            if (usuario != null)
            {
                
                MessageBox.Show("Login realizado com sucesso!");
                FrmDashBoard dashBoard = new FrmDashBoard();
                dashBoard.Show();
                this.Hide();
            }
            else
            {
                // Se o usuário não for encontrado
                MessageBox.Show("Email ou senha incorretos, tente novamente!");
            }
        }
    }
}
