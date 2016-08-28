using UnityEngine;
using System.Collections;

public interface EventReceiver {
	void ReceiveEvent (MonoBehaviour source);
}