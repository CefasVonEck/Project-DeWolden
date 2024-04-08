using UnityEngine;
using TMPro;
using System;

public class AbilitySets : MonoBehaviour
{
    [SerializeField]
    public GameObject[] accuracyIcon = new GameObject[11];

    [SerializeField]
    private int enemiesAtOnce = 0;

    [SerializeField]
    private float attackSpeedEnemy1 = 0;
    [SerializeField]
    private float maxAttackSpeedEnemy1 = 0;

    [SerializeField]
    private float attackSpeedEnemy2 = 0;
    [SerializeField]
    private float maxAttackSpeedEnemy2 = 0;

    [SerializeField]
    private float attackSpeedEnemy3 = 0;
    [SerializeField]
    private float maxAttackSpeedEnemy3 = 0;

    [SerializeField]
    private float attackSpeedEnemy4 = 0;
    [SerializeField]
    private float maxAttackSpeedEnemy4 = 0;

    private int waitingMessage = 0;

    [SerializeField]
    private SliderController healthMina;

    [SerializeField]
    private SliderController healthJager;

    [SerializeField]
    private SliderController accuracyMe;

    [SerializeField]
    private PlayerAbilities PlayerAbilities;

    private static int attackAgainTimer = 0;

    [SerializeField]
    private String enemyOneName = "";
    [SerializeField]
    private String enemyTwoName = "";
    [SerializeField]
    private String enemyThreeName = "";
    [SerializeField]
    private String enemyFourName = "";

    private String enemyName = "";

    [SerializeField]
    private String abilityName = "";
    [SerializeField]
    private int attackDamage1 = 0;
    [SerializeField]
    private int accurcyDamage1 = 0;
    [SerializeField]
    private int attackDamageBoost1 = 0;
    [SerializeField]
    private int accurcyBoost1 = 0;
    [SerializeField]
    private int maxAbilityUse = 0;
    [SerializeField]
    private int changeBeingUsed = 0;
    [SerializeField]
    private String attackUseMessage = null;
    [SerializeField]
    private bool boostAllAccurcy1 = false;
    [SerializeField]
    private bool canMiss = true;

    [SerializeField]
    private String abilityName2 = "";
    [SerializeField]
    private int attackDamage2 = 0;
    [SerializeField]
    private int accurcyDamage2 = 0;
    [SerializeField]
    private int attackDamageBoost2 = 0;
    [SerializeField]
    private int accurcyBoost2 = 0;
    [SerializeField]
    private int maxAbilityUse2 = 0;
    [SerializeField]
    private int changeBeingUsed2 = 0;
    [SerializeField]
    private String attackUseMessage2 = null;
    [SerializeField]
    private bool boostAllAccurcy2 = false;
    [SerializeField]
    private bool canMiss2 = true;

    [SerializeField]
    private String abilityNameLast = "";
    [SerializeField]
    private int attackDamageLast = 0;
    [SerializeField]
    private int accurcyDamageLast = 0;
    [SerializeField]
    private bool boostAllAccurcyLast = false;
    [SerializeField]
    private int attackDamageBoostLast = 0;
    [SerializeField]
    private String attackUseMessageLast = null;

    [SerializeField]
    private TextMeshProUGUI UseMessage;

    [SerializeField]
    private String startBattleMessage = "";

    private float countExtraDamage = 0;


    // Start is called before the first frame update
    void Start() 
    {
        attackAgainTimer = 350;

        UseMessage.text = enemyName + " " + startBattleMessage;
    }

    public int getWaitingTime()
    {
        return waitingMessage + attackAgainTimer;
    }

    public static void afterPlayerAttacked()
    {
        attackAgainTimer = 300;
    }

