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

        private void TelaNovaVenda_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Você realmente deseja voltar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
