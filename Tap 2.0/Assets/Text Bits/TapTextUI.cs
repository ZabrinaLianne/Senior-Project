using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapTextUI : MonoBehaviour
{
    public GameData GameData;
    

    // to make the tap text go away when it's not level 1
    void Update()
    {
        if(GameData.CurrentLevel != 1)
        {
            gameObject.SetActive(false);
        }
    }

   
}
