using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pageinfo : MonoBehaviour
{
    public Sprite picture;

    public string Name;

    public string Info;

    public string Storyrel;

    public pagehandler scrip;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setinfo()
    {
        scrip.NameTxt.text = Name.ToString();
        scrip.StoryTxt.text = Storyrel.ToString();
        scrip.DetailTxt.text = Info.ToString();

        scrip.pict.GetComponent<Image>().sprite = picture;
    }
}
