using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioHolder : MonoBehaviour
{
    public static AudioSource staticSource;

    private void Start()
    {
        staticSource = gameObject.GetComponent<AudioSource>();
    }
}
