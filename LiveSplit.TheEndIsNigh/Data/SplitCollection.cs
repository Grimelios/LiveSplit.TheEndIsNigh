using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveSplit.TheEndIsNigh.Events;

namespace LiveSplit.TheEndIsNigh.Data
{
	/// <summary>
	/// Represents a collection of splits. Splits are generally set from the configuration control (often using default settings).
	/// </summary>
	public class SplitCollection
	{
		private Split[] splits;
		private Split currentSplit;
		private EndIsNighComponent parent;

		private int splitIndex;

		/// <summary>
		/// Constructs the class.
		/// </summary>
		public SplitCollection(EndIsNighComponent parent)
		{
			this.parent = parent;
		}

		/// <summary>
		/// Called when the timer splits.
		/// </summary>
		public void OnSplit()
		{
			currentSplit = splits[++splitIndex];
		}

		/// <summary>
		/// Called when a split is undone.
		/// </summary>
		public void OnUndoSplit()
		{
			currentSplit = splits[--splitIndex];
		}

		/// <summary>
		/// Called when a split is skipped.
		/// </summary>
		public void OnSkipSplit()
		{
			currentSplit = splits[++splitIndex];
		}

		/// <summary>
		/// Called when the timer resets.
		/// </summary>
		public void OnReset()
		{
			currentSplit = splits[splitIndex = 0];
		}
	}
}
