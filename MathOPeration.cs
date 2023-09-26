using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSPROJECT_TQ.Hashset
{
    internal class MathOPeration
    {
        static void Main(string[] args)
        {
            HashSet<string> list1 = new HashSet<string>();

            list1.Add("C");
            list1.Add("C++");
            list1.Add("C#");
            list1.Add("Java");

            HashSet<string> list2 = new HashSet<string>();

            list2.Add("Python");
            list2.Add("C++");
            list2.Add("Angular");
            list2.Add("Java");
           /* list1.UnionWith(list2);
            list1.IntersectWith(list2);
*/


            list1.ExceptWith(list2);

            foreach (string item in list1)
            {
                Console.WriteLine(item);
            }
        }

    }
}
