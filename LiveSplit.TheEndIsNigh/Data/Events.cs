using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSplit.TheEndIsNigh.Data
{
	/// <summary>
	/// Static class storing events used to split (i.e. world events).
	/// </summary>
	public static class Events
	{
		/// <summary>
		/// Called when the player enters a new level for the first time.
		/// </summary>
		public static event Action<Point> NewLocationEvent;

		/// <summary>
		/// Triggers the new location event.
		/// </summary>
		public static void OnNewLocation(Point location)
		{
			NewLocationEvent.Invoke(location);
		}
	}
}
