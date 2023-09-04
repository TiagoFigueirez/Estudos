namespace CursoCSharp.ClasseEMetodos
{
    public class moto
    {
        private string Marca; // se não colocar se e public ou private por padrão fica private
        private string Modelo;
        private uint Clindrada;// uint e uma variavel que impede o sinal negativo

        public moto(string marca, string modelo, uint clindrada)
        {
            //Marca = marca;
            //Modelo = modelo;
            //Clindrada = clindrada;
            SetMarca(marca);//impede que seja setado valor negat
            SetModelo(modelo);
            SetClindrada(clindrada);
        }
        public moto()
        {

        }
        public string GetMarca()
        {
            return Marca;
        }
        public void SetMarca(string marca)
        {
            Marca = marca;
        }
        public string GetModelo()
        {
            return Modelo;
        }
        public void SetModelo(string modelo)
        {
            Modelo = modelo;
        }
        public uint GetClindrada()
        {
            return Clindrada;
        }
        public void SetClindrada(uint clindrada)
        {
            // opção 1 
            //if (clindrada > 0) //metodo getset permite colocar controladores para atribuição nesse caso impede
            //                    clindrada negativa
            //{
            //    Clindrada = clindrada;
            //}
            //opção 2
            //Clindrada = Math.Abs(clindrada);pega o valo negativo e transformar em positivo outro metodo
            Clindrada = clindrada;
        }
    }


    internal class GetSet
    {
        public static void Executar()
        {
            var moto1 = new moto("Kawasaki", "Nninja ZX-R ", 636);

            Console.WriteLine(moto1.GetMarca());//como são privado não podemos acessar diretamente os atributos
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetClindrada());
        }
    }
}
