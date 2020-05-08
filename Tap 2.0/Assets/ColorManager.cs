using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    Camera _cam;
    public Color LoseColor;
    public Color StartColor;
    // Start is called before the first frame update
    void Start()
    {
        _cam = GetComponent<Camera>();
        _cam.backgroundColor = StartColor;
    }

  public void ChangeToLoseColor()
    {
        _cam.backgroundColor = LoseColor;
    }


    public void ChangeToStartColor()
    {
        _cam.backgroundColor = StartColor;
    }

}
