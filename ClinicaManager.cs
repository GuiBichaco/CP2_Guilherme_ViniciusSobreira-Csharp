using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP2_Guilherme_ViniciusSobreira_Csharp
{
    public class ClinicaManager
    {
        private List<Paciente> pacientes = new();
        private List<Medico> medicos = new();

        public void CadastrarPaciente(string nome, string cpf, DateOnly dataNascimento)
        {
            pacientes.Add(new Paciente(nome, cpf, dataNascimento));
        }

        public void CadastrarMedico(string nome, string crm, string especialidade)
        {
            medicos.Add(new Medico(nome, crm, especialidade));
        }

        public List<Paciente> ListarPacientes() => pacientes;
        public List<Medico> ListarMedicos() => medicos;

        public void AgendarConsulta(Guid idMedico, Guid idPaciente, DateOnly data, TimeOnly hora)
        {
            var medico = medicos.FirstOrDefault(m => m.Id == idMedico);
            var paciente = pacientes.FirstOrDefault(p => p.Id == idPaciente);
            if (medico != null && paciente != null)
            {
                var consulta = new Consulta(medico, paciente, data, hora);
                medico.AdicionarConsulta(consulta);
            }
        }

        public void ListarConsultas(Guid idMedico)
        {
            var medico = medicos.FirstOrDefault(m => m.Id == idMedico);
            if (medico != null)
            {
                Console.WriteLine($"Consultas do Dr(a). {medico.Nome}:");
                foreach (var c in medico.ObterConsultas())
                    Console.WriteLine(c);
            }
        }

        public void RemoverConsulta(Guid idMedico, Guid consultaId)
        {
            var medico = medicos.FirstOrDefault(m => m.Id == idMedico);
            medico?.RemoverConsulta(consultaId);
        }

        public void GerarRelatorioDiario(DateOnly data)
        {
            var consultasDia = medicos.SelectMany(m => m.ObterConsultas())
                .Where(c => c.Data == data)
                .OrderBy(c => c.Hora)
                .ToList();

            if (!consultasDia.Any())
            {
                Console.WriteLine("Nenhuma consulta neste dia.");
                return;
            }

            Console.WriteLine($"Relatório do dia {data:dd/MM/yyyy}");
            Console.WriteLine($"Total de Consultas: {consultasDia.Count}");
            Console.WriteLine($"Primeira consulta: {consultasDia.First().Hora}");
            Console.WriteLine($"Última consulta: {consultasDia.Last().Hora}");

            var intervalos = consultasDia.Zip(consultasDia.Skip(1), (a, b) => (b.Hora.ToTimeSpan() - a.Hora.ToTimeSpan()).TotalMinutes);
            if (intervalos.Any())
                Console.WriteLine($"Intervalo médio entre consultas: {intervalos.Average():F2} minutos");
        }
    }

}
