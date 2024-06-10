using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pageinfo : MonoBehaviour
{
    [SerializeField]
    private bool ischar;

    // the unlocked color
    public Color col;

    [Header("the info to set")]
    public Sprite picture;

    public string Name;

    public string Info;
  
    public string Storyrel;



    [Header("settings and stuff")]
    // the page the info needs to be on
    [SerializeField]
    public pagehandler scrip;

    public bool isunlocked = false;

<<<<<<< HEAD

=======
>>>>>>> origin/CombatBranch
    [SerializeField]
    private GameObject page;

    [SerializeField]
    private journalhandler jour;


    //[SerializeField]
    //private GameObject pop;

    // Start is called before the first frame update
    void Awake()
    {
        //set the picture of the info page the same as the button icon
        picture = GetComponent<Image>().sprite;
    }

    // Update is called once per frame
    void Update()
    {
        // if this entry is unlocked set the color to the regular color
        if (isunlocked == true)
        {
            GetComponent<Image>().color = col;
        }
    }


    // when the player enters this entry page set the information right
    public void setinfo()
    {
        if (isunlocked == true)
        {
            if (ischar == true)
            {
                jour.OpenChar();
            }
            else
            {
                jour.OpenLoc();
            }

            scrip.NameTxt.text = Name.ToString();
            scrip.StoryTxt.text = Storyrel.ToString();
            scrip.DetailTxt.text = Info.ToString();

            scrip.pict.sprite = picture;
        }
    }
}
