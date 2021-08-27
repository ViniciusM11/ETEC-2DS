/* IMPORTAÇÕES DE PACOTES: */
const express = require('express');

/* INSTANCIAS DE PACOTES: */
const app = express();

/* ROTAS */
app.use(require('./routes'));

/* INSTANCIA DO SERVIDOR EXPRESS: */
app.listen(3000,
    () => {
        console.log('SERVIDOR RODANDO NA URL -> http://localhost:3000');
    }

);