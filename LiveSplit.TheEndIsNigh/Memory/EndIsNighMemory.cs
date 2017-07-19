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
				
				dataPointer = process.MainModule.BaseAddress + MemoryOffsets.StructureOffset;
			}

			return true;
		}

		/// <summary>
		/// Returns the number of frames the game has been running (i.e. in-game frames). This value only updates during gameplay.
		/// </summary>
		public long GetInGameTime()
		{
			return process.Read<long>(dataPointer, MemoryOffsets.InGameTime);
		}

		/// <summary>
		/// Gets the current death count.
		/// </summary>
		public int GetDeathCount()
		{
			return process.Read<int>(dataPointer, MemoryOffsets.DeathCount);
		}

		/// <summary>
		/// Gets the current tumor count.
		/// </summary>
		public int GetTumorCount()
		{
			return process.Read<int>(dataPointer, MemoryOffsets.TumorCount);
		}

		/// <summary>
		/// Gets the current cartridge count.
		/// </summary>
		public int GetCartridgeCount()
		{
			return process.Read<int>(dataPointer, MemoryOffsets.CartridgeCount);
		}

		/// <summary>
		/// Checks whether the in-game flag is set.
		/// </summary>
		public bool CheckInGame()
		{
			return process.Read<bool>(dataPointer, MemoryOffsets.InGame);
		}

		/// <summary>
		/// Checks whether a file was just selected (i.e. the autosplitter should start).
		/// </summary>
		public bool CheckFileSelect()
		{
			return process.Read<bool>(dataPointer, MemoryOffsets.FileSelect);
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
					offset = MemoryOffsets.Head;
					break;

				case BodyParts.Heart:
					offset = MemoryOffsets.Heart;
					break;

				case BodyParts.Body:
					offset = MemoryOffsets.Body;
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
					offset = MemoryOffsets.AssembledFriend;
					break;

				case WorldEvents.Escape:
					offset = MemoryOffsets.Escaping;
					break;

				case WorldEvents.End1:
					offset = MemoryOffsets.BeatEnd1;
					break;

				case WorldEvents.End2:
					offset = MemoryOffsets.BeatEnd2;
					break;
			}

			return process.Read<bool>(dataPointer, offset);
		}

		/// <summary>
		/// Gets the player's current location in the game's level grid.
		/// </summary>
		public Point GetWorldLocation()
		{
			int x = process.Read<int>(dataPointer, MemoryOffsets.WorldGridX);
			int y = process.Read<int>(dataPointer, MemoryOffsets.WorldGridY);

			return new Point(x, y);
		}
	}
}
