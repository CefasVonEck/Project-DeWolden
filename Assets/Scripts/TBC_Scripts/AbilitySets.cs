using UnityEngine;
using TMPro;
using System;
using System.Runtime.InteropServices.WindowsRuntime;

public class AbilitySets : MonoBehaviour
{
    [SerializeField]
    private GameObject animationScene;
    [SerializeField]
    private GameObject battleScene;
    [SerializeField]
    private AnimationBehaviour animationBehaviourScript;

    [SerializeField]
    private SliderController[] enemyHealth = new SliderController[] { null, null, null, null };

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

    //Enemies can only have 3 attacks/abilities

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
    private TextMeshProUGUI UseMessageAnimationScene;

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

    /**
	 * Displays Icon if the Attack Hit Change is lower(ed): yellow, orange, red
	 */
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
    
    private int prepareAttack(int enemyID)
    {
        float attackSpeed = 0;
        int willUseInMove;

        //Load attack speed from enemy that is attacking
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

        //Ability in use(yes, I know the code looks weird, but they are leftovers from other smaller prototypes in 1 script, because I ran out of time due to making stupid art)
        //Missed attack, lower(ed) accuracy will make it miss more than 25% of the time
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
        //Last attack, if no other attack is being used
        else
        {
            willUseInMove = 4;
        }
        
        return willUseInMove;
    }

    /**
	 * Calculates which attack to use on who, or that it missed, or even hit a partner
	 */
    public int useAttack(int abilityUse, int enemyID)
    {
        //Miss
        if (abilityUse == 1)
        {
            UseMessage.text = enemyName + " tried to attack and missed!";
            waitingMessage = 50;

            usedAbilitySpeed = 0;
        }
        //attack
        else if (abilityUse == 2)
        {
            if (attackUseMessage != null && !(attackUseMessage.Equals("")))
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName + "</i>" + attackUseMessage;
            }
            else
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName + "</i>" + " and it hit!";
            }

