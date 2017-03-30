using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Upgrades : MonoBehaviour
{
    public int level = 0;

    public void Geklikt(int MoneyMult, int Cost, int PopularityUpgrade, int Welke)
    {
        Economy.money -= Cost;
        Economy.MoneyMultiplier += MoneyMult;
        Economy.popularity += PopularityUpgrade;
    }

    private void Update()
    {

    }

}
