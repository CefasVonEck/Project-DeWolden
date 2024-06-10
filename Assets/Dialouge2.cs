using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

<<<<<<< HEAD

using UnityEngine.SceneManagement;



=======
<<<<<<< HEAD
using UnityEngine.SceneManagement;


=======
>>>>>>> origin/CombatBranch
>>>>>>> origin/CombatBranch
public class Dialouge2 : MonoBehaviour
{
    [Header("character renders")]
    [SerializeField]
    private Sprite SMina;

    [SerializeField]
    private Sprite SJag;

<<<<<<< HEAD

    [SerializeField]
    private Sprite SSpin;


=======
<<<<<<< HEAD
<<<<<<< HEAD
    [SerializeField]
    private Sprite SSpin;

=======
>>>>>>> origin/CombatBranch
=======
>>>>>>> origin/CombatBranch
>>>>>>> origin/CombatBranch
    [Header("game control")]
    // to check if the player is in dialouge
    [SerializeField]
    public bool india = false;

    public writer write;

    [SerializeField]
    private GameObject bright;

    [SerializeField]
    private Texthandler checkMain;

    [SerializeField]
    private Texthandler checkNpc;

    //current dia for Character
    [SerializeField]
    private int curdiaMain1 = 1;

    // max dia for Character
    [SerializeField]
    private int maxdiaMain1;

    [SerializeField]
    private Pageinfo scrip;

    [SerializeField]
    private GameChecker check;

    public bool candia;


    [Header("animators")]
    // the animator used for showing textbox maincharacter
    [SerializeField]
    private Animator aniMain;

    // the render animation for showing in screen
    [SerializeField]
    private Animator playRen;

    // the npc render for showing in screen
    [SerializeField]
    private Animator NpcRen;

    // the animator used for showing textbox NPC
    [SerializeField]
    private Animator aniNPC;


    [Header("txtboxes and renders")]
    // the string variable for the name of the character
    [SerializeField]
    private string nameChar;

    // the string variable for the name of the NPC
    [SerializeField]
    private string nameNpc;

    // the textbox object
    [SerializeField]
    private GameObject txtboxmain;

    // player render picture
    [SerializeField]
    private GameObject PlayerRen;

    // the textbox object
    [SerializeField]
    private GameObject txtboxNPC;

    // NPC render picture
    [SerializeField]
    private GameObject NPCRen;

    [Header("dialouge options part1")]
    // all dia strings and names can be easily changed in inspector this is just for testing
    [SerializeField]
    private string Dia1M = "Hey";

    [SerializeField]
    private string Dia2M = "how u doing";

    [SerializeField]
    private string Dia3M = "how u doing";

    [SerializeField]
    private string Dia4M = "how u doing";

    [SerializeField]
<<<<<<< HEAD

    private string Dia5M = "how u doing";

    [SerializeField]

=======
<<<<<<< HEAD
<<<<<<< HEAD
    private string Dia5M = "how u doing";

    [SerializeField]
=======
>>>>>>> origin/CombatBranch
=======
>>>>>>> origin/CombatBranch
>>>>>>> origin/CombatBranch
    private string NameMain = "Mina";

    [SerializeField]
    private string NameNPC = "Duivel van Koekange";

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

    [SerializeField]
    private bool forSpin;

    [SerializeField]
    private bool forJag;

    public GameObject jag;

<<<<<<< HEAD
    public GameObject pop;
    public GameObject pop2;
=======
<<<<<<< HEAD
<<<<<<< HEAD
    public GameObject pop;
    public GameObject pop2;
=======
>>>>>>> origin/CombatBranch
=======
>>>>>>> origin/CombatBranch
>>>>>>> origin/CombatBranch

    // Start is called before the first frame update
    void Start()
    {

        india = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (india == true)
        {
            bright.SetActive(true);
            nexttxt1();
            DiatrackMain1();
            txtboxmain.SetActive(true);
            PlayerRen.SetActive(true);

        }
        else
        {
            txtboxmain.SetActive(false);
            PlayerRen.SetActive(false);
            bright.SetActive(false);
        }
        nameMain.text = nameChar.ToString();

        // constantly update the text 
        diaMain.text = write.partialtext.ToString();
    }

