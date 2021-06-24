using System.Drawing;

using Geometry.Interfaces;

namespace Geometry.Types
{
    public abstract class Shape : Entity, IShape
    {
        public Color Color { get; set; }
    }
}
