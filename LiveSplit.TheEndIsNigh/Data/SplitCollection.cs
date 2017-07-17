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

			Splits = new []
			{
				new Split(SplitTypes.CartridgeCount, 1)
			};

			currentSplit = Splits[0];
		}

		/// <summary>
		/// Array of splits. Can be set directly from the collection control.
		/// </summary>
		public Split[] Splits { get; set; }

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
			currentSplit = Splits[--splitIndex];
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
			currentSplit = ++splitIndex < Splits.Length ? Splits[splitIndex] : null;
		}

		/// <summary>
		/// Called when the timer resets.
		/// </summary>
		public void OnReset()
		{
			currentSplit = Splits[splitIndex = 0];
		}

		/// <summary>
		/// Updates the split collection. During update, different data classes are queried for data based on the current split.
		/// </summary>
		public void Update()
		{
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
