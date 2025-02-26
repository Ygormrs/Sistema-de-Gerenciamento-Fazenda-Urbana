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
    public partial class TelaInsumos : Form
    {
        public TelaInsumos()
        {
            InitializeComponent();
        }

        private void btn_add_insumo_Click(object sender, EventArgs e)
        {
            TelaNovoInsumo FormMain = new TelaNovoInsumo();
            FormMain.btn_att_ni.Visible = false;
            FormMain.ShowDialog();
        }

        private void btn_insumos_voltar_Click(object sender, EventArgs e)
        {
            TelaMenu FormMain = new TelaMenu();
            this.Hide();
        }

        private void TelaInsumos_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-5VTI9UI\SQLSERVER2022; integrated security=SSPI; initial catalog=DigitalNexus"))
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Insumos", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void btn_consultar_insumo_Click(object sender, EventArgs e)
        {
            TelaNovoInsumo FormMain = new TelaNovoInsumo();
            FormMain.btn_att_ni.Enabled = false;
            FormMain.lbl_novoinsumo.Text = "Consultar Insumo";
            FormMain.btn_ni_salvar.Visible = false;
            FormMain.btn_att_ni.Visible = false;
            FormMain.txtbox_ni_codigo.Text = dataGridView1.CurrentRow.Cells["IDInsumo"].Value.ToString();
            FormMain.txtbox_ni_nomeinsumo.Enabled = false;
            FormMain.txtbox_ni_nomeinsumo.Text = dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();
            FormMain.combobox_ni_tipoinsumo.Enabled = false;
            FormMain.combobox_ni_tipoinsumo.Text = dataGridView1.CurrentRow.Cells["TipoInsumo"].Value.ToString();
            FormMain.txtbox_ni_quantidade.Enabled = false;
            FormMain.txtbox_ni_quantidade.Text = dataGridView1.CurrentRow.Cells["Quantidade"].Value.ToString();
            FormMain.msktxtbox_ni_cnpj_fornecedor.Enabled = false;
            FormMain.msktxtbox_ni_cnpj_fornecedor.Text = dataGridView1.CurrentRow.Cells["CNPJ"].Value.ToString();
            FormMain.ShowDialog();
        }

        private void TelaInsumos_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlg = MessageBox.Show("Você realmente deseja voltar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dlg == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void btn_att_insumo_Click(object sender, EventArgs e)
        {
            TelaNovoInsumo FormMain = new TelaNovoInsumo();
            FormMain.lbl_novoinsumo.Text = "Editar Insumo";
            FormMain.btn_ni_salvar.Enabled = false;

            FormMain.txtbox_ni_codigo.Text = dataGridView1.CurrentRow.Cells["IDInsumo"].Value.ToString();
            FormMain.txtbox_ni_nomeinsumo.Text = dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();
            FormMain.combobox_ni_tipoinsumo.Text = dataGridView1.CurrentRow.Cells["TipoInsumo"].Value.ToString();
            FormMain.txtbox_ni_quantidade.Text = dataGridView1.CurrentRow.Cells["Quantidade"].Value.ToString();
            FormMain.msktxtbox_ni_cnpj_fornecedor.Text = dataGridView1.CurrentRow.Cells["CNPJ"].Value.ToString();
            FormMain.ShowDialog();
        }
    }
}
