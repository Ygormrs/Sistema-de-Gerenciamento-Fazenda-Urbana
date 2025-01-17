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
    public partial class TelaVendas : Form
    {
        public TelaVendas()
        {
            InitializeComponent();
        }

        private void btn_vendas_voltar_Click(object sender, EventArgs e)
        {
            TelaMenu FormMain = new TelaMenu();
            this.Hide();
        }

        private void btn_add_venda_Click(object sender, EventArgs e)
        {
            TelaNovaVenda FormMain = new TelaNovaVenda();
            FormMain.Show();
        }

        private void TelaVendas_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-5VTI9UI\SQLSERVER2022; integrated security=SSPI; initial catalog=DigitalNexus"))
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Vendas", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void btn_consultar_venda_Click(object sender, EventArgs e)
        {
            TelaNovaVenda FormMain = new TelaNovaVenda();
            FormMain.lbl_novavenda.Text = "Consulta Venda";
            FormMain.btn_nv_salvar.Visible = false;
            FormMain.txtbox_nv_codigo.Text = dataGridView1.CurrentRow.Cells["IDVenda"].Value.ToString();
            FormMain.msktxtbox_nv_cnpj.Enabled = false;
            FormMain.msktxtbox_nv_cnpj.Text = dataGridView1.CurrentRow.Cells["CNPJ"].Value.ToString();
            FormMain.combobox_nv_produto.Enabled = false;
            FormMain.combobox_nv_produto.Text = dataGridView1.CurrentRow.Cells["Produto"].Value.ToString();
            FormMain.txtbox_nv_quantidade.Enabled = false;
            FormMain.txtbox_nv_quantidade.Text = dataGridView1.CurrentRow.Cells["Quantidade"].Value.ToString();
            FormMain.dateTimePicker1.Enabled = false;
            FormMain.dateTimePicker1.Text = dataGridView1.CurrentRow.Cells["PrevisaoEntrega"].Value.ToString();
            FormMain.ShowDialog();
        }

        private void TelaVendas_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Você realmente deseja voltar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
