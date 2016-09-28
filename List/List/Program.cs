using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            Element<int> a = new Element<int>(9);
            Element<int> b = new Element<int>(9);
            Element<int> c = new Element<int>(9);
            List<int> list = new List<int>();
            list.addfirst(a);
            list.addfirst(b);
            list.addfirst(c);
            list.printf();
        }
    }
}
