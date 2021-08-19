using System.Drawing;

using Geometry.Core.Interfaces;

namespace Geometry.Core.Types.Shape2D
{
    public class Rectangle : Shape2D, IAngularShape
    {
        public double Width { get; set; }
        public double Length { get; set; }


        public override double Surface => Width * Length;
        public override double Circumference => 2 * (Width + Length);


        public Rectangle()
        {
            Label = "Untitled";
            Color = Color.White;
            CoordinateX = 0.0;
            CoordinateY = 0.0;
            Length = 10.0;
            Width = 10.0;
        }


        public override void Enlarge(double factor)
        {
            Width *= factor;
            Length *= factor;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}, '{Label}', {Color} | Coordinates (x,y,z): {CoordinateX}, {CoordinateY} | Dimensions (Length, Width): {Length}, {Width}";
        }
    }
}
