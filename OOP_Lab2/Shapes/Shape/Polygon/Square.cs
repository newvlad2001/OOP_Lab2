using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lab_1.Shape.Polygon
{
    public class Square : BaseShape
    {
        public float _side;

        public float Side
        {
            get
            {
                return _side;
            }

            set
            {
                if (value > 0)
                {
                    _side = value;
                }
            }
        }


        public override void Draw(Graphics graphics, Pen pen)
        {            
            graphics.DrawRectangle(pen, X, Y, Side, Side);
        }

        public override void Init(float endX, float endY)
        {
            Side = Math.Max(Math.Abs(X - endX), Math.Abs(Y - endY));
        }

        public Square(float x, float y) : base(x, y)
        {
        }
    }
}
