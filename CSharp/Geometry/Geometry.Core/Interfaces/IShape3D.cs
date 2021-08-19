namespace Geometry.Core.Interfaces
{
    public interface IShape3D : IShape
    {
        double CoordinateX { get; }
        double CoordinateY { get; }
        double CoordinateZ { get; }
        
        double Volume { get; }
        double Surface { get; }

        void Enlarge(double factor);
    }
}
