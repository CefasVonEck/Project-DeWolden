using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour
{
    public GameChecker scrip;

    [SerializeField]
    private Transform PointA;

    [SerializeField]
    private Transform PointB;

    public GameObject pop;

    public GameObject bright;

    public GameObject Spin;

    public GameObject play;


    public GameObject Pop;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(PointA.position, PointB.position);

        if (distance <= 1f)
        {
            if (scrip.pieces == 2)
            {
                pop.SetActive(true);
                if(Input.GetKeyDown(KeyCode.E))
                {
                    bright.SetActive(true);
                    Spin.SetActive(true);

                    play.GetComponent<Player>().enabled = false;

                    Invoke("ConRes", 2);
                    
                }
            }
            
        }
        else
        {
            pop.SetActive(false);
        }
    }

    public void ConRes()
    {
        play.GetComponent<Player>().enabled = true;
        bright.SetActive(false);

        Pop.SetActive(true);

        Destroy(this);

    }
}
