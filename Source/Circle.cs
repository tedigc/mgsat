using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace PolygonCollision {
    public class Circle {

        private Texture2D texture;
        private Vector2 position;
        private float radius;

        public Circle(Vector2 position, float radius) {
            this.position = position;
            this.radius = radius;
            texture = Assets.get().GetTexture("circle");
        }

        public void Draw() {
            Game.sb.Draw(texture, new Rectangle((int) position.X, (int) position.Y, (int) radius*2, (int) radius*2), Color.White );
        }

    }
}