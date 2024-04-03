using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AbilityList : MonoBehaviour
{
    [SerializeField]
    public String[] abilityName = new String[5];
    [SerializeField]
    public int[] attackDamage1 = new int[5];
    [SerializeField]
    public int[] agileDamage1 = new int[5];
    [SerializeField]
    public int[] attackDamageBoost1 = new int[5];
    [SerializeField]
    public int[] maxAbilityUse = new int[5];
    [SerializeField]
    public int[] changeBeingUsed = new int[5];
    [SerializeField]
    public String[] attackUseMessage = new String[5];
    [SerializeField]
    public String[] userName1 = new String[5];
    [SerializeField]
    public bool[] hitAll = new bool[5] { true, true, true, true, true };
    [SerializeField]
    public bool[] canMiss = new bool[5] { true, true, true, true, true };
    [SerializeField]
    public bool[] harmTeammate = new bool[5] { true, true, true, true, true };
    [SerializeField]
    public int[] damageTeammate = new int[5];
    [SerializeField]
    public int[] agileDamageTeammate = new int[5];


    // Start is called before the first frame update
    void Start()
    {
        //MonoBehaviour script = obj.GetComponentInChildren<MonoBehaviour>();
    }

    public void replaceAbilityOne(int id,String abilityName_, int attackDamage_, int agileDamage_, int attackDamageBoost_, int maxAbilityUse_, int changeBeingUsed_, String attackUseMessage_, String userName_, bool hitAll_, bool canMiss_, bool harmTeammate_, int damageTeammate_, int agileDamageTeammate_)
    {
        abilityName[id] = abilityName_;
        attackDamage1[id] = attackDamage_;
        agileDamage1[id] = agileDamage_;
        attackDamageBoost1[id] = attackDamageBoost_;
        maxAbilityUse[id] = maxAbilityUse_;
        changeBeingUsed[id] = changeBeingUsed_;
        attackUseMessage[id] = attackUseMessage_;
        userName1[id] = userName_;
        hitAll[id] = hitAll_;
        canMiss[id] = canMiss_;
        harmTeammate[id] = harmTeammate_;
        damageTeammate[id] = damageTeammate_;
        agileDamageTeammate[id] = agileDamageTeammate_;
    }

}
