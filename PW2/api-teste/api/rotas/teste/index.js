const roteador = require('express').Router()

roteador.use(
    '/',
    async(requisicao, resposta) => {
        resposta.send(
            JSON.stringify('Teste OK...')
        )
    }
)

module.exports = roteador
