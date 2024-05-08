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
    public partial class Atualizar_animal : Form
    {
        private int _receberID;

        bd_animal bd = new bd_animal();
        animal c = new animal();

        public Atualizar_animal(int receberID)
        {
            InitializeComponent();
            _receberID = receberID;
        }

        private void PreencherCamposAnimal(int id)
        {
            animal animal = bd.ObterAnimalPorID(id);

            txt_nomeDono.Text = animal.nome_dono;
            txt_Contacto.Text = animal.contacto_dono;
            dtp_nascimentoAnimal.Value = animal.data_nascimento;
            dtp_UltimaConsulta.Value = animal.data_ultima_consulta;
            cb_tipoAnimal.Text = animal.tipo_animal;
            txt_racaAnimal.Text = animal.raca;
            cb_sexoAnimal.Text = animal.sexo;
            txt_pesoAnimal.Text = animal.peso.ToString();
        }

        private void Atualizar_animal_Load(object sender, EventArgs e)
        {
            lbl_ID.Text = _receberID.ToString();
            PreencherCamposAnimal(_receberID);
        }

        private void btn_confirmAlteracao_Click(object sender, EventArgs e)
        {
            string novoNomeDono = txt_nomeDono.Text;
            string novoContactoDono = txt_Contacto.Text;
            DateTime novaDataNascimento = dtp_nascimentoAnimal.Value;
            DateTime novaDataUltimaConsulta = dtp_UltimaConsulta.Value;
            string novoTipoAnimal = cb_tipoAnimal.Text;
            string novaRaca = txt_racaAnimal.Text;
            string novoSexo = cb_sexoAnimal.Text;
            double novoPeso = double.Parse(txt_pesoAnimal.Text);

            c.nome_dono = novoNomeDono;
            c.contacto_dono = novoContactoDono;
            c.data_nascimento = novaDataNascimento;
            c.data_ultima_consulta = novaDataUltimaConsulta;
            c.tipo_animal = novoTipoAnimal;
            c.raca = novaRaca;
            c.sexo = novoSexo;
            c.peso = novoPeso;

            bd.EditarAnimal(int.Parse(lbl_ID.Text), c);

            MessageBox.Show("Editado com sucesso.");
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Animal k = new Animal();
            k.Show();
            this.Hide();
        }
    }
}
