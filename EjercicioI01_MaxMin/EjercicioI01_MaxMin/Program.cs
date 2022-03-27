using System;

namespace EjercicioI01_MaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            ingresarNumerosYPromedios();
            Console.ReadKey();
        }

        public static void ingresarNumerosYPromedios()
        {
            int ingresado = 0;
            int minimo = 0;
            int maximo = 0;
            int total = 0;
            float promedio = 0.0f;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Ingrese un numero : ");
                ingresado = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    maximo = ingresado;
                    minimo = ingresado;
                }

                if (minimo < ingresado)
                    minimo = ingresado;
                if (maximo > ingresado)
                    maximo = ingresado;

                total += ingresado;
            }
            promedio = total / 5;
            Console.WriteLine(" minimo {0} , maximo {1} , promedio {2} ", minimo, maximo, promedio);
        }
    }
}
