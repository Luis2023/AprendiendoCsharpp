using System;

namespace Comparacion
{
    class Program
    {
        static void Main(string[] args)
        {
            //se preguntan los datos en string, se convierten a int 
            //y se almacenan en variables 
            string _Numero1, _Numero2;
            int Numero1, Numero2;

            Console.Write("Numero 1: ");
            _Numero1 = Console.ReadLine();

            Console.Write("Numero 2: ");
            _Numero2 = Console.ReadLine();
       
            Numero1 = Convert.ToInt32(_Numero1);
            Numero2 = Convert.ToInt32(_Numero2);
            // Un if dentro de otro, ambos con salida falsa
            if (_Numero1 == _Numero2) 
            {
                Console.WriteLine(
                    String.Format("Numeros proporcionados{0} y {1}. {2}", Numero1, Numero2, "Son iguales."));

            }
            else
            {

                if (Numero1 > Numero2)
                {
                    Console.WriteLine(
                    String.Format("Numeros proporcionados{0} y {1}. {2}", Numero1, Numero2, "El mayor es el primero"));
                }
                else
                {


                    Console.WriteLine(
                    String.Format("Numeros proporcionados{0} y {1}. {2}", Numero1, Numero2, "El mayor es el segundo"));
                }

            }



        }
    }
}
