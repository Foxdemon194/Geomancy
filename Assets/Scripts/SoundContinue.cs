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

    private void Update()
    {
        if (SceneManager.GetActiveScene().name == "Level1")
        {
            GetComponent<AudioSource>().volume = 0f;
            currentLevelMusic.volume = 0.4f;
        }
        if (SceneManager.GetActiveScene().name == "Level2")
        {
            Destroy(this.gameObject);
        }
    }
}
