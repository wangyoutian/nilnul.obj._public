using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul.obj.op
{

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="P1"></typeparam>
	/// <typeparam name="R"></typeparam>
	/// 
	///morphism fro A to R
	public partial class Binary<P1,P2,R>

		:
		BinaryI<P1,P2,R>
		
	{
		Func<P1,P2, R> op;


		public Binary(Func<P1,P2,R> op)
		{
			this.op = op;
		}



		public R eval(P1 a,P2 b)
		{
			return op(a,b);
			throw new NotImplementedException();
		}




		public class Expr
			:ExprI2<R>
		{
			private ExprI2<P1> _arg;

			public ExprI2<P1> arg
			{
				get { return _arg; }
				set { _arg = value; }
			}


			private ExprI2<P2> _arg1;

			public ExprI2<P2> arg1
			{
				get { return _arg1; }
				set { _arg1 = value; }
			}
			
			private BinaryI<P1,P2,R> _op;

			public BinaryI<P1,P2,R> op
			{
				get { return _op; }
				set { _op = value; }
			}





			public R eval()
			{
				return op.eval(arg.eval(),arg1.eval());

				throw new NotImplementedException();
			}
		}

		public class Expr2
			:
			Call_OpArgArg1A<BinaryI<P1,P2,R>,ExprI3<P1>,ExprI3<P2>>
			,
			ExprI3<R>
		{

			public Expr2(BinaryI<P1,P2,R> op,ExprI3<P1> p1,ExprI3<P2> arg2 )
				:base(op,p1,arg2)
			{
			}
	
		}

		public class Const:
			Call_OpArgArg1A<BinaryI<P1,P2,R> ,ConstI<P1>,ConstI<P2>>
			,ConstI<R>
		{

			public Const(
				BinaryI<P1,P2,R> op
				,
				ConstI<P1> arg
				,ConstI<P2> arg1
				
				)
				:base(op,arg,arg1)
			{

			}

			public R eval()
			{
				return op.eval( arg.eval(),arg1.eval());
				throw new NotImplementedException();
			}
		}
	}
}
