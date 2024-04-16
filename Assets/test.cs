using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            gamecheck.finishedcom = true;
            Invoke("change", 1);
        }

        DontDestroyOnLoad(this);
    }

    void change()
    {
        SceneManager.LoadScene("TestLevelScene");
    }
}
