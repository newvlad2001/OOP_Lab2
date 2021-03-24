using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lab_1.Shape.Ellipse
{
    public class Circle : BaseShape
    {
        public float Radius
        {
            get; set;
        }

        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawEllipse(pen, X, Y, Radius, Radius);
        }

        public override void Init(float endX, float endY)
        {
            Radius = Math.Abs(endX - X) > Math.Abs(endY - Y) ? endX - X : endY - Y;
        }

        public Circle(float x, float y) : base(x, y)
        {
        }
    }
}
