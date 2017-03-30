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
    public Text Gevolg;
    public Text Steelwaard;
    public Text MoneyMinute;
    public Text SteelMoneyMinute;

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
        Gevolg.text = "U bent Gekozen als CEO van de NS";
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
        MoneyMinute.text = Economy.MoneyMinute.ToString();
        SteelMoneyMinute.text = Economy.laundredMinute.ToString();

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
            keuzeRechts.text = "Minder, minder, minder treinen";
            keuzeLinks.text = "Alles komt wel goed";
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

        if (L == 3 && R == 0)
        {
            title.text = "Treinkaping in Rotterdam";
            text.text = "Eerste noemen ze ons nazi’s, dan tuigen ze de binnenstad af en als" +
                " klapper op de vuurpijl is er net bekend gemaakt ze de intercity" +
                " van Rotterdam naar verweggistan hebben gekaapt. Die turken gaan nu" +
                " echt te ver. Er zijn 1337 mensen aan boord en er wordt gevreesd dat als" +
                " we er niet snel gehandeld wordt, ze mensen gaan executeren. De volgende" +
                " beslissingen zijn van levensbelang. We kunnen Wilders als onderhandelaar" +
                " sturen om te proberen de mensen vrij te krijgen of we houden voet bij stuk;" +
                " We do not negotiate with terrorists! Zegt u het maar…";
            keuzeLinks.text = "Nuke them!";
            keuzeRechts.text = "Stuur Wilders";
        }

        if (L == 1 && R == 2)
        {
            title.text = "De koekjes zijn kut";
            text.text = "Het personeel klaagt al tijden over de koektrommel in " +
                "de kantine. Omdat deze niet goed sluit, worden de koekjes al " +
                "na twee dagen zacht. Een schande!... vinden zij. We kunnen zeggen " +
                "dat dat niet ons probleem is maar we kunnen ook proberen de fabrikant" +
                " van de koekjestrommel aan te klagen. Dat levert geld op en het " +
                "personeel is wat blijer maar er is ook een kans dat we die rechtszaak verliezen. ";
            keuzeLinks.text = "Niet ons probleem";
            keuzeRechts.text = "Schande! Aanklagen die oplichters";
        }

        if (L == 2 && R == 2)
        {
            title.text = "Personeel wil 1,1% meer loon";
            text.text = "We doen alles voor ze maar toch willen die aasgieren van de " +
                "vakbond meer geld. Ze eisen dat de lonen van het personeel met 1,1% " +
                "omhoog gaan. Het is een schande dat ze dat van ons kunnen eisen. En " +
                "nu dreigen ze zelfs met stakingen. Wat doen we nu? We kunnen simpel " +
                "toegeven aan hun eisen maar dat is prijzig. We kunnen natuurlijk ook de " +
                "fabrikant van de koekjestrommels in de kantines aanklagen. Er gaan geruchten rond " +
                "dat deze niet goed sluiten waardoor de koekjes snel oud worden en als we" +
                " ze aanklagen laten we zien dat we er wel zijn voor het personeel. Nu alleen wel" +
                " hopen dat we de rechtzaak winnen…";
            keuzeLinks.text = "Rechtzaak";
            keuzeRechts.text = "Betaal de lonen";
        }

        /*if (L == 30 && R == 30)
        {
            title.text = "";
            text.text = "";
            keuzeLinks.text = "";
            keuzeRechts.text = "";
        }*/


    }
    public void NewsLinksUpdate()
    {
        if (L == 0 && R == 0)
        {
            NewsTitle.text = "Een dure Kl**tzak";
            NewsContent.text = "Er is nieuws binnen over de nieuwe CEO, het blijkt dat zijn eerste beslissing genomen is." +
                "Hij wilt op een dure stoel zitten van tijgervel. Dit zal de NS wel veel geld kosten." +
                "Als dit maar goed komt met de rest van de jaren die hij nog bij de NS moet werken.";
            Economy.money -= 4000;
            Gevolg.text = "Gevolg: er is 4000 euro afgeschreven van de rekening van de NS";

        }

        if (L == 1 && R == 0)
        {
            NewsTitle.text = "Alles komt wel goed";
            NewsContent.text = "Ondanks al het glade weer heeft de NS besloten om treinen gewoon te laten rijden." +
                " ‘Wij willen onze klanten geen extra lange reistijden geven’ zegt de NS." +
                " ‘Blaadjes op het spoor kunnen geen gevaar leveren voor onze treinen. Dus laat ze maar reiden, wat kan er mis gaan’ zegt de ceo van de NS. ";
            Gevolg.text = "Er is niks gebeurd";
        }

        if (L == 0 && R == 1)
        {
            NewsTitle.text = "Wat een blunder";
            NewsContent.text = "De storm van afgelopen nacht zorgde ervoor dat een boom" +
                " was omgevallen Ergens tussen Den helder en Maastricht. Hierdoor is er een trein tegenaan gebotst." +
                " Gelukkig zijn er geen doden, maar wel 12 gewonden." +
                " achteraf bleek dat de NS van de boom wist maar er niks aan heeft gedaan.";
            Gevolg.text = "- 10% populariteit | Geld -4500";
            Economy.money -= 4500;
            Economy.popularity -= 10;
        }

        if (L == 2 && R == 0)
        {
            NewsTitle.text = "Even wachten op de NS maar dan anders!";
            NewsContent.text = " Wachten op de NS is normaal, maar nu snappen we waarom, " +
                "de NS drinkt teveel koffie. Gister is er een trein ontspoord in Vlissingen" +
                " door blaadjes op het spoor. Hier zijn gelukkig geen reizigers door gewond geraakt. " +
                "Wel zijn vele reizigers kwaad op de NS. ‘We stonden wel 3 uur te wachten tot we werden opgehaald’ " +
                "wordt gezegd door menige reizigers. ‘Het is toch absurd dat het zo lang duurt voordat ze ons ophalen’. " +
                "Waarom de NS zo laat kwam is nog niet bekend.";
            Gevolg.text = "- 15% populariteit | Geld -1200 (nieuwe trein)";
            Economy.money -= 1200;
            Economy.popularity -= 15;
        }

        if (L == 1 && R == 1)
        {
            NewsTitle.text = "Persconferentie";
            NewsContent.text = "De NS heeft gister een persconferentie gehouden, " +
                "hierin wilde ze duidelijk maken dat ze er alles aan doen om de " +
                "kwaliteit van de NS te verbeteren. Ze zeggen alleen dat de reizigers" +
                " wel geduldig moeten zijn. ‘We hebben jullie gehoord, en er komt verandering" +
                " we doen er alles aan vertrouw ons. Willen jullie meer of minder reistijd?’ zegt" +
                " de NS woordvoerder Geert Dekkers.";
            Gevolg.text = "+ 10% populariteit | Geld -200";
            Economy.money -= 200;
            Economy.popularity += 10;
        }

        if (L == 3 && R == 0)
        {
            NewsTitle.text = "Dode man gevonden in NS-kantoor Utrecht";
            NewsContent.text = "Vanochtend was er een man dood gevonden in een NS-kantoor in Utrecht. " +
                "Volgens de politie is het onduidelijk of het om zelfmoord of om moord gaat. De man is " +
                "vanochtend om 03:20 gevonden opgestroopt aan het plafond of de 3de verdieping van De Inktpot." +
                " De politie weet niet of het om zelfmoord gaat aangezien er geen zelfmoord-briefje is geschreven." +
                " Verder blijken er sporen van geweld op het lichaam te zijn (blauwen plekken etc.…). Ook is er " +
                "op de muur ‘Murderer’ geschreven. De heer P.J wordt aanstaande zondag begraven.";
            Gevolg.text = "U Bent vermoord door een boze menigte";
        }
        if (L == 1 && R == 2)
        {
            NewsTitle.text = "Medewerkers niet blij met Koekjes";
            NewsContent.text = "Er gaat een gerucht rond dat NS medewerkers in staking gaan. Ze voelen zich niet goed behandeld door hun werkgever. Wat voor gevolgen heeft dit voor de NS.";
        }
        if (L == 2 && R == 2)
        {
            //RNG roll Aanklaging
            NewsTitle.text = "";
            NewsContent.text = "WORDT AAN GEWERKT";
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
            Gevolg.text = "Gevolg: er is 2000 euro afgeschreven van de rekening van de NS";

            Economy.money -= 2000;

        }
        if (L == 1 && R == 0)
        {
            NewsTitle.text = "Minder, minder, minder treinen";
            NewsContent.text = "Mensen zitten al te klagen dat he zo rustig is in hun tuin." +
                " Ondertussen is het heel druk op de stations terwijl er wordt omgeroepen:" +
                " 'Damens en Heren dit is een mededeling voor alle reizigers, wegens blaadjes op het spoor rijden er minder treinen." +
                " Dit kan zorgen voor langere reistijden.'";
            Gevolg.text = "5 % minder populariteit. Geld -1500";
            Economy.money -= 1500;
            Economy.popularity -= 5;
        }

        if (L == 0 && R == 1)
        {
            NewsTitle.text = "Opruimen die stronk";
            NewsContent.text = "De storm van afgelopen nacht zorgde ervoor dat een boom " +
                "was omgevallen Ergens tussen Den helder en Maastricht. De NS heeft die met" +
                " man en macht snel opgeruimd. Er was maar een klein beetje vertraging en verder" +
                " geen probleem. Een goede keuze als je het aan mij vraagt.";
            Gevolg.text = "+ 10% populariteit | Geld -900";
            Economy.money -= 900;
            Economy.popularity += 10;
        }

        if (L == 2 && R == 0)
        {
            NewsTitle.text = "Goed en Slecht";
            NewsContent.text = " Gister is er een trein ontspoord in Vlissingen door blaadjes op het spoor." +
                " Hier zijn gelukkig geen reizigers door gewond geraakt. De oorzaak van het omval waren gladden" +
                " blaadjes op het spoor. Reizigers zijn boos doordat de NS hier wat aan had moeten doen, gelukkig" +
                " was de NS er wel snel bij om de mensen toch te vervoeren naar hun bestemming. ";
            Gevolg.text = "Geld -1400";
            Economy.money -= 1400;
        }

        if (L == 1 && R == 1)
        {
            NewsTitle.text = "Een betere reiskwaliteit";
            NewsContent.text = "De NS heeft geluisterd naar de reizigers. Er is verbetering te zien in de service" +
                " van de NS. Zo is de gemiddelde vertraging van treinen van 13 na 12 minuten gegaan. Ook het " +
                "aantal treinen dat niet rijdt is vermindert met 1%. Ook zijn de treinen langer gemaakt zodat mensen kunnen zitten." +
                " Dit kost de medewerkers van de NS wel meer inspanning.";
            Gevolg.text = "Geld -1200 (voor langere treinen)";
            Economy.money -= 1200;

        }

        if (L == 3 && R == 0)
        {
            NewsTitle.text = "Wilders onze held!";
            NewsContent.text = "Gisternacht is onze beste man Geert Wilders onthoofd." +
                " Na de kaping van de intercity van Rotterdam naar Verweggistan vroegen " +
                "de kapers om Geert Wilders als onderhandelaar. Ze wilde met niemand anders praten." +
                " Geert Wilders, als de dappere man die hij is. Heeft onderhandeld met de terroristen. " +
                "Wilders heeft zijn leven gegeven voor de 1337 passagiers die in de trein werden gegijzeld. " +
                "De terroristen zijn opgepakt en hebben 20 jaar cel gekregen voor moord en gijzeling. ";
            Gevolg.text = "Populariteit +15%";
            Economy.popularity += 15;
        }

        if (L == 1 && R == 2)
        {
            //RNG roll Aanklaging
            NewsTitle.text = "";
            NewsContent.text = "WORDT AAN GEWERKT";
        }
        if (L == 2 && R == 2)
        {
            NewsTitle.text = "Staking eindelijk over!";
            NewsContent.text = "Na drie dagen zonder treinen kunnen reizigers morgen weer in de ijzeren buis zitten. " +
                "De staking van de NS is voorbij. De medewerkers hebben hun zin gekregen en hebben nu 1.1% meer loon. ";
            Gevolg.text = "Populariteit +10% | geld -6800";
            Economy.money -= 6800;
            Economy.popularity += 10;
        }
    }
}
