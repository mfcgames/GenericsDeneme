using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDeneme
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Generic<string> isim = new Generic<string>();

            isim.Add("Ali");

            isim.Add("Ali");

            isim.Add("Ali");

            isim.Add("Ali");
            //Console.WriteLine(isim.Length);

            MyDictionary<int,string> map = new MyDictionary<int,string>();

            map.Add(1, "London");
            map.Add(2, "New York");
            map.Add(3, "Istanbul");

            Console.WriteLine(map.ToString());

        }
    }
}
