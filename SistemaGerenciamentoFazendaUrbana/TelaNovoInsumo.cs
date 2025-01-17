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
    public partial class TelaNovoInsumo : Form
    {
        public TelaNovoInsumo()
        {
            InitializeComponent();
        }

        private void btn_ni_salvar_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-5VTI9UI\SQLSERVER2022; integrated security=SSPI; initial catalog=DigitalNexus");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn; // Associar conexão ao comando
            cmd.CommandText = "INSERT INTO Insumos(Nome, TipoInsumo, Quantidade, CNPJ) VALUES(@nome, @tipoinsumo, @quantidade, @cnpj)";

            // Adicionar parâmetros ao comando
            cmd.Parameters.Add("@nome", SqlDbType.VarChar).Value = txtbox_ni_nomeinsumo.Text;
            cmd.Parameters.Add("@tipoinsumo", SqlDbType.VarChar).Value = combobox_ni_tipoinsumo.Text;
            cmd.Parameters.Add("@quantidade", SqlDbType.Int).Value = int.TryParse(txtbox_ni_quantidadedisponivel.Text, out int quantidadedisponivel) ? quantidadedisponivel : 0;
            cmd.Parameters.Add("@cnpj", SqlDbType.VarChar).Value = msktxtbox_ni_cnpj_fornecedor.Text;

            try
            {
                cn.Open(); // Abre a conexão
                cmd.ExecuteNonQuery(); // Executa o comando

                cmd.CommandText = "SELECT @@IDENTITY";
                txtbox_ni_codigo.Text = cmd.ExecuteScalar().ToString();

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

        private void btn_ni_voltar_Click(object sender, EventArgs e)
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

        private void TelaNovoInsumo_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Você realmente deseja voltar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
