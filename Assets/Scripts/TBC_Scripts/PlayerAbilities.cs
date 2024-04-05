using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerAbilities : MonoBehaviour
{
    [SerializeField]
    private string returnToMainSceneName;
    
    [SerializeField]
    private SliderController healthEnemySelected;
    [SerializeField]
    private SliderController healthEnemy01;
    [SerializeField]
    private SliderController healthEnemy02;
    [SerializeField]
    private SliderController healthEnemy03;
    [SerializeField]
    private SliderController healthEnemy04;

    [SerializeField]
    private SliderController healthMina;
    [SerializeField]
    private SliderController healthJager;

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
    private bool hitAll = true;
    [SerializeField]
    private bool canMiss = true;
    [SerializeField]
    private bool harmTeammate = true;
    [SerializeField]
    private int damageTeammate = 0;
    [SerializeField]
    private int agileDamageTeammate = 0;

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
    private int maxAbilityUse2 = 0;
    [SerializeField]
    private int changeBeingUsed2 = 0;
    [SerializeField]
    private String userName2 = "";
    [SerializeField]
    private bool hitAll2 = true;
    [SerializeField]
    private bool canMiss2 = true;
    [SerializeField]
    private bool harmTeammate2 = true;
    [SerializeField]
    private int damageTeammate2 = 0;
    [SerializeField]
    private int agileDamageTeammate2 = 0;

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
    private static int maxAbilityUse3 = 0;
    [SerializeField]
    private static int changeBeingUsed3 = 0;
    [SerializeField]
    private String userName3 = "";
    [SerializeField]
    private bool hitAll3 = true;
    [SerializeField]
    private bool canMiss3 = true;
    [SerializeField]
    private bool harmTeammate3 = true;
    [SerializeField]
    private int damageTeammate3 = 0;
    [SerializeField]
    private int agileDamageTeammate3 = 0;

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
    private bool hitAll4 = true;
    [SerializeField]
    private bool canMiss4 = true;
    [SerializeField]
    private bool harmTeammate4 = true;
    [SerializeField]
    private int damageTeammate4 = 0;
    [SerializeField]
    private int agileDamageTeammate4 = 0;

    private int attackDamageBoostMina = 0;
    private int attackDamageBoostJager = 0;


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

    [SerializeField]
    private Button AttackButton1;
    [SerializeField]
    private Button AttackButton2;

    [SerializeField]
    private Button AttackButton3;
    [SerializeField]
    private Button AttackButton4;

    [SerializeField]
    private Button enemy1;
    [SerializeField]
    private Button enemy2;
    [SerializeField]
    private Button enemy3;
    [SerializeField]
    private Button enemy4;

    private int missAbiblityChangesMina = 0;
    private int missAbiblityChangesJager = 0;
    private AbilityList abilityList = new AbilityList();

    // Start is called before the first frame update
    void Start()
    {
        //abilityName = abilityList.abilityName[0];
        //attackDamage1 = abilityList.attackDamage1[0];
        //agileDamage1 = abilityList.agileDamage1[0];
        //attackDamageBoost1 = abilityList.attackDamageBoost1[0];
        //maxAbilityUse = abilityList.maxAbilityUse[0];
        //changeBeingUsed = abilityList.changeBeingUsed[0];
        //attackUseMessage = abilityList.attackUseMessage[0];
        //userName1 = abilityList.userName1[0];
        //hitAll = abilityList.hitAll[0];
        //canMiss = abilityList.canMiss[0];
        //harmTeammate = abilityList.harmTeammate[0];
        //damageTeammate = abilityList.damageTeammate[0];
        //agileDamageTeammate = abilityList.agileDamageTeammate[0];


        if (Attack1 != null && abilityName != null && !abilityName.Equals(""))
        {
            Attack1.text = abilityName;
        }

        if (Attack2 != null && abilityName2 != null && !abilityName2.Equals(""))
        {
            Attack2.text = abilityName2;
        }

        if(Attack3 != null && abilityName3 != null && !abilityName3.Equals(""))
        {
            Attack3.text = abilityName3;
        }

        if (Attack4 != null && abilityName4 != null && !abilityName4.Equals(""))
        {
            Attack4.text = abilityName4;
        }

        if(AttackButton1 != null)
        {
            AttackButton1.interactable = false;
            AttackButton2.interactable = false;
            AttackButton3.interactable = false;
            AttackButton4.interactable = false;
        }
       

        if (enemy1 != null)
        {
            enemy1.interactable = false;
        }

        if (enemy2 != null)
        {
            enemy2.interactable = false;
        }

        if (enemy3 != null)
        {
            enemy3.interactable = false;
        }

        if (enemy4 != null)
        {
            enemy4.interactable = false;
        }
    }

    public void abilityInfo1()
    {
        if(!(Attack1.text.Contains(":")))
        {
            if(attackDamage1 > 0 && agileDamage1 > 0 && attackDamageBoost1 > 0)
            {
                Attack1.text += ":  <i> Att. " + (attackDamage1 + attackDamageBoostMina) + "  Accur. -" + agileDamage1 + "  DMG+ " + attackDamageBoost1;
            }
            else if (agileDamage1 > 0 && attackDamageBoost1 > 0)
            {
                Attack1.text += ":  <i> Accur. -" + agileDamage1 + "  DMG+ " + attackDamageBoost1;
            }
            else if (attackDamage1 > 0 && attackDamageBoost1 > 0)
            {
                Attack1.text += ":  <i> Att. " + (attackDamage1 + attackDamageBoostMina) + "  DMG+ " + attackDamageBoost1;
            }
            else if (attackDamage1 > 0 && attackDamageBoost1 > 0)
            {
                Attack1.text += ":  <i> Att. " + (attackDamage1 + attackDamageBoostMina) + "  Accur. -" + agileDamage1;
            }
            else if (attackDamageBoost1 > 0 && agileDamage1 <= 0 && attackDamage1 <= 0)
            {
                Attack1.text += ":  <i>DMG+ " + attackDamageBoost1;
            }
            else if (attackDamageBoost1 <= 0 && agileDamage1 > 0 && attackDamage1 <= 0)
            {
                Attack1.text += ":  <i>Accur. -" + agileDamage1;
            }
            else
            {
                Attack1.text += ":  <i> Att. " + (attackDamage1 + attackDamageBoostMina);
            }

            if(damageTeammate > 0)
            {
                Attack1.text += " PID: " + damageTeammate;
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
                Attack2.text += ":  <i> Att. " + (attackDamage2 + attackDamageBoostMina) + "  Accur. -" + agileDamage2 + "  DMG+ " + attackDamageBoost2;
            }
            else if (agileDamage2 > 0 && attackDamageBoost2 > 0)
            {
                Attack2.text += ":  <i> Accur. -" + agileDamage2 + "  DMG+ " + attackDamageBoost2;
            }
            else if (attackDamage2 > 0 && attackDamageBoost2 > 0)
            {
                Attack2.text += ":  <i> Att. " + (attackDamage2 + attackDamageBoostMina) + "  DMG+ " + attackDamageBoost2;
            }
            else if (attackDamage2 > 0 && attackDamageBoost2 > 0)
            {
                Attack2.text += ":  <i> Att. " + (attackDamage2 + attackDamageBoostMina) + "  Accur. -" + agileDamage2;
            }
            else if (attackDamageBoost2 > 0 && agileDamage2 <= 0 && attackDamage2 <= 0)
            {
                Attack2.text += ":  <i>DMG+ " + attackDamageBoost2;
            }
            else if (attackDamageBoost2 <= 0 && agileDamage2 > 0 && attackDamage2 <= 0)
            {
                Attack2.text += ":  <i>Accur. -" + agileDamage2;
            }
            else
            {
                Attack2.text += ":  <i> Att. " + (attackDamage2 + attackDamageBoostMina);
            }

            if (damageTeammate2 > 0)
            {
                Attack2.text += " PID: " + damageTeammate2;
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
                Attack3.text += ":  <i> Att. " + (attackDamage3 + attackDamageBoostJager) + "  Accur. -" + agileDamage3 + "  DMG+ " + attackDamageBoost3;
            }
            else if (agileDamage3 > 0 && attackDamageBoost3 > 0)
            {
                Attack3.text += ":  <i> Accur. -" + agileDamage3 + "  DMG+ " + attackDamageBoost3;
            }
            else if (attackDamage3 > 0 && attackDamageBoost3 > 0)
            {
                Attack3.text += ":  <i> Att. " + (attackDamage3 + attackDamageBoostJager) + "  DMG+ " + attackDamageBoost3;
            }
            else if (attackDamage3 > 0 && attackDamageBoost3 > 0)
            {
                Attack3.text += ":  <i> Att. " + (attackDamage3 + attackDamageBoostJager) + "  Accur. -" + agileDamage3;
            }
            else if (attackDamageBoost3 > 0 && agileDamage3 <= 0 && attackDamage3 <= 0)
            {
                Attack3.text += ":  <i>DMG+ " + attackDamageBoost3;
            }
            else if (attackDamageBoost3 <= 0 && agileDamage3 > 0 && attackDamage3 <= 0)
            {
                Attack3.text += ":  <i>Accur. -" + agileDamage3;
            }
            else
            {
                Attack3.text += ":  <i> Att. " + (attackDamage3 + attackDamageBoostJager);
            }

            if (damageTeammate3 > 0)
            {
                Attack3.text += " PID: " + damageTeammate3;
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
                Attack4.text += ":  <i> Att. " + (attackDamage4 + attackDamageBoostJager) + "  Accur. -" + agileDamage4 + "  DMG+ " + attackDamageBoost4;
            }
            else if (agileDamage4 > 0 && attackDamageBoost4 > 0)
            {
                Attack4.text += ":  <i> Accur. -" + agileDamage4 + "  DMG+ " + attackDamageBoost4;
            }
            else if (attackDamage4 > 0 && attackDamageBoost4 > 0)
            {
                Attack4.text += ":  <i> Att. " + (attackDamage4 + attackDamageBoostJager) + "  DMG+ " + attackDamageBoost4;
            }
            else if (attackDamage4 > 0 && attackDamageBoost4 > 0)
            {
                Attack4.text += ":  <i> Att. " + attackDamage4 + attackDamageBoostJager + "  Accur. -" + agileDamage4;
            }
            else if (attackDamageBoost4 > 0 && agileDamage4 <= 0 && attackDamage4 <= 0)
            {
                Attack4.text += ":  <i>DMG+ " + (attackDamage4 + attackDamageBoostJager);
            }
            else if (attackDamageBoost4 <= 0 && agileDamage4 > 0 && attackDamage4 <= 0)
            {
                Attack4.text += ":  <i>Accur. -" + agileDamage4;
            }
            else
            {
                Attack4.text += ":  <i> Att. " + (attackDamage4 + attackDamageBoostJager);
            }

            if (damageTeammate4 > 0)
            {
                Attack4.text += " PID: " + damageTeammate4;
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

    public void decreaseHittingAbilityMina(int decreaseWith)
    {
        if (missAbiblityChangesMina < 85)
        {
            missAbiblityChangesMina += decreaseWith;
        }
    }

    public void decreaseHittingAbilityJager(int decreaseWith)
    {
        if (missAbiblityChangesJager < 85)
        {
            missAbiblityChangesJager += decreaseWith;
        }
    }

    public int getWaitingTime()
    {
        return  attackAgainTimer;
    }

    private void PlayerAttacked()
    {
        int shouldGoFirst = -2;
        
        if (UnityEngine.Random.Range(0, 100 - missAbiblityChangesMina) <= 5 && canMiss)
        {
            if (userName1 != null && !(userName1.Equals("")))
            {
                enemyName = userName1;
            }

            UseMessage.text = enemyName + " tried to attack and missed!";

            attackAgainTimer = 70;
        }
        else if (enemyAbilities.getWaitingTime() + this.getWaitingTime() == 0)
        {
            attackAgainTimer = 70;

            if (hitAll)
            {
                healthEnemy01.SetSliderValue(attackDamage1 + attackDamageBoostMina);
                if (healthEnemy02 != null) { healthEnemy02.SetSliderValue(attackDamage1 + attackDamageBoostMina); }
                if (healthEnemy03 != null) { healthEnemy03.SetSliderValue(attackDamage1 + attackDamageBoostMina); }
                if (healthEnemy04 != null) { healthEnemy04.SetSliderValue(attackDamage1 + attackDamageBoostMina); }

                if (attackDamageBoost1 > 0)
                {
                    attackDamageBoostMina += attackDamageBoost1;
                }
            }
            else
            {
                if (attackDamage1 > 0)
                {
                    healthEnemySelected.SetSliderValue(attackDamage1 + attackDamageBoostMina);
                }

                if (attackDamageBoost1 > 0)
                {
                    attackDamageBoostMina += attackDamageBoost1;
                }
            }

            if (harmTeammate)
            {
                healthJager.SetSliderValue(damageTeammate);
                if (attackDamageBoostJager - agileDamageTeammate >= 0)
                {
                    attackDamageBoostJager -= agileDamageTeammate;
                }
            }

            if(hitAll)
            {
                enemyAbilities.reduceAttackSpeed(-agileDamage1, 0);
                enemyAbilities.reduceAttackSpeed(-agileDamage1, 1);
                enemyAbilities.reduceAttackSpeed(-agileDamage1, 2);
                enemyAbilities.reduceAttackSpeed(-agileDamage1, 3);
            }
            else
            {
                enemyAbilities.reduceAttackSpeed(-agileDamage1, selectedEnemy);
            }
            
            //--maxAbilityUse;

            if (userName1 != null && !(userName1.Equals("")))
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
    }

    private void PlayerAttacked2()
    {
        int shouldGoFirst = -2;
        
        if (UnityEngine.Random.Range(0, 100) <= 5 && canMiss2)
        {
            if (userName2 != null && !(userName2.Equals("")))
            {
                enemyName = userName2;
            }

            UseMessage.text = enemyName + " tried to attack and missed!";

            attackAgainTimer = 70;
        }
        else if (enemyAbilities.getWaitingTime() + this.getWaitingTime() == 0)
        {
            attackAgainTimer = 70;

            if (hitAll2)
            {
                if (attackDamage2 > 0)
                {
                    healthEnemy01.SetSliderValue(attackDamage2 + attackDamageBoostMina);
                    if (healthEnemy02 != null){healthEnemy02.SetSliderValue(attackDamage2 + attackDamageBoostMina);}
                    if (healthEnemy03 != null){healthEnemy03.SetSliderValue(attackDamage2 + attackDamageBoostMina);}
                    if (healthEnemy04 != null){healthEnemy04.SetSliderValue(attackDamage2 + attackDamageBoostMina);}
                }

                if (attackDamageBoost2 > 0)
                {
                    attackDamageBoostMina += attackDamageBoost2;
                }
            }
            else
            {
                if (attackDamage2 > 0)
                {
                    healthEnemySelected.SetSliderValue(attackDamage2 + attackDamageBoostMina);
                }

                if (attackDamageBoost2 > 0)
                {
                    attackDamageBoostMina += attackDamageBoost2;
                }
            }

            if (harmTeammate2)
            {
                healthJager.SetSliderValue(damageTeammate2);
                if (attackDamageBoostJager - agileDamageTeammate2 >= 0)
                {
                    attackDamageBoostJager -= agileDamageTeammate2;
                }
            }

            if (hitAll)
            {
                enemyAbilities.reduceAttackSpeed(-agileDamage2, 0);
                enemyAbilities.reduceAttackSpeed(-agileDamage2, 1);
                enemyAbilities.reduceAttackSpeed(-agileDamage2, 2);
                enemyAbilities.reduceAttackSpeed(-agileDamage2, 3);
            }
            else
            {
                enemyAbilities.reduceAttackSpeed(-agileDamage2, selectedEnemy);
            }

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
    }

    private void PlayerAttacked3()
    {
        int shouldGoFirst = -2;
        
        if (UnityEngine.Random.Range(0, 100) <= 5 && canMiss3)
        {
            if (userName3 != null && !(userName3.Equals("")))
            {
                enemyName = userName3;
            }

            UseMessage.text = enemyName + " tried to attack and missed!";

            attackAgainTimer = 70;
        }
        else if (enemyAbilities.getWaitingTime() + this.getWaitingTime() == 0)
        {
            attackAgainTimer = 70;

            if (hitAll3)
            {
                if (attackDamage3 > 0)
                {
                    healthEnemy01.SetSliderValue(attackDamage3 + attackDamageBoostJager);
                    if (healthEnemy02 != null){healthEnemy02.SetSliderValue(attackDamage3 + attackDamageBoostJager);}
                    if (healthEnemy03 != null){healthEnemy03.SetSliderValue(attackDamage3 + attackDamageBoostJager);}
                    if (healthEnemy04 != null){healthEnemy04.SetSliderValue(attackDamage3 + attackDamageBoostJager);}
                }

                if (attackDamageBoost3 > 0)
                {
                    attackDamageBoostJager += attackDamageBoost3;
                }
            }
            else
            {
                if (attackDamage3 > 0)
                {
                    healthEnemySelected.SetSliderValue(attackDamage3 + attackDamageBoostJager);
                }

                if (attackDamageBoost3 > 0)
                {
                    attackDamageBoostJager += attackDamageBoost3;
                }
            }

            if (this.harmTeammate3)
            {
                healthMina.SetSliderValue(damageTeammate3);
                if (attackDamageBoostMina - agileDamageTeammate3 >= 0)
                {
                    attackDamageBoostMina -= agileDamageTeammate3;
                }
            }

            if (hitAll)
            {
                enemyAbilities.reduceAttackSpeed(-agileDamage3, 0);
                enemyAbilities.reduceAttackSpeed(-agileDamage3, 1);
                enemyAbilities.reduceAttackSpeed(-agileDamage3, 2);
                enemyAbilities.reduceAttackSpeed(-agileDamage3, 3);
            }
            else
            {
                enemyAbilities.reduceAttackSpeed(-agileDamage3, selectedEnemy);
            }
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
    }

    private void PlayerAttacked4()
    {
        int shouldGoFirst = -2;
        
        if (UnityEngine.Random.Range(0, 100) <= 5 && canMiss4)
        {
            if (userName4 != null && !(userName4.Equals("")))
            {
                enemyName = userName4;
            }

            UseMessage.text = enemyName + " tried to attack and missed!";

            attackAgainTimer = 70;
        }
        else if (enemyAbilities.getWaitingTime() + this.getWaitingTime() == 0)
        {
            attackAgainTimer = 70;

            if (hitAll4)
            {
                if (attackDamage4 > 0)
                {
                    healthEnemy01.SetSliderValue(attackDamage4 + attackDamageBoostJager);
                    if (healthEnemy02 != null){healthEnemy02.SetSliderValue(attackDamage4 + attackDamageBoostJager);}
                    if (healthEnemy03 != null){healthEnemy03.SetSliderValue(attackDamage4 + attackDamageBoostJager);}
                    if (healthEnemy04 != null){healthEnemy04.SetSliderValue(attackDamage4 + attackDamageBoostJager);}
                }

                if (attackDamageBoost4 > 0)
                {
                    attackDamageBoostJager += attackDamageBoost4;
                }
            }
            else
            {
                if (attackDamage4 > 0)
                {
                    healthEnemySelected.SetSliderValue(attackDamage4 + attackDamageBoostJager);
                }

                if (attackDamageBoost4 > 0)
                {
                    attackDamageBoostJager += attackDamageBoost4;
                }
            }

            if (harmTeammate4)
            {
                healthMina.SetSliderValue(damageTeammate4);
                if (attackDamageBoostMina - agileDamageTeammate4 >= 0)
                {
                    attackDamageBoostMina -= agileDamageTeammate4;
                }
            }

            if (hitAll)
            {
                enemyAbilities.reduceAttackSpeed(-agileDamage4, 0);
                enemyAbilities.reduceAttackSpeed(-agileDamage4, 1);
                enemyAbilities.reduceAttackSpeed(-agileDamage4, 2);
                enemyAbilities.reduceAttackSpeed(-agileDamage4, 3);
            }
            else
            {
                enemyAbilities.reduceAttackSpeed(-agileDamage4, selectedEnemy);
            }
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
    }

    private int abilityChosen = -1;
    public void chooseAbility(int id)
    {
        abilityChosen = id;

        if(id == 0 && hitAll)
        {
            this.PlayerAttacked();
        }
        else if (id == 1 && hitAll2)
        {
            this.PlayerAttacked2();
        }
        else if (id == 2 && hitAll3)
        {
            this.PlayerAttacked3();
        }
        else if (id == 3 && hitAll4)
        {
            this.PlayerAttacked4();
        }
        else
        {
            if (enemy1 != null)
            {
                enemy1.interactable = true;
            }

            if (enemy2 != null)
            {
                enemy2.interactable = true;
            }

            if (enemy3 != null)
            {
                enemy3.interactable = true;
            }

            if (enemy4 != null)
            {
                enemy4.interactable = true;
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

        if (attackAgainTimer == 45)
        {
            AttackButton1.interactable = false;
            AttackButton2.interactable = false;
            AttackButton3.interactable = false;
            AttackButton4.interactable = false;

            if (enemy1 != null)
            {
                enemy1.interactable = false;
            }

            if (enemy2 != null)
            {
                enemy2.interactable = false;
            }

            if (enemy3 != null)
            {
                enemy3.interactable = false;
            }

            if (enemy4 != null)
            {
                enemy4.interactable = false;
            }

            selectedEnemy = -1;
        }

        if (attackAgainTimer == 5)
        {
            AbilitySets.afterPlayerAttacked();
            UseMessage.text = "...";
        }


        if (healthEnemy01 != null && healthEnemy02 != null && healthEnemy03 != null && healthEnemy04 != null && (healthEnemy01.getValue() <= 0 && healthEnemy02.getValue() <= 0) && healthEnemy03.getValue() <= 0 && healthEnemy04.getValue() <= 0)
        {
            SceneManager.LoadScene(returnToMainSceneName);
        }
        else if (healthEnemy01 != null && healthEnemy02 != null && healthEnemy03 != null && (healthEnemy01.getValue() <= 0 && healthEnemy02.getValue() <= 0 && healthEnemy03.getValue() <= 0))
        {
            SceneManager.LoadScene(returnToMainSceneName);
        }
        else if (healthEnemy01 != null && healthEnemy02 != null && (healthEnemy01.getValue() <= 0 && healthEnemy02.getValue() <= 0))
        {
            SceneManager.LoadScene(returnToMainSceneName);
        }
        else if (healthEnemy01 != null && healthEnemy01.getValue() <= 0)
        {
            SceneManager.LoadScene(returnToMainSceneName);
        }
        else if (healthMina != null && (healthMina.getValue() <= 0 && healthJager.getValue() <= 0))
        {
            SceneManager.LoadScene(returnToMainSceneName);
        }
    }

    public void unlockAttacks()
    {
        if(healthMina.getValue() > 0)
        {
            AttackButton1.interactable = true;
            AttackButton2.interactable = true;
        }

        if (healthJager.getValue() > 0)
        {
            AttackButton3.interactable = true;
            AttackButton4.interactable = true;
        }
    }

    public void selectEnemy1()
    {
        healthEnemySelected = healthEnemy01;
        selectedEnemy = 0;
        activateAttack();
    }

    public void selectEnemy2()
    {
        healthEnemySelected = healthEnemy02;
        selectedEnemy = 1;
        activateAttack();
    }

    public void selectEnemy3()
    {
        healthEnemySelected = healthEnemy03;
        selectedEnemy = 2;
        activateAttack();
    }

    public void selectEnemy4()
    {
        healthEnemySelected = healthEnemy04;
        selectedEnemy = 3;
        activateAttack();
    }

    private int selectedEnemy = -1;

    private void activateAttack()
    {
        if (abilityChosen == 0)
        {
            this.PlayerAttacked();
        }
        else if (abilityChosen == 1)
        {
            this.PlayerAttacked2();
        }
        else if (abilityChosen == 2)
        {
            this.PlayerAttacked3();
        }
        else if (abilityChosen == 3)
        {
            this.PlayerAttacked4();
        }
    }
}