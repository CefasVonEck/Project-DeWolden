using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hint : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // when this object is active
        if (this.gameObject.activeInHierarchy == true)
        {
            // after 3 seconds perform the close function
            Invoke("Close", 3);
        }
    }

    void Close()
    {
        //disable the hint
        this.gameObject.SetActive(false);
    }
}
