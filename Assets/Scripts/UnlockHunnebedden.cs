using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnlockHunnebedden : MonoBehaviour
{
    [SerializeField]
    private Collider2D col;

    // setting it active on the 
    [SerializeField]
    private Pageinfo scrip;

    [SerializeField]
    private GameObject hint;

    private void Awake()
    {
        hint = GameObject.FindWithTag("HintObj");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if ((scrip.isunlocked == false))
            {
                scrip.isunlocked = true;

                //enable the hint
                hint.SetActive(true);
            }
        }
    }
}
