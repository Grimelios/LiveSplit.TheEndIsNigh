using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSplit.TheEndIsNigh.Data
{
	/// <summary>
	/// Static class storing enumerations. Not all enumerations are stored here.
	/// </summary>
	public static class Enumerations
	{
		/// <summary>
		/// Enumeration storing body parts used to construct the friend.
		/// </summary>
		public enum BodyParts
		{
			Head,
			Heart,
			Body
		}

		/// <summary>
		/// Enumeration storing zones (i.e. major areas of the game).
		/// </summary>
		public enum Zones
		{
			TheEnd,
			AridFlats,
			Overflow,
			TheSplit,
			WallOfSorrow,
			SSExodus,
			Retrograde,
			TheMachine,
			TheHollows,
			Golgotha
		}
	}
}
