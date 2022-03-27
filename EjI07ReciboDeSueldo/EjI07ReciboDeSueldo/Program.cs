using System;

namespace EjI07ReciboDeSueldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidadEmpleados = ingresarIN("Ingrese cantidad de empleados : ");
            for(int i = 0; i < cantidadEmpleados; i++)
            {
                calcularReciboUnEmpleado();
            }
        }


        private static void calcularReciboUnEmpleado()
        {
            decimal importeAcobrarBruto = 0;
            decimal importeAcobrarNeto = 0;
            decimal descuento = 0.13M;
            decimal calculoDescuento = 0;
            string nombre = ingresarST("Ingrese el nombre del empleado ");
            decimal valorHora = ingresarDE("Ingrese el valor hora de su trabajo ");
            int antiguedadEnAños = ingresarIN("Ingrese la cantidad de años de antiguedad ");
            int horasTrabajadas = ingresarIN("Ingrese la cantidad de horas trabajadas ");
            importeAcobrarBruto = valorHora * horasTrabajadas + (antiguedadEnAños * 150);
            calculoDescuento = importeAcobrarBruto * descuento;
            importeAcobrarNeto = importeAcobrarBruto - calculoDescuento;

            Console.WriteLine(" Empleado {0} ", nombre);
            Console.WriteLine(" Antiguedad {0} ", antiguedadEnAños);
            Console.WriteLine(" Valor hora {0} ", valorHora);
            Console.WriteLine(" Total a cobrar en bruto {0} ", importeAcobrarBruto);
            Console.WriteLine(" descuento {0} ", calculoDescuento);
            Console.WriteLine(" Total a cobrar en neto {0} ", importeAcobrarNeto);

        }



        private static string ingresarST(string texto)
        {
            string devolver = "";
            Console.Write(texto);
            devolver = Console.ReadLine();
            return devolver;
        }

        private static decimal ingresarDE(string texto)
        {
            decimal devolver = 0;
            string retorno;
            bool ok = false;
            do
            {
                Console.Write(texto);
                retorno = Console.ReadLine();
                ok = decimal.TryParse(retorno, out devolver);

                if (!ok)
                {
                    Console.WriteLine("Ingrese un numero decimal por favor ");
                }
            }
            while (!ok);

            return devolver;
        }

        private static int ingresarIN(string texto)
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
                    Console.WriteLine("Ingrese un numero entero por favor ");
                }
            }
            while (!ok);

            return devolver;
        }
    }
}
