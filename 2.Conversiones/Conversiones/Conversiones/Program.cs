using System;

namespace Conversiones
{
    class Program
    {
        static void Main(string[] args)
        {
            string Numero = "1234";
            Console.WriteLine(Numero.GetType().ToString());
            int intNumero = Convert.ToInt32(Numero);
            Console.WriteLine(intNumero.GetType().ToString());
            Console.WriteLine(String.Format("El Numero es {0}", intNumero));
            Console.ReadLine();


        }
    }
}
