using System;

namespace uso_de_ciclos__for_
{
    class Program
    {
        static void Main(string[] args)
        {
            /* cuando los datos se capturan en string y se ocupa que 
             * sean numericos los datos se capturan den 2 variables */
            string  _Numero;
            int Numero;
            //se pregunta el dato como string y se convierte a un equivalente numerico
            Console.WriteLine("Dame un numero del 1 al 9");
            _Numero = Console.ReadLine();
            Numero = Convert.ToInt32(_Numero);
            //se genera un ciclo de numero conocido de iteraciones 
            for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine(
                    String.Format("{0} * {1} + {2}", Numero, i, Numero * i));
            }

            
        }
    }
}
