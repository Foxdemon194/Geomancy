using UnityEngine;
using System.Collections;

public class SoundContinue : MonoBehaviour
{

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        if (objs.Length > 1)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);

        GetComponent<AudioSource>().volume = 0.4f;
    }
}
