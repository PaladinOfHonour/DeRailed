using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Upgrades : MonoBehaviour
{
    //Static variables used for upgrade calculations; static as they shouldn't be inst multiple times
    private int level = 0;
    private static int cost;            //full-amount
    private static int costFlux;        // %-Punt
    public const int startFlux = 5;
    private static float popFlux;       //index
    private static int incomeFlux;      //diff-amount
    public Subject subj;                //decides what upgrade

    /// <summary>
    /// Decides what upgrade is done
    /// </summary>
    public enum Subject
    {
        money = 0,
        popularity = 1
    }

    /// <summary>
    /// Core Upgrade logic
    /// </summary>
    /// <param name="subj">param for deciding what upgrade will be performed</param>
    public void Upgrade(Subject subj)
    {
        this.subj = subj;

        //checking for sucide
        if (Economy.money < cost) return;

        //processing cost
        cost *= 1 + (costFlux / 100);
        Economy.money -= cost;

        //processing gains
        Boons();

        //updating cost increase
        level++;
        costFlux = startFlux + (2 * costFlux);      //exponential cost increase
    }

    /// <summary>
    /// All different Upgrades
    /// </summary>
    private void Boons()
    {
        Debug.Log("Boons Called" + (int)subj);
        switch ((int)subj)
        {
            case 0:
                Economy.income += incomeFlux;           //Income Upgrade
                break;
            case 1:
                Economy.popularity *= popFlux;          //Popularity Upgrade
                break;
            default:
                Debug.Log("No upgrades were applied");
                break;

        }
    }

    /// <summary>
    /// Used for setting incomeFlux [full value]
    /// </summary>
    /// <param name="var">New vaue for incomeFlux</param>
    public void SetIncomeFlux(int var)
    {
        incomeFlux = var;
    }

    /// <summary>
    /// Used for setting popflux [index ex: 1.1]
    /// </summary>
    /// <param name="var">New vaue for popFlux</param>
    public void SetPopFlux(float var)
    {
        popFlux = var;
    }

    /// <summary>
    /// Used for setting cost [full value]
    /// </summary>
    /// <param name="var">New vaue for cost</param>
    public void SetCost(int var)
    {
        cost = var;
    }

}
