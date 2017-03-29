using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Economy : MonoBehaviour
{
    //static variables
    public static double money = 1000000;
    public const double startMoney = 1000000;
    public static double laundredMoney = 0;
    public static double popularity = 70;
    public const double startPop = 70;
    public static double income = 10000;
    //public static double trust = 0.5;

    // Update is called once per frame
    void Update()
    {
        income -= (money / startMoney) * Time.deltaTime;

        money += income * Time.deltaTime;
        //popularity += trust * Time.deltaTime;

        //Debug.Log("Money: " + money + "\nPopularity: " + popularity);
    }
}
