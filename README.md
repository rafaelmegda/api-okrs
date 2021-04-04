# Projeto Estudo .Net API Core

Este projeto é de estudo para desenvolver uma API utilizando .Net Core usando o VSCode sendo consumida pelo front Angular em AWS.

Afim de auxiliar no processo de desenvolvimento, irei listar os passos para serem registrados e posteriormente auxiliar outros developers a também desenvolverem suas API's.

## Instalar .NetCore API

> `em breve`

## Criando seu projeto

Abra seu terminal e execute os comandos abaixo:

> `mdir defina-nome-do-seu-arquivo`

> `cd defina-nome-do-seu-arquivo`

> `dotnet`


## Dependencias necessárias

> Microsoft.EntityFrameworkCore.SqlServer" Version="3.0.0"
> PackageReference Include="Microsoft.EntityFrameworkCore.Sqlite" Version="3.0.0"
> Microsoft.EntityFrameworkCore.Design" Version="3.0.0"


## Configurando o EntityFrameworkCore Sqlite

### Instalando o Banco de dados

Instalar o EF Global
> `dotnet tool install --global dotnet-ef`

Criando as tabelas
> `dotnet ef migrations add init`

Criando o banco de dados
> `dotnet ef database update`

Download SQLLiteDB Browser
> http://sqlitebrowser.org/

## Extensões Vs.Code
> NuGet Package Manager


## Rodando o Projeto
> `dotnet watch run`

### Swager
* localhost:5001/swagger/index.html

### Angular

## Criar o projeto Angular
> `ng new nome-projeto`

## Rodando a aplicação
> `ng build`
> `ng serve -o`
