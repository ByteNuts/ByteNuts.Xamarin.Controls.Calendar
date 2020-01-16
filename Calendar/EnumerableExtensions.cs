using System;
using System.Collections.Generic;

namespace ByteNuts.Xamarin.Controls.Calendar
{
	public static class EnumerableExtensions
	{
		public static void ForEach<T>(this IEnumerable<T> enumeration, Action<T> action)
		{
			foreach (T item in enumeration)
			{
				action(item);
			}
		}
	}
}