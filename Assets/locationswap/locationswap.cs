using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
// Scenemanager

public class locationswap : MonoBehaviour
{
    [Tooltip ("put the name of the scene in here")]
    [SerializeField]
    private string sceneName;

    // the text pop up
    [SerializeField]
    private GameObject pop;

    // the overlay for switcing scenes
    [SerializeField]
    private GameObject Over;

    // the name of the location to travel too
    [SerializeField]
    private string loc;

    [SerializeField]
    private TextMeshProUGUI Name;

    [SerializeField]
    private GameObject Play;

    [SerializeField]
    private float moveSpeed;

    public Vector2 Direction;

    [SerializeField]
    private bool canmove;

    [SerializeField]
    private bool enteredTrigger;


    private void Awake()
    {
        pop = GameObject.FindWithTag("locpop");
        Over = GameObject.FindWithTag("Over");
        Play = GameObject.FindWithTag("Player");
        pop.SetActive(false);
        Over.SetActive(false);
        canmove = false;
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (canmove == true)
        {
            //move the player out of the scene
            Play.transform.Translate(moveSpeed * Time.deltaTime * Direction);
        }

        if (enteredTrigger == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                clickyes();
            }
        }
    }

    // during collision
    public void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            // show pop up
            pop.SetActive(true);
            //Time.timeScale = 0f;

            Name.text = loc.ToString();

            enteredTrigger = true;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (pop.activeInHierarchy == true)
            {
                pop.SetActive(false);
            }
            enteredTrigger = false;
        }
    }

    // if clicked yes move to location
    public void clickyes()
    {

        //show a black overlay
        Over.SetActive(true);
        pop.SetActive(false);        
        canmove = true;
        Invoke("changescene", 2);
        Invoke("Res", 1);
    }

    public void changescene()
    {
        // change the scene
        SceneManager.LoadScene(sceneName);
    }

    public void Res()
    {
        canmove = false;
    }
}
