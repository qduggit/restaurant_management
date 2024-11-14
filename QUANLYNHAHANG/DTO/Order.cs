using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYNHAHANG.DTO
{
    public class Order
    { 
        private int id;
        private DateTime checkin;   
        private List<OrderInfo> orderItems;
        public Order()
        {
            id = 0;
            checkin = System.DateTime.Now;    
            orderItems = new List<OrderInfo>();
        }

        public Order(int ID, DateTime checkIn )
        {
            id = ID;
            checkin = checkIn;           
            orderItems = new List<OrderInfo>();
        }
        public List<OrderInfo> OrderItems
        {
            get { return orderItems; }
            set { orderItems = value; }
        }

        public DateTime CheckIn
        {
            get { return checkin; }
            set { checkin = value; }
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
      

    }
}
