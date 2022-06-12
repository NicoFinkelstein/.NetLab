using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp4.Data;

namespace tp4.Logic
{
    public class BaseLogic
    {
        private readonly NorthwindContext context;
        
        public BaseLogic()
        {
            context = new NorthwindContext();
        }
    }
}
