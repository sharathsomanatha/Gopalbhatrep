using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        public int a = 10;
         
        static void Main(string[] args)
        {
         int a = 10;
        SqlConnection conn= new SqlConnection("Data Source=BLR-BMCZ7Q2-D;Initial Catalog=CareNotesDevLocal510;UID=sa;Password=W3lc0m3");
             conn.Open();

            Class1.Simplemethod(ref conn,a);

            if (conn.State == ConnectionState.Open)
            {
                Console.WriteLine("connection successful");
            }
            else
            {
                Console.WriteLine("not connected");
            }
            Console.WriteLine(" this is calling method A"+a);
            Console.ReadKey();
        }
    }
}
