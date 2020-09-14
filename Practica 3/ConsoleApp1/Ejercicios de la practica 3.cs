using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Ejercicios_de_la_practica_3
    {
        //ejercicio numero 1 de la practica
        public void ejercicioNumeroUno()
        {

            double a, b, i;
            Console.WriteLine("Introduzca un numero: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("\nIntroduszca otro numero uqe sea mayor al primero que introdujo: ");
            b = double.Parse(Console.ReadLine());

            for (i = a + 1; i < b; i++)
            {

                Console.WriteLine("\nLos numeros entre dichos valores son: " + i);
            }
            Console.ReadKey();

        }
        //ejercicio numero 2 de la practica
        public void ejercicioNumeroDos()
        {




            int n, Max, i; int Suma = 0; string linea;



            Console.WriteLine("digite la cantidad de numeros que desea introducir: ");
            Max = int.Parse(Console.ReadLine());

            for (i = 1; i <= Max; i++)
            {
                Console.WriteLine("Introduzca un numero: "); linea = Console.ReadLine();
                n = int.Parse(linea);
                Suma += n;
            }
            Console.WriteLine("La suma total es: " + Suma);

            Console.ReadKey();
        }
        //ejercicio numero 3 de la practica
        public void ejercicioNumeroTres()
        {

            {
                int i = 0, a = 0;
                string Clave, Usuario;

                do
                {
                    Console.WriteLine("Introduzca su usuario");
                    Usuario = Console.ReadLine();
                    Console.WriteLine("Introduzca la clave:");
                    Clave = Console.ReadLine();
                    if ((Usuario == "admin") & (Clave == "1234"))
                    {
                        a = 1;
                    }
                    {
                        i++;
                    }
                }
                while (((i < 3) & (a == 0)));

                if (a == 1)
                {
                    Console.WriteLine("\nCorrecto, A iniciado cesion ");
                }
                else
                {
                    Console.WriteLine("\nAgoto el numero de intentos maximo");
                }
                Console.ReadKey();


            }

        }
        //ejercicio numero 4 de la practica
        public double ejercicioNumeroCuatro()
        {
            double n, r;

            Console.WriteLine("Introduzca un numero: ");
            n = double.Parse(Console.ReadLine());
            r = n * 2;
            Console.WriteLine("\nEl doble es: " + "\n" + r);
            Console.ReadKey();
            return r;



        }
        //ejercicio numero 5 de la practica
        public void ejercicioNumeroCinco()
        {
            int a;

            Console.Write("Introduzca un numero del 1 al 12: ");
            a = int.Parse(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.WriteLine("\nEl numero elegido corresponde al primer mes, que es Enero.");
                    break;
                case 2:
                    Console.WriteLine("\nEl numero elegido corresponde al segundo mes, que es Febrero.");
                    break;
                case 3:
                    Console.WriteLine("\nEl numero elegido corresponde al tercer mes, que es Marzo.");
                    break;
                case 4:
                    Console.WriteLine("\nEl numero elegido corresponde al cuarto mes, que es Abril.");
                    break;
                case 5:
                    Console.WriteLine("\nEl numero elegido corresponde al quinto mes, que es Mayo.");
                    break;
                case 6:
                    Console.WriteLine("\nEl numero elegido corresponde al sexto mes, que es Junio.");
                    break;
                case 7:
                    Console.WriteLine("\nEl numero elegido corresponde al septimo mes, que es Julio.");
                    break;
                case 8:
                    Console.WriteLine("\nEl numero elegido corresponde al octavo mes, que es Agosto.");
                    break;
                case 9:
                    Console.WriteLine("El numero elegido corresponde al noveno mes, que es Septiembre.");
                    break;
                case 10:
                    Console.WriteLine("El numero elegido corresponde al decimo mes, que es Octubre.");
                    break;
                case 11:
                    Console.WriteLine("El numero elegido corresponde al decimo primer mes, que es Noviembre.");
                    break;
                case 12:
                    Console.WriteLine("El numero elegido corresponde al ultimo mes, que es Diciembre.");
                    break;
                default:
                    Console.WriteLine("\nSe ingreso un numreo no valido");
                    break;
            }
            Console.ReadKey();
        }
        //ejercicio numero 6 de la practica
        public void ejercicioNumeroSeis()
        {
            SoloParaEjercicio6 a = new SoloParaEjercicio6();
            string n;
            do
            {
                Console.WriteLine("Elegina una de las siguientes opciones: " +
                  "\n1-Convertir grados a Celsius a Fahrenheit " +
                  "\n2-Convertir dólar a pesos" +
                  "\n3-Convertir metros a pies" +
                  "\n4-Salir\n");


                n = Console.ReadLine();

                switch (n)
                {
                    case "1":
                        Console.Clear();
                        a.cambioCelcius();
                        Console.Clear();
                        break;
                    case "2":
                        Console.Clear();
                        a.cambioDollar();
                        Console.Clear();
                        break;
                    case "3":
                        Console.Clear();
                        a.cambioMetros();
                        Console.Clear();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("\nSaliendo del menu");
                        Console.ReadKey();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("\nOpcion no valida, intente una de las opciones en pantalla");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                }

            } while (n != "4");

        }
        //ejercicio numero 7 de la practica
        public void ejercicioNumeroSiete()
        {
            int n, r, i;
            Console.WriteLine("Tabla de los multiplos de 5, comprendidos de 1 al 1000");


            for (n = 5; n <= 1000; n = n + 5)
            {
                for (i = n; i <= 1000; i = i + 5)
                {
                    r = n * i;

                    Console.WriteLine("{0} * {1} = {2}", n, i, r);

                }
                Console.ReadKey();
            }

        }
        //ejercicio numero 8 de la practica
        public void ejercicioNumeroOcho()
        {
            SoloParaElEjercicio8 a = new SoloParaElEjercicio8();
            string c;
            do
            {

                Console.WriteLine("Elegina una de las siguientes opciones: " +
                      "\n1-Calcular salario de personas asalariadas " +
                      "\n2-Calacular salario de profesionales liberales o independientes" +
                      "\n3-Salir\n");


                c = Console.ReadLine();

                switch (c)
                {
                     
                case "1":
                        Console.Clear();
                        a.salarioPrivado();
                        Console.Clear();
                        break;

                case "2":
                        Console.Clear();
                        a.profesionalLibre();
                        Console.Clear();
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine("Saliendo del programa");
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opcion no valida, intenre selecionando una opcion valida");
                        Console.Clear();
                        break;
                }
                            
          } while (c != "3");
        }
        // ejercicio numero 9
        public void ejercicoNumeroNueve()
        {//Banco ABC
        }
           
    }
}



    









