using System.Drawing;

namespace Lab_1.Shape.Ellipse
{
    public class Ellipse : Circle
    {
        public float RadiusY { get; set; }

        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawEllipse(pen, X, Y, Radius, RadiusY);
        }

        public override void Init(float endX, float endY)
        {
            Radius = endX - X;
            RadiusY = endY - Y;
        }

        public Ellipse(float x, float y) : base(x, y)
        {
        }
    }
}
