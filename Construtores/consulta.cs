using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicaVeterinaria.Construtores
{
    internal class consulta
    {
        public int id_animal { get; set; }
        public string nome_medico { get; set; }
        public string tipo_consulta { get; set; }
        public DateTime data_consulta { get; set; }
        public DateTime prox_visita { get; set; }
        public string diagnostico { get; set; }
        public string ato_medico { get; set; }
        public string observacoes { get; set; }
        public double peso { get; set; }
        public string prescricao_medica { get; set; }
    }
}
