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
		private bool withinTargetFutureZone;

		private Point[] futureMap;
		private Point[] zoneMap;

		/// <summary>
		/// Constructs the class.
		/// </summary>
		public MapGrid(EndIsNighMemory memory) : base(memory)
		{
			visited = new bool[GridWidth, GridHeight];

			futureMap = new []
			{
				new Point(11, 28),
				new Point(11, 35),
				new Point(12, 30),
				new Point(11, 32),   
			};

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
		/// Checks whether the given future zone (by index) has been completed.
		/// </summary>
		public bool QueryFuture(object data)
		{
			Point targetLocation = futureMap[(int)data];
			Point location = Memory.GetWorldLocation();

			if (!withinTargetFutureZone)
			{
				if (location == targetLocation)
				{
					withinTargetFutureZone = true;
				}
			}
			// This means you reached the target future zone and then moved or teleported to another screen.
			else if (location != targetLocation)
			{
				withinTargetFutureZone = false;

				// Using Manhattan distance ensures you don't split when you enter the last room of a future section and then just walk
				// back into the previous room.
				if (ComputeManhattanDistance(location, targetLocation) > 1)
				{
					return true;
				}
			}

			return false;
		}

		/// <summary>
		/// Computes the Manhattan distance betweeen the two given points.
		/// </summary>
		private int ComputeManhattanDistance(Point point1, Point point2)
		{
			int dX = Math.Abs(point1.X - point2.X);
			int dY = Math.Abs(point1.Y - point2.Y);

			return dX + dY;
		}

		/// <summary>
		/// Checks whether the given zone (i.e. map cell) has been reached. Only returns true the first time the zone is entered.
		/// </summary>
		public override bool QueryData(object data)
		{
			Point targetLocation = data is Zones ? zoneMap[(int)data] : (Point)data;
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
