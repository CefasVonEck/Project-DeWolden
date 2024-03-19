using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.Text.RegularExpressions;

public class AbilitySets : MonoBehaviour
{
    [SerializeField]
    private float attackSpeed = 0;
    [SerializeField]
    private float maxAttackSpeed = 0;


    private int waitingMessage = 0;


    [SerializeField]
    private SliderController healthMina;

    private static int attackAgainTimer = 0;

    [SerializeField]
    private String enemyName = "";

    [SerializeField]
    private String abilityName = "";
    [SerializeField]
    private int attackDamage1 = 0;
    [SerializeField]
    private int agileDamage1 = 0;
    [SerializeField]
    private int attackDamageBoost1 = 0;
    [SerializeField]
    private int maxAbilityUse = 0;
    [SerializeField]
    private int changeBeingUsed = 0;


    [SerializeField]
    private String abilityName2 = "";
    [SerializeField]
    private int attackDamage2 = 0;
    [SerializeField]
    private int agileDamage2 = 0;
    [SerializeField]
    private int attackDamageBoost2 = 0;


    [SerializeField]
    private TextMeshProUGUI UseMessage;

    [SerializeField]
    private String startBattleMessage = "";

    private float countExtraDamage = 0;

    // Start is called before the first frame update
    void Start() 
    {
        attackAgainTimer = 200;
        UseMessage.text = enemyName + " " + startBattleMessage;
    }

    public int getWaitingTime()
    {
        return waitingMessage + attackAgainTimer;
    }

    public static void afterPlayerAttacked()
    {
        attackAgainTimer = 150;
    }

    public void reduceAttackSpeed(float speed)
    {
        attackSpeed -= speed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(attackAgainTimer == 1)
        {
            if(UnityEngine.Random.Range(0, 100 - (int)(attackSpeed / 2f)) <= 5)
            {
                UseMessage.text = enemyName + " tried to attack and missed!";
                waitingMessage = 150;
            }
            else if (UnityEngine.Random.Range(1,131) >= (int)(changeBeingUsed - (attackSpeed / 2f)) && maxAbilityUse > 0)
            {
                if(attackDamageBoost1 > 0)
                {
                    countExtraDamage += attackDamageBoost1;
                }
                else
                {
                    healthMina.SetSliderValue(attackDamage1 + countExtraDamage);
                }

                --maxAbilityUse;

                UseMessage.text = enemyName + " Used " + abilityName + " and it hit!";

                waitingMessage = 100;
            }
            else
            {
                if (attackDamageBoost2 > 0)
                {
                    countExtraDamage += attackDamageBoost2;
                }
                else
                {
                    healthMina.SetSliderValue(attackDamage2 + countExtraDamage);
                }

                UseMessage.text = enemyName + " Used " + abilityName2 + " and it hit!";

                waitingMessage = 100;
            }
        }

        if(attackSpeed < maxAttackSpeed)
        {
            attackSpeed += 0.1f;
        }

        if (attackAgainTimer > 0)
        {
            --attackAgainTimer;
            //Debug.Log(attackAgainTimer);
        } 

        if(waitingMessage > 0)
        {
            --waitingMessage;
            if(waitingMessage == 0)
            {
                UseMessage.text = "Waiting for the Player to make a move...";
            }
        }
    }
        
}
