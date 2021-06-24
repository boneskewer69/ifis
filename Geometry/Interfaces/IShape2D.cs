namespace Geometry.Interfaces
{
    public interface IShape2D : IShape
    {
        double CoordinateX { get; }
        double CoordinateY { get; }

        double Surface { get; }
        double Circumference { get; }

        void Enlarge(double factor);
    }
}
