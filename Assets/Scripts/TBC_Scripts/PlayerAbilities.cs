using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.Text.RegularExpressions;

public class PlayerAbilities : MonoBehaviour
{
    [SerializeField]
    private SliderController healthEnemy;

    [SerializeField]
    private AbilitySets enemyAbilities;

    private int attackAgainTimer = 0;

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
    private String attackUseMessage2 = null;
    [SerializeField]
    private bool canMiss2 = true;

    [SerializeField]
    private String abilityName3 = "";
    [SerializeField]
    private int attackDamage3 = 0;
    [SerializeField]
    private int agileDamage3 = 0;
    [SerializeField]
    private int attackDamageBoost3 = 0;
    [SerializeField]
    private String attackUseMessage3 = null;
    [SerializeField]
    private bool canMiss3 = true;

    [SerializeField]
    private String abilityName4 = "";
    [SerializeField]
    private int attackDamage4 = 0;
    [SerializeField]
    private int agileDamage4 = 0;
    [SerializeField]
    private int attackDamageBoost4 = 0;
    [SerializeField]
    private String attackUseMessage4 = null;
    [SerializeField]
    private bool canMiss4 = true;

    private int attackDamageBoost = 0;


    [SerializeField]
    private TextMeshProUGUI UseMessage;

    [SerializeField]
    private TextMeshProUGUI Attack1;
    [SerializeField]
    private TextMeshProUGUI Attack2;

    [SerializeField]
    private TextMeshProUGUI Attack3;
    [SerializeField]
    private TextMeshProUGUI Attack4;

    private int missAbiblityChanges = 0;

    // Start is called before the first frame update
    void Start()
    {
        Attack1.text = abilityName;
        Attack2.text = abilityName2;
        Attack3.text = abilityName3;
        Attack4.text = abilityName4;
    }

    public void decreaseHittingAbility(int decreaseWith)
    {
        if (missAbiblityChanges < 85)
        {
            missAbiblityChanges += decreaseWith;
        }
    }

    public int getWaitingTime()
    {
        return  attackAgainTimer;
    }

    public void PlayerAttacked()
    {
        if (UnityEngine.Random.Range(0, 100 - missAbiblityChanges) <= 5 && canMiss)
        {
            UseMessage.text = enemyName + " tried to attack and missed!";
            attackAgainTimer = 250;
        }
        else if (enemyAbilities.getWaitingTime() + this.getWaitingTime() == 0)
        {
            attackAgainTimer = 450;

            if (attackDamage1 > 0)
            {
                healthEnemy.SetSliderValue(attackDamage1 + attackDamageBoost);
            }

            if(attackDamageBoost1 > 0)
            {
                healthEnemy.SetSliderValue(attackDamage1 + attackDamageBoost);
            }

            decreaseHittingAbility(agileDamage1);
            //--maxAbilityUse;

            if (attackUseMessage != null && !(attackUseMessage.Equals("")))
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName + "</i>" + attackUseMessage;
            }
            else
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName + "</i>" + " and it hit!";
            }
        }
    }

    public void PlayerAttacked2()
    {
        if (UnityEngine.Random.Range(0, 100) <= 5 && canMiss2)
        {
            UseMessage.text = enemyName + " tried to attack and missed!";
            attackAgainTimer = 250;
        }
        else if (enemyAbilities.getWaitingTime() + this.getWaitingTime() == 0)
        {
            attackAgainTimer = 450;

            if (attackDamage2 > 0)
            {
                healthEnemy.SetSliderValue(attackDamage2 + attackDamageBoost);
            }

            if (attackDamageBoost2 > 0)
            {
                attackDamageBoost += attackDamageBoost2;
            }

            enemyAbilities.reduceAttackSpeed(agileDamage2);

            //--maxAbilityUse;

            if (attackUseMessage2 != null && !(attackUseMessage2.Equals("")))
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName2 + "</i>" + attackUseMessage2;
            }
            else
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName2 + "</i>" + " and it hit!";
            }
        }
    }

    public void PlayerAttacked3()
    {
        if (UnityEngine.Random.Range(0, 100) <= 5 && canMiss3)
        {
            UseMessage.text = enemyName + " tried to attack and missed!";
            attackAgainTimer = 250;
        }
        else if (enemyAbilities.getWaitingTime() + this.getWaitingTime() == 0)
        {
            attackAgainTimer = 450;

            if (attackDamage3 > 0)
            {
                healthEnemy.SetSliderValue(attackDamage3 + attackDamageBoost);
            }

            if (attackDamageBoost3 > 0)
            {
                attackDamageBoost += attackDamageBoost3;
            }

            enemyAbilities.reduceAttackSpeed(agileDamage3);
            //--maxAbilityUse;

            if (attackUseMessage3 != null && !(attackUseMessage3.Equals("")))
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName3 + "</i>" + attackUseMessage3;
            }
            else
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName3 + "</i>" + " and it hit!";
            }
        }
    }

    public void PlayerAttacked4()
    {
        if (UnityEngine.Random.Range(0, 100) <= 5 && canMiss4)
        {
            UseMessage.text = enemyName + " tried to attack and missed!";
            attackAgainTimer = 250;
        }
        else if (enemyAbilities.getWaitingTime() + this.getWaitingTime() == 0)
        {
            attackAgainTimer = 450;

            if (attackDamage4 > 0)
            {
                healthEnemy.SetSliderValue(attackDamage4 + attackDamageBoost);
            }

            if (attackDamageBoost4 > 0)
            {
                attackDamageBoost += attackDamageBoost4;
            }

            enemyAbilities.reduceAttackSpeed(agileDamage4);
            //--maxAbilityUse;

            if (attackUseMessage4 != null && !(attackUseMessage4.Equals("")))
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName4 + "</i>" + attackUseMessage4;
            }
            else
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName4 + "</i>" + " and it hit!";
            }
        }
    }

    void FixedUpdate()
    {
        if (attackAgainTimer > 0)
        {
            --attackAgainTimer;
            //Debug.Log(attackAgainTimer);
        }

        if (attackAgainTimer == 150)
        {
            AbilitySets.afterPlayerAttacked();
            UseMessage.text = "Enemy waiting its turn...";
        }
    }

    // Update is called once per frame
    void FixedUpdate2()
    {
        if (attackAgainTimer == 1)
        {
            if (UnityEngine.Random.Range(0, (float)changeBeingUsed) == 0.0f && maxAbilityUse > 0)
            {
                healthEnemy.SetSliderValue(attackDamage1 + attackDamageBoost1);
                --maxAbilityUse;

                UseMessage.text = enemyName + " Used <i>" + abilityName + "</i>" + " and it hit!";
            }
            else
            {
                healthEnemy.SetSliderValue(attackDamage2 + attackDamageBoost2);

                UseMessage.text = enemyName + " Used <i>" + abilityName2 + "</i>" + " and it hit!";
            }
        }

        if (attackAgainTimer > 0)
        {
            --attackAgainTimer;
            //Debug.Log(attackAgainTimer);
        }
    }

}
