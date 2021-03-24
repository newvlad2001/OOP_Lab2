using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lab_1.Shape.Polygon
{
    public class Rectangle : Square
    {
        private float _secondSide;

        public float SecondSide
        {
            get
            {
                return _secondSide;
            }

            set
            {
                if (value > 0)
                {
                    _secondSide = value;
                }
            }
        }

        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawRectangle(pen, X, Y, Side, SecondSide);
        }

        public override void Init(float endX, float endY)
        {
            Side = Math.Abs(endX - X);
            SecondSide = Math.Abs(endY - Y);
        }

        public Rectangle(float x, float y) : base(x, y)
        {
        }
    }
}
