using System;
using System.Collections.Generic;
using System.Linq;
using Test472.Core;

public partial class _default : System.Web.UI.Page
{
	private static void TestIt()
	{
		var list = Enumerable.Range(0, 10).ToHashSet();
	}
}