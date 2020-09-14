using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    class Aritmetica
    {
        public static void suma( int a, int b) 
        {
            var resultado = a + b;
            Console.WriteLine(resultado);            
        }
        public static void suma(int a, int b, int c)
        {
            var resultado = a + b + c;
            Console.WriteLine(resultado);
        }

        public static void multiplicar(int a, int b) 
        {
            var resultado = a * b;
            Console.WriteLine(resultado);
        }

        public static void dividir(int a, int b) 
        {
            var resultado = a / b;
            Console.WriteLine(resultado);
        }
        public static void resta(int a, int b) 
        {
            var resultado = a - b;
            Console.WriteLine(resultado);
        }
        public static void resta(int a, int b, int c)
        {
            var resultado = a - b - c;
            Console.WriteLine(resultado);
        }
    }
}
