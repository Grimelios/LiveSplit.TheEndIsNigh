using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveSplit.Model;
using LiveSplit.UI.Components;

namespace LiveSplit.TheEndIsNigh
{
	/// <summary>
	/// Factory class used to construct the End Is Nigh component.
	/// </summary>
	public class EndIsNighFactory : IComponentFactory
	{
		/// <summary>
		/// Component category.
		/// </summary>
		public ComponentCategory Category => ComponentCategory.Control;

		/// <summary>
		/// Component name.
		/// </summary>
		public string ComponentName => "The End Is Nigh Autosplitter v" + Version;

		/// <summary>
		/// Component description.
		/// </summary>
		public string Description => "Autosplitter for The End Is Nigh.";

		/// <summary>
		/// Update name for the component. Equivalent to component name.
		/// </summary>
		public string UpdateName => ComponentName + " " + Version;

		/// <summary>
		/// URL used to update the component.
		/// </summary>
		public string UpdateURL => "https://raw.githubusercontent.com/Grimelios/LiveSplit.TheEndIsNigh/master/";

		/// <summary>
		/// XML update filename.
		/// </summary>
		public string XMLURL => UpdateURL + "Components/LiveSplit.TheEndIsNigh.Updates.xml";

		/// <summary>
		/// Component version.
		/// </summary>
		public Version Version => Version.Parse("1.2.2");

		/// <summary>
		/// Creates the component.
		/// </summary>
		public IComponent Create(LiveSplitState state)
		{
			return new EndIsNighComponent();
		}
	}
}
