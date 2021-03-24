using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Lab_1.Shape.Polygon
{
    public class Triangle : BaseShape
    {
        private int[] _firstV;
        private int[] _secondV;
        private int[] _thirdV;

        public int[] FirstV
        {
            get
            {
                return _firstV;
            }

            set
            {
                _firstV = value;
            }
        }

        public int[] SecondV
        {
            get
            {
                return _secondV;
            }

            set
            {
                    _secondV = value;
            }
        }

        public int[] ThirdV
        {
            get
            {
                return _thirdV;
            }

            set
            {
                    _thirdV = value;
            }
        }

        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawPolygon(pen,
                new Point[] { new Point(_firstV[0], _firstV[1]),
                              new Point(_secondV[0], _secondV[1]),
                              new Point(_thirdV[0], _thirdV[1])
                }
            );
        }

        public override void Init(float endX, float endY)
        {
            FirstV = new int[] { (int) (X + (endX - X) / 2), (int) Y };
            SecondV = new int[] { (int) X, (int) endY };
            ThirdV = new int[] { (int) endX, (int) endY };

        }

        public Triangle(float x, float y) : base(x, y)
        {
        }
    }
}
