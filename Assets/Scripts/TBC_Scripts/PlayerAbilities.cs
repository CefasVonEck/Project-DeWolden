using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using System.Text.RegularExpressions;

public class PlayerAbilities : MonoBehaviour
{
    [SerializeField]
    private bool abilitySpeedIsKing = false;

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
    private String userName1 = "";
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
    private String userName2 = "";
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
    private String userName3 = "";
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
    private String userName4 = "";
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
        if (abilityName != null && !abilityName.Equals(""))
        {
            Attack1.text = abilityName;
        }

        if (abilityName2 != null && !abilityName2.Equals(""))
        {
            Attack2.text = abilityName2;
        }

        if(abilityName3 != null && !abilityName3.Equals(""))
        {
            Attack3.text = abilityName3;
        }

        if (abilityName4 != null && !abilityName4.Equals(""))
        {
            Attack4.text = abilityName4;
        }
    }

    public void abilityInfo1()
    {
        if(!(Attack1.text.Contains(":")))
        {
            if(attackDamage1 > 0 && agileDamage1 > 0 && attackDamageBoost1 > 0)
            {
                Attack1.text += ":  <i> Att. " + attackDamage1 + "  Accur. " + agileDamage1 + "  DMG+ " + attackDamageBoost1;
            }
            else if (agileDamage1 > 0 && attackDamageBoost1 > 0)
            {
                Attack1.text += ":  <i> Accur. " + agileDamage1 + "  DMG+ " + attackDamageBoost1;
            }
            else if (attackDamage1 > 0 && attackDamageBoost1 > 0)
            {
                Attack1.text += ":  <i> Att. " + attackDamage1 + "  DMG+ " + attackDamageBoost1;
            }
            else if (attackDamage1 > 0 && attackDamageBoost1 > 0)
            {
                Attack1.text += ":  <i> Att. " + attackDamage1 + "  Accur. " + agileDamage1;
            }
            else if (attackDamageBoost1 > 0 && agileDamage1 <= 0 && attackDamage1 <= 0)
            {
                Attack1.text += ":  <i>DMG+ " + attackDamageBoost1;
            }
            else if (attackDamageBoost1 <= 0 && agileDamage1 > 0 && attackDamage1 <= 0)
            {
                Attack1.text += ":  <i>Accur. " + agileDamage1;
            }
            else
            {
                Attack1.text += ":  <i> Att. " + attackDamage1;
            }
        }
        else if (Attack1.text.Contains(":"))
        {
            string[] parts = Attack1.text.Split(':');

            // Take the first part (before the colon)
            string modifiedString = parts[0];

            Attack1.text = modifiedString;
        }
    }

    public void abilityInfo2()
    {
        if (!(Attack2.text.Contains(":")))
        {
            if (attackDamage2 > 0 && agileDamage2 > 0 && attackDamageBoost2 > 0)
            {
                Attack2.text += ":  <i> Att. " + attackDamage2 + "  Accur. " + agileDamage2 + "  DMG+ " + attackDamageBoost2;
            }
            else if (agileDamage2 > 0 && attackDamageBoost2 > 0)
            {
                Attack2.text += ":  <i> Accur. " + agileDamage2 + "  DMG+ " + attackDamageBoost2;
            }
            else if (attackDamage2 > 0 && attackDamageBoost2 > 0)
            {
                Attack2.text += ":  <i> Att. " + attackDamage2 + "  DMG+ " + attackDamageBoost2;
            }
            else if (attackDamage2 > 0 && attackDamageBoost2 > 0)
            {
                Attack2.text += ":  <i> Att. " + attackDamage2 + "  Accur. " + agileDamage2;
            }
            else if (attackDamageBoost2 > 0 && agileDamage2 <= 0 && attackDamage2 <= 0)
            {
                Attack2.text += ":  <i>DMG+ " + attackDamageBoost2;
            }
            else if (attackDamageBoost2 <= 0 && agileDamage2 > 0 && attackDamage2 <= 0)
            {
                Attack2.text += ":  <i>Accur. " + agileDamage2;
            }
            else
            {
                Attack2.text += ":  <i> Att. " + attackDamage2;
            }
        }
        else if (Attack2.text.Contains(":"))
        {
            string[] parts = Attack2.text.Split(':');

            // Take the first part (before the colon)
            string modifiedString = parts[0];

            Attack2.text = modifiedString;
        }
    }

    public void abilityInfo3()
    {
        if (!(Attack3.text.Contains(":")))
        {
            if (attackDamage3 > 0 && agileDamage3 > 0 && attackDamageBoost3 > 0)
            {
                Attack3.text += ":  <i> Att. " + attackDamage3 + "  Accur. " + agileDamage3 + "  DMG+ " + attackDamageBoost3;
            }
            else if (agileDamage3 > 0 && attackDamageBoost3 > 0)
            {
                Attack3.text += ":  <i> Accur. " + agileDamage3 + "  DMG+ " + attackDamageBoost3;
            }
            else if (attackDamage3 > 0 && attackDamageBoost3 > 0)
            {
                Attack3.text += ":  <i> Att. " + attackDamage3 + "  DMG+ " + attackDamageBoost3;
            }
            else if (attackDamage3 > 0 && attackDamageBoost3 > 0)
            {
                Attack3.text += ":  <i> Att. " + attackDamage3 + "  Accur. " + agileDamage3;
            }
            else if (attackDamageBoost3 > 0 && agileDamage3 <= 0 && attackDamage3 <= 0)
            {
                Attack3.text += ":  <i>DMG+ " + attackDamageBoost3;
            }
            else if (attackDamageBoost3 <= 0 && agileDamage3 > 0 && attackDamage3 <= 0)
            {
                Attack3.text += ":  <i>Accur. " + agileDamage3;
            }
            else
            {
                Attack3.text += ":  <i> Att. " + attackDamage3;
            }
        }
        else if (Attack3.text.Contains(":"))
        {
            string[] parts = Attack3.text.Split(':');

            // Take the first part (before the colon)
            string modifiedString = parts[0];

            Attack3.text = modifiedString;
        }
    }

    public void abilityInfo4()
    {
        if (!(Attack4.text.Contains(":")))
        {
            if (attackDamage4 > 0 && agileDamage4 > 0 && attackDamageBoost4 > 0)
            {
                Attack4.text += ":  <i> Att. " + attackDamage4 + "  Accur. " + agileDamage4 + "  DMG+ " + attackDamageBoost4;
            }
            else if (agileDamage4 > 0 && attackDamageBoost4 > 0)
            {
                Attack4.text += ":  <i> Accur. " + agileDamage4 + "  DMG+ " + attackDamageBoost4;
            }
            else if (attackDamage4 > 0 && attackDamageBoost4 > 0)
            {
                Attack4.text += ":  <i> Att. " + attackDamage4 + "  DMG+ " + attackDamageBoost4;
            }
            else if (attackDamage4 > 0 && attackDamageBoost4 > 0)
            {
                Attack4.text += ":  <i> Att. " + attackDamage4 + "  Accur. " + agileDamage4;
            }
            else if (attackDamageBoost4 > 0 && agileDamage4 <= 0 && attackDamage4 <= 0)
            {
                Attack4.text += ":  <i>DMG+ " + attackDamageBoost4;
            }
            else if (attackDamageBoost4 <= 0 && agileDamage4 > 0 && attackDamage4 <= 0)
            {
                Attack4.text += ":  <i>Accur. " + agileDamage4;
            }
            else
            {
                Attack4.text += ":  <i> Att. " + attackDamage4;
            }
        }
        else if (Attack4.text.Contains(":"))
        {
            string[] parts = Attack4.text.Split(':');

            // Take the first part (before the colon)
            string modifiedString = parts[0];

            Attack4.text = modifiedString;
        }
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
        int shouldGoFirst = -2;
        if(abilitySpeedIsKing)
        {
            shouldGoFirst = enemyAbilities.useAttack(-2);
        }

        if (abilitySpeedIsKing && enemyAbilities.getAbilitySpeed() > agileDamage1)
        {
            
        }
        else if (UnityEngine.Random.Range(0, 100 - missAbiblityChanges) <= 5 && canMiss)
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

            decreaseHittingAbility(-agileDamage1);
            //--maxAbilityUse;

            if(userName1 != null && !(userName1.Equals("")))
            {
                enemyName = userName1;
            }

            if (attackUseMessage != null && !(attackUseMessage.Equals("")))
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName + "</i>" + attackUseMessage;
            }
            else
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName + "</i>" + " and it hit!";
            }
        }

        if (abilitySpeedIsKing)
        {
            enemyAbilities.useAttack(shouldGoFirst);
        }
    }

    public void PlayerAttacked2()
    {
        int shouldGoFirst = -2;
        if (abilitySpeedIsKing)
        {
            shouldGoFirst = enemyAbilities.useAttack(-2);
        }

        if (abilitySpeedIsKing && enemyAbilities.getAbilitySpeed() > agileDamage2)
        {

        }
        else if (UnityEngine.Random.Range(0, 100) <= 5 && canMiss2)
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

            enemyAbilities.reduceAttackSpeed(-agileDamage2);

            //--maxAbilityUse;

            if (userName2 != null && !(userName2.Equals("")))
            {
                enemyName = userName2;
            }

            if (attackUseMessage2 != null && !(attackUseMessage2.Equals("")))
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName2 + "</i>" + attackUseMessage2;
            }
            else
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName2 + "</i>" + " and it hit!";
            }
        }

        if (abilitySpeedIsKing)
        {
            enemyAbilities.useAttack(shouldGoFirst);
        }
    }

    public void PlayerAttacked3()
    {
        int shouldGoFirst = -2;
        if (abilitySpeedIsKing)
        {
            shouldGoFirst = enemyAbilities.useAttack(-2);
        }

        if (abilitySpeedIsKing && enemyAbilities.getAbilitySpeed() > agileDamage3)
        {

        }
        else if (UnityEngine.Random.Range(0, 100) <= 5 && canMiss3)
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

            enemyAbilities.reduceAttackSpeed(-agileDamage3);
            //--maxAbilityUse;

            if (userName3 != null && !(userName3.Equals("")))
            {
                enemyName = userName3;
            }

            if (attackUseMessage3 != null && !(attackUseMessage3.Equals("")))
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName3 + "</i>" + attackUseMessage3;
            }
            else
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName3 + "</i>" + " and it hit!";
            }
        }

        if (abilitySpeedIsKing)
        {
            enemyAbilities.useAttack(shouldGoFirst);
        }
    }

    public void PlayerAttacked4()
    {
        int shouldGoFirst = -2;
        if (abilitySpeedIsKing)
        {
            shouldGoFirst = enemyAbilities.useAttack(-2);
        }

        if (abilitySpeedIsKing && enemyAbilities.getAbilitySpeed() > agileDamage4)
        {

        }
        else if (UnityEngine.Random.Range(0, 100) <= 5 && canMiss4)
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

            enemyAbilities.reduceAttackSpeed(-agileDamage4);
            //--maxAbilityUse;

            if (userName4 != null && !(userName4.Equals("")))
            {
                enemyName = userName4;
            }

            if (attackUseMessage4 != null && !(attackUseMessage4.Equals("")))
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName4 + "</i>" + attackUseMessage4;
            }
            else
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName4 + "</i>" + " and it hit!";
            }
        }

        if (abilitySpeedIsKing)
        {
            enemyAbilities.useAttack(shouldGoFirst);
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
            if (abilitySpeedIsKing)
            {

            }
            else
            {
                UseMessage.text = "Enemy waiting its turn...";
            } 
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
