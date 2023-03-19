using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class battleButtons : MonoBehaviour
{
    public GameObject battleSceneHolder;
    public bool holderDestroyed = false;
    public bool musicOn = false;

    private string capital;

    // Start is called before the first frame update
    void Start() 
    {
        capital = GetComponent<Encounter>().capital;
    }

    // Update is called once per frame
    void Update()
    {
        //if ()
    }

    public void endBattle()
    {
        AudioHolder.staticSource.UnPause();//david added this
        Destroy(battleSceneHolder.gameObject);
        holderDestroyed = true;
        afterBattle();
    }

    public void afterBattle()
    {
        Time.timeScale = 1;
        holderDestroyed = true;
    }

    private void OnDestroy()
    {
        //GetComponent<enemyEncounter>().doomed = true; //david removed this
    }
}
