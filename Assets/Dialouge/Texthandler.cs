using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Texthandler : MonoBehaviour
{
    public bool canshowtext = false;

    public bool boxinplace = false;

    public rendercheck check;

    public bool rengone = false;

    [SerializeField]
    private writer scrip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // check if the character render is in the right place so the text can appear otherwise it can't appear
        if (check.reninplace == true)
        {
            canshowtext = true;
        }
        else
        {
            canshowtext = false;
        }

        // check if the next text box can show
        if (check.nextboxshow == true)
        {
            rengone = true;
        }
        else
        {
            rengone = false;
        }
    }

    // for the text box being in the right place
    public void InPlace()
    {
        boxinplace = true;
    }

    // for the textbox not being in the right place
    public void NotInplace()
    {
        boxinplace = false;
        canshowtext = false;
        //scrip.partialtext = "";
    }

    public void ResTex()
    {
        scrip.partialtext = "";
    }
}
