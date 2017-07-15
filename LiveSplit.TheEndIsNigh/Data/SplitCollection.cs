using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSplit.TheEndIsNigh.Data
{
	/// <summary>
	/// Represents a collection of splits. Splits are generally set from the configuration control (often using default settings).
	/// </summary>
	public class SplitCollection
	{
		private Split[] splits;

		private int splitIndex;

		/// <summary>
		/// Called when the timer splits.
		/// </summary>
		public void OnSplit()
		{
			splitIndex++;
		}

		/// <summary>
		/// Called when a split is undone.
		/// </summary>
		public void OnUndoSplit()
		{
			splitIndex--;
		}

		/// <summary>
		/// Called when a split is skipped.
		/// </summary>
		public void OnSkipSplit()
		{
			splitIndex++;
		}

		/// <summary>
		/// Called when the timer resets.
		/// </summary>
		public void OnReset()
		{
			splitIndex = 0;
		}
	}
}
