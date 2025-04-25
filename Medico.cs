using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP2_Guilherme_ViniciusSobreira_Csharp
{
    public class Medico
    {
        public Guid Id { get; private set; }
        public string Nome { get; set; }
        private string Crm { get; set; }
        public string Especialidade { get; set; }
        private List<Consulta> Consultas { get; set; } = new List<Consulta>();

        public Medico(string nome, string crm, string especialidade)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Crm = crm;
            Especialidade = especialidade;
        }

        public void AdicionarConsulta(Consulta consulta)
        {
            Consultas.Add(consulta);
        }

        public void RemoverConsulta(Guid consultaId)
        {
            Consultas.RemoveAll(c => c.Id == consultaId);
        }

        public List<Consulta> ObterConsultas() => Consultas;

        public override string ToString() => $"{Nome} - {Especialidade}";
    }

}
