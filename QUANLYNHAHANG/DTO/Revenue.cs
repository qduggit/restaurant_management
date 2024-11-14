using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUANLYNHAHANG.DTO
{
    public class Revenue
    {
        private string _nameban;
        private DateTime _ngayvao;
        private DateTime _ngayra;


        public Revenue()
        {

            _nameban = "";
            _ngayra = System.DateTime.Now;
            _ngayvao = System.DateTime.Now;
        }

        public Revenue(string name, DateTime ngayra, DateTime ngayvao)
        {
            _nameban = name;
            _ngayvao = ngayvao;
            _ngayra = ngayra;
        }

        public string TenBan
        {
            get { return _nameban; }
            set { _nameban = value; }
        }
        public DateTime NgayVao
        {
            get { return _ngayvao; }
            set { _ngayvao = value; }
        }
        public DateTime NgayRa
        {
            get { return _ngayra; }
            set { _ngayra = value; }
        }
    }
}

