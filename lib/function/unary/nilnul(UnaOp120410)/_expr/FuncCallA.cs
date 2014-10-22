using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.op;

namespace nilnul.op
{

	/// <summary>
	/// arguments with an op, possibly a composite op.
	/// </summary>
	/// <typeparam name="R"></typeparam>
	/// <typeparam name="TArg"></typeparam>
	/// <remarks>
	/// This stands from a function call.
	/// </remarks>
	public partial class FuncCallA<TFunc, TArg>
		
	{

		TFunc function;

		TArg arg;


		public FuncCallA( TFunc function,TArg arg)
		{
			this.function = function;
			this.arg = arg;
		}
					






	}
}
