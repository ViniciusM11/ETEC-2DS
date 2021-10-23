const roteador = require('express').Router()

roteador.use(
    '/',
    async(requisicao, resposta) => {
        resposta.send(
            JSON.stringify('OK')
        )
    }
)

module.exports = roteador
