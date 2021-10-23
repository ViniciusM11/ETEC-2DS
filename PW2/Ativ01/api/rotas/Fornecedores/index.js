const roteador = require('express').Router();

roteador.use(
    '/',
    async(requisicao, resposta) => {
        resposta.send(
            JSON.stringify('FORNECEDORES OK')
        )
    }
)

module.exports = roteador;