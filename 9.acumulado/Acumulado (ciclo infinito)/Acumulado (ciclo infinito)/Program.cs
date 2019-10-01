using System;

namespace Acumulado__ciclo_infinito_
{
    class Program
    {
        static void Main(string[] args)
        {
            String  _Numero;
            int Numero;
            int acumulado = 0;
            Console.WriteLine("Captura los enteros a acumular.");
            Console.WriteLine("Dejar vacio y dar intro para salir");
            Console.WriteLine("");
            //un ciclo while no termina hasta un Break
            while (true)
            {

                Console.WriteLine("Dame un numero entero: ");
                _Numero = Console.ReadLine();
                if (_Numero=="")
                {
                    break;
                }
                else
                {
                    if(int.TryParse(_Numero, out Numero))
                    {
                        acumulado += Numero;
                        Console.WriteLine(String.Format("Monto Acumulado: {0}", acumulado));

                    }
                    else
                    {
                        Console.WriteLine("te espesifique entero, prueba con otro");
                        Console.WriteLine(" intenta de nuevo");
                    }

                }

            }
            //pausa
            Console.WriteLine("");
            Console.WriteLine("Preciona intro pa continuar");
            Console.ReadKey();

        }
    }
}
