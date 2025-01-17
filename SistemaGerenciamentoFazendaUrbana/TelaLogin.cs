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
            // Dados de login pr�-definidos
            string usuarioCorreto = "admin";
            string senhaCorreta = "admin";

            // Obtendo os valores digitados pelo usu�rio
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
                MessageBox.Show("Usu�rio ou senha inv�lidos. Tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Voc� realmente deseja voltar?", "Confirma��o", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
