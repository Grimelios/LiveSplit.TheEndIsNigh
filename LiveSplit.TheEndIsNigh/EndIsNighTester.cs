using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveSplit.TheEndIsNigh.Controls;
using LiveSplit.TheEndIsNigh.Data;
using LiveSplit.TheEndIsNigh.Memory;

namespace LiveSplit.TheEndIsNigh
{
	/// <summary>
	/// Static class used to test the autosplitter using the console.
	/// </summary>
	public static class EndIsNighTester
	{
		/// <summary>
		/// Main function for the testing program.
		/// </summary>
		public static void Main(string[] args)
		{
			EndIsNighComponent component = new EndIsNighComponent();

			while (true)
			{
				component.Autosplit();

				Thread.Sleep(100);
			}

			//Application.Run(new TestingForm());
		}
	}
}
