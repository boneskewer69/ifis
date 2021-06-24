using Geometry.Interfaces;

namespace Geometry.Types.Shape3D
{
    public abstract class Shape3D : Shape, IShape3D
    {
        public double CoordinateX { get; set; }
        public double CoordinateY { get; set; }
        public double CoordinateZ { get; set; }

        public abstract double Volume { get; }
        public abstract double Surface { get; }
        

        public abstract void Enlarge(double factor);
    }
}
