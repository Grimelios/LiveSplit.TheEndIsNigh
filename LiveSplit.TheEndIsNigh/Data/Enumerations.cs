﻿using System;
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
		Body,
		Unassigned
	}

	/// <summary>
	/// Enumeration storing all cartridges.
	/// </summary>
	public enum Cartridges
	{
		Martaman,
		BlasterMassacre,
		RiverCityRancid,
		Catastrovania,
		DigDead,
		AshClimber,
		FallenFantasy,
		RubbleBobble,
		MorbidGear,
		SuperMegaCart,
		Denial,
		Anger,
		Bargaining,
		Depression,
		Acceptance,
		ScabOrDie,
		TombsAndTorture,
		PusMan,
		GhostsNGrieving,
		DeadRacer,
		SpikeTales,
		TheEndIsNigh
	}

	/// <summary>
	/// Enumeration storing world events (often triggered by player interaction).
	/// </summary>
	public enum WorldEvents
	{
		Friend,
		Escape,
		End1,
		End2,
		Unassigned
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
		Nevermore,

		Unassigned
	}
}
