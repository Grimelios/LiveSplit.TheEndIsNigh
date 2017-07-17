using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveSplit.TheEndIsNigh.Data;

namespace LiveSplit.TheEndIsNigh.Events
{
	/// <summary>
	/// Interface describing any class that can listen for game events.
	/// </summary>
	public interface IEventListener
	{
		/// <summary>
		/// Called when a game event occurs.
		/// </summary>
		void OnEvent(EventTypes eventType, object data);
	}
}
