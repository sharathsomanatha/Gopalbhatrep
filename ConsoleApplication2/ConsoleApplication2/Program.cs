using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {

            string id = "85563B23-C535-485B-8943-C5349D5F8884";
            try
            {
                var gid = Guid.Parse(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message+""+e.StackTrace);
            }
            finally
            {
                Console.ReadKey();
            }
            
        }
    }
}
