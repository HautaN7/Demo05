using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create tyre
            Tyre tyre = new Tyre { Name = "Nokia", Model = "Hakka", TyreSize = "205R16" };

            // create car
            Vehicle car = new Vehicle();
            car.Name = "Audi";
            car.Model = "R8";
            car.AddTyre(tyre);
            car.AddTyre(tyre);
            car.AddTyre(tyre);
            car.AddTyre(tyre);

            Console.WriteLine(car.ToString());
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
