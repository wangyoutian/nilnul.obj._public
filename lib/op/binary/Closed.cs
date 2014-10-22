using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.op.binary
{
	public partial class Closed<T>
		:
		
		ClosedI<T>
	{
		private Func<T,T,T> _func;

		public Func<T,T,T> func
		{
			get { return _func; }
			set { _func = value; }
		}
		
		public Closed(Func<T,T,T> func)
		{
			this._func = func;

		}

		public T eval(T a, T b)
		{
			return _func(a, b);
			throw new NotImplementedException();
		}
	}
}
