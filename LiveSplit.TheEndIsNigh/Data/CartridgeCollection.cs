using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveSplit.TheEndIsNigh.Memory;

namespace LiveSplit.TheEndIsNigh.Data
{
	/// <summary>
	/// Data class used to track cartridge count.
	/// </summary>
	public class CartridgeCollection : AutosplitDataClass
	{
		private int cartridgeCount;

		/// <summary>
		/// Constructs the class.
		/// </summary>
		public CartridgeCollection(EndIsNighMemory memory) : base(memory)
		{
		}

		/// <summary>
		/// Resets the collection.
		/// </summary>
		public override void Reset()
		{
			cartridgeCount = 0;
		}

		/// <summary>
		/// Checks whether the given cartridge count has been reached. Unlike tumors, cartridges update the moment you collect them (i.e.
		/// you don't need to move offscreen).
		/// </summary>
		public override bool QueryData(object data)
		{
			int newCartridgeCount = Memory.GetCartridgeCount();

			if (newCartridgeCount > cartridgeCount)
			{
				cartridgeCount = newCartridgeCount;

				if (cartridgeCount >= (int)data)
				{
					return true;
				}
			}

			return false;
		}
	}
}
