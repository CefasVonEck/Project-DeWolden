using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TestClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // This method will be called when the mouse pointer enters the button's area
    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Mouse entered button area");
        // Add your code to perform actions when hovered
        // For example, change button color, display tooltip, etc.
        this.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void youstupidDoYouWork()
    {
        Debug.Log("Mouse entered button area");
    }
}
