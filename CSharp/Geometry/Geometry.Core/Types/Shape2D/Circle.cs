using System;

using Geometry.Core.Interfaces;

namespace Geometry.Core.Types.Shape2D
{
    public class Circle : Shape2D, IRoundShape
    {
        public double Radius { get; set; }

        public double Diameter => Radius * 2;
        public override double Surface => Math.PI * Math.Pow(Radius, 2);
        public override double Circumference => 2 * Math.PI * Radius;


        public override void Enlarge(double factor)
        {
            Radius *= factor;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}, '{Label}', {Color} | Coordinates (x,y,z): {CoordinateX}, {CoordinateY} | Radius: {Radius}";
        }
    }
}
