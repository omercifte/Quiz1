using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsp
{

    public interface IElletut
    {
        void Elletut();
    }
    public abstract class Oyuncu
    {
        public abstract void Play();
    }



    public class Kaleci : Oyuncu, IElletut
    {
        public override void Play()
        {

            Console.WriteLine("Kadroya Alındı(Kaleci)");
        }

        public void Elletut()
        {
            Console.WriteLine("Eldivenleri Hazırladı(Kaleci)");
        }

       
    }

    public class Forvet: Oyuncu
    {

        public override void Play()
        {
            Console.WriteLine("Golcü oyuncu ısınıyor(Forvet)");
        }


    }
}
