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
    public partial class TelaNovaCompra : Form
    {
        public TelaNovaCompra()
        {
            InitializeComponent();
        }

        private void btn_novacompra_voltar_Click(object sender, EventArgs e)
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

        private void btn_novacompra_salvar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-5VTI9UI\SQLSERVER2022; integrated security=SSPI; initial catalog=DigitalNexus");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn; // Associar conexão ao comando
            cmd.CommandText = "INSERT INTO Compras(CNPJ, Solicitante, Produto, Quantidade) VALUES(@cnpj, @solicitante, @produto, @quantidade)";

            // Adicionar parâmetros ao comando
            cmd.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = msktxtbox_nc_cnpj_forn.Text;
            cmd.Parameters.Add("@solicitante", SqlDbType.VarChar).Value = txtbox_nc_solicitante.Text;
            cmd.Parameters.Add("@produto", SqlDbType.VarChar).Value = txtbox_nc_produto.Text;
            cmd.Parameters.Add("@quantidade", SqlDbType.Int).Value = txtbox_nc_quantidade.Text;

            try
            {
                cn.Open(); // Abre a conexão
                cmd.ExecuteNonQuery(); // Executa o comando

                cmd.CommandText = "SELECT @@IDENTITY";
                txtbox_codigo_compra.Text = cmd.ExecuteScalar().ToString();

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

        //private void TelaNovaCompra_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    DialogResult dlg = MessageBox.Show("Você realmente deseja voltar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //    if (dlg == DialogResult.No)
        //    {
        //        e.Cancel = true;
        //    }
        //}

        private void btn_att_novacompra_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-5VTI9UI\SQLSERVER2022; integrated security=SSPI; initial catalog=DigitalNexus");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn; // Associar conexão ao comando

            // Alteração do comando SQL para UPDATE
            cmd.CommandText = "UPDATE Compras SET " +
                              "CNPJ = @cnpj, " +
                              "Solicitante = @solicitante, " +
                              "Quantidade = @quantidade, " +
                              "Produto = @produto " +
                              "WHERE IDCompra = @codigo"; // Supondo que você use o "Codigo" como chave primária

            // Adicionar parâmetros ao comando
            cmd.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = msktxtbox_nc_cnpj_forn.Text;
            cmd.Parameters.Add("@solicitante", SqlDbType.VarChar).Value = txtbox_nc_solicitante.Text;
            cmd.Parameters.Add("@quantidade", SqlDbType.Int).Value = int.TryParse(txtbox_nc_quantidade.Text, out int quantidade) ? quantidade : 0;
            cmd.Parameters.Add("@produto", SqlDbType.VarChar).Value = txtbox_nc_produto.Text;

            // Supondo que o código do produto esteja no TextBox `txtbox_nf_codigo`
            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = int.TryParse(txtbox_codigo_compra.Text, out int codigo) ? codigo : 0;

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
