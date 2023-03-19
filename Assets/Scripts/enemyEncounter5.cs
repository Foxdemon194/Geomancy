using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyEncounter5 : MonoBehaviour
{
    public GameObject oldAudio;
    public AudioSource musicObject; //david added this


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Time.timeScale = 0;
            Application.LoadLevelAdditive("BattleScene5");
            //oldAudio.gameObject.SetActive(false);//david removed this
            musicObject.Pause(); //david added this
            gameObject.SetActive(false); // David added this

        }
    }
}
