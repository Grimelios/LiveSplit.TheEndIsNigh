using System;
using System.Collections.Generic;
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
		/// Split type.
		/// </summary>
		public SplitTypes Type { get; }

		/// <summary>
		/// Data associated with the split. Using a pure object seemed simpler than creating extending classes for different split types.
		/// </summary>
		public object Data { get; }
	}
}
