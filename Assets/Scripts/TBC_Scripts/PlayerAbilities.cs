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
    private GameObject abilityMenu;

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
    private TextMeshProUGUI abilityInfoText;

    [SerializeField]
    private AbilitySets enemyAbilities;

    private int attackAgainTimer = 0;

    private bool switchINCdamage = false;
    private int switchINCdamageTurns = 0;

    public bool getDamageSwitch()
    {
        return switchINCdamage;
    }

    [SerializeField]
    private bool[] recieveToPartnerDamage = new bool[] {false ,false ,false, false, false, false, false, false };

    [SerializeField]
    private bool[] enemyHitPartner = new bool[] { false, false, false, false, false, false, false, false };

    private bool enemyHitPartnerOnTurn = false;

    public bool getEnemyHitPartner()
    {
        return enemyHitPartnerOnTurn;
    }

    [SerializeField]
    private int[] damageBhealthMulti = new int[8];

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
    private int attackTimes = 1;
    [SerializeField]
    private int damageTeammate = 0;
    [SerializeField]
    private int agileDamageTeammate = 0;
    [SerializeField]
    private float thornDamageActive = 0;
    [SerializeField]
    private String abilityMessage = "";

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
    private int attackTimes2 = 1;
    [SerializeField]
    private int damageTeammate2 = 0;
    [SerializeField]
    private int agileDamageTeammate2 = 0;
    [SerializeField]
    private float thornDamageActive2 = 0;
    [SerializeField]
    private String abilityMessage2 = "";

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
    private int attackTimes3 = 1;
    [SerializeField]
    private int damageTeammate3 = 0;
    [SerializeField]
    private int agileDamageTeammate3 = 0;
    [SerializeField]
    private float thornDamageActive3 = 0;
    [SerializeField]
    private String abilityMessage3 = "";

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
    private int attackTimes4 = 1;
    [SerializeField]
    private int damageTeammate4 = 0;
    [SerializeField]
    private int agileDamageTeammate4 = 0;
    [SerializeField]
    private float thornDamageActive4 = 0;
    [SerializeField]
    private String abilityMessage4 = "";

    [SerializeField]
    private String abilityName5 = "";
    [SerializeField]
    private int attackDamage5 = 0;
    [SerializeField]
    private int agileDamage5 = 0;
    [SerializeField]
    private int attackDamageBoost5 = 0;
    [SerializeField]
    private String attackUseMessage5 = null;
    [SerializeField]
    private String userName5 = "";
    [SerializeField]
    private bool hitAll5 = true;
    [SerializeField]
    private bool canMiss5 = true;
    [SerializeField]
    private bool harmTeammate5 = true;
    [SerializeField]
    private int attackTimes5 = 1;
    [SerializeField]
    private int damageTeammate5 = 0;
    [SerializeField]
    private int agileDamageTeammate5 = 0;
    [SerializeField]
    private float thornDamageActive5 = 0;
    [SerializeField]
    private String abilityMessage5 = "";

    [SerializeField]
    private String abilityName6 = "";
    [SerializeField]
    private int attackDamage6 = 0;
    [SerializeField]
    private int agileDamage6 = 0;
    [SerializeField]
    private int attackDamageBoost6 = 0;
    [SerializeField]
    private String attackUseMessage6 = null;
    [SerializeField]
    private String userName6 = "";
    [SerializeField]
    private bool hitAll6 = true;
    [SerializeField]
    private bool canMiss6 = true;
    [SerializeField]
    private bool harmTeammate6 = true;
    [SerializeField]
    private int attackTimes6 = 1;
    [SerializeField]
    private int damageTeammate6 = 0;
    [SerializeField]
    private int agileDamageTeammate6 = 0;
    [SerializeField]
    private float thornDamageActive6 = 0;
    [SerializeField]
    private String abilityMessage6 = "";

    [SerializeField]
    private String abilityName7 = "";
    [SerializeField]
    private int attackDamage7 = 0;
    [SerializeField]
    private int agileDamage7 = 0;
    [SerializeField]
    private int attackDamageBoost7 = 0;
    [SerializeField]
    private String attackUseMessage7 = null;
    [SerializeField]
    private String userName7 = "";
    [SerializeField]
    private bool hitAll7 = true;
    [SerializeField]
    private bool canMiss7 = true;
    [SerializeField]
    private bool harmTeammate7 = true;
    [SerializeField]
    private int attackTimes7 = 1;
    [SerializeField]
    private int damageTeammate7 = 0;
    [SerializeField]
    private int agileDamageTeammate7 = 0;
    [SerializeField]
    private float thornDamageActive7 = 0;
    [SerializeField]
    private String abilityMessage7 = "";

    [SerializeField]
    private String abilityName8 = "";
    [SerializeField]
    private int attackDamage8 = 0;
    [SerializeField]
    private int agileDamage8 = 0;
    [SerializeField]
    private int attackDamageBoost8 = 0;
    [SerializeField]
    private String attackUseMessage8 = null;
    [SerializeField]
    private String userName8 = "";
    [SerializeField]
    private bool hitAll8 = true;
    [SerializeField]
    private bool canMiss8 = true;
    [SerializeField]
    private bool harmTeammate8 = true;
    [SerializeField]
    private int attackTimes8 = 1;
    [SerializeField]
    private int damageTeammate8 = 0;
    [SerializeField]
    private int agileDamageTeammate8 = 0;
    [SerializeField]
    private float thornDamageActive8 = 0;
    [SerializeField]
    private String abilityMessage8 = "";

    private int attackDamageBoostMina = 0;
    private int attackDamageBoostJager = 0;


    [SerializeField]
    private TextMeshProUGUI UseMessage;

    [SerializeField]
    private TextMeshProUGUI Attack1;
    [SerializeField]
    private TextMeshProUGUI Attack2;
    [SerializeField]
    private TextMeshProUGUI Attack5;
    [SerializeField]
    private TextMeshProUGUI Attack6;

    [SerializeField]
    private TextMeshProUGUI Attack3;
    [SerializeField]
    private TextMeshProUGUI Attack4;
    [SerializeField]
    private TextMeshProUGUI Attack7;
    [SerializeField]
    private TextMeshProUGUI Attack8;

    [SerializeField]
    private Button AttackButton1;
    [SerializeField]
    private Button AttackButton2;
    [SerializeField]
    private Button AttackButton5;
    [SerializeField]
    private Button AttackButton6;

    [SerializeField]
    private Button AttackButton3;
    [SerializeField]
    private Button AttackButton4;
    [SerializeField]
    private Button AttackButton7;
    [SerializeField]
    private Button AttackButton8;

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

    private int attackOverAgain = 0;
    public float thornDamage = 0;
 
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

        if (Attack5 != null && abilityName5 != null && !abilityName5.Equals(""))
        {
            Attack5.text = abilityName5;
        }

        if (Attack6 != null && abilityName6 != null && !abilityName6.Equals(""))
        {
            Attack6.text = abilityName6;
        }

        if (Attack7 != null && abilityName7 != null && !abilityName7.Equals(""))
        {
            Attack7.text = abilityName7;
        }

        if (Attack8 != null && abilityName8 != null && !abilityName8.Equals(""))
        {
            Attack8.text = abilityName8;
        }

        if (AttackButton1 != null)
        {
            AttackButton1.interactable = false;
            AttackButton2.interactable = false;
            AttackButton3.interactable = false;
            AttackButton4.interactable = false;
            AttackButton5.interactable = false;
            AttackButton6.interactable = false;
            AttackButton7.interactable = false;
            AttackButton8.interactable = false;

            jagerSelected = true;
            AttackButton1.gameObject.SetActive(true);
            AttackButton2.gameObject.SetActive(true);
            AttackButton5.gameObject.SetActive(true);
            AttackButton6.gameObject.SetActive(true);
            AttackButton3.gameObject.SetActive(false);
            AttackButton4.gameObject.SetActive(false);
            AttackButton7.gameObject.SetActive(false);
            AttackButton8.gameObject.SetActive(false);
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

        if (abilityMenu != null)
        {
            abilityMenu.SetActive(false);
        }
    }

    public void abilityInfo1()
    {
        int abilityButtonID = 0;
        abilityMenu.SetActive(true);
        if (!(abilityInfoText.text.Contains(":")))
        {
            abilityInfoText.text += ": " + abilityMessage;
        }
        else if (abilityInfoText.text.Contains(":"))
        {
            string[] parts = abilityInfoText.text.Split(':');

            // Take the first part (before the colon)
            string modifiedString = parts[0];

            abilityInfoText.text = modifiedString;
            abilityMenu.SetActive(false);
        }
    }

    public void abilityInfo2()
    {
        int abilityButtonID = 1;
        abilityMenu.SetActive(true);
        if (!(abilityInfoText.text.Contains(":")))
        {
            abilityInfoText.text += ": " + abilityMessage2;
        }
        else if (abilityInfoText.text.Contains(":"))
        {
            string[] parts = abilityInfoText.text.Split(':');

            // Take the first part (before the colon)
            string modifiedString = parts[0];

            abilityInfoText.text = modifiedString;
            abilityMenu.SetActive(false);
        }
    }

    public void abilityInfo5()
    {
        int abilityButtonID = 4;
        abilityMenu.SetActive(true);
        if (!(abilityInfoText.text.Contains(":")))
        {
            abilityInfoText.text += ": " + abilityMessage5;
        }
        else if (abilityInfoText.text.Contains(":"))
        {
            string[] parts = abilityInfoText.text.Split(':');

            // Take the first part (before the colon)
            string modifiedString = parts[0];

            abilityInfoText.text = modifiedString;
            abilityMenu.SetActive(false);
        }
    }

    public void abilityInfo6()
    {
        int abilityButtonID = 5;
        abilityMenu.SetActive(true);
        if (!(abilityInfoText.text.Contains(":")))
        {
            abilityInfoText.text += ": " + abilityMessage6;
        }
        else if (abilityInfoText.text.Contains(":"))
        {
            string[] parts = abilityInfoText.text.Split(':');

            // Take the first part (before the colon)
            string modifiedString = parts[0];

            abilityInfoText.text = modifiedString;
            abilityMenu.SetActive(false);
        }
    }

    public void abilityInfo3()
    {
        int abilityButtonID = 2;
        abilityMenu.SetActive(true);
        if (!(abilityInfoText.text.Contains(":")))
        {
            abilityInfoText.text += ": " + abilityMessage3;
        }
        else if (abilityInfoText.text.Contains(":"))
        {
            string[] parts = abilityInfoText.text.Split(':');

            // Take the first part (before the colon)
            string modifiedString = parts[0];

            abilityInfoText.text = modifiedString;
            abilityMenu.SetActive(false);
        }
    }

    public void abilityInfo4()
    {
        int abilityButtonID = 3;
        abilityMenu.SetActive(true);
        if (!(abilityInfoText.text.Contains(":")))
        {
            abilityInfoText.text += ": " + abilityMessage4;
        }
        else if (abilityInfoText.text.Contains(":"))
        {
            string[] parts = abilityInfoText.text.Split(':');

            // Take the first part (before the colon)
            string modifiedString = parts[0];

            abilityInfoText.text = modifiedString;
            abilityMenu.SetActive(false);
        }
    }

    public void abilityInfo7()
    {
        int abilityButtonID = 6;
        abilityMenu.SetActive(true);
        if (!(abilityInfoText.text.Contains(":")))
        {
            abilityInfoText.text += ": " + abilityMessage7;
        }
        else if (abilityInfoText.text.Contains(":"))
        {
            string[] parts = abilityInfoText.text.Split(':');

            // Take the first part (before the colon)
            string modifiedString = parts[0];

            abilityInfoText.text = modifiedString;
            abilityMenu.SetActive(false);
        }
    }

    public void abilityInfo8()
    {
        int abilityButtonID = 7;
        abilityMenu.SetActive(true);
        if (!(abilityInfoText.text.Contains(":")))
        {
            abilityInfoText.text += ": " + abilityMessage8;
        }
        else if (abilityInfoText.text.Contains(":"))
        {
            string[] parts = abilityInfoText.text.Split(':');

            // Take the first part (before the colon)
            string modifiedString = parts[0];

            abilityInfoText.text = modifiedString;
            abilityMenu.SetActive(false);
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
        if (attackOverAgain > 0)
        {
            return 0;
        }
        else return attackAgainTimer;
    }

    private void PlayerAttacked()
    {
        int shouldGoFirst = -2;

        if (userName1 != null && !(userName1.Equals("")))
        {
            enemyName = userName1;
        }

        if (UnityEngine.Random.Range(0, 100 - missAbiblityChangesMina) <= 5 && canMiss)
        {
            UseMessage.text = enemyName + " tried to attack and missed!";

            attackAgainTimer = 70;
        }
        else if (enemyAbilities.getWaitingTime() + this.getWaitingTime() == 0)
        {
            attackAgainTimer = 70;

            if (hitAll)
            {
                healthEnemy01.SetSliderValue(attackDamage1 + attackDamageBoostMina);
                if (healthEnemy02 != null) { healthEnemy02.SetSliderValue(attackDamage1 + attackDamageBoostMina + ((float)damageBhealthMulti[0] * (float)((100-healthMina.getValue()) /50))); }
                if (healthEnemy03 != null) { healthEnemy03.SetSliderValue(attackDamage1 + attackDamageBoostMina + ((float)damageBhealthMulti[0] * (float)((100-healthMina.getValue()) /50))); }
                if (healthEnemy04 != null) { healthEnemy04.SetSliderValue(attackDamage1 + attackDamageBoostMina + ((float)damageBhealthMulti[0] * (float)((100-healthMina.getValue()) /50))); }

                if (attackDamageBoost1 > 0)
                {
                    attackDamageBoostMina += attackDamageBoost1;
                }
            }
            else
            {
                if (attackDamage1 > 0)
                {
                    healthEnemySelected.SetSliderValue(attackDamage1 + attackDamageBoostMina + ((float)damageBhealthMulti[0] * (float)((100-healthMina.getValue()) /50)));
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

            if (recieveToPartnerDamage[0])
            {
                switchINCdamage = true;
                switchINCdamageTurns = 3;
            }

            if (enemyHitPartner[0])
            {
                enemyHitPartnerOnTurn = true;
            }

            if (hitAll)
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

            if(attackOverAgain == 0 && attackTimes > 1)
            {
                attackOverAgain = attackTimes;
            }

            if(thornDamageActive > 0)
            {
                thornDamage = thornDamageActive;
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

        if (userName2 != null && !(userName2.Equals("")))
        {
            enemyName = userName2;
        }

        if (UnityEngine.Random.Range(0, 100) <= 5 && canMiss2)
        {
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
                    if (healthEnemy02 != null){healthEnemy02.SetSliderValue(attackDamage2 + attackDamageBoostMina + ((float)damageBhealthMulti[1] * (float)((100-healthMina.getValue()) /50)));}
                    if (healthEnemy03 != null){healthEnemy03.SetSliderValue(attackDamage2 + attackDamageBoostMina + ((float)damageBhealthMulti[1] * (float)((100-healthMina.getValue()) /50)));}
                    if (healthEnemy04 != null){healthEnemy04.SetSliderValue(attackDamage2 + attackDamageBoostMina + ((float)damageBhealthMulti[1] * (float)((100-healthMina.getValue()) /50)));}
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
                    healthEnemySelected.SetSliderValue(attackDamage2 + attackDamageBoostMina + ((float)damageBhealthMulti[1] * (float)((100-healthMina.getValue()) /50)));
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

            if (recieveToPartnerDamage[1])
            {
                switchINCdamage = true;
                switchINCdamageTurns = 3;
            }

            if (enemyHitPartner[1])
            {
                enemyHitPartnerOnTurn = true;
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

            if (attackOverAgain == 0 && attackTimes2 > 1)
            {
                attackOverAgain = attackTimes2;
            }

            if (thornDamageActive2 > 0)
            {
                thornDamage = thornDamageActive2;
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

    private void PlayerAttacked5()
    {
        int shouldGoFirst = -2;

        if (userName5 != null && !(userName5.Equals("")))
        {
            enemyName = userName5;
        }

        if (UnityEngine.Random.Range(0, 100) <= 5 && canMiss5)
        {
            UseMessage.text = enemyName + " tried to attack and missed!";

            attackAgainTimer = 70;
        }
        else if (enemyAbilities.getWaitingTime() + this.getWaitingTime() == 0)
        {
            attackAgainTimer = 70;

            if (hitAll5)
            {
                if (attackDamage5 > 0)
                {
                    healthEnemy01.SetSliderValue(attackDamage5 + attackDamageBoostMina);
                    if (healthEnemy02 != null) { healthEnemy02.SetSliderValue(attackDamage5 + attackDamageBoostMina + ((float)damageBhealthMulti[2] * (float)((100-healthMina.getValue()) /50))); }
                    if (healthEnemy03 != null) { healthEnemy03.SetSliderValue(attackDamage5 + attackDamageBoostMina + ((float)damageBhealthMulti[2] * (float)((100-healthMina.getValue()) /50))); }
                    if (healthEnemy04 != null) { healthEnemy04.SetSliderValue(attackDamage5 + attackDamageBoostMina + ((float)damageBhealthMulti[2] * (float)((100-healthMina.getValue()) /50))); }
                }

                if (attackDamageBoost5 > 0)
                {
                    attackDamageBoostMina += attackDamageBoost5;
                }
            }
            else
            {
                if (attackDamage5 > 0)
                {
                    healthEnemySelected.SetSliderValue(attackDamage5 + attackDamageBoostMina + ((float)damageBhealthMulti[2] * (float)((100-healthMina.getValue()) /50)));
                }

                if (attackDamageBoost5 > 0)
                {
                    attackDamageBoostMina += attackDamageBoost5;
                }
            }

            if (harmTeammate5)
            {
                healthJager.SetSliderValue(damageTeammate5);
                if (attackDamageBoostJager - agileDamageTeammate5 >= 0)
                {
                    attackDamageBoostJager -= agileDamageTeammate5;
                }
            }

            if (recieveToPartnerDamage[2])
            {
                switchINCdamage = true;
                switchINCdamageTurns = 3;
            }

            if (enemyHitPartner[2])
            {
                enemyHitPartnerOnTurn = true;
            }

            if (hitAll)
            {
                enemyAbilities.reduceAttackSpeed(-agileDamage5, 0);
                enemyAbilities.reduceAttackSpeed(-agileDamage5, 1);
                enemyAbilities.reduceAttackSpeed(-agileDamage5, 2);
                enemyAbilities.reduceAttackSpeed(-agileDamage5, 3);
            }
            else
            {
                enemyAbilities.reduceAttackSpeed(-agileDamage5, selectedEnemy);
            }

            if (attackOverAgain == 0 && attackTimes5 > 1)
            {
                attackOverAgain = attackTimes5;
            }

            if (thornDamageActive5 > 0)
            {
                thornDamage = thornDamageActive5;
            }

            //--maxAbilityUse;

            if (userName5 != null && !(userName5.Equals("")))
            {
                enemyName = userName5;
            }

            if (attackUseMessage5 != null && !(attackUseMessage5.Equals("")))
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName5 + "</i>" + attackUseMessage5;
            }
            else
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName5 + "</i>" + " and it hit!";
            }
        }
    }

    private void PlayerAttacked3()
    {
        int shouldGoFirst = -2;

        if (userName3 != null && !(userName3.Equals("")))
        {
            enemyName = userName3;
        }

        if (UnityEngine.Random.Range(0, 100) <= 5 && canMiss3)
        {
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
                    if (healthEnemy02 != null){healthEnemy02.SetSliderValue(attackDamage3 + attackDamageBoostJager + ((float)damageBhealthMulti[3] * (float)((100-healthJager.getValue()) /50)));}
                    if (healthEnemy03 != null){healthEnemy03.SetSliderValue(attackDamage3 + attackDamageBoostJager + ((float)damageBhealthMulti[3] * (float)((100-healthJager.getValue()) /50)));}
                    if (healthEnemy04 != null){healthEnemy04.SetSliderValue(attackDamage3 + attackDamageBoostJager + ((float)damageBhealthMulti[3] * (float)((100-healthJager.getValue()) /50)));}
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
                    healthEnemySelected.SetSliderValue(attackDamage3 + attackDamageBoostJager + ((float)damageBhealthMulti[3] * (float)((100-healthJager.getValue()) /50)));
                }

                if (attackDamageBoost3 > 0)
                {
                    attackDamageBoostJager += attackDamageBoost3;
                }
            }

            if (harmTeammate3)
            {
                healthMina.SetSliderValue(damageTeammate3);
                if (attackDamageBoostMina - agileDamageTeammate3 >= 0)
                {
                    attackDamageBoostMina -= agileDamageTeammate3;
                }
            }

            if (recieveToPartnerDamage[3])
            {
                switchINCdamage = true;
                switchINCdamageTurns = 3;
            }

            if (enemyHitPartner[3])
            {
                enemyHitPartnerOnTurn = true;
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

            if (attackOverAgain == 0 && attackTimes3 > 1)
            {
                attackOverAgain = attackTimes3;
            }

            if (thornDamageActive3 > 0)
            {
                thornDamage = thornDamageActive3;
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

        if (userName4 != null && !(userName4.Equals("")))
        {
            enemyName = userName4;
        }

        if (UnityEngine.Random.Range(0, 100) <= 5 && canMiss4)
        {
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
                    if (healthEnemy02 != null){healthEnemy02.SetSliderValue(attackDamage4 + attackDamageBoostJager + ((float)damageBhealthMulti[4] * (float)((100-healthJager.getValue()) /50)));}
                    if (healthEnemy03 != null){healthEnemy03.SetSliderValue(attackDamage4 + attackDamageBoostJager + ((float)damageBhealthMulti[4] * (float)((100-healthJager.getValue()) /50)));}
                    if (healthEnemy04 != null){healthEnemy04.SetSliderValue(attackDamage4 + attackDamageBoostJager + ((float)damageBhealthMulti[4] * (float)((100-healthJager.getValue()) /50)));}
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
                    healthEnemySelected.SetSliderValue(attackDamage4 + attackDamageBoostJager + ((float)damageBhealthMulti[4] * (float)((100-healthJager.getValue()) /50)));
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

            if (recieveToPartnerDamage[4])
            {
                switchINCdamage = true;
                switchINCdamageTurns = 3;
            }

            if (enemyHitPartner[4])
            {
                enemyHitPartnerOnTurn = true;
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

            if (attackOverAgain == 0 && attackTimes4 > 1)
            {
                attackOverAgain = attackTimes4;
            }

            if (thornDamageActive4 > 0)
            {
                thornDamage = thornDamageActive4;
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

    private void PlayerAttacked6()
    {
        int shouldGoFirst = -2;

        if (userName6 != null && !(userName6.Equals("")))
        {
            enemyName = userName6;
        }

        if (UnityEngine.Random.Range(0, 100) <= 5 && canMiss6)
        {
            UseMessage.text = enemyName + " tried to attack and missed!";

            attackAgainTimer = 70;
        }
        else if (enemyAbilities.getWaitingTime() + this.getWaitingTime() == 0)
        {
            attackAgainTimer = 70;

            if (hitAll6)
            {
                if (attackDamage6 > 0)
                {
                    healthEnemy01.SetSliderValue(attackDamage6 + attackDamageBoostJager);
                    if (healthEnemy02 != null) { healthEnemy02.SetSliderValue(attackDamage6 + attackDamageBoostMina + ((float)damageBhealthMulti[5] * (float)((100-healthMina.getValue()) /50))); }
                    if (healthEnemy03 != null) { healthEnemy03.SetSliderValue(attackDamage6 + attackDamageBoostMina + ((float)damageBhealthMulti[5] * (float)((100-healthMina.getValue()) /50))); }
                    if (healthEnemy04 != null) { healthEnemy04.SetSliderValue(attackDamage6 + attackDamageBoostMina + ((float)damageBhealthMulti[5] * (float)((100-healthMina.getValue()) /50))); }
                }

                if (attackDamageBoost6 > 0)
                {
                    attackDamageBoostMina += attackDamageBoost6;
                }
            }
            else
            {
                if (attackDamage6 > 0)
                {
                    healthEnemySelected.SetSliderValue(attackDamage6 + attackDamageBoostMina + ((float)damageBhealthMulti[5] * (float)((100-healthJager.getValue()) /50)));
                }

                if (attackDamageBoost6 > 0)
                {
                    attackDamageBoostMina += attackDamageBoost6;
                }
            }

            if (harmTeammate6)
            {
                healthJager.SetSliderValue(damageTeammate6);
                if (attackDamageBoostJager - agileDamageTeammate6 >= 0)
                {
                    attackDamageBoostJager -= agileDamageTeammate6;
                }
            }

            if (recieveToPartnerDamage[5])
            {
                switchINCdamage = true;
                switchINCdamageTurns = 3;
            }

            if (enemyHitPartner[5])
            {
                enemyHitPartnerOnTurn = true;
            }

            if (hitAll)
            {
                enemyAbilities.reduceAttackSpeed(-agileDamage6, 0);
                enemyAbilities.reduceAttackSpeed(-agileDamage6, 1);
                enemyAbilities.reduceAttackSpeed(-agileDamage6, 2);
                enemyAbilities.reduceAttackSpeed(-agileDamage6, 3);
            }
            else
            {
                enemyAbilities.reduceAttackSpeed(-agileDamage6, selectedEnemy);
            }

            if (attackOverAgain == 0 && attackTimes6 > 1)
            {
                attackOverAgain = attackTimes6;
            }

            if (thornDamageActive6 > 0)
            {
                thornDamage = thornDamageActive6;
            }

            //--maxAbilityUse;

            if (userName6 != null && !(userName6.Equals("")))
            {
                enemyName = userName6;
            }

            if (attackUseMessage6 != null && !(attackUseMessage6.Equals("")))
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName6 + "</i>" + attackUseMessage6;
            }
            else
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName6 + "</i>" + " and it hit!";
            }
        }
    }

    private void PlayerAttacked7()
    {
        int shouldGoFirst = -2;

        if (userName7 != null && !(userName7.Equals("")))
        {
            enemyName = userName7;
        }

        if (UnityEngine.Random.Range(0, 100) <= 5 && canMiss7)
        {
            UseMessage.text = enemyName + " tried to attack and missed!";

            attackAgainTimer = 70;
        }
        else if (enemyAbilities.getWaitingTime() + this.getWaitingTime() == 0)
        {
            attackAgainTimer = 70;

            if (hitAll7)
            {
                if (attackDamage7 > 0)
                {
                    healthEnemy01.SetSliderValue(attackDamage7 + attackDamageBoostJager);
                    if (healthEnemy02 != null) { healthEnemy02.SetSliderValue(attackDamage7 + attackDamageBoostJager + ((float)damageBhealthMulti[6] * (float)((100-healthJager.getValue()) /50))); }
                    if (healthEnemy03 != null) { healthEnemy03.SetSliderValue(attackDamage7 + attackDamageBoostJager + ((float)damageBhealthMulti[6] * (float)((100-healthJager.getValue()) /50))); }
                    if (healthEnemy04 != null) { healthEnemy04.SetSliderValue(attackDamage7 + attackDamageBoostJager + ((float)damageBhealthMulti[6] * (float)((100-healthJager.getValue()) /50))); }
                }

                if (attackDamageBoost7 > 0)
                {
                    attackDamageBoostJager += attackDamageBoost7;
                }
            }
            else
            {
                if (attackDamage7 > 0)
                {
                    healthEnemySelected.SetSliderValue(attackDamage7 + attackDamageBoostJager + ((float)damageBhealthMulti[6] * (float)((100-healthJager.getValue()) /50)));
                }

                if (attackDamageBoost7 > 0)
                {
                    attackDamageBoostJager += attackDamageBoost7;
                }
            }

            if (harmTeammate7)
            {
                healthMina.SetSliderValue(damageTeammate7);
                if (attackDamageBoostMina - agileDamageTeammate7 >= 0)
                {
                    attackDamageBoostMina -= agileDamageTeammate7;
                }
            }

            if (recieveToPartnerDamage[6])
            {
                switchINCdamage = true;
                switchINCdamageTurns = 3;
            }

            if (enemyHitPartner[6])
            {
                enemyHitPartnerOnTurn = true;
            }

            if (hitAll)
            {
                enemyAbilities.reduceAttackSpeed(-agileDamage7, 0);
                enemyAbilities.reduceAttackSpeed(-agileDamage7, 1);
                enemyAbilities.reduceAttackSpeed(-agileDamage7, 2);
                enemyAbilities.reduceAttackSpeed(-agileDamage7, 3);
            }
            else
            {
                enemyAbilities.reduceAttackSpeed(-agileDamage7, selectedEnemy);
            }

            if (attackOverAgain == 0 && attackTimes7 > 1)
            {
                attackOverAgain = attackTimes7;
            }

            if (thornDamageActive7 > 0)
            {
                thornDamage = thornDamageActive7;
            }

            //--maxAbilityUse;

            if (userName7 != null && !(userName7.Equals("")))
            {
                enemyName = userName7;
            }

            if (attackUseMessage7 != null && !(attackUseMessage7.Equals("")))
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName7 + "</i>" + attackUseMessage7;
            }
            else
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName7 + "</i>" + " and it hit!";
            }
        }
    }

    private void PlayerAttacked8()
    {
        int shouldGoFirst = -2;

        if (userName8 != null && !(userName8.Equals("")))
        {
            enemyName = userName8;
        }

        if (UnityEngine.Random.Range(0, 100) <= 5 && canMiss8)
        {
            UseMessage.text = enemyName + " tried to attack and missed!";

            attackAgainTimer = 70;
        }
        else if (enemyAbilities.getWaitingTime() + this.getWaitingTime() == 0)
        {
            attackAgainTimer = 70;

            if (hitAll8)
            {
                if (attackDamage8 > 0)
                {
                    healthEnemy01.SetSliderValue(attackDamage8 + attackDamageBoostJager);
                    if (healthEnemy02 != null) { healthEnemy02.SetSliderValue(attackDamage8 + attackDamageBoostJager + ((float)damageBhealthMulti[7] * (float)((100-healthJager.getValue()) /50))); }
                    if (healthEnemy03 != null) { healthEnemy03.SetSliderValue(attackDamage8 + attackDamageBoostJager + ((float)damageBhealthMulti[7] * (float)((100-healthJager.getValue()) /50))); }
                    if (healthEnemy04 != null) { healthEnemy04.SetSliderValue(attackDamage8 + attackDamageBoostJager + ((float)damageBhealthMulti[7] * (float)((100-healthJager.getValue()) /50))); }
                }

                if (attackDamageBoost8 > 0)
                {
                    attackDamageBoostJager += attackDamageBoost8;
                }
            }
            else
            {
                if (attackDamage8 > 0)
                {
                    healthEnemySelected.SetSliderValue(attackDamage8 + attackDamageBoostJager);
                }

                if (attackDamageBoost8 > 0)
                {
                    attackDamageBoostJager += attackDamageBoost8;
                }
            }

            if (harmTeammate8)
            {
                healthMina.SetSliderValue(damageTeammate8);
                if (attackDamageBoostMina - agileDamageTeammate8 >= 0)
                {
                    attackDamageBoostMina -= agileDamageTeammate8;
                }
            }

            if (recieveToPartnerDamage[7])
            {
                switchINCdamage = true;
                switchINCdamageTurns = 3;
            }

            if (enemyHitPartner[7])
            {
                enemyHitPartnerOnTurn = true;
            }

            if (hitAll)
            {
                enemyAbilities.reduceAttackSpeed(-agileDamage8, 0);
                enemyAbilities.reduceAttackSpeed(-agileDamage8, 1);
                enemyAbilities.reduceAttackSpeed(-agileDamage8, 2);
                enemyAbilities.reduceAttackSpeed(-agileDamage8, 3);
            }
            else
            {
                enemyAbilities.reduceAttackSpeed(-agileDamage8, selectedEnemy);
            }

            if (attackOverAgain == 0 && attackTimes8 > 1)
            {
                attackOverAgain = attackTimes8;
            }

            if (thornDamageActive8 > 0)
            {
                thornDamage = thornDamageActive8;
            }

            //--maxAbilityUse;

            if (userName8 != null && !(userName8.Equals("")))
            {
                enemyName = userName8;
            }

            if (attackUseMessage8 != null && !(attackUseMessage8.Equals("")))
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName8 + "</i>" + attackUseMessage8;
            }
            else
            {
                UseMessage.text = enemyName + " Used <i>" + abilityName8 + "</i>" + " and it hit!";
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
        else if (id == 4 && hitAll5)
        {
            this.PlayerAttacked5();
        }
        else if (id == 5 && hitAll6)
        {
            this.PlayerAttacked6();
        }
        else if (id == 6 && hitAll7)
        {
            this.PlayerAttacked7();
        }
        else if (id == 7 && hitAll8)
        {
            this.PlayerAttacked8();
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


            if (attackOverAgain > 0 && attackAgainTimer == 45)
            {
                UseMessage.text = enemyName + " attacked again!";
            }
            else if (attackOverAgain > 0 && attackAgainTimer == 15)
            {
                --attackOverAgain;
                attackAgainTimer = 80;
                activateAttack();
            }

            //Debug.Log(attackAgainTimer);
        }

        if (attackAgainTimer == 45)
        {
            AttackButton1.interactable = false;
            AttackButton2.interactable = false;
            AttackButton3.interactable = false;
            AttackButton4.interactable = false;
            AttackButton5.interactable = false;
            AttackButton6.interactable = false;
            AttackButton7.interactable = false;
            AttackButton8.interactable = false;

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


        if (healthEnemy01 != null && healthEnemy02 != null && healthEnemy03 != null && healthEnemy04 != null)
        {
            if (healthEnemy01.getValue() <= 0 && healthEnemy02.getValue() <= 0 && healthEnemy03.getValue() <= 0 && healthEnemy04.getValue() <= 0)
            {
                SceneManager.LoadScene(returnToMainSceneName);
            }
        }
        else if (healthEnemy01 != null && healthEnemy02 != null && healthEnemy03 != null)
        {
            if (healthEnemy01.getValue() <= 0 && healthEnemy02.getValue() <= 0 && healthEnemy03.getValue() <= 0)
            {
                SceneManager.LoadScene(returnToMainSceneName);
            }
        }
        else if (healthEnemy01 != null && healthEnemy02 != null)
        {
            if(healthEnemy01.getValue() <= 0 && healthEnemy02.getValue() <= 0)
            {
                SceneManager.LoadScene(returnToMainSceneName);
            }
        }
        else if (healthEnemy01 != null && healthEnemy01.getValue() <= 0)
        {
            SceneManager.LoadScene(returnToMainSceneName);
        }
        
        if (healthMina != null && (healthMina.getValue() <= 0 && healthJager.getValue() <= 0))
        {
            SceneManager.LoadScene(returnToMainSceneName);
        }
    }

    public void unlockAttacks()
    {
        if(switchINCdamageTurns > 0)
        {
            --switchINCdamageTurns;
        }
        else
        {
            switchINCdamage = false;
        }

        enemyHitPartnerOnTurn = false;

        this.thornDamage = 0;

        if (healthMina.getValue() > 0)
        {
            AttackButton1.interactable = true;
            AttackButton2.interactable = true;
            AttackButton5.interactable = true;
            AttackButton6.interactable = true;
        }

        if (healthJager.getValue() > 0)
        {
            AttackButton3.interactable = true;
            AttackButton4.interactable = true;
            AttackButton7.interactable = true;
            AttackButton8.interactable = true;
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
        else if (abilityChosen == 4)
        {
            this.PlayerAttacked5();
        }
        else if (abilityChosen == 5)
        {
            this.PlayerAttacked6();
        }
        else if (abilityChosen == 6)
        {
            this.PlayerAttacked7();
        }
        else if (abilityChosen == 7)
        {
            this.PlayerAttacked8();
        }
    }

    //Leave this scene, go back
    public void fleeBattle()
    {
        SceneManager.LoadScene("TestLevelScene");
    }

    private bool jagerSelected;

    //Switch abilities in Box from Partner to Partner
    public void switchAbilities()
    {
        if (!jagerSelected)
        {
            jagerSelected = true;
            AttackButton1.gameObject.SetActive(true);
            AttackButton2.gameObject.SetActive(true);
            AttackButton5.gameObject.SetActive(true);
            AttackButton6.gameObject.SetActive(true);
            AttackButton3.gameObject.SetActive(false);
            AttackButton4.gameObject.SetActive(false);
            AttackButton7.gameObject.SetActive(false);
            AttackButton8.gameObject.SetActive(false);
        }
        else
        {
            jagerSelected = false;
            AttackButton1.gameObject.SetActive(false);
            AttackButton2.gameObject.SetActive(false);
            AttackButton5.gameObject.SetActive(false);
            AttackButton6.gameObject.SetActive(false);
            AttackButton3.gameObject.SetActive(true);
            AttackButton4.gameObject.SetActive(true);
            AttackButton7.gameObject.SetActive(true);
            AttackButton8.gameObject.SetActive(true);
        }
    }
}