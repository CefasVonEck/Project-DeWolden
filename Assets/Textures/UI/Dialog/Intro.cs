using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Intro : MonoBehaviour
{
    [SerializeField]
    private GameObject[] popupText = new GameObject[5];

    private int timer = 0;

    [SerializeField]
    private int speedUp = 1;

    void Start()
    {
        if (popupText[0] != null) 
        { 
            popupText[0].active = false; 
        }

        if (popupText.Length > 1 && popupText[1] != null && popupText[1].activeSelf) 
        { 
            popupText[1].active = false; 
        }
        
        if (popupText.Length > 2 && popupText[2] != null && popupText[2].activeSelf) 
        { 
            popupText[2].active = false; 
        }

        if (popupText.Length > 3 && popupText[3] != null && popupText[3].activeSelf) 
        { 
            popupText[3].active = false; 
        }

        if (popupText.Length > 4 && popupText[4] != null && popupText[4].activeSelf)
        {
            popupText[4].active = false;
        }
        //if (popupText[4] != null) { popupText[4].active = false; }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (timer < 1500)
        {
            ++timer;
            if (timer == 250 / speedUp)
            {
                popupText[0].active = true;
            }
            else if (timer == 450 / speedUp)
            {
                popupText[0].active = false;
            }
            else if (timer == 501 / speedUp)
            {
                popupText[1].active = true;
            }
            else if (timer == 750 / speedUp)
            {
                popupText[1].active = false;
            }
            else if (popupText.Length > 2 && timer == 901 / speedUp)
            {
                popupText[2].active = true;
            }
            else if (popupText.Length > 2 && timer == 1150 / speedUp)
            {
                popupText[2].active = false;
            }
            else if (popupText.Length > 3 && timer == 1300 / speedUp)
            {
                popupText[3].active = true;
            }
            else if (popupText.Length > 3 && timer == 1650 / speedUp)
            {
                popupText[3].active = false;
            }
            else if (popupText.Length > 4 && timer == 1900 / speedUp)
            {
                popupText[4].active = true;
            }
            else if (popupText.Length > 4 && timer == 2350 / speedUp)
            {
                popupText[4].active = false;
            }

            if (popupText.Length == 0 && timer == 1499)
            {
                timer = 500;
            }

            if (popupText.Length == 4 && timer == 2000 / speedUp)
            {
                timer = 0;
            }
        }
    }
}
