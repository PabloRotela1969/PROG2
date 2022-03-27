using System;

namespace EjI05centroNumerico
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int numero = 0;
            numero = ingresar("Ingrese un numero para probar si hay centrales dentro : ");
            ProbarDistintosNumerosParaEncontrarCentroNumerico(numero);
        }


        private static void ProbarDistintosNumerosParaEncontrarCentroNumerico(int hasta)
        {
            for(int i = 1; i < hasta; i++)
            {
                verificarSiEnconteCentroNumerico(hasta, i);
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



        private static void verificarSiEnconteCentroNumerico(int hasta , int candidato)
        {

            int acumuladoIzquierda;
            int acumuladoDerecha;
            string cuentaIzquierda = "";
            string cuentaDerecha = "";
            
            acumuladoDerecha = 0;
            acumuladoIzquierda = 0;
            cuentaDerecha = "";
            cuentaIzquierda = "";
            for(int izquierda = 1; izquierda < candidato; izquierda++)
            {
                acumuladoIzquierda += izquierda;
                cuentaIzquierda = cuentaIzquierda + izquierda.ToString() + " + ";
            }

            for(int derecha = candidato + 1; derecha <= hasta; derecha++)
            {
                acumuladoDerecha += derecha;
                cuentaDerecha = cuentaDerecha + derecha.ToString() + " + ";
            }
            if(acumuladoIzquierda == acumuladoDerecha)
            {
                Console.WriteLine("Encontré al {0} como centro ", candidato);
                Console.WriteLine("porque {0} = {1} \n {2} = {3} ", cuentaIzquierda, acumuladoIzquierda, cuentaDerecha, acumuladoDerecha);
            }

        }

    }
}
