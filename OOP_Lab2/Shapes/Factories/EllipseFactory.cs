using Lab_1;
using Lab_1.Shape;
using Lab_1.Shape.Ellipse;

namespace OOP_Lab2_Form.Shapes.Factories
{
    public class EllipseFactory : IShapeFactory
    {
        public BaseShape CreateShape(float x, float y)
        {
            return new Ellipse(x, y);
        }
    }
}