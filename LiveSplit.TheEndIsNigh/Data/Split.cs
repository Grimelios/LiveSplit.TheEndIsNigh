using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSplit.TheEndIsNigh.Data
{
	/// <summary>
	/// Enumeration storing split types. Split type is used by the main component to determine how and when to split.
	/// </summary>
	public enum SplitTypes
	{
		BodyPart,
		Interaction,
		Zone
	}

	/// <summary>
	/// Represents a single split. Splits can be configured based on category and personal preference.
	/// </summary>
	public class Split
	{
		/// <summary>
		/// Constructs the class. The data string is parsed based on split type. Using a string makes it easier to load splits from Json
		/// files.
		/// </summary>
		public Split(SplitTypes type, string data)
		{
			Type = type;

			switch (type)
			{
				case SplitTypes.BodyPart:
					Data = Enum.Parse(typeof(BodyParts), data);
					break;
			
				case SplitTypes.Zone:
					Data = Enum.Parse(typeof(Zones), data);
					break;
			}
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
