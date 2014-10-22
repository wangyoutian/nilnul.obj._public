using System;
using System.Net;

namespace nilnul.obj
{

	/// <summary>
	///Inherited from this class, a class can wrap a val of Type TOriginal into a more abstract type.
	/// </summary>
	/// <typeparam name="TOriginal"></typeparam>
	public partial class Box1<TOriginal>
	{
		public TOriginal val;

		public Box1(TOriginal val)
		{
			this.val = val;
		}
					

		public TOriginal toOriginal() {

			return this.val;
		}

		static public implicit operator TOriginal(Box1<TOriginal> a) {
			return a.val;
		}
		static public implicit operator Box1<TOriginal>(TOriginal a) {
			return new Box1<TOriginal>(a);
		}

	}

	static public partial class X {

		static public TOriginal To<TOriginal,TTo>(this TTo a)
			where TTo:Box1<TOriginal>,new()
		{
			var r = new TTo();
			r.val = a;
			return r;
		}
		
	}
}
