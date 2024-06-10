using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Following_Behaviour : MonoBehaviour
{
    public GameObject player;
    public float distanceMaxFollowing = 5F;
    [SerializeField]
    private float distanceMinFollowing = 1.1F;

    public float speed = 10.0f; // Speed of movement

    private Vector3 startPosition;

    private float journeyLength;

    void Start()
    {
        startPosition = transform.position;
        journeyLength = Vector3.Distance(this.transform.position, player.transform.position);
    }

    bool stopMoving = false;

    void FixedUpdate()
    {
        // Start the movement coroutine
        if (!stopMoving)
        {
            StartCoroutine(MoveObject());
        }
        journeyLength = Vector3.Distance(this.transform.position, player.transform.position);
    }

    void Update()
    {
        if (Vector3.Distance(this.transform.position, player.transform.position) >= 0.35f && Vector3.Distance(this.transform.position, player.transform.position) < distanceMaxFollowing)
        {
            stopMoving = false;
        }
        else
        {
            stopMoving = true;
        }
    }

    IEnumerator MoveObject()
    {
        float distCovered = 1f;
        float fracJourney = 0;

        while (!stopMoving && fracJourney < 1)
        {
            // Calculate the fraction of the journey completed
            distCovered += speed * 1000f;
            fracJourney = distCovered / journeyLength;

            Vector2 distanceMinnFollowing = new Vector2(distanceMinFollowing, distanceMinFollowing);

            if (player.transform.position.x > this.transform.position.x)
            {
                distanceMinnFollowing.x = 1 - (distanceMinFollowing - 1);
            }
            else if (player.transform.position.x < this.transform.position.x)
            {
                distanceMinnFollowing.x = distanceMinFollowing;
            }
            
            if (player.transform.position.y > this.transform.position.y)
            {
                distanceMinnFollowing.y = 1 - (distanceMinFollowing - 1);
            }
            else if (player.transform.position.y < this.transform.position.y)
            {
                distanceMinnFollowing.y = distanceMinFollowing;
            }


            if(fracJourney > 0.00001f)
            {
                fracJourney = 0.00001f;
            }

            for (int i = 0; i < 8; ++i)
            {
                // Move the object smoothly towards the target position
                transform.position = Vector3.Lerp(this.transform.position, new Vector3(player.transform.position.x * distanceMinnFollowing.x, player.transform.position.y * distanceMinnFollowing.y, 0), fracJourney);
            }
            yield return null;
        }
    }
}