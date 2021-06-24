using System;

using Geometry.Interfaces;

namespace Geometry.Types.Shape3D
{
    public class Sphere : Shape3D, IRoundShape
    {
        public double Radius { get; set; }
        
        public double Diameter => Radius * 2;
        public override double Surface => Math.Pow(Math.PI * Radius, 2);
        public override double Volume => 4 / 3 * Math.PI * Math.Pow(Radius, 3);


        public override void Enlarge(double factor)
        {
            Radius *= factor;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}, '{Label}', {Color} | Coordinates (x,y,z): {CoordinateX}, {CoordinateY}, {CoordinateZ} | Radius: {Radius}";
        }
    }
}
