using QUANLYNHAHANG.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYNHAHANG.DAO
{
    public class DanhMucOrder
    {
        private List<OrderInfo> list;

        public DanhMucOrder()
        {
            list = new List<OrderInfo>();
           
        }
        public List<OrderInfo> DSOrder
        {
            get { return list; }
            set {list = value; }
        }
        public void XoaOrderTheoBan(int tableId)
        {
            list.RemoveAll(order => order.TableID == tableId);
        }
        public bool CoDonHang(int maBan)
        {
            return DSOrder.Any(order => order.TableID == maBan);
        }
        public void them(OrderInfo nv)
        {
            list.Add(nv);
        }


    }
}
