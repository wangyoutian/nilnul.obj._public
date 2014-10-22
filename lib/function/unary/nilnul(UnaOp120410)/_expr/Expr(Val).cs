using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.op;

namespace nilnul.op
{

	/// <summary>
	/// This is the function call on ValI(A). the function may be a composite function.
	/// 
	/// Note this is only a call expression. it doesn't execute. 
	/// 
	/// 
	/// </summary>
	/// <typeparam name="R"></typeparam>
	/// <typeparam name="A"></typeparam>
	public partial class ValExpr<A,R>
		:FuncCallA<UnaOpI<A,R>,ExprI<ValI<A>>>
		,
		ExprI<ValI<R>>
	{


		/// <summary>
		/// 
		/// </summary>
		/// <param name="arg">the vals: literal, or var</param>
		/// <param name="op">the op: parameter type: P, return type:R </param>
		public ValExpr( UnaOpI<A,R> op,ExprI<ValI<A>> arg)
			:base(op,arg)
		{
			
		}
					






	}
}
