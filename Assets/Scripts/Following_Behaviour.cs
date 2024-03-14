using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Following_Behaviour : MonoBehaviour
{
    public GameObject player;
    public float distanceMaxFollowing = 5F;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float distance = Vector3.Distance(player.transform.position, this.transform.position);

        if (distance < distanceMaxFollowing)
        {

            float distanceX = Vector3.Distance(new Vector3(player.transform.position.x, 0, 0), new Vector3(this.transform.position.x, 0, 0));
            float distanceZ = Vector3.Distance(new Vector3(0, 0, player.transform.position.y), new Vector3(0, 0, this.transform.position.y));

            float speed = (0.025f * distance);

            Vector3 thisEntity = this.transform.position;

            if (distance > 0.5F && distanceX > distanceZ)
            {
                if (player.transform.position.x > this.transform.position.x)
                {
                    thisEntity = new Vector3(thisEntity.x + speed, thisEntity.y, thisEntity.z);
                }
                else if (player.transform.position.x < this.transform.position.x)
                {
                    thisEntity = new Vector3(thisEntity.x - speed, thisEntity.y, thisEntity.z);
                }
            }
            else if (distance > 0.5F)
            {
                if (player.transform.position.y > this.transform.position.y)
                {
                    thisEntity = new Vector3(thisEntity.x, thisEntity.y + speed, thisEntity.z);
                }
                else if (player.transform.position.y < this.transform.position.y)
                {
                    thisEntity = new Vector3(thisEntity.x, thisEntity.y - speed, thisEntity.z);
                }
            }

            this.transform.position = thisEntity;

            //this.transform.position = new Vector3(thisEntity.x - 0.5f, thisEntity.y, thisEntity.z);

            Debug.Log(" dfgdffdgfydsfhyudfuifeyygrus");
        }
    }
}
