using System;

namespace EjercicioI03LosPrimos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            mostarPrimosDeNumeroSolicitado();
        }


        /*
         *  Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario por consola.
            Validar que el dato ingresado por el usuario sea un número.
            Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".
            Si ingresa "salir", cerrar la consola.
            Al finalizar, preguntar al usuario si desea volver a operar. Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.
        */

        private static string ingresar(string texto)
        {
            string retorno;
            Console.Write(texto);
            retorno = Console.ReadLine();
            return retorno;
        }

        /// <summary>
        /// solicito un numero, si escribo "salir" salgo, de lo contrario, muestro todos los números primos del numero 
        /// ingresado
        /// </summary>
        /// <returns></returns>
        private static string mostarPrimosDeNumeroSolicitado()
        {
            string retorno = "";
            int numero = 0;
            string valor = "";
            bool error = false;
            do
            {
                valor = ingresar("\nIngrese un número :");
                if(valor.ToLower() == "salir")
                {
                    break; // salgo del do while
                }
                error = esNumero(valor);
                if(!error)
                {
                    Console.WriteLine("Ingrese un número o teclee \"salir\" para terminar");
                }
                else
                {
                    numero = int.Parse(valor);
                    calcularPrimosHasta(numero);

                }

            } while (error);
            return retorno;
        }

        /// <summary>
        /// prueba todos los numeros desde el 0 hasta el numero ingresado mostrando los primos 
        /// </summary>
        /// <param name="numero"></param>
        private static void calcularPrimosHasta(int numero)
        {
            for(int i = 0; i < numero; i++)
            {
                if(esPrimo(i))
                {
                    Console.Write(" {0} ,", i.ToString());
                }
            }

        }
        /// <summary>
        /// verifica si un numero es primo
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>true si es divisible por sí mismo y la unidad</returns>
        private static bool esPrimo(int numero)
        {
            bool esPrimo = true;
            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    esPrimo = false;
                    break;
                }


            }
            return esPrimo;
        }

        /// <summary>
        /// recibe un string que no debe contener ningún número
        /// </summary>
        /// <param name="expresion">string a evaluar</param>
        /// <returns>false si hay una letra en la cadena, true si no se encontró ninguna letra</returns>
        private static bool esNumero(string expresion)
        {
            bool retorno = false;
            foreach(char caracter in expresion)
            {
                retorno = false;
                for (int i = 0; i < 9; i++)
                {
                    if(i.ToString() == caracter.ToString())
                    {
                        retorno = true;
                        break;// salgo del bucle que compara con numeros
                    }
                }
                if(!retorno)
                {
                    break;// si encontré una letra, no sigo buscando el resto de la cadena
                }
            }
          return retorno;
        }



    }
}
