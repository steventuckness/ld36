using UnityEngine;
using System.Collections;

public class EventReceiverUtils {

	public static void FireEvents(MonoBehaviour source, MonoBehaviour[] listeners) {
		foreach (MonoBehaviour listener in listeners) {
			if (listener is EventReceiver) {
				(listener as EventReceiver).ReceiveEvent (source);
			}
		}
	}

}
