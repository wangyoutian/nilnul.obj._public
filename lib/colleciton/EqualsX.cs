﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul_obj.collection.set;
using nilnul_obj.collection.set.finite;

namespace set.collection.nilnul
{
	static public partial class EqualsX 
		
	{

		

		

		static public bool Equals<T>(IEnumerable<T> a, IEnumerable<T> b,Func<T,T,bool> equator)
		{

			return new FiniteSet<T>(a,equator).SetEquals(new FiniteSet<T>(b,equator));

		}

		
		





	}
}
