using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp4.Data;
using tp4.Entities;

namespace tp4.Logic
{
    public class ShippersLogic : BaseLogic  
    {
        private readonly NorthwindContext context;
        public List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }

        public void Add(Shippers newShippers)
        {
            context.Shippers.Add(newShippers);

            context.SaveChanges();
        }
    }
}
