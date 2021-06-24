using System;
using System.Drawing;
using System.Collections.Generic;

using Geometry.Interfaces;
using Geometry.Types;
using Geometry.Types.Shape2D;
using Geometry.Types.Shape3D;

namespace Geometry
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            #region Create Objects
            var objects = new List<Shape>();
            var objects2D = new List<IShape2D>();
            var objects3D = new List<IShape3D>();
            var roundedObjects = new List<IRoundShape>();
            var angularObjects = new List<IAngularShape>();
            #endregion
            
            #region Create Shapes
            var circle1 = new Circle()
            {
                Radius = 10.0,
                Label = "Mein Kreis",
                Color = Color.Black,
                CoordinateX = -10.0,
                CoordinateY = 0.0
            };
            var sphere1 = new Sphere()
            {
                CoordinateX = 10.0,
                CoordinateY = 10.0,
                CoordinateZ = 10.0,
                Label = "Meine Kugel",
                Color = Color.Green,
                Radius = 20.0
            };

            var cube1 = new Cuboid()
            {
                CoordinateX = 30.0,
                CoordinateY = -10.0,
                CoordinateZ = 0.0,
                Height = 12.5,
                Length = 15.0,
                Width = 11.1,
                Color = Color.Black,
                Label = "Mein Würfel"
            };
            var rectangle1 = new Types.Shape2D.Rectangle()
            {
                CoordinateX = -12.0,
                CoordinateY = 22.0,
                Label = "Mein Rect",
                Color = Color.Aqua,
                Length = 6.3,
                Width = 9.9
            };
            #endregion

            #region Task 1
            Spacer();

            Console.WriteLine("Liste aller Objekte/Figuren" + Environment.NewLine);

            objects.Add(circle1);
            objects.Add(sphere1);
            objects.Add(cube1);
            objects.Add(rectangle1);

            foreach (var obj in objects)
                Console.WriteLine($"{obj.GetType().Name} '{obj.Label}' \t| {obj.Color}");

            Spacer();
            #endregion

            #region Task 2
            Console.WriteLine("Liste aller 2D-Objekte" + Environment.NewLine);

            objects2D.Add(circle1);
            objects2D.Add(rectangle1);

            foreach (var obj in objects2D)
                Console.WriteLine($"{obj.GetType().Name} '{obj.Label}' \t| Surface: {Math.Round(obj.Surface, 2)}; Circumference: {Math.Round(obj.Circumference, 2)}");

            Spacer();
            #endregion

            #region Task 3
            Console.WriteLine("Liste aller 3D-Objekte" + Environment.NewLine);
            
            objects3D.Add(cube1);
            objects3D.Add(sphere1);

            foreach (var obj in objects3D)
                Console.WriteLine($"{obj.GetType().Name} '{obj.Label}' \t| Volume: {Math.Round(obj.Volume, 2)}; Surface: {Math.Round(obj.Surface, 2)}");

            Spacer();
            #endregion

            #region Task 4
            Console.WriteLine("Liste aller eckigen Objekte" + Environment.NewLine);

            angularObjects.Add(cube1);
            angularObjects.Add(rectangle1);

            foreach (var obj in angularObjects)
                Console.WriteLine($"{obj.GetType().Name} '{obj.Label}' \t| Length: {Math.Round(obj.Length, 2)}; Width: {Math.Round(obj.Width, 2)}");

            Spacer();
            #endregion

            #region Task 5
            Console.WriteLine("Liste aller runden Objekte" + Environment.NewLine);

            roundedObjects.Add(circle1);
            roundedObjects.Add(sphere1);

            foreach (var obj in roundedObjects)
                Console.WriteLine($"{obj.GetType().Name} '{obj.Label}' \t| Length: {Math.Round(obj.Radius, 2)}; Width: {Math.Round(obj.Diameter, 2)}");

            Spacer();
            #endregion
        }

        private static void Spacer()
        {
            Console.WriteLine(Environment.NewLine + "----------------------------------------------------------------" + Environment.NewLine);
        }
    }
}
