﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul_obj.op
{
	public partial interface OpCallI<Op> : OpCallI
		where Op:OpI
	{
		Op op
		{
			get;
			set;
		}
	}
}
