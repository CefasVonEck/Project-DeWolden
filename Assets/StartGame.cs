using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    [Header("character renders")]
    [SerializeField]
    private Sprite SMina;

    [Header("game control")]
    // to check if the player is in dialouge
    [SerializeField]
    public bool india = false;

    public writer write;

    [SerializeField]
    private GameObject bright;

    [SerializeField]
    private Texthandler checkMain;

    //current dia for Character
    [SerializeField]
    private int curdiaMain1 = 1;

    // max dia for Character
    [SerializeField]
    private int maxdiaMain1;

    [SerializeField]
    private UnlockJournal scrip;

    [SerializeField]
    private GameChecker check;


    [Header("animators")]
    // the animator used for showing textbox maincharacter
    [SerializeField]
    private Animator aniMain;

    // the render animation for showing in screen
    [SerializeField]
    private Animator playRen;

    [SerializeField]
    private Animator playAni;


    [Header("txtboxes and renders")]
    // the string variable for the name of the character
    [SerializeField]
    private string nameChar;

    // the textbox object
    [SerializeField]
    private GameObject txtboxmain;

    // player render picture
    [SerializeField]
    private GameObject PlayerRen;

    [Header("dialouge options part1")]
    // all dia strings and names can be easily changed in inspector this is just for testing
    [SerializeField]
    private string Dia1M = "Hey";

    [SerializeField]
    private string Dia2M = "how u doing";

    [SerializeField]
    private string Dia3M = "how u doing";

    [SerializeField]
    private string NameMain = "Mina";

    [Header("all the textmeshed")]
    // the text in game for the character to say
    [SerializeField]
    private TextMeshProUGUI diaMain;

    // the name in game for the character
    [SerializeField]
    private TextMeshProUGUI nameMain;

    public GameObject play;

    public bool dia2;

    // Start is called before the first frame update
    void Start()
    {
        // disable textbox
        txtboxmain.SetActive(false);
        PlayerRen.SetActive(false);

        MinaAppear();
        india = false;

        play.GetComponent<Player>().enabled = false;
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
            PlayerRen.GetComponent<Image>().sprite = SMina;

            write.text = Dia1M;
            bright.SetActive(true);

            // set the name right
            nameChar = NameMain;

            // having the right box show up
            aniMain.SetBool("main", true);


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
            write.Towrite = diaMain;
            write.StartWriting();
        }

        // setting first dia right
        if (curdiaMain1 == 3)
        {
            write.text = Dia3M;
            write.Towrite = diaMain;
            write.StartWriting();
        }

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
    {
        india = false;


        // having the right box show up
        aniMain.SetBool("main", false);
        playRen.SetBool("coming", false);

        // reset everything
        write.DeltaTime = 0f;

        write.partialtext = "";

        curdiaMain1 = 0;
        Invoke("Delthis", 1);

        if(dia2 == true)
        {
            check.Startdone = true;
        }

        play.GetComponent<Player>().enabled = true;

    }

    void MinaAppear()
    {
        playAni.SetTrigger("Appear");
        Invoke("startgame", 1.5f);
    }

    void startgame()
    {
        india = true;
    }

    void Delthis()
    {
        scrip.hinten();
        Destroy(this.gameObject);
    }
}
