﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul_obj.bit.op.binary
{
	/// <summary>
	/// not imply means: the difference of x-y, or x holds while y not.
	/// </summary>
	static public partial class NotImplyX
	{
		static public bool Eval(bool x,bool y) {
			return ! (ImplyX.Eval_byExpr(x, y) );
		
		}

	}
}
