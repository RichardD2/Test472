using System;
using System.Linq;
using Test472.Core;

namespace ASP
{
	public static class Testing
	{
		private static void TestIt()
		{
			var list = Enumerable.Range(0, 10).ToHashSet();
		}
	}
}