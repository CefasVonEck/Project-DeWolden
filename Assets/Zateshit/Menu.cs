using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject menuScreen;
    public bool showMenu = false;
    public bool menuKey = Input.GetKeyDown(KeyCode.M);

    public void EnableMenu()
    {
        if (menuKey==true && showMenu == false)
        {
            showMenu = true;
            menuScreen.SetActive(true);
        }
        else if (menuKey==true && showMenu == true)
        {
            showMenu = false;
            menuScreen.SetActive(false);
        }

    }

    void Update()
    {
        menuKey = Input.GetKeyDown(KeyCode.M);
        EnableMenu();

    }
    void Start()
    {
        menuKey = Input.GetKeyDown(KeyCode.M);
        menuScreen.SetActive(false);

    }

}
