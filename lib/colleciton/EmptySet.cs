﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul_obj.collection.set
{
	public partial class EmptySet:SetI<object>
	{

		static private readonly EmptySet _Instance = new EmptySet();
		static public EmptySet Instance
		{
			get
			{
				return _Instance;
			}
		}
		private EmptySet()
		{
		}
				
		public bool contains(object a)
		{
			return false;
		}
	}
}
