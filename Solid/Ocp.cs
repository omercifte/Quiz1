using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
     class Ocp
    {
        static void Main(string[]args)
        {

        }
    }
    
    class CustomerManager2
    {
        public void Add()
        {
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add();
        }

    }
    class CustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Added to Database");
        }

    }
}
