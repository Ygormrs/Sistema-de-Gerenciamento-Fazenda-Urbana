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
    public partial class TelaNovaVenda : Form
    {
        public TelaNovaVenda()
        {
            InitializeComponent();
        }

        private void btn_nv_voltar_Click(object sender, EventArgs e)
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

        private void btn_nv_salvar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-5VTI9UI\SQLSERVER2022; integrated security=SSPI; initial catalog=DigitalNexus");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn; // Associar conexão ao comando
            cmd.CommandText = "INSERT INTO Vendas(CNPJ, Produto, Quantidade, PrevisaoEntrega) VALUES(@cnpj, @produto, @quantidade, @previsao)";

            // Adicionar parâmetros ao comando
            cmd.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = msktxtbox_nv_cnpj.Text;
            cmd.Parameters.Add("@produto", SqlDbType.VarChar).Value = combobox_nv_produto.Text;
            cmd.Parameters.Add("@quantidade", SqlDbType.Int).Value = txtbox_nv_quantidade.Text;
            cmd.Parameters.Add("@previsao", SqlDbType.Date).Value = dateTimePicker1.Text;

            try
            {
                cn.Open(); // Abre a conexão
                cmd.ExecuteNonQuery(); // Executa o comando
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

        //private void TelaNovaVenda_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    DialogResult dlg = MessageBox.Show("Você realmente deseja voltar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //    if (dlg == DialogResult.No)
        //    {
        //        e.Cancel = true;
        //    }
        //}

        private void btn_att_ncompra_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-5VTI9UI\SQLSERVER2022; integrated security=SSPI; initial catalog=DigitalNexus");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn; // Associar conexão ao comando

            // Alteração do comando SQL para UPDATE
            cmd.CommandText = "UPDATE Vendas SET " +
                              "CNPJ = @cnpj, " +
                              "Produto = @produto, " +
                              "Quantidade = @quantidade, " +
                              "PrevisaoEntrega = @previsao " +
                              "WHERE IDVenda = @codigo"; // Supondo que você use o "Codigo" como chave primária

            // Adicionar parâmetros ao comando
            cmd.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = msktxtbox_nv_cnpj.Text;
            cmd.Parameters.Add("@produto", SqlDbType.VarChar).Value = combobox_nv_produto.Text;
            cmd.Parameters.Add("@quantidade", SqlDbType.Int).Value = int.TryParse(txtbox_nv_quantidade.Text, out int quantidade) ? quantidade : 0;
            cmd.Parameters.Add("@previsao", SqlDbType.VarChar).Value = dateTimePicker1.Text;

            // Supondo que o código do produto esteja no TextBox `txtbox_nf_codigo`
            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = int.TryParse(txtbox_nv_codigo.Text, out int codigo) ? codigo : 0;

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
