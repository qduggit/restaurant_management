using QUANLYNHAHANG.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace QUANLYNHAHANG.DAO
{
    class DanhMucCategory
    {
        private List<Category> dsCategory;
        public DanhMucCategory()
        {
            dsCategory = new List<Category>();
            DocFileText("Category.txt");
        }

        public List<Category> DSCategory
        {
            get { return dsCategory.ToList(); }
            set { dsCategory = value; }
        }

        public void them(Category nv)
        {
            this.dsCategory.Add(nv);
        }

        public void sua(Category nvMoi)
        {
            int index = this.dsCategory.FindIndex(nv => nv.ID.Equals(nvMoi.ID));
            if (index != -1)
            {
                this.dsCategory[index] = nvMoi;
            }
        }
        public void xoa(int vitri)
        {
            this.dsCategory.RemoveAt(vitri);
        }


        private void DocFileText(string tenFile)
        {
            try
            {
                using (StreamReader sr = new StreamReader(tenFile, Encoding.UTF8))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split('\t');
                        if (parts.Length == 2)
                        {
                            if (int.TryParse(parts[0], out int id))
                            {
                                Category ct = new Category(id, parts[1]);
                                dsCategory.Add(ct);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }


        public bool kiemTraTrungMa(string ma)
        {
            foreach (Category tb in this.dsCategory)
                if (tb.ID.Equals(ma))
                    return true;
            return false;
        }
    }
}
