using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	public partial interface ExprI2<out T>:ExprI
	{
		ExprI2<T> substitute<V>( VarI2<V> var,ExprI2<V> expr);

	}
}
