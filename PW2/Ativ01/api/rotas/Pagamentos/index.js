const roteador = require('express').Router();

roteador.use(
    '/',
    async(requisicao, resposta) => {
        resposta.send(
            JSON.stringify('PAGAMENTOS OK')
        )
    }
)

module.exports = roteador;