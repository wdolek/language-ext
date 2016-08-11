﻿using LanguageExt.TypeClasses;

namespace LanguageExt.Instances
{
    /// <summary>
    /// Equality test
    /// </summary>
    /// <param name="x">The left hand side of the equality operation</param>
    /// <param name="y">The right hand side of the equality operation</param>
    /// <returns>True if x and y are equal</returns>
    public struct EqLst<EQ, A> : Eq<Lst<A>> where EQ : struct, Eq<A>
    {
        public bool Equals(Lst<A> x, Lst<A> y)
        {
            if (x == null) return y == null;
            if (y == null) return false;
            if (ReferenceEquals(x, y)) return true;
            if (x.Count != y.Count) return false;

            var enumx = x.GetEnumerator();
            var enumy = y.GetEnumerator();
            for (int i = 0; i < x.Count; i++)
            {
                enumx.MoveNext();
                enumy.MoveNext();
                if (default(EQ).Equals(enumx.Current, enumy.Current)) return false;
            }
            return true;
        }
    }
}