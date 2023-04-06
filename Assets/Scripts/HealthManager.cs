using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    [SerializeField] int health;
    public GameObject heartContainer1;
    public GameObject heartContainer2;
    public GameObject heartContainer3;

    public GameObject gameOverPanel;

    private void Start()
    {
        health = 3;
    }

    void Update()
    {
        if (health == 3)
        {
            heartContainer1.SetActive(true);
            heartContainer2.SetActive(true);
            heartContainer3.SetActive(true);
        }
        else if (health == 2)
        {
            heartContainer1.SetActive(true);
            heartContainer2.SetActive(true);
            heartContainer3.SetActive(false);
        }
        else if (health == 1)
        {
            heartContainer1.SetActive(true);
            heartContainer2.SetActive(false);
            heartContainer3.SetActive(false);
        }
        else if (health <= 0)
        {
            heartContainer1.SetActive(false);
            heartContainer2.SetActive(false);
            heartContainer3.SetActive(false);
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
    // To call this method you will need to declare HealthManager healthManager
    //then just call it by typing this
    // healthManager.WrongAnswer();
    public void WrongAnswer()
    {
        health -= 1;
    }
}
