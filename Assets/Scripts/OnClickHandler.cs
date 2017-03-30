using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// An inbetween Handler To set certain defining variables.
/// </summary>
public class OnClickHandler : MonoBehaviour
{
    //Variables should be set in Editor
    public int cost;
    public float popFlux;
    public int incomeFlux;
    public Upgrades target;
    public Upgrades.Subject subj;

    /// <summary>
    /// Called OnClick button; Sets variables and calls upon calc script
    /// </summary>
    public void OnClick()
    {
        //setting variables
        target.SetPopFlux(popFlux);
        target.SetCost(cost);
        target.SetIncomeFlux(incomeFlux);

        //Final call
        target.Upgrade(subj);
    }

}