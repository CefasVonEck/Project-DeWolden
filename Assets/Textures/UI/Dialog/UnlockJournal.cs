using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockJournal : MonoBehaviour
{
    [SerializeField]
    private Transform pointA;

    [SerializeField]
    private Transform pointB;

    [SerializeField]
    private GameObject unlockable;

    [SerializeField]
    private GameObject showUpdate;
    private int showTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        unlockable.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(pointA.position, pointB.position);
        if (!unlockable.active && distance < 0.5f)
        {
            unlockable.SetActive(true);
            showUpdate.SetActive(true);
            showTimer = 250;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(showTimer > 0)
        {
            --showTimer;

            if(showTimer == 1)
            {
                showUpdate.SetActive(false);
            }
        }
    }
}
