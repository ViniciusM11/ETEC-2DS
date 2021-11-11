const express = require('express');
const config = require('config');
const app = express();

app.use(require('./route'));

app.listen(
    config.get('api.porta'),
    () => {
        console.log('Rodando em -> http://localhost:3000');
    }
);