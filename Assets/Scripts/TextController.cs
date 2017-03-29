using UnityEngine;
using UnityEngine.UI;
using System.Collections;


public class TextController : MonoBehaviour
{
    public Text text;
    public Text title;
    public Text keuzeLinks;
    public Text keuzeRechts;
    public Text NewsTitle;
    public Text NewsContent;
    public int L = 0;
    public int R = 0;
    

    void Start()
    {
        title.text = "...";
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
            title.text = "Je eerste beslissing";
            text.text = "Gefeliciteerd met je nieuwe baan. Je baan kent" +
                " veel belangrijke verantwoordelijkheden, zoals je laten omkopen" +
                " om nieuwe treinen te kopen of op vakantie gaan. We beginnen meteen" +
                " met een moeilijke beslissing: Wil je een dure stoel gemaakt van" +
                " tijgervel of een iets goedkopere stoel" +
                " gemaakt van iets minder goed tijgervel ?";
            keuzeLinks.text = "Tijgervel";
            keuzeRechts.text = "Minder goed tijgervel";
            NewsTitle.text = "Een nieuwe medewerker";
            NewsContent.text = "Er komt een CEO (oftwel baas) bij de Nederlandse Spoorwegen." +
                " Het wordt spannend de komen de weken. Wie wordt het en gaat het hem" +
                " wel lukken om alles op de rails te houden bij de Nederlandse Spoorwegen." +
                " Hij zal velen beslissingen moeten maken als het nieuwe bestuurslid." +
                " Wat kan er misgaan...";
        }
        if (L == 1 && R == 0)
        {
            title.text = "Blaadjes op het spoor";
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
            title.text = "Boom op spoor";
            text.text = "Ergens tussen Den helder en Maastricht is er een boom op het spoor" +
                " terecht gekomen na de storm van gisteravond. We hebben twee opties," +
                " we laten de boom lekker liggen totdat ‘ie is weggerot en laten de" +
                " treinen tot die tijd over het andere spoor rijden (twee richtingen op één spoor)," +
                " dat levert wel vertragingen op, of we halen de boom weg maar dat kost geld.";
            keuzeLinks.text = "Lekker laten liggen";
            keuzeRechts.text = "Weghalen";


        }
        if (L == 2 && R == 0)
        {
            title.text = "Boom op spoor";
            text.text = "Ergens tussen Den helder en Maastricht is er een boom op het spoor" +
                " terecht gekomen na de storm van gisteravond. We hebben twee opties," +
                " we laten de boom lekker liggen totdat ‘ie is weggerot en laten de" +
                " treinen tot die tijd over het andere spoor rijden (twee richtingen op één spoor)," +
                " dat levert wel vertragingen op, of we halen de boom weg maar dat kost geld.";
            keuzeLinks.text = "Lekker laten liggen";
            keuzeRechts.text = "Weghalen";


        }
        if (L == 0 && R == 1)
        {
            title.text = "Boom op spoor";
            text.text = "Ergens tussen Den helder en Maastricht is er een boom op het spoor" +
                " terecht gekomen na de storm van gisteravond. We hebben twee opties," +
                " we laten de boom lekker liggen totdat ‘ie is weggerot en laten de" +
                " treinen tot die tijd over het andere spoor rijden (twee richtingen op één spoor)," +
                " dat levert wel vertragingen op, of we halen de boom weg maar dat kost geld.";
            keuzeLinks.text = "Lekker laten liggen";
            keuzeRechts.text = "Weghalen";
        }

       
    }
    public void NewsLinksUpdate()
    {
        if (L == 0 && R == 0)
        {
            NewsTitle.text = "Een dure Kl**tzak";
            NewsContent.text = "Er is nieuws binnen over de nieuwe CEO, het blijkt dat zijn eerste beslissing genomen is." +
                "Hij wilt op een dure stoel zitten van tijgervel. Dit zal de NS wel veel geld kosten." +
                "Als dit maar goed komt met de rest van de jaren die hij nog bij de NS moet werken.";


        }

        if (L == 1 && R == 0)
        {
            NewsTitle.text = "Minder, minder, minder treinen";
            NewsContent.text = "Mensen zitten al te klagen dat he zo rustig is in hun tuin." +
                " Ondertussen is het heel druk op de stations terwijl er wordt omgeroepen:" +
                " 'Damens en Heren dit is een mededeling voor alle reizigers, wegens blaadjes op het spoor rijden er minder treinen." +
                " Dit kan zorgen voor langere reistijden.'";
        }

        if (L == 1 && R == 0)
        {
            NewsTitle.text = "";
            NewsContent.text = "";
        }

        if (L == 1 && R == 0)
        {
            NewsTitle.text = "";
            NewsContent.text = "";
        }

        if (L == 1 && R == 0)
        {
            NewsTitle.text = "";
            NewsContent.text = "";
        }
    }

    public void NewsRechtsUpdate()
    {
        if (L == 0 && R == 0)
        {
            NewsTitle.text = "Een iets minder dure Kl**tzak";
            NewsContent.text = "Er is nieuws binnen over de nieuwe CEO, het blijkt dat zijn eerste beslissing genomen is." +
                " Hij wilt op een dure stoel zitten van tweedehands tijgervel. Dit zal de NS wel veel geld kosten." +
                " Als dit maar goed komt met de rest van de jaren die hij nog bij de NS moet werken.";


        }
        if (L == 1 && R == 0)
        {
            NewsTitle.text = "Alles komt wel goed";
            NewsContent.text = "Ondanks al het glade weer heeft de NS besloten om treinen gewoon te laten rijden." +
                " 'wij willen onze klanten geen extra";
        }

        if (L == 1 && R == 0)
        {
            NewsTitle.text = "";
            NewsContent.text = "";
        }

        if (L == 1 && R == 0)
        {
            NewsTitle.text = "";
            NewsContent.text = "";
        }
    }
}
