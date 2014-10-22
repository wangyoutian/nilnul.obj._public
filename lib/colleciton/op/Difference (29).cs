﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.element.collection.set;

namespace nilnul.element.collection.set
{
	public class Difference 
		:SetOpA,
		DifferenceI

	{

		static  private readonly Difference _Instance = new Difference();
		private Difference() { }
		static  public Difference Instance
		{
			get
			{
				return _Instance;
			}
		}


		public override char sign
		{
			get { return '-'; }
		}
	}
}
