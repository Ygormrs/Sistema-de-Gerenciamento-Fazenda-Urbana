using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGerenciamentoFazendaUrbana
{
    public partial class TelaNovoCliente : Form
    {
        public TelaNovoCliente()
        {
            InitializeComponent();
        }

        private void btn_nc_salvar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-5VTI9UI\SQLSERVER2022; integrated security=SSPI; initial catalog=DigitalNexus");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn; // Associar conexão ao comando
            cmd.CommandText = "INSERT INTO Clientes(CNPJ, StatusCliente, RazaoSocial, NomeFantasia, CEP, Estado, Cidade, Bairro, Rua, Numero, Complemento, Telefone, Email, NomeRepresentante) VALUES(@cnpj, @status, @razaosocial, @nomefantasia, @cep, @estado, @cidade, @bairro, @rua, @numero, @complemento, @telefone, @email, @nomerepresentante)";

            // Adicionar parâmetros ao comando
            cmd.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = msktxtbox_nc_cnpj.Text;
            cmd.Parameters.Add("@razaosocial", SqlDbType.VarChar).Value = txtbox_nc_razaosocial.Text;
            cmd.Parameters.Add("@nomefantasia", SqlDbType.VarChar).Value = txtbox_nc_nomefantasia.Text;
            cmd.Parameters.Add("@cep", SqlDbType.VarChar).Value = msktxtbox_nc_cep.Text;
            cmd.Parameters.Add("@estado", SqlDbType.VarChar).Value = combobox_nc_estado.Text;
            cmd.Parameters.Add("@cidade", SqlDbType.VarChar).Value = txtbox_nc_cidade.Text;
            cmd.Parameters.Add("@bairro", SqlDbType.VarChar).Value = txtbox_nc_bairro.Text;
            cmd.Parameters.Add("@rua", SqlDbType.VarChar).Value = txtbox_nc_rua.Text;
            cmd.Parameters.Add("@numero", SqlDbType.VarChar).Value = txtbox_nc_numero.Text;
            cmd.Parameters.Add("@complemento", SqlDbType.VarChar).Value = txtbox_nc_complemento.Text;
            cmd.Parameters.Add("@telefone", SqlDbType.VarChar).Value = msktxtbox_nc_telefone.Text;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtbox_nc_email.Text;
            cmd.Parameters.Add("@nomerepresentante", SqlDbType.VarChar).Value = txtbox_nc_nomerepresentante.Text;

            if (rb_nc_status_ativo.Checked == true)
            {
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = rb_nc_status_ativo.Text;
            }
            else
            {
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = rb_nc_status_inativo.Text;
            }

            try
            {
                cn.Open(); // Abre a conexão
                cmd.ExecuteNonQuery(); // Executa o comando

                cmd.CommandText = "SELECT @@IDENTITY";
                txtbox_nc_codigo.Text = cmd.ExecuteScalar().ToString();

                MessageBox.Show("Dados salvos com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar os dados: {ex.Message}");
            }
            finally
            {
                cn.Close(); // Fecha a conexão
                this.Hide();
            }
        }

        private void btn_nc_voltar_Click(object sender, EventArgs e)
        {
            // Chama o método de confirmação
            if (ConfirmarVoltar())
            {
                this.Hide(); // Oculta a tela atual
            }
        }

        private bool ConfirmarVoltar()
        {
            var resultado = MessageBox.Show("Você realmente deseja voltar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return resultado == DialogResult.Yes; // Retorna true se o usuário clicar em "Sim"
        }

        //private void TelaNovoCliente_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    DialogResult dlg = MessageBox.Show("Você realmente deseja voltar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //    if (dlg == DialogResult.No)
        //    {
        //        e.Cancel = true;
        //    }
        //}

        private void btn_att_nc_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-5VTI9UI\SQLSERVER2022; integrated security=SSPI; initial catalog=DigitalNexus");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn; // Associar conexão ao comando

            // Alteração do comando SQL para UPDATE
            cmd.CommandText = "UPDATE Clientes SET " +
                              "CNPJ = @cnpj, " +
                              "StatusCliente = @status, " +
                              "RazaoSocial = @razaosocial, " +
                              "NomeFantasia = @nomefantasia, " +
                              "CEP = @cep, " +
                              "Estado = @estado, " +
                              "Cidade = @cidade, " +
                              "Bairro = @bairro, " +
                              "Rua = @rua, " +
                              "Numero = @numero, " +
                              "Complemento = @complemento, " +
                              "Telefone = @telefone, " +
                              "Email = @email, " +
                              "NomeRepresentante = @nomerepresentante " +
                              "WHERE IDCliente = @codigo"; // Supondo que você use o "Codigo" como chave primária

            // Adicionar parâmetros ao comando
            cmd.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = msktxtbox_nc_cnpj.Text;
            cmd.Parameters.Add("@razaosocial", SqlDbType.VarChar).Value = txtbox_nc_razaosocial.Text;
            cmd.Parameters.Add("@nomefantasia", SqlDbType.VarChar).Value = txtbox_nc_nomefantasia.Text;
            cmd.Parameters.Add("@cep", SqlDbType.VarChar).Value = msktxtbox_nc_cep.Text;
            cmd.Parameters.Add("@estado", SqlDbType.VarChar).Value = combobox_nc_estado.Text;
            cmd.Parameters.Add("@cidade", SqlDbType.VarChar).Value = txtbox_nc_cidade.Text;
            cmd.Parameters.Add("@bairro", SqlDbType.VarChar).Value = txtbox_nc_bairro.Text;
            cmd.Parameters.Add("@rua", SqlDbType.VarChar).Value = txtbox_nc_rua.Text;
            cmd.Parameters.Add("@numero", SqlDbType.VarChar).Value = txtbox_nc_numero.Text;
            cmd.Parameters.Add("@complemento", SqlDbType.VarChar).Value = txtbox_nc_complemento.Text;
            cmd.Parameters.Add("@telefone", SqlDbType.VarChar).Value = msktxtbox_nc_telefone.Text;
            cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = txtbox_nc_email.Text;
            cmd.Parameters.Add("@nomerepresentante", SqlDbType.VarChar).Value = txtbox_nc_nomerepresentante.Text;

            // Supondo que o código do produto esteja no TextBox `txtbox_nf_codigo`
            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = int.TryParse(txtbox_nc_codigo.Text, out int codigo) ? codigo : 0;

            if (rb_nc_status_ativo.Checked == true)
            {
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = rb_nc_status_ativo.Text;
            }
            else
            {
                cmd.Parameters.Add("@status", SqlDbType.VarChar).Value = rb_nc_status_inativo.Text;
            }

            try
            {
                cn.Open(); // Abre a conexão
                cmd.ExecuteNonQuery(); // Executa o comando de atualização

                MessageBox.Show("Dados atualizados com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao atualizar os dados: {ex.Message}");
            }
            finally
            {
                cn.Close(); // Fecha a conexão
                this.Hide();
            }
        }
    }
}

