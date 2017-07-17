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
	/// Data class used to track the player's location within the world grid. The map grid is unique in that it can trigger multiple kinds
	/// of splits (zone and start).
	/// </summary>
	public class MapGrid : AutosplitDataClass
	{
		// These values are taken from the CSV file in Resources (map.csv).
		private const int GridWidth = 100;
		private const int GridHeight = 61;

		// Even though much of the map grid is empty (i.e. there's not a level in every cell), it still seemed simpler to just use a 2D
		// boolean grid to track visited levels.
		private bool[,] visited;

		/// <summary>
		/// Constructs the class.
		/// </summary>
		public MapGrid(EndIsNighMemory memory) : base(memory)
		{
			visited = new bool[GridWidth, GridHeight];
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
		/// Checks whether the game is starting (i.e. a new file was just selected).
		/// </summary>
		public bool QueryStart()
		{
			// The visited array is intentionally not updated here (because, when starting a new game, the player doesn't actually visit
			// the (0, 37) cell. (0, 37) also happens to be the first level of The End Is Nigh, so marking it visited would cause the
			// cartridge zone to not trigger when running categories that visit that cart.
			return Memory.GetWorldLocation() == new Point(0, 37);
		}
		
		/// <summary>
		/// Checks whether the given zone (i.e. map cell) has been reached. Only returns true the first time the zone is entered.
		/// </summary>
		public override bool QueryData(object data)
		{
			Point targetLocation = (Point)data;
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
