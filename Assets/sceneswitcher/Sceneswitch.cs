using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// immportant
using UnityEngine.SceneManagement;

public class Sceneswitch : MonoBehaviour
{
    // transition animator
    //[SerializeField]
    //private Animator ani;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // collision detecting
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SceneSwitch();
        }
    }

    void SceneSwitch()
    {
        SceneManager.LoadScene("scenetest");
    }
}