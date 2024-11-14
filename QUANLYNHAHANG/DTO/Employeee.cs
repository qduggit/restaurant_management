using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYNHAHANG.DTO
{
    public class Employee
    {
        private string _id;
        private string _name;
        private string _address;
        private string _sex;
        private double _sdt;
        private string _position;

        public Employee()
        {
            _id = "";
            _name = "";
            _address = "";
            _sex = "";
            _sdt = 0.0;
            _position = "";
        }

        public Employee(string id, string name, string address, string sex, double sdt, string position)
        {
            _id = id;
            _name = name;
            _address = address;
            _sex = sex;
            _sdt = sdt;
            _position = position;
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

        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }

        public string Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        public double SDT
        {
            get { return _sdt; }
            set { _sdt = value; }
        }

        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }
    }
}
