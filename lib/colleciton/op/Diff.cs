﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul_obj.collection.set.op
{
	public partial class Diff<T>:BinaryI<T>
	{
		public bit.op.binary.BinaryI membershipLogic
		{
			get {
				
				return bit.op.binary.Diff.Instance; 
			
			}
		}
	}
}
