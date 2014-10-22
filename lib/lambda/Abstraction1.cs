using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.lambda
{
	public partial class Abstract1<TVar,TExpr>:
		//nilnul.obj.op.UnaryI<ExprI2<TVar>,ExprI2<TExpr>>
		//,
		LambdaI<TVar,TExpr>
	{
		private VarI2<TVar> _var;

		public VarI2<TVar> var
		{
			get { return _var; }
			set { _var = value; }
		}

		private LambdaI<TExpr> _expr;

		public LambdaI<TExpr> expr
		{
			get { return _expr; }
			set { _expr = value; }
		}

		public Abstract1(
			VarI2<TVar> var
			,LambdaI<TExpr> expr
		)
		{
			this.var = var;
			this.expr = expr;

		}



		public Abstract1<TVar,TExpr> substitute(VarI2<TVar> var, LambdaI<TVar> expr)
		{
			return new Abstract1<TVar,TExpr>( var, expr.substitute(var,expr));
			throw new NotImplementedException();
		}

		public LambdaI<TExpr> apply(ExprI2<TVar> expr)
		{
			throw new NotImplementedException();
		}
	}
}
