using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName = "Enemy")]
public class Encounter : ScriptableObject
{
    public string enemyName;

    public Sprite enemySprite;

    public string cityName1;
    public string cityName2;
    public string cityName3;
    public string cityName4;

    public string capital;

    public int damage = 1;
    public int health = 1;
}
