using UnityEngine;
using UnityEngine.Events;

public class EventListener : MonoBehaviour
{
    public GameEvent[] Event;
    public UnityEvent Response;

    void OnEnable()
    {
        foreach(GameEvent ev in Event)
        {
            ev.Register(this);
        }
      
    }
    void OnDisable()
    {
        foreach (GameEvent ev in Event)
        {
            ev.DeRegister(this);
        }
    }
    public void OnEventRaised()
    {
        Response.Invoke();
    }
}
