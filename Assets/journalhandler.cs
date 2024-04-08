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


    private void Awake()
    {
        jour = GameObject.FindWithTag("jour");
        charpage = GameObject.FindWithTag("charp");
        locpage = GameObject.FindWithTag("locp");
        DesCharP = GameObject.FindWithTag("DesCharP");
        DesLocP = GameObject.FindWithTag("DesLocP");
    }
    // Start is called before the first frame update
    void Start()
    {
        DesCharP.SetActive(false);
        DesLocP.SetActive(false);
        charpage.SetActive(false);
        locpage.SetActive(false);
        jour.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("j"))
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
    }

    public void Charopen()
    {
        // have the character page open
        charpage.SetActive(true);
        locpage.SetActive(false);
    }

    public void Locopen()
    {
        // have the location page open
        charpage.SetActive(false);
        locpage.SetActive(true);
    }

    public void OpenChar()
    {

    }

    public void OpenLoc()
    {

    }
}
