using System.Collections;
using Csharp.Demo.Keyword_class.NestedClass.GeometricShape.Shape;

namespace Csharp.Demo.Keyword_class.NestedClass.GeometricShape
{
    public class Drawing : IEnumerable
    {
        private class Iterator : IEnumerator
        {
            private Drawing _drawing;
            private int _current;

            public Iterator(Drawing drawing)
            {
                this._drawing = drawing;
                this._current = -1;
            }
            #region Implementation of IEnumerator
            /// <summary>
            /// Gets the current element in the collection.
            /// </summary>
            /// <returns>
            /// The current element in the collection.
            /// </returns>
            public object Current
            {
                get
                {
                    return _drawing.shapes[_current];
                }
            }
            /// <summary>
            /// Advances the enumerator to the next element of the collection.
            /// </summary>
            /// <returns>
            /// true if the enumerator was successfully advanced to the next element; false if the enumerator has passed the end of the collection.
            /// </returns>
            /// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created. </exception>
            public bool MoveNext()
            {
                if (++_current >= _drawing.shapes.Count)
                {
                    return false;
                }
                return true;
            }

            /// <summary>
            /// Sets the enumerator to its initial position, which is before the first element in the collection.
            /// </summary>
            /// <exception cref="T:System.InvalidOperationException">The collection was modified after the enumerator was created. </exception>
            public void Reset()
            {
                this._current = -1;
            }
            #endregion
        }

        private ArrayList shapes;

        public Drawing()
        {
            this.shapes = new ArrayList();
        }

        public void Add(AbstractShape shape)
        {
            this.shapes.Add(shape);
        }
        #region Implementation of IEnumerable
        /// <summary>
        /// Returns an enumerator that iterates through a collection.
        /// </summary>
        /// <returns>
        /// An <see cref="T:System.Collections.IEnumerator"/> object that can be used to iterate through the collection.
        /// </returns>
        public IEnumerator GetEnumerator()
        {
            return new Iterator(this);
        }

        #endregion
    }
}
