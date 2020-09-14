using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Practica_4
{
    class Personaje : SerVivo
    {
        
        public void moverArriba() 
        {
            Console.WriteLine("el personaje se mueve hacia arriba.");
            Console.ReadKey();
        }
        public void moverAbajo()
        {
            Console.WriteLine("el personaje se mueve hacia abajo.");
            Console.ReadKey();
        }
        public void moverIzquierda()
        {
            Console.WriteLine("el personaje se mueve hacia la izquierda.");
            Console.ReadKey();
        }
        public void moverDerecha()
        {
            Console.WriteLine("el personaje se mueve hacia la derecha.");
            Console.ReadKey();
        }
    }
    class Mario : Personaje 
    {

    }
    class koopa : Personaje
    {

    }
}
