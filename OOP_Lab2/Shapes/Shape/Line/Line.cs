using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lab_1.Shape.Line
{
    public class Line : BaseShape
    {
        public float EndX { get; set; }
        public float EndY { get; set; }

        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, new Point((int) X, (int) Y), new Point((int) EndX, (int) EndY));
        }

        public override void Init(float endX, float endY)
        {
            EndX = endX;
            EndY = endY;
        }

        public Line(float x, float y) : base(x, y)
        {
        }
    }
}