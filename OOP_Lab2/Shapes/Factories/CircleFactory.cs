using Lab_1;
using Lab_1.Shape;
using Lab_1.Shape.Ellipse;

namespace OOP_Lab2_Form.Shapes.Factories
{
    public class CircleFactory : IShapeFactory
    {
        public BaseShape CreateShape(float x, float y)
        {
            return new Circle(x, y);
        }
    }
}