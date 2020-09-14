using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            Ejercicios_de_la_practica_3 z = new Ejercicios_de_la_practica_3();

            string t;
            do
            {

                Console.WriteLine("Elegina una de las siguientes opciones: " +
                      "\n1-Ejercicio 1 " +
                      "\n2-Ejercicio 2" +
                      "\n3-Ejercicio 3" +
                      "\n4-Ejercicio 4" +
                      "\n5-Ejercicio 5" +
                      "\n6-Ejercicio 6" +
                      "\n7-Ejercicio 7" +
                      "\n8-Ejercicio 8" +
                      "\n9-Ejercicio 9 y 10" +
                      "\n10-Salir\n");


                t = Console.ReadLine();

                switch (t)
                {

                    case "1":
                        Console.Clear();
                        z.ejercicioNumeroUno();
                        Console.Clear();
                        break;

                    case "2":
                        Console.Clear();
                        z.ejercicioNumeroDos();
                        Console.Clear();
                        break;

                    case "3":
                        Console.Clear();
                        z.ejercicioNumeroTres();
                        Console.Clear();
                        break;

                    case "4":
                        Console.Clear();
                        z.ejercicioNumeroCuatro();
                        Console.Clear();
                        break;

                    case "5":
                        Console.Clear();
                        z.ejercicioNumeroCinco();
                        Console.Clear();
                        break;

                    case "6":
                        Console.Clear();
                        z.ejercicioNumeroSeis();
                        Console.Clear();
                        break;
                    case "7":
                        Console.Clear();
                        z.ejercicioNumeroSiete();
                        Console.Clear();
                        break;

                    case "8":
                        Console.Clear();
                        z.ejercicioNumeroOcho();
                        Console.Clear();
                        break;

                    case "9":
                        Console.Clear();
                        Console.WriteLine("Incompleto, me quede viendo como ahcer que el cajero muestre en consola la cantidad de billetes que le quedan de cada uno y tambien los interperte correctamente" +
                            "\n Borre la funcion.");
                        Console.Clear();
                        break;

                    case "10":
                        Console.Clear();
                        Console.WriteLine("Saliendo del menu de la practica numero 3.");
                        Console.Clear();
                        break;


                    default:
                        Console.Clear();
                        Console.WriteLine("Opcion no valida, intenre selecionando una opcion valida");
                        Console.Clear();
                        break;
                }

            } while (t != "10");


        }




    }
}



        

    
    

    



    


  