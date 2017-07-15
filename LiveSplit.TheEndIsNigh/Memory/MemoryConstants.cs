using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSplit.TheEndIsNigh.Memory
{
	/// <summary>
	/// Static class used to store memory locations for the game. These locations were found pretty meticulously using Cheat Engine.
	/// </summary>
	public static class MemoryConstants
	{
		/// <summary>
		/// Byte array used to find the address of the player's X coordinate in the world grid. The Y coordinate will always be located
		/// four bytes after the X coordinate.
		/// </summary>
		public const string LocationByteArray = null;
	}
}
