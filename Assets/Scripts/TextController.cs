using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class TextController : MonoBehaviour
{
    public Text text;
    public Text name;
    public Text keuzeLinks;
    public Text keuzeRechts;
    public Text NewsTitle;
    public Text NewsContent;
    public int L = 0;
    public int R = 0;
    

    void Start()
    {
        name.text = "...";
        text.text = "Finally... After hours of driving, here I am.";
        keuzeLinks.text = "Test links";
        keuzeRechts.text = "Test Rechts";
        NewsTitle.text = "Dit is een krante bericht xD";
        NewsContent.text = "CONTENT OP OP";
    }

   public void Lupper()
    {
        L = L + 1;
    }

    public void Rupper()
    {
        R = R + 1;
    }

    private void Update()
    {
        if (L == 0 && R == 0)
        {
            name.text = "Je eerste beslissing";
            text.text = "Gefeliciteerd met je nieuwe baan. Je baan kent" +
                " veel belangrijke verantwoordelijkheden, zoals je laten omkopen" +
                " om nieuwe treinen te kopen of op vakantie gaan. We beginnen meteen" +
                " met een moeilijke beslissing: Wil je een dure stoel gemaakt van" +
                " tijgervel of een iets goedkopere stoel" +
                " gemaakt van iets minder goed tijgervel ?";
            keuzeLinks.text = "Tijgervel";
            keuzeRechts.text = "Minder goed tijgervel";
        }
        if (L == 1 && R == 0)
        {
            name.text = "Blaadjes op het spoor";
            text.text = "Herfst is begonnen en daarmee arriveert staatsvijand" +
                " nummer één ook: vallende blaadjes. We moeten ons indekken " +
                "want anders loopt het spoor hopeloos vast. Als we minder treinen" +
                " laten rijden deze herfst, dan zijn er ook minder treinen vertraagd" +
                " maar dan wordt het nog drukker in de treinen die wel rijden." +
                " We kunnen ook gewoon de treinen laten en YOLO hopen dat alles goed komt.";
            keuzeLinks.text = "Minder, minder, minder treinen";
            keuzeRechts.text = "Alles komt wel goed";
        }
        if (L == 0 && R == 1)
        {
            name.text = "Boom op spoor";
            text.text = "Ergens tussen Den helder en Maastricht is er een boom op het spoor" +
                " terecht gekomen na de storm van gisteravond. We hebben twee opties," +
                " we laten de boom lekker liggen totdat ‘ie is weggerot en laten de" +
                " treinen tot die tijd over het andere spoor rijden (twee richtingen op één spoor)," +
                " dat levert wel vertragingen op, of we halen de boom weg maar dat kost geld.";
            keuzeLinks.text = "Lekker laten liggen";
            keuzeRechts.text = "Weghalen";

        }
    }
}
