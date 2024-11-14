using QUANLYNHAHANG.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYNHAHANG.DAO
{
    class DanhMucRevenue
    {
        private List<Revenue> dsRevenue;
        public DanhMucRevenue()
        {
            dsRevenue = new List<Revenue>();
        }

        public List<Revenue> DSRevenue
        {
            get { return dsRevenue.ToList(); }
            set { dsRevenue = value; }
        }   
      
    }
}
