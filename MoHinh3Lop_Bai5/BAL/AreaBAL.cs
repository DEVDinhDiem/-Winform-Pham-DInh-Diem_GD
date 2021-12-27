using MoHinh3Lop_Bai5.DAL;
using MoHinh3Lop_Bai5.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoHinh3Lop_Bai5.BAL
{
    class AreaBAL
    {
        AreaDAL dal = new AreaDAL();
        public List<AreaBEL> ReadAreaList()
        {
            List<AreaBEL> lstArea = dal.ReadAreaList();
            return lstArea;
        }
    
    }
}
