using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CP2_Guilherme_ViniciusSobreira_Csharp
{
    public class Paciente
    {
        public Guid Id { get; private set; }
        public string Nome { get; set; }
        private string Cpf { get; set; }
        public DateOnly DataNascimento { get; set; }

        public Paciente(string nome, string cpf, DateOnly dataNascimento)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Cpf = cpf;
            DataNascimento = dataNascimento;
        }

        public override string ToString() => $"{Nome} - Nascimento: {DataNascimento:dd/MM/yyyy}";
    }
}
