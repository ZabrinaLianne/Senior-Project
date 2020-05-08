using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]

public class GameEvent : ScriptableObject
{

    List<EventListener> _eventListeners = new List<EventListener>();

    public void Raise()
    {
        for (int t=0; t <_eventListeners.Count; t++)
        {
            _eventListeners[t].OnEventRaised();
          
        }
    }

    public void Register(EventListener listener)
    {
        if (!_eventListeners.Contains(listener))
        {
            _eventListeners.Add(listener);
        }
    }
   
    public void DeRegister(EventListener listener)
    {
        if (_eventListeners.Contains(listener))
        {
            _eventListeners.Remove(listener);
        }
    }
}
