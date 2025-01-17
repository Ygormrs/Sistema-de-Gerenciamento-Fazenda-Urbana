namespace SistemaGerenciamentoFazendaUrbana
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            txtbox_LoginSenha.PasswordChar = '*';
        }

        private void btn_Login_Entrar_Click(object sender, EventArgs e)
        {
            // Dados de login pré-definidos
            string usuarioCorreto = "admin";
            string senhaCorreta = "admin";

            // Obtendo os valores digitados pelo usuário
            string usuarioDigitado = txtbox_CodLogin.Text;
            string senhaDigitada = txtbox_LoginSenha.Text;

            // Verificando as credenciais
            if (usuarioDigitado == usuarioCorreto && senhaDigitada == senhaCorreta)
            {
                // Login bem-sucedido
                MessageBox.Show("Login bem-sucedido!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);

                TelaMenu formMain = new TelaMenu();
                formMain.Show();
                this.Hide();
            }
            else
            {
                // Credenciais incorretas
                MessageBox.Show("Usuário ou senha inválidos. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Você realmente deseja voltar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
