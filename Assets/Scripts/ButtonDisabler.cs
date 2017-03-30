using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonDisabler : MonoBehaviour
{
    public Button Telefoon;
    public Sprite PhoneButton;
    public Sprite PhoneButton_disable;
    public AudioPlayer sound;
    float TelefoonOvergaan = 5;
    float TelefoonCooldown = 10;
    private bool ButtonPresbaar;

    void Start()
    {
        Telefoon = GetComponent<Button>();
        Telefoon.interactable = false;
        ButtonPresbaar = false;
        if (sound != null) sound.AddAudio("telephone", true, true, 1f, sound.FindClip("knightrider"));
    }

    public void ChangeButton()
    {
        Telefoon.image.overrideSprite = PhoneButton_disable;
        Telefoon.interactable = false;
    }

    public void TelefoonRing()
    {
        if (!sound.FindSource("telephone").isPlaying) sound.Play("telephone");
        Telefoon.interactable = true;
        Debug.Log("TELEFOON GAAT OVER");
        TelefoonOvergaan -= Time.deltaTime;

        if (TelefoonOvergaan <= 0)
        {
            //telefoon niet opgenomen.
            sound.Stop("telephone");
            ButtonPresbaar = false;
            TelefoonOvergaan = 5;
            Debug.Log("TELAAT");
        }

    }
    public void GeenBericht()
    {
        Telefoon.interactable = false;
        Debug.Log("GeenBericht");
        TelefoonCooldown -= Time.deltaTime;

        if (TelefoonCooldown <= 0)
        {
            ButtonPresbaar = true;
            TelefoonCooldown = 10;
        }

    }

    public void Update()
    {
        if (ButtonPresbaar == true)
        {
            TelefoonRing();
        }
        if (ButtonPresbaar == false)
        {
            GeenBericht();
        }

    }

    public void TelefoonOpnemen()
    {
        ButtonPresbaar = false;
        TelefoonOvergaan = 5;
    }


}
