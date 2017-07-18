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

		private MapGrid mapGrid;
		private TumorCollection tumorCollection;
		private BodyPartCollection bodyPartCollection;
		private CartridgeCollection cartridgeCollection;
		private WorldEventCollection worldEventCollection;

		private int splitIndex;

		/// <summary>
		/// Constructs the class.
		/// </summary>
		public SplitCollection(EndIsNighComponent parent, AutosplitDataClass[] dataClasses)
		{
			this.parent = parent;

			mapGrid = (MapGrid)dataClasses[0];
			tumorCollection = (TumorCollection)dataClasses[1];
			bodyPartCollection = (BodyPartCollection)dataClasses[2];
			cartridgeCollection = (CartridgeCollection)dataClasses[3];
			worldEventCollection = (WorldEventCollection)dataClasses[4];

			// Creating an empty array prevents null pointers in a few locations.
			splits = new Split[0];
		}

		/// <summary>
		/// Array of splits. Can be set directly while loading or modifying splits.
		/// </summary>
		public Split[] Splits
		{
			get { return splits; }
			set
			{
				splits = value;
				currentSplit = splits[0];
			}
		}

		/// <summary>
		/// Called when the timer splits.
		/// </summary>
		public void OnSplit()
		{
			AdvanceSplit();
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
			AdvanceSplit();
		}

		/// <summary>
		/// Advances the current split.
		/// </summary>
		private void AdvanceSplit()
		{
			currentSplit = ++splitIndex < splits.Length ? splits[splitIndex] : null;
		}

		/// <summary>
		/// Called when the timer resets.
		/// </summary>
		public void OnReset()
		{
			currentSplit = splits.Length > 0 ? splits[splitIndex = 0] : null;
		}

		/// <summary>
		/// Updates the split collection. During update, different data classes are queried for data based on the current split.
		/// </summary>
		public void Update()
		{
			// Current split being null indicates that splits were never set up by the player.
			if (currentSplit == null)
			{
				return;
			}

			if (CheckSplit())
			{
				parent.Split();
			}
		}

		/// <summary>
		/// Checks whether the split criteria for the current split have been met.
		/// </summary>
		private bool CheckSplit()
		{
			object data = currentSplit.Data;

			switch (currentSplit.Type)
			{
				case SplitTypes.BodyPart:
					return bodyPartCollection.QueryData((BodyParts)data);

				case SplitTypes.CartridgeCount:
					return cartridgeCollection.QueryData((int)data);

				case SplitTypes.TumorCount:
					return tumorCollection.QueryData((int)data);

				case SplitTypes.WorldEvent:
					return worldEventCollection.QueryData((WorldEvents)data);

				case SplitTypes.Zone:
					return mapGrid.QueryData((Zones)data);
			}

			return false;
		}
	}
}
