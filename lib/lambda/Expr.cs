using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace nilnul.obj.lambda
{
	public class Expr<T>
	{
		private Expression _expr;

		public Expression expr
		{
			get { return _expr; }
			set {
				Assert.True(
					value.Type==typeof(T)
				);
				_expr = value; 
			}
		}
				
	}
}
