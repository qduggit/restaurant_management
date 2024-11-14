using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYNHAHANG.DTO
{
    public class Food
    {
        private string _id;
        private string _name;
        private double _price;
        private string _mota;

        public Food()
        {
            _id = "";
            _name = "";
            _price = 0.0;
            _mota = "";
        }

        public Food(string id, string name, double price,string mota)
        {
            _id = id;
            _name = name;
            _price = price;
            _mota = mota;
        }

        public string MoTa
        {
            get { return _mota; }
            set { _mota = value; }
        }
        public string ID
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
    }
}