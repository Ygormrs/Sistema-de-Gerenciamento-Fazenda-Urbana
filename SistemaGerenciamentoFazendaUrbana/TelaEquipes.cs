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
    public partial class TelaEquipes : Form
    {
        public TelaEquipes()
        {
            InitializeComponent();
        }

        private void btn_add_equipe_Click(object sender, EventArgs e)
        {
            TelaNovaEquipe FormMain = new TelaNovaEquipe();
            FormMain.btn_att_ne.Visible = false;
            FormMain.ShowDialog();
        }

        private void btn_equipes_voltar_Click(object sender, EventArgs e)
        {
            TelaMenu FormMain = new TelaMenu();
            this.Hide();
        }

        private void TelaEquipes_Load(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-5VTI9UI\SQLSERVER2022; integrated security=SSPI; initial catalog=DigitalNexus"))
            {
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Equipes", cn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dataGridView1.DataSource = dt;
            }
        }

        private void btn_consulta_equipe_Click(object sender, EventArgs e)
        {

            TelaNovaEquipe FormMain = new TelaNovaEquipe();
            FormMain.lbl_novaequipe.Text = "Consulta Equipe";
            FormMain.btn_ne_salvar.Visible = false;
            FormMain.btn_att_ne.Visible = false;
            FormMain.txtbox_codigo_equipe.Text = dataGridView1.CurrentRow.Cells["IDEquipe"].Value.ToString();
            FormMain.txtbox_ne_nomeequipe.Enabled = false;
            FormMain.txtbox_ne_nomeequipe.Text = dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();
            FormMain.txtbox_ne_emaildolider.Enabled = false;
            FormMain.txtbox_ne_emaildolider.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            FormMain.ShowDialog();
        }

        //private void TelaEquipes_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    DialogResult dlg = MessageBox.Show("Você realmente deseja voltar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        //    if (dlg == DialogResult.No)
        //    {
        //        e.Cancel = true;
        //    }
        //}

        private void btn_editarquipe_Click(object sender, EventArgs e)
        {
            TelaNovaEquipe FormMain = new TelaNovaEquipe();
            FormMain.lbl_novaequipe.Text = "Editar Equipe";
            FormMain.btn_ne_salvar.Visible = false;
            FormMain.txtbox_codigo_equipe.Text = dataGridView1.CurrentRow.Cells["IDEquipe"].Value.ToString();
            FormMain.txtbox_ne_nomeequipe.Text = dataGridView1.CurrentRow.Cells["Nome"].Value.ToString();
            FormMain.txtbox_ne_emaildolider.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            FormMain.ShowDialog();
        }
    }
}