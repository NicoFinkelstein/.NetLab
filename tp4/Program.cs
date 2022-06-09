using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp4.Entities;
using tp4.Logic;

namespace tp4
{
    class Program
    {
        

        static void Main(string[] args)
        {
            Order_DetailsLogic order_DetailsLogic = new Order_DetailsLogic();
        

            foreach (Order_Details order_Details in new Order_DetailsLogic().GetAll())
            {
                Console.WriteLine($"{order_Details.Order_DetailsName} - {order_Details.UnitPrice}");
            }
            Console.ReadLine();

            {
                ShippersLogic shippersLogic = new ShippersLogic();


               foreach (Shippers order_Details in new ShippersLogic().GetAll())
            {
                    Console.WriteLine($"{shippers.ShippersName} - {shippers.UnitPrice}");
                }
                Console.ReadLine();
            }

        }

        

    }
}
