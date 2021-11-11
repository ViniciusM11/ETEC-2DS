const express = require('express');

const router = express.Router();

//C
router.post(
    '/insert', (request, response) => {
        response.send('Executando o POST');
    }
);

//R
router.get(
    '/list', (request, response) => {
        response.send('Executando o GET');
    }
);

//U
router.put(
    '/alter', (request, response) => {
        response.send('Executando o PUT');
    }
);

//D
router.delete(
    '/delete', (request, response) => {
        response.send('Executando o DELETE');
    }
);


module.exports = router