using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawApp
{
    class Circle : DrawingObject
    {
        public override void Draw()
        {
            Console.WriteLine("Draw circle.");
        }
    }
}
