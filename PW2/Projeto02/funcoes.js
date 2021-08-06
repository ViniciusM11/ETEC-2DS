function calculaQuadrado1(){

    console.log(`QUADRADO DE 10: ${10 * 10}`);

}

calculaQuadrado1();

let num1 = 100;

function calculaQuadrado2(numParam) {
    
    console.log(`QUADRADO DE 10: ${numParam * 10}`);
}

calculaQuadrado2(15);
calculaQuadrado2(num1);

function multiplosParametros(numParam1=0, numParam2=0) {
    
    console.log(`PARÂMETRO1: ${numParam1} PARÂMETRO2: ${numParam2}`);
}

multiplosParametros(num1, 12345);
multiplosParametros(num1);
multiplosParametros();

function calculaQuadrado4(numParam) {
    
    return `QUADRADO DE 10: ${numParam * 10}`;
}

let retorno = calculaQuadrado4(250);

console.log(retorno);