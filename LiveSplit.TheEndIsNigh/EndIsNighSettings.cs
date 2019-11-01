using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using LiveSplit.TheEndIsNigh.Controls;
using LiveSplit.TheEndIsNigh.Data;

namespace LiveSplit.TheEndIsNigh
{
	/// <summary>
	/// Helper class used to save and load settings in LiveSplit.
	/// </summary>
	public class EndIsNighSettings
	{
		private SettingsControl settingsControl;
		private SplitCollection splitCollection;
		private SplitCollectionControl collectionControl;

		/// <summary>
		/// Constructs the class. This constructor is useful for saving settings.
		/// </summary>
		public EndIsNighSettings(SplitCollection splitCollection, SplitCollectionControl collectionControl,
			SettingsControl settingsControl)
		{
			this.settingsControl = settingsControl;
			this.splitCollection = splitCollection;
			this.collectionControl = collectionControl;

			settingsControl.Settings = this;
		}

		/// <summary>
		/// Whether the component should display death count.
		/// </summary>
		public bool DisplayEnabled { get; set; }

		/// <summary>
		/// If set, game time is set to exactly match the time shown on the file select screen (i.e. using pure in-game
		/// time). File time excludes cutscenes and menus.
		/// </summary>
		public bool MatchFileTime { get; set; }

		/// <summary>
		/// Loads settings from the given XML node.
		/// </summary>
		public void LoadSettings(XmlNode node)
		{
			XmlElement splitsElement = node["Splits"];
			XmlNodeList splitNodes = splitsElement.GetElementsByTagName("Split");

			Split[] splits = new Split[splitNodes.Count];

			for (int i = 0; i < splitNodes.Count; i++)
			{
				XmlNode splitElement = splitNodes[i];

				SplitTypes type = (SplitTypes)Enum.Parse(typeof(SplitTypes), splitElement.Attributes[0].InnerText);

				string data = splitElement.Attributes[1].InnerText;

				splits[i] = new Split(type, data);
			}

			DisplayEnabled = bool.Parse(node["DisplayEnabled"].InnerText);

			var matchElement = node["MatchFileTime"];

			// This null check protects again versioning differences (since the option to match file time was added
			// roughly two years after the original autosplitter release).
			if (matchElement != null)
			{
				MatchFileTime = bool.Parse(matchElement.InnerText);
			}
			
			settingsControl.DeathCheckbox = DisplayEnabled;
			settingsControl.FileTimeCheckbox = MatchFileTime;

			// Setting splits on the collection control also updates the split collection.
			collectionControl.SetSplits(splits);
		}

		/// <summary>
		/// Saves settings in an XML node.
		/// </summary>
		public XmlNode SaveSettings(XmlDocument document)
		{
			XmlElement settingsElement = document.CreateElement("Settings");
			XmlElement splitsElement = document.CreateElement("Splits");

			foreach (Split split in splitCollection.Splits)
			{
				SplitTypes type = split.Type;

				string data;

				if (type == SplitTypes.Level)
				{
					Point point = (Point)split.Data;

					data = point.X + "," + point.Y;
				}
				else
				{
					data = split.Data.ToString();
				}

				XmlAttribute splitType = document.CreateAttribute("Type");
				splitType.InnerText = type.ToString();

				XmlAttribute splitData = document.CreateAttribute("Data");
				splitData.InnerText = data;

				XmlElement splitElement = document.CreateElement("Split");
				splitElement.Attributes.Append(splitType);
				splitElement.Attributes.Append(splitData);

				splitsElement.AppendChild(splitElement);
			}

			XmlElement displayElement = document.CreateElement("DisplayEnabled");
			displayElement.InnerText = DisplayEnabled.ToString();

			XmlElement fileTimeElement = document.CreateElement("MatchFileTime");
			fileTimeElement.InnerText = MatchFileTime.ToString();

			settingsElement.AppendChild(displayElement);
			settingsElement.AppendChild(fileTimeElement);
			settingsElement.AppendChild(splitsElement);

			return settingsElement;
		}
	}
}
