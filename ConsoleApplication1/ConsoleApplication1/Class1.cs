using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Class1
    {
        public static void Simplemethod(ref SqlConnection connection, int a)
        {
            a = 20;
            Console.WriteLine("this is called method A value="+ a);
           // connection.Close();

        }

    }
}
