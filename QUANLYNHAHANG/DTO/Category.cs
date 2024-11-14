using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYNHAHANG.DTO
{
    public class Category
    {
        private int _id;
        private string _tenDM;


        public Category()
        {
            _id = 0;
            _tenDM = "";
        }

        public Category(int id, string danhmuc)
        {
            _id = id;
            _tenDM = danhmuc;
        }

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string DanhMuc
        {
            get { return _tenDM; }
            set { _tenDM = value; }
        }
    }
}
