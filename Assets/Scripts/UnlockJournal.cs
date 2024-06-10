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
<<<<<<< HEAD


    [SerializeField]
    private bool forjournal = false;

    [SerializeField]
    private GameObject hint;

    public GameObject jourdia;


    private void Awake()
    {

        hint = GameObject.FindWithTag("HintObj");

        hint = GameObject.FindWithTag("HintObj");


        pointA = this.gameObject.transform;
    }
=======
    private int showTimer = 0;
>>>>>>> parent of bd80bc4 (Final working version)

    // Start is called before the first frame update
    void Start()
    {
        if (unlockable != null)
        {
<<<<<<< HEAD

            float distance = Vector2.Distance(pointA.position, pointB.position);
            if (distance <= 1f)
            {
                if (forjournal == true)
                {
                    scrip2.unlocked = true;
                    hint.SetActive(true);
                    jourdia.SetActive(true);
                    Destroy(showUpdate.gameObject);

                    Destroy(this.gameObject);
                }
                else

                {
                    if ((scrip.isunlocked == false))
                    {
                        scrip.isunlocked = true;

                        //enable the hint
                        hint.SetActive(true);

                        showUpdate.SetActive(true);
                        Invoke("hintdis", 2);
                    }
                }


            }


            if (forjournal == true)
            {
                if (showUpdate.activeInHierarchy == true && scrip2.unlocked == false)
                {
                    Invoke("hintdis", 3);
                }
            }

=======
            unlockable.SetActive(false);
>>>>>>> parent of bd80bc4 (Final working version)
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
