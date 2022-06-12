﻿using System;
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
                Console.WriteLine($"{order_Details.Order_DetailsName} - {order_Details.OrderID} - {order_Details.UnitPrice} - {order_Details.Quantity} - {order_Details.Discount}");
            }

            Console.ReadLine();

            
                ShippersLogic shippersLogic = new ShippersLogic();


               foreach (Shippers shippers in new ShippersLogic().GetAll())
                 {
                Console.WriteLine($"{shippers.ShippersName} - {shippers.CompanyName}");
                
            }

            ShippersLogic shippersLogic1 = new ShippersLogic();

            foreach (var item in shippersLogic1.GetAll())
            {
                Console.WriteLine($"{item.ShipperID} - {item.CompanyName}");
            }

            shippersLogic.Add(new Shippers
            {
                ShipperID = 55,
                CompanyName = "FINKELSTEIN LDT"

            });
            Console.WriteLine();

            shippersLogic.Delete(55);

            Console.WriteLine("Shipper eliminado");

                Console.ReadLine();
            

        }

        

    }
}
