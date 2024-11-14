using QUANLYNHAHANG.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYNHAHANG.DAO
{
    class DanhMucEmployee
    {
        private List<Employee> dsEmployee;
        public DanhMucEmployee()
        {
            dsEmployee = new List<Employee>();
        }

        public List<Employee> DSEmployee
        {
            get { return dsEmployee.ToList(); }
            set { dsEmployee = value; }
        }

        public void them(Employee nv)
        {
            this.dsEmployee.Add(nv);
        }

        public void sua(Employee nvMoi)
        {
            int index = this.dsEmployee.FindIndex(nv => nv.ID.Equals(nvMoi.ID));
            if (index != -1)
            {
                this.dsEmployee[index] = nvMoi;
            }
        }
        public void xoa(int vitri)
        {
            this.dsEmployee.RemoveAt(vitri);
        }
        public bool kiemTraTrungMa(string ma)
        {
            foreach (Employee tb in this.dsEmployee)
                if (tb.ID.Equals(ma))
                    return true;
            return false;
        }
    }
}
