using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp4.Data;
using tp4.Entities;

namespace tp4.Logic
{
    public class ShippersLogic
    {
        private readonly NorthwindContext context;

        public ShippersLogic()
        {
            context = new NorthwindContext();
        }
        public List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }
    }
}
