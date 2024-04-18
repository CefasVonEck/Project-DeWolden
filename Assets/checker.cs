using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checker : MonoBehaviour
{
    public Animator ani;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Sani()
    {
        ani.SetBool("move", true);
    }
    public void Eani()
    {
        ani.SetBool("move", false);
    }
}
