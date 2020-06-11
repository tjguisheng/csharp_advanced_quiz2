using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class LINQClass
    {
        List<int> myList = new List<int>() { 50, 200, 740, 76, 230, 482, 95 };
        
        public void GraterThan(int x)
        {
            var outList = myList.Where(n => n > x).ToList();
            Console.WriteLine($"The numbers greater than {x} are: ");
            foreach(var i in outList)
            {
                Console.WriteLine(i);
            }
        }
    }

}
