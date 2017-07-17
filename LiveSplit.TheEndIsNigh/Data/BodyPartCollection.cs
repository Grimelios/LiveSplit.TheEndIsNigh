using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveSplit.TheEndIsNigh.Memory;

namespace LiveSplit.TheEndIsNigh.Data
{
	/// <summary>
	/// Data class used to track the player's collected body parts.
	/// </summary>
	public class BodyPartCollection : AutosplitDataClass
	{
		private bool[] bodyParts;

		/// <summary>
		/// Constructs the class.
		/// </summary>
		public BodyPartCollection(EndIsNighMemory memory) : base(memory)
		{
			bodyParts = new bool[3];
		}

		/// <summary>
		/// Resets the collection.
		/// </summary>
		public override void Reset()
		{
			for (int i = 0; i < bodyParts.Length; i++)
			{
				bodyParts[i] = false;
			}
		}

		/// <summary>
		/// Checks whether the given body part has been collected. Body part collection triggers immediately when you touch the body prt.
		/// </summary>
		public override bool QueryData(object data)
		{
			int index = (int)data;

			if (!bodyParts[index] && Memory.CheckBodyPart((BodyParts)index))
			{
				bodyParts[index] = true;

				return true;
			}

			return false;
		}
	}
}
