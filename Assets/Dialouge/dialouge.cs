using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dialouge : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI dia;

    //current dia
    [SerializeField]
    private int curdia = 1;

    // max dia
    [SerializeField]
    private int maxdia;

    [SerializeField]
    private string text;

    [SerializeField]
    private GameObject txtbox;


    // all dia strings
    [SerializeField]
    private string Dia1 = "Hey";

    [SerializeField]
    private string Dia2 = "Hey";

    [SerializeField]
    private string Dia3 = "by";


    // e button
    [SerializeField]
    private GameObject indi;

    // player transform
    [SerializeField]
    private GameObject Player;

    [SerializeField]
    private bool inrange = false;

    [SerializeField]
    private bool india = false;


    // Start is called before the first frame update
    void Start()
    {
        // look for right gameobjects and disable textbox
        Player = GameObject.FindWithTag("Player");
        indi = GameObject.FindWithTag("interact");
        txtbox = GameObject.FindWithTag("box");
        txtbox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // calculate distance
        float dist = Vector2.Distance(transform.position, Player.transform.position);

        // if the distance is low enough
        if (dist <= 2)
        {
            // player is in talk range
            inrange = true;
        }
        else
        {
            // player is not in talk range
            inrange = false;
        }

        // keep track of the range between npc and player
        InTalkRange();

        // constantly update the text 
        dia.text = text.ToString();

        // if the player is in dialouge
        if(india == true)
        {
            // keep track of dialouge and enable the dialouge
            nexttxt();
            Diatrack();

            // show the textbox
            Showtxt();
        }
        else
        {
            // enable movement
            Player.GetComponent<Player>().enabled = true;

            // disable the textbox
            txtbox.SetActive(false);
        }
    }

    // for when the player is in talk range
    void InTalkRange()
    {
        if (inrange == true)
        {
            // show the indicator
            indi.SetActive(true);

            // if e is pressed
            if (Input.GetKeyDown("e"))
            {
                // the player is in a dialouge
                india = true;
            }
        }
        else
        {
            // disable the E inidicator
            indi.SetActive(false);
        }

    }


    //for showing text
    void Showtxt()
    {
        // enable dialouge/ disable movement
        Player.GetComponent<Player>().enabled = false;
        txtbox.SetActive(true);
    }

    // for going trough the text
    void nexttxt()
    {
        // if space is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // go to next text
            curdia += 1;

            // if there is no next dialouge
            if (curdia > maxdia)
            {
                // finish the text
                fintxt();
            }
        }
    }

    // for the final dialouge
    void fintxt()
    {
        // reset dia
        curdia = 1;

        india = false;
    }

    // for setting the right dialouge active
    void Diatrack()
    {
        if (curdia == 1)
        {
            text = Dia1;
        }

        else if (curdia == 2)
        {
            text = Dia2;
        }

        else if (curdia == 3)
        {
            text = Dia3;
        }
    }
}
