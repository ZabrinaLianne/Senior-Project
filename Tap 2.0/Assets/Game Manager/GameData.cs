using UnityEngine;

[CreateAssetMenu]
public class GameData : ScriptableObject
{

    public int CurrentLevel;
   
    public int DotsRemaining;
    public int Score;
    public bool IsRunning = false;

    public void ResetLevel()
    {
        IsRunning = false;
        //method to reset dots remaining to the current level
        DotsRemaining = CurrentLevel;
    }

    public void ResetData()
    {
        CurrentLevel = 1;
        DotsRemaining = CurrentLevel;
    }
    
}