    public void reduceAttackSpeed(float speed,int enemyID)
    {
        if(enemiesAtOnce >= 1 && enemyID == 0 && attackSpeedEnemy1 < 80)
        {
            attackSpeedEnemy1 -= speed;
            if(!accuracyIcon[0].active && attackSpeedEnemy1 < 30)
            {
                accuracyIcon[0].active = true;
            }
            else if (!accuracyIcon[1].active && attackSpeedEnemy1 < 60)
            {
                accuracyIcon[1].active = true;
            }
            else if (!accuracyIcon[2].active && attackSpeedEnemy1 < 80)
            {
                accuracyIcon[2].active = true;
            }
        }
        
        if (enemiesAtOnce >= 2 && enemyID == 1 && attackSpeedEnemy2 < 80)
        {
            attackSpeedEnemy2 -= speed;
            if (!accuracyIcon[3].active && attackSpeedEnemy2 < 30)
            {
                accuracyIcon[3].active = true;
            }
            else if (!accuracyIcon[4].active && attackSpeedEnemy2 < 60)
            {
                accuracyIcon[4].active = true;
            }
            else if (!accuracyIcon[5].active && attackSpeedEnemy2 < 80)
            {
                accuracyIcon[5].active = true;
            }
        }
        
        if (enemiesAtOnce >= 3 && enemyID == 2 && attackSpeedEnemy3 < 80)
        {
            attackSpeedEnemy3 -= speed;
            if (!accuracyIcon[6].active && attackSpeedEnemy3 < 30)
            {
                accuracyIcon[6].active = true;
            }
            else if (!accuracyIcon[7].active && attackSpeedEnemy3 < 60)
            {
                accuracyIcon[7].active = true;
            }
            else if (!accuracyIcon[8].active && attackSpeedEnemy3 < 80)
            {
                accuracyIcon[8].active = true;
            }
        }
        
        if (enemiesAtOnce >= 4 && enemyID == 3 && attackSpeedEnemy4 < 80)
        {
            attackSpeedEnemy4 -= speed;
            if (!accuracyIcon[9].active && attackSpeedEnemy4 < 30)
            {
                accuracyIcon[9].active = true;
            }
            else if (!accuracyIcon[10].active && attackSpeedEnemy4 < 60)
            {
                accuracyIcon[10].active = true;
            }
            else if (!accuracyIcon[11].active && attackSpeedEnemy4 < 80)
            {
                accuracyIcon[11].active = true;
            }
        }
    }
    public int useAttack(int abilityUse, int enemyID)
    {
        int willUseInMove = -1;

        if ((abilityUse == -2))
        {
            float attackSpeed = 0;

            if (enemyID == 0)
            {
                attackSpeed = attackSpeedEnemy1;
            }
            else if (enemyID == 1)
            {
                attackSpeed = attackSpeedEnemy2;
            }
            else if (enemyID == 3)
            {
                attackSpeed = attackSpeedEnemy3;
            }
            else if (enemyID == 4)
            {
                attackSpeed = attackSpeedEnemy4;
            }

            if (UnityEngine.Random.Range(0, 100 - (int)(attackSpeed)) <= 25)
            {
                willUseInMove = 1;
            }
            else if ((UnityEngine.Random.Range(1, 131) >= (int)(changeBeingUsed - (attackSpeed)) || !canMiss || (attackDamage1 > 3 && healthMina.getValue() < 20)) && maxAbilityUse > 0)
            {
                willUseInMove = 2;
            }
            else if ((UnityEngine.Random.Range(1, 131) >= (int)(changeBeingUsed2 - (attackSpeed / 2f)) || !canMiss2 || (attackDamage2 > 3 && healthMina.getValue() < 20)) && maxAbilityUse2 > 0)
            {
                willUseInMove = 3;
            }
            else
            {
                willUseInMove = 4;
            }

            abilityUse = willUseInMove;
        }

        if (abilityUse == 1)
        {
            UseMessage.text = enemyName + " tried to attack and missed!";
            waitingMessage = 50;

            usedAbilitySpeed = 0;
        }
        else if (abilityUse == 2)
        {
            if (attackDamageBoost1 > 0)
            {
                countExtraDamage += attackDamageBoost1;
            }
            else
            {
                if (!PlayerAbilities.getDamageSwitch() && healthMina.getValue() > 0 && UnityEngine.Random.Range(0, 100) <= 50)
                {
                    healthMina.SetSliderValue(attackDamage1 + countExtraDamage);
                }
                else
                {
                    healthJager.SetSliderValue(attackDamage1 + countExtraDamage);
                }
            }

            if (accurcyBoost1 > 0)
            { 
                if (boostAllAccurcy1)
                {
                    attackSpeedEnemy1 += accurcyBoost1;
                    attackSpeedEnemy2 += accurcyBoost2;
                }
                else
                {
                    attackSpeedEnemy1 += accurcyBoost1;
                }
            }

            if (UnityEngine.Random.Range(0, 100) <= 50)
            {
                PlayerAbilities.decreaseHittingAbilityMina(accurcyDamage1);
            }
            else
            {
                PlayerAbilities.decreaseHittingAbilityJager(accurcyDamage1);
            }


            --maxAbilityUse;

            if (attackUseMessage != null && !(attackUseMessage.Equals("")))
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName + "</i>" + attackUseMessage;
            }
            else
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName + "</i>" + " and it hit!";
            }

            usedAbilitySpeed = accurcyDamage1;

