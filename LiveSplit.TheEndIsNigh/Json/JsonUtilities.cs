using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LiveSplit.TheEndIsNigh.Json
{
	/// <summary>
	/// Static class used to serialize and deserialize Json files.
	/// </summary>
	public static class JsonUtilities
	{
		/// <summary>
		/// Static initializer for the class.
		/// </summary>
		static JsonUtilities()
		{
			JsonConvert.DefaultSettings = () => new JsonSerializerSettings
			{
				Formatting = Formatting.Indented,
				TypeNameHandling = TypeNameHandling.Auto
			};
		}

		/// <summary>
		/// Serializes the given data to the given Json file.
		/// </summary>
		public static void Serialize(object data, string filename)
		{
			StreamWriter writer = new StreamWriter(File.Create("Json/" + filename));
			writer.Write(JsonConvert.SerializeObject(data));
			writer.Close();
		}

		/// <summary>
		/// Deserializes an object of the given type from the given Json file.
		/// </summary>
		public static T Deserialize<T>(string filename)
		{
			return JsonConvert.DeserializeObject<T>(File.ReadAllText("Json/" + filename));
		}
	}
}
