using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveSplit.TheEndIsNigh.Memory;

namespace LiveSplit.TheEndIsNigh.Data
{
	/// <summary>
	/// Represents an abstract class used to track game data used to trigger splits.
	/// </summary>
	public abstract class AutosplitDataClass
	{
		/// <summary>
		/// Constructs the class.
		/// </summary>
		protected AutosplitDataClass(EndIsNighMemory memory)
		{
			Memory = memory;
		}

		/// <summary>
		/// Reference to an instance of the memory class.
		/// </summary>
		protected EndIsNighMemory Memory { get; }

		/// <summary>
		/// Resets the class.
		/// </summary>
		public abstract void Reset();

		/// <summary>
		/// Checks game memory for the given data to determine whether to split. Used directly by the split collection in order to reduce
		/// unneeded memory checks during a run.
		/// </summary>
		public abstract bool QueryData(object data);
	}
}
