#  Cadastro de Itens — Windows Forms + MySQL

Sistema de cadastro de itens desenvolvido em C# com Windows Forms e integração com banco de dados MySQL, criado durante o curso de Programador de Sistemas no SENAC em 2022.

##  Funcionalidades

- **Cadastrar** novos registros (nome e telefone)
- **Consultar** registro por ID
- **Excluir** registro por ID
- **Listar** todos os registros em um DataGridView

## 🛠️ Tecnologias

![C#](https://img.shields.io/badge/C%23-239120?style=flat&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-512BD4?style=flat&logo=dotnet&logoColor=white)
![MySQL](https://img.shields.io/badge/MySQL-4479A1?style=flat&logo=mysql&logoColor=white)

##  Pré-requisitos

- Visual Studio
- MySQL Server rodando localmente
- Banco de dados `FormularioCad` com tabela `FormularioCad (ID, nome, telefone)`
- Pacote NuGet: `MySql.Data`

##  Como executar

1. Clone o repositório
2. Crie o banco de dados MySQL:
```sql
CREATE DATABASE FormularioCad;
USE FormularioCad;
CREATE TABLE FormularioCad (
  ID INT AUTO_INCREMENT PRIMARY KEY,
  nome VARCHAR(100),
  telefone VARCHAR(20)
);
```
3. Abra `cadastro.sln` no Visual Studio e execute.

##  Estrutura

```
├── Program.cs
├── Form1.cs         ← lógica principal (CRUD)
├── Form1.Designer.cs
└── cadastro.sln
```
