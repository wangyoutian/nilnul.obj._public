using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.op
{
	public partial interface UnaOpI<in P,out R> 
		: 
		UnaOpI_P<P>
		,
		UnaOpI_R<R>
	{
		R eval(P a);
	}
}
