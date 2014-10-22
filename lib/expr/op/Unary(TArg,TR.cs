using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.expr.op
{
	public partial class Unary<TArg,TR>
		:nilnul.obj.op.UnaryI<ExprI2<TArg>,ExprI2<TR>>
	{
		private nilnul.obj.op.UnaryI<TArg,TR> _op;

		public nilnul.obj.op.UnaryI<TArg,TR> op
		{
			get { return _op; }
			set { _op = value; }
		}
		

			
		public Unary(nilnul.obj.op.UnaryI<TArg,TR> op)
		{
			this.op = op;

		}


		public class Expr
			:
			nilnul.obj.op.Call_OpArgA< nilnul.obj.op.UnaryI<TArg,TR>,ExprI2<TArg>>
			,
			nilnul.obj.ExprI2<TR>
		{


			public Expr( nilnul.obj.op.UnaryI<TArg,TR> op ,ExprI2<TArg> arg)
				:base(
				 
				 op,
				
				arg)
			{

			}
			
			public ExprI2<TR> substitute<V>( VarI2<V> var,ExprI2<V> expr)
			{
				return new Expr(this.op, this.arg.substitute(var, expr));

				throw new NotImplementedException();
			}
		}

		public ExprI2<TR> eval(ExprI2<TArg> a)
		{
			return new Expr(op, a);

			throw new NotImplementedException();
		}




	}
}
