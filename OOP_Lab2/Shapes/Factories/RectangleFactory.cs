using Lab_1;
using Lab_1.Shape;
using Lab_1.Shape.Polygon;

namespace OOP_Lab2_Form.Shapes.Factories
{
    public class RectangleFactory : IShapeFactory
    {
        public BaseShape CreateShape(float x, float y)
        {
            return new Rectangle(x, y);
        }
    }
}