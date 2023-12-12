## Requisitos

* .NET 8.0
* Database (MySQL, SQLServer e etc)

## Como rodar localmente?

1. Configure o banco de dados de escolha.

2. No arquivo [appsettings.json](RegistroCarrosdosAlunosIF/appsettings.json), alterar a _**Connection String**_ com o nome da sua máquina:
```
(...)
  "ConnectionStrings": {
    "DataBase": "Server=NOME DO DISPOSITIVO;DataBase=Db_Cadastros;Trusted_Connection=True;TrustServerCertificate=Yes"
  },
(...)
```
*Caso possuir uma Connection String personalizada, excluir a padrão e alterar pela sua.*

3. Abrir o Prompt de Comando e navegar até onde o projeto estiver localizado e usar o comando **dotnet run**:
```
C:\Users\Usuário> cd Desktop\CEIF\RegistroVeiculosIF

C:\Users\pedro\Desktop\CEIF\RegistroVeiculosIF> dotnet run
```

4. A aplicação começará a compilar e depois de poucos segundos vai rodar localmente:

![Página home do projeto.](/imgs/Screenshot_1.png "img1")