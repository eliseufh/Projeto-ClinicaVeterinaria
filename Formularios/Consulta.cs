using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using clinicaVeterinaria.Construtores;
using clinicaVeterinaria.BD;

namespace clinicaVeterinaria.Formularios
{
    public partial class Consulta : Form
    {
        DataTable dt = new DataTable();
        consulta c = new consulta();
        bd_consulta bd = new bd_consulta();

        public Consulta()
        {
            InitializeComponent();
            PreencherDataGrid();
            dgvConsulta.ReadOnly = true;
        }

        public void PreencherDataGrid()
        {
            dt = bd_consulta.GetConsulta();
            dgvConsulta.DataSource = dt;
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            Adicionar_consulta k = new Adicionar_consulta();
            k.Show();
            this.Hide();
        }

        private void Consulta_Load(object sender, EventArgs e)
        {

        }

        private void btn_RemoverConsulta_Click(object sender, EventArgs e)
        {
            btn_voltarMenu.Enabled = false;
            btn_Adicionar.Enabled = false;
            btn_RemoverConsulta.Enabled = false;
            btn_AlterarRegisto.Enabled = false;
            btn_VoltarRemover.Enabled = false;

            btn_voltarMenu.Visible = false;
            btn_Adicionar.Visible = false;
            btn_RemoverConsulta.Visible = false;
            btn_AlterarRegisto.Visible = false;

            txt_ID.Enabled = true;
            lbl_ID.Enabled = true;
            btn_confirmar.Enabled = true;
            btn_VoltarRemover.Enabled = true;

            btn_Informacao.Visible = false;
            lbl_ID.Visible = true;
            txt_ID.Visible = true;
            btn_confirmar.Visible = true;
            btn_VoltarRemover.Visible = true;
        }

        private void btn_VoltarRemover_Click(object sender, EventArgs e)
        {
            btn_Adicionar.Enabled = true;
            btn_RemoverConsulta.Enabled = true;
            btn_AlterarRegisto.Enabled = true;
            btn_voltarMenu.Enabled = true;

            btn_Adicionar.Visible = true;
            btn_RemoverConsulta.Visible = true;
            btn_AlterarRegisto.Visible = true;
            btn_voltarMenu.Visible = true;

            lbl_ID.Enabled = false;
            txt_ID.Enabled = false;
            btn_confirmar.Enabled = false;
            btn_ConfirmarAtualizar.Enabled = false;
            btn_VoltarRemover.Enabled = false;

            lbl_ID.Visible = false;
            btn_Informacao.Visible = false;
            txt_ID.Visible = false;
            btn_confirmar.Visible = false;
            btn_ConfirmarAtualizar.Visible = false;
            btn_VoltarRemover.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 k = new Form1();
            k.Show();
            this.Hide();
        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                int id_consulta = Convert.ToInt32(txt_ID.Text);
                bd.DelConsulta(id_consulta);
                PreencherDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txt_ID.Clear();
        }

        private void btn_AlterarRegisto_Click(object sender, EventArgs e)
        {
            btn_Adicionar.Enabled = false;
            btn_RemoverConsulta.Enabled = false;
            btn_AlterarRegisto.Enabled = false;
            btn_voltarMenu.Enabled = false;
            btn_confirmar.Enabled = false;

            btn_Adicionar.Visible = false;
            btn_RemoverConsulta.Visible = false;
            btn_AlterarRegisto.Visible = false;
            btn_voltarMenu.Visible = false;
            btn_confirmar.Visible = false;

            txt_ID.Enabled = true;
            lbl_ID.Enabled = true;
            btn_ConfirmarAtualizar.Enabled = true;
            btn_VoltarRemover.Enabled = true;

            txt_ID.Visible = true;
            lbl_ID.Visible = true;
            btn_ConfirmarAtualizar.Visible = true;
            btn_VoltarRemover.Visible = true;
        }

        private void btn_ConfirmarAtualizar_Click(object sender, EventArgs e)
        {
            btn_Adicionar.Enabled = true;
            btn_RemoverConsulta.Enabled = true;
            btn_AlterarRegisto.Enabled = true;
            btn_voltarMenu.Enabled = true;

            btn_Adicionar.Visible = true;
            btn_RemoverConsulta.Visible = true;
            btn_AlterarRegisto.Visible = true;
            btn_voltarMenu.Visible = true;

            txt_ID.Enabled = false;
            btn_ConfirmarAtualizar.Enabled = false;
            btn_VoltarRemover.Enabled = false;

            lbl_ID.Visible = false;
            txt_ID.Visible = false;
            btn_ConfirmarAtualizar.Visible = false;
            btn_VoltarRemover.Visible = false;

            int valorID = int.Parse(txt_ID.Text);
            Atualizar_consulta atualizar = new Atualizar_consulta(valorID);
            atualizar.Show();
            this.Hide();
        }
    }
}
