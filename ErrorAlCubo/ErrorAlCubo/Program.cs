using System;

namespace ErrorAlCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            calcularPotencias(ingresarNumeroValidando());
            Console.ReadKey();
        }

        public static int ingresarNumeroValidando()
        {
            string valor = "";
            int error = 0;
            int numero = 0;
            do
            {
                error = 0;
                Console.Write("Ingrese el numero : ");
                valor = Console.ReadLine();
                if(valor != "")
                {
                    numero = int.Parse(valor);
                    if (numero < 1)
                    {
                        Console.WriteLine("ERROR : reingrese el numero!!!");
                        error = 1;
                    }
                }
                else
                {
                    Console.WriteLine("Ingrese un numero por favor!");
                    error = 1;
                }

            } while (error == 1);
            
            return numero;
        }

        public static void calcularPotencias(int numero)
        {
            double cuadrado = Math.Pow(numero, 2);
            double cubo = Math.Pow(numero, 3);
            Console.WriteLine("El cuadrado de {0} es {1} y el cubo es {2}", numero, cuadrado, cubo);
        }

    }
}
