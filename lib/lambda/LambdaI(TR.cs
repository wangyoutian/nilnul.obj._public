using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.lambda
{
	public partial interface LambdaI<TExpr>
		:LambdaI
	{
		LambdaI<TExpr> expr
		{
			get;
		}

		LambdaI<TExpr> substitute<TVar>(VarI2<TVar> var,La);



	}
}
