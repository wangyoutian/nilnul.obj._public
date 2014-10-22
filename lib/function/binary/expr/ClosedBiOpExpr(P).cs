﻿using System;
using System.Net;

namespace nilnul.op
{
	/// <summary>
	/// Given two literal expressions, return a literal expression.
	/// </summary>
	/// <typeparam name="A1"></typeparam>
	/// <typeparam name="A2"></typeparam>
	/// <typeparam name="P1"></typeparam>
	/// <typeparam name="P2"></typeparam>
	public partial class ClosedBiOpExpr<P>
		:
		BiOpCallA<ExprI<P>,ExprI<P>,ClosedBiOpI<P>>
		,
		ExprI<P>
		
		
		
	{
		

		public ClosedBiOpExpr(ExprI<P> a1, ExprI<P> a2, ClosedBiOpI<P> op ):
			base(a1,a2,op)
		{
			
		}
					

	}
}
