using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj.op
{
	/// <summary>
	/// An Expression with two arguments. The op is not specified here; it can be specified in a subtype, say divideExpression,  which implies an op in the definition, not in the field.
	/// </summary>
	/// <typeparam name="A1"></typeparam>
	/// <typeparam name="A2"></typeparam>
	public abstract partial class ArgsA<T>
	
	{
		private T _arg;
		
		public ArgsA(T arg){
			this.arg = arg;
		}

		public T arg
		{
			get
			{
				return _arg;
			}
			set
			{
				_arg=value;
			}
		}



	}
}
