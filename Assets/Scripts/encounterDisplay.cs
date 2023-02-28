using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class encounterDisplay : MonoBehaviour
{
    public Encounter encounter;

    public Text nameText;

    public GameObject enemysprite;

    public Button option1;
    public Button option2;
    public Button option3;
    public Button option4;
    // Start is called before the first frame update
    void Start()
    {
        nameText.text = encounter.name + "!";
        enemysprite.GetComponentInChildren<SpriteRenderer>().sprite = encounter.enemySprite;
        option1.GetComponentInChildren<Text>().text = encounter.cityName1;
        option2.GetComponentInChildren<Text>().text = encounter.cityName2;
        option3.GetComponentInChildren<Text>().text = encounter.cityName3;
        option4.GetComponentInChildren<Text>().text = encounter.cityName4;
    }
}
