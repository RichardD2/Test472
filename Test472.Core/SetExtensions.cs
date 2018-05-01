using System;
using System.Collections.Generic;

namespace Test472.Core
{
	public static class SetExtensions
	{
		public static HashSet<T> ToHashSet<T>(this IEnumerable<T> source)
		{
			if (source == null) throw new ArgumentNullException(nameof(source));
			return new HashSet<T>(source);
		}
	}
}
