namespace CursoCSharp.ClasseEMetodos
{
    internal class Struct
    {
        interface ponto
        {
            void MoverNaDiagonal(int delta);
        };
        struct Coordenada : ponto
        {
            public int X;
            public int Y;

            public Coordenada(int x, int y)
            {
                X = x;
                Y = y;
            }
            public void MoverNaDiagonal(int delta)
            {
                X += delta;
                Y += delta;
            }
        }


        public static void Executar()
        {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;
            Console.WriteLine("Coordenada Inicial:");
            Console.WriteLine("X é:{0}", coordenadaInicial.X);
            Console.WriteLine("Y é:{0}", coordenadaInicial.Y);

            var coordenadaFinal = new Coordenada(x: 6, y: 9);
            coordenadaFinal.MoverNaDiagonal(10);

            Console.WriteLine("Coordenada Final:");
            Console.WriteLine("X é:{0}", coordenadaFinal.X);
            Console.WriteLine("Y é:{0}", coordenadaFinal.Y);

        }
    }
}
