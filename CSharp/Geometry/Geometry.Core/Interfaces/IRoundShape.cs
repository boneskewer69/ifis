namespace Geometry.Core.Interfaces
{
    public interface IRoundShape : IShape
    {
        double Radius { get; }
        double Diameter { get; }
        double Surface { get; }
    }
}
