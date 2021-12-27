using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoHinh3Lop_Bai5.Model
{
   public class AreaBEL
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public List<CustomerBEL> Customers { get; set; }
    }
}
