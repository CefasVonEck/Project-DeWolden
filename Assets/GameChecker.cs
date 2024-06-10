using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class GameChecker : MonoBehaviour
{
    public GameObject jag;
    public GameObject Spin;

    public GameObject Bor;

    public journalhandler scrip;

    public bool Startdone;

    public int pieces;

    public TextMeshProUGUI piec;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (scrip.unlocked == true)
        {
            Startdone = true;

            jag.SetActive(true);
            Spin.SetActive(true);
            Bor.SetActive(false);
        }
        else
        {
            jag.SetActive(false);
            Spin.SetActive(false);
        }


        piec.text = pieces.ToString();

    }
}
