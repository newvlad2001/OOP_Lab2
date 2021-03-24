using Lab_1;
using Lab_1.Shape;
using Lab_1.Shape.Line;

namespace OOP_Lab2_Form.Shapes.Factories
{
    public class LineFactory : IShapeFactory
    {
        public BaseShape CreateShape(float x, float y)
        {
            return new Line(x, y);
        }
    }
}