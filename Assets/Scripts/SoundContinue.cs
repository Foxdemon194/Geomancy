using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SoundContinue : MonoBehaviour
{

    public AudioSource currentLevelMusic;

    void Awake()
    {
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");
        if (objs.Length > 1)
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);

        GetComponent<AudioSource>().volume = 0.4f;
    }

    void Update()
    {
        if (SceneManager.GetActiveScene().name == "Level1")
        {
            Destroy(this.gameObject);
        }
        else if (SceneManager.GetActiveScene().name == "BattleScene")
        {
            Destroy(this.gameObject);
        }
    }
}
