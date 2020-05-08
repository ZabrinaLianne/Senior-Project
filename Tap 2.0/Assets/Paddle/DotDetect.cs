using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotDetect : MonoBehaviour
{
    public GameData GameData;
    GameObject _currentDot;

    GameObject _lastEnterDot;
    public float Threshold = .5f;
    public GameEvent DotMissedEvent;
    public GameEvent DotScoredEvent;

    void OnTriggerEnter2D(Collider2D other)
    {
        _currentDot = other.gameObject;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        _lastEnterDot = _currentDot;
        _currentDot = null;
    }
    void Update()
    {
        if (GameData.IsRunning)
        {

            if (_lastEnterDot && DistanceFromLastDot()>Threshold)
            {
                DotMissedEvent.Raise();
            }


            if (_didTap)
            {

                if (_currentDot != null)
                {
                    GameData.Score+=10;
                    Destroy(_currentDot);
                    DotScoredEvent.Raise();

                }
                else
                {
                    GameData.Score -= 5;
                    DotMissedEvent.Raise();
                }
            }
        }
    }

    float DistanceFromLastDot()
    {
        return (transform.position - _lastEnterDot.transform.position).magnitude;
    }
    bool _didTap
    {
        get
        {
            return Input.GetMouseButtonDown(0);
        }
    }
}
