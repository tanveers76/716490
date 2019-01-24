using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0716490
{
    class Program

    {
        static void Main(string[] args)
        {
            var dog_and_cat = new Car();
            var bowling = new Car();
            Console.WriteLine("how many cars:{0}", Vehicle.howManyCars);
        }
    }


    class Vehicle
    {
        public static howManyCars=0; 
        public string Color = "Blue";
        internal static int howManyCars;
    }
    class Car : Vehicle
    {
        public String new int howManyCars = 0;
        public Car()
        {
            Console.WriteLine("my color is " + Color);

        }
    }
    class BookCollection
    {

    }
    class Book : BookCollection
    {
        private String Title;
        public void SetTitle(String)
    }
}
