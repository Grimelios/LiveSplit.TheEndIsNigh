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
	public class WorldEventCollection : AutosplitDataClass
	{
		private bool[] worldEvents;

		/// <summary>
		/// Constructs the class.
		/// </summary>
		public WorldEventCollection(EndIsNighMemory memory) : base(memory)
		{
			worldEvents = new bool[4];
		}

		/// <summary>
		/// Resets the collection.
		/// </summary>
		public override void Reset()
		{
			for (int i = 0; i < worldEvents.Length; i++)
			{
				worldEvents[i] = false;
			}
		}

		/// <summary>
		/// Checks whether the given world event has been triggered.
		/// </summary>
		public override bool QueryData(object data)
		{
			int index = (int)data;

			if (!worldEvents[index] && Memory.CheckWorldEvent((WorldEvents)index))
			{
				worldEvents[index] = true;

				return true;
			}

			return false;
		}
	}
}
