using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar

{
    class Collections
    {

        static void Main(string[] args)
        {
            Dictionary();
            Console.WriteLine("***************************************************************");
            list();
            Console.WriteLine("***************************************************************");
            SortedSet();





        }

        private static void SortedSet()
        {
            SortedSet<string> sortedset = new SortedSet<string>();
            sortedset.Add("Galatasaray");
            sortedset.Add("Fenerbahçe");
            sortedset.Add("Beşiktaş");
            sortedset.Add("Başakşehir");
            sortedset.Add("Ankaragücü");
            sortedset.Add("Trabzonspor");


            foreach (var takimlar in sortedset)
            {

                Console.WriteLine(takimlar);
            }
        }

        private static void Dictionary()
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(34, "İstanbul");
            dictionary.Add(53, "Rize");
            dictionary.Add(06, "Ankara");
            dictionary.Add(35, "İzmir");
            dictionary.Add(61, "Trabzon");
            

            foreach (var plakalar in dictionary)
            {
                
                Console.WriteLine("Plaka " + plakalar.Key + "\t" + "Şehir " + plakalar.Value);
            }
        }

        private static void list()
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("İstanbul");
            sehirler.Add("Ankara");
            sehirler.Add("İzmir");
            sehirler.Add("Antalya");

            foreach (var sehir in sehirler)
            {
                Console.WriteLine(sehir);

            }
        }



    }
}
