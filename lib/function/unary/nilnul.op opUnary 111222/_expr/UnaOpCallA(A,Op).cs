using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.op
{
	public abstract partial class UnaOpCallA<TArg,TOp> 
		
		:OpCallA<TOp>
	


	{
		public TArg operand
		{
			get;
			set;
		}

		public UnaOpCallA(TArg operand,TOp op )
			:base(op)
		{
			this.operand = operand;

		}


	
	}
}
