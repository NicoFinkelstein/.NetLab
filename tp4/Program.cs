using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp4.Entities;
using tp4.Logic;

namespace tp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order_DeteailsLogic order_DetailsLogic = new Order_DetailsLogic();

            foreach (Order_Details order_Details in Order_DetailsLogic.GetAll())
            {
                Console.WriteLine($"{order_Details.Order_DetailsName} - {order_Details.UnitPrice}");
            }
            Console.ReadLine();
        }
    }
}
