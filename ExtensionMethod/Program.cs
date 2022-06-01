using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("Cargue el divisor (numero por el cual quiere que se divida");
            modelo.NumberB = int.Parse(Console.ReadLine());
            Console.WriteLine("El resultado es : " + dividir.Dividir(modelo));
            Console.ReadLine();
        }

        
     

       
           

        
    }
}
