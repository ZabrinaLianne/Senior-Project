using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotSpawner : MonoBehaviour
{
   

    public Motor Bar;
    public GameObject dotPrefab;

    GameObject _activeDot;
    Transform _anchor;
    Vector3 _initialPos;

    void Start()
    {
        _anchor = GameObject.FindGameObjectWithTag("Anchor").transform;
        _initialPos = GetComponent<Transform>().localPosition;
        Spawn();
    }


    public void Spawn()
    {
        if (_activeDot)
        {
            Destroy(_activeDot.gameObject);
        }
            var angle = Random.Range(20, 120);
            _activeDot = Instantiate(dotPrefab, Bar.transform.position, Quaternion.identity, transform);
            _activeDot.transform.RotateAround(_anchor.position, Vector3.forward, -angle * (int)Bar.Direction);

        
        

    }

    
}
