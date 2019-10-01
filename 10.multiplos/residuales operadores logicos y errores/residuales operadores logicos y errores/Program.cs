using System;

namespace residuales_operadores_logicos_y_errores
{
    class Program
    {
        static void Main(string[] args)
        {
            string _numero;
            int numero;
            bool esMultiploDe3, esMultiplode5, esMultiplode7;

            try
            {
                Console.WriteLine("Dame un numero entero: ");
                _numero = Console.ReadLine();
                numero = Convert.ToInt32(_numero);
                /* si un numero tiene un residual de cero
                 * con respecto a un numero, es un multiplo */
                esMultiploDe3 = ((numero % 3) == 0);
                esMultiplode5 = ((numero % 5) == 0);
                esMultiplode7 = ((numero % 7) == 0);

                if (esMultiploDe3 & esMultiplode5 | esMultiplode7)
                {
                    Console.WriteLine("Correcto companebrio");
                }
                else
                {
                    Console.WriteLine("No es correcto");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("El dato proporcionado da errores");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("");
                Console.WriteLine("Pulsa intro pa irte");
                Console.ReadKey();
            }

            
        }
    }
}
