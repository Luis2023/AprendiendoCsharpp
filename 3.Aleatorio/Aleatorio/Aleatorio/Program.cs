using System;

namespace Aleatorio
{
    class Program
    {//la F significa que la variable es tipo Float
        static public float A = 24.5F;
        
        static void Main(string[] args)
           
        {
            //declarar dentro de un metodo hace que la variable sea local
            float B = 0.0F;
            Random NumAleatorio = new Random ();
            B = (float)NumAleatorio.Next(1, 11);
            Console.WriteLine(String.Format("La Suma De{0} y {1} es {2}", A , B , A + B ));
            Console.ReadKey();

            
        }
    }
}
