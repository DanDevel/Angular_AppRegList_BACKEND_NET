# API com Swagger
Este é um projeto de API com Swagger desenvolvido em C# .NET. A API foi construída seguindo as melhores práticas de arquitetura, utilizando os princípios do DDD (Domain-Driven Design) e Clean Code, visando alta qualidade, escalabilidade e manutenibilidade do código.

## Recursos
A API oferece os seguintes recursos:

## Registro de Dados: 
Permite o registro de dados através de um endpoint específico. Os dados são enviados em formato JSON.

## Visualização de Dados: 
Disponibiliza um endpoint para recuperar os dados registrados. Os dados são retornados em formato JSON, permitindo a visualização de todos os registros ou a busca por um registro específico. Seja utilizando requisições async, sync ou conceito de B2F Backend to FrontEnd.

## Arquitetura e Design
O projeto segue a arquitetura DDD (Domain-Driven Design), que promove a organização e separação de responsabilidades por domínio. 
Também adotamos as práticas do Clean Code, que envolvem a escrita de código legível, modular e de fácil manutenção.

# O projeto está estruturado em camadas, incluindo:

## Camada de Apresentação: 
Contém os controladores responsáveis por receber as requisições HTTP e fornecer as respostas adequadas.

## Camada de Aplicação: 
Responsável pela lógica de negócio e coordenação das operações entre as diferentes camadas.

## Camada de Domínio DDD: 
Contém as entidades e regras de negócio do domínio da aplicação.

## Camada de Infraestrutura CC: 
Lida com detalhes de implementação, como persistência de dados, acesso a serviços externos e configuração da API.

## Autenticação JWT
A API foi projetada para suportar autenticação baseada em JWT (JSON Web Token). Isso significa que, para acessar determinados recursos, é necessário enviar um token JWT válido junto com a requisição. A autenticação é realizada através do middleware de autenticação fornecido pelo ASP.NET Core.
Para esta demo, esta funcionalidade não foi solicitada, está presente no código para preparação de futuras integrações.

## CORS (Cross-Origin Resource Sharing)
O projeto está configurado para permitir requisições de qualquer origem (CORS), permitindo a integração com diferentes clientes. Isso é alcançado através da configuração adequada no arquivo Startup.cs, onde são definidas as políticas de CORS.
Para este projeto o CORS permite requisições sem restrições. Por se tratar de um dos recursos presentes no projeto que não foram solicitados.

## Tecnologias Utilizadas

### C# .NET: 
Uma plataforma de desenvolvimento robusta e amplamente utilizada para construir aplicativos web e serviços.

### ASP.NET Core: 
Um framework de desenvolvimento web rápido e modular que fornece recursos avançados para a construção de APIs.

### Swagger: 
Uma ferramenta de documentação e geração de código para APIs RESTful. Permite a visualização e interação com a API por meio de uma interface intuitiva.

### JWT: 
JSON Web Tokens são utilizados para autenticação e troca segura de informações entre partes.

### Entity Framework Core: 
Um ORM (Object-Relational Mapping) que simplifica o acesso e manipulação de dados no banco de dados.


## Como Executar
Clone o repositório para a sua máquina local.
Abra o projeto utilizando a IDE de sua preferência (por exemplo, Visual Studio ou Visual Studio Code).
Certifique-se de ter o .NET Core SDK instalado.
No terminal, navegue até a pasta raiz do projeto.
Execute o comando dotnet run para iniciar a API.
Acesse a documentação da API em http://localhost:<porta>/swagger, onde <porta> é a porta configurada para a execução da API.
Esse README detalhado destaca as principais características e tecnologias utilizadas no projeto da API com Swagger. Ele demonstra nosso comprometimento com a qualidade de código, segurança e documentação adequada.
  

# PRINTS do sistema:
  
## SWAGGER - HOME:
https://github.com/DanDevel/Angular_AppRegList_BACKEND_NET/blob/main/PrintsDoSistema/SWAGGER_home.png
  
## SWAGGER - GET Request:
https://github.com/DanDevel/Angular_AppRegList_BACKEND_NET/blob/main/PrintsDoSistema/SWAGGER_GetRequest.png
  
## SWAGGER - GET Request ID:
https://github.com/DanDevel/Angular_AppRegList_BACKEND_NET/blob/main/PrintsDoSistema/SWAGGER_GetRequest_ID.png

  
  
