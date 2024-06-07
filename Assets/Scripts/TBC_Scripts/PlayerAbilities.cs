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

    private bool switchINCdamage = false;

    public bool getDamageSwitch()
    {
        return switchINCdamage;
    }

    [SerializeField]
    private bool[] recieveToPartnerDamage = new bool[] {false ,false ,false, false, false, false, false, false };

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
    private int damageTeammate5 = 0;
    [SerializeField]
    private int agileDamageTeammate5 = 0;

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
    private int damageTeammate6 = 0;
    [SerializeField]
    private int agileDamageTeammate6 = 0;

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
    private int damageTeammate7 = 0;
    [SerializeField]
    private int agileDamageTeammate7 = 0;

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
    private int damageTeammate8 = 0;
    [SerializeField]
    private int agileDamageTeammate8 = 0;

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
                Attack1.text += ":  <i> Att. " + (attackDamage1 + attackDamageBoostMina + ((float)damageBhealthMulti[0] * (float)(healthMina.getValue() / 50))) + "  Accur. -" + agileDamage1 + "  DMG+ " + attackDamageBoost1;
            }
            else if (agileDamage1 > 0 && attackDamageBoost1 > 0)
            {
                Attack1.text += ":  <i> Accur. -" + agileDamage1 + "  DMG+ " + attackDamageBoost1;
            }
            else if (attackDamage1 > 0 && attackDamageBoost1 > 0)
            {
                Attack1.text += ":  <i> Att. " + (attackDamage1 + attackDamageBoostMina + ((float)damageBhealthMulti[0] * (float)(healthMina.getValue() / 50))) + "  DMG+ " + attackDamageBoost1;
            }
            else if (attackDamage1 > 0 && attackDamageBoost1 > 0)
            {
                Attack1.text += ":  <i> Att. " + (attackDamage1 + attackDamageBoostMina + ((float)damageBhealthMulti[0] * (float)(healthMina.getValue() / 50))) + "  Accur. -" + agileDamage1;
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
                Attack1.text += ":  <i> Att. " + (attackDamage1 + attackDamageBoostMina + ((float)damageBhealthMulti[0] * (float)(healthMina.getValue() / 50)));
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
                Attack2.text += ":  <i> Att. " + (attackDamage2 + attackDamageBoostMina + ((float)damageBhealthMulti[1] * (float)(healthMina.getValue() / 50))) + "  Accur. -" + agileDamage2 + "  DMG+ " + attackDamageBoost2;
            }
            else if (agileDamage2 > 0 && attackDamageBoost2 > 0)
            {
                Attack2.text += ":  <i> Accur. -" + agileDamage2 + "  DMG+ " + attackDamageBoost2;
            }
            else if (attackDamage2 > 0 && attackDamageBoost2 > 0)
            {
                Attack2.text += ":  <i> Att. " + (attackDamage2 + attackDamageBoostMina + ((float)damageBhealthMulti[1] * (float)(healthMina.getValue() / 50))) + "  DMG+ " + attackDamageBoost2;
            }
            else if (attackDamage2 > 0 && attackDamageBoost2 > 0)
            {
                Attack2.text += ":  <i> Att. " + (attackDamage2 + attackDamageBoostMina + ((float)damageBhealthMulti[1] * (float)(healthMina.getValue() / 50))) + "  Accur. -" + agileDamage2;
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
                Attack2.text += ":  <i> Att. " + (attackDamage2 + attackDamageBoostMina + ((float)damageBhealthMulti[1] * (float)(healthMina.getValue() / 50)));
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

    public void abilityInfo5()
    {
        if (!(Attack5.text.Contains(":")))
        {
            if (attackDamage5 > 0 && agileDamage5 > 0 && attackDamageBoost5 > 0)
            {
                Attack5.text += ":  <i> Att. " + (attackDamage5 + attackDamageBoostMina + ((float)damageBhealthMulti[2] * (float)(healthMina.getValue() / 50))) + "  Accur. -" + agileDamage5 + "  DMG+ " + attackDamageBoost5;
            }
            else if (agileDamage5 > 0 && attackDamageBoost5 > 0)
            {
                Attack5.text += ":  <i> Accur. -" + agileDamage5 + "  DMG+ " + attackDamageBoost5;
            }
            else if (attackDamage5 > 0 && attackDamageBoost5 > 0)
            {
                Attack5.text += ":  <i> Att. " + (attackDamage5 + attackDamageBoostMina + ((float)damageBhealthMulti[2] * (float)(healthMina.getValue() / 50))) + "  DMG+ " + attackDamageBoost5;
            }
            else if (attackDamage5 > 0 && attackDamageBoost5 > 0)
            {
                Attack5.text += ":  <i> Att. " + (attackDamage5 + attackDamageBoostMina + ((float)damageBhealthMulti[2] * (float)(healthMina.getValue() / 50))) + "  Accur. -" + agileDamage5;
            }
            else if (attackDamageBoost5 > 0 && agileDamage5 <= 0 && attackDamage5 <= 0)
            {
                Attack5.text += ":  <i>DMG+ " + attackDamageBoost5;
            }
            else if (attackDamageBoost5 <= 0 && agileDamage5 > 0 && attackDamage5 <= 0)
            {
                Attack5.text += ":  <i>Accur. -" + agileDamage5;
            }
            else
            {
                Attack5.text += ":  <i> Att. " + (attackDamage5 + attackDamageBoostMina + ((float)damageBhealthMulti[2] * (float)(healthMina.getValue() / 50)));
            }

            if (damageTeammate5 > 0)
            {
                Attack5.text += " PID: " + damageTeammate5;
            }
        }
        else if (Attack5.text.Contains(":"))
        {
            string[] parts = Attack5.text.Split(':');

            // Take the first part (before the colon)
            string modifiedString = parts[0];

            Attack5.text = modifiedString;
        }
    }

    public void abilityInfo6()
    {
        if (!(Attack6.text.Contains(":")))
        {
            if (attackDamage6 > 0 && agileDamage6 > 0 && attackDamageBoost6 > 0)
            {
                Attack6.text += ":  <i> Att. " + (attackDamage6 + attackDamageBoostMina + ((float)damageBhealthMulti[3] * (float)(healthMina.getValue() / 50))) + "  Accur. -" + agileDamage6 + "  DMG+ " + attackDamageBoost6;
            }
            else if (agileDamage6 > 0 && attackDamageBoost6 > 0)
            {
                Attack6.text += ":  <i> Accur. -" + agileDamage6 + "  DMG+ " + attackDamageBoost6;
            }
            else if (attackDamage6 > 0 && attackDamageBoost6 > 0)
            {
                Attack6.text += ":  <i> Att. " + (attackDamage6 + attackDamageBoostMina + ((float)damageBhealthMulti[3] * (float)(healthMina.getValue() / 50))) + "  DMG+ " + attackDamageBoost6;
            }
            else if (attackDamage6 > 0 && attackDamageBoost6 > 0)
            {
                Attack6.text += ":  <i> Att. " + (attackDamage6 + attackDamageBoostMina + ((float)damageBhealthMulti[3] * (float)(healthMina.getValue() / 50))) + "  Accur. -" + agileDamage6;
            }
            else if (attackDamageBoost6 > 0 && agileDamage6 <= 0 && attackDamage6 <= 0)
            {
                Attack6.text += ":  <i>DMG+ " + attackDamageBoost6;
            }
            else if (attackDamageBoost6 <= 0 && agileDamage6 > 0 && attackDamage6 <= 0)
            {
                Attack6.text += ":  <i>Accur. -" + agileDamage6;
            }
            else
            {
                Attack6.text += ":  <i> Att. " + (attackDamage6 + attackDamageBoostMina + ((float)damageBhealthMulti[3] * (float)(healthMina.getValue() / 50)));
            }

            if (damageTeammate6 > 0)
            {
                Attack6.text += " PID: " + damageTeammate6;
            }
        }
        else if (Attack6.text.Contains(":"))
        {
            string[] parts = Attack6.text.Split(':');

            // Take the first part (before the colon)
            string modifiedString = parts[0];

            Attack6.text = modifiedString;
        }
    }

    public void abilityInfo3()
    {
        if (!(Attack3.text.Contains(":")))
        {
            if (attackDamage3 > 0 && agileDamage3 > 0 && attackDamageBoost3 > 0)
            {
                Attack3.text += ":  <i> Att. " + (attackDamage3 + attackDamageBoostJager + ((float)damageBhealthMulti[4] * (float)(healthJager.getValue() / 50))) + "  Accur. -" + agileDamage3 + "  DMG+ " + attackDamageBoost3;
            }
            else if (agileDamage3 > 0 && attackDamageBoost3 > 0)
            {
                Attack3.text += ":  <i> Accur. -" + agileDamage3 + "  DMG+ " + attackDamageBoost3;
            }
            else if (attackDamage3 > 0 && attackDamageBoost3 > 0)
            {
                Attack3.text += ":  <i> Att. " + (attackDamage3 + attackDamageBoostJager + ((float)damageBhealthMulti[4] * (float)(healthJager.getValue() / 50))) + "  DMG+ " + attackDamageBoost3;
            }
            else if (attackDamage3 > 0 && attackDamageBoost3 > 0)
            {
                Attack3.text += ":  <i> Att. " + (attackDamage3 + attackDamageBoostJager + ((float)damageBhealthMulti[4] * (float)(healthJager.getValue() / 50))) + "  Accur. -" + agileDamage3;
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
                Attack3.text += ":  <i> Att. " + (attackDamage3 + attackDamageBoostJager + ((float)damageBhealthMulti[4] * (float)(healthJager.getValue() / 50)));
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
                Attack4.text += ":  <i> Att. " + (attackDamage4 + attackDamageBoostJager + ((float)damageBhealthMulti[5] * (float)(healthJager.getValue() / 50))) + "  Accur. -" + agileDamage4 + "  DMG+ " + attackDamageBoost4;
            }
            else if (agileDamage4 > 0 && attackDamageBoost4 > 0)
            {
                Attack4.text += ":  <i> Accur. -" + agileDamage4 + "  DMG+ " + attackDamageBoost4;
            }
            else if (attackDamage4 > 0 && attackDamageBoost4 > 0)
            {
                Attack4.text += ":  <i> Att. " + (attackDamage4 + attackDamageBoostJager + ((float)damageBhealthMulti[5] * (float)(healthJager.getValue() / 50))) + "  DMG+ " + attackDamageBoost4;
            }
            else if (attackDamage4 > 0 && attackDamageBoost4 > 0)
            {
                Attack4.text += ":  <i> Att. " + (attackDamage4 + attackDamageBoostJager + ((float)damageBhealthMulti[5] * (float)(healthJager.getValue() / 50))) + "  Accur. -" + agileDamage4;
            }
            else if (attackDamageBoost4 > 0 && agileDamage4 <= 0 && attackDamage4 <= 0)
            {
                Attack4.text += ":  <i>DMG+ " + (attackDamageBoostJager);
            }
            else if (attackDamageBoost4 <= 0 && agileDamage4 > 0 && attackDamage4 <= 0)
            {
                Attack4.text += ":  <i>Accur. -" + agileDamage4;
            }
            else
            {
                Attack4.text += ":  <i> Att. " + (attackDamage4 + attackDamageBoostJager + ((float)damageBhealthMulti[5] * (float)(healthJager.getValue() / 50)));
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

    public void abilityInfo7()
    {
        if (!(Attack7.text.Contains(":")))
        {
            if (attackDamage7 > 0 && agileDamage7 > 0 && attackDamageBoost7 > 0)
            {
                Attack7.text += ":  <i> Att. " + (attackDamage7 + attackDamageBoostJager + ((float)damageBhealthMulti[6] * (float)(healthJager.getValue() / 50))) + "  Accur. -" + agileDamage7 + "  DMG+ " + attackDamageBoost7;
            }
            else if (agileDamage7 > 0 && attackDamageBoost7 > 0)
            {
                Attack7.text += ":  <i> Accur. -" + agileDamage7 + "  DMG+ " + attackDamageBoost7;
            }
            else if (attackDamage7 > 0 && attackDamageBoost7 > 0)
            {
                Attack7.text += ":  <i> Att. " + (attackDamage7 + attackDamageBoostJager + ((float)damageBhealthMulti[6] * (float)(healthJager.getValue() / 50))) + "  DMG+ " + attackDamageBoost7;
            }
            else if (attackDamage7 > 0 && attackDamageBoost7 > 0)
            {
                Attack7.text += ":  <i> Att. " + (attackDamage7 + attackDamageBoostJager + ((float)damageBhealthMulti[6] * (float)(healthJager.getValue() / 50))) + "  Accur. -" + agileDamage7;
            }
            else if (attackDamageBoost7 > 0 && agileDamage7 <= 0 && attackDamage7 <= 0)
            {
                Attack7.text += ":  <i>DMG+ " + attackDamageBoost7;
            }
            else if (attackDamageBoost7 <= 0 && agileDamage7 > 0 && attackDamage7 <= 0)
            {
                Attack7.text += ":  <i>Accur. -" + agileDamage7;
            }
            else
            {
                Attack7.text += ":  <i> Att. " + (attackDamage7 + attackDamageBoostJager + ((float)damageBhealthMulti[6] * (float)(healthJager.getValue() / 50)));
            }

            if (damageTeammate7 > 0)
            {
                Attack7.text += " PID: " + damageTeammate7;
            }
        }
        else if (Attack7.text.Contains(":"))
        {
            string[] parts = Attack7.text.Split(':');

            // Take the first part (before the colon)
            string modifiedString = parts[0];

            Attack7.text = modifiedString;
        }
    }

    public void abilityInfo8()
    {
        if (!(Attack8.text.Contains(":")))
        {
            if (attackDamage8 > 0 && agileDamage8 > 0 && attackDamageBoost8 > 0)
            {
                Attack8.text += ":  <i> Att. " + (attackDamage8 + attackDamageBoostJager + ((float)damageBhealthMulti[7] * (float)(healthJager.getValue() / 50))) + "  Accur. -" + agileDamage8 + "  DMG+ " + attackDamageBoost8;
            }
            else if (agileDamage8 > 0 && attackDamageBoost8 > 0)
            {
                Attack8.text += ":  <i> Accur. -" + agileDamage8 + "  DMG+ " + attackDamageBoost8;
            }
            else if (attackDamage8 > 0 && attackDamageBoost8 > 0)
            {
                Attack8.text += ":  <i> Att. " + (attackDamage8 + attackDamageBoostJager + ((float)damageBhealthMulti[7] * (float)(healthJager.getValue() / 50))) + "  DMG+ " + attackDamageBoost8;
            }
            else if (attackDamage8 > 0 && attackDamageBoost8 > 0)
            {
                Attack8.text += ":  <i> Att. " + (attackDamage8 + attackDamageBoostJager + ((float)damageBhealthMulti[7] * (float)(healthJager.getValue() / 50))) + "  Accur. -" + agileDamage8;
            }
            else if (attackDamageBoost8 > 0 && agileDamage8 <= 0 && attackDamage8 <= 0)
            {
                Attack8.text += ":  <i>DMG+ " + attackDamageBoost8;
            }
            else if (attackDamageBoost8 <= 0 && agileDamage8 > 0 && attackDamage8 <= 0)
            {
                Attack8.text += ":  <i>Accur. -" + agileDamage8;
            }
            else
            {
                Attack8.text += ":  <i> Att. " + (attackDamage8 + attackDamageBoostJager + ((float)damageBhealthMulti[7] * (float)(healthJager.getValue() / 50)));
            }

            if (damageTeammate8 > 0)
            {
                Attack8.text += " PID: " + damageTeammate8;
            }
        }
        else if (Attack8.text.Contains(":"))
        {
            string[] parts = Attack8.text.Split(':');

            // Take the first part (before the colon)
            string modifiedString = parts[0];

            Attack8.text = modifiedString;
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
                if (healthEnemy02 != null) { healthEnemy02.SetSliderValue(attackDamage1 + attackDamageBoostMina + ((float)damageBhealthMulti[0] * (float)(healthMina.getValue() / 50))); }
                if (healthEnemy03 != null) { healthEnemy03.SetSliderValue(attackDamage1 + attackDamageBoostMina + ((float)damageBhealthMulti[0] * (float)(healthMina.getValue() / 50))); }
                if (healthEnemy04 != null) { healthEnemy04.SetSliderValue(attackDamage1 + attackDamageBoostMina + ((float)damageBhealthMulti[0] * (float)(healthMina.getValue() / 50))); }

                if (attackDamageBoost1 > 0)
                {
                    attackDamageBoostMina += attackDamageBoost1;
                }
            }
            else
            {
                if (attackDamage1 > 0)
                {
                    healthEnemySelected.SetSliderValue(attackDamage1 + attackDamageBoostMina + ((float)damageBhealthMulti[0] * (float)(healthMina.getValue() / 50)));
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
                    if (healthEnemy02 != null){healthEnemy02.SetSliderValue(attackDamage2 + attackDamageBoostMina + ((float)damageBhealthMulti[1] * (float)(healthMina.getValue() / 50)));}
                    if (healthEnemy03 != null){healthEnemy03.SetSliderValue(attackDamage2 + attackDamageBoostMina + ((float)damageBhealthMulti[1] * (float)(healthMina.getValue() / 50)));}
                    if (healthEnemy04 != null){healthEnemy04.SetSliderValue(attackDamage2 + attackDamageBoostMina + ((float)damageBhealthMulti[1] * (float)(healthMina.getValue() / 50)));}
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
                    healthEnemySelected.SetSliderValue(attackDamage2 + attackDamageBoostMina + ((float)damageBhealthMulti[1] * (float)(healthMina.getValue() / 50)));
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
                    if (healthEnemy02 != null) { healthEnemy02.SetSliderValue(attackDamage5 + attackDamageBoostMina + ((float)damageBhealthMulti[2] * (float)(healthMina.getValue() / 50))); }
                    if (healthEnemy03 != null) { healthEnemy03.SetSliderValue(attackDamage5 + attackDamageBoostMina + ((float)damageBhealthMulti[2] * (float)(healthMina.getValue() / 50))); }
                    if (healthEnemy04 != null) { healthEnemy04.SetSliderValue(attackDamage5 + attackDamageBoostMina + ((float)damageBhealthMulti[2] * (float)(healthMina.getValue() / 50))); }
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
                    healthEnemySelected.SetSliderValue(attackDamage5 + attackDamageBoostMina + ((float)damageBhealthMulti[2] * (float)(healthMina.getValue() / 50)));
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
                    if (healthEnemy02 != null){healthEnemy02.SetSliderValue(attackDamage3 + attackDamageBoostJager + ((float)damageBhealthMulti[3] * (float)(healthJager.getValue() / 50)));}
                    if (healthEnemy03 != null){healthEnemy03.SetSliderValue(attackDamage3 + attackDamageBoostJager + ((float)damageBhealthMulti[3] * (float)(healthJager.getValue() / 50)));}
                    if (healthEnemy04 != null){healthEnemy04.SetSliderValue(attackDamage3 + attackDamageBoostJager + ((float)damageBhealthMulti[3] * (float)(healthJager.getValue() / 50)));}
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
                    healthEnemySelected.SetSliderValue(attackDamage3 + attackDamageBoostJager + ((float)damageBhealthMulti[3] * (float)(healthJager.getValue() / 50)));
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
                    if (healthEnemy02 != null){healthEnemy02.SetSliderValue(attackDamage4 + attackDamageBoostJager + ((float)damageBhealthMulti[4] * (float)(healthJager.getValue() / 50)));}
                    if (healthEnemy03 != null){healthEnemy03.SetSliderValue(attackDamage4 + attackDamageBoostJager + ((float)damageBhealthMulti[4] * (float)(healthJager.getValue() / 50)));}
                    if (healthEnemy04 != null){healthEnemy04.SetSliderValue(attackDamage4 + attackDamageBoostJager + ((float)damageBhealthMulti[4] * (float)(healthJager.getValue() / 50)));}
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
                    healthEnemySelected.SetSliderValue(attackDamage4 + attackDamageBoostJager + ((float)damageBhealthMulti[4] * (float)(healthJager.getValue() / 50)));
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
                    if (healthEnemy02 != null) { healthEnemy02.SetSliderValue(attackDamage6 + attackDamageBoostJager + ((float)damageBhealthMulti[5] * (float)(healthJager.getValue() / 50))); }
                    if (healthEnemy03 != null) { healthEnemy03.SetSliderValue(attackDamage6 + attackDamageBoostJager + ((float)damageBhealthMulti[5] * (float)(healthJager.getValue() / 50))); }
                    if (healthEnemy04 != null) { healthEnemy04.SetSliderValue(attackDamage6 + attackDamageBoostJager + ((float)damageBhealthMulti[5] * (float)(healthJager.getValue() / 50))); }
                }

                if (attackDamageBoost6 > 0)
                {
                    attackDamageBoostJager += attackDamageBoost6;
                }
            }
            else
            {
                if (attackDamage6 > 0)
                {
                    healthEnemySelected.SetSliderValue(attackDamage6 + attackDamageBoostJager + ((float)damageBhealthMulti[5] * (float)(healthJager.getValue() / 50)));
                }

                if (attackDamageBoost6 > 0)
                {
                    attackDamageBoostJager += attackDamageBoost6;
                }
            }

            if (harmTeammate6)
            {
                healthMina.SetSliderValue(damageTeammate6);
                if (attackDamageBoostMina - agileDamageTeammate6 >= 0)
                {
                    attackDamageBoostMina -= agileDamageTeammate6;
                }
            }

            if (recieveToPartnerDamage[5])
            {
                switchINCdamage = true;
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
                    if (healthEnemy02 != null) { healthEnemy02.SetSliderValue(attackDamage7 + attackDamageBoostJager + ((float)damageBhealthMulti[6] * (float)(healthJager.getValue() / 50))); }
                    if (healthEnemy03 != null) { healthEnemy03.SetSliderValue(attackDamage7 + attackDamageBoostJager + ((float)damageBhealthMulti[6] * (float)(healthJager.getValue() / 50))); }
                    if (healthEnemy04 != null) { healthEnemy04.SetSliderValue(attackDamage7 + attackDamageBoostJager + ((float)damageBhealthMulti[6] * (float)(healthJager.getValue() / 50))); }
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
                    healthEnemySelected.SetSliderValue(attackDamage7 + attackDamageBoostJager + ((float)damageBhealthMulti[6] * (float)(healthJager.getValue() / 50)));
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
                    if (healthEnemy02 != null) { healthEnemy02.SetSliderValue(attackDamage8 + attackDamageBoostJager + ((float)damageBhealthMulti[7] * (float)(healthJager.getValue() / 50))); }
                    if (healthEnemy03 != null) { healthEnemy03.SetSliderValue(attackDamage8 + attackDamageBoostJager + ((float)damageBhealthMulti[7] * (float)(healthJager.getValue() / 50))); }
                    if (healthEnemy04 != null) { healthEnemy04.SetSliderValue(attackDamage8 + attackDamageBoostJager + ((float)damageBhealthMulti[7] * (float)(healthJager.getValue() / 50))); }
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
        switchINCdamage = false;

        if(healthMina.getValue() > 0)
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
}