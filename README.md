# Exemplo CRUD: .NET CORE 2 com Angular 5

Repositório para fins de estudos relacionado a desenvolvimento de .NET CORE 2 com Angular 5


## Recursos Utilizados no Desenvolvimento:

* Visual Studio 2017;
* .NET CORE 2.1;
* C#;
* Angular 5;
* Typescript 2.x;
* Entity Framework Core (DataBase First);
* SQL Server;
* Node.js (execução do Front-End);

## Executando Localmente:

Se faz necessário executar os seguintes comandos (**Package Manager Console**):

```

> Install-Package Microsoft.EntityFrameworkCore.SqlServer  

```

```

> Install-Package Microsoft.EntityFrameworkCore.Tools  

```

```

> Scaffold-DbContext "Sua connection string aqui" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Tables Funcionario, Cidades 

```

**(documentação em desenvolvimento)**

