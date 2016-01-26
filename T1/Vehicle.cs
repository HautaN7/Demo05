using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1
{
    class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public List<Tyre> Tyres { get; }
        public Vehicle()
        {
            Tyres = new List<Tyre>();
        }
        public void AddTyre(Tyre tyre)
        {
            Tyres.Add(tyre);
        }

        public override string ToString()
        {
            string sVehicle = "Vehicle Name: " + Name + " Model: " + Model + " Tyres: \n";
            foreach(Tyre tyre in Tyres)
            {
                sVehicle += tyre.ToString() + "\n";
            }
            return sVehicle;
        }
    }
}
