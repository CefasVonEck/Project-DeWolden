using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class journalhandler : MonoBehaviour
{
    [SerializeField]
    private GameObject jour;

    [SerializeField]
    private GameObject charpage;

    [SerializeField]
    private GameObject locpage;

    [SerializeField]
    private GameObject DesCharP;

    [SerializeField]
    private GameObject DesLocP;

    [SerializeField]
    private dialouge check;

    [SerializeField]
    private GameObject hin;


    private void Awake()
    {
        jour = GameObject.FindWithTag("jour");
        charpage = GameObject.FindWithTag("charp");
        locpage = GameObject.FindWithTag("locp");
        DesCharP = GameObject.FindWithTag("DesCharP");
        DesLocP = GameObject.FindWithTag("DesLocP");

        hin = GameObject.FindWithTag("jourh");

        DesCharP.SetActive(false);
        DesLocP.SetActive(false);
        charpage.SetActive(false);
        locpage.SetActive(false);
        jour.SetActive(false);
        hin.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(check.hastalked == true)
        {
            hin.SetActive(true);
        }

        if (Input.GetKeyDown("j") && check.hastalked == true)
        {
            if (jour.activeInHierarchy == false)
            {
                OpenJour();
            }
        }
    }

    void OpenJour()
    {
        // open the journal
        jour.SetActive(true);
       
        // pause the game
        Time.timeScale = 0f;
        Cursor.lockState = CursorLockMode.None;
    }

    public void CloseJour()
    {
        // close the journal
        jour.SetActive(false);
        // unpause the game
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;

        DesCharP.SetActive(false);
        DesLocP.SetActive(false);
        charpage.SetActive(false);
        locpage.SetActive(false);

    }

    public void Charopen()
    {
        // have the character page open
        charpage.SetActive(true);
        locpage.SetActive(false);

        DesCharP.SetActive(false);
        DesLocP.SetActive(false);
    }

    public void Locopen()
    {
        // have the location page open
        charpage.SetActive(false);
        locpage.SetActive(true);

        DesCharP.SetActive(false);
        DesLocP.SetActive(false);
    }

    public void OpenChar()
    {
        DesCharP.SetActive(true);
        charpage.SetActive(false);
        locpage.SetActive(false);
        DesLocP.SetActive(false);
    }

    public void OpenLoc()
    {
        DesCharP.SetActive(false);
        charpage.SetActive(false);
        locpage.SetActive(false);
        DesLocP.SetActive(true);
    }
}
