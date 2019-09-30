using System;

namespace Detectar_si_un_dato_es_entero
{
    class Program
    {
        static void Main(string[] args)
        {
            string Valor;
            int receptora = 0;

            Console.WriteLine("Escribe algo Campeon ");
            Valor = Console.ReadLine();

            if (int.TryParse(Valor , out receptora))
            {
                //si se convierte se almacenara el dato 
                Console.WriteLine(
                    String.Format ("Dato Entero {0}. Muy bien tkm", receptora));
            }
            else
            {
                //si no se rechaza la entrada de datos
                Console.WriteLine("Tienes que ingresar un dato entero e.e");
            }

            //Pausa
            Console.WriteLine();
            Console.WriteLine("Preciona INTRO Pa' continuar");
            Console.ReadKey();
        }
    }
}
