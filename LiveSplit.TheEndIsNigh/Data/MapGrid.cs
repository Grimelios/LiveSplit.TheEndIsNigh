using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveSplit.TheEndIsNigh.Events;
using LiveSplit.TheEndIsNigh.Memory;

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

		private bool gameStarted;

		private EndIsNighMemory memory;

		/// <summary>
		/// Constructs the class.
		/// </summary>
		public MapGrid(EndIsNighMemory memory)
		{
			this.memory = memory;

			visited = new bool[GridWidth, GridHeight];
		}

		/// <summary>
		/// Resets the map grid.
		/// </summary>
		public void Reset()
		{
			for (int i = 0; i < GridHeight; i++)
			{
				for (int j = 0; j < GridWidth; j++)
				{
					visited[j, i] = false;
				}
			}

			gameStarted = false;
		}

		/// <summary>
		/// Updates the grid. Triggers zone events when a new zone is reached for the first time. The map grid also triggers the Start
		/// event when a new file is selected.
		/// </summary>
		public void Update()
		{
			Point location = memory.GetWorldLocation();

			int x = location.X;
			int y = location.Y;

			if (!visited[x, y])
			{
				visited[x, y] = true;

				if (location == new Point(0, 37) && !gameStarted)
				{
					Console.WriteLine("Game started.");

					gameStarted = true;

					return;
				}

				Console.WriteLine($"Zone reached ({location.X}, {location.Y}).");

				//EventSystem.Send(EventTypes.ZoneReached, location);
			}
		}
	}
}
