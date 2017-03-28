using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

/// <summary>
/// Class that enforces the different pages, idea from https://www.youtube.com/watch?v=PYrDztnGmUw
/// </summary>
public class CanvasSwap : MonoBehaviour
{
    public List<GameObject> pageList;
    public GameObject activePage;
    public CanvasGroup canvG;
    public int pageIndex;
    private int fade;
    public float growthRate, fadeRate;

    /// <summary>
    /// Initiates fields
    /// </summary>
    void Start()
    {
        pageList = new List<GameObject>();
        pageIndex = 0;

        /*
        fade = 0  -> No fade
        fade = 1  -> Fading In
        fade = 2  -> Fading Out
        */

        fade = 0;
        growthRate = 0.5f;
        fadeRate = 8f;
    }

    private void Update()
    {
        //update logic for smoot swapping
        switch (fade)
        {
            case 1:
                canvG.alpha += fadeRate * Time.deltaTime;
                break;
            case 2:
                canvG.alpha -= fadeRate * Time.deltaTime;
                activePage.transform.localScale = Vector3.one * growthRate * Time.deltaTime;
                break;
            case 0:
            default:
                break;
        }
    }

    /// <summary>
    /// called when one wants to display a new page; starts SwapPage coroutine.
    /// </summary>
    /// <param name="newPage">The Index of the page to be shown</param>
    public void NewPage(int newPage)
    {
        //checks if the newpage isn't the same as the active page
        if (newPage != pageIndex)
        {
            //starts a coroutine [unity special method] that swaps between canvasses
            StartCoroutine("SwapPage", newPage);
        }
    }

    /// <summary>
    /// Coroutine Method for swapping between pages.
    /// </summary>
    /// <param name="newPage">The Index of the page to be shown</param>
    /// <returns></returns>
    public IEnumerator SwapPage(int newPage)
    {
        //retrieve activePage alpha
        canvG = activePage.GetComponent<CanvasGroup>();
        canvG.alpha = 1f;
        fade = 2;

        //fade 
        //routine must return -> def 0
        while (canvG.alpha > 0) yield return 0;

        //close current page
        activePage.SetActive(false);

        //activate new page
        pageIndex = newPage;
        activePage = pageList[pageIndex];
        activePage.SetActive(true);
        canvG = activePage.GetComponent<CanvasGroup>();
        canvG.alpha = 0f;
        activePage.transform.localScale = Vector3.one * 0.95f;
        fade = 1;

        while (canvG.alpha < 1f || activePage.transform.localScale.x < 1f) yield return 0;

        //setting to correct variavles; redundancy
        canvG.alpha = 1f;
        activePage.transform.localScale = Vector3.one;
        fade = 0;
    }
}
