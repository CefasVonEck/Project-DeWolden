using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endgame : MonoBehaviour
{
    public GameChecker scrip;

    [SerializeField]
    private Transform PointA;

    [SerializeField]
    private Transform PointB;

    public GameObject choice;

    public GameObject pop;

    public GameObject dia;

    public GameObject play;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector2.Distance(PointA.position, PointB.position);
        if (distance <= 0.5f)
        {
            pop.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                choice.SetActive(true);
                play.GetComponent<Player>().enabled = false;
            }
        }
    }

    public void ChoNo()
    {
        choice.SetActive(false);
        play.GetComponent<Player>().enabled = true;
    }

    public void ChoYes()
    {
        choice.SetActive(false);
        dia.SetActive(true);

    }
}
