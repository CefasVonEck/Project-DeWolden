using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD
<<<<<<< HEAD
using TMPro;
=======
>>>>>>> origin/CombatBranch
=======
>>>>>>> origin/CombatBranch

public class GameChecker : MonoBehaviour
{
    public GameObject jag;
    public GameObject Spin;

    public GameObject Bor;

    public journalhandler scrip;

    public bool Startdone;

    public int pieces;

<<<<<<< HEAD
<<<<<<< HEAD
    public TextMeshProUGUI piec;

=======
>>>>>>> origin/CombatBranch
=======
>>>>>>> origin/CombatBranch
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
<<<<<<< HEAD
<<<<<<< HEAD

        piec.text = pieces.ToString();
=======
>>>>>>> origin/CombatBranch
=======
>>>>>>> origin/CombatBranch
    }
}
