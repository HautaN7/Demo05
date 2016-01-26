using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create new clothes
            Fabric shirt = new Fabric { Type = "Shirt", Color = "Red" };
            Fabric pants = new Fabric { Type = "Pants", Color = "Black" };
            Fabric sock = new Fabric { Type = "Sock", Color = "White" };

            // Create dresser
            Dresser dresser = new Dresser();
            dresser.Material = "Wood";
            dresser.Drawer = 2;
            dresser.AddFabric(shirt);
            dresser.AddFabric(pants);
            dresser.AddFabric(sock);
            dresser.AddFabric(sock);

            Console.WriteLine(dresser.ToString());
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
