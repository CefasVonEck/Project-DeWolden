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

    // setting it active on the 
    [SerializeField]
    private Pageinfo scrip;

    // setting it active on the 
    [SerializeField]
    private journalhandler scrip2;

    //In the Journal's case, it unlocks the whole Journal. For encountering other Landmarks & Characters, it would be an Item inside the Journal(picture that now is just a Black square)
    [SerializeField]
    private GameObject unlockable;


    //This Object is a "Text" Cloud that will be visable for a short while
    [SerializeField]
    private GameObject showUpdate;


    [SerializeField]
    private bool forjournal = false;

    [SerializeField]
    private GameObject hint;

    public GameObject jourdia;


    private void Awake()
    {

        pointA = this.gameObject.transform;
    }

    // Start is called before the first frame update
    void Start()
        { 
            hint.SetActive(false);
            showUpdate.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {

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

        }

     void hintdis()
    {
        showUpdate.SetActive(false);
        Invoke("hinten", 10);
    }

    public void hinten()
    {
        showUpdate.SetActive(true);
    }

}


