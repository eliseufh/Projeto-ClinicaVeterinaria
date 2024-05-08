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
using clinicaVeterinaria.Formularios;

namespace clinicaVeterinaria
{
    public partial class Adicionar_animal : Form
    {
        bd_animal bd = new bd_animal();
        animal obj = new animal();

        public Adicionar_animal()
        {
            InitializeComponent();
        }

        public void AdicionarValores()
        {
            obj.nome_dono = txt_nomeDono.Text;
            obj.contacto_dono = txt_Contacto.Text;
            obj.data_nascimento = dtp_nascimentoAnimal.Value;
            obj.data_ultima_consulta = dtp_UltimaConsulta.Value;
            obj.tipo_animal = cb_tipoAnimal.Text;
            obj.raca = txt_racaAnimal.Text;
            obj.sexo = cb_sexoAnimal.Text;
            obj.peso = double.Parse(txt_pesoAnimal.Text);

            bd.CadastrarAnimal(obj);

            MessageBox.Show("Dados inseridos com sucesso!");
        }

        private void Adicionar_animal_Load(object sender, EventArgs e)
        {

        }

        private void btn_confirmRegisto_Click(object sender, EventArgs e)
        {
            AdicionarValores();
            btn_confirmRegisto.Enabled = true;
        }

        private void btn_ContinuarAdd_Click(object sender, EventArgs e)
        {
            Adicionar_animal k = new Adicionar_animal();
            k.Show();
            this.Hide();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Animal k = new Animal();
            k.Show();
            this.Hide();
        }
    }
}
