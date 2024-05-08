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
    public partial class Animal : Form
    {
        DataTable dt = new DataTable();
        animal c = new animal();
        bd_animal bd = new bd_animal();

        public Animal()
        {
            InitializeComponent();
            PreencherDataGrid();
            dgvAnimais.ReadOnly = true;
        }

        public void PreencherDataGrid()
        {
            dt = bd_animal.GetAnimal();
            dgvAnimais.DataSource = dt;
        }

        private void Animal_Load(object sender, EventArgs e)
        {

        }

        private void btn_Adicionar_animal_Click(object sender, EventArgs e)
        {
            Adicionar_animal k = new Adicionar_animal();
            k.Show();
            this.Hide();
        }

        private void btn_removeranimal1_Click(object sender, EventArgs e)
        {
            btn_VoltarMenu.Enabled = false;
            btn_Adicionar.Enabled = false;
            btn_RemoverAnimal.Enabled = false;
            btn_AlterarRegisto.Enabled = false;
            btn_VoltarRemover.Enabled = false;

            btn_VoltarMenu.Visible = false;
            btn_Adicionar.Visible = false;
            btn_RemoverAnimal.Visible = false;
            btn_AlterarRegisto.Visible = false;
            btn_removeranimal1.Visible = false;

            txt_ID.Enabled = true;
            lbl_ID.Enabled = true;
            btn_Confirmar.Enabled = true;
            btn_VoltarRemover.Enabled = true;

            lbl_ID.Visible = true;
            txt_ID.Visible = true;
            btn_Confirmar.Visible = true;
            btn_VoltarRemover.Visible = true;
        }

        private void btn_VoltarRemover_Click(object sender, EventArgs e)
        {
            btn_Adicionar.Enabled = true;
            btn_RemoverAnimal.Enabled = false;
            btn_AlterarRegisto.Enabled = true;
            btn_VoltarMenu.Enabled = true;

            btn_Adicionar.Visible = true;
            btn_RemoverAnimal.Visible = false;
            btn_AlterarRegisto.Visible = true;
            btn_VoltarMenu.Visible = true;
            btn_removeranimal1.Visible = true;

            lbl_ID.Enabled = false;
            txt_ID.Enabled = false;
            btn_Confirmar.Enabled = false;
            btn_ConfirmarAtualizar.Enabled = false;
            btn_VoltarRemover.Enabled = false;

            lbl_ID.Visible = false;
            btn_ID.Visible = false;
            txt_ID.Visible = false;
            btn_Confirmar.Visible = false;
            btn_ConfirmarAtualizar.Visible = false;
            btn_VoltarRemover.Visible = false;
        }

        private void btn_VoltarMenu_Click(object sender, EventArgs e)
        {
            Form1 k = new Form1();
            k.Show();
            this.Hide();
        }

        private void btn_ConfirmarAtualizar_Click(object sender, EventArgs e)
        {
            btn_Adicionar.Enabled = true;
            btn_RemoverAnimal.Enabled = true;
            btn_AlterarRegisto.Enabled = true;
            btn_VoltarMenu.Enabled = true;

            btn_Adicionar.Visible = true;
            btn_RemoverAnimal.Visible = true;
            btn_AlterarRegisto.Visible = true;
            btn_VoltarMenu.Visible = true;

            txt_ID.Enabled = false;
            btn_ConfirmarAtualizar.Enabled = false;
            btn_VoltarRemover.Enabled = false;

            lbl_ID.Visible = false;
            txt_ID.Visible = false;
            btn_ConfirmarAtualizar.Visible = false;
            btn_VoltarRemover.Visible = false;

            int valorID = int.Parse(txt_ID.Text);
            Atualizar_animal atualizar = new Atualizar_animal(valorID);
            atualizar.Show();
            this.Hide();
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            try
            {
                int id_animal = Convert.ToInt32(txt_ID.Text);
                bd.DelAnimal(id_animal);
                PreencherDataGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            txt_ID.Clear();
        }

        private void btn_AlterarRegisto_Click_1(object sender, EventArgs e)
        {
            btn_VoltarMenu.Enabled = false;
            btn_Adicionar.Enabled = false;
            btn_RemoverAnimal.Enabled = false;
            btn_AlterarRegisto.Enabled = false;
            btn_VoltarRemover.Enabled = false;
            btn_Confirmar.Enabled = false;

            btn_VoltarMenu.Visible = false;
            btn_Adicionar.Visible = false;
            btn_RemoverAnimal.Visible = false;
            btn_AlterarRegisto.Visible = false;
            btn_removeranimal1.Visible = false;
            btn_Confirmar.Visible = false;

            txt_ID.Enabled = true;
            lbl_ID.Enabled = true;
            btn_ConfirmarAtualizar.Enabled = true;
            btn_VoltarRemover.Enabled = true;

            lbl_ID.Visible = true;
            txt_ID.Visible = true;
            btn_ConfirmarAtualizar.Visible = true;
            btn_VoltarRemover.Visible = true;
        }
    }
}
