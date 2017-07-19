using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSplit.TheEndIsNigh.Memory
{
	/// <summary>
	/// Static class used to store memory offsets for the game. See AutosplitData.jpg in the Reference folder for more information.
	/// </summary>
	public static class MemoryOffsets
	{
		/// <summary>
		/// Static offset to the autosplit data structure created by Tyler.
		/// </summary>
		public const int StructureOffset = 0x25EFD0;

		/// <summary>
		/// Offset to in-game time (frame count).
		/// </summary>
		public const int InGameTime = 0x10;

		/// <summary>
		/// Offset to death count.
		/// </summary>
		public const int DeathCount = InGameTime + 0x8;

		/// <summary>
		/// Offset to the player's X coordinate in the world grid.
		/// </summary>
		public const int WorldGridX = DeathCount + 0x4;

		/// <summary>
		/// Offset to the player's Y coordinate in the world grid.
		/// </summary>
		public const int WorldGridY = WorldGridX + 0x4;

		/// <summary>
		/// Offset to tumor count.
		/// </summary>
		public const int TumorCount = WorldGridY + 0x4;

		/// <summary>
		/// Offset to cartridge count.
		/// </summary>
		public const int CartridgeCount = TumorCount + 0x4;

		/// <summary>
		/// Offset to the body flag.
		/// </summary>
		public const int Body = CartridgeCount + 0x4;

		/// <summary>
		/// Offset to the heart flag.
		/// </summary>
		public const int Heart = Body + 0x1;

		/// <summary>
		/// Offset to the head flag.
		/// </summary>
		public const int Head = Heart + 0x1;

		/// <summary>
		/// Offset to the in-game flag.
		/// </summary>
		public const int InGame = Head + 0x1;

		/// <summary>
		/// Offset to the assembled-friend flag.
		/// </summary>
		public const int AssembledFriend = InGame + 0x1;

		/// <summary>
		/// Offset to the escaping flag (i.e. after interacting with the second friend).
		/// </summary>
		public const int Escaping = AssembledFriend + 0x1;

		/// <summary>
		/// Offset to the beat-end-one flag.
		/// </summary>
		public const int BeatEnd1 = Escaping + 0x1;

		/// <summary>
		/// Offset to the beat-end-two flag.
		/// </summary>
		public const int BeatEnd2 = BeatEnd1 + 0x1;

		/// <summary>
		/// Offset to the file-selected flag.
		/// </summary>
		public const int FileSelect = BeatEnd2 + 0x1;
	}
}
