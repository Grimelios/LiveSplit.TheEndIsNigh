using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveSplit.TheEndIsNigh.Controls;

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
			Application.Run(new TestingForm());
		}
	}
}
