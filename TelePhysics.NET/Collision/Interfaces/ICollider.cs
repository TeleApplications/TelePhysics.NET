using Microsoft.Xna.Framework;
using TelePhysics.NET.Structures;

namespace TelePhysics.NET.Collision.Interfaces
{
    public interface ICollider<T> where T : ICollider<T>
    {
        public Transform Transform { get; set; }

        public bool IsColliding(T collideObject);
    }
}
