using Microsoft.Data.SqlClient;
using ProjetoControleFinanceiro.Models;
using ProjetoControleFinanceiro.Repository;
using ProjetoControleFinanceiro.Services;
using ProjetoControleFinanceiro.Views;

namespace ProjetoControleFinanceiro
{
    public partial class FrmLogin : Form
    {
        SqlConnection conexao = new SqlConnection("Data Source=DESKTOP-S864QTA;Initial Catalog=FinanceiroDb;Integrated Security=True;Trust Server Certificate=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public FrmLogin()
        {
            InitializeComponent();
            using (var db = new FinanceiroContext())
            {

            }
        }

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

                        
                        UsuarioModel NovoUsuario = new UsuarioModel
                        {
                            Nome = form.txtUsuario.Text,
                            Email = form.txtEmailCadastro.Text,
                            Senha = form.txtSenhaCadastro.Text
                        };

                        
                        var UsuarioService = new UsuarioService();
                        await UsuarioService.CadastrarUsuario(NovoUsuario);
                        MessageBox.Show("Usuário Cadastrado com Sucesso!");

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from dbo.Usuarios where email=@email and senha =@senha", conexao);   
            cmd.Parameters.AddWithValue("@email", txtEmailLogin.Text);
            cmd.Parameters.AddWithValue("@senha", txtSenhaLogin.Text);
            conexao.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                
                MessageBox.Show("Login realizado com Sucesso!");
                FrmDashBoard dashboard = new FrmDashBoard();
                dashboard.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos, tente novamente!");
            }
            
            
            

        }
    }
}
