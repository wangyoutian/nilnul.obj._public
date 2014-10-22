﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.eq
{
	public partial class Context<T,TEq>
		where TEq:IEqualityComparer<T>,new()
	{
		static public TEq Eq = SingletonByDefaultNew<TEq>.Instance;

	}
}
