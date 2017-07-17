using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSplit.TheEndIsNigh
{
	/// <summary>
	/// Static class storing extension methods for the project.
	/// </summary>
	public static class Extensions
	{
		/// <summary>
		/// Adds the given point to the source point.
		/// </summary>
		public static Point Add(this Point localPoint, Point point)
		{
			return new Point(localPoint.X + point.X, localPoint.Y + point.Y);
		}

		/// <summary>
		/// Resets the given boolean array to all false.
		/// </summary>
		public static void Reset(this bool[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				array[i] = false;
			}
		}
	}
}
