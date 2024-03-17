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
    private TextMeshProUGUI Attack1;
    [SerializeField]
    private TextMeshProUGUI Attack2;



    // Start is called before the first frame update
    void Start()
    {
        Attack1.text = abilityName;
        Attack2.text = abilityName2;
    }

    public void PlayerAttacked()
    {
        attackAgainTimer = 350;
        healthEnemy.SetSliderValue(attackDamage1 + attackDamageBoost1);
        //--maxAbilityUse;

        UseMessage.text = enemyName + " Used " + abilityName + " and it hit!";
    }

    public void PlayerAttacked2()
    {
        attackAgainTimer = 350;
        enemyAbilities.reduceAttackSpeed(-25f);
        //--maxAbilityUse;

        UseMessage.text = enemyName + " Used " + abilityName2 + " and it hit!";
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

                UseMessage.text = enemyName + " Used " + abilityName + " and it hit!";
            }
            else
            {
                healthEnemy.SetSliderValue(attackDamage2 + attackDamageBoost2);

                UseMessage.text = enemyName + " Used " + abilityName2 + " and it hit!";
            }
        }

        if (attackAgainTimer > 0)
        {
            --attackAgainTimer;
            //Debug.Log(attackAgainTimer);
        }
    }

}
