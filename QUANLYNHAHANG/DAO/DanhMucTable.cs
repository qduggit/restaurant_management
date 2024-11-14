using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QUANLYNHAHANG.DTO;
using System.IO;

namespace QUANLYNHAHANG.DAO
{
    public class DanhMucTable
    {
        
        private List<Table> dsTable;

       
        public DanhMucTable() 
        { 
            dsTable = new List<Table>();        
            DocFileText("table.txt");
        }

        public void DocFileText(string tenFile)
        {
            try
            {
                using (StreamReader sr = new StreamReader(tenFile, Encoding.UTF8))
                {
                    while (!sr.EndOfStream)
                    {
                        string[] parts = sr.ReadLine().Split('\t');
                        if (parts.Length == 3)
                        {
                            if (int.TryParse(parts[0], out int id))
                            {
                                string name = parts[1];
                                string status = parts[2];
                                Table table = new Table(id, name, status);
                                dsTable.Add(table);
                            }
                            else
                            {
                                
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
        }
        public List<Table> DSTaBle 
        {
            get { return dsTable.ToList(); }
            set { dsTable = value; }
        }

       
        public void them(Table tb)
        {
            this.dsTable.Add(tb);
        }
        public void xoa(int vitri)
        {
            this.dsTable.RemoveAt(vitri);
        }

        public void sua(Table tbMoi)
        {
            int index = this.dsTable.FindIndex(tb => tb.ID.Equals(tbMoi.ID));
            if (index != -1)
            {
                this.dsTable[index] = tbMoi;
            }
        }

        public bool kiemTraTrungMa(string ma)
        {
            foreach (Table tb in this.dsTable)
                if (tb.ID.Equals(ma))
                    return true;
            return false;
        }
    }
}
