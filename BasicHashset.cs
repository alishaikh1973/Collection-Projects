using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.Hashset
{
    internal class BasicHashset
    {
        static void Main(string[] args)
        {
            HashSet<string> list1 = new HashSet<string>();

            list1.Add("pune");
            list1.Add("mumbai");
            list1.Add("nagpur");
            list1.Add("pune");

            list1.Remove("nagpur"); 
            list1.Clear(); 
            foreach (string item in list1)
            {
                Console.WriteLine(item);
            }
        }

    }
}
