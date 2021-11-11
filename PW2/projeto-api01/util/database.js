const mysql = require("mysql");

const mysqlConnection = mysql.createConnection({
  host: "localhost:3306",
  user: "root",
  password: "",
  database: 'cadastro',
});

mysqlConnection.connect( (error) => {
    if(error){
        console.log('ERRO AO CONECTAR COM O BANCO DE DADOS => ${error}');


    }else{
        console.log('CONEXÃO EFETUADA COM SUCESSO!')

    }
});