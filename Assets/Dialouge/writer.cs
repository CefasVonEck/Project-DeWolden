using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using TMPro;

public class writer : MonoBehaviour
{   
    // the text to write
    public string text;

    // in seconds time between the characters
    public float writeSpeed;

    [SerializeField]
    public string partialtext;

    [SerializeField]
    public float DeltaTime;

    // we have it public since this is going to be changed all the time
    public TextMeshProUGUI Towrite;

    //public bool cancon = false;


    private void Awake()
    {
        partialtext = "";
        DeltaTime = 0f;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartWriting()
    {
        //DeltaTime = 0f;
        DeltaTime += Time.deltaTime;

        while (DeltaTime >= writeSpeed && partialtext.Length < text.Length)
        {
            partialtext += text[partialtext.Length];
            DeltaTime -= writeSpeed;

            //cancon = false;
        }

        //if (partialtext.Length == text.Length)
        //{
            //cancon = true;
        //}


        Towrite.text = partialtext;
    }
}
