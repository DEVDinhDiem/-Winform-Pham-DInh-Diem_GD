using KiemTra.DAO;
using KiemTra.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KiemTra.BLL
{
    class CongNoBLL
    {

        CongNODAO dal = new CongNODAO();

        public List<CongNoBEL> ReadCustomer()
        {
            List<CongNoBEL> lstCus = dal.ReadCustomer();
            return lstCus;
        }
        public void NewCustomer(CongNoBEL cus)
        {
            dal.NewCustomer(cus);
        }
        public void DeleteCustomer(CongNoBEL cus)
        {
            dal.DeleteCustomer(cus);
        }
        public void EditCustomer(CongNoBEL cus)
        {
            dal.EditCustomer(cus);
        }
    }
}
