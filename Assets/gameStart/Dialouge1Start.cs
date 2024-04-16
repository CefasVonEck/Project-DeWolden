using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Dialouge1Start : MonoBehaviour
{
    [Header("character renders")]
    [SerializeField]
    private Sprite SMina;

    [SerializeField]
    private Sprite SJag;

    [SerializeField]
    private Sprite Sspin;

    [Header("game control")]

    [SerializeField]
    private GameObject boxes;

    [SerializeField]
    public GameObject boxes2;

    [SerializeField]
    public GameObject boxes3;

    // to check if the player is in dialouge
    [SerializeField]
    public bool india = false;

    public writer write;

    public writer write2;

    public writer write3;

    [SerializeField]
    private GameObject bright;

    [SerializeField]
    private Texthandler checkMain;

    [SerializeField]
    private Texthandler checkNpc;

    [SerializeField]
    private Texthandler checkMain2;

    [SerializeField]
    private Texthandler checkNpc2;

    [SerializeField]
    private Texthandler checkMain3;

    [SerializeField]
    public Texthandler checkNpc3;

    //current dia for Character
    [SerializeField]
    private int curdiaMain1 = 1;

    // max dia for Character
    [SerializeField]
    private int maxdiaMain1;

    //current dia for Character
    [SerializeField]
    private int curdiaMain2 = 1;

    // max dia for Character
    [SerializeField]
    private int maxdiaMain2;

    //current dia for Character
    [SerializeField]
    private int curdiaMain3 = 1;

    // max dia for Character
    [SerializeField]
    private int maxdiaMain3;

    // a boolean to stop the dialouge from being repeated all the time
    [SerializeField]
    private bool hastalked = false;

    [Header("animators")]
    // the animator used for showing textbox maincharacter
    [SerializeField]
    private Animator aniMain;

    // the animator used for showing textbox NPC
    [SerializeField]
    private Animator aniNPC;    
    
    // the render animation for showing in screen
    [SerializeField]
    private Animator playRen;

    // the npc render for showing in screen
    [SerializeField]
    private Animator NpcRen;

    [Header("animators2")]
    // the animator used for showing textbox maincharacter
    [SerializeField]
    private Animator aniMain2;

    // the animator used for showing textbox NPC
    [SerializeField]
    private Animator aniNPC2;

    // the render animation for showing in screen
    [SerializeField]
    private Animator playRen2;

    // the npc render for showing in screen
    [SerializeField]
    private Animator NpcRen2;

    [Header("animators3")]
    // the animator used for showing textbox maincharacter
    [SerializeField]
    private Animator aniMain3;

    // the animator used for showing textbox NPC
    [SerializeField]
    private Animator aniNPC3;

    // the render animation for showing in screen
    [SerializeField]
    private Animator playRen3;

    // the npc render for showing in screen
    [SerializeField]
    private Animator NpcRen3;


    [Header("all the textmeshed")]
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


    [Header("txtboxes and renders")]
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

    // player render picture
    [SerializeField]
    private GameObject PlayerRen;

    // NPC render picture
    [SerializeField]
    private GameObject NPCRen;

    [Header("all the textmeshed2")]
    // the text in game for the character to say
    [SerializeField]
    private TextMeshProUGUI diaMain2;

    // the name in game for the character
    [SerializeField]
    private TextMeshProUGUI nameMain2;

    // the text in game for the character to say
    [SerializeField]
    private TextMeshProUGUI diaNPC2;

    // the name in game for the character
    [SerializeField]
    private TextMeshProUGUI nameNPC2;


    [Header("txtboxes and renders2")]
    // the string variable for the name of the character
    [SerializeField]
    private string nameChar2;

    // the string variable for the NPC to say
    [SerializeField]
    private string textNpc2;

    // the string variable for the name of the NPC
    [SerializeField]
    private string nameNpc2;

    // the textbox object
    [SerializeField]
    private GameObject txtboxmain2;

    // the textbox object
    [SerializeField]
    private GameObject txtboxNPC2;

    // player render picture
    [SerializeField]
    private GameObject PlayerRen2;

    // NPC render picture
    [SerializeField]
    private GameObject NPCRen2;

    [Header("all the textmeshes3")]

    // the text in game for the character to say
    [SerializeField]
    private TextMeshProUGUI diaMain3;

    // the name in game for the character
    [SerializeField]
    private TextMeshProUGUI nameMain3;

    // the text in game for the character to say
    [SerializeField]
    private TextMeshProUGUI diaNPC3;

    // the name in game for the character
    [SerializeField]
    private TextMeshProUGUI nameNPC3;


    [Header("txtboxes and renders3")]
    // the string variable for the name of the character
    [SerializeField]
    private string nameChar3;

    // the string variable for the NPC to say
    [SerializeField]
    private string textNpc3;

    // the string variable for the name of the NPC
    [SerializeField]
    private string nameNpc3;

    // the textbox object
    [SerializeField]
    private GameObject txtboxmain3;

    // the textbox object
    [SerializeField]
    private GameObject txtboxNPC3;

    // player render picture
    [SerializeField]
    private GameObject PlayerRen3;

    // NPC render picture
    [SerializeField]
    private GameObject NPCRen3;

    [Header("dialouge options part1")]
    // all dia strings and names can be easily changed in inspector this is just for testing
    [SerializeField]
    private string Dia1M1 = "Hey";

    [SerializeField]
    private string Dia2M1 = "how u doing";

    [SerializeField]
    private string Dia3M1 = "bye";

    [SerializeField]
    private string Dia4M1 = "bye";

    [SerializeField]
    private string Dia1N1 = "Hey";

    [SerializeField]
    private string Dia2N1 = "how u doing";

    [SerializeField]
    private string Dia3N1 = "bye";

    [SerializeField]
    private string NameMain1 = "Mina";

    [SerializeField]
    private string NameNPC1 = "Farmer";

    [Header("dialouge options part2")]
    // all dia strings and names can be easily changed in inspector this is just for testing
    [SerializeField]
    private string Dia1M2 = "Hey";

    [SerializeField]
    private string Dia2M2 = "how u doing";

    [SerializeField]
    private string Dia3M2 = "bye";

    [SerializeField]
    private string Dia4M2 = "bye";

    [SerializeField]
    private string Dia1N2 = "Hey";

    [SerializeField]
    private string Dia2N2 = "how u doing";

    [SerializeField]
    private string Dia3N2 = "bye";

    [SerializeField]
    private string NameMain2 = "SpinWiefen";

    [SerializeField]
    private string NameNPC2 = "Jager";

    [SerializeField]
    private string NameNPC22 = "Mina";

    [SerializeField]
    private string NameNPC23 = "Mina and Jager";


    [Header("dialouge options part3")]
    // all dia strings and names can be easily changed in inspector this is just for testing
    [SerializeField]
    private string Dia1M3 = "Hey";

    [SerializeField]
    private string Dia2M3 = "how u doing";

    [SerializeField]
    private string Dia3M3 = "bye";

    [SerializeField]
    private string Dia4M3 = "bye";

    [SerializeField]
    private string Dia1N3 = "Hey";

    [SerializeField]
    private string Dia2N3 = "how u doing";

    [SerializeField]
    private string Dia3N3 = "bye";

    [SerializeField]
    private string NameMain3 = "Mina";

    [SerializeField]
    private string NameNPC3 = "Farmer";

    [SerializeField]
    private string NameNPC32 = "Farmer";

    [SerializeField]
    private string NameNPC33 = "Farmer";

    public gameStart startdia;

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
        //if part one is being active
        if (startdia.Startdia1 == true)
        {
            india = true;
            // keep track of dialouge and enable the dialouge
            nexttxt1();
            DiatrackMain1();

            txtboxmain.SetActive(true);
            txtboxNPC.SetActive(true);
            NPCRen.SetActive(true);
            PlayerRen.SetActive(true);

            // lower the brightness
            bright.SetActive(true);
            // updating the text variables constantly
            Textup();
        }

        else if (startdia.Startdia2 == true)
        {
            india = true;
            // keep track of dialouge and enable the dialouge
            nexttxt2();
            DiatrackMain2();

            txtboxmain2.SetActive(true);
            txtboxNPC2.SetActive(true);
            NPCRen2.SetActive(true);
            PlayerRen2.SetActive(true);

            boxes2.SetActive(true);
            // lower the brightness
            bright.SetActive(true);
            // updating the text variables constantly
            Textup2();
        }

        else if (startdia.Startdia3 == true)
        {
            india = true;
            // keep track of dialouge and enable the dialouge
            nexttxt3();
            DiatrackMain3();

            txtboxmain3.SetActive(true);
            txtboxNPC3.SetActive(true);
            NPCRen3.SetActive(true);
            PlayerRen3.SetActive(true);

            boxes3.SetActive(true);
            // lower the brightness
            bright.SetActive(true);
            // updating the text variables constantly
            Textup3();
        }

        if (india == false)
        {
            bright.SetActive(false);
        }
    }


    // for going trough the text
    void nexttxt1()
    {
        // if space is pressed
        if (Input.GetKeyDown(KeyCode.Space)) //&& write.cancon == true)
        {
            write.DeltaTime = 0f;

            // go to next text
            curdiaMain1 += 1;

            //write.cancon = false;

            // make sure the text isn't shown yet (did it since it looked weird otherwise
            checkMain.canshowtext = false;
            checkNpc.canshowtext = false;

            // if there is no next dialouge
            if (curdiaMain1 > maxdiaMain1)
            {
                // finish the text
                fintxt1();
            }
        }
    }

    void nexttxt2()
    {
        // if space is pressed
        if (Input.GetKeyDown(KeyCode.Space)) //&& write2.cancon == true)
        {
            write2.DeltaTime = 0f;

            // go to next text
            curdiaMain2 += 1;

            //write2.cancon = false;

            // make sure the text isn't shown yet (did it since it looked weird otherwise
            checkMain2.canshowtext = false;
            checkNpc2.canshowtext = false;

            // if there is no next dialouge
            if (curdiaMain2 > maxdiaMain2)
            {
                // finish the text
                fintxt2();
            }
        }
    }

    void nexttxt3()
    {
        // if space is pressed
        if (Input.GetKeyDown(KeyCode.Space)) //&& write2.cancon == true)
        {
            write3.DeltaTime = 0f;

            // go to next text
            curdiaMain3 += 1;

            //write2.cancon = false;

            // make sure the text isn't shown yet (did it since it looked weird otherwise
            checkMain3.canshowtext = false;
            checkNpc3.canshowtext = false;

            // if there is no next dialouge
            if (curdiaMain3 > maxdiaMain3)
            {
                // finish the text
                fintxt3();
            }
        }
    }

    // for the final dialouge
    void fintxt1()
    {

        // disable all the text and renders
        PlayerRen.SetActive(false);
        NPCRen.SetActive(false);

        txtboxmain.SetActive(false);
        txtboxNPC.SetActive(false);

        india = false;

        startdia.Startdia1 = false;

        startdia.findia1 = true;

        // reset everything
        write.DeltaTime = 0f;

        write.partialtext = "";

        curdiaMain1 = 0;

        boxes.SetActive(false);
    }

    void fintxt2()
    {

        // disable all the text and renders
        PlayerRen2.SetActive(false);
        NPCRen2.SetActive(false);

        txtboxmain2.SetActive(false);
        txtboxNPC2.SetActive(false);

        india = false;

        startdia.Startdia2 = false;

        startdia.findia2 = true;

        // reset everything
        write2.DeltaTime = 0f;

        write2.partialtext = "";

        curdiaMain2 = 1;

        boxes2.SetActive(false);

        bright.SetActive(false);
    }

    void fintxt3()
    {

        // disable all the text and renders
        PlayerRen3.SetActive(false);
        NPCRen3.SetActive(false);

        txtboxmain3.SetActive(false);
        txtboxNPC3.SetActive(false);

        india = false;

        startdia.Startdia3 = false;

        startdia.findia3 = true;

        // reset everything
        write3.DeltaTime = 0f;

        write3.partialtext = "";

        curdiaMain3 = 1;

        boxes3.SetActive(false);

        bright.SetActive(false);
    }

    // for setting the right dialouge active
    void DiatrackMain1()
    {
        // setting first dia right
        if (curdiaMain1 == 1)
        {
            PlayerRen.GetComponent<Image>().sprite = SMina;

            write.text = Dia1M1;
            // getting the NPC Render away (just to be sure)
            NpcRen.SetBool("comin", false);

            // having the right box show up
            aniMain.SetBool("main", true);
            aniNPC.SetBool("side", false);


            //right text showing
            if (checkMain.canshowtext == true)
            {
                write.Towrite = diaMain;
                write.StartWriting();
            }

            // set the name right
            nameChar = NameMain1;

            if (checkMain.boxinplace == true)
            {
                // have the right render showing up
                playRen.SetBool("coming", true);
            }
        }

        // setting first dia right
        if (curdiaMain1 == 2)
        {
            NpcRen.GetComponent<Image>().sprite = SJag;

            write.text = Dia1N1;
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
                write.Towrite = diaNPC;
                write.StartWriting();

            }


            // set the name right
            nameNpc = NameNPC1;

            //right render showing
            if (checkNpc.boxinplace == true)
            {
                // have the right render showing up
                NpcRen.SetBool("comin", true);
            }
        }


        else if (curdiaMain1 == 3)
        {
            PlayerRen.GetComponent<Image>().sprite = SMina;

            write.text = Dia2M1;
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
                write.Towrite = diaMain;
                write.StartWriting();
            }


            // right name showing
            nameChar = NameMain1;

            //right render showing
            if (checkMain.boxinplace == true)
            {
                // have the right render showing up
                playRen.SetBool("coming", true);
            }

        }

        else if (curdiaMain1 == 4)
        {
            NpcRen.GetComponent<Image>().sprite = SJag;

            write.text = Dia2N1;
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
                write.Towrite = diaNPC;
                write.StartWriting();
            }

            // right name showing
            nameNpc = NameNPC1;

            //right render showing
            if (checkNpc.boxinplace == true)
            {
                // have the right render showing up
                NpcRen.SetBool("comin", true);
            }

        }

        else if (curdiaMain1 == 5)
        {
            PlayerRen.GetComponent<Image>().sprite = SMina;

            write.text = Dia3M1;
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
                write.Towrite = diaMain;
                write.StartWriting();
            }

            //right name showing
            nameChar = NameMain1;

            //right render showing
            if (checkMain.boxinplace == true)
            {
                // have the right render showing up
                playRen.SetBool("coming", true);
            }

        }

        else if (curdiaMain1 == 6)
        {
            NpcRen.GetComponent<Image>().sprite = SJag;

            write.text = Dia3N1;
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
                write.Towrite = diaNPC;
                write.StartWriting();

            }

            //right name showing
            nameNpc = NameNPC1;

            //right render showing
            if (checkNpc.boxinplace == true)
            {
                // have the right render showing up
                NpcRen.SetBool("comin", true);
            }

        }

        else if (curdiaMain1 == 7)
        {
            PlayerRen.GetComponent<Image>().sprite = SMina;

            write.text = Dia4M1;
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
                write.Towrite = diaMain;
                write.StartWriting();

            }

            //right name showing
            nameChar = NameMain1;

            //right render showing
            if (checkMain.boxinplace == true)
            {
                // have the right render showing up
                playRen.SetBool("coming", true);
            }

        }
    }

    void DiatrackMain2()
    {
        // setting first dia right
        if (curdiaMain2 == 1)
        {
            PlayerRen2.GetComponent<Image>().sprite = Sspin;

            write2.text = Dia1M2;
            // getting the NPC Render away (just to be sure)
            NpcRen2.SetBool("comin2", false);

            // having the right box show up
            aniMain2.SetBool("main2", true);
            aniNPC2.SetBool("side2", false);


            //right text showing
            if (checkMain2.canshowtext == true)
            {
                write2.Towrite = diaMain2;
                write2.StartWriting();
            }

            // set the name right
            nameChar2 = NameMain2;

            if (checkMain2.boxinplace == true)
            {
                // have the right render showing up
                playRen2.SetBool("coming2", true);
            }
        }

        // setting first dia right
        if (curdiaMain2 == 2)
        {
            NpcRen2.GetComponent<Image>().sprite = SJag;

            write2.text = Dia1N2;
            // have the render going away first
            playRen2.SetBool("coming2", false);

            // when the render is gone
            if (checkMain2.rengone == true)
            {
                // having the right box show up
                aniMain2.SetBool("main2", false);
                aniNPC2.SetBool("side2", true);
            }

            //right text showing
            if (checkNpc2.canshowtext == true)
            {
                write2.Towrite = diaNPC2;
                write2.StartWriting();

            }


            // set the name right
            nameNpc2 = NameNPC2;

            //right render showing
            if (checkNpc2.boxinplace == true)
            {
                // have the right render showing up
                NpcRen2.SetBool("comin2", true);
            }
        }


        else if (curdiaMain2 == 3)
        {
            PlayerRen2.GetComponent<Image>().sprite = SMina;

            write2.text = Dia2M2;
            // have the render going away first
            NpcRen2.SetBool("comin2", false);

            // when the render is gone
            if (checkNpc2.rengone == true)
            {
                // have the right box show up
                aniMain2.SetBool("main2", true);
                aniNPC2.SetBool("side2", false);
            }

            //right text showing
            if (checkMain2.canshowtext == true)
            {
                write2.Towrite = diaMain2;
                write2.StartWriting();
            }


            // right name showing
            nameChar2 = NameNPC22;

            //right render showing
            if (checkMain.boxinplace == true)
            {
                // have the right render showing up
                playRen2.SetBool("coming2", true);
            }

        }

        else if (curdiaMain2 == 4)
        {
            NpcRen2.GetComponent<Image>().sprite = Sspin;

            write2.text = Dia2N2;
            // have the right render showing up
            playRen2.SetBool("coming2", false);

            // when the render is gone
            if (checkMain2.rengone == true)
            {
                // having the right box show up
                aniMain2.SetBool("main2", false);
                aniNPC2.SetBool("side2", true);
            }

            //right text showing
            if (checkNpc2.canshowtext == true)
            {
                write2.Towrite = diaNPC2;
                write2.StartWriting();
            }

            // right name showing
            nameNpc2 = NameMain2;

            //right render showing
            if (checkNpc2.boxinplace == true)
            {
                // have the right render showing up
                NpcRen2.SetBool("comin2", true);
            }

        }

        else if (curdiaMain2 == 5)
        {
            PlayerRen2.GetComponent<Image>().sprite = SJag;

            write2.text = Dia3M2;
            // have the render going away first
            NpcRen2.SetBool("comin2", false);

            // when the render is gone
            if (checkNpc2.rengone == true)
            {
                // have the right box show up
                aniMain2.SetBool("main2", true);
                aniNPC2.SetBool("side2", false);
            }

            //right text showing
            if (checkMain2.canshowtext == true)
            {
                write2.Towrite = diaMain2;
                write2.StartWriting();
            }

            //right name showing
            nameChar2 = NameNPC2;

            //right render showing
            if (checkMain2.boxinplace == true)
            {
                // have the right render showing up
                playRen2.SetBool("coming2", true);
            }

        }

        else if (curdiaMain2 == 6)
        {
            NpcRen2.GetComponent<Image>().sprite = Sspin;

            write2.text = Dia3N2;
            // have the right render showing up
            playRen2.SetBool("coming2", false);

            // when the render is gone
            if (checkMain2.rengone == true)
            {
                // having the right box show up
                aniMain2.SetBool("main2", false);
                aniNPC2.SetBool("side2", true);
            }

            //right text showing
            if (checkNpc2.canshowtext == true)
            {
                write2.Towrite = diaNPC2;
                write2.StartWriting();

            }

            //right name showing
            nameNpc2 = NameMain2;

            //right render showing
            if (checkNpc2.boxinplace == true)
            {
                // have the right render showing up
                NpcRen2.SetBool("comin2", true);
            }

        }

        else if (curdiaMain2 == 7)
        {
            PlayerRen2.GetComponent<Image>().sprite = SMina;

            NpcRen.GetComponent<Image>().sprite = SJag;

            write2.text = Dia4M2;
            // have the render going away first
            NpcRen2.SetBool("comin2", false);

            // when the render is gone
            if (checkNpc2.rengone == true)
            {
                // have the right box show up
                aniMain2.SetBool("main2", true);
                aniNPC2.SetBool("side2", false);
            }

            //right text showing
            if (checkMain2.canshowtext == true)
            {
                write2.Towrite = diaMain2;
                write2.StartWriting();

            }

            //right name showing
            nameChar2 = NameNPC23;

            //right render showing
            if (checkMain2.boxinplace == true)
            {
                // have the right render showing up
                playRen2.SetBool("coming2", true);
                NpcRen2.SetBool("comin2", true);
            }

        }
    }

    void DiatrackMain3()
    {
        // setting first dia right
        if (curdiaMain3 == 1)
        {
            PlayerRen3.GetComponent<Image>().sprite = SMina;

            write3.text = Dia1M3;
            // getting the NPC Render away (just to be sure)
            NpcRen3.SetBool("comin", false);

            // having the right box show up
            aniMain3.SetBool("main", true);
            aniNPC3.SetBool("side", false);


            //right text showing
            if (checkMain3.canshowtext == true)
            {
                write3.Towrite = diaMain3;
                write3.StartWriting();
            }

            // set the name right
            nameChar3 = NameMain3;

            if (checkMain3.boxinplace == true)
            {
                // have the right render showing up
                playRen3.SetBool("coming", true);
            }
        }

        // setting first dia right
        if (curdiaMain3 == 2)
        {
            NpcRen3.GetComponent<Image>().sprite = Sspin;

            write3.text = Dia1N3;
            // have the render going away first
            playRen3.SetBool("coming", false);

            // when the render is gone
            if (checkMain3.rengone == true)
            {
                // having the right box show up
                aniMain3.SetBool("main", false);
                aniNPC3.SetBool("side", true);
            }

            //right text showing
            if (checkNpc3.canshowtext == true)
            {
                write3.Towrite = diaNPC3;
                write3.StartWriting();

            }


            // set the name right
            nameNpc3 = NameNPC3;

            //right render showing
            if (checkNpc3.boxinplace == true)
            {
                // have the right render showing up
                NpcRen3.SetBool("comin", true);
            }
        }


        else if (curdiaMain3 == 3)
        {
            PlayerRen3.GetComponent<Image>().sprite = SMina;

            write3.text = Dia2M3;
            // have the render going away first
            NpcRen3.SetBool("comin", false);

            // when the render is gone
            if (checkNpc3.rengone == true)
            {
                // have the right box show up
                aniMain3.SetBool("main", true);
                aniNPC3.SetBool("side", false);
            }

            //right text showing
            if (checkMain3.canshowtext == true)
            {
                write3.Towrite = diaMain3;
                write3.StartWriting();
            }


            // right name showing
            nameChar3 = NameNPC3;

            //right render showing
            if (checkMain3.boxinplace == true)
            {
                // have the right render showing up
                playRen3.SetBool("coming", true);
            }

        }

        else if (curdiaMain3 == 4)
        {
            NpcRen3.GetComponent<Image>().sprite = Sspin;

            write3.text = Dia2N3;
            // have the right render showing up
            playRen3.SetBool("coming", false);

            // when the render is gone
            if (checkMain3.rengone == true)
            {
                // having the right box show up
                aniMain3.SetBool("main", false);
                aniNPC3.SetBool("side", true);
            }

            //right text showing
            if (checkNpc3.canshowtext == true)
            {
                write3.Towrite = diaNPC3;
                write3.StartWriting();
            }

            // right name showing
            nameNpc3 = NameMain3;

            //right render showing
            if (checkNpc3.boxinplace == true)
            {
                // have the right render showing up
                NpcRen3.SetBool("comin", true);
            }

        }

        else if (curdiaMain3 == 5)
        {
            PlayerRen3.GetComponent<Image>().sprite = SJag;

            write3.text = Dia3M3;
            // have the render going away first
            NpcRen3.SetBool("comin", false);

            // when the render is gone
            if (checkNpc3.rengone == true)
            {
                // have the right box show up
                aniMain3.SetBool("main", true);
                aniNPC3.SetBool("side", false);
            }

            //right text showing
            if (checkMain3.canshowtext == true)
            {
                write3.Towrite = diaMain3;
                write3.StartWriting();
            }

            //right name showing
            nameChar3 = NameNPC32;

            //right render showing
            if (checkMain3.boxinplace == true)
            {
                // have the right render showing up
                playRen3.SetBool("coming", true);
            }

        }

        else if (curdiaMain3 == 6)
        {
            NpcRen3.GetComponent<Image>().sprite = Sspin;

            write3.text = Dia3N3;
            // have the right render showing up
            playRen3.SetBool("coming", false);

            // when the render is gone
            if (checkMain3.rengone == true)
            {
                // having the right box show up
                aniMain3.SetBool("main", false);
                aniNPC3.SetBool("side", true);
            }

            //right text showing
            if (checkNpc3.canshowtext == true)
            {
                write3.Towrite = diaNPC3;
                write3.StartWriting();

            }

            //right name showing
            nameNpc3 = NameNPC3;

            //right render showing
            if (checkNpc3.boxinplace == true)
            {
                // have the right render showing up
                NpcRen3.SetBool("comin", true);
            }

        }

        else if (curdiaMain3 == 7)
        {
            PlayerRen3.GetComponent<Image>().sprite = SMina;

            NPCRen3.GetComponent<Image>().sprite = SJag;

            write3.text = Dia4M3;
            // have the render going away first
            NpcRen3.SetBool("comin", false);

            // when the render is gone
            if (checkNpc3.rengone == true)
            {
                // have the right box show up
                aniMain3.SetBool("main", true);
                aniNPC3.SetBool("side", false);
            }

            //right text showing
            if (checkMain3.canshowtext == true)
            {
                write3.Towrite = diaMain3;
                write3.StartWriting();

            }

            //right name showing
            nameChar3 = NameNPC33;

            //right render showing
            if (checkMain3.boxinplace == true)
            {
                // have the right render showing up
                playRen3.SetBool("coming", true);
                NpcRen3.SetBool("comin", true);
            }

        }
    }

    void Textup()
    {
        // constantly update the text 
        diaMain.text = write.partialtext.ToString();
        
        nameMain.text = nameChar.ToString();

        diaNPC.text = write.partialtext.ToString();

        nameNPC.text = nameNpc.ToString();
    }

    void Textup2()
    {
        // constantly update the text 
        diaMain2.text = write2.partialtext.ToString();

        nameMain2.text = nameChar2.ToString();

        diaNPC2.text = write2.partialtext.ToString();

        nameNPC2.text = nameNpc2.ToString();
    }

    void Textup3()
    {
        // constantly update the text 
        diaMain3.text = write3.partialtext.ToString();

        nameMain3.text = nameChar3.ToString();

        diaNPC3.text = write3.partialtext.ToString();

        nameNPC3.text = nameNpc3.ToString();
    }

}
