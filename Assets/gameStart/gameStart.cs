using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameStart : MonoBehaviour
{

    [Header("Controleable characters")]

    [SerializeField]
    private GameObject Mina;

    [SerializeField]
    private GameObject Jager;

    [Header("Game start characters")]

    [SerializeField]
    private GameObject SMina;

    [SerializeField]
    private GameObject SJager;

    [SerializeField]
    private GameObject Sspinwiefen;

    [SerializeField]
    private GameObject Swolf;

    [SerializeField]
    private GameObject SMina2;

    [SerializeField]
    private GameObject SJager2;

    [SerializeField]
    private GameObject Sspinwiefen2;

    [SerializeField]
    private GameObject Swolf2;

    [Header("Which Dialouge to start")]

    public bool Startdia1 = false;    

    public bool Startdia2 = false;    

    public bool Startdia3 = false;

    [Header("Which Dialouge are finished")]

    public bool findia1 = false;
    public bool SWapp;

    public bool findia2 = false;

    public bool findia3 = false;

    [Header("Game control shizzle")]
    [SerializeField]
    private GameObject NPC;

    [SerializeField]
    private GameObject brightness;

    public string scenename;

    public GameObject SMan;

    public GameObject cam;

    [Header("the dialouge scripts for the start dialouges")]
    public Dialouge1Start script;

    public bool checker = false;

    // Start is called before the first frame update
    void Awake()
    {
        // having all of the characters
        Jager = GameObject.FindWithTag("Jager");
        Mina = GameObject.FindWithTag("Player");
        SJager = GameObject.FindWithTag("Sjager");
        SMina = GameObject.FindWithTag("Smin");
        Sspinwiefen = GameObject.FindWithTag("Sspin");
        Swolf = GameObject.FindWithTag("Swolf");

        NPC = GameObject.FindWithTag("dia");

        cam.SetActive(false);

        if (gamecheck.finishedcom == true)
        {
            Invoke("AfterCombat", 2);

            SJager2.SetActive(true);
            SMina2.SetActive(true);
            Sspinwiefen2.SetActive(true);
            Swolf2.SetActive(true);

            SJager.SetActive(false);
            SMina.SetActive(false);
            Sspinwiefen.SetActive(false);
            Swolf.SetActive(false);

            Swolf2.GetComponent<Animator>().SetTrigger("diss");

        }

        else
        {
            // only have the characters for the start enabled
            Jager.SetActive(false);
            Mina.SetActive(false);
            SJager.SetActive(true);
            SMina.SetActive(false);
            Sspinwiefen.SetActive(false);

            brightness.SetActive(false);

            SJager2.SetActive(false);
            SMina2.SetActive(false);
            Sspinwiefen2.SetActive(false);
            Swolf2.SetActive(false);

            // moving Jager in the screen
            SJager.GetComponent<Animator>().SetTrigger("Move");
            Invoke("appearMina", 2);
        }
       
    }

    private void Start()
    {
        // had to disable because otherwise doesnt work have to find a solution for it still
        NPC.SetActive(false);

     

    }

    // Update is called once per frame
    void Update()
    {
        if (findia1 == true && SWapp == false)
        {
            Invoke("SWAppear", 1);
        }

        if (findia2 == true)
        {
            //script2.enabled = false;
            Invoke("Combatstart", 1);
            Swolf.GetComponent<Animator>().SetTrigger("app");
        }

        if (findia2 == true)
        {
            Startdia2 = false;
            script.boxes2.SetActive(false);
        }

        if (findia3 == true)
        {
            Startdia3 = false;
            script.boxes3.SetActive(false);
            FinStart();
        }

        Jager.transform.position = SJager.transform.position;
        Mina.transform.position = SMina.transform.position;

    }


    public void appearMina()
    {
        SMina.SetActive(true);
        // let Mina Character appear
        SMina.GetComponent<Animator>().SetTrigger("appear");
        // trigger first Dialouge 
        Invoke("StartDia1", 2);
    }

    void StartDia1()
    {
        // StartDialouge1
        Startdia1 = true;

    }

    void SWAppear()
    {
        // let Spinwiefen appear
        Sspinwiefen.SetActive(true);
        Sspinwiefen.GetComponent<Animator>().SetTrigger("appear");
        SWapp = true;
        // trigger second dialouge
        Invoke("StartDia2", 2);
    }

    void StartDia2()
    {
        Startdia2 = true;

    }

    void Combatstart()
    {
        // let wolves appear / trigger first combat
        Invoke("swap", 1);
    }

    void AfterCombat()
    {
        // trigger final dialouge/ move characters to final location
        Startdia3 = true;
    }

    void swap()
    {
        SceneManager.LoadScene(scenename);
    }

    void FinStart()
    {
        Sspinwiefen2.GetComponent<Animator>().SetTrigger("dis");
        Invoke("returnCon", 2);
    }

    void returnCon()
    {
        Jager.SetActive(true);
        Mina.SetActive(true);

        cam.SetActive(true);

        Destroy(SMan);

        Destroy(script.boxes2);

        Destroy(script.boxes3);
    }

}