    void DiatrackMain1()
    {
        // setting first dia right
        if (curdiaMain1 == 1)
        {
<<<<<<< HEAD


            PlayerRen.GetComponent<Image>().sprite = SSpin;

=======
<<<<<<< HEAD
<<<<<<< HEAD
            PlayerRen.GetComponent<Image>().sprite = SSpin;
=======
>>>>>>> origin/CombatBranch
            PlayerRen.GetComponent<Image>().sprite = SJag;
>>>>>>> origin/CombatBranch
=======
            PlayerRen.GetComponent<Image>().sprite = SJag;
>>>>>>> origin/CombatBranch

            PlayerRen.GetComponent<Image>().sprite = SJag;


            write.text = Dia1M;
            bright.SetActive(true);

            // set the name right
            nameChar = NameMain;

            // having the right box show up
            aniMain.SetBool("main", true);
            aniNPC.SetBool("side", false);


            //right text showing
            if (checkMain.canshowtext == true)
            {
                write.Towrite = diaMain;
                write.StartWriting();
            }



            if (checkMain.boxinplace == true)
            {
                // have the right render showing up
                playRen.SetBool("coming", true);
            }
        }

        // setting first dia right
        if (curdiaMain1 == 2)
        {
            write.text = Dia2M;
            write.Towrite = diaNPC;
            write.StartWriting();

            NPCRen.GetComponent<Image>().sprite = SMina;

            // have the render going away first
            playRen.SetBool("coming", false);


            //right text showing
            if (checkMain.canshowtext == true)
            {
                write.Towrite = diaMain;
                write.StartWriting();

            }


            // set the name right
            nameChar = NameNPC;

            //right render showing
            if (checkMain.boxinplace == true)
            {
                // have the right render showing up
                NpcRen.SetBool("comin", true);
            }
        }

        // setting first dia right
        if (curdiaMain1 == 3)
        {
<<<<<<< HEAD

            PlayerRen.GetComponent<Image>().sprite = SSpin;

=======
<<<<<<< HEAD
<<<<<<< HEAD
            PlayerRen.GetComponent<Image>().sprite = SSpin;
=======
>>>>>>> origin/CombatBranch
            PlayerRen.GetComponent<Image>().sprite = SJag;
>>>>>>> origin/CombatBranch
=======
            PlayerRen.GetComponent<Image>().sprite = SJag;
>>>>>>> origin/CombatBranch


            PlayerRen.GetComponent<Image>().sprite = SJag;


            NpcRen.SetBool("comin", false);

            write.text = Dia3M;
            bright.SetActive(true);

            // set the name right
            nameChar = NameMain;



            //right text showing
            if (checkMain.canshowtext == true)
            {
                write.Towrite = diaMain;
                write.StartWriting();
            }



            if (checkMain.boxinplace == true)
            {
                // have the right render showing up
                playRen.SetBool("coming", true);
            }
        }

        // setting first dia right
        if (curdiaMain1 == 4)
        {
            write.text = Dia4M;
            write.Towrite = diaNPC;
            write.StartWriting();

            NPCRen.GetComponent<Image>().sprite = SMina;

            // have the render going away first
            playRen.SetBool("coming", false);


            //right text showing
            if (checkMain.canshowtext == true)
            {
                write.Towrite = diaMain;
                write.StartWriting();

            }


            // set the name right
            nameChar = NameNPC;

            //right render showing
            if (checkMain.boxinplace == true)
            {
                // have the right render showing up
                NpcRen.SetBool("comin", true);
            }
        }

<<<<<<< HEAD

=======
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> origin/CombatBranch
        // setting first dia right
        if (curdiaMain1 == 5)
        {
            write.text = Dia5M;
            write.Towrite = diaNPC;
            write.StartWriting();

            NPCRen.GetComponent<Image>().sprite = SJag;

            // have the render going away first
            playRen.SetBool("coming", false);


            //right text showing
            if (checkMain.canshowtext == true)
            {
                write.Towrite = diaMain;
                write.StartWriting();

            }


            // set the name right
            nameChar = NameNPC;

            //right render showing
            if (checkMain.boxinplace == true)
            {
                // have the right render showing up
                NpcRen.SetBool("comin", true);
            }
        }

<<<<<<< HEAD

=======
=======
>>>>>>> origin/CombatBranch
=======
>>>>>>> origin/CombatBranch
>>>>>>> origin/CombatBranch
    }

    void nexttxt1()
    {
        // if space is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            write.DeltaTime = 0f;
            write.partialtext = "";

            // go to next text
            curdiaMain1 += 1;

            // make sure the text isn't shown yet (did it since it looked weird otherwise
            checkMain.canshowtext = false;


            // if there is no next dialouge
            if (curdiaMain1 > maxdiaMain1)
            {
                // finish the text
                fintxt1();
            }
        }
    }

    void fintxt1()
<<<<<<< HEAD
<<<<<<< HEAD
    { 


        if (forJag == true)
        {
            pop.SetActive(true);
            jag.SetActive(false);
            check.pieces += 1;
            pop2.SetActive(true);
=======
=======
>>>>>>> origin/CombatBranch
    {
        if (forJag == true)
        {
            pop.SetActive(true);
            jag.SetActive(false);
            check.pieces += 1;
<<<<<<< HEAD
            pop2.SetActive(true);


            if (forJag == true)
            {
                jag.SetActive(false);
                check.pieces += 1;


            }

            bright.SetActive(false);

            india = false;


            // having the right box show up
            aniMain.SetBool("main", false);
            playRen.SetBool("coming", false);

            NPCRen.SetActive(false);
            txtboxNPC.SetActive(false);

            // reset everything
            write.DeltaTime = 0f;

            write.partialtext = "";

            curdiaMain1 = 0;
            Invoke("Delthis", 1);

            scrip.isunlocked = true;


            SceneManager.LoadScene("Combat");

        }
    }

        void startdia()
        {
            india = true;
        }

        void Delthis()
        {
            Destroy(this.gameObject);
        }
=======
<<<<<<< HEAD
>>>>>>> origin/CombatBranch
=======
>>>>>>> origin/CombatBranch
        }

        bright.SetActive(false);

        india = false;


        // having the right box show up
        aniMain.SetBool("main", false);
        playRen.SetBool("coming", false);

        NPCRen.SetActive(false);
        txtboxNPC.SetActive(false);

        // reset everything
        write.DeltaTime = 0f;

        write.partialtext = "";

        curdiaMain1 = 0;
        Invoke("Delthis", 1);

        scrip.isunlocked = true;

<<<<<<< HEAD
<<<<<<< HEAD
        SceneManager.LoadScene("Combat"); 
=======

>>>>>>> origin/CombatBranch
=======

>>>>>>> origin/CombatBranch
>>>>>>> origin/CombatBranch
    }

