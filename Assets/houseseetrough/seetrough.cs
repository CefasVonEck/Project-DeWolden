using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seetrough : MonoBehaviour
{
    // the sprite
    [SerializeField]
    private SpriteRenderer render;

    [SerializeField]
    private Color invis;

    [SerializeField]
    private Color regular;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    // changing the opacity of the sprite
    void Opacchange()
    {
        // make it more see trough
        render.color = invis;
    }

    // reset the opacity
    void Opaback()
    {
        // make it 
        render.color = regular;
    }

    // chaning opacity when player is entering building
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Opacchange();
        }
    }

    // changing opacity when player is existing building
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Opaback();
        }
    }
}
