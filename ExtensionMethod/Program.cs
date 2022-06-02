using System;

namespace ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ejecutar();
        }
        private static void Ejecutar()
        {
            DivisionMachine dividir = new DivisionMachine();
            NumberModel modelo = new NumberModel();
            Console.WriteLine("Cargue el dividendo (numero que quiere que se divida)");
            modelo.NumberA = int.Parse(Console.ReadLine());
            Console.WriteLine("Cargue el divisor (numero por el cual quiere que se divida)");
            modelo.NumberB = int.Parse(Console.ReadLine());
            Console.WriteLine("El resultado es : " + dividir.Dividir(modelo));
            Console.ReadLine();
           
            try
            {
                modelo.NumberB = int.Parse(Console.ReadLine());
            }
            catch(FormatException ex)
            {
                Console.WriteLine("No se ha introducido un valor numerico valido");
                Console.WriteLine(ex.Message);
            }

            catch(DivideByZeroException ex)
            {
                Console.WriteLine("No se puede dividir por 0");
            }
            


        }








    }
}
