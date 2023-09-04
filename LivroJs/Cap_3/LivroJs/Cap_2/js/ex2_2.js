function ConverterHora()
{
    var titulo =document.getElementById("inTitulo").value;
    var minutos =document.getElementById("InDuracao").value;
    
    //arredondo para baixo o resiltado da divisao
    var horas = Math.floor(minutos / 60);

    //obtem o resto da divisao que sera os miutos
    var minutos = minutos % 60;


    document.getElementById("outTitulo").textContent = titulo;
    document.getElementById("outResposta").textContent =  horas + "hora(s) e " + minutos + "minuto(s)";
}

var mostrar = document.getElementById("btnConverter");

mostrar.addEventListener("click",ConverterHora);