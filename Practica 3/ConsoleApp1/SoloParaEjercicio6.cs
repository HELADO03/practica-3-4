using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SoloParaEjercicio6
    {
        public  void  cambioDollar() 
        {
            int dolar;
            int pesos;
            int convercion = 59;

            Console.WriteLine("la tasa del dolar es: " + convercion + " en pesos dominicanos\n");
            Console.WriteLine("introduzca los dolares que desea convertir");
            dolar = int.Parse(Console.ReadLine());
            pesos = dolar * convercion;
            Console.WriteLine("\nusted tiene: " + pesos + " en pesos dominicanos");

            Console.ReadKey();
        }

        public void cambioCelcius() 
        {
            Console.WriteLine("Introduzca la cantidad de grados Fahrenheit que desea convertir: ");
            int f =int.Parse (Console.ReadLine());
            int convercion;
            convercion = (f - 32) * 5 / 9;
            Console.WriteLine("\nEsa ccantidad de grados Fharenheit equivalen a: " + convercion + " en grados Celsius");

            Console.ReadKey();
        }
        public void cambioMetros()
        {
            double metros;
            double pies;

            Console.WriteLine("introduzaca la distancia en mtros que desea convertir");
            metros = double.Parse(Console.ReadLine());
            pies = metros * 3.2801;
            Console.WriteLine("eso es: " + pies+ " en Kilometros");

            Console.ReadKey();

        }

    }
}
