using Geometry.Interfaces;

namespace Geometry.Types.Shape2D
{
    public abstract class Shape2D : Shape, IShape2D
    {
        public double CoordinateX { get; set; }
        public double CoordinateY { get; set; }

        public abstract double Surface { get; }
        public abstract double Circumference { get; }


        public abstract void Enlarge(double factor);
    }
}
