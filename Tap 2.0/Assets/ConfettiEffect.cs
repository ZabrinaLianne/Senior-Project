using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConfettiEffect : MonoBehaviour
{
    public GameObject confettiPrefab;
  public void confettiBurst()
    {
        GameObject ob = Instantiate(confettiPrefab);
    }
}
