/* IMPORTAÇÕES DE PACOTES: */
const express = require('express');

/* INSTANCIAS DE PACOTES: */
// const app = express();

/* INSTANCIA O RECURSO DE ROTAS DO express: */
const router = express.Router();

/* 
ROTA DE PESQUISA GERAL (GET) 
TODA ROTA DEVE SER COMPOSTA DE:
    - UM VERBO HTTP (GET, POST, PUT E DELETE), ONDE NO EXPRESS CADA VERBO HTTP É REPRESENTADO POR UM MÉTODO, EXEMPLOS: get(), post(), put().
    DENTRO DO CABEÇALHO DE PARAMETRO D OMÉTODO DO VERBO DEVEMOS PASSAR PELO MENOS DOIS PARAMETROS, SENDO ESSE:
    - 1º PARAMETRO - O NOME DA ROTA, EXEMPLO: router.get(1º parametro)
                               router.get('/list')
    
    - 2º PARAMETRO - A AÇAO QUE O MÉTODO DO VERBO HTTP DEVE EXECUTAR, 
    EXEMPLO: router.get(1º parametro, 2º parametro)
             router.get('/list', function(){.....})
             router.get('/list', ()=>{})
    O SEGUNDO PARAMETRO É UM CALLBACK, OU SEJA, A CHAMDA DE UYMA FUNÇÃO QUE VAI EXECUTAR A TAREFA DO MÉTODO.
    
*/
router.get('/list', (request, response) => {

    response.send('ESSE É O MÉTODO DE LISTAGEM GERAL DE DADOS!')

});

/* ROTA DE INSERÇÃO (POST) */
router.post('/insert', (request, response) => {

    response.send('ESSE É O MÉTODO DE INSERÇÃO DE DADOS!')

});

/* ROTA DE ALTERAÇÃO (PUT) */
router.put('/alter', (request, response) => {

    response.send('ESSE É O MÉTODO DE ALTERAÇÃO DE DADOS!')

});

/* ROTA DE EXCLUSÃO (DELETE) */
router.delete('/list', (request, response) => {

    response.send('ESSE É O MÉTODO DE EXCLUSÃO DE DADOS!')

});

module.exports = router