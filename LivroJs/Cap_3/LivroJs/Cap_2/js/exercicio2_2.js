function CalcularValor()
{
    var getValorMin = document.getElementById("InValorMin").value;
    var getTempoUso = document.getElementById("InTempoUso").value;

    var valor= Math.ceil(getTempoUso/15) * getValorMin;

    document.getElementById("outValorPagar").textContent = "Valor a Pagar R$: " + valor.toFixed(2);

}

var outValor = document.getElementById("btnCaucular");

outValor.addEventListener("click",CalcularValor);