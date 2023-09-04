var inHoraBrasil = document.getElementById("InHoraBrasil");
var outHoraFranca = document.getElementById("outHoraFrança");

function calcularFusoHorario()
{
    var horaBrasil = Number(inHoraBrasil.value);

    if(inHoraBrasil.value ==""||isNaN(horaBrasil))
    {
        alert("Insira a hora corretamente !");
        inHoraBrasil.focus();
        return;
    }

    var horaFranca = horaBrasil + 5;

    if(horaFranca >24)
    {
        horaFranca = horaFranca - 24;
    }

    outHoraFranca.textContent = "Hora na França : " + horaFranca.toFixed(2);

}
    var btnCaucularHora = document.getElementById("btnCalcularHora");
    btnCaucularHora.addEventListener("click", calcularFusoHorario);