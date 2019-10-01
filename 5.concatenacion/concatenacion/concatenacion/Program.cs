using System;

namespace concatenacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre;
            string Apellido;
            string NombreCompleto;
            Console.WriteLine("pon tu nombre");
            Nombre = Console.ReadLine();
            Console.WriteLine("oye we pasame tu apellido ;v");
            Apellido = Console.ReadLine();
            /*los datos string son inmutables o sea que si los concatenas con "+" se sumaran datos en memoria
             * y eso no lo queremos no no. Para evitar esto se usa StringBuilder que no los copia sino que crea uno nuevo*/
            NombreCompleto = Nombre + Apellido;
            Console.WriteLine("Pulsame cualquier teclita BRHO");
            Console.ReadKey();
            Console.WriteLine("Entonces tu eres:" + NombreCompleto);

        }
    }
}
