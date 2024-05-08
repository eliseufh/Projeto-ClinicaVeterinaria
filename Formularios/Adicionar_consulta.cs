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
    public partial class Adicionar_consulta : Form
    {
        bd_consulta bd = new bd_consulta();
        consulta obj = new consulta();

        public Adicionar_consulta()
        {
            InitializeComponent();
        }

        public void AdicionarValores()
        {
            obj.id_animal = int.Parse(txt_idAnimal.Text);
            obj.nome_medico = txt_NomeMedico.Text;
            obj.tipo_consulta = txt_tipoConsulta.Text;
            obj.data_consulta = dtp_dataConsulta.Value;
            obj.prox_visita = dtp_ProximaVisita.Value;
            obj.diagnostico = txt_diagnostico.Text;
            obj.ato_medico = txt_atoMedico.Text;
            obj.observacoes = txt_observacoes.Text;
            obj.peso = double.Parse(txt_pesoAnimal.Text);
            obj.prescricao_medica = txt_prescricao.Text;

            bd.AdicionarConsulta(obj);

            MessageBox.Show("Dados inseridos com sucesso!");
        }

        private void Adicionar_consulta_Load(object sender, EventArgs e)
        {

        }

        private void btn_confirmRegisto_Click(object sender, EventArgs e)
        {
            AdicionarValores();
            btn_confirmRegisto.Enabled = true;
        }

        private void btn_ContinuarAdd_Click(object sender, EventArgs e)
        {
            Adicionar_consulta k = new Adicionar_consulta();
            k.Show();
            this.Hide();
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Consulta k = new Consulta();
            k.Show();
            this.Hide();
        }
    }
}
