using System;
using System.Net;
using nilnul.element.expr;

namespace nilnul
{
	public partial class BiOpCallA<A1,A2,Op>
		:BiOpCallA<A1,A2>

		
		
		
	{
		Op op;
		

		public BiOpCallA(A1 a1,A2 a2, Op op ):
			base(a1,a2)
		{
			this.op = op;
			
		}
					

	}
}
