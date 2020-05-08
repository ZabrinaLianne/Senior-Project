using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameData GameData;
    public GameEvent OnWinEvent;
    bool _isFirstTap = true; 

    void Start()
    {
        GameData.ResetLevel();
    }
    void Update()
    {
        if(Input.GetMouseButtonDown(0)&& !GameData.IsRunning &&_isFirstTap)
        {
            GameData.IsRunning = true;
            _isFirstTap = false; 
        }
    }
    
    public void DecrementRemainingDots()
    {
        GameData.DotsRemaining--;

        if (GameData.DotsRemaining<=0) //preventing negative numbers
        {
            GameData.DotsRemaining = 0;
            OnWinEvent.Raise();
        }
    }

    public void LoadLevel(bool next)
    {
        if (next)
        {
            GameData.CurrentLevel++;
        }
        GameData.ResetLevel();
        _isFirstTap = true;
    }

    public void StopGame() //To make the bar stop moving when the level is done
    {
        GameData.IsRunning = false;
    }
}
