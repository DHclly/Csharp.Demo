using Csharp.Demo.Keyword_class.NestedClass.GeometricShape.Shape;

namespace Csharp.Demo.Keyword_class.NestedClass.GeometricShape
{
    public class Demo
    {
        public static void Run()
        {
            AbstractShape rectangle = new Rectangle();
            AbstractShape circle = new Circle();
            AbstractShape triangle = new Triangle();
            Drawing drawing = new Drawing();
            drawing.Add(rectangle);
            drawing.Add(circle);
            drawing.Add(triangle);
            foreach (AbstractShape shape in drawing)
            {
                shape.Draw();
            }
        }
    }
}
