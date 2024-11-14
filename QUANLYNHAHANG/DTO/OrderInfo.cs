using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYNHAHANG.DTO
{
    public class OrderInfo
    {
     
        private string _TenTungMon;
        private int _count;
        private double _price;
        private int tableID;


        public OrderInfo()
        {
            _TenTungMon = "";
            _count = 0;
            _price = 0.0;
            tableID = 0;

        }

        public OrderInfo(string name, int count,double price,int tableId)
        {
            _TenTungMon = name;   
            _count = count;
            _price= price;
            tableID = tableId;
        }

        public string Name
        {
            get { return _TenTungMon; }
            set { _TenTungMon = value; }
        }

        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }

        public int TableID
        {
            get { return tableID; }
            set { tableID = value; }
        }
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public double ThanhTien
        {
            get { return (this._count * this._price); }
            
        }
    }
}
