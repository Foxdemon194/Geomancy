
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class battleButtons : MonoBehaviour
{
    //HealthManager healthManager;
    public GameObject battleSceneHolder;
    //public bool holderDestroyed = false;
    //public bool musicOn = false;

    private string capital;

    // Start is called before the first frame update
    void Start() 
    {
        capital = GetComponent<Encounter>().capital;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void endBattle()
    {
        Destroy(battleSceneHolder.gameObject);
        afterBattle();
        AudioHolder.staticSource.UnPause();//david added this
    }

    public void afterBattle()
    {
        Time.timeScale = 1;
    }

    private void OnDestroy()
    {

    }

    public void Wrong()
    {
        HealthManager.health--;    
    }

    public void BossWrong()
    {
        HealthManager.health--;
        HealthManager.health--;
    }

    public void endBattleBoss()
    {
        Destroy(battleSceneHolder.gameObject);
        SceneManager.LoadScene("Epilogue");
    }
}
