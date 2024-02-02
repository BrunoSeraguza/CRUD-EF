# CRUD-EF com JWT e Extensões de Classe

Este é um projeto de exemplo que demonstra a implementação de um CRUD (Create, Read, Update, Delete) utilizando Entity Framework em uma aplicação .NET, com autenticação baseada em JWT (JSON Web Tokens) e extensões de classe para funcionalidades adicionais.

## Requisitos

- Visual Studio (ou qualquer IDE compatível com .NET)
- SQL Server (ou outro banco de dados suportado pelo Entity Framework)

## Configuração

1. Clone este repositório:

    ```bash
    git clone https://github.com/BrunoSeraguza/CRUD-EF.git
    ```

2. Abra o projeto no Visual Studio.

3. Configure a string de conexão no arquivo `appsettings.json` para apontar para o seu banco de dados.

    ```json
    {
      "ConnectionStrings": {
        "DefaultConnection": "sua_string_de_conexao_aqui"
      },
      // ...
    }
    ```

4. Execute as migrações do Entity Framework para criar o banco de dados:

    ```
    dotnet ef database update
    ```

5. Configure as chaves secretas para JWT no arquivo `appsettings.json`:

    ```json
    {
      "JwtSettings": {
        "SecretKey": "sua_chave_secreta_aqui",
        "Issuer": "seu_issuer_aqui",
        "Audience": "sua_audience_aqui"
      },
      // ...
    }
    ```

6. Inicie o aplicativo.

## Funcionalidades

- **Create:** Adiciona novos registros ao banco de dados.
- **Read:** Recupera e exibe registros existentes.
- **Update:** Modifica registros existentes.
- **Delete:** Remove registros do banco de dados.
- **Autenticação JWT:** Implementa autenticação baseada em JWT para proteger rotas e recursos sensíveis.
- **Extensões de Classe:** Utiliza extensões de classe para organizar e reutilizar código de maneira eficiente.

## Contribuição

Contribuições são bem-vindas! Se você encontrar problemas ou tiver sugestões de melhorias, sinta-se à vontade para abrir uma "issue" ou enviar um "pull request".


