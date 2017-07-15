using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSplit.TheEndIsNigh.Data
{
	public class MapGrid
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
		public MapGrid()
		{
			visited = new bool[GridWidth, GridHeight];
		}

		/// <summary>
		/// Updates the grid with the given player location.
		/// </summary>
		public void Update(Point location)
		{
			int x = location.X;
			int y = location.Y;

			if (!visited[x, y])
			{
				visited[x, y] = true;
			}
		}
	}
}
