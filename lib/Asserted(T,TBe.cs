using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	public partial class Asserted<T,TBe>
		:Box1<T>
		where TBe:BeI<T>,new()
	{
		public Asserted(T val)
			:base(val)
		{
			SingletonByDefaultNew<Assert<T, TBe>>.Instance.assert(val);


		}
	}
}
