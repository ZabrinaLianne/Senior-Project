using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventInvoke : MonoBehaviour
{
    public GameEvent[] Events;
   
    public void Raise(int index)
    {
        Events[index].Raise();
    }

   
}
