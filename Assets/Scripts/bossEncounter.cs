using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bossEncounter : MonoBehaviour
{
    public GameObject oldAudio;
    public AudioSource musicObjectlvl2; //David added this

    // Start is called before the first frame update
    void Start()
    {
        //i cant figure out how to get the level1 music playing again when the encounter is over - tony
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (doomed == true)
        {
            Debug.Log("Labrobro");           //David removed this
            Destroy(this.gameObject);
        }*/
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Time.timeScale = 0;
            Application.LoadLevelAdditive("BossBattleScene");
            //oldAudio.gameObject.SetActive(false); //david removed this
            musicObjectlvl2.Pause(); //david added this
            gameObject.SetActive(false); // David added this
        }
    }
}