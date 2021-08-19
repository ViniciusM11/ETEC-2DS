/* DECLARAÇÃO DE VARIÁVEIS */
let escola = 'ETEC DE BARUERI';
let curso = 'DESENVOLVIMENTO DE SISTEMAS';
let componente = 'PROGRAMAÇÃO WEB 2';

let num1 = 10;
let num2 = 10;

/* SAÍDA DAS VARIÁVEIS - CONCATENADAS */
console.log(escola, ' - ', curso, ' - ', componente);
console.log(escola + ' - ' + curso + ' - ' + componente);


/* SAÍDA DAS VARIÁVEIS - TEMPLATE STRINGS */
console.log(`ESCOLA: ${escola} CURSO: ${curso} COMPONENTE: ${componente}`);


/* SAÍDA DE UM CALCULO - TEMPLATE STRINGS */
console.log(`MULTIPLICAÇÃO: ${ num1 * num2 }`);