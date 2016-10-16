using System;

namespace Csharp.Demo.Keyword_class.NestedClass.GeometricShape.Shape
{
    class Rectangle:AbstractShape
    {
        #region Overrides of AbstractShape

        public override void Draw()
        {
            Console.WriteLine("Rectangle.Draw()");
        }

        #endregion
    }
}
