using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerClass
{
    class Test
    {
		public static void Main()
		{
			IndexerClass b = new IndexerClass();
			b[3] = 256;
			b[5] = 1024;
			for (int i = 0; i <= 10; i++)
			{
				Console.WriteLine("Element # {0} = {1}", i, b[i]);
			}
			Console.Read();
		}

	}
}
