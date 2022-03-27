using System;

namespace EjI08DibujandoTriánguloRectángulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad = ingresar("Ingrese cantidad de niveles a dibujar : ");
            dibujarConAsteriscosTrianguloRectangulo(cantidad);
        }

        private static void dibujarConAsteriscosTrianguloRectangulo(int altura)
        {
            for (int i = 1; i <= altura * 2; i++)
            {

                if (i % 2 == 1)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }

                }

                Console.Write("\n");
            }
        }

        private static int ingresar(string texto)
        {
            int devolver = 0;
            string retorno;
            bool ok = false;
            do
            {
                Console.Write(texto);
                retorno = Console.ReadLine();
                ok = int.TryParse(retorno, out devolver);

                if (!ok)
                {
                    Console.WriteLine("Ingrese un numero por favor ");
                }
            }
            while (!ok);

            return devolver;
        }



    }
}
