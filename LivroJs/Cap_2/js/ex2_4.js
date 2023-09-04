function calcularPreco()
{
    var getPrecoQuilo= document.getElementById("InPrecoKg").value;
    var getGramas= document.getElementById("InConsumo").value;

    var Kg = getGramas /1000;

    var TotalPagar = Kg * getPrecoQuilo;

    document.getElementById("resposta").textContent = "Valor a PAGAR R$:"+TotalPagar.toFixed(2);
}

var mostrar = document.getElementById("btnCaucular");
mostrar.addEventListener("click", calcularPreco);