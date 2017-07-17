using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSplit.TheEndIsNigh.Events
{
	/// <summary>
	/// Enumeration storing all game events that can be used to trigger splits.
	/// </summary>
	public enum EventTypes
	{
		BodyPartCollected,
		CartridgeCollected,
		TumorCollected,
		WorldEventTriggered,
		ZoneReached
	}

	/// <summary>
	/// Static class used to distribute event data as game events occur.
	/// </summary>
	public static class EventSystem
	{
		private static List<IEventListener>[] listeners;

		/// <summary>
		/// Static initializer for the class.
		/// </summary>
		static EventSystem()
		{
			listeners = new List<IEventListener>[Enum.GetValues(typeof(EventTypes)).Length];
		}

		/// <summary>
		/// Subscribes the given listener to the given event type.
		/// </summary>
		public static void Subscribe(EventTypes eventType, IEventListener listener)
		{
			VerifyList(eventType).Add(listener);
		}

		/// <summary>
		/// Sends a message with the given event type and data.
		/// </summary>
		public static void Send(EventTypes eventType, object data)
		{
			listeners[(int)eventType].ForEach(l => l.OnEvent(eventType, data));
		}

		/// <summary>
		/// Verifies whether a receiver list exists for the given event type and, if it doesn't, creates one. The receiver list is
		/// returned.
		/// </summary>
		private static List<IEventListener> VerifyList(EventTypes eventType)
		{
			int index = (int)eventType;

			return listeners[index] ?? (listeners[index] = new List<IEventListener>());
		}
	}
}
