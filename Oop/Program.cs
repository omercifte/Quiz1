using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    class Program
    {
        static void Main(string[] args)
        {

            Calisan[] kisiler = new Calisan[]
            {
                new Garson{FirstName = "Ali", LastName="Yılmaz"},
                new Menager { FirstName = "Suat", LastName = "Kaya" },
                new Asci { FirstName = "Ayşe", LastName = "Çakır" }
            };
            foreach (var item in kisiler)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} {item.MaasHesaplama()}");
            }






        }
    }




class Calisan
{

    public string FirstName { get; set; }
    public string LastName { get; set; }
    protected Decimal Maas { get; set; }

    private const Decimal Asgari = 5500;


    public virtual decimal MaasHesaplama()
    {
        Maas = Asgari;
            return Maas;
    }



}

class Garson : Calisan
{
    public int Bahsis { get; set; }

    public override decimal MaasHesaplama()
    {
        base.MaasHesaplama();
        Maas *= 1M;
            return Maas;

    }


}

class Menager : Calisan
{
    public int Prim { get; set; }
    public override decimal MaasHesaplama()
    {
        base.MaasHesaplama();
        Maas *= 3M;
            return Maas;
        }

}

class Asci : Calisan
{
    public int YemekBakiye { get; set; }
    public override decimal MaasHesaplama()
    {
        base.MaasHesaplama();
        Maas *= 2M;
            return Maas;
        }
}

   

}