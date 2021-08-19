using System.Drawing;

using Geometry.Core.Interfaces;

namespace Geometry.Core.Types
{
    public abstract class Shape : Entity, IShape
    {
        public Color Color { get; set; }
    }
}
