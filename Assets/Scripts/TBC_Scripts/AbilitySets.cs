using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.Text.RegularExpressions;

public class AbilitySets : MonoBehaviour
{
    [SerializeField]
    private bool abilitySpeedIsKing = false;

    [SerializeField]
    private float attackSpeed = 0;
    [SerializeField]
    private float maxAttackSpeed = 0;

    private int waitingMessage = 0;


    [SerializeField]
    private SliderController healthMina;

    [SerializeField]
    private PlayerAbilities PlayerAbilities;

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
    private String attackUseMessage = null;
    [SerializeField]
    private bool canMiss = true;

    [SerializeField]
    private String abilityName2 = "";
    [SerializeField]
    private int attackDamage2 = 0;
    [SerializeField]
    private int agileDamage2 = 0;
    [SerializeField]
    private int attackDamageBoost2 = 0;
    [SerializeField]
    private int maxAbilityUse2 = 0;
    [SerializeField]
    private int changeBeingUsed2 = 0;
    [SerializeField]
    private String attackUseMessage2 = null;
    [SerializeField]
    private bool canMiss2 = true;

    [SerializeField]
    private String abilityNameLast = "";
    [SerializeField]
    private int attackDamageLast = 0;
    [SerializeField]
    private int agileDamageLast = 0;
    [SerializeField]
    private int attackDamageBoostLast = 0;

    [SerializeField]
    private TextMeshProUGUI UseMessage;

    [SerializeField]
    private String startBattleMessage = "";

    private float countExtraDamage = 0;
    
    // Start is called before the first frame update
    void Start() 
    {
        if(!abilitySpeedIsKing)
        {
            attackAgainTimer = 200;
        }
        else
        {
            waitingMessage = 200;
        }

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
        if(attackSpeed < 120)
        {
            attackSpeed -= speed;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(attackAgainTimer == 1)
        {
            if(UnityEngine.Random.Range(0, 100 - (int)(attackSpeed)) <= 5)
            {
                UseMessage.text = enemyName + " tried to attack and missed!";
                waitingMessage = 150;
            }
            else if ((UnityEngine.Random.Range(1,131) >= (int)(changeBeingUsed - (attackSpeed)) || !canMiss || (attackDamage1 > 3 && healthMina.getValue() < 20)) && maxAbilityUse > 0)
            {
                if(attackDamageBoost1 > 0)
                {
                    countExtraDamage += attackDamageBoost1;
                }
                else
                {
                    healthMina.SetSliderValue(attackDamage1 + countExtraDamage);
                }

                PlayerAbilities.decreaseHittingAbility(agileDamage1);

                --maxAbilityUse;

                if (attackUseMessage != null && !(attackUseMessage.Equals("")))
                {
                    UseMessage.text = enemyName + " Used <i>" + abilityName + "</i>" + attackUseMessage;
                }
                else
                {
                    UseMessage.text = enemyName + " Used <i>" + abilityName + "</i>" + " and it hit!";
                }

                waitingMessage = 200;
            }
            else if ((UnityEngine.Random.Range(1, 131) >= (int)(changeBeingUsed2 - (attackSpeed / 2f)) || !canMiss2 || (attackDamage2 > 3 && healthMina.getValue() < 20)) && maxAbilityUse2 > 0)
            {
                if (attackDamageBoost2 > 0)
                {
                    countExtraDamage += attackDamageBoost2;
                }
                else
                {
                    healthMina.SetSliderValue(attackDamage2 + countExtraDamage);
                }

                PlayerAbilities.decreaseHittingAbility(agileDamage2);

                --maxAbilityUse2;

                if (attackUseMessage2 != null && !(attackUseMessage2.Equals("")))
                {
                    UseMessage.text = enemyName + " Used <i>" + abilityName2 + "</i>" + attackUseMessage2;
                }
                else
                {
                    UseMessage.text = enemyName + " Used <i>" + abilityName2 + "</i>" + " and it hit!";
                }

                waitingMessage = 200;
            }
            else
            {
                if (attackDamageBoostLast > 0)
                {
                    countExtraDamage += attackDamageBoostLast;
                }
                else
                {
                    healthMina.SetSliderValue(attackDamageLast + countExtraDamage);
                }

                PlayerAbilities.decreaseHittingAbility(agileDamageLast);

                UseMessage.text = enemyName + " Used <i>" + abilityNameLast + "</i>" + " and it hit!";

                waitingMessage = 200;
            }
        }

        if(attackSpeed > maxAttackSpeed)
        {
            attackSpeed -= 0.001f;
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
