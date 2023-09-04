var inNumero = document.getElementById("inNumero");
var outRaiz = document.getElementById("outRaiz");

function calcularRaiz()
{
    var Numero = Number(inNumero.value);

    if(Numero == 0 || isNaN(Numero))
    {
        alert("Numero em branco, insira um número valido");
        inNumero.focus();
        return;
    }

    var raiz = Math.sqrt(Numero);

    if (raiz == Math.floor(raiz))
    {
        outRaiz.textContent = "raiz quadrada de " + Numero + " é:" + raiz;
        return;

    }
    else
    {
        outRaiz.textContent = "A raiz quadrada de "+ Numero + " Não é exata";
    } 

}
var btnCalcular = document.getElementById("btnCalcularRaiz");
btnCalcular.addEventListener("click",calcularRaiz);
/*Mat.floor verifica se o numero e inteiro pois ele aredonda casas deciamis para baixo ai no caso se o numero da 
raiz for igual a math.floor ou seja sem casas dicmais então a raiz e exata */