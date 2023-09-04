function MostrarPromocao()
{
    var veiculo = document.getElementById("veiculo").value;
    var preco = document.getElementById("preco").value;

    var entrada = preco * 0.5;

    var parcela = entrada /12;


    document.getElementById("veiculoMostrar").textContent = "Promoção:" + veiculo;
    document.getElementById("descontoMostrar").textContent = "Entrada de R$: " + entrada.toFixed(2);
    document.getElementById("precoParcelado").textContent = "+12x de R$" + parcela.toFixed(2);

}

var mostrar = document.getElementById("btnPromocao");

mostrar.addEventListener("click", MostrarPromocao);