using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.obj
{
    static public class SwapX
    {
		static public void Swap<T>(ref T first, ref T second) {
			T temp = first;
			first=second;
			second= temp;
	
		
		}
		static public void Swap<T>(this List<T> list, int i,int j) {
			T t = list[i];

			list[i] = list[j];
			list[j] = t;
		}
    }
}
