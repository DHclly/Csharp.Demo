using System;

namespace Csharp.Demo.Keyword_class.NestedClass.GeometricShape.Shape
{
    class Circle:AbstractShape
    {
        #region Overrides of AbstractShape

        public override void Draw()
        {
            Console.WriteLine("Circle.Draw()");
        }

        #endregion
    }
}
