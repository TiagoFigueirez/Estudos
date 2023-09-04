function PromocaoMed()
{
    var getMed =document.getElementById("InMedicamento").value;
    var getPreco = document.getElementById("InPreco").value;

    var PrecoDuasUni = Math.floor(getPreco*2); 

    document.getElementById("outMedicamento").textContent="Promoção de " + getMed;
    document.getElementById("outPromocao").textContent="Leve 2 por apenas R$: " + PrecoDuasUni.toFixed(2);

}

var btnMostrar = document.getElementById("btnPromocao");
btnMostrar.addEventListener("click", PromocaoMed);
