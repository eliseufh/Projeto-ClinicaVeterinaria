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
    public partial class Atualizar_consulta : Form
    {
        private int _receberID;

        bd_consulta bd = new bd_consulta();
        consulta c = new consulta();

        public Atualizar_consulta(int receberID)
        {
            InitializeComponent();
            _receberID = receberID;
        }

        private void PreencherCamposConsulta(int id)
        {
            consulta consulta = bd.ObterConsultaPorID(id);

            txt_idAnimal.Text = consulta.id_animal.ToString();
            txt_NomeMedico.Text = consulta.nome_medico;
            txt_tipoConsulta.Text = consulta.tipo_consulta;
            dtp_dataConsulta.Value = consulta.data_consulta;
            dtp_ProximaVisita.Value = consulta.prox_visita;
            txt_atoMedico.Text = consulta.ato_medico;
            txt_diagnostico.Text = consulta.diagnostico;
            txt_pesoAnimal.Text = consulta.peso.ToString();
            txt_observacoes.Text = consulta.observacoes;
            txt_prescricao.Text = consulta.prescricao_medica;
        }

        private void Atualizar_consulta_Load(object sender, EventArgs e)
        {
            lbl_ID.Text = _receberID.ToString();
            PreencherCamposConsulta(_receberID);
        }

        private void btn_confirmAlteracao_Click(object sender, EventArgs e)
        {
            int novoID = int.Parse(txt_idAnimal.Text);
            string novoNomeMedico = txt_NomeMedico.Text;
            string novoConsultaTipo = txt_tipoConsulta.Text;
            DateTime novaDataConsulta = dtp_dataConsulta.Value;
            DateTime novaDataVisita = dtp_ProximaVisita.Value;
            string novoAto = txt_atoMedico.Text;
            string novoDiagnostico = txt_diagnostico.Text;
            double Pesos = double.Parse(txt_pesoAnimal.Text);
            string novoObservacao = txt_observacoes.Text;
            string novoPrecricao = txt_prescricao.Text;

            c.id_animal = novoID;
            c.nome_medico = novoNomeMedico;
            c.tipo_consulta = novoConsultaTipo;
            c.data_consulta = novaDataConsulta;
            c.prox_visita = novaDataVisita;
            c.ato_medico = novoAto;
            c.diagnostico = novoDiagnostico;
            c.peso = Pesos;
            c.observacoes = novoObservacao;
            c.prescricao_medica = novoPrecricao;

            bd.EditarConsulta(int.Parse(lbl_ID.Text), c);

            MessageBox.Show("Editado com sucesso.");
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            Consulta k = new Consulta();
            k.Show();
            this.Hide();
        }
    }
}
