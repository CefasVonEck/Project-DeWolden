using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    [SerializeField]
    private GameObject[] popupText = new GameObject[5];

    private int timer = 0;

    void Start()
    {
        if (popupText[0] != null) { popupText[0].active = false; }
        if (popupText[1] != null) { popupText[1].active = false; }
        //if (popupText[2] != null) { popupText[2].active = false; }
        //if (popupText[3] != null) { popupText[3].active = false; }
        //if (popupText[4] != null) { popupText[4].active = false; }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ++timer;
        if(timer == 250)
        {
            popupText[0].active = true;
        }
        else if (timer == 450)
        {
            popupText[0].active = false;
        }
        else if (timer == 500)
        {
            popupText[1].active = true;
        }
        else if (timer == 750)
        {
            popupText[1].active = false;
        }
    }
}
