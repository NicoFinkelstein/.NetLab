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
            Console.WriteLine("***MENU DE OPCIONES***");
            Console.WriteLine();
            Console.WriteLine("1. Mostrar todos los datos de Order Details");
            Console.WriteLine("2. Mostrar todos los datos de los Cargueros (shippers)");
            Console.WriteLine("3. Hacer un INSERT");
            Console.WriteLine("4. Hacer un DELETE");
            Console.WriteLine("5. Generar un UPDATE");
            Console.WriteLine("0. Salir");
            Console.WriteLine("***************************************************************************");

            string input = Console.ReadLine();
            Console.Clear();
            
            switch (input)
                {
                case "1":

                    Console.WriteLine("Order Details");


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
                    input = Console.ReadLine();
                    Console.Clear();
                    break;
               
                case "2":
                    Console.WriteLine("Shippers");
                    ShippersLogic shippersLogic1 = new ShippersLogic();

                    foreach (var item in shippersLogic1.GetAll())
                    {
                        Console.WriteLine($"{item.ShipperID} - {item.CompanyName}");
                    }
                    input = Console.ReadLine();
                    Console.Clear();
                    break;

                case "3":
                    Console.WriteLine("Haga su INSERT");
                    shippersLogic.Add(new Shippers
                    {
                        ShipperID = 55,
                        CompanyName = "FINKELSTEIN LDT"

                    });
                    Console.WriteLine();
                    input = Console.ReadLine();
                    Console.Clear();
                    break;
               
                case "4":
                     Console.WriteLine("Haga su DELETE");
                    shippersLogic.Delete(55);

                    Console.WriteLine("Shipper eliminado");
                    input = Console.ReadLine();
                    Console.Clear();
                    break;

                case "5":
                    Console.WriteLine("Genere su UPDATE");
                    shippersLogic.Update(new Shippers
                    {
                        ShippersName = "Nuevo Nombre",
                        ShipperID = 55,
                    });

                    Console.ReadLine();
                    input = Console.ReadLine();
                    Console.Clear();
                    break;

                default:
                    Console.WriteLine("Selecciono salir");

                    break;

            }




           

           

           


            
            

        }
         
        

    }
}
