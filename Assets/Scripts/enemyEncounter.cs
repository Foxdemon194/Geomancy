using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyEncounter : MonoBehaviour
{
    public GameObject oldAudio;
    public bool doomed;

    // Start is called before the first frame update
    void Start()
    {
        doomed = false;
        //i cant figure out how to get the level1 music playing again when the encounter is over - tony
    }

    // Update is called once per frame
    void Update()
    {
        if (doomed == true)
        {
            Debug.Log("Labrobro");
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Time.timeScale = 0;
            Application.LoadLevelAdditive("BattleScene");
            oldAudio.gameObject.SetActive(false);
        }
    }
}
