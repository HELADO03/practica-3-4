using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SoloParaElEjercicio8
    {
        public void salarioPrivado() 
        {
            double s, sn;
            Console.WriteLine("Introduzca su salario: ");
            s = double.Parse(Console.ReadLine());

            sn = (s - (s * 0.0591));
            double sna = sn * 12;

            if (sna < 416220.00)
            {
                Console.WriteLine("El salario real anual es:" + " $RD " + sna + "\nSalario neto mensual es: " + " $RD " + sn +
                    " \nEstos salarios son reales porque ya tienen aplicados el descuento de AFP, SRS e IRS correspondiente ");
                Console.ReadKey();
            }
            if (sna >= 416220.01 & sna <= 624329.00)
            {
                double irs = (sna - (sna * 0.15));
                Console.WriteLine("El salario real anual es:" + "$RD " + irs + "\nSalario real mensual es: " + " $RD " + irs / 12 +
                                " \nEstos salarios son reales porque ya tienen aplicados el descuento de AFP, SRS e IRS correspondiente ");
                Console.ReadKey();

            }
            if (sna >= 624329.01 & sna <= 867123.00)
            {
                double irs = (sna - (sna * 0.20));
                Console.WriteLine("El salario real anual es:" + " $RD " + irs + "\nSalario real mensual es: " + " $RD " + irs / 12 +
                    "\n Estos salarios son reales porque ya tienen aplicados el descuento de AFP, SRS e IRS correspondiente ");
                Console.ReadKey();

            }
            if (sna >= 867123.01)
            {
                double irs = (sna - (sna * 0.25)); 
                Console.WriteLine("El salario real anual es:" + " $RD " + irs+  "\nSalario real mensual es: " + " $RD " + irs / 12 +
                    " \nEstos salarios son reales porque ya tienen aplicados el descuento de AFP, SRS e IRS correspondiente ");
                Console.ReadKey();


            }
        }
        public void profesionalLibre()
        {
            int s;
            Console.WriteLine("Introduzca su sueldo");
            s = int.Parse(Console.ReadLine());           
           double sn = (s - (s * 0.10));
            double sna = sn * 12;
            Console.WriteLine("Su salaio neto anual es: " + " $RD " +sna + "\nSu salrio neto mensual es: " + " $RD " + sn);
            Console.ReadKey();


        }
    }
}
            
