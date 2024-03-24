using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestClick : MonoBehaviour
{

    [SerializeField]
    private PlayerAbilities playerThings;

    [SerializeField]
    private AbilitySets enemyAttacks;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void afterPlayerAttacked()
    {
        if(enemyAttacks.getWaitingTime() + playerThings.getWaitingTime() == 0)
        {
            playerThings.PlayerAttacked();
        }
    }

    public void afterPlayerAttacked2()
    {
        if (enemyAttacks.getWaitingTime() + playerThings.getWaitingTime() == 0)
        {
            playerThings.PlayerAttacked2();
        }
    }

}