using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{

	public partial class Eq<T>: 
		EqualityComparer<T>
		,IEquatable<Eq<T>>
	{

		private Func<T,T,bool> _comparer;

		public Eq(Func<T,T,bool>comparer)
		{
			this._comparer = comparer;

		}




		public override bool Equals(T x, T y)
		{
			return _comparer(x,y);
		}

		public override int GetHashCode(T obj)
		{
			return obj.GetHashCode();
		}


		public bool Equals(Eq<T> other)
		{
			return this._comparer == other._comparer;

			throw new NotImplementedException();
		}
	}


}
