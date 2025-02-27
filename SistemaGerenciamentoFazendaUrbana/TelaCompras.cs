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
    public partial class TelaCompras : Form
    {
        public TelaCompras()
        {
            InitializeComponent();
        }

        private void btn_compras_voltar_Click(object sender, EventArgs e)
        {
            TelaMenu FormMain = new TelaMenu();
            this.Hide();
        }

        private void btn_solicitarcompra_Click(object sender, EventArgs e)
        {
            TelaNovaCompra FormMain = new TelaNovaCompra();
            FormMain.btn_att_novacompra.Visible = false;
            FormMain.Show();
        }

        private void TelaCompras_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-5VTI9UI\SQLSERVER2022; integrated security=SSPI; initial catalog=DigitalNexus"))
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Compras", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void btn_consultarcompra_Click(object sender, EventArgs e)
        {
            TelaNovaCompra FormMain = new TelaNovaCompra();
            FormMain.lbl_novacompra.Text = "Consulta Compra";
            FormMain.btn_novacompra_salvar.Visible = false;
            FormMain.btn_att_novacompra.Visible = false;
            FormMain.txtbox_codigo_compra.Text = dataGridView1.CurrentRow.Cells["IDCompra"].Value.ToString();
            FormMain.txtbox_codigo_compra.Enabled = false;
            FormMain.msktxtbox_nc_cnpj_forn.Text = dataGridView1.CurrentRow.Cells["CNPJ"].Value.ToString();
            FormMain.msktxtbox_nc_cnpj_forn.Enabled = false;
            FormMain.txtbox_nc_solicitante.Text = dataGridView1.CurrentRow.Cells["Solicitante"].Value.ToString();
            FormMain.txtbox_nc_solicitante.Enabled = false;
            FormMain.txtbox_nc_produto.Text = dataGridView1.CurrentRow.Cells["Produto"].Value.ToString();
            FormMain.txtbox_nc_produto.Enabled = false;
            FormMain.txtbox_nc_quantidade.Text = dataGridView1.CurrentRow.Cells["Quantidade"].Value.ToString();
            FormMain.txtbox_nc_quantidade.Enabled = false;
            FormMain.ShowDialog();
        }

        private void TelaCompras_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Você realmente deseja voltar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_editar_compra_Click(object sender, EventArgs e)
        {
            TelaNovaCompra FormMain = new TelaNovaCompra();
            FormMain.lbl_novacompra.Text = "Consulta Compra";
            FormMain.btn_novacompra_salvar.Visible = false;
            FormMain.txtbox_codigo_compra.Text = dataGridView1.CurrentRow.Cells["IDCompra"].Value.ToString();
            FormMain.msktxtbox_nc_cnpj_forn.Text = dataGridView1.CurrentRow.Cells["CNPJ"].Value.ToString();
            FormMain.txtbox_nc_solicitante.Text = dataGridView1.CurrentRow.Cells["Solicitante"].Value.ToString();
            FormMain.txtbox_nc_produto.Text = dataGridView1.CurrentRow.Cells["Produto"].Value.ToString();
            FormMain.txtbox_nc_quantidade.Text = dataGridView1.CurrentRow.Cells["Quantidade"].Value.ToString();
            FormMain.ShowDialog();
        }
    }
}
