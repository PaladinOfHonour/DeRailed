using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Handles the entire economy of the game
/// </summary>
public class Economy : MonoBehaviour
{
    //static variables; static for acces in other scripts and since only one instance of each should exist
    public static double money = 1000000;
    public const double startMoney = 1000000;           //can't be changed after init
    public static double launderedMoney = 0;
    public static double popularity = 70;
    public const double startPop = 70;                  //can't be changed affter init
    public static double income = 1000000;              //10000 : balanced
    public static double siphon = 0;
    public static double trust = 0.5;
    public static double laundredMinute = 0;
    public static double MoneyMinute = 0;
    public bool passiveTrustGain = false;               //determines wether the player passively gains trust/pop

    /// <summary>
    /// Adjust Economy values; called once per frame
    /// </summary>
    void Update()
    {
        //income -= (money / startMoney) * Time.deltaTime;                    //income decreases as capital increases (optional)

        //money update logic
        MoneyMinute = (income - ((siphon * income) / 100));
        money += MoneyMinute * Time.deltaTime;             
        launderedMoney += ((siphon * income) / 100) * Time.deltaTime;        //adds siphoned money to LaundredMoney
        laundredMinute = ((siphon * income) / 100);
        if (passiveTrustGain) popularity += trust * Time.deltaTime;         //set Trustgain bool "true" if you wish for passive trust gain
    }

    /// <summary>
    /// Amount (%) that a player siphons off for money laundering each second;
    /// </summary>
    public void Siphon(float amount)
    {
        siphon = amount;
    }
}
