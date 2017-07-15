using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSplit.TheEndIsNigh.Memory
{
	/// <summary>
	/// Helper class used to access various locations in the game's memory.
	/// </summary>
	public class EndIsNighMemory
	{
		private Process process;
		private IntPtr xPointer;
		private IntPtr yPointer;

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
			}

			return true;
		}

		/// <summary>
		/// Gets the player's current location in the game's level grid.
		/// </summary>
		public Point GetWorldLocation()
		{
			int x = process.Read<int>(xPointer);
			int y = process.Read<int>(yPointer);

			return new Point(x, y);
		}
	}
}
