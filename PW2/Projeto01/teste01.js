/*
DECLARAÇÃO DE VARIÁVEIS
- var
- let
- const
*/
/* EXEMPLO DE DECLARAÇÃO COM var */
// var conteudo = 'ETEC DE BARUERI - DS - PW2';
// console.log(conteudo);
// conteudoVAr = 'ETEC DE BARUERI - DS - PW2 - VAR';
// console.log(conteudoVAr);
// var conteudoVAr;
/* EXEMPLO DE DECLARAÇÃO COM let */
let conteudoLet;
conteudoLet = 'ETEC DE BARUERI - DS - PW2 - LET - 1';
console.log(conteudoLet);
conteudoLet = 'ETEC DE BARUERI - DS - PW2 - LET - 2';
console.log(conteudoLet);
/* EXEMPLO DE DECLARAÇÃO COM const */
const conteudoConst = 'ETEC DE BARUERI - DS - PW2 - CONST - 1';
console.log(conteudoConst);
// conteudoConst = 'ETEC DE BARUERI - DS - PW2 - CONST - 2';
// console.log(conteudoConst);

/* DECLARAÇÃO DE VARIÁVEIS */
let escola = 'ETEC DE BARUERI';
let curso = 'DESENVOLVIMENTO DE SISTEMAS';
let componente = 'PROGRAMAÇÃO WEB 2';

let num1 = 10;
let num2 = 10;

/* SAÍDA DAS VARIÁVEIS CONCÁTENADAS*/
console.log(escola, ' - ', curso, ' - ', componente);
console.log(escola + ' - ' + curso + ' - ' + componente);

/* SAÍDA DAS VARIÁVEIS TEMPLATES STRING*/
console.log(`ESCOLA: ${escola} CURSO: ${curso} COMPONENTE: ${componente}`);

/* SAÍDA DE UM CALCULO - TEMPLATE STRINGS */
console.log(`MUMTIPLICAÇÃO: ${ num1 * num2 }`);