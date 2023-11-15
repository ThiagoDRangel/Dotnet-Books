# Dotnet Books

### Create project
```bash
dotnet new webapi
```

### Trust digital certificate in localhost
```bash
dotnet dev-certs https --trust
```

### Install dependencies for entity Framework
```bash
dotnet add package Microsoft.EntityFrameworkCore
```

### Config SqlServer
```bash
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
```

### Install Fluent Assertions
```bash
dotnet add package FluentAssertions.AspNetCore.MVC --version 4.2.0
```

### Created container Docker
```bash
docker run -e 'ACCEPT_EULA=1' -e 'MSSQL_SA_PASSWORD=Dot123456!' -p 1433:1433 -d mcr.microsoft.com/azure-sql-edge:latest
```

### Created migrations in DB
```bash
dotnet ef migrations add initialCreate
```