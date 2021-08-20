using System;
using System.Drawing;
using System.Collections.Generic;

using Geometry.Core.Interfaces;
using Geometry.Core.Types;
using Geometry.Core.Types.Shape2D;
using Geometry.Core.Types.Shape3D;

namespace Geometry
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            var random = new Random();
            var materialValues = Enum.GetValues(typeof(Material));

            #region Create Objects
            var shapes = new List<Shape>();
            var shapes2D = new List<IShape2D>();
            var shapes3D = new List<IShape3D>();
            var roundedShapes = new List<IRoundShape>();
            var angularShapes = new List<IAngularShape>();
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
            var rectangle1 = new Core.Types.Shape2D.Rectangle()
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

            shapes.Add(circle1);
            shapes.Add(sphere1);
            shapes.Add(cube1);
            shapes.Add(rectangle1);

            foreach (var obj in shapes)
                Console.WriteLine($"{obj.GetType().Name} '{obj.Label}' \t| "
                    + $"{obj.Color}");

            Spacer();
            #endregion

            #region Task 2
            Console.WriteLine("Liste aller 2D-Objekte" + Environment.NewLine);

            shapes2D.Add(circle1);
            shapes2D.Add(rectangle1);

            foreach (var obj in shapes2D)
                Console.WriteLine($"{obj.GetType().Name} '{obj.Label}' \t| "
                    + $"Surface: {Math.Round(obj.Surface, 2)}; "
                    + $"Circumference: {Math.Round(obj.Circumference, 2)}");

            Spacer();
            #endregion

            #region Task 3
            Console.WriteLine("Liste aller 3D-Objekte" + Environment.NewLine);
            
            shapes3D.Add(cube1);
            shapes3D.Add(sphere1);

            foreach (var obj in shapes3D)
            {
                var material = (Material)materialValues.GetValue(random.Next(materialValues.Length));

                Console.WriteLine($"{obj.GetType().Name} '{obj.Label}' "
                    + $"\t| Volume: {Math.Round(obj.Volume, 2)};"
                    + $"\t| Surface: {Math.Round(obj.Surface, 2)};"
                    + $"\t| Weight ({material}): {Math.Round(CalculateWeight(obj, material))} g");
            }

            Spacer();
            #endregion

            #region Task 4
            Console.WriteLine("Liste aller eckigen Objekte" + Environment.NewLine);

            angularShapes.Add(cube1);
            angularShapes.Add(rectangle1);

            foreach (var obj in angularShapes)
                Console.WriteLine($"{obj.GetType().Name} '{obj.Label}' \t| "
                    + $"Length: {Math.Round(obj.Length, 2)}; "
                    + $"Width: {Math.Round(obj.Width, 2)}");

            Spacer();
            #endregion

            #region Task 5
            Console.WriteLine("Liste aller runden Objekte" + Environment.NewLine);

            roundedShapes.Add(circle1);
            roundedShapes.Add(sphere1);

            foreach (var obj in roundedShapes)
                Console.WriteLine($"{obj.GetType().Name} '{obj.Label}' \t| "
                    + $"Length: {Math.Round(obj.Radius, 2)}; "
                    + $"Width: {Math.Round(obj.Diameter, 2)}");

            Spacer();
            #endregion
        }

        private static void Spacer()
        {
            Console.WriteLine(Environment.NewLine
                + "----------------------------------------------------------------"
                + Environment.NewLine);
        }

        private static double CalculateWeight(IShape3D shape3D, Material element)
        {
            return element switch
            {
                Material.Air => shape3D.Volume * 0.0013,
                Material.Water => shape3D.Volume * 1.0,
                Material.Glass => shape3D.Volume * 2.5,
                Material.Iron => shape3D.Volume * 7.9,
                _ => 0.0,
            };
        }
    }

    public enum Material
    {
        Air,
        Water,
        Glass,
        Iron
    }
}
