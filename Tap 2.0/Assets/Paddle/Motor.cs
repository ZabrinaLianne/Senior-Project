using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Motor : MonoBehaviour


{
    public GameData GameData;
    public int Speed = 5;
    public Direction Direction = Direction.clockwise;
    Transform _anchor;

    public int MaxSpeed = 100;
    public int MinSpeed = 40
        ;
    Vector3 _initialPos;//RESET CRAP
    // Start is called before the first frame update
    void Start()
    {
        _anchor = GameObject.FindGameObjectWithTag("Anchor").transform;
        _initialPos = GetComponent<Transform>().localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        if (GameData.IsRunning)
        {
            transform.RotateAround(_anchor.position, Vector3.forward, Speed * Time.deltaTime * (int)Direction);
        }


        if (_didTap && GameData.IsRunning)
        {
           
            ChangeDirection();
        }
    }

    bool _didTap
    {
        get
        {
            return Input.GetMouseButtonDown(0);
        }
    }

    void ChangeDirection()
    {
        switch (Direction)
        {
            case Direction.clockwise:
                Direction = Direction.counterclockwise;
                break;
            case Direction.counterclockwise:
                Direction = Direction.clockwise;
                break;


        }
    }
    //RESET CRAP
    public void ResetPosition()
    {
        transform.localPosition = new Vector3( _initialPos.x, _initialPos.y, _initialPos.z);
        transform.localRotation = Quaternion.identity;
        GameData.IsRunning = false;
    }

    //Increasing/decreasing speed throughout the game

    public void IncreaseSpeed(int value) //As level increases the bar moves faster to add difficulty, but is lmited so that speed doesn't oncrease infinitely
    {
        if (value > 0)
        {
            Speed = Mathf.Min(Speed + value, MaxSpeed);
        }
    }

    public void DecreaseSpeed(int value) //If a player misses a dot the bar slows very slightly to help them out
    {
        if (value > 0)
        {
            Speed = Mathf.Max(Speed - value, MinSpeed);
        }
    }
    
   
}

public enum Direction {

    clockwise=-1,
    counterclockwise= 1
}
