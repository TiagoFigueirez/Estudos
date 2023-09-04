var inDinheiro = document.getElementById("inDinheiro");
var outNotasCem = document.getElementById("outNotasCem");
var outNotasCinquenta = document.getElementById("outNotasCinquenta");
var outNotasDez = document.getElementById("outNotasDez");

// limpra as nostas em caso de segunda execução
outNotasCem.textContent = "";
outNotasCinquenta.textContent = "";
outNotasDez.textContent = "";


function mostrarCedulas()
{
    var dinheiro = Number(inDinheiro.value);

    if(dinheiro == 0 || isNaN(dinheiro))
    {
        alert("Erro preencha o valor corretamente !");
        inSaque.focus();
        return;
    }
    //verifica se o saque não é múltiplo de 10
    if(dinheiro % 10 != 0)
    {
        alert("valor invalido para notas disponivéis(R$ 10, 20, 50)");    
    }
    var notasCem = Math.floor(saque/100);
    var resto = saque % 100;
    var notasCinquenta = math.floor(resto/50);
    resto = resto % 50;
    var notasDez = Math.floor(rest/10);

    if(notasCem > 0)
    {
        outNotasCem.textContent = "Notas de R$ 100: " + notasCem;
    }
    if(notasCinquenta > 0)
    {
        outNotasCinquenta.textContent = "Notas de R$ 50: " + notasCinquenta;
    }
    if(notasDez > 0)
    {
        outNotasDez.textContent = "Notas de R$ 10: " + notasDez;
    }

}
