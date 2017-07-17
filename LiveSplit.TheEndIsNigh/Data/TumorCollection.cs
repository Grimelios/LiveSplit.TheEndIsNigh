using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveSplit.TheEndIsNigh.Memory;

namespace LiveSplit.TheEndIsNigh.Data
{
	/// <summary>
	/// Data class used to track the player's tumor count.
	/// </summary>
	public class TumorCollection : AutosplitDataClass
	{
		private int tumorCount;

		/// <summary>
		/// Constructs the class.
		/// </summary>
		public TumorCollection(EndIsNighMemory memory) : base(memory)
		{
		}

		/// <summary>
		/// Resets the collection.
		/// </summary>
		public override void Reset()
		{
			tumorCount = 0;
		}

		/// <summary>
		/// Checks whether the given tumor count has been reached. Note that for the purposes of this autosplitter, tumors are only
		/// considered collected when they are confirmed (i.e. a tumor is collected and then the player moves to a new level). 
		/// </summary>
		public override bool QueryData(object data)
		{
			int newTumorCount = Memory.GetTumorCount();

			if (newTumorCount > tumorCount)
			{
				tumorCount = newTumorCount;

				if (tumorCount >= (int)data)
				{
					return true;
				}
			}

			return false;
		}
	}
}
