using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rendercheck : MonoBehaviour
{

    public bool reninplace = false;

    public bool nextboxshow = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // check if the render of the character is out of the screen so next textbox can show
        if(reninplace == false)
        {
            nextboxshow = true;
        }
        else
        {
            nextboxshow = false;
        }
    }

    // the render is in the right place
    public void renplaced()
    {
        reninplace = true;
    }

    // the render is not in the right place
    public void rennotplaced()
    {
        reninplace = false;
    }

    // the render is out the screen and the next textbox can appear
    public void renoutscreen()
    {
        nextboxshow = true;
        reninplace = false;
    }

    // the render is still in the screen
    public void reninscreen()
    {
        nextboxshow = false;
    }
}
