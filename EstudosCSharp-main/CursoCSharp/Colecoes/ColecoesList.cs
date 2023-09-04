namespace CursoCSharp.Colecoes
{
    public class produto
    {
        public string Nome;
        public double Preco;
        public produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public override bool Equals(object? obj)//este metodo pertence a aula igualdade e permite que seja comparado o valor dos dados e não o espaço de memoria 
        {                                       //
            produto outro = (produto)obj;
            bool mesmoNome = Nome == outro.Nome;
            bool mesmoPreco = Preco == outro.Preco;
            return mesmoNome && mesmoPreco;
        }
        public override int GetHashCode()//esse metodo serve pra verificar o tamanho de setring de uma colecoes do tipo se
        { // o hashcode server para filtrrar quais
          // itens tem a mesma quantidade de carcacteres para o   Equals comparar pra ver se e igual impedindo a criação de itens iguais
            return Nome.Length;
        }
    }
    internal class ColecoesList
    {
        static public void Executar()
        {
            var Livro = new produto("Game pf Thrones", 49.99);

            var carrinho = new List<produto>();  // o que fica entre os sinais de maior ou menos fica o tipo
                                                 // de dado que podera entrar na list
            carrinho.Add(Livro);
            var combo = new List<produto>()
            {
                new produto("camisa",29.90),
                new produto("8 temporada",80.00),
                new produto("caneca",17.90)
            };

            carrinho.AddRange(combo);//add mais de um item a lista
            Console.WriteLine(carrinho.Count);//mosta a quantidade de itens
            carrinho.RemoveAt(3);// remove item da lista

            foreach (var item in carrinho)
            {
                Console.Write(carrinho.IndexOf(item));// diz qual e o numero que o item esta de 0 a 3
                Console.WriteLine($" {item.Nome}{item.Preco}");
            }
        }

    }
}
