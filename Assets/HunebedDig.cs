using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HunebedDig : MonoBehaviour
{
    public Transform PointA;
    public Transform PointB;

    public GameObject indi;

    public bool haspiece;

    public bool hasdug;

    public GameChecker scrip;

<<<<<<< HEAD

    public GameObject pop;


=======
<<<<<<< HEAD
<<<<<<< HEAD
    public GameObject pop;

=======
>>>>>>> origin/CombatBranch
=======
>>>>>>> origin/CombatBranch
>>>>>>> origin/CombatBranch
    // Start is called before the first frame update
    void Start()
    {
        PointA = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(PointA.position, PointB.position);

        if (distance <= 0.5 && hasdug == false)
        {
            indi.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                hasdug = true;

                if (haspiece == true)
                {
                    scrip.pieces += 1;
<<<<<<< HEAD

                    pop.SetActive(true);

=======
<<<<<<< HEAD
<<<<<<< HEAD
                    pop.SetActive(true);
=======
>>>>>>> origin/CombatBranch
=======
>>>>>>> origin/CombatBranch
>>>>>>> origin/CombatBranch
                }
            }
        }
        else
        {
            indi.SetActive(false);
        }    
    }
}
