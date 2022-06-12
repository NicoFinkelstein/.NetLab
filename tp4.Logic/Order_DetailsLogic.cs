using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp4.Data;
using tp4.Entities;

namespace tp4.Logic
{
    public class Order_DetailsLogic : BaseLogic    
    {
        private readonly NorthwindContext context;

        public Order_DetailsLogic()
        {
            context = new NorthwindContext();   
        }
        
        public List<Order_Details> GetAll()
        {
            return context.Order_Details.ToList();
        }
    }
}
