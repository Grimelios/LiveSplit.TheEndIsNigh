using System;
using System.Collections.Generic;
using System.Drawing;
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
		private Split currentSplit;
		private EndIsNighComponent parent;

		private int splitIndex;

		/// <summary>
		/// Constructs the class.
		/// </summary>
		public SplitCollection(EndIsNighComponent parent)
		{
			this.parent = parent;

			Events.NewLocationEvent += OnNewLocation;
		}

		/// <summary>
		/// Called when the player enters a new level for the first time.
		/// </summary>
		private void OnNewLocation(Point location)
		{
			if (currentSplit.Type == SplitTypes.Zone && (Point)currentSplit.Data == location)
			{
				parent.Split();
				splitIndex++;
			}
		}

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
