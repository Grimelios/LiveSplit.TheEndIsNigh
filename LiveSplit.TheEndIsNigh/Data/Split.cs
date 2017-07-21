using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSplit.TheEndIsNigh.Data
{
	/// <summary>
	/// Enumeration storing split types. Split type is used to determine when and how to split.
	/// </summary>
	public enum SplitTypes
	{
		BodyPart,
		CartridgeCount,
		FutureCompletion,
		Level,
		TumorCount,
		WorldEvent,
		Zone,
		Unassigned
	}

	/// <summary>
	/// Represents a single split. Splits can be configured based on category and personal preference.
	/// </summary>
	public class Split
	{
		/// <summary>
		/// Constructs the class.
		/// </summary>
		public Split(SplitTypes type, object data)
		{
			Type = type;
			Data = data;
		}

		/// <summary>
		/// Constructs the class. The string data is parsed based on split type.
		/// </summary>
		public Split(SplitTypes type, string data)
		{
			Type = type;
			Data = ParseData(type, data);
		}

		/// <summary>
		/// Split type.
		/// </summary>
		public SplitTypes Type { get; }

		/// <summary>
		/// Data associated with the split. Using a pure object seemed simpler than creating extending classes for different split types.
		/// </summary>
		public object Data { get; }

		/// <summary>
		/// Parses the given string data based on split type.
		/// </summary>
		private object ParseData(SplitTypes type, string data)
		{
			switch (type)
			{
				case SplitTypes.BodyPart:
					return (BodyParts)Enum.Parse(typeof(BodyParts), data);

				case SplitTypes.CartridgeCount:
				case SplitTypes.TumorCount:
				case SplitTypes.FutureCompletion:
					return int.Parse(data);

				case SplitTypes.Level:
					string[] tokens = data.Split(',');

					int x = int.Parse(tokens[0]);
					int y = int.Parse(tokens[1]);

					return new Point(x, y);

				case SplitTypes.WorldEvent:
					return (WorldEvents)Enum.Parse(typeof(WorldEvents), data);

				case SplitTypes.Zone:
					return (Zones)Enum.Parse(typeof(Zones), data);
			}

			return null;
		}
	}
}
