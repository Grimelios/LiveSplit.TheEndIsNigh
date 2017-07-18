using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveSplit.TheEndIsNigh.Memory;

namespace LiveSplit.TheEndIsNigh.Data
{
	/// <summary>
	/// Data class used to track the player's location within the world grid.
	/// </summary>
	public class MapGrid : AutosplitDataClass
	{
		// These values are taken from the CSV file in Resources (map.csv).
		private const int GridWidth = 100;
		private const int GridHeight = 61;

		// Even though much of the map grid is empty (i.e. there's not a level in every cell), it still seemed simpler to just use a 2D
		// boolean grid to track visited levels.
		private bool[,] visited;

		private Point[] zoneMap;

		/// <summary>
		/// Constructs the class.
		/// </summary>
		public MapGrid(EndIsNighMemory memory) : base(memory)
		{
			visited = new bool[GridWidth, GridHeight];

			zoneMap = new []
			{
				new Point(0, 17),
				new Point(20, 17),
				new Point(40, 17),
				new Point(61, 17),
				new Point(61, 16),
				new Point(69, 10),
				new Point(62, 17),
				new Point(77, 17),
				new Point(61, 18),
				new Point(71, 23),
				new Point(0, 26),
				new Point(20, 26),
				new Point(40, 26),
				new Point(60, 30),
				new Point(40, 31),
			};
		}

		/// <summary>
		/// Resets the map grid.
		/// </summary>
		public override void Reset()
		{
			for (int i = 0; i < GridHeight; i++)
			{
				for (int j = 0; j < GridWidth; j++)
				{
					visited[j, i] = false;
				}
			}
		}
		
		/// <summary>
		/// Checks whether the given zone (i.e. map cell) has been reached. Only returns true the first time the zone is entered.
		/// </summary>
		public override bool QueryData(object data)
		{
			Point targetLocation = zoneMap[(int)data];
			Point location = Memory.GetWorldLocation();

			int x = location.X;
			int y = location.Y;

			if (!visited[x, y])
			{
				visited[x, y] = true;

				if (location == targetLocation)
				{
					return true;
				}
			}

			return false;
		}
	}
}
