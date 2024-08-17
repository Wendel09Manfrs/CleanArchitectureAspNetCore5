# Implementação de Arquitetura Limpa com ASP.NET Core 5

## Descrição

Este repositório contém um projeto de demonstração que ilustra a implementação da Clean Architecture (Arquitetura Limpa) utilizando o framework ASP.NET Core 5. A Clean Architecture é uma abordagem de design de software que promove a separação de responsabilidades e facilita a manutenção, teste e evolução de sistemas complexos.

## Objetivo

O objetivo deste projeto é fornecer um exemplo claro e bem-estruturado de como aplicar os princípios da Clean Architecture em uma aplicação ASP.NET Core 5. 

## Estrutura do Projeto
```bash
CleanArchi/
│
├── CleanArchi.Application
│   ├── Services/
│   ├── Interfaces/
│   ├── Mappings/
│   └── ViewModels/
├── CleanArchi.Domain
│   ├── Entities/
│   └── Interfaces/
│
├── CleanArchi.Infra.Data
│   ├── Context/
│   ├── EntityConfigurations/
│   ├── Migrations/
│   ├── Models/
│   └── Repositories/
│
├── CleanArchi.Infra.IoC
│   └── DependencyInjection
│
└── CleanArchi.MVC
    ├── Controllers/
    ├── MappingConfig/
    ├── Views/
    ├── wwwroot/
    ├── Program
    └── Startup

 ```

## Tecnologias Utilizadas

- Visual Studio 2022
- ASP.NET Core 5
- SQL Server 

## Instalação e Configuração

1. Clone o repositório:
    ```bash
    git clone https://github.com/Wendel09Manfrs/CleanArchitectureAspNetCore5.git
    ```

2. Navegue até o diretório do projeto na pasta CleanArchi.MVC com o Visual Studio Code:
    ```bash
    cd CleanArchitectureAspNetCore5
    ```
    Já dentro do diretório do projeto, navegue até a pasta MVC usando:
      ```bash
    cd CleanArchi.MVC
    ```

3. Restaure as dependências(opcional):
    ```bash
    dotnet restore
    ```

4. Configure a string de conexão no arquivo `appsettings.json` para apontar para o seu banco de dados SQL Server do seu ambiente.

5. Execute as migrações do Entity Framework Core para configurar o banco de dados(opcional):
    ```bash
    dotnet ef database update
    ```

6. Execute a aplicação:
    ```bash
    dotnet run
    ```

