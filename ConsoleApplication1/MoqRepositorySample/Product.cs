using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoqRepositorySample
{
    public class Product
    {
        public int ProductId { get; set; }

        public string Name { get; set; }
        
        public string Description { get; set; }

        public double Price { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateModified { get; set; }
    
    }
}
