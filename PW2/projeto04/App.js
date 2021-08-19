const express = require('express');

const app = express();

const port = 3000;

/* ROTAS: */
app.get('/', function(request, response){

    response.send('OLÁ!!!');

});

app.get('/cad', function(request, response){

    response.send('ESSA É A PÁGINA DE CADASTRO!');

});

app.get('/pessoa/:nome/:sobrenome', function(request, response){

    console.log(request.params);
    // let nome = request.params.nome;
    // let sobrenome = request.params.sobrenome;

    //DESTRUCT:
    let {nome, sobrenome} = request.params;


    response.send(`NOME: ${nome} SOBRENOME: ${sobrenome}`);

})

/* SERVIDOR: */
app.listen(port, function(){
    console.log(`SERVIDOR RODANDO NA URL: http://localhost:${port}`);
});