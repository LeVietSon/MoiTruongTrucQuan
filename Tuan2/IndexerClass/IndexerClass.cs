using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerClass
{
    class IndexerClass
    {
		private int[] myArray = new int[100];
		public int this[int index]
		{
			get
			{
				If(index < 0 || index >= 100)    return 0;
		   else
					return myArray[index];
			}
			set
			{
				if (!(index < 0 || index >= 100))
					myArray[index] = value;
			}
		}

	}
}
