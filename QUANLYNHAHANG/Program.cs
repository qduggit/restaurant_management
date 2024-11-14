namespace QUANLYNHAHANG
{
    internal static class Program
    { 
        static void Main()
        {
            string filePath = "data.txt";
            string[] lines = new string[]
            {
                "username1,123",
                "admin,123"
            };
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (string line in lines)
                    {
                            writer.WriteLine(line);
                    }
                }

                Console.WriteLine("Ghi dữ liệu vào tệp txt thành công.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
            }

            Console.ReadLine();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new fManagement());
        }
    }
}
