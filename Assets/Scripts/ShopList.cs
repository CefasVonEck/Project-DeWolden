using UnityEngine;
using TMPro;
using System;
using UnityEngine.SceneManagement;


public class ShopList : MonoBehaviour
{
    [SerializeField]
    private AbilityList playerCombatSTuff;

    [SerializeField]
    private String mainGameSceneName;
    [SerializeField]
    private String keepSceneLoaded;

    [SerializeField]
    private String[] abilityName = new String[5];
    [SerializeField]
    private int[] attackDamage1 = new int[5];
    [SerializeField]
    private int[] agileDamage1 = new int[5];
    [SerializeField]
    private int[] attackDamageBoost1 = new int[5];
    [SerializeField]
    private int[] maxAbilityUse = new int[5];
    [SerializeField]
    private int[] changeBeingUsed = new int[5];
    [SerializeField]
    private String[] attackUseMessage = new String[5];
    [SerializeField]
    private String[] userName1 = new String[5];
    [SerializeField]
    private bool[] hitAll = new bool[5] { true, true, true, true, true };
    [SerializeField]
    private bool[] canMiss = new bool[5] { true, true, true, true, true };
    [SerializeField]
    private bool[] harmTeammate = new bool[5] {true,true,true,true,true};
    [SerializeField]
    private int[] damageTeammate = new int[5];
    [SerializeField]
    private int[] agileDamageTeammate = new int[5];

    [SerializeField]
    TextMeshProUGUI AttackButton1;
    [SerializeField]
    TextMeshProUGUI AttackButton2;
    [SerializeField]
    TextMeshProUGUI AttackButton3;
    [SerializeField]
    TextMeshProUGUI AttackButton4;

    // Start is called before the first frame update
    void Start()
    {
        abilityInfo(0, AttackButton1);
        //abilityInfo(0, AttackButton1);
        if(script != null)
        {
            script.enabled = false;
        }
    }

    public void buyAbilityOne(int id)
    {
        playerCombatSTuff.replaceAbilityOne(0,abilityName[id], attackDamage1[id], agileDamage1[id], attackDamageBoost1[id], maxAbilityUse[id], changeBeingUsed[id], attackUseMessage[id], userName1[id], hitAll[id], canMiss[id], harmTeammate[id], damageTeammate[id], agileDamageTeammate[id]);
    }

    public void buyAbilityTwo(int id)
    {
        playerCombatSTuff.replaceAbilityOne(1, abilityName[id], attackDamage1[id], agileDamage1[id], attackDamageBoost1[id], maxAbilityUse[id], changeBeingUsed[id], attackUseMessage[id], userName1[id], hitAll[id], canMiss[id], harmTeammate[id], damageTeammate[id], agileDamageTeammate[id]);
    }

    private void abilityInfo(int id, TextMeshProUGUI Attack)
    {
        if (Attack != null && !(Attack.text.Contains(":")))
        {
            Attack.text = abilityName[id];

            if (attackDamage1[id] > 0 && agileDamage1[id] > 0 && attackDamageBoost1[id] > 0)
            {
                Attack.text += ":  <i> Att. " + (attackDamage1[id] + attackDamageBoost1[id]) + "  Accur. -" + agileDamage1[id] + "  DMG+ " + attackDamageBoost1[id];
            }
            else if (agileDamage1[id] > 0 && attackDamageBoost1[id] > 0)
            {
                Attack.text += ":  <i> Accur. -" + agileDamage1[id] + "  DMG+ " + attackDamageBoost1[id];
            }
            else if (attackDamage1[id] > 0 && attackDamageBoost1[id] > 0)
            {
                Attack.text += ":  <i> Att. " + (attackDamage1[id] + attackDamageBoost1[id]) + "  DMG+ " + attackDamageBoost1[id];
            }
            else if (attackDamage1[id] > 0 && attackDamageBoost1[id] > 0)
            {
                Attack.text += ":  <i> Att. " + (attackDamage1[id] + attackDamageBoost1[id]) + "  Accur. -" + agileDamage1[id];
            }
            else if (attackDamageBoost1[id] > 0 && agileDamage1[id] <= 0 && attackDamage1[id] <= 0)
            {
                Attack.text += ":  <i>DMG+ " + attackDamageBoost1[id];
            }
            else if (attackDamageBoost1[id] <= 0 && agileDamage1[id] > 0 && attackDamage1[id] <= 0)
            {
                Attack.text += ":  <i>Accur. -" + agileDamage1[id];
            }
            else
            {
                Attack.text += ":  <i> Att. " + (attackDamage1[id] + attackDamageBoost1[id]);
            }

            if (damageTeammate[id] > 0)
            {
                Attack.text += " PID: " + damageTeammate[id];
            }
        }
        else if (Attack != null && Attack.text.Contains(":"))
        {
            string[] parts = Attack.text.Split(':');

            // Take the first part (before the colon)
            string modifiedString = parts[0];

            Attack.text = modifiedString;
        }
    }

    [SerializeField]
    private TransportScriptData script;

    public void returnToScene()
    {
        script.enabled = true;
    }
}
