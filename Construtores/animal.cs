using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clinicaVeterinaria.Construtores
{
    internal class animal
    {
        public string nome_dono { get; set; }
        public string contacto_dono { get; set; }
        public DateTime data_nascimento { get; set; }
        public DateTime data_ultima_consulta { get; set; }
        public string tipo_animal { get; set; }
        public string raca { get; set; }
        public string sexo { get; set; }
        public double peso { get; set; }
    }
}
