using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelTextUI : MonoBehaviour
{
    public GameData GameData;
    TMPro.TextMeshPro _text;

   
    void Start()
    {
        _text = GetComponent<TMPro.TextMeshPro>();
        _text.text = "Level: " + GameData.CurrentLevel.ToString();
        
    }

  
    void Update()
    {
        _text.text = "Level: " + GameData.CurrentLevel.ToString();
    }
}
