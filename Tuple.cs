using System;
using System.Collections.Generic;
using System.Text;

namespace Tuples
{
    class Tuple<T, U, K>
    {
        private T item1;
        private U item2;
        private K item3;

        public Tuple()
        {

        }
        public Tuple(T item1, U item2, K item3)
        {
            this.Item1 = item1;
            this.Item2 = item2;
            this.Item3 = item3;
        }
        public K Item3
        {
            get { return item3; }
            set { item3 = value; }
        }

        public U Item2
        {
            get { return item2; }
            set { item2 = value; }
        }

        public T Item1
        {
            get { return item1; }
            set { item1 = value; }
        }

        public override string ToString()
        {
            var print = $"{item1} -> {item2} -> {item3}";
            return print.ToString();
        }

    }
}
