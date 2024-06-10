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

    public GameObject pop;

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
                    pop.SetActive(true);
                }
            }
        }
        else
        {
            indi.SetActive(false);
        }    
    }
}
