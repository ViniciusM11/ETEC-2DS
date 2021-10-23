const roteador = require('express').Router();

roteador.use(
    '/',
    async(requisicao, resposta) => {
        resposta.send(
            JSON.stringify('VENDEDORES OK')
        )
    }
)

module.exports = roteador;