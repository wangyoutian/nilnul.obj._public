using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.lambda
{
	public partial interface LambdaI<TVar,TExpr>
		:LambdaI<TExpr>
	{

		VarI2<TVar> var { get; }

		LambdaI<TVar,TExpr> substitute(VarI2<TVar> var, ExprI2<TVar> expr);

		LambdaI<TExpr> apply(ExprI2<TVar> expr);




	}
}
