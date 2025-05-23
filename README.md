# 🏥 CP2_Guilherme_ViniciusSobreira-Csharp

Projeto de Console App desenvolvido para o Checkpoint 2 da disciplina **C# Software Development** na FIAP. A aplicação simula o sistema de gestão de uma clínica médica, com funcionalidades de cadastro, agendamento e emissão de relatórios.

---
![image](https://github.com/user-attachments/assets/11a694b5-38a8-4890-844b-539921f008f6)

---
## 👥 Integrantes do grupo

- Guilherme Catelli Bichaco - RM: 97989
- Vinicius Sobreira Borges - RM: 97767
---
## 📌 Funcionalidades

- Cadastro de **pacientes** e **médicos**
- Agendamento de **consultas** com registro de data e hora
- Listagem e remoção de consultas
- Geração de **relatório diário**:
  - Total de consultas
  - Primeira e última consulta
  - Intervalo médio entre elas
- Listagem de todos os médicos e pacientes cadastrados
- Menu interativo via console

---

## 🛠️ Tecnologias e conceitos aplicados

- C# com .NET 8
- Programação Orientada a Objetos (POO)
- Coleções genéricas com `List<T>`
- Encapsulamento de atributos sensíveis (`cpf`, `crm`)
- Manipulação correta de datas e horários com `DateOnly`, `TimeOnly`, `DateTime`
- Método genérico para listagem com índice (`ListarComIndice<T>()`)
- Estrutura limpa com separação de responsabilidades por classe

---

## 🧑‍💻 Como executar o projeto

1. **Pré-requisitos:**
   - Ter o [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) instalado
   - Ter o Git instalado

2. **Clone o repositório:**
   ```bash
   git clone https://github.com/GuiBichaco/CP2_Guilherme_ViniciusSobreira-Csharp.git
   cd CP2_Guilherme_ViniciusSobreira-Csharp
   ```

3. **Compile e execute o projeto:**
   ```bash
   dotnet run
   ```

---

## 🗂️ Estrutura de arquivos

```
📁 CP2_Guilherme_ViniciusSobreira-Csharp/
├── Paciente.cs
├── Medico.cs
├── Consulta.cs
├── ClinicaManager.cs
├── Utils.cs
├── Program.cs
└── README.md
```

---

## ✅ Versão utilizada

- .NET 8
- C# 12
