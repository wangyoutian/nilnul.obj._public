using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
	public partial class Assert<T,TBe>
		
		where TBe:BeI<T>,new()
	{
		public void assert(T val) {
			if (!SingletonByDefaultNew<TBe>.Instance.be(val))
			{
				throw new Exception();
				
			}
		}
	}
}
