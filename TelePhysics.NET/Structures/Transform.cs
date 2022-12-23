using Microsoft.Xna.Framework;

namespace TelePhysics.NET.Structures
{
    public struct Transform
    {
        public Vector2 Position { get; set; } = Vector2.Zero;
        public Quaternion Rotation { get; set; } = Quaternion.Identity;
        public float Scale { get; set; } = 1f;

        public Transform() { }
        public Transform(Vector2 position, Quaternion rotation, float scale = 1f) 
        {
            Position = position;
            Rotation = rotation;
            Scale = scale;
        }
    }
}
