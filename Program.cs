using CP2_Guilherme_ViniciusSobreira_Csharp;

class Program
{
    static void Main()
    {
        var manager = new ClinicaManager();
        while (true)
        {
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. Cadastrar Paciente");
            Console.WriteLine("2. Cadastrar Médico");
            Console.WriteLine("3. Agendar Consulta");
            Console.WriteLine("4. Listar Consultas");
            Console.WriteLine("5. Remover Consulta");
            Console.WriteLine("6. Relatório Diário");
            Console.WriteLine("7. Listar Todos os Pacientes");
            Console.WriteLine("8. Listar Todos os Médicos");
            Console.WriteLine("0. Sair");

            var opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    Console.Write("Nome: "); var nome = Console.ReadLine();
                    Console.Write("CPF: "); var cpf = Console.ReadLine();
                    Console.Write("Data de nascimento (dd/MM/yyyy): "); var dn = DateOnly.Parse(Console.ReadLine());
                    manager.CadastrarPaciente(nome, cpf, dn);
                    break;
                case "2":
                    Console.Write("Nome: "); nome = Console.ReadLine();
                    Console.Write("CRM: "); var crm = Console.ReadLine();
                    Console.Write("Especialidade: "); var esp = Console.ReadLine();
                    manager.CadastrarMedico(nome, crm, esp);
                    break;
                case "3":
                    var pacientes = manager.ListarPacientes();
                    if (pacientes.Count == 0)
                    {
                        Console.WriteLine("Não há pacientes cadastrados.");
                        break;
                    }
                    var medicos = manager.ListarMedicos();
                    if (medicos.Count == 0)
                    {
                        Console.WriteLine("Não há médicos cadastrados.");
                        break;
                    }
                    Utils.ListarComIndice("Pacientes:", pacientes);
                    Console.Write("Escolha o número do paciente: "); var pIndex = int.Parse(Console.ReadLine());
                    Utils.ListarComIndice("Médicos:", medicos);
                    Console.Write("Escolha o número do médico: "); var mIndex = int.Parse(Console.ReadLine());
                    Console.Write("Data (dd/MM/yyyy): "); var data = DateOnly.Parse(Console.ReadLine());
                    Console.Write("Hora (HH:mm): "); var hora = TimeOnly.Parse(Console.ReadLine());
                    manager.AgendarConsulta(medicos[mIndex].Id, pacientes[pIndex].Id, data, hora);
                    break;

                case "4":
                    medicos = manager.ListarMedicos();
                    if (medicos.Count == 0)
                    {
                        Console.WriteLine("Não há médicos cadastrados.");
                        break;
                    }
                    Utils.ListarComIndice("Médicos:", medicos);
                    Console.Write("Escolha o número do médico: "); mIndex = int.Parse(Console.ReadLine());
                    manager.ListarConsultas(medicos[mIndex].Id);
                    break;

                case "5":
                    medicos = manager.ListarMedicos();
                    if (medicos.Count == 0)
                    {
                        Console.WriteLine("Não há médicos cadastrados.");
                        break;
                    }
                    Utils.ListarComIndice("Médicos:", medicos);
                    Console.Write("Escolha o número do médico: "); mIndex = int.Parse(Console.ReadLine());
                    var medico = medicos[mIndex];
                    var consultas = medico.ObterConsultas();
                    if (consultas.Count == 0)
                    {
                        Console.WriteLine("Não há consultas para este médico.");
                        break;
                    }
                    Utils.ListarComIndice("Consultas:", consultas);
                    Console.Write("Escolha o número da consulta para remover: "); var cIndex = int.Parse(Console.ReadLine());
                    manager.RemoverConsulta(medico.Id, consultas[cIndex].Id);
                    break;
                case "6":
                    Console.Write("Data do relatório (dd/MM/yyyy): ");
                    data = DateOnly.Parse(Console.ReadLine());
                    manager.GerarRelatorioDiario(data);
                    break;

                case "7":
                    pacientes = manager.ListarPacientes();
                    if (pacientes.Count == 0)
                        Console.WriteLine("Não há pacientes cadastrados.");
                    else
                        Utils.ListarComIndice("Lista de Pacientes:", pacientes);
                    break;

                case "8":
                    medicos = manager.ListarMedicos();
                    if (medicos.Count == 0)
                        Console.WriteLine("Não há médicos cadastrados.");
                    else
                        Utils.ListarComIndice("Lista de Médicos:", medicos);
                    break;
                case "0":
                    return;
            }
        }
    }
}
