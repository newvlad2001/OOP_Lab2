namespace Lab_1
{
    public interface IShapeFactory
    {
        /// <summary>
        /// Create shape with the X and Y start pos
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Shape</returns>
        Shape.BaseShape CreateShape(float x, float y);
    }
}