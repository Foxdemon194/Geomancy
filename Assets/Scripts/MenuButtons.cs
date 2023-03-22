using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void LoadSettings()
    {
        SceneManager.LoadScene("SettingsScene");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void LoadCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void LoadPrologue()
    {
        SceneManager.LoadScene("Prologue");
    }

    public void OpenSurvey()
    {
        Application.OpenURL("https://forms.gle/BpUdaeUdTYheBjya8");
    }
}