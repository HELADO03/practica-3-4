using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_4
{
    class Carro
    {
        protected string _marca;
        protected string _modelo;
       public double Gasolina;
        private double _cantidadCombustible;
        
        public void encender() 
        {
            int i;
            

           
            _cantidadCombustible = Gasolina;

            for (i = 1; _cantidadCombustible > 0; i++) 
            {
                
                Console.WriteLine("\nVeamos si el vehiculo tiene suficiente combustible para encender");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("El vehiculo esta ensendido");
                Console.ReadKey();
                Console.Clear();
                _cantidadCombustible = _cantidadCombustible - 1;

            }
            Console.WriteLine("\t\t\t\tUPPS el vehiculo se quedo sin galones de gasolina");
            Console.ReadKey();
            
        }

    }
    class CosasDeCarro 
    {
        public void cuantosGalones() 
        {
            Carro a = new Carro();
            Console.WriteLine("Cuantos galones de gasolina tiene su vehiculo?");
            a.Gasolina = double.Parse(Console.ReadLine());
            
            Console.Clear();

            if (a.Gasolina >= 1)
            {
                a.encender();
            }
        }
        
    }
}
