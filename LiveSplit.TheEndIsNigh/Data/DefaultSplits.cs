using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSplit.TheEndIsNigh.Data
{
	/// <summary>
	/// Data class used to store sets of default splits.
	/// </summary>
	public class DefaultSplits
	{
		/// <summary>
		/// Constructs the class.
		/// </summary>
		public DefaultSplits()
		{
			AnyPercent = new []
			{
				new Split(SplitTypes.Zone, Zones.AridFlats), 
				new Split(SplitTypes.Zone, Zones.Overflow), 
				new Split(SplitTypes.Zone, Zones.TheSplit), 
				new Split(SplitTypes.Zone, Zones.SSExodus), 
				new Split(SplitTypes.BodyPart, BodyParts.Head),
				new Split(SplitTypes.Zone, Zones.TheMachine),
				new Split(SplitTypes.BodyPart, BodyParts.Heart),
				new Split(SplitTypes.Zone, Zones.Golgotha),
				new Split(SplitTypes.BodyPart, BodyParts.Body),
				new Split(SplitTypes.Zone, Zones.Gloom),
				new Split(SplitTypes.Zone, Zones.Blight),
				new Split(SplitTypes.Zone, Zones.Ruin),
				new Split(SplitTypes.WorldEvent, WorldEvents.Escape),
				new Split(SplitTypes.WorldEvent, WorldEvents.End1)
			};

			FriendPercent = new[]
			{
				new Split(SplitTypes.Zone, Zones.AridFlats),
				new Split(SplitTypes.Zone, Zones.Overflow),
				new Split(SplitTypes.Zone, Zones.TheSplit),
				new Split(SplitTypes.Zone, Zones.SSExodus),
				new Split(SplitTypes.BodyPart, BodyParts.Head),
				new Split(SplitTypes.Zone, Zones.TheMachine),
				new Split(SplitTypes.BodyPart, BodyParts.Heart),
				new Split(SplitTypes.Zone, Zones.Golgotha),
				new Split(SplitTypes.WorldEvent, WorldEvents.Friend),
			};
		}

		/// <summary>
		/// Default Any% splits.
		/// </summary>
		public Split[] AnyPercent { get; }

		/// <summary>
		/// Default Friend% splits.
		/// </summary>
		public Split[] FriendPercent { get; }
	}
}
