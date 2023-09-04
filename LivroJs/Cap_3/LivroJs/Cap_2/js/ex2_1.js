//declara a função
function mostrarOla() {
    //obem o conteudo do campo(id=) nome
    var nome = document.getElementById("nome").value;
    //exibe no paragro("resposta"):"Ola" e o nome informado
    document.getElementById("resposta").textContent = "Ola " + nome;
}
// cria uma referência ao botão(com id=) mostrar
var mostrar = document.getElementById("mostrar");
mostrar.addEventListener("click", mostrarOla);
/*esse metodo também serve para dizer oque o vendto click vai (ou outro evendo) adicionamos o evento em um
ea função a ser executada no outro*/




/*aqui acessamo diretamente a propriedade que queremos alterar
var nome= document.getElementById("nome").Value;
document.getElementById("resposta").textContent = "Olá "+ nome;
 para referenciar um elemento html que vai sar usado na programação utilizamos o document para
dizer que estamos pégando do documento e em seguida a função getElementById para referencia o Id
do elemento que vamos programar, textContent altera o texto de um H1 ou p para o conteudo atribuido 
temos também o inner.html

var mostrar = document.getElementById("mostrar");
mostrar.onclick = mostrarOla;
var inputNome= document.getElementById("nome");

var nome = inputNome.Value; essa forma e interessante quando o elemento sera acessado mais de uma vez
value e o comando para obter o valor digitado no campo
aqui armazenamos o momento de pegar o click do botão em uma variavel em seguida acessamos a propriedade clieck
e adicionamos a função nela*/