using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveSplit.TheEndIsNigh.Memory;

namespace LiveSplit.TheEndIsNigh.Data
{
	/// <summary>
	/// Represents a collection of body parts. Used to track when the player picks up a body part.
	/// </summary>
	public class BodyPartCollection
	{
		private bool[] bodyParts;

		private EndIsNighMemory memory;

		/// <summary>
		/// Constructs the class.
		/// </summary>
		public BodyPartCollection(EndIsNighMemory memory)
		{
			this.memory = memory;

			bodyParts = new bool[3];
		}

		/// <summary>
		/// Resets the collection.
		/// </summary>
		public void Reset()
		{
			bodyParts.Reset();
		}

		/// <summary>
		/// Updates the collection. Triggers body events when a new body part is collected.
		/// </summary>
		public void Update()
		{
			for (int i = 0; i < bodyParts.Length; i++)
			{
				if (!bodyParts[i] && memory.CheckBodyPart((BodyParts)i))
				{
					bodyParts[i] = true;

					Console.WriteLine($"{(BodyParts)i} collected.");
				}
			}
		}
	}
}
