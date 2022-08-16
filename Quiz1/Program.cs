using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz1
{
    class Collections
    {
        static void Main(string[] args)
        {

            ArrayList sehirler = new ArrayList();
            sehirler.Add("İstanbul");
            sehirler.Add("Ankara");

            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir);


            }
            Console.WriteLine("hello");





        }





    }
}
