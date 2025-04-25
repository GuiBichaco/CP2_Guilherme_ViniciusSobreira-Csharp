using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP2_Guilherme_ViniciusSobreira_Csharp
{
    public class Consulta
    {
        public Guid Id { get; private set; }
        public Medico Medico { get; set; }
        public Paciente Paciente { get; set; }
        public DateOnly Data { get; set; }
        public TimeOnly Hora { get; set; }
        private DateTime CriadoUtc { get; set; }

        public Consulta(Medico medico, Paciente paciente, DateOnly data, TimeOnly hora)
        {
            Id = Guid.NewGuid();
            Medico = medico;
            Paciente = paciente;
            Data = data;
            Hora = hora;
            CriadoUtc = DateTime.UtcNow;
        }

        public override string ToString() => $"Consulta {Data:dd/MM/yyyy} às {Hora} - Paciente: {Paciente.Nome}";
    }

}
