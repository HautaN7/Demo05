using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
    class Dresser
    {
        public string Material { get; set; }
        public int Drawer { get; set; }
        public List<Fabric> Fabrics { get; }

        public Dresser()
        {
            Fabrics = new List<Fabric>();
        }

        public void AddFabric(Fabric fabric)
        {
            Fabrics.Add(fabric);
        }
        public override string ToString()
        {
            string sDresser = "Dresser Material: " + Material + " Drawer(s): " + Drawer + " Fabrics: \n";
            foreach (Fabric fabric in Fabrics)
            {
                return base.ToString() + "\n";
            }
            return sDresser;
        }
    }
}
