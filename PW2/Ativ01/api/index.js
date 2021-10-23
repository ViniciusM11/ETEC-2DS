
const express = require ('express');

const App= express();
const bodyParser = require('body-parser');

App.use(bodyParser.json());

//ROTA Forn
const rote1 = require('./rotas/Fornecedores');
App.use('/api/fornecedores', rote1);
//Rota Ped
const rote2 = require('./rotas/Pedidos');
App.use('/api/pedidos', rote2);
//Rota Pag
const rote3 = require('./rotas/Pagamentos');
App.use('/api/pagamentos', rote3);
//Rota Prod
const rote4 = require('./rotas/Produtos');
App.use('/api/produtos', rote4);
//Rpta Vend
const rote5 = require('./rotas/Vendedores');
App.use('/api/vendedores', rote5);

App.listen(8080, () => console.log('API em uso....'));