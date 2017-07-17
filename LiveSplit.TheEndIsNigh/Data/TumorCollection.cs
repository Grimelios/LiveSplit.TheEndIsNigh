using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveSplit.TheEndIsNigh.Memory;

namespace LiveSplit.TheEndIsNigh.Data
{
	/// <summary>
	/// Data class used to store the player's tumor count during gameplay.
	/// </summary>
	public class TumorCollection
	{
		private int tumorCount;

		private EndIsNighMemory memory;

		/// <summary>
		/// Constructs the class.
		/// </summary>
		public TumorCollection(EndIsNighMemory memory)
		{
			this.memory = memory;
		}

		/// <summary>
		/// Resets tumor count.
		/// </summary>
		public void Reset()
		{
			tumorCount = 0;
		}

		/// <summary>
		/// Updates the collection. Triggers tumor events when a new tumor is collected (confirmed collection, i.e. when you collect a
		/// tumor and then move offscreen).
		/// </summary>
		public void Update()
		{
			int newTumorCount = memory.GetTumorCount();

			if (tumorCount != newTumorCount)
			{
				tumorCount = newTumorCount;

				Console.WriteLine($"Tumor collected ({tumorCount} total).");
			}
		}
	}
}