            waitingMessage = 100;
        }
        else if (abilityUse == 3)
        {
            if (attackDamageBoost2 > 0)
            {
                countExtraDamage += attackDamageBoost2;
            }
            else
            {
                if (!PlayerAbilities.getDamageSwitch() && healthMina.getValue() > 0 && UnityEngine.Random.Range(0, 100) <= 50)
                {
                    healthMina.SetSliderValue(attackDamage1 + countExtraDamage);
                }
                else
                {
                    healthJager.SetSliderValue(attackDamage1 + countExtraDamage);
                }
            }

            if (accurcyBoost2 > 0)
            {
                if (boostAllAccurcy2)
                {
                    attackSpeedEnemy1 += accurcyBoost2;
                    attackSpeedEnemy2 += accurcyBoost2;
                }
                else
                {
                    attackSpeedEnemy2 += accurcyBoost2;
                }
            }

            if (UnityEngine.Random.Range(0, 100) <= 50)
            {
                PlayerAbilities.decreaseHittingAbilityMina(accurcyDamage2);
            }
            else
            {
                PlayerAbilities.decreaseHittingAbilityJager(accurcyDamage2);
            }

            --maxAbilityUse2;

            if (attackUseMessage2 != null && !(attackUseMessage2.Equals("")))
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName2 + "</i>" + attackUseMessage2;
            }
            else
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName2 + "</i>" + " and it hit!";
            }

            usedAbilitySpeed = accurcyDamage2;

            waitingMessage = 100;
        }
        else if(abilityUse == 4)
        {
            if (attackDamageBoostLast > 0)
            {
                countExtraDamage += attackDamageBoostLast;
            }
            else
            {
                if (!PlayerAbilities.getDamageSwitch() && healthMina.getValue() > 0 && UnityEngine.Random.Range(0, 100) <= 50)
                {
                    healthMina.SetSliderValue(attackDamageLast + countExtraDamage);
                }
                else
                {
                    healthJager.SetSliderValue(attackDamageLast + countExtraDamage);
                }
            }

            if (boostAllAccurcyLast)
            {
                attackSpeedEnemy1 += accurcyBoost1;
                attackSpeedEnemy2 += accurcyBoost2;
            }

            if (UnityEngine.Random.Range(0, 100) <= 50)
            {
                PlayerAbilities.decreaseHittingAbilityMina(accurcyDamageLast);
            }
            else
            {
                PlayerAbilities.decreaseHittingAbilityJager(accurcyDamageLast);
            }


            usedAbilitySpeed = accurcyDamageLast;

            if (attackUseMessageLast != null && !(attackUseMessageLast.Equals("")))
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName2 + "</i>" + attackUseMessageLast;
            }
            else
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName2 + "</i>" + " and it hit!";
            }
            

            waitingMessage = 100;
        }

        return abilityUse;
    }

    private int usedAbilitySpeed = 0;

    public int getAbilitySpeed()
    {
        return usedAbilitySpeed;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (enemiesAtOnce > 3 && attackAgainTimer == 250)
        {
            this.enemyName = enemyFourName;
            useAttack(-2, 0);
        }

        if (enemiesAtOnce > 2 && attackAgainTimer == 150)
        {
            this.enemyName = enemyThreeName;
            useAttack(-2, 1);
        }

        if (enemiesAtOnce > 1 && attackAgainTimer == 80)
        {
            this.enemyName = enemyTwoName;
            useAttack(-2, 2);
        }

        if (attackAgainTimer == 1)
        {
            this.enemyName = enemyOneName;
            useAttack(-2, 3);
        }

        if(attackSpeedEnemy1 > attackSpeedEnemy1)
        {
            attackSpeedEnemy1 -= 0.0005f;
        }

        if (attackSpeedEnemy2 > attackSpeedEnemy2)
        {
            attackSpeedEnemy2 -= 0.0005f;
        }

        if (attackSpeedEnemy3 > attackSpeedEnemy3)
        {
            attackSpeedEnemy3 -= 0.0005f;
        }

        if (attackSpeedEnemy4 > attackSpeedEnemy4)
        {
            attackSpeedEnemy4 -= 0.0005f;
        }

        //accuracyMe.SetSliderValue(attackSpeedEnemy1);

        if (attackAgainTimer > 0)
        {
            --attackAgainTimer;
            //Debug.Log(attackAgainTimer);
        } 

        if(waitingMessage > 0 && attackAgainTimer < 10)
        {
            --waitingMessage;
            if(waitingMessage == 0)
            {
                UseMessage.text = "Waiting for the Player to make a move...";
                PlayerAbilities.unlockAttacks();
            }
        }
    }     
}
