using System.Drawing;

namespace Lab_1.Shape
{
    public abstract class BaseShape
    {
        private float _y;
        public float Y
        {
            get
            {
                return _y;
            }

            set
            {
                if (value > 0)
                {
                    _y = value;
                }
            }
        }

        private float _x;
        public float X
        {
            get
            {
                return _x;
            }

            set
            {
                if (value > 0)
                {
                    _x = value;
                }
            }
        }

        public BaseShape(float x, float y)
        {
            X = x;
            Y = y;
        }

        public abstract void Init(float endX, float endY);
        public abstract void Draw(Graphics graphics, Pen pen);
    }
}
