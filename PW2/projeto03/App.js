/*
CRIAÇÃO DE UMA WEB-SERVER HTTP COM NODEJS
UTIULIZANDO O PACOTE http NATIVO DO NODEJS
*/
//IMPORTAÇÃO DO MÓDULO HTTP:
const httpServer = require('http');

/*
CRIANDO UMA INSTANCIA DE SERVIDOR HTTP COM NODEJS

O MÉTODO createServer UMA CHAMADA DE UM ESCUTADOR (listen) QUE DEVERÁ INFORMA UMA PORTA
LÓGICA

REQUEST -> REQUISIÇÃO
RESPONSE -> RESPOSTA
*/
httpServer.createServer().listen(3000);
console.log('OK');
console.log('OK2');