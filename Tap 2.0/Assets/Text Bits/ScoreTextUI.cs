using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTextUI : MonoBehaviour
{
    public GameData GameData;
    TMPro.TextMeshPro _text;
    
    void Start()
    {
        _text = GetComponent<TMPro.TextMeshPro>();
        _text.text = "Score: " + GameData.Score.ToString();

    }

    
    void Update()
    {
        _text.text = "Score: " + GameData.Score.ToString();
    }
}
