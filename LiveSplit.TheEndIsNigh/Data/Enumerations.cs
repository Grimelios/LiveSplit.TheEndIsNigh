using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSplit.TheEndIsNigh.Data
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
	/// Enumeration listing all cartridges.
	/// </summary>
	public enum Cartridges
	{
	}

	/// <summary>
	/// Enumeration storing world events (often triggered by player interaction).
	/// </summary>
	public enum WorldEvents
	{
		Friend,
		Escape,
		BeatEnd1,
		BeatEnd2
	}

	/// <summary>
	/// Enumeration storing zones (i.e. major areas of the game). This includes areas in the future.
	/// </summary>
	public enum Zones
	{
		// The past.
		TheEnd,
		AridFlats,
		Overflow,
		TheSplit,
		WallOfSorrow,
		SSExodus,
		Retrograde,
		TheMachine,
		TheHollows,
		Golgotha,

		// The future.
		Anguish,
		Gloom,
		Blight,
		Ruin,
		Acceptance,
		Nevermore
	}
}
