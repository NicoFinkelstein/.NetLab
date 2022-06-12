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
        private new readonly NorthwindContext context;

        public ShippersLogic()
        {
            context = new NorthwindContext();
        }
        public List<Shippers> GetAll()
        {
            return context.Shippers.ToList();
        }

        public void Add(Shippers newShipper)
        {
            context.Shippers.Add(newShipper);
            context.SaveChanges();

        }

        public void Delete(int id)
        { 
            var ShipperAEliminar = context.Shippers.First(s => s.ShipperID == id);
            
            context.Shippers.Remove(ShipperAEliminar);

            context.SaveChanges();
        }

        public void Update(Shippers shippers)
        {
            var ShippersUpdate = context.Shippers.Find(shippers.ShipperID);

            ShippersUpdate.ShippersName = shippers.ShippersName;

            context.SaveChanges();
        }
    }
}
