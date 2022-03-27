using System;

namespace EjI04númeroPerfecto
{
    internal class Program
    {
        /*
         * Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos (excluido el mismo) que son divisores del número.

            El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.

            Escribir una aplicación que encuentre los 4 primeros números perfectos.
        */
        static void Main(string[] args)
        {
            busquedaDeNumerosPerfectos();
        }

        private static void busquedaDeNumerosPerfectos()
        {
            int suma = 0;
            int contadorDeEncontrados = 1;
            int i = 1;

            do
            {
                suma = 0;
                for (int j = 1; j < i; j++)
                {
                    if(esDivisorDe(i,j))
                    {
                        suma = suma + j;
                    }
                }
                if(suma == i)
                {
                    Console.WriteLine("\nEncontré al {0} como suma de sus divisores ",i);
                    contadorDeEncontrados++;
                }
                i++;
            } 
            while(contadorDeEncontrados <= 4);
        }



        private static bool esDivisorDe(int numero1, int numero2)
        {
            bool resultado = false;

            decimal resultadoDecimal;
            
            resultadoDecimal = numero1 % numero2;
            if(resultadoDecimal == 0)
            {
                resultado = true;
            }

            return resultado;
        }



    }
}
