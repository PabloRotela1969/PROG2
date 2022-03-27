using System;

namespace EjI06AñosBisiestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int desde = ingresar("Ingrese un año inicial ");
            int hasta = ingresar("Ingrese un año final ");
            probarRangoDeAñosSiSonBisiestos(desde,hasta);
        }

        public static void probarRangoDeAñosSiSonBisiestos(int desde, int hasta)
        {
            bool esMultiploDe4 = false;
            bool esMultiploDe100 = false;
            bool esMultiploDe400 = false;
            bool esBiciesto = false;
            for(int i = desde; i < hasta; i++)
            {
                esMultiploDe4 = esMultiplo(i, 4);
                esMultiploDe100 = esMultiplo(i, 100);
                esMultiploDe400 = esMultiplo(i, 400);
                if(esMultiploDe4 && !esMultiploDe100)
                {
                    esBiciesto = true;
                }
                else
                {
                    if(esMultiploDe100 && esMultiploDe400)
                    {
                        esBiciesto=true;
                    }
                }
                if(esBiciesto)
                {
                    Console.WriteLine("El año {0} es biciesto ", i);
                    
                }
                esBiciesto = false;
            }

        }


        private static bool esMultiplo(int numero, int de)
        {
            bool respuesta = false;
            respuesta = (numero % de) == 0;
            return respuesta;
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
