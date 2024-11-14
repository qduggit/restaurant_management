using QUANLYNHAHANG.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace QUANLYNHAHANG.DAO
{
    class DanhMucFood
    {
        private List<Food> dsFood;
        public DanhMucFood()
        {
            dsFood = new List<Food>();
            DocFileText("Food.txt");
        }

        public List<Food> DSFood
        {
            get { return dsFood.ToList(); }
            set { dsFood = value; }
        }

        public void them(Food nv)
        {
            this.dsFood.Add(nv);
        }

        public void sua(Food foodMoi)
        {
            int index = this.dsFood.FindIndex(food => food.ID.Equals(foodMoi.ID));
            if (index != -1)
            {
                this.dsFood[index] = foodMoi;
            }
        }
        public void xoa(int vitri)
        {
            this.dsFood.RemoveAt(vitri);

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
                        if (parts.Length == 4)
                        {
                            string id = parts[0];
                            string name = parts[1];
                            if (double.TryParse(parts[2], out double price))
                            {
                                string description = parts[3];
                                Food food = new Food(id, name, price, description);
                                this.dsFood.Add(food);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi đọc file: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool kiemTraTrungMa(string ma)
        {
            foreach (Food tb in this.dsFood)
                if (tb.ID.Equals(ma))
                    return true;
            return false;
        }

    }
}
