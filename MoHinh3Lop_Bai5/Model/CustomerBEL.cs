using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoHinh3Lop_Bai5.Model
{
   public class CustomerBEL
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public AreaBEL Area { get; set; }
        public string AreaName { get { return Area.Name; } }
        List<CustomerBEL> lstCus = new List<CustomerBEL>();
    }
}
