const express = require('express');
const app = express();
const port = 3000;

/* IMPORTA O MÓDULO DO SEQUELIZE: */
const Sequelize = require('sequelize');

/* INSTANCIAR UM OBJETO DO SEQUELIZE: 
PARAMETROS:
1º - O NOME DO BANCO DE DADOS - OK
2º - USUÁRIO - OK
3º - SENHA - OK
4º - OBJETO JSON: HOST DO BANCO DE DADOS, DIALECT (SGBDR -> MARIADB OU MYSQL)
*/
const sequelize = new Sequelize('sistemacadastro', 'root', '', { host: 'localhost', dialect: 'mariadb' });

/* CONEXÃO COM BANCO DE DADOS: */
sequelize.authenticate()
.then(

  ()=>{ console.log('CONECTADO AO BANCO DE DADOS!'); }

).catch(

  (error)=>{

      console.log(`ERRO?: ${error}`);

  }
  
);

          

/* SERVIDOR: */
app.listen(port, function(){
    console.log(`SERVIDOR RORANDO NA URL: http://localhost:${port}`);
});