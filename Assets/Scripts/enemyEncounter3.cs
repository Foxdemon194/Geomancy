using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class enemyEncounter3 : MonoBehaviour
{
    public GameObject oldAudio;

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
            Application.LoadLevelAdditive("BattleScene3");
            oldAudio.gameObject.SetActive(false);
        }
    }
}
