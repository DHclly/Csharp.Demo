using System;

namespace Csharp.Demo.Keyword_class.NestedClass.GeometricShape.Shape
{
    class Triangle:AbstractShape
    {
        #region Overrides of AbstractShape

        public override void Draw()
        {
            Console.WriteLine("Triangle.Draw()");
        }

        #endregion
    }
}
