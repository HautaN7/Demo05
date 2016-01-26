using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //DrawingObject do = new DrawingObject();

            Circle circle = new Circle();
            circle.Name = "My circle";
            circle.Draw();

            Square square = new Square();
            square.Name = "My square";
            square.Draw();

            List<DrawingObject> drawingObjects = new List<DrawingObject>();
            // add new objects t ocollection
            drawingObjects.Add(new Circle());
            drawingObjects.Add(new Square());
            drawingObjects.Add(new Circle());
            drawingObjects.Add(new Square());
            drawingObjects.Add(new Circle());
            drawingObjects.Add(new Square());

            // loop collection and draw
            Console.WriteLine("Drawing objects in a list.");
            foreach(DrawingObject drawingObject in drawingObjects)
            {
                drawingObject.Draw();
            }

            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
