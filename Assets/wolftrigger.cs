using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wolftrigger : MonoBehaviour
{
    public Animator ani;

    public GameObject play;

    public Pageinfo scrip;

    public GameObject hint;

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
            ani.SetTrigger("ani");
            play.GetComponent<Player>().enabled = false;
            Invoke("Des", 2);
        }
    }

    void Des()
    {
        hint.SetActive(true);
        play.GetComponent<Player>().enabled = true;
        scrip.isunlocked = true;
        Destroy(this.gameObject);

    }
}
