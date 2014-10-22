using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.op;

namespace nilnul.op
{

	/// <summary>
	/// arguments with an op, possibly a composite op.
	/// </summary>
	/// <typeparam name="R"></typeparam>
	/// <typeparam name="A"></typeparam>
	public partial class Expr<R, A>
		:ExprI<R>
	{

		UnaOpI<A, R> op;

		A arg;


		public Expr(A arg, UnaOpI<A,R> op)
		{
			this.op = op;
			this.arg = arg;
		}
					






	}
}
