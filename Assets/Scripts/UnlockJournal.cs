using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockJournal : MonoBehaviour
{
    //The Player
    [SerializeField]
    private Transform pointA;

    //The Object itself(Stick Object without Render, Render(Stick Texture) is just a Tile)
    [SerializeField]
    private Transform pointB;

    //In the Journal's case, it unlocks the whole Journal. For encountering other Landmarks & Characters, it would be an Item inside the Journal(picture that now is just a Black square)
    [SerializeField]
    private GameObject unlockable;

    //This Object is a "Text" Cloud that will be visable for a short while
    [SerializeField]
    private GameObject showUpdate;
    private int showTimer = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (unlockable != null)
        {
            unlockable.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(pointA.position, pointB.position);
        if (distance < 0.5f)
        {
            if ((unlockable != null && !unlockable.active))
            {
                unlockable.SetActive(true);
            }

            if (showTimer == 0) 
            { 
                showUpdate.SetActive(true); 
                showTimer = 250; 
            }
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
