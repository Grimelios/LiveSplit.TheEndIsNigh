using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using LiveSplit.TheEndIsNigh.Data;

namespace LiveSplit.TheEndIsNigh
{
	/// <summary>
	/// Helper class used to save and load settings in LiveSplit.
	/// </summary>
	public class EndIsNighSettings
	{
		private SplitCollection splitCollection;

		/// <summary>
		/// Constructs the class.
		/// </summary>
		public EndIsNighSettings(SplitCollection splitCollection)
		{
			this.splitCollection = splitCollection;
		}

		/// <summary>
		/// Saves settings in the given XML document.
		/// </summary>
		public void SaveSettings(XmlDocument document)
		{
		}
	}
}
