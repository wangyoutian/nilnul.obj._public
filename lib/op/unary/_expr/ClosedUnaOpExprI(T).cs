﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul_obj.function;

namespace nilnul_obj.op.unary
{
	/// <summary>
	/// op: closedUnaOpI(T)
	/// a: exprI(T)
	/// :ExprI(T)
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial interface ClosedUnaOpExprI<T> 
		
		:
		UnaOpExprI<T, T, ExprI<T>>,
		
		UnaOpCallI<ExprI<T>, ClosedUnaOpI<T>>
	{

	}
}
