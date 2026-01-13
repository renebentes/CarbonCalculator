# Calculador de Emissões de Gás Carbônico - CarbonCalculator

![.NET 10+](https://img.shields.io/badge/.NET-10-512BD4?style=for-the-badge)
![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?style=for-the-badge)

> [!IMPORTANT]
> Trata-se de um aplicativo desenvolvida como parte do desafio final do Bootcamp GitHub Copilot - Código na Prática da [Digital Innovation One](https://www.dio.me)

## Sobre

É uma aplicativo Web desenvolvido com e Blazor WebAssembly e .NET 10, aplicando técnicas de _prompt engineering_ para obter resultados melhores com o GitHub Copilot que calcula as quantidades de emissões em Kg de meios de transportes.

> [!WARNING] > **Limitações:**
> Os fatores de emissão de cada meio de transporte está fixo por praticidade e limitam-se a: bicicleta, carro, ônibus e caminhão.

## Tecnologias Utilizadas

- [.NET 10](https://dot.net)
- [ASP.NET Core](https://asp.net)
- [Blazor WebAssembly](https://blazor.net)
- [GitHub Copilot](https://github.com/features/copilot)

## Funcionalidades

- Calcula a quantidade em Kg de emissões de CO₂ com base nos fatores de emissão por meio de transporte;
- Exibe quantidade de créditos de carbono que podem ser obtidos.

## Como testar localmente

### Pré-requisitos

- SDK do .NET 10 instalado em sua máquina.

### Executando o Aplicativo

1. Clone o repositório ou baixe o código-fonte.
2. Abra um terminal e navegue até o diretório do projeto.
3. Execute o seguinte comando para compilar o projeto:

   ```sh
   dotnet build
   ```

4. Após compilar, execute o aplicativo com:

   ```sh
   dotnet run
   ```

## Autor

[Rene Bentes Pinto](http://github.com/renebentes)

## Contribuindo

Contribuições são bem-vindas!

Se você achar algum problema ou tiver sugestões para melhorias, por favor, abra uma [_Issue_][issues] ou envie uma [_Pull Request (PR)_][pulls] para nosso [repositório][repo].

Você também pode verificar as _Issues_ e _Pull Requests_ existentes com os quais poderia ajudar.

Ao contribuir com este projeto, por favor, siga o estilo de codificação existente, use [conventional commits][commits] em suas mensagens de commit e submeta suas alterações em uma branch separada.

## Notas de Lançamento

Você pode [ver as notas de lançamento aqui.](CHANGELOG.md)

## Licença

Copyright (c) 2026 Rene Bentes Pinto

Este projeto está sob a licença **MIT**. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

[repo]: http://github.com/renebentes/CarbonCalculator
[issues]: ../../issues
[pulls]: ../../pulls
[commits]: https://www.conventionalcommits.org/en/v1.0.0/