            if (attackDamageBoost1 > 0)
            {
                countExtraDamage += attackDamageBoost1;
            }
            else
            {
                if (PlayerAbilities.getEnemyHitPartner() && enemyHealth[enemyID] != null)
                {
                    enemyHealth[isEnemyPressented(enemyID)].SetSliderValue(attackDamage1 + countExtraDamage);
                }
                else if (!PlayerAbilities.getDamageSwitch() && healthMina.getValue() > 0 && UnityEngine.Random.Range(0, 100) <= 50)
                {
                    healthMina.SetSliderValue(attackDamage1 + countExtraDamage);
                    animationBehaviourScript.MinaSprite.SetActive(true);
                    animationBehaviourScript.JagerSprite.SetActive(false);
                }
                else
                {
                    healthJager.SetSliderValue(attackDamage1 + countExtraDamage);
                    animationBehaviourScript.MinaSprite.SetActive(false);
                    animationBehaviourScript.JagerSprite.SetActive(true);
                }

                enemyHealth[enemyID].SetSliderValue(PlayerAbilities.thornDamage);
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

            usedAbilitySpeed = accurcyDamage1;

            waitingMessage = 100;
        }
        //attack
        else if (abilityUse == 3)
        {
            if (attackUseMessage2 != null && !(attackUseMessage2.Equals("")))
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName2 + "</i>" + attackUseMessage2;
            }
            else
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName2 + "</i>" + " and it hit!";
            }

            if (attackDamageBoost2 > 0)
            {
                countExtraDamage += attackDamageBoost2;
            }
            else
            {
                if (PlayerAbilities.getEnemyHitPartner() && enemyHealth[enemyID] != null)
                {
                    enemyHealth[isEnemyPressented(enemyID)].SetSliderValue(attackDamage2 + countExtraDamage);
                }
                else if (!PlayerAbilities.getDamageSwitch() && healthMina.getValue() > 0 && UnityEngine.Random.Range(0, 100) <= 50)
                {
                    healthMina.SetSliderValue(attackDamage2 + countExtraDamage);
                    animationBehaviourScript.MinaSprite.SetActive(true);
                    animationBehaviourScript.JagerSprite.SetActive(false);
                }
                else
                {
                    healthJager.SetSliderValue(attackDamage2 + countExtraDamage);
                    animationBehaviourScript.MinaSprite.SetActive(false);
                    animationBehaviourScript.JagerSprite.SetActive(true);
                }

                enemyHealth[enemyID].SetSliderValue(PlayerAbilities.thornDamage);
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

            usedAbilitySpeed = accurcyDamage2;

            waitingMessage = 100;
        }
        //attack
        else if(abilityUse == 4)
        {
            if (attackUseMessageLast != null && !(attackUseMessageLast.Equals("")))
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName2 + "</i>" + attackUseMessageLast;
            }
            else
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName2 + "</i>" + " and it hit!";
            }

            if (attackDamageBoostLast > 0)
            {
                countExtraDamage += attackDamageBoostLast;
            }
            else
            {
                if (PlayerAbilities.getEnemyHitPartner() && enemyHealth[enemyID] != null)
                {
                    enemyHealth[isEnemyPressented(enemyID)].SetSliderValue(attackDamageLast + countExtraDamage);
                }
                else if (!PlayerAbilities.getDamageSwitch() && healthMina.getValue() > 0 && UnityEngine.Random.Range(0, 100) <= 50)
                {
                    healthMina.SetSliderValue(attackDamageLast + countExtraDamage);
                    animationBehaviourScript.MinaSprite.SetActive(true);
                    animationBehaviourScript.JagerSprite.SetActive(false);
                }
                else
                {
                    healthJager.SetSliderValue(attackDamageLast + countExtraDamage);
                    animationBehaviourScript.MinaSprite.SetActive(false);
                    animationBehaviourScript.JagerSprite.SetActive(true);
                }

                enemyHealth[enemyID].SetSliderValue(PlayerAbilities.thornDamage); 
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

            waitingMessage = 100;
        }

        UseMessageAnimationScene.text = UseMessage.text;

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
        if (enemiesAtOnce > 3 && attackAgainTimer == 250 && this.enemyHealth[3] != null && this.enemyHealth[3].getValue() > 0)
        {
            this.enemyName = enemyFourName;
            
            int attack = prepareAttack(3);

            if(attack != 1)
            {
                enableAnimationScene(3);
            }

            useAttack(attack, 3);
        }

        if (enemiesAtOnce > 2 && attackAgainTimer == 150 && this.enemyHealth[2] != null && this.enemyHealth[2].getValue() > 0)
        {
            this.enemyName = enemyThreeName;

            int attack = prepareAttack(2);

            if (attack != 1)
            {
                enableAnimationScene(2);
            }

            useAttack(attack, 2);
        }

        if (enemiesAtOnce > 1 && attackAgainTimer == 80 && this.enemyHealth[1] != null && this.enemyHealth[1].getValue() > 0)
        {
            this.enemyName = enemyTwoName;

            int attack = prepareAttack(1);

            if (attack != 1)
            {
                enableAnimationScene(1);
            }

            useAttack(attack, 1);
        }

        if (attackAgainTimer == 1 && this.enemyHealth[0] != null && this.enemyHealth[0].getValue() > 0)
        {
            this.enemyName = enemyOneName;

            int attack = prepareAttack(0);

            if (attack != 1)
            {
                enableAnimationScene(0);
            }

            useAttack(attack, 0);
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

    /**
	 * Prepares to play the battle animation Scene by the Enemy that will use its attack(If you don't use != null, it will flip out)
	 */
    private void enableAnimationScene(int enemyID)
    {
        if (enemyID == 0)
        {
            if (animationBehaviourScript.enemy1SpriteObject != null)
            {
                animationBehaviourScript.enemy1SpriteObject.SetActive(true);
            }
            if (animationBehaviourScript.enemy2SpriteObject != null)
            {
                animationBehaviourScript.enemy2SpriteObject.SetActive(false);
            }
            if (animationBehaviourScript.enemy3SpriteObject != null)
            {
                animationBehaviourScript.enemy3SpriteObject.SetActive(false);
            }
            if (animationBehaviourScript.enemy4SpriteObject != null)
            {
                animationBehaviourScript.enemy4SpriteObject.SetActive(false);
            }
        }
        else if (enemyID == 1)
        {
            if (animationBehaviourScript.enemy1SpriteObject != null)
            {
                animationBehaviourScript.enemy1SpriteObject.SetActive(false);
            }
            if (animationBehaviourScript.enemy2SpriteObject != null)
            {
                animationBehaviourScript.enemy2SpriteObject.SetActive(true);
            }
            if (animationBehaviourScript.enemy3SpriteObject != null)
            {
                animationBehaviourScript.enemy3SpriteObject.SetActive(false);
            }
            if (animationBehaviourScript.enemy4SpriteObject != null)
            {
                animationBehaviourScript.enemy4SpriteObject.SetActive(false);
            }
        }
        else if (enemyID == 3)
        {
            if (animationBehaviourScript.enemy1SpriteObject != null)
            {
                animationBehaviourScript.enemy1SpriteObject.SetActive(false);
            }
            if (animationBehaviourScript.enemy2SpriteObject != null)
            {
                animationBehaviourScript.enemy2SpriteObject.SetActive(false);
            }
            if (animationBehaviourScript.enemy3SpriteObject != null)
            {
                animationBehaviourScript.enemy3SpriteObject.SetActive(true);
            }
            if (animationBehaviourScript.enemy4SpriteObject != null)
            {
                animationBehaviourScript.enemy4SpriteObject.SetActive(false);
            }
        }
        else if (enemyID == 4)
        {
            if (animationBehaviourScript.enemy1SpriteObject != null)
            {
                animationBehaviourScript.enemy1SpriteObject.SetActive(false);
            }
            if (animationBehaviourScript.enemy2SpriteObject != null)
            {
                animationBehaviourScript.enemy2SpriteObject.SetActive(false);
            }
            if (animationBehaviourScript.enemy3SpriteObject != null)
            {
                animationBehaviourScript.enemy3SpriteObject.SetActive(false);
            }
            if (animationBehaviourScript.enemy4SpriteObject != null)
            {
                animationBehaviourScript.enemy4SpriteObject.SetActive(true);
            }
        }

        if (animationScene != null && battleScene != null)
        {
            animationScene.SetActive(true);
            battleScene.SetActive(false);
        }
    }

    /**
	 * Chooses to hit partnter enemy in confusion if present
	 */
    private int isEnemyPressented(int enemyID)
    {
        if (enemyID == 0 && (enemyHealth[1] != null || enemyHealth[2] != null || enemyHealth[3] != null))
        {
            int hitFriend = 0;

            if(enemyHealth[1] != null && UnityEngine.Random.Range(0, 100) <= 90)
            {
                hitFriend = 1;
            }

            if (enemyHealth[2] != null && UnityEngine.Random.Range(0, 100) <= 90)
            {
                hitFriend = 2;
            }

            if (enemyHealth[3] != null && UnityEngine.Random.Range(0, 100) <= 90)
            {
                hitFriend = 3;
            }

            UseMessage.text = enemyName + " hit partner in self confusion!";

            return hitFriend;
        }
        else if (enemyID == 1 && (enemyHealth[0] != null || enemyHealth[2] != null || enemyHealth[3] != null))
        {
            int hitFriend = 1;

            if (enemyHealth[0] != null && UnityEngine.Random.Range(0, 100) <= 90)
            {
                hitFriend = 0;
            }

            if (enemyHealth[2] != null && UnityEngine.Random.Range(0, 100) <= 90)
            {
                hitFriend = 2;
            }

            if (enemyHealth[3] != null && UnityEngine.Random.Range(0, 100) <= 90)
            {
                hitFriend = 3;
            }

            UseMessage.text = enemyName + " hit partner in self confusion!";

            return hitFriend;
        }
        else if (enemyID == 2 && (enemyHealth[0] != null || enemyHealth[1] != null || enemyHealth[3] != null))
        {
            int hitFriend = 2;

            if (enemyHealth[0] != null && UnityEngine.Random.Range(0, 100) <= 90)
            {
                hitFriend = 0;
            }

            if (enemyHealth[1] != null && UnityEngine.Random.Range(0, 100) <= 90)
            {
                hitFriend = 1;
            }

            if (enemyHealth[3] != null && UnityEngine.Random.Range(0, 100) <= 90)
            {
                hitFriend = 3;
            }

            UseMessage.text = enemyName + " hit partner in self confusion!";

            return hitFriend;
        }
        else if (enemyID == 3 && (enemyHealth[0] != null || enemyHealth[1] != null || enemyHealth[2] != null))
        {
            int hitFriend = 3;

            if (enemyHealth[0] != null && UnityEngine.Random.Range(0, 100) <= 90)
            {
                hitFriend = 0;
            }

            if (enemyHealth[1] != null && UnityEngine.Random.Range(0, 100) <= 90)
            {
                hitFriend = 1;
            }

            if (enemyHealth[2] != null && UnityEngine.Random.Range(0, 100) <= 90)
            {
                hitFriend = 2;
            }

            UseMessage.text = enemyName + " hit partner in self confusion!";

            return hitFriend;
        }
        else return -1; 
    }
}
