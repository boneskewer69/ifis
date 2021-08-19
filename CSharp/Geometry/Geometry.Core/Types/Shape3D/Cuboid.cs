using Geometry.Core.Interfaces;

namespace Geometry.Core.Types.Shape3D
{
    public class Cuboid : Shape3D, IAngularShape
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public double Height { get; set; }


        public override double Volume => Width * Length * Height;
        public override double Surface => 2 * ((Width * Length) + (Width * Height) + (Length * Height));


        public override void Enlarge(double factor)
        {
            Width *= factor;
            Length *= factor;
            Height *= factor;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name}, '{Label}', {Color} | Coordinates (x,y,z): {CoordinateX}, {CoordinateY}, {CoordinateZ} | Dimensions (Length, Width, Height): {Length}, {Width}, {Height}";
        }
    }
}
