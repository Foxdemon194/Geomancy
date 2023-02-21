using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volumeControl : MonoBehaviour
{
    void Start()
    {
        GetComponent<AudioSource>().volume = 0.2f;
    }
}
