using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveSplit.TheEndIsNigh.Memory;

namespace LiveSplit.TheEndIsNigh.Data
{
	/// <summary>
	/// Data class used to track world events.
	/// </summary>
	public class WorldEventCollection
	{
		private bool[] worldEvents;

		private EndIsNighMemory memory;

		/// <summary>
		/// Constructs the class.
		/// </summary>
		public WorldEventCollection(EndIsNighMemory memory)
		{
			this.memory = memory;
		}

		/// <summary>
		/// Resets the collection.
		/// </summary>
		public void Reset()
		{
			for (int i = 0; i < worldEvents.Length; i++)
			{
				worldEvents[i] = false;
			}
		}

		/// <summary>
		/// Updates the collection. Triggers world events when they are detected.
		/// </summary>
		public void Update()
		{
			for (int i = 0; i < worldEvents.Length; i++)
			{
				if (!worldEvents[i] && memory.CheckWorldEvent((WorldEvents)i))
				{
					worldEvents[i] = true;

					Console.WriteLine($"{(WorldEvents)i} event triggered.");
				}
			}
		}
	}
}
