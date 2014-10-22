﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.linearAlgebra;

using nilnul.collection.set;

namespace nilnul.collection.set.operation
{
	
	

	public class Union<T> :Set<T>,

		IUnion<T> 

		where T:IEquatable<T>
	{

		private IList<Set<T>> _operands;

		//public Union(IList<Set<T>> operands) {
		//    _operands = operands;
		//}

		public Union(params Set<T>[] operands) {
			_operands = operands.ToList();
		}
		public IList<Set<T>> operands {
			get {
				return _operands;
			}
		}

		public override string ToString()
		{
			return "+(" + operands.ToArray().toString() + ")";
		}

		
	}
}
