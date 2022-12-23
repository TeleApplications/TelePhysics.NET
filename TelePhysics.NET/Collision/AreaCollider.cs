using Microsoft.Xna.Framework;
using TelePhysics.NET.Collision.Interfaces;
using TelePhysics.NET.Structures;

namespace TelePhysics.NET.Collision
{
    public abstract class AreaCollider : ICollider<AreaCollider>
    {
        public Transform Transform { get; set; }
        public Vector2 Size { get; }

        public AreaCollider(Rectangle rectangle, Quaternion rotation)
        {
            Size = new Vector2(rectangle.Size.X, rectangle.Size.Y);

            var position = new Vector2(rectangle.Location.X, rectangle.Location.Y);
            Transform = new(position, rotation);
        }

        public bool IsColliding(AreaCollider collideObject) 
        {

        }

        public abstract float CalculateArea();
    }
}
