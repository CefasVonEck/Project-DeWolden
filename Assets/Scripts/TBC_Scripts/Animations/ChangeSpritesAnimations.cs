using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSpritesAnimations : MonoBehaviour
{
    [SerializeField]
    private GameObject thisCanvas;
    [SerializeField]
    private GameObject battleCanvas;

    [SerializeField]
    private Following_Behaviour followScript;

    [SerializeField]
    private GameObject orgObject;
    [SerializeField]
    private GameObject spriteOne;
    [SerializeField]
    private GameObject spriteTwo;

    private int switchSpriteTimer = 0;
    private Vector3 orgPosition = new Vector3(0,0,0);

    // Start is called before the first frame update
    void Start()
    {
        if(spriteOne != null)
        {
            spriteOne.SetActive(true);
        }

        if (spriteTwo != null)
        {
            spriteTwo.SetActive(false);
        }

        if (followScript != null && orgObject != null)
        {
            orgPosition = orgObject.transform.position;
            followScript.distanceMaxFollowing = 0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (switchSpriteTimer < 650)
        {
            ++switchSpriteTimer;

            if (followScript != null && switchSpriteTimer == 5)
            {
                followScript.distanceMaxFollowing = 5000f;
            }

            if (switchSpriteTimer == 150)
            {
                if (spriteOne != null)
                {
                    spriteOne.SetActive(false);
                }

                if (spriteTwo != null)
                {
                    spriteTwo.SetActive(true);
                }
            }



            if (switchSpriteTimer == 649)
            {
                if (spriteOne != null)
                {
                    spriteOne.SetActive(true);
                }

                if (spriteTwo != null)
                {
                    spriteTwo.SetActive(false);
                }

                if(orgObject != null)
                {
                    orgObject.transform.position = orgPosition;
                }

                if (followScript != null)
                {
                    followScript.distanceMaxFollowing = 0f;
                }

                switchSpriteTimer = 0;

                if(thisCanvas != null && battleCanvas != null)
                {
                    thisCanvas.SetActive(false);
                    battleCanvas.SetActive(true);
                }
            }
        }
    }  
}