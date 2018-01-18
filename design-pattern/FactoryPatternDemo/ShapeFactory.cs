namespace FactoryPatternDemo
{
    class ShapeFactory
    {
        public Shape GetShape(string shapeType)
        {
            if (shapeType == null)
                return null;
            switch (shapeType.ToUpper())
            {
                case "CIRCLE":
                    return new Circle();
                case "RECTANGLE":
                    return new Rectangle();
                case "SQUARE":
                    return new Square();
                default:
                    return null;
            }
        }
    }
}