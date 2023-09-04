function caucularPromocao()
{
    var produto = document.getElementById("InProduto").value;
    var preco =  document.getElementById("InPreco").value;

    var promocao = preco * 0.5;

    var precoTotal = (preco * 2) + promocao;

    document.getElementById("outProduto").textContent = produto + " Promoção Leve 3 por R$: " + precoTotal.toFixed(2); 
    document.getElementById("outPreco").textContent = "O 3 Produto sai por R$: " + promocao.toFixed(2);


}

  var show = document.getElementById("btnMostrar");

  show.addEventListener("click", caucularPromocao);