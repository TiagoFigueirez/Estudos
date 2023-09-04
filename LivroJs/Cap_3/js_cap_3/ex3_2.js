var inNome= document.getElementById("inNome");
var inAltura= document.getElementById("inAltura");
var rbMasculino= document.getAnimations("rbMasculino");
var rbFeminino= document.getElementById("rbFeminino");
var outResposta= document.getElementById("outResposta");


function CalcularPeso()
{
    var nome = inNome.value;
    var altura = Number(inAltura.value);
    var masculino = rbMasculino.checked;
    var feminino = rbFeminino.checked;

    if(nome == "" || (masculino == false && feminino ==false) )
    {
        alert("Nome ou sexo em branco, preencha os dados corretamente !")
        inNome.focus(); //da um foco no nome pocisionando o cursor no campo
        return;
    }
    if(altura==0 || isNaN(altura))
    {
        alert("Informe a Altura corretamente !");
        inAltura.focus();
        return;
    }
    if(masculino)
    {
        var peso= 22*Math.pow(altura,2);
    }
    else
    {
        var peso= 21*Math.pow(altura, 2);
    }
    outResposta.textContent= nome +" Seu peso Ideal é " + peso.toFixed(3) 
}
var btnCalcularPeso = document.getElementById("btnCalcularPeso");
btnCalcularPeso.addEventListener("click",CalcularPeso);

function limparCampos()
{
    document.getElementById("inNome").value="";
    document.getElementById("inAltura").value="";
    document.getElementById("rbMasculino").checked = false;
    document.getElementById("rbFeminino").checked = false;
    document.getElementById("outResposta").textContent="";

    document.getElementById("inNome").focus();
    //outra forma de fazer e com location.reload(); ele recarrega e assim tira os dados da tela
}

var btnLimparCampos = document.getElementById("btnLimparCampo");
btnLimparCampos.addEventListener("click", limparCampos);

