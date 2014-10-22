﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul_obj.bit;

namespace nilnul_obj.set.rel
{
	public partial class Disjoint<TElement>
		
	{
		static public Predicate<HashSet<TElement>, HashSet<TElement>> Create() {
			return Predicate<HashSet<TElement>, HashSet<TElement>>.CreateNegativeFrom(
				JointX.Is
			);
		}

		
		
					
	}
}
