function CalcularNota() {

    var inAluno = document.getElementById("inAluno");
    var inNota1 = document.getElementById("inNota1");
    var inNota2 = document.getElementById("inNota2");
    var outSituacao = document.getElementById("outSituacao");
    var outMedia = document.getElementById("outMedia");
    var Aluno = inAluno.value;
    var Nota1 = Number(inNota1.value);
    var Nota2 = Number(inNota2.value);
    //para alterar o valor das linhas de respota como a cor temos que armazenar as referencias do campos em uma variavel

    var mediaFinal = (Nota1 + Nota2) / 2;


    outMedia.textContent = "Média das Notas: " + mediaFinal;

    if (mediaFinal >= 7) {
        outSituacao.textContent = "Parabéns" + Aluno + " Você Foi Aprovado!"
        outSituacao.style.color = "blue";
    } else {

        outSituacao.textContent = "Que pena " + Aluno + " Você Foi Reprovado, se esforce mais"
        outSituacao.style.color = "red";

    }
}

var btnMostrar = document.getElementById("btnCalcularNota");
btnMostrar.addEventListener("click", CalcularNota);
