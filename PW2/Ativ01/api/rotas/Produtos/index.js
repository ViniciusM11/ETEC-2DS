const roteador = require('express').Router();

roteador.use(
    '/',
    async(requisicao, resposta) => {
        resposta.send(
            JSON.stringify('PRODUTOS OK')
        )
    }
)

module.exports = roteador;