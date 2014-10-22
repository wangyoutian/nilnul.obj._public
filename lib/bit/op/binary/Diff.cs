﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nilnul_obj.bit.op.binary
{
	public partial class Diff:BinaryI
	{

		static private readonly Diff _Instance = new Diff();
		static public Diff Instance
		{
			get
			{
				return _Instance;
			}
		}
		private Diff()
		{
		}
				
		public bool exec(bool a, bool b)
		{
			return a && (!b);
		}
	}
}
