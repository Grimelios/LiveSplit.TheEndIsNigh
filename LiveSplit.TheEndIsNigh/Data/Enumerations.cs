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
		Body
	}

	/// <summary>
	/// Enumeration listing all cartridges.
	/// </summary>
	public enum Cartridges
	{
	}

	/// <summary>
	/// Enumeration storing objects the player can interact with.
	/// </summary>
	public enum Interactions
	{
		Friend
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
		Blight
	}
}
