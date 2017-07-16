using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveSplit.TheEndIsNigh.Data;

namespace LiveSplit.TheEndIsNigh.Memory
{
	/// <summary>
	/// Helper class used to access various locations in the game's memory.
	/// </summary>
	public class EndIsNighMemory
	{
		private Process process;
		private IntPtr dataPointer;

		/// <summary>
		/// Attempts to find and hook the Windows process for The End Is Nigh. Returns true if the process was successfully found (and the
		/// program is running) or false otherwise.
		/// </summary>
		public bool HookProcess()
		{
			if (process == null || process.HasExited)
			{
				Process[] processes = Process.GetProcessesByName("TheEndIsNigh");
				process = processes.Length == 0 ? null : processes[0];

				if (processes.Length == 0 || process.HasExited)
				{
					return false;
				}

				dataPointer = process.FindSignatures(MemoryConstants.SearchString)[0];
			}

			return true;
		}

		/// <summary>
		/// Gets the current death count.
		/// </summary>
		public int GetDeathCount()
		{
			return process.Read<int>(dataPointer, MemoryConstants.DeathCount);
		}

		/// <summary>
		/// Gets the current tumor count.
		/// </summary>
		public int GetTumorCount()
		{
			return process.Read<int>(dataPointer, MemoryConstants.TumorCount);
		}

		/// <summary>
		/// Gets the current cartridge count.
		/// </summary>
		public int GetCartridgeCount()
		{
			return process.Read<int>(dataPointer, MemoryConstants.CartridgeCount);
		}

		/// <summary>
		/// Checks whether the in-game flag is set.
		/// </summary>
		public bool CheckInGame()
		{
			return process.Read<bool>(dataPointer, MemoryConstants.InGame);
		}

		/// <summary>
		/// Checks whether the player has collected the given body part.
		/// </summary>
		public bool CheckBodyPart(BodyParts bodyPart)
		{
			int offset = 0;

			switch (bodyPart)
			{
				case BodyParts.Head:
					offset = MemoryConstants.Head;
					break;

				case BodyParts.Heart:
					offset = MemoryConstants.Heart;
					break;

				case BodyParts.Body:
					offset = MemoryConstants.Body;
					break;
			}

			return process.Read<bool>(dataPointer, offset);
		}

		/// <summary>
		/// Checks whether the given world event has been triggered.
		/// </summary>
		public bool CheckWorldEvent(WorldEvents worldEvent)
		{
			int offset = 0;

			switch (worldEvent)
			{
				case WorldEvents.Friend:
					offset = MemoryConstants.AssembledFriend;
					break;

				case WorldEvents.Escape:
					offset = MemoryConstants.Escaping;
					break;
			}

			return process.Read<bool>(dataPointer, offset);
		}

		/// <summary>
		/// Gets the player's current location in the game's level grid.
		/// </summary>
		public Point GetWorldLocation()
		{
			int x = process.Read<int>(dataPointer, MemoryConstants.WorldGridX);
			int y = process.Read<int>(dataPointer, MemoryConstants.WorldGridY);

			return new Point(x, y);
		}
	}
}
