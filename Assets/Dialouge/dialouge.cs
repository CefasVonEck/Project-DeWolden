using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class dialouge : MonoBehaviour
{
    [SerializeField]
    private GameObject bright;


    [SerializeField]
    private Texthandler checkMain;

    [SerializeField]
    private Texthandler checkNpc;

    // a boolean to stop the dialouge from being repeated all the time
    [SerializeField]
    private bool hastalked = false;

    // the animator used for showing textbox maincharacter
    [SerializeField]
    private Animator aniMain;

    // the animator used for showing textbox NPC
    [SerializeField]
    private Animator aniNPC;

    // the text in game for the character to say
    [SerializeField]
    private TextMeshProUGUI diaMain;
    
    // the name in game for the character
    [SerializeField]
    private TextMeshProUGUI nameMain;


    // the text in game for the character to say
    [SerializeField]
    private TextMeshProUGUI diaNPC;

    // the name in game for the character
    [SerializeField]
    private TextMeshProUGUI nameNPC;

    //current dia for Character
    [SerializeField]
    private int curdiaMain = 1;

    // max dia for Character
    [SerializeField]
    private int maxdiaMain;

    // the string variable for the character to say
    [SerializeField]
    private string textChar;

    // the string variable for the name of the character
    [SerializeField]
    private string nameChar;

    // the string variable for the NPC to say
    [SerializeField]
    private string textNpc;

    // the string variable for the name of the NPC
    [SerializeField]
    private string nameNpc;

    // the textbox object
    [SerializeField]
    private GameObject txtboxmain;

    // the textbox object
    [SerializeField]
    private GameObject txtboxNPC;

    // all dia strings and names can be easily changed in inspector this is just for testing
    [SerializeField]
    private string Dia1M = "Hey";

    [SerializeField]
    private string Dia2M = "how u doing";

    [SerializeField]
    private string Dia3M = "bye";

    [SerializeField]
    private string Dia1N = "Hey";

    [SerializeField]
    private string Dia2N = "how u doing";

    [SerializeField]
    private string Dia3N = "bye";

    [SerializeField]
    private string NameMain = "Mina";

    [SerializeField]
    private string NameNPC = "Farmer";

    // e button
    [SerializeField]
    private GameObject indi;

    // player transform
    [SerializeField]
    private GameObject Player;

    // player render picture
    [SerializeField]
    private GameObject PlayerRen;

    // NPC render picture
    [SerializeField]
    private GameObject NPCRen;

    // the render animation for showing in screen
    [SerializeField]
    private Animator playRen;

    // the npc render for showing in screen
    [SerializeField]
    private Animator NpcRen;

    // to check if the player is in talking range
    [SerializeField]
    private bool inrange = false;

    // to check if the player is in dialouge
    [SerializeField]
    private bool india = false;


    private void Awake()
    {
        Player = GameObject.FindWithTag("Player");
        indi = GameObject.FindWithTag("interact");
        txtboxmain = GameObject.FindWithTag("boxmain");
        txtboxNPC = GameObject.FindWithTag("boxnpc");

        NPCRen = GameObject.FindWithTag("NPCRen");
        PlayerRen = GameObject.FindWithTag("CharRen");
    }
    // Start is called before the first frame update
    void Start()
    {
        // disable textbox
        txtboxmain.SetActive(false);
        txtboxNPC.SetActive(false);
        NPCRen.SetActive(false);
        PlayerRen.SetActive(false);
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

        // if the player is in dialouge
        if(india == true)
        {
            // keep track of dialouge and enable the dialouge
            nexttxt();
            DiatrackMain();
            DiatrackNPC();

            // show the textbox
            Showtxt();

            // lower the brightness
            bright.SetActive(true);
        }
        else
        {
            // enable movement
            Player.GetComponent<Player>().enabled = true;

            // disable the textbox
            txtboxmain.SetActive(false);
            txtboxNPC.SetActive(false);

            // have normal brightness
            bright.SetActive(false);
        }

        // updating the text variables constantly
        Textup();
    }

    // for when the player is in talk range
    void InTalkRange()
    {
        // if the player in talking range
        if (inrange == true)
        {
            // if the player hasn't yet talked
            if (hastalked == false)
            {
                // show the indicator
                indi.SetActive(true);
            }


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
        // if the player hasn't yet talked
        if (hastalked == false)
        {
            // enable dialouge/ disable movement
            Player.GetComponent<Player>().enabled = false;

            txtboxmain.SetActive(true);
            txtboxNPC.SetActive(true);
            NPCRen.SetActive(true);
            PlayerRen.SetActive(true);
        }
        else
        {
            // have dialouge inactive
            txtboxmain.SetActive(false);
            txtboxNPC.SetActive(false);
            NPCRen.SetActive(false);
            PlayerRen.SetActive(false);
        }

    }

    // for going trough the text
    void nexttxt()
    {
        // if space is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {

            // go to next text
            curdiaMain += 1;

            // make sure the text isn't shown yet (did it since it looked weird otherwise
            checkMain.canshowtext = false;
            checkNpc.canshowtext = false;

            // if there is no next dialouge
            if (curdiaMain > maxdiaMain)
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
        //curdiaMain = 1;
        hastalked = true;

        india = false;

        // disable all the text and renders
        PlayerRen.SetActive(false);
        NPCRen.SetActive(false);

        txtboxmain.SetActive(false);
        txtboxNPC.SetActive(false);
    }

    // for setting the right dialouge active
    void DiatrackMain()
    {
        // setting first dia right
        if (curdiaMain == 1)
        {
            // getting the NPC Render away (just to be sure)
            NpcRen.SetBool("comin", false);

            // having the right box show up
            aniMain.SetBool("main", true);
            aniNPC.SetBool("side", false);


            //right text showing
            if (checkMain.canshowtext == true)
            {
                textChar = Dia1M;
                diaNPC.gameObject.SetActive(false);
                diaMain.gameObject.SetActive(true);
            }

            // set the name right
            nameChar = NameMain;

            if (checkMain.boxinplace == true)
            {
                // have the right render showing up
                playRen.SetBool("coming", true);
            }


        }

        else if (curdiaMain == 3)
        {
            // have the render going away first
            NpcRen.SetBool("comin", false);

            // when the render is gone
            if (checkNpc.rengone == true)
            {
                // have the right box show up
                aniMain.SetBool("main", true);
                aniNPC.SetBool("side", false);
            }

            //right text showing
            if (checkMain.canshowtext == true)
            {
                textChar = Dia2M;
                diaNPC.gameObject.SetActive(false);
                diaMain.gameObject.SetActive(true);
            }


            // right name showing
            nameChar = NameMain;

            //right render showing
            if (checkMain.boxinplace == true)
            {
                // have the right render showing up
                playRen.SetBool("coming", true);
            }

        }

        else if (curdiaMain == 5)
        {
            // have the render going away first
            NpcRen.SetBool("comin", false);

            // when the render is gone
            if (checkNpc.rengone == true)
            {
                // have the right box show up
                aniMain.SetBool("main", true);
                aniNPC.SetBool("side", false);
            }

            //right text showing
            if (checkMain.canshowtext == true)
            {
                textChar = Dia3M;
                diaNPC.gameObject.SetActive(false);
                diaMain.gameObject.SetActive(true);
            }


            //right name showing
            nameChar = NameMain;

            //right render showing
            if (checkMain.boxinplace == true)
            {
                // have the right render showing up
                playRen.SetBool("coming", true);
            }

        }
    }

    void DiatrackNPC()
    {
        // setting first dia right
        if (curdiaMain == 2)
        {
            // have the render going away first
            playRen.SetBool("coming", false);

            // when the render is gone
            if (checkMain.rengone == true)
            {
                // having the right box show up
                aniMain.SetBool("main", false);
                aniNPC.SetBool("side", true);
            }

            //right text showing
            if (checkNpc.canshowtext == true)
            {
                textNpc = Dia1N;
                diaNPC.gameObject.SetActive(true);
                diaMain.gameObject.SetActive(false);
            }


            // set the name right
            nameNpc = NameNPC;

            //right render showing
            if (checkNpc.boxinplace == true)
            {
                // have the right render showing up
                NpcRen.SetBool("comin", true);
            }
        }

        else if (curdiaMain == 4)
        {
            // have the right render showing up
            playRen.SetBool("coming", false);

            // when the render is gone
            if (checkMain.rengone == true)
            {
                // having the right box show up
                aniMain.SetBool("main", false);
                aniNPC.SetBool("side", true);
            }

            //right text showing
            if (checkNpc.canshowtext == true)
            {
                textNpc = Dia2N;
                diaNPC.gameObject.SetActive(true);
                diaMain.gameObject.SetActive(false);
            }


            // right name showing
            nameNpc = NameNPC;

            //right render showing
            if (checkNpc.boxinplace == true)
            {
                // have the right render showing up
                NpcRen.SetBool("comin", true);
            }

        }

        else if (curdiaMain == 6)
        {
            // have the right render showing up
            playRen.SetBool("coming", false);

            // when the render is gone
            if (checkMain.rengone == true)
            {
                // having the right box show up
                aniMain.SetBool("main", false);
                aniNPC.SetBool("side", true);
            }

            //right text showing
            if (checkNpc.canshowtext == true)
            {
                textNpc = Dia3N;
                diaNPC.gameObject.SetActive(true);
                diaMain.gameObject.SetActive(false);
            }


            //right name showing
            nameNpc = NameNPC;

            //right render showing
            if (checkNpc.boxinplace == true)
            {
                // have the right render showing up
                NpcRen.SetBool("comin", true);
            }

        }
    }


    void Textup()
    {
        // constantly update the text 
        diaMain.text = textChar.ToString();
        
        nameMain.text = nameChar.ToString();

        diaNPC.text = textNpc.ToString();

        nameNPC.text = nameNpc.ToString();
    }


}
