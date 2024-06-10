using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour
{
    public GameObject credpag;

    public GameObject Regpage;

    private void Start()
    {
        credpag.SetActive(false);
        Regpage.SetActive(true);
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("MainGame");
    }
    public void QuitGame()
    {
        Application.Quit();
    }

    public void Credits()
    {
        credpag.SetActive(true);
        Regpage.SetActive(false);
    }
    public void ManMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void OpenLink()
    {
        Application.OpenURL("https://www.bindbibliotheken.nl/vestigingen/zuidwolde.html");
    }

    public void BackPage()
    {
        credpag.SetActive(false);
        Regpage.SetActive(true);

    }
}
