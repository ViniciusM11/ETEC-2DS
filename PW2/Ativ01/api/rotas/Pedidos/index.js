const roteador = require('express').Router();

roteador.use(
    '/',
    async(requisicao, resposta) => {
        resposta.send(
            JSON.stringify('PEDIDOS OK')
        )
    }
)

module.exports = roteador;