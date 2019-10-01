using System;

namespace Tablas__ciclo_anidado_
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("");
                Console.WriteLine(String.Format("Tabla Del {0}", i));
                Console.WriteLine("");
                //un for dentro de otro for permite cambiar las variables de secuencia
                for(int l=1; l<=10; l++)
                {
                    Console.WriteLine(
                        string.Format("{0} * {1} = {2}",
                        i, l, i * l));

                }

            }


        }
    }
}
