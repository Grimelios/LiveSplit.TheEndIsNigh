using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveSplit.TheEndIsNigh.Memory;

namespace LiveSplit.TheEndIsNigh.Data
{
	/// <summary>
	/// Data class used to track cartridges.
	/// </summary>
	public class CartridgeCollection
	{
		private bool[] cartridges;

		private EndIsNighMemory memory;

		/// <summary>
		/// Constructs the class.
		/// </summary>
		public CartridgeCollection(EndIsNighMemory memory)
		{
			this.memory = memory;

			cartridges = new bool[0];
		}

		/// <summary>
		/// Resets the collection.
		/// </summary>
		public void Reset()
		{
			cartridges.Reset();
		}

		/// <summary>
		/// Updates the collection. Triggers cartridge events when a new cartridge is collected and confirmed (similar to tumors).
		/// </summary>
		public void Update()
		{
		}
	}
}
