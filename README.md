# nicoletiweathermusic

Utilizar o usuario Git (somente nome) para autenticar.

https://nicoletiweathermusic.herokuapp.com/index.html

SMD
https://app.lucidchart.com/documents/view/c9cb905d-26ec-4b01-ace9-1926477b5312/0_0

Documentação

Para a construção da API foi utilizado o dotnet core versão 3.1.
Fazendo do pacote de criação webapi do dotnet core, este já proporciona um ambiente prémoldado para aplicações REST.
Para a conexão com banco de dados foi utilizado o pacote EntityFrameWork Core, com extensão para banco de dados POSTGRE.
A opção pelo banco de dados Postgre, se deu pelo fato do hospedeiro sugerido, Heroku, ter a possibilidade trabalho gratuito com o mesmo.
Para documentação da API, foi utilizado o Swagger (Swashbuckle) na versão mais recente.
Para autenticação do ambiente, foi escolhido o modo Jwt com Bearer, pois este proporciona uma autenticação simples e rápida.
Para acessar API externa (OpenWeather) foi utilizado o pacote Refit.
Para trabalho das classes em JSON foi utilizado o pacote NewtonSoft.
