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
    public Text Steelwaard;

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
        Steelwaard.text = Economy.siphon.ToString() + "%";

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
            title.text = "Ontsporing in Vlissingen";
            text.text = "Oh hemel. We krijgen net te horen dat er een trein is" +
                " ontspoord net buiten het station van Vlissingen (Zeeland)." +
                " Uhm… tja, zeeland. Er wordt gesuggereerd dat de sporen te glad" +
                " waren door blaadjes. Helaas moeten we hier toch wel iets aan doen" +
                " want we kunnen niet blijven zitten wachten totdat het wrak vanzelf wegrot." +
                " Of misschien wel… We kunnen meteen een reddingsoperatie op touw zetten" +
                " om het spoor zo snel mogelijk vrij te krijgen. We kunnen ook eerst nog" +
                " een kop koffie nemen en niet al te veel haast maken.";
            keuzeLinks.text = "Eerst kop koffie";
            keuzeRechts.text = "Meteen opruimen";
        }

        if (L == 1 && R == 1)
        {
            title.text = "Boze reizigers";
            text.text = "Reizigers zijn boos over de kwaliteit van de spoorwegen" +
                " en de treinen. We hebben hier mogelijk een aanstaande PR-ramp" +
                " dus daar moeten we iets aan doen. We kunnen gewoon een persconferentie" +
                " houden om wat vragen te beantwoorden en een paar handen schudden of we kunnen" +
                " (heel pijnlijk) onze service daadwerkelijk verbeteren maar dat kost klauwen met geld.";
            keuzeLinks.text = "Persconferentie";
            keuzeRechts.text = "Service verbeteren";
        }

        if (L == 2 && R == 0)
        {
            title.text = "";
            text.text = "";
            keuzeLinks.text = "";
            keuzeRechts.text = "";
        }

        if (L == 2 && R == 0)
        {
            title.text = "";
            text.text = "";
            keuzeLinks.text = "";
            keuzeRechts.text = "";
        }

        if (L == 2 && R == 0)
        {
            title.text = "";
            text.text = "";
            keuzeLinks.text = "";
            keuzeRechts.text = "";
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

        if (L == 0 && R == 1)
        {
            NewsTitle.text = "Wat een blunder";
            NewsContent.text = "De storm van afgelopen nacht zorgde ervoor dat een boom" +
                " was omgevallen Ergens tussen Den helder en Maastricht. Hierdoor is er een trein tegenaan gebotst." +
                " Gelukkig zijn er geen doden, maar wel 12 gewonden." + 
                " achteraf bleek dat de NS van de boom wist maar er niks aan heeft gedaan.";
        }

        if (L == 2 && R == 0)
        {
            NewsTitle.text = "";
            NewsContent.text = "";
        }

        if (L == 1 && R == 1)
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
                " ‘Wij willen onze klanten geen extra lange reistijden geven’ zegt de NS." +
                " ‘Blaadjes op het spoor kunnen geen gevaar leveren voor onze treinen. Dus laat ze maar reiden, wat kan er mis gaan’ zegt de ceo van de NS. ";
        }

        if (L == 0 && R == 1)
        {
            NewsTitle.text = "Opruimen die stronk";
            NewsContent.text = "De storm van afgelopen nacht zorgde ervoor dat een boom " +
                "was omgevallen Ergens tussen Den helder en Maastricht. De NS heeft die met" +
                " man en macht snel opgeruimd. Er was maar een klein beetje vertraging en verder" +
                " geen probleem. Een goede keuze als je het aan mij vraagt.";
        }

        if (L == 2 && R == 0)
        {
            NewsTitle.text = "";
            NewsContent.text = "";
        }
    }
}
