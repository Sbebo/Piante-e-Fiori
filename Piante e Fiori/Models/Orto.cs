using Microsoft.Toolkit.Uwp.UI.Controls.TextToolbarSymbols;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Piante_e_Fiori.Models;

using Windows.UI.Xaml.Controls;

namespace Piante_e_Fiori.Models
{
//28 ORTO
    public class Orto
    {
        public string NomeComunePianta { get; set; }
        public string NomeFamiglia { get; set; }
        public string NomeScientificoPianta { get; set; }
        public string FotoPianta { get; set; }
        public string SourceGalleryFotografica { get; set; }
        public string LavoriOrto { get; set; }

        public string Semina { get; set; }
        public string CureColturali { get; set; }
        public string Raccolta { get; set; }
        public string PropietaeBenefici { get; set; }

        public string Varieta1 { get; set; } //Non usare varietà perchè l'accento crea problemi in fase di compilazione
        public string Varieta2 { get; set; }
        public string Varieta3 { get; set; }
        public string Varieta4 { get; set; }

        public string Malattia1 { get; set; }
        public string Malattia2 { get; set; }
        public string Malattia3 { get; set; }
        public string Malattia4 { get; set; }


    }

    public static class OrtoDataService
    {
        private static IEnumerable<Orto> AllOrto()
        {
            // The following is order summary data
            var data = new ObservableCollection<Orto>
            {
               
                new Orto
                {
                   NomeComunePianta = "AGLIO",
                   NomeFamiglia = "Alliacee",
                   NomeScientificoPianta = "Allium sativum",
                   FotoPianta = "ms-appx:///Immagini/Orto/Aglio/AGLIO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Orto/Abete-*.jpg",
                   LavoriOrto = "ms-appx:///Immagini/Orto/Aglio/calendario_lavori_aglio.jpg",


                   Semina = "PRIMA DI PROCEDERE ALLA SEMINA DEI BULBILLI, SI PREPARA IL LETTO DI SEMINA PER IMPEDIRE RISTAGNI IDRICI. OCCORRE SCEGLIERE I BULBILLI PIÙ ESTERNI DEL BULBO E TRATTARLI (CONCIA) CON UN PRODOTTO IN POLVERE PER PREVENIRE EVENTUALI MARCIUMI. SI TRACCIANO FILE DISTANTI 25-30 CM L’UNA DALL’ALTRA E SI POSIZIONANO I BULBILLI A 10-15 CM TRA LORO E A PROFONDITÀ DI 3-5 CENTIMETRI. SI SEMINA NEL PERIODO PRIMAVERILE NELLE REGIONI SETTENTRIONALI, IN AUTUNNO IN QUELLE MERIDIONALI. ",
                   CureColturali = "L’aglio è una pianta molto rustica e si adatta facilmente alle diverse condizioni di coltivazione. Le cure saranno quindi limitate all’asportazione delle erbe infestanti e alla sarchiatura del terreno per frantumare la crosta superfi ciale, oltre che per facilitare lo scolo dell’acqua. L’irrigazione andrà effettuata solo in casi di siccità prolungata. ",
                   Raccolta = "La raccolta inizia quando la vegetazione si secca e va da fine giugno (al Nord) all’inizio di luglio, per proseguire fino ad agosto.  Dopo la raccolta, le teste vanno lasciate asciugare fino a quando non si staccheranno facilmente dal resto della pianta.",
                   PropietaeBenefici = "L’aglio ha proprietà ipotensive, per cui è indicato per i soggetti con pressione sanguigna alta. È, inoltre, un antisettico delle vie aeree e un antibatterico, in particolare contro i microrganismi responsabili delle infezioni intestinali. Inoltre, stimola la secrezione di bile ed è utile quando è necessario un forte richiamo di sangue nei tessuti (reumatismi, torcicollo ecc.).",

                    Varieta1 = "AGLIO BIANCO È la varietà più coltivata in Italia, sia per la quantità prodotta e sia per la qualità ottenuta.",
                    Varieta2 = "AGLIO ROSA Coltivato prevalentemente nelle regioni meridionali, è più precoce del precedente, dal quale si distingue per le tuniche esterne del bulbillo, di colore rosa, e per il sapore meno intenso. Si consuma fresco. ",
                    Varieta3 = "AGLIO ROSSO Meglio noto come Rosso di Sulmona, si presenta di colore bianco all’esterno del bulbo, mentre le tuniche che rivestono i bulbilli sono caratterizzate da una tonalità leggermente violacea. Il suo sapore è più marcato delle altre varietà di aglio e, inoltre, ha una migliore conservabilità.",

                    Malattia1 = "Fusariosi e nematodi: effettuate rotazioni lunghe delle colture: 3-4 anni prima di piantare l’aglio o altri ortaggi della stessa famiglia (cipolla, scalogno, porro) nella medesima proda. Utile è la copertura del terreno con teli plastici trasparenti (solarizzazione) per 1-2 mesi tra luglio e agosto. ",
                    Malattia2 = "Botrite, marciume bianco, marciume verde: evitate la piantagione in terreni con ristagni d’acqua; curate lo sgrondo dell’acqua ed effettuate l’impianto a fine inverno.",
                    Malattia3 = "Tignola: è difficile da combattere, in quanto le larve sono all’interno delle foglie; eliminate subito le piante colpite.",
                },

                new Orto
                {
                   NomeComunePianta = "ANGURIA",
                   NomeFamiglia = "Cucurbitacee",
                   NomeScientificoPianta = "Citrullus lanatus",
                   FotoPianta = "ms-appx:///Immagini/Orto/Anguria/ANGURIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Orto/Abete-*.jpg",
                   LavoriOrto = "ms-appx:///Immagini/Orto/Anguria/calendario_lavori_anguria.jpg",

                   Semina = "IL COCOMERO HA ESIGENZE TERMICHE ELEVATE: LA TEMPERATURA MINIMA DI GERMINAZIONE È DI 15 °C, QUINDI SI SEMINA SOLO A PRIMAVERA AVANZATA (APRILE-MAGGIO). SI PONGONO VICINI 4-5 SEMI, POI SI DIRADANO LE PIANTINE NATE, LASCIANDONE 2 PER POSTARELLA. IL SESTO D’IMPIANTO È MOLTO LARGO: 2-3 M TRA LE FILE E 1,5-2 M TRA LE POSTARELLE, IN MODO CHE PER OGNI METRO QUADRO LA DENSITÀ SIA DI 0,3-0,5 PIANTE. I TERRENI PIÙ ADATTI SONO QUELLI PROFONDI, ACIDI E SCIOLTI, O PER TESSITURA O PER STRUTTURA.",
                   CureColturali = "Il controllo delle infestanti si effettua con ripetute sarchiature. Alla comparsa della quinta foglia si cima il tralcio per favorire l’emissione di getti ascellari, dai quali ottenere più frutti. Il massimo fabbisogno d’acqua si ha dall’allegagione dei fiori all’ingrossamento dei frutti. All’approssimarsi della raccolta l’irrigazione va sospesa per favorire la concentrazione degli zuccheri nei frutti, che sono pronti 4 mesi dopo la semina",
                   Raccolta = "Si effettua a scalare durante l'estate quando il frutto è maturo (empiricamente si può dire quando il viticcio del peduncoloè secco e sul frutto si evidenzia la caratteristica pruina). L'anguria può esssere conservata a 15-25°C per una settimana.",
                   PropietaeBenefici = "L'anguria ha un buon quantitativo di zuccheri e una elevata percentuale di acqua (circa il 95%) per cui è un frutto scarsamente nutritivo ma energetico e può quasi sostituire un pasto (pranzo o cena). Svolge una buona azione diuretica. Contiene le vitamine A e C.",

                    Varieta1 = "",
                    Varieta2 = "",
                    Varieta3 = "",

                    Malattia1 = "Afidi, mosca bianca, nottue fogliari e terricole, elateridi, tripidi e acari",
                    Malattia2 = "Oidio, peronospora, muffa grigia, sclerotina, Pythium e batteriosi",
                    Malattia3 = "",
                },

                new Orto
                {
                   NomeComunePianta = "CAROTA",
                   NomeFamiglia = "Ombrellifere",
                   NomeScientificoPianta = "Daucus carota",
                   FotoPianta = "ms-appx:///Immagini/Orto/Carota/CAROTA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Orto/Abete-*.jpg",
                   LavoriOrto = "ms-appx:///Immagini/Orto/Carota/calendario_lavori_carota.jpg",

                   Semina = "LE PRODE DEVONO ESSERE RIALZATE DI 10-15 CM RISPETTO AL PIANO DI CAMPAGNA. SI TRACCIANO FILE DISTANTI TRA LORO 20-25 CM E SI SPARGONO I SEMI IN RAGIONE DI 1 G/MQ, PROCEDENDO NORMALMENTE A PARTIRE DA MARZO, IN QUANTO LA TEMPERATURA MINIMA NECESSARIA PER LA GERMINAZIONE (CHE AVVIENE DOPO 10-15 GIORNI) È DI 10 °C. SI POSSONO ESEGUIRE SEMINE A INTERVALLI DI UN MESE SINO A GIUGNO E ANCORA UNA SEMINA A FINE LUGLIO PER IL RACCOLTO AUTUNNALE.",
                   CureColturali = "Il primo si esegue quando le piantine hanno raggiunto 4 cm di altezza e si ripete all’altezza di 8 cm, in modo che rimangano 7-10 cm tra una pianta e l’altra. Bisogna irrigare spesso, per aspersione o a pioggia, evitando periodi di siccità responsabili del rallentamento o del blocco della crescita del fittone . All’inizio la crescita è lenta: bisogna eseguire la sarchiatura dell’interfila e la rimozione manuale delle infestanti sulla fila, coprendo di terra eventuali radici esposte alla luce, perché diventerebbero verdi.",
                   Raccolta = "Per le varietà lunghe comincia in giugno e prosegue fino a novembre. Le varietà precoci primaverili a radice corta sono pronte 40 giorni dopo la semina.",
                   PropietaeBenefici = "La carota contiene elevate quantità di carotene, precursore della vitamina A, e vitamina C. Inoltre, attenua le infiammazioni di stomaco e intestino, stimola la diuresi e depura l’organismo; infatti essa decongestiona e purifica le pelli infiammate, lenisce le scottature e agisce come stimolante cutaneo. I semi di carota hanno proprietà aperitive e digestive e, secondo alcuni, aumentano la secrezione lattea.",

                    Varieta1 = "RADICE CORTA Tonda di Parigi, Rossa d’Olanda, Rossa Corta (precoci).",
                    Varieta2 = "RADICE MEZZA LUNGA Nantese di Chantenay, Mercato di Sottomarina, Rossa Mezzana di Amsterdam.",
                    Varieta3 = "RADICE LUNGA Berlicum, Florence, Lunga di Napoli, Lunga di Saint-Valéry.",

                    Malattia1 = "Marciumi e Sclerotinia: eseguire una rotazione lunga delle colture (3-4 anni) e curate lo sgrondo delle acque dal terreno; bisogna evitare l’uso di letame e di concimazioni troppo abbondanti e asportare i residui delle colture. ",
                    Malattia2 = "Alternaria: eseguite concimazioni non abbondanti e adottate il sistema di irrigazione per infiltrazione laterale per non bagnare le foglie. Mantenete le piante distanziate e arieggiate; se fosse indispensabile fate un trattamento a base di ossicloruro di rame-20 (60-80 g/10 l d’acqua).",
                    Malattia3 = "",
                },

                new Orto
                {
                   NomeComunePianta = "CAVOLI, CAVOLETTI E CAVOLFIORI",
                   NomeFamiglia = "Crucifere",
                   NomeScientificoPianta = "Brassica oleracea",
                   FotoPianta = "ms-appx:///Immagini/Orto/Cavoli/CAVOLI.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Orto/Abete-*.jpg",
                   LavoriOrto = "ms-appx:///Immagini/Orto/CAVOLI/calendario_lavori_cavoli.jpg",

                   Semina = "B. O. CAPITATA È COLTIVATA PER LE FOGLIE LISCE (CAVOLO CAPPUCCIO) O BOLLOSE (VERZA); B. O. BULLATA GOMMIFERA (CAVOLINO DI BRUXELLES) PER I GERMOGLI SFERICI E TENERI CHE SI FORMANO ALL’ASCELLA DELLE FOGLIE; B. O. BOTRYTIS CIMOSA (BROCCOLO) PER I BOCCIOLI DEI FIORI, COME IL CAVOLFIORE (B.O. BOTRYTIS); B.O. ACEPHALA (CAVOLO NERO) PER LE FOGLIE SOTTILI E DOLCI. I CAVOLI RICHIEDONO TERRENI FERTILI, BEN LAVORATI E STRUTTURATI. SI SEMINA A INIZIO PRIMAVERA, IMPIEGANDO 2-3 G/MQ DI SEME. ",
                   CureColturali = "La coltura va tenuta sarchiata sia tra le file sia sulla fila per mantenere pulito il terreno da infestanti. La base va rincalzata con la terra. L’irrigazione dovrà essere abbondante soprattutto nel periodo che segue il trapianto, per evitare che le giovani piante vadano incontro a stress idrici irreversibili. Nelle coltivazioni autunnali va evitato il fenomeno della fioritura anticipata, che rende le piante non più adatte al consumo.",
                   Raccolta = "La raccolta si effettua quando le parti destinate al consumo raggiungono le dimensioni e la consistenza tipiche delle varietà. Per i cavolini di Bruxelles, i broccoli e i cavoli neri palmizi (come il toscano) la raccolta è scalare e può avvenire per un lungo periodo tra l’autunno e la primavera. La resa nella coltivazione è sempre alta; per i cavoli cappucci si aggira tra 20 e 30 kg in media per 10 mq di terreno.",
                   PropietaeBenefici = "",

                    Varieta1 = "CAVOLO CAPPUCCIO Express, con testa di forma conica, piede corto, primaverile; Cuore di Bue Grosso, semiprecoce, primaverile; Cavolo cappuccio di Brunswick olandese; Quintale di Alsazia tardivo; Rosso Testa di Negro. ",
                    Varieta2 = "CAVOLO VERZA Quarantino, precoce estivo; di Asti e Padovano, entrambi estivi; di Napoli, Savoy King F1 autunnali; di Milano, Piacentino, Napoli Tardivo, Principe d’Inverno, tutti a maturazione invernale. ",
                    Varieta3 = "CAVOLINO DI BRUXELLES Jade Cross, precoce e adatto alla coltivazione nelle regioni calde; Perfezione, da raccogliere tra l’inverno e l’inizio della primavera. ",
                    Varieta4 = "CAVOLFIORE Tra le varietà a raccolta autunnale precoce Primaticcio Toscano e Meraviglia di Tutte le Stagioni; tra quelle tardive e invernali Natalino, Gennarese e Febbrarese.",

                    Malattia1 = "Fusariosi e phoma: colpiscono in modo particolare i semenzai e i cavoli nelle prime fasi di sviluppo; è necessario partire da piantine sane, meglio se prodotte in proprio. ",
                    Malattia2 = "Cavolaia: i bruchi di questa farfalla bianca sono la causa più frequente di rosure sulle foglie; se sono pochi, basta raccoglierli a mano, ma in caso di forti infestazioni potete usare il Bacillus thuringiensis (10-20 g/10 l d’acqua), attendendo poi 3 giorni prima di raccogliere.",
                    Malattia3 = "",
                },

                new Orto
                {
                   NomeComunePianta = "CETRIOLO",
                   NomeFamiglia = "Cucurbitacee",
                   NomeScientificoPianta = "Cucumis sativa",
                   FotoPianta = "ms-appx:///Immagini/Orto/Cetriolo/CETRIOLO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Orto/Abete-*.jpg",
                   LavoriOrto = "ms-appx:///Immagini/Orto/CETRIOLO/calendario_lavori_cetriolo.jpg",

                   Semina = "SI PONGONO I SEMI IN GRUPPI DI 2-3, A CIRCA 3 CM DI PROFONDITÀ, DIRETTAMENTE NEL TERRENO A UNA DISTANZA DI 4050 CM TRA UNA POSTA E L’ALTRA. UNA VOLTA GERMINATI, SI ESEGUE IL DIRADAMENTO LASCIANDO LE PIANTINE PIÙ VIGOROSE. LA SEMINA AVVIENE A PARTIRE DA MAGGIO ALL’APERTO, MA SIN DA MARZO AL RIPARO IN VASETTI SINGOLI PONENDO 3 SEMI IN OGNI VASETTO. IN SEGUITO SI TIENE SOLO LA PIANTA PIÙ VIGOROSA, CHE VA TRAPIANTATA ALL’APERTO NEL MESE DI MAGGIO.",
                   CureColturali = "Si eliminano le infestanti, soprattutto nel primo periodo di accrescimento. Dopo la formazione di 3-4 foglie, si procede alla cimatura, per facilitare lo sviluppo dei germogli laterali. Si irriga in modo regolare e abbondante nei periodi molto caldi, altrimenti i frutti diventano amarognoli.  La vegetazione può essere lasciata correre sul terreno oppure si può farla arrampicare realizzando apposite strutture di sostegno.",
                   Raccolta = "Al raggiungimento di dimensioni e consistenza tipiche della varietà coltivata, procedete alla raccolta dei frutti, staccandoli con un coltellino per evitare di lesionare lo stelo o la buccia del frutto stesso. La raccolta si protrae, abbondantissima e continua, da giugno a settembre.",
                   PropietaeBenefici = "Il frutto del cetriolo contiene molta acqua, sali minerali, amminoacidi, vitamina C e carotene, che gli conferiscono buone proprietà diuretiche e depurative. Il frutto può essere consumato fresco in insalata oppure centrifugato e diluito in acqua come bibita dissetante. Un impiego interessante del cetriolo è quello cosmetico; la polpa ha infatti la proprietà di schiarire la pelle, decongestionandola e idratandola.",

                    Varieta1 = "A FRUTTO PICCOLO (adatti per la preparazione in salamoia, se raccolti quando sono lunghi 4-10 cm) Wisconsin, Piccolo di Parigi, Blitz, Bounty. ",
                    Varieta2 = "A FRUTTO MEDIO (verde scuro, di 18-24 cm di lunghezza) Marketer e Marketmore. ",
                    Varieta3 = "A FRUTTO LUNGO (scanalati, lunghi 3035 cm) Brunex, Daleva, Lungo di Cina.",

                    Malattia1 = "Fusariosi e marciumi: usate sementi sane e disinfettate, impiegate nella produzione delle piantine un terriccio sterile da semina ed effettuate la rotazione colturale. ",
                    Malattia2 = "Oidio: solo se indispensabile, a causa di un grave attacco si può intervenire con zolfo bagnabile-80 (10 g/10 l d’acqua) nelle ore più fresche ed evitando la raccolta dei frutti per almeno 7 giorni. Se il problema si ripete tutti gli anni, piantate solo varietà e ibridi di prima generazione (F1) di provata resistenza a questa malattia crittogamica, quali Green Fall F1, Sensation F1, Kudos F1, Triumph F1, Scout F1, Darina F1, Columbus F1, Egnazia F1.",
                    Malattia3 = "",
                },

                new Orto
                {
                   NomeComunePianta = "CICORIA",
                   NomeFamiglia = "Composite",
                   NomeScientificoPianta = "Cichorium intybus",
                   FotoPianta = "ms-appx:///Immagini/Orto/Cicoria/CICORIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Orto/Abete-*.jpg",
                   LavoriOrto = "ms-appx:///Immagini/Orto/CICORIA/calendario_lavori_cicoria.jpg",

                   Semina = "LA PREPARAZIONE DEL LETTO DI SEMINA DEVE ESSERE ACCURATA PER SEMINE IN PERIODI DIVERSI: ALL’INIZIO DELLA PRIMAVERA PER LE CICORIE A FOGLIE VERDI, DA FINE MAGGIO A LUGLIO PER I RADICCHI D’AUTUNNO O D’INVERNO, CHE POSSONO ANCHE ESSERE SOTTOPOSTI A FORZATURA INVERNALE. SE SI PARTE DAL TRAPIANTO, SI TRACCIANO FILE DISTANTI TRA LORO 20-25 CM; A DISTANZA SULLA FILA DI 20-25 CM SI PONGONO LE PIANTINE IN BUCHETTE PROFONDE 5-9 CM, POI SI RINCALZA LA TERRA ATTORNO ALLA PIANTA.",
                   CureColturali = "Occorre eliminare con regolarità le erbe infestanti in quanto, oltre a sottrarre elementi nutritivi alla cicoria stessa, aumentano le probabilità di trasmissione di pericolosi virus veicolati dagli afidi. L’irrigazione, fondamentale per le cicorie estive, deve essere eseguita senza bagnare le foglie. In estate, buoni apporti d’acqua riducono al minimo la prefioritura, che impedisce la formazione dei cespi commestibili. ",
                   Raccolta = "Con il raggiungimento delle dimensioni e della consistenza tipiche delle varietà, si procede alla raccolta scalare, tagliando le foglie alla base, in corrispondenza del colletto. Le foglie esterne, più dure, vanno scartate. In media da 1 mq coltivato con cicoria rossa di Treviso si può ottenere una produzione di 20 radici, pari a 1 kg circa di germogli teneri.",
                   PropietaeBenefici = "Squisite in insalata, le cicorie possono essere usate anche per decotti, infusi e tinture per il benessere dell’organismo. Le foglie stimolano le funzioni intestinali, del fegato e dei reni, con un conseguente effetto depurativo e disintossicante per l’intero organismo",

                    Varieta1 = "CICORIE DA FOGLIA Selvatica, a foglie di colore verde scuro o rossastre, pelose;",
                    Varieta2 = "CICORIE A RADICE GROSSA Cicoria di Magdeburgo e Cicoria di Witloof. Quest’ultima, con la forzatura invernale al riparo, emette germogli bianchi, teneri e amarognoli noti come Cicoria di Bruxelles.",
                    Varieta3 = "",

                    Malattia1 = "Muffa grigia, Sclerotinia e Pythium: eseguite la rotazione delle colture (2-3 anni prima di ripiantare la cicoria nello stesso terreno), garantite un ottimo sgrondo dell’acqua dal terreno e distruggete i residui di coltivazione. Con un’infezione in atto potete tentare di limitare i danni eseguendo delle irrorazioni localizzate con una soluzione di ossicloruro di rame-20 (80-90 g/10 l d’acqua) cercando di bagnare bene il colletto.",
                    Malattia2 = "Bremia, Alternaria, muffa grigia e oidio: eseguite la rotazione delle colture (come sopra); fate trapianti non troppo fitti. Alcune varietà sono più resistenti alla bremia (per esempio Columbus, Lido, Big Boston, Elsa, Jessy, Saladin, Malika, Odessa, Melissa, Canasta). Quando i cespi vengono legati per l’imbianchimento, le piante devono essere ben asciutte.",
                    Malattia3 = "",
                },

                new Orto
                {
                   NomeComunePianta = "CIPOLLA",
                   NomeFamiglia = "Alliacee",
                   NomeScientificoPianta = "Allium cepa",
                   FotoPianta = "ms-appx:///Immagini/Orto/Cipolla/CIPOLLA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Orto/Abete-*.jpg",
                   LavoriOrto = "ms-appx:///Immagini/Orto/CIPOLLA/calendario_lavori_cipolla.jpg",

                   Semina = "SI ESEGUE UNA VANGATURA PROFONDA ALMENO 25 CENTIMETRI. SI SOPRAELEVANO LE PRODE DI 10-15 CM PER RIDURRE IL RISCHIO DI PERICOLOSI RISTAGNI IDRICI. SI PONGONO LE PIANTINE DA TRAPIANTARE (DI ALMENO 15-20 CM DI ALTEZZA E CON 3-5 FOGLIOLINE) IN FILE DISTANTI 30-40 CM E A 15-20 CM SULLA FILA. L’EPOCA DI SEMINA È FEBBRAIO-MARZO, QUELLA DI TRAPIANTO APRILE. LE CIPOLLINE SI SEMINANO DIRETTAMENTE A DIMORA; I CIPOLLOTTI SI TRAPIANTANO DURANTE IL MESE DI OTTOBRE E SI RACCOLGONO LA PRIMAVERA SUCCESSIVA.",
                   CureColturali = "La cipolla ha un accrescimento molto lento nei primi periodi dopo il trapianto e soffre la competizione delle infestanti, che vanno estirpate. Si deve irrigare solo se necessario, nei periodi caldi, senza bagnare la vegetazione, sospendendo 20 giorni prima della raccolta.",
                   Raccolta = "Le cipolle possono essere consumate durante qualsiasi fase del loro ciclo di accrescimento. Mentre per i bulbi precoci risulterà utile l’impiego della vanga, in modo da scalzare le piante ancora saldamente ancorate al terreno, per quelli più tardivi si procede alla raccolta quando le foglie sono diventate secche e i bulbi cominciano ad affiorare dal terreno. La raccolta avviene a partire da luglio e si protrae per tutto agosto. Da 10 mq di terreno si ottengono in media 20-40 kg di prodotto. ",
                   PropietaeBenefici = "Consumata cruda è un ottimo diuretico, disinfetta l’intestino, abbassa la pressione sanguigna e il tasso di glucosio nel sangue; cotta è ritenuta un regolatore intestinale. Usata esternamente, svolge un’azione antisettica e stimola la circolazione periferica; il succo è utile per neutralizzare le punture di insetti e ragni. Una curiosità: se l’odore non fosse incompatibile con l’uso cosmetico, la cipolla sarebbe un ottimo vitalizzante del cuoio capelluto, in quanto stimola il bulbo pilifero e ritarda la caduta dei capelli.",

                    Varieta1 = "PRECOCI Apriatica, appiattita e grossa; Bianca di Giugno, bulbo tondo e bianco lucido; Bianca di Pompei, Bianca di Barletta, Bianca di Maggio.",
                    Varieta2 = "TARDIVE Rossa di Tropea, Fiascona di Firenze e Piacentina, tutte rosse e aromatiche; Agostana, Blanco Duro, Tardiva d’Argento. ",
                    Varieta3 = "DA CIPOLLOTTI Bianca di Lisbona, White Knight.",

                    Malattia1 = "Fusariosi e botrite: eseguite la rotazione delle colture (attendete almeno 3 anni prima di far ritornare la cipolla nella stessa proda); inoltre eseguite concimazioni e irrigazioni contenute e provvedete a un perfetto sgrondo delle acque piovane e di irrigazione. Alcune varietà sono più resistenti alla fusariosi, per esempio la Dorata di Parma, selezione Erso 1 e 2.",
                    Malattia2 = "Peronospora e ruggine: contenete le concimazioni azotate e evitate semine troppo ﬁ tte e irrigate per infiltrazione laterale; se necessario trattate di frequente (ogni 7 giorni) con ossicloruro di rame-20 (80-100 g/10 l d’acqua).",
                    Malattia3 = "",

                },new Orto
                {
                   NomeComunePianta = "FAGIOLINI",
                   NomeFamiglia = "Leguminose",
                   NomeScientificoPianta = "Phaseolus spp.",
                   FotoPianta = "ms-appx:///Immagini/Orto/Fagiolini/FAGIOLINI.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Orto/Abete-*.jpg",
                   LavoriOrto = "ms-appx:///Immagini/Orto/Fagiolini/calendario_lavori_fagiolini.jpg",

                   Semina = "LA SEMINA AVVIENE IN PIENA TERRA A PARTIRE DA FINE APRILE E SINO A GIUGNO PER LE VARIETÀ RAMPICANTI, FINO A METÀ LUGLIO PER QUELLE NANE. SI PREPARA IL TERRENO TRACCIANDO FILE DISTANTI 80-100 CM; SI PONE UN SEME OGNI 5 CM SULLA FILA PER LE VARIETÀ NANE E OGNI 15 CM PER QUELLE RAMPICANTI. NEL CASO DI SEMINA A POSTARELLE (2-3 SEMI POSTI SULLA STESSA BUCA CON SUCCESSIVO DIRADAMENTO), LE DISTANZE SULLA FILA SONO DI 15 CM PER LE VARIETÀ NANE E DI 30 CM PER QUELLE RAMPICANTI. ",
                   CureColturali = "Periodiche sarchiature del terreno eliminano le erbacce che richiamano gli afidi e trasmettono le virosi. Le varietà rampicanti vanno sostenute con reti plastiche alte 2 m o con tutori in legno o canne di bambù. L’irrigazione è modesta.",
                   Raccolta = "I fagiolini vanno raccolti a circa 2/3 della maturazione dei baccelli, quando sono ancora teneri e privi del cosiddetto “filo”, la cui presenza è segno di decadimento qualitativo (si può attuare una verifica periodica spezzando qualche baccello). L’operazione, che per alcune varietà è concentrata nell’arco di 3-4 settimane, per altre può durare mesi. Un metro quadrato di coltura dà in media 1 kg di raccolto per le varietà nane e quasi il doppo per quelle rampicanti.",
                   PropietaeBenefici = "I fagiolini sono ricchi di sali minerali e, per il contenuto di vitamina A, proteine e potassio, sono raccomandati a chi soffre di malattie cardiache. Si consuma il frutto immaturo previa cottura. Oltre a rinfrescare l’apparato gastrointestinale, svolgono una spiccata azione diuretica. Hanno un basso potere calorico e sono ricchi di fibre. La minore concentrazione di proteine rispetto alle altre leguminose è dovuta al fatto che la raccolta avviene quando i semi sono in fase di sviluppo e non hanno ancora accumulato le sostanze di riserva altamente proteiche. Sono dunque da considerare ortaggi piuttosto che legumi.",

                    Varieta1 = "NANE Bronco, Provider, Nerina, Latemar, Labrador, Processor, Gabriella (giallo), Goldrush (giallo). ",
                    Varieta2 = "RAMPICANTI Bobis, Anellino (gancetto), Stortino di Trento, Trionfo (violetto), Meraviglia di Venezia (giallo), Saint Fiacre (giallo).",
                    Varieta3 = "",

                    Malattia1 = "Insetti del terreno: eseguite la rotazione delle colture, attendendo 2 anni prima di coltivare i fagiolini sulla stessa proda. ",
                    Malattia2 = "Muffa grigia e antracnosi: provvedete con attenzione allo sgrondo dal terreno dell’acqua piovana e di irrigazione; eseguite concimazioni e irrigazioni modeste. Se in passato nel terreno si sono già verificate malattie crittogamiche, è possibile attuare un trattamento preventivo con ossicloruro di rame-20 (80-100 g/10 l di acqua) prima della formazione di fiori e baccelli.",
                    Malattia3 = "",
                },

                new Orto
                {
                   NomeComunePianta = "FAGIOLI",
                   NomeFamiglia = "Leguminose",
                   NomeScientificoPianta = "Phaseolus spp.",
                   FotoPianta = "ms-appx:///Immagini/Orto/Fagioli/FAGIOLI.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Orto/Abete-*.jpg",
                   LavoriOrto = "ms-appx:///Immagini/Orto/Fagioli/calendario_lavori_fagioli.jpg",

                   Semina = "LA SEMINA INIZIA DALLA SECONDA METÀ DI APRILE, CON TEMPERATURA DI ALMENO 15 °C. LE DISTANZE DI SEMINA VARIANO A SECONDA DEL PORTAMENTO: FAGIOLO NANO A 40-60 CM TRA LE FILE E A 4-5 CM SULLA FILA, DIRADANDO POI IN MODO CHE NE RESTI UNA OGNI 15-20 CM; RAMPICANTE A 80-100 CM TRA LE FILE E A 20-40 CM SULLA FILA. NELLA SEMINA A POSTARELLE (2-3 SEMI NELLA STESSA BUCA) SI PUÒ SEMINARE ALLA DISTANZA DI 15-20 CM SULLA FILA. LA PROFONDITÀ NON DEVE SUPERARE I 2 CENTIMETRI.",
                   CureColturali = "Le varietà rampicanti richiedono una struttura di sostegno con tutori o reti plastiche a maglie larghe. Richiedono irrigazioni limitate ma frequenti, soprattutto in fase di accrescimento.  Poiché il fagiolo arricchisce il terreno di azoto, non sono necessarie concimazioni e, anzi, può essere consociato con le insalate e altri ortaggi da foglia, che sono forti consumatori di azoto.",
                   Raccolta = "L’operazione inizia quando i baccelli assumono la tipica colorazione e screziatura. Altro importante segnale è il leggero appassimento dei baccelli, in contrasto con l’aumentato turgore dei semi. Per la conservazione invernale, fate essiccare completamente i baccelli e procedete quindi alla sgranatura. In media da 10 mq di terreno si possono ottenere circa 1,5-2,5 kg di fagioli sgranati per le varietà nane e circa 3-4 kg per le varietà rampicanti.",
                   PropietaeBenefici = "Il seme del fagiolo è ricchissimo di proteine, amidi, zuccheri e relativamente povero di grassi. Sotto il proﬁ lo dietetico, quindi, è un alimento abbastanza completo, a elevato valore nutritivo, che può in parte sostituire la carne. Ai baccelli, inoltre, sono attribuite proprietà diuretiche, oltre che regolatrici del tasso di zuccheri e colesterolo nel sangue. Gli infusi rappresentano un’ottima bevanda per diabetici e persone affette da arteriosclerosi o che abbisognano di un buon apporto proteico e vitaminico.",

                    Varieta1 = "NANE Borlotto, Cannellino. ",
                    Varieta2 = "RAMPICANTI di Vigevano, Lingua di fuoco, di Lima (o del Papa), di Spagna, Saluggia.",
                    Varieta3 = "",

                    Malattia1 = "Marciumi: eseguite la rotazione delle colture (attendete 2-3 anni prima di coltivarli nello stesso terreno), assicurate un perfetto sgrondo dell’acqua dal terreno ed evitate la concimazione azotata. ",
                    Malattia2 = "Batteriosi: eseguite la rotazione delle colture, riducete al minimo le concimazioni e non piantate in modo troppo fitto, irrigate senza bagnare le foglie e utilizzate sementi sane.",
                    Malattia3 = "",
                },

                new Orto
                {
                   NomeComunePianta = "FINOCCHIO",
                   NomeFamiglia = "Ombrellifere",
                   NomeScientificoPianta = "Foeniculum vulgare dulce",
                   FotoPianta = "ms-appx:///Immagini/Orto/Finocchio/FINOCCHIO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Orto/Abete-*.jpg",
                   LavoriOrto = "ms-appx:///Immagini/Orto/Finocchio/calendario_lavori_finocchio.jpg",

                   Semina = "LA PREPARAZIONE DEL LETTO DI SEMINA DEVE ESSERE PROFONDA (30-40 CM), CON ACCURATO AFFINAMENTO DELLA TERRA IN SUPERFICIE. SI PROCEDE AL TRAPIANTO DI GIOVANI PIANTE DALLE RADICI NUMEROSE E BIANCHE E DALL’APPARATO AEREO COMPATTO (10 CM DI ALTEZZA) E SANO. SI TRACCIANO FILE DISTANTI 50-70 CM E SI TRAPIANTANO A UNA DISTANZA DI 20 CM SULLA FILA. PER IL RACCOLTO DEL PERIODO AUTUNNALE I TRAPIANTI VANNO ESEGUITI A FINE LUGLIO, PER CONTINUARE FINO AI PRIMI DI SETTEMBRE.",
                   CureColturali = "I finocchi vanno irrigati con attenzione perché periodi di siccità anche brevi possono pregiudicare lo sviluppo delle radici e la produzione. Irrigate per aspersione, poco ma di frequente, evitando che si formino pericolosi ristagni di acqua in prossimità del colletto, dove potrebbero verificarsi fenomeni di marcescenza. Circa 2 settimane prima della raccolta procedere alla rincalzatura per indurre l’imbianchimento dei piccioli fogliari, che rappresentano la parte commestibile. La terra va radunata attorno alla base formando una montagnola, in modo che la base delle piante sia protetta dalla luce solare diretta.",
                   Raccolta = "Con il raggiungimento delle dimensioni tipiche della varietà coltivata inizia la raccolta dei finocchi. Utilizzate la vanga per scalzare le piante, fortemente ancorate al terreno grazie all’apparato radicale molto profondo. Rimuovete le foglie esterne e lavate l’ortaggio. La raccolta non si deve protrarre oltre la seconda metà di novembre perché le gelate precoci causano la distruzione del raccolto. Da 10 mq di terreno si ottengono in media 20-30 kg di prodotto.",
                   PropietaeBenefici = "Il finocchio, notissima pianta alimentare, deve le sue proprietà salutari ai frutti e alla radice, che è un valido diuretico. I frutti stimolano l’appetito, favoriscono la digestione e bloccano i processi fermentativi intestinali; sono utili anche per sedare dolori addominali e frenare nausea e singhiozzo. Per un bagno rigenerante, deodorante e purificante, basta una manciata di frutti nell’acqua calda.",

                    Varieta1 = "STANDARD di Romagna (o di Bologna, di Parma, di Firenze), di Sarno, di Napoli, di Sicilia, Romanesco, Latina, Mantovano, Cervino.",
                    Varieta2 = "IBRIDI Nevo, rotondo, pesante, a semina estiva, di sviluppo lento ma di ingrossamento rapido; Carmo, medio-grosso, adatto per semine estive, resiste bene alla prefioritura; Rudy, a semina primaverile, precocissimo.",
                    Varieta3 = "",

                    Malattia1 = "Marciumi: eseguite la rotazione delle colture (attendete 2-3 anni prima di piantare il ﬁ nocchio o altre ombrellifere nella stessa proda); assicurate un perfetto sgrondo dell’acqua dal terreno; adottate concimazioni contenute. ",
                    Malattia2 = "Sclerotinia: fate in modo che non si formino ristagni d’acqua nel terreno; eseguite poche concimazioni e irrigazioni; a scopo preventivo si può effettuare una irrorazione con ossicloruro di rame-20 (80-100 g/10 l d’acqua).",
                    Malattia3 = "",
                },

                new Orto
                {
                   NomeComunePianta = "FRAGOLA",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Fragaria vesca",
                   FotoPianta = "ms-appx:///Immagini/Orto/Fragola/FRAGOLA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Orto/Abete-*.jpg",
                   LavoriOrto = "ms-appx:///Immagini/Orto/Fragola/calendario_lavori_fragola.jpg",

                   Semina = "DATE LE DIFFICOLTÀ DI SEMINA LA PIANTAGIONE SI EFFETTUA UTILIZZANDO PIANTICELLE GIÀ PRONTE PER LA MESSA A DIMORA, OTTENUTE CON LA MOLTIPLICAZIONE PER PROPAGGINE O ACQUISTATE IN VASETTO. DOPO AVER PREPARATO IL TERRENO, SI REALIZZANO PRODE LARGHE 30 CM, ALTE 25-30 CM E DISTANTI TRA LORO 70-80 CENTIMETRI. SI STENDE IL FILM PLASTICO NERO DI POLIETILENE COME COPERTURA PACCIAMANTE E, A DISTANZA DI 25-35 CM SULLA FILA, SI PRATICANO I FORI PER PORRE LE PIANTINE, INTERRANDO SOLO LE RADICI.",
                   CureColturali = "Per favorire l’attecchimento delle giovani piante irrigare a pioggia con getto a bassa pressione. A fine inverno rimuovere le foglie e gli stoloni secchi o marcescenti, lasciando solo 2-3 germogli per pianta; trattare con solfato di rame dall’azione disinfettante e cicatrizzante. ",
                   Raccolta = "La raccolta nel fragoleto inizia tra aprile e maggio; i frutti vanno staccati con il picciolo possibilmente nelle ore più fresche della giornata. La raccolta è scalare, in media ogni 5 giorni per 10-12 volte.",
                   PropietaeBenefici = "Le fragole, ricche di vitamine (A, C, gruppo B), contengono poco zucchero, e sono quindi tra i rari frutti permessi ai diabetici. Inoltre, possono essere utilizzate come maschera emolliente, schiarente e rivitalizzante per pelli secche e rugose. Il succo dei frutti, applicato sulla pelle, lenisce le scottature solari. Il rizoma della fragola ha proprietà aperitive, depurative e diuretiche ed è un valido astringente gengivale. Le foglie, invece, hanno proprietà astringenti per l’epidermide, antiemorragiche e cicatrizzanti.",

                    Varieta1 = "Le varietà di fragola si dividono in unifere, che fioriscono una sola volta in primavera; bifere, che fioriscono una seconda volta a distanza di un mese; rifiorenti, che fioriscono di continuo per tutta la buona stagione.",
                    Varieta2 = "TRA LE PIÙ DIFFUSE Marmolada (unifera), vigorosa e molto produttiva, dà frutti grossi di ottimo aspetto, ha sapore discreto ed è sensibile alla rizottoniosi e al marciume bruno; Addie (unifera), vigorosa, fornisce buone produzioni precoci, dà frutti medio-grossi, di ottimo aspetto e sapore; resiste alla botrite ma è sensibile all’oidio. ",
                    Varieta3 = "ALTRE VARIETÀ Chandler (bifera), Elsanta (unifera), Honeyoye (unifera), Selva (rifiorente), Tudla (unifera), Idea (unifera), Irvine (rifiorente).",

                    Malattia1 = "Rizottoniosi e Phytophthora: eseguite la rotazione lunga delle colture, evitate ristagni di umidità, assicurate una buona circolazione dell’aria in mezzo alle foglie, fate uso ridotto di concimi chimici, scegliete piantine sane e certificate. ",
                    Malattia2 = "Muffa grigia e marciume bruno: fate sgrondare l’acqua il più possibile, contenete concimazioni azotate e irrigazioni ed effettuate trattamenti preventivi a base di ossicloruro di rame20 (70-90 g/10 litri di acqua) fino a 20 giorni dalla raccolta. ",
                    Malattia3 = "Ragnetto rosso comune: Tetranychus urticae è un acaro che può provocare seri danni alla coltivazione della fragola. Si manifesta con decolorazione delle foglie, che prendono i toni del giallo e del grigio, e in seguito vengono ricoperte da fitte ragnatele dell’acaro che le porta al totale disseccamento. Assicuratevi che l’acqua sgrondi il più possibile dal terreno e bagnate con cautela.",
                },

                new Orto
                {
                   NomeComunePianta = "INDIVIE",
                   NomeFamiglia = "Composite",
                   NomeScientificoPianta = "Cichorium endivia",
                   FotoPianta = "ms-appx:///Immagini/Orto/Indivie/INDIVIE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Orto/Abete-*.jpg",
                   LavoriOrto = "ms-appx:///Immagini/Orto/Indivie/calendario_lavori_indivie.jpg",

                   Semina = "Le numerose varietà coltivate si differenziano per le dimensioni del cespo, la precocità e la rusticità. Si distinguono indivie ricce, che temono il freddo e per le quali la coltivazione si conclude nell’autunno, e scarole, che si seminano invece a fine estate perché non subiscano il caldo che le induce alla prefioritura. Per quanto riguarda l’indivia si procede da seme o, meglio, trapiantando giovani piante di vivaio. Preparato il terreno, tracciate file distanti tra loro 25-30 cm e, a una distanza sulla fila di 25-30 cm, ponete le piantine all’interno di buchette della profondità di 5-8 cm (in funzione del terreno e del pane di terra). Comprimere bene la terra e infine irrigare leggermente. L’epoca per il trapianto va dalla seconda metà di marzo fino alla seconda metà di settembre o comunque fino a quando le condizioni stagionali lo permettono.",
                   CureColturali = "La lotta alle erbe infestanti viene fatta con sarchiature frequenti. La concimazione azotata favorisce la precocità della coltura, mentre quella potassica stimola lo sviluppo delle foglie. L’irrigazione deve essere leggera ma quasi quotidiana in estate, senza però bagnare il fogliame. Per favorire l’imbianchimento del grumolo i cespi ben asciutti vanno legati circa 2 settimane prima della raccolta.",
                   Raccolta = "È un’operazione di estrema semplicità, che consiste nel taglio del colletto al di sotto del cespo con l’aiuto di un coltello affilato. Si eliminano quindi le foglie più esterne, che di solito sono sporche o anche marcescenti. Da 10 mq di terreno si ottengono in media dai 10 ai 25 kg di prodotto utile.",
                   PropietaeBenefici = "L’indivia è ricca di sali minerali e oligoelementi, in particolare di selenio, un antiossidante che protegge le cellule dall’invecchiamento. Il rapporto potassio/sodio (tanto/pochissimo) le conferisce proprietà diuretiche. Inoltre, le fibre che rendono le foglie sode e croccanti favoriscono il transito intestinale. Infine, come la lattuga il germe di grano e di mais e il lievito di birra secco, l’indivia contiene, anche se in minor misura, vitamina B9, importante per rafforzare le difese immunitarie e attiva contro anemia e depressione.",

                    Varieta1 = "Cicoria Scarola Casco d’Oro, semina da febbraio ad agosto; Cicoria Scarola Cuore Pieno, semina da marzo a settembre; Cicoria Scarola Gigante degli Ortolani, a raccolto autunnale e invernale; Indivia Grossa di Pancalieri, a semina estiva e raccolto invernale; Riccia Fina d’Estate, con foglie rosse alla base; Riccia d’Estate, a cuore giallo.",
                    Varieta2 = "",
                    Varieta3 = "",

                    Malattia1 = "In tutti i casi: usate buon terriccio per semine e trapianti, eseguite la solarizzazione del terreno (copertura con teli plastici trasparenti) per disinfettarlo e togliete dalle prode gli avanzi delle colture e distruggeteli. ",
                    Malattia2 = "Lumache e limacce: si consiglia di distribuire sali disidratanti (sale da cucina, calce in polvere) collocati nelle zone di passaggio di questi molluschi o di attirarli con esche a base di birra.",
                    Malattia3 = "",
                },

                new Orto
                {
                   NomeComunePianta = "LATTUGA",
                   NomeFamiglia = "Composite",
                   NomeScientificoPianta = "Lactuca sativa",
                   FotoPianta = "ms-appx:///Immagini/Orto/Lattuga/LATTUGA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Orto/Abete-*.jpg",
                   LavoriOrto = "ms-appx:///Immagini/Orto/Lattuga/calendario_lavori_lattuga.jpg",

                   Semina = "IN GENERE SI PROCEDE AL TRAPIANTO DI GIOVANI PIANTE ACQUISTATE IN VIVAIO O PRODOTTE IN SEMENZAIO. PREPARATO IL TERRENO, SI TRACCIANO FILE DISTANTI TRA LORO 30-40 CM E, A DISTANZA SULLA FILA DI 20-30 CM, SI PONGONO LE PIANTINE IN BUCHETTE, IN MODO CHE IL COLLETTO SI TROVI A LIVELLO DEL TERRENO E NON INTERRATO. L’EPOCA PER IL TRAPIANTO ALL’APERTO VA DALLA SECONDA METÀ DI MARZO A METÀ SETTEMBRE, IN BASE ALLA VARIETÀ. PUÒ ESSERE UTILE LA COPERTURA CON TELO NON TESSUTO. ",
                   CureColturali = "L’irrigazione, essenziale per le lattughe estive, deve essere effettuata a cadenza quotidiana, ma non deve essere abbondante, soprattutto se il terreno è pesante e trattiene umidità. Per la varietà Romana si può procedere all’imbianchimento, legando il cespo un paio di settimane prima della raccolta.",
                   Raccolta = "Quando il cespo è ben formato e sodo al centro, e le foglie più esterne sono ancora sane e verdi: è sufficiente reciderlo all’altezza del colletto con un coltello affilato. Da un metro quadrato di terreno si ottengono in media 1,5-3 kg di prodotto.",
                   PropietaeBenefici = "Le foglie di lattuga hanno proprietà diuretiche, dovute al vantaggioso rapporto potassio/sodio. Inoltre contengono elevate quantità di fibre che le rendono sode e croccanti, ma anche un toccasana per l’intestino. Infine, come altre piante ortive da foglia, la lattuga possiede buone quantità di vitamina B9, antianemica e antidepressiva e utile per rafforzare le difese immunitarie.",

                    Varieta1 = "LATTUGA A CAPPUCCIO CLASSICA Meraviglia delle Quattro Stagioni, Meraviglia d’Inverno, Regina di Maggio, Trocadero, Kranager (estiva), Regina d’Estate (estiva). ",
                    Varieta2 = "LATTUGA BRASILIANA (ICEBERG) Nabucco, Nerone, Saladin, Chianti, Salinas, Great lake (estiva), Regina dei Ghiacci (estiva).",
                    Varieta3 = "TIPO BATAVIA Canasta, Bionda di Parigi. TIPO ROMANA Bionda degli Ortolani, Bionda Colosseo, Balloon (estiva), Bionda Lentissima a Montare (estiva).",
                    Varieta4 = "LATTUGA A CESPO MORBIDO O DA TAGLIO (da seminare a spaglio) Lollo Rossa e Lollo Verde, Red Salad Bowl.",

                    Malattia1 = "Muffa grigia, Sclerotinia e Pythium: eseguite la rotazione delle colture (almeno 2-3 anni prima di ripiantare la lattuga nello stesso terreno), assicurate un ottimo drenaggio del terreno, distruggete i residui di coltivazione e irrorate localmente con una soluzione di ossicloruro di rame-20 (90-100 g/10 l d’acqua) cercando di bagnare bene il colletto. ",
                    Malattia2 = "Bremia, Alternaria, muffa grigia e oidio: eseguite la rotazione delle colture (come sopra), limitate concimazioni azotate e irrigazioni, asportate e distruggete la vegetazione residua e preferite varietà resistenti alla bremia (Columbus, Lido, Big Boston, Elsa, Jessy, Saladin, Malika, Odessa, Melissa, Canasta).",
                    Malattia3 = "",
                },

                new Orto
                {
                   NomeComunePianta = "MELANZANA",
                   NomeFamiglia = "Solanacee",
                   NomeScientificoPianta = "Solanum melongena",
                   FotoPianta = "ms-appx:///Immagini/Orto/Melanzana/MELANZANA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Orto/Abete-*.jpg",
                   LavoriOrto = "ms-appx:///Immagini/Orto/Melanzana/calendario_lavori_melanzana.jpg",


                   Semina = "LA TEMPERATURA OTTIMALE È COMPRESA TRA 15 E 26 °C. SI COLTIVA IN QUASI TUTTI I TERRENI, MA PREFERISCE QUELLI DI MEDIO IMPASTO, SCIOLTI E FRESCHI. SI SEMINA IN CASSONE RISCALDATO, IN GENNAIO-FEBBRAIO. IL TRAPIANTO A DIMORA (PIANTINE CON 4-5 FOGLIE) SI FA IN PICCOLI SOLCHETTI TRACCIATI ALLA DISTANZA DI 90 CM E METTENDO LE PIANTE LUNGO LA FILA A 60 CM UNA DALL’ALTRA, A UNA PROFONDITÀ DI 7-8 CENTIMETRI. LA MESSA A DIMORA SI EFFETTUA TRA FINE APRILE E FINE MAGGIO.",
                   CureColturali = "Eliminare le infestanti con regolari sarchiature, utili tra l'altro per rendere il terreno più arieggiato e meno compatto. L’azoto può provocare scarsa fioritura e scarsa allegagione dei frutti (meglio non eccedere); il fosforo favorisce la fioritura e l’allegagione dei frutti, e il potassio la maturazione. La pianta ha elevate esigenze idriche, in particolare durante la fase d’ingrossamento dei frutti.  Un tutore di 1 m di altezza è pressoché indispensabile per legare la pianta al fine di assicurarne la stabilità, specie quando è in piena produzione.",
                   Raccolta = "La raccolta si esegue quando i frutti hanno raggiunto le dimensioni e il colore tipici della varietà: al momento dell’asportazione, è opportuno provvedere a ruotarli, in modo da staccare anche il picciolo. È consigliabile non ritardare troppo questa operazione, in quanto i frutti, invecchiando, diventano duri, la buccia si decolora e i semi acquistano un sapore amaro.",
                   PropietaeBenefici = "La melanzana normalizza le funzioni del fegato, riduce il tasso di colesterolo nel sangue, stimola la diuresi e l’eliminazione di scorie azotate. Per queste virtù è un depurativo generale, un disintossicante e un ricostituente, per esempio dopo lunghe malattie o trattamenti con antibiotici. Per uso esterno, la polpa fresca può essere impiegata per lenire arrossamenti della pelle e scottature.",

                    Varieta1 = "TONDA, STANDARD Black Beauty, Tonda di Firenze, Piccola Genovese, Tonda Bianca Sfumata Rosa. IBRIDI Nite King, Purpura.",
                    Varieta2 = "OVALE, STANDARD Florida Market, Bianca Ovale. IBRIDI Bonica, Galine. ",
                    Varieta3 = "LUNGA, STANDARD Long Purple, Riminese. IBRIDI Baluroi, Marfa, Sicilia.",

                    Malattia1 = "Verticillosi: eseguite rotazioni almeno di 3 anni e utilizzate piante innestate su pomodoro Kyndia F1 resistenti alla malattia.",
                    Malattia2 = "Phoma e Alternaria: contenete le concimazioni, irrigate per infiltrazione laterale e se necessario effettuate un trattamento preventivo con ossicloruro di rame-20 (70-90 g/10 l d’acqua).",
                    Malattia3 = "",
                },

                new Orto
                {
                   NomeComunePianta = "MELONE",
                   NomeFamiglia = "Cucurbitacee",
                   NomeScientificoPianta = "Cucumis melo",
                   FotoPianta = "ms-appx:///Immagini/Orto/Melone/MELONE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Orto/Abete-*.jpg",
                   LavoriOrto = "ms-appx:///Immagini/Orto/Melone/calendario_lavori_melone.jpg",


                   Semina = "La semina avviene al riparo in contenitori alveolari di polistirolo. Ponete 2-3 semi in ogni alveolo con l’apice rivolto verso il basso a circa 1 cm di profondità. Attenzione: maneggiate con cautela i semi che, anche se abbastanza grossi, sono delicati. In alternativa ai contenitori alveolari potete seminare in vasetti di plastica, interrando 3 semi in ogni vasetto. L’epoca della semina in ambiente protetto va da fine gennaio ai primi di marzo, ma anche a epoca più avanzata nelle regioni in cui, arrivando tardi l’estate, non sarebbe possibile mettere a dimora le piantine (che necessitano di molto caldo per svilupparsi) in piena terra. Nei climi miti potete anche seminare direttamente a dimora a partire da metà aprile.",
                   CureColturali = "I concimi fosfatici e potassici vanno dati alla preparazione del terreno; quelli azotati in parte all’impianto, in parte in copertura. Il controllo delle erbe infestanti si fa con le sarchiature. L’irrigazione (a pioggia, a solchi, a goccia o con manichette forate sotto la pacciamatura) è indispensabile per l’accrescimento del frutto. La cimatura degli steli si effettua lasciando 2-4 foglie.",
                   Raccolta = "Inizia quando il peduncolo comincia a screpolarsi e il frutto ha raggiunto le dimensioni, il colore e il profumo tipici della varietà. La raccolta si esegue recidendo il picciolo con un coltello affilato onde evitare di spezzare i rami. Da 10 mq di terreno si ottengono circa 20-30 kg di meloni.",
                   PropietaeBenefici = "Il melone è un frutto molto dissetante; se consumato nel corso dei pasti o come piacevole intermezzo durante la giornata, rinfresca e reintegra nell’organismo l’acqua persa con il sudore. Oltre all’acqua, il melone contiene anche una notevole quantità di sali minerali e vitamina A e C. L’alto contenuto di potassio lo rende un ottimo integratore, soprattutto dopo aver effettuato attività fisiche.",

                    Varieta1 = "A FRUTTO LISCIO Cantalupo Charentais, Honey Dew, Jolly, Tamaris, Pamir. ",
                    Varieta2 = "A FRUTTO RETATO Supermarket, Rony, Supersprint, Burpus.",
                    Varieta3 = "",

                    Malattia1 = "Le malattie più frequenti sono praticamente incurabili, è quindi fondamentale fare una buona prevenzione. ",
                    Malattia2 = "Fusariosi: eseguite rotazioni lunghe (3-4 anni prima di coltivare nuovamente melone o altre cucurbitacee nello stesso terreno) e preferite varietà resistenti o meno delicate come Carlo F1, Laro F1, Soleado F1, Calipso F1, Parsifal F1. Se riuscite a trovarle, usate piantine di melone innestate.",
                    Malattia3 = "Oidio: preferite varietà tolleranti tra cui Parsifal F1 e Calipso F1; solo se risultasse necessario per salvare il raccolto, irrorate le foglie con zolfo bagnabile-80 (7-10 g/10 l di acqua) nelle ore più fresche della giornata.",
                },

                new Orto
                {
                   NomeComunePianta = "PATATA",
                   NomeFamiglia = "Solanacee",
                   NomeScientificoPianta = "Solanum tuberosum",
                   FotoPianta = "ms-appx:///Immagini/Orto/Patata/PATATA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Orto/Abete-*.jpg",
                   LavoriOrto = "ms-appx:///Immagini/Orto/Patata/calendario_lavori_patata.jpg",


                   Semina = "IL TERRENO VA PREPARATO ALL’INIZIO DELLA PRIMAVERA CON LA VANGATURA E L’AGGIUNTA DI UNA GRANDE QUANTITÀ DI LETAME MOLTO MATURO. SI TRACCIANO I SOLCHI DISTANTI TRA LORO CIRCA 60 CM E PROFONDI 7-10 CM. SI PONGONO I TUBERI-SEME A CIRCA 30 CM UNO DALL’ALTRO E SI RICOPRE CON UN PO’ DI TERRA. DUE SETTIMANE DOPO LA PIANTAGIONE SI PROCEDE ALLA RINCALZATURA, RADUNANDO TERRA SUI DUE LATI DELLA FILA, IN MODO CHE I GERMOGLI RIMANGANO COPERTI. ",
                   CureColturali = "Due settimane dopo la piantagione, procedere alla prima rincalzatura, radunando terra sui due lati della fila, in modo che i germogli restino coperti. Ripetere la stessa operazione a un mese di distanza. L’irrigazione non è necessaria, se non in annate particolarmente siccitose. In questo caso bisogna bagnare tra i solchi, preferibilmente nelle ore serali o notturne, per evitare gli sbalzi termici.",
                   Raccolta = "La raccolta avviene durante l’estate, da metà luglio a fine agosto a seconda della varietà. Si procede quando la vegetazione appare ingiallita, asportando i fusti e le foglie e poi scalzando con una vanga la rincalzatura. La conservazione deve essere fatta all’interno di ambienti privi di luce, in modo da impedire l’inverdimento della buccia, fenomeno che rende i tuberi amarognoli e non commestibili.",
                   PropietaeBenefici = "La patata ha un alto contenuto di zuccheri e di vitamina C: ben 24 mg per 100 g di tubero maturo, ma la quantità diminuisce con la conservazione. Inoltre, questo tubero è ricco di sali minerali, quali potassio, cromo, magnesio e fosforo. Per le spiccate proprietà antifermentative trova impiego come antidiarroico.",

                    Varieta1 = "SPUNTA Tuberi di forma regolare allungata, buccia liscia e gialla, produzione precoce e abbondante.",
                    Varieta2 = "JAERLA Tuberi globosi, buccia liscia e chiara, produzione medio-precoce. I tuberi, specie in terreni pesanti e mal strutturati, possono assumere forme irregolari.",
                    Varieta3 = "KENNEBEK Produzione abbondante e tardiva. Sensibile al fenomeno dell’inverdimento se i tuberi sono esposti alla luce del sole e non vengono ben coperti di terra.",

                    Malattia1 = "Batteriosi: fate in modo che l’acqua piovana possa deﬂ uire velocemente; impiegate tuberi da seme certiﬁ cati. ",
                    Malattia2 = "Dorifora: su superfici limitate eseguite la raccolta a mano quando appaiono i primi insetti adulti e poi le larve; per superfici elevate intervenite con un prodotto a base di Bacillus thuringiensis, che può essere irrorato fino a 3 giorni dalla raccolta.",
                    Malattia3 = "",
                },

                new Orto
                {
                   NomeComunePianta = "PEPERONE",  
                   NomeFamiglia = "Solanacee",
                   NomeScientificoPianta = "Capsicum annuum",
                   FotoPianta = "ms-appx:///Immagini/Orto/Peperone/PEPERONE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Orto/Abete-*.jpg",
                   LavoriOrto = "ms-appx:///Immagini/Orto/Peperone/calendario_lavori_peperone.jpg",


                   Semina = "LA SEMINA SI EFFETTUA IN AMBIENTE PROTETTO A FINE INVERNO, MANTENENDO UNA TEMPERATURA DI 20 °C FINO ALLA GERMINAZIONE. SE SI ACQUISTANO PIANTINE PER IL TRAPIANTO, SI PREPARANO IN ANTICIPO LE PRODE, SOPRAELEVANDOLE, IN MODO DA GARANTIRE IL DEFLUSSO DELL’ACQUA. LA MESSA A DIMORA SI ESEGUE DA FINE APRILE A TUTTO MAGGIO, SU FILE DISTANTI TRA LORO 70-80 CM, IN CUI PRATICARE LE BUCHETTE A DISTANZA DI 40-45 CM SULLA FILA, OVE INTERRARE LE RADICI.",
                   CureColturali = "Al momento del trapianto è bene stendere la pacciamatura con film plastico nero, con i fori intervallati per la piantagione. Le infestanti vanno tempestivamente rimosse mediante la sarchiatura. L’irrigazione deve essere regolare fino all’allegagione, senza bagnare il fogliame. Per evitare che i rami si spezzino, è bene provvedere a inserire i tutori. ",
                   Raccolta = "A seconda della varietà, i peperoni si raccolgono quando il colore, le dimensioni e il peso delle bacche sono quelli caratteristici. Per evitare la spaccatura dei rami, tagliate il picciolo dei frutti con le forbici o con un coltello tagliente. All’aperto la raccolta inizia verso metà luglio e si protrae sino a inizio autunno. Da circa 10 mq di terreno si ottengono in media 25-35 kg di peperoni.",
                   PropietaeBenefici = "Il peperone è ricchissimo di vitamine B e C e contiene una modesta quantità di provitamina A (carotene). Sono note le proprietà aromatizzanti del peperone e ancora di più della varietà piccante, il peperoncino, che favorisce le attività digestive stimolando la secrezione gastrica. A contatto con la pelle il peperone determina una sensazione di calore, dovuta alla stimolazione dei tessuti nervosi. Questa peculiarità è sfruttata nella produzione di cerotti contro nevralgie, reumatismi e geloni.",

                    Varieta1 = "QUADRATA, STANDARD Quadrato d’Asti,  Super Golia e Carmagnola (giallorosso); Galdino e Golden Calwonder, a frutto giallo; Keystone Resistant Giant n. 3 e California Wonder con frutti rossi. IBRIDI Ideal, Kali, Duplo, Ghibli, Jolly Giallo e Rosso.",
                    Varieta2 = "RETTANGOLARE (LUNGA E SEMILUNGA), STANDARD Marconi, di Nocera. IBRIDI Lux, Mikalor, Olber, Eldorado, Gladiator, Cancun, Clovis, Osir, Mayata. ",
                    Varieta3 = "CONICA Cuneo F1 e Cuneo. A FORMA DI CORNO Hot Large, Diablo, Ringo. A FORMA DI POMODORO Topepo 391 e Topepo.",

                    Malattia1 = "Cancrena pedale: eseguite una rotazione lunga della coltura (3 anni e più prima di ricoltivare peperoni nello stesso terreno), garantite un ottimo drenaggio ed eseguite concimazioni azotate minime. ",
                    Malattia2 = "Batteri, Alternaria e botrite: evitate impianti fitti e concimazioni azotate, irrigate senza bagnare le foglie e i frutti e intervenite con prodotti a base di ossicloruro di rame-20 (60-80 g/10 l di acqua) solo se fosse indispensabile.",
                    Malattia3 = "",
                },

                new Orto
                {
                   NomeComunePianta = "PISELLO",
                   NomeFamiglia = "Leguminose",
                   NomeScientificoPianta = "Pisum sativum",
                   FotoPianta = "ms-appx:///Immagini/Orto/Pisello/PISELLO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Orto/Abete-*.jpg",
                   LavoriOrto = "ms-appx:///Immagini/Orto/Pisello/calendario_lavori_pisello.jpg",


                   Semina = "IL TERRENO SI PREPARA ALLA SEMINA SENZA VANGATURE PROFONDE, MA ASSICURANDONE L’OTTIMO DRENAGGIO: LE FILE DEVONO ESSERE SOPRAELEVATE DI CIRCA 10 CM; SI TRACCIANO A UNA DISTANZA TRA LORO DI 30 CM PER LE VARIETÀ NANE E DI 50-60 CM PER QUELLE RAMPICANTI. SI SEMINA SULLA FILA A DISTANZA DI 7-10 CM, COPRENDO CON 1-2 CM DI TERRA. LA GERMINAZIONE PUÒ AVVENIRE ANCHE A 4 °C. SI SEMINA QUINDI ANCHE IN AUTUNNO PER UNA GERMINAZIONE PRIMAVERILE PRECOCE.",
                   CureColturali = "Occorre procedere periodicamente alla sarchiatura, per rimuovere le erbe infestanti, oppure ricorrere alla pacciamatura con il film plastico nero. Le varietà rampicanti necessitano di un’opportuna struttura di sostegno. Sono necessarie irrigazioni limitate ma frequenti, almeno durante l’accrescimento iniziale; da sospendere durante la fioritura. ",
                   Raccolta = "La raccolta si esegue scalarmente e a mano, staccando i baccelli dalla pianta facendo attenzione a non danneggiare le infiorescenze e le ramifi cazioni. La produzione varia tra 3 e 5 kg di piselli sgusciati per 10 mq di terreno.",
                   PropietaeBenefici = "Data la minore concentrazione di amido, i piselli risultano più digeribili di altri legumi e contengono pochi lipidi, trovando quindi impiego anche nelle diete ipocaloriche. Sono dotati, inoltre, di buone quantità di sali minerali come potassio, fosforo e calcio. Possono essere consumati sia freschi sia secchi e, se particolarmente giovani e piccoli, sono ottimi aggiunti crudi nelle insalate.",

                    Varieta1 = "Tra le varietà da consumo diretto consigliamo Gigante a Fiore Bianco, Gigante Svizzero, Gigante Dorato.",
                    Varieta2 = "",
                    Varieta3 = "",

                    Malattia1 = "Fusariosi, Pythium: eseguite la rotazione delle colture (attendete 2-3 anni prima di coltivarli nello stesso terreno), approntate un ottimo sgrondo dell’acqua piovana e di irrigazione dal terreno e preferite varietà resistenti alla fusariosi come Progress n. 9. ",
                    Malattia2 = "Peronospora, muffa grigia: limitate le concimazioni e il numero di piante per metro quadrato, assicurate adeguato sostegno alle varietà rampicanti e non esagerate con le irrigazioni.",
                    Malattia3 = "",
                },

                new Orto
                {
                   NomeComunePianta = "POMODORO",
                   NomeFamiglia = "Solanacee",
                   NomeScientificoPianta = "Solanum lycopersicum",
                   FotoPianta = "ms-appx:///Immagini/Orto/Pomodoro/POMODORO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Orto/Abete-*.jpg",
                   LavoriOrto = "ms-appx:///Immagini/Orto/Pomodoro/calendario_lavori_pomodoro.jpg",


                   Semina = "LA SEMINA SI ESEGUE VERSO LA FINE DI FEBBRAIO IN AMBIENTE PROTETTO. QUANDO LE PIANTINE HANNO 4-6 FOGLIE VERE (A FINE APRILE O INIZIO MAGGIO), SI PROCEDE CON LA MESSA A DIMORA IN PIENA TERRA. SI TRACCIANO LE FILE A DISTANZA DI 70-100 CM E SI SCAVA UNA BUCHETTA OGNI 35-40 CM SULLA FILA. SI PONE LA PIANTINA CON IL PANE DI TERRA, RINCALZANDO BENE IN MODO CHE SIA COPERTO ANCHE IL COLLETTO. SUBITO DOPO SI DEVE PROCEDERE A UN’IRRIGAZIONE MOLTO ACCURATA.",
                   CureColturali = "L’acqua va fornita solo per infiltrazione laterale e deve essere modesta nelle fasi iniziali e fino alla formazione dei frutticini. In seguito si ravvicinano i turni di irrigazione, somministrando sempre poca acqua per volta. La cimatura rinvigorisce i rami laterali fruttiferi; la sfemminellatura elimina i germogli non produttivi. La rincalzatura, operazione che consiste nell’accostare terra attorno alla base del fusto, provoca l’emissione di nuove radici superficiali, che migliorano l’assorbimento di sostanze nutrienti e la stabilità delle piante.",
                   Raccolta = "La raccolta inizia durante l’estate, nella prima decade di luglio, e si protrae sino ai primi freddi. Staccare i pomodori delicatamente, ruotandoli sul picciolo per evitare di danneggiare i frutti vicini e la vegetazione. ",
                   PropietaeBenefici = "Il pomodoro è un concentrato di buona salute: ha azione rinfrescante, aperitiva, astringente, dissetante, diuretica e digestiva, soprattutto nei confronti degli amidi, e rappresenta un ottimo rimedio per combattere l’inappetenza, l’azotemia elevata, l’arteriosclerosi, disturbi gastrici e intestinali. È ricco di vitamine (A, B1, B2, B6, C, E, K e PP) e di sali minerali (boro, calcio, ferro, fosforo, iodio, magnesio, manganese, potassio, rame, sodio, zinco, zolfo). I pomodori sono ideali per chi fa attività sportiva poiché, essendo ricchi di potassio, prevengono i crampi muscolari. Le foglie di pomodoro tritate e applicate sulla pelle sono un rimedio contro le punture di insetti.",

                    Varieta1 = "Varietà da mensa CLASSICA Montecarlo, Carmelo, Tipo Ace, Fandango, San Pietro. ",
                    Varieta2 = "A FRUTTI MATURI Luana, Rita, Monika, Italico, Brio, Durinta.",
                    Varieta3 = "CILIEGINO Naomi, Cherelino.",
                    Varieta4 = "DA INDUSTRIA San Marzano, Roma, Earlymech, Earlypeel.",

                    Malattia1 = "Peronospora, septoria: rispettate le distanze di trapianto, contenete le concimazioni azotate, non bagnate le foglie durante l’irrigazione, impiegate la pacciamatura con teli plastici e solo se necessario eseguite trattamenti con ossicloruro di rame-20 (70-90 g/10 l d’acqua) fino a 20 giorni dalla raccolta. ",
                    Malattia2 = "Afidi: intervenite con prodotti a base di piretrine naturali (6-8 g/10 l d’acqua) se gli attacchi sono consistenti. ",
                    Malattia3 = "Virosi: per prevenirle potete ricorrere a varietà resistenti come Fandango e Carmelo. Nematodi: eseguite rotazioni di 3-4 anni prima di coltivare di nuovo pomodori. Le varietà Fandango e Carmelo sono meno attaccabili da questi vermi.",
                },

                new Orto
                {
                   NomeComunePianta = "PORRO",
                   NomeFamiglia = "Alliacee",
                   NomeScientificoPianta = "Allium porrum",
                   FotoPianta = "ms-appx:///Immagini/Orto/Porro/PORRO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Orto/Abete-*.jpg",
                   LavoriOrto = "ms-appx:///Immagini/Orto/Porro/calendario_lavori_porro.jpg",


                   Semina = "LE VARIETÀ PRECOCI SI SEMINANO IN GENNAIO SU LETTO CALDO PER RACCOLTE IN GIUGNO-LUGLIO; QUELLE ESTIVO-AUTUNNALI SI SEMINANO IN MARZO PER LA RACCOLTA IN AGOSTO-NOVEMBRE; QUELLE TARDIVE SI SEMINANO IN MAGGIO PER LA RACCOLTA IN NOVEMBRE-DICEMBRE; LE SEMINE IN SETTEMBRE DANNO IL RACCOLTO IN MARZO. IL TRAPIANTO SI ESEGUE DOPO 12 SETTIMANE DALLA SEMINA, QUANDO LE PIANTINE SONO ALTE 15 CM, DISTANZIANDOLE SULLA FILA DI 8-20 CM E TRA LE FILE DI 30-50 CENTIMETRI.",
                   CureColturali = "A 30-40 giorni dalla semina si procede al diradamento delle piantine. Sono utili sarchiature frequenti per arieggiare il terreno e ridurre lo sviluppo delle infestanti. Vanno evitate le concimazioni eccessive, che riducono la resistenza al gelo nelle varietà invernali. Due settimane prima della raccolta si rincalzano i primi 10-15 cm della pianta per ottenerne l’imbianchimento. ",
                   Raccolta = "Il massimo ingrossamento dei fusti si verifica a 5-6 mesi dalla semina (3-4 mesi dal trapianto), ma la raccolta può essere effettuata a qualsiasi stadio di crescita. Si inizia a maggio e, se le semine sono state scalari, si prosegue in pratica per tutto l’anno.",
                   PropietaeBenefici = "Oltre ad avere un buon contenuto di vitamine, il porro è anche ricco di minerali preziosi per l’organismo umano: ferro (indispensabile per la formazione dei globuli rossi), magnesio (importante per il sistema nervoso), zolfo (indicato per contrastare la fermentazione intestinale), sodio (combatte l’acidità), silicio (prezioso per i tessuti ossei ed epiteliali).",

                    Varieta1 = "PORRI ESTIVI Semina a gennaio-marzo e raccolta a maggio-giugno. ",
                    Varieta2 = "PORRI AUTUNNALI Presentano una scarsa resistenza al freddo, si seminano in febbraio-marzo e si raccolgono da luglio a ottobre. ",
                    Varieta3 = "PORRI INVERNALI Notevolmente resistenti al freddo, sono adatti quindi a svernare in pieno campo; semina in aprile-maggio, raccolta a novembre-marzo.",

                    Malattia1 = "Fusariosi e nematodi: eseguite rotazioni lunghe delle colture (attendete 3-4 anni prima di piantare nello stesso terreno porri o altri ortaggi della stessa famiglia, come cipolla, scalogno, aglio).",
                    Malattia2 = "Botrite, marciume bianco: evitate ristagni d’acqua curando il drenaggio e le sarchiature; è meglio eseguire l’impianto a fine inverno.",
                    Malattia3 = "",
                },

                new Orto
                {
                   NomeComunePianta = "RADICCHIO",
                   NomeFamiglia = "Composite",
                   NomeScientificoPianta = "Cichorium intybus",
                   FotoPianta = "ms-appx:///Immagini/Orto/Radicchio/RADICCHIO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Orto/Abete-*.jpg",
                   LavoriOrto = "ms-appx:///Immagini/Orto/Radicchio/calendario_lavori_radicchio.jpg",


                   Semina = "LA SEMINA PUÒ AVVENIRE TUTTO L’ANNO (TRANNE I MESI PIÙ FREDDI), MA IN GENERE, PER AVERE L’INSALATA NEL PERIODO INVERNALE E PRIMAVERILE, SI EFFETTUA ALL’INIZIO DELL’ESTATE IN TERRENO BEN AFFINATO E FERTILE, OPPURE SI TRAPIANTANO PIANTINE CON GIÀ UN ABBOZZO DI ROSETTA FOGLIARE. LA MESSA A DIMORA AVVIENE IN FILE DISTANTI 25-35 CM CON DISTANZA SULLA FILA DI 25-30 CM, INTERRANDO LE RADICI A PROFONDITÀ MAGGIORE SE IL TERRENO È DI TIPO SABBIOSO.",
                   CureColturali = "Risulta importante rimuovere le infestanti che sottraggono elementi nutritivi. L’irrigazione, essenziale per i trapianti in estate, deve avvenire per infiltrazione laterale, con bagnature leggere ma quotidiane, in modo da ridurre il fenomeno di fioritura anticipata. In autunno, i cespi perfettamente sviluppati vanno sottoposti all’imbianchimento, legando il cespo ben asciutto",
                   Raccolta = "Il taglio si effettua sotto il cespo, all’altezza del colletto, con un coltello affilato. Si eliminano quindi le foglie esterne, danneggiate o marcescenti. Se si lasciano nel terreno le grosse radici a fittone, all’inizio della primavera è possibile fare un secondo raccolto di foglioline tenere e colorate, prima di eliminare i resti della coltura e vangare la terra per predisporre quelle nuove. Mediamente da 1 mq di terreno si ottengono 1,5-3 kg di radicchio.",
                   PropietaeBenefici = "Il radicchio è ricco di fibre, sali minerali e vitamine, ha proprietà depurative ed è consigliato in caso di stitichezza, cattiva digestione, problemi di pelle, artrite e reumatismi. Inoltre è utile in caso di diabete e insonnia e, grazie al basso apporto calorico, rientra nella dieta contro l’obesità.",

                    Varieta1 = "RADICCHIO ROSSO DI VERONA Cespo piccolo tondeggiante, foglie dolci rosso vivo. ",
                    Varieta2 = "RADICCHIO DI TREVISO Foglie lunghe, rosse, spiccatamente amare, con nervature centrali molto accentuate. Varietà pregiata, nelle varianti precoce e tardivo. ",
                    Varieta3 = "RADICCHIO DI CHIOGGIA Cespo tondeggiante di grossa taglia, con foglie variegate di colore bianco crema.",

                    Malattia1 = "Muffa grigia e Sclerotinia: effettuate la rotazione delle colture, garantite un ottimo drenaggio del terreno; solo se necessario intervenite con irrorazioni pianta per pianta con una soluzione di ossicloruro di rame-20 (80-90 grammi per 10 litri d’acqua) cercando di bagnare bene il colletto. ",
                    Malattia2 = "Muffa grigia e oidio: effettuate la rotazione delle colture, rispettate le distanze di trapianto, limitate le concimazioni, irrigate senza bagnare le foglie; quando legate i cespi per l’imbianchimento procedete solo se le foglie sono ben asciutte.",
                    Malattia3 = "",
                },

                new Orto
                {
                   NomeComunePianta = "RAPA",
                   NomeFamiglia = "Crucifere",
                   NomeScientificoPianta = "Brassica rapa",
                   FotoPianta = "ms-appx:///Immagini/Orto/Rapa/RAPA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Orto/Abete-*.jpg",
                   LavoriOrto = "ms-appx:///Immagini/Orto/Rapa/calendario_lavori_rapa.jpg",


                   Semina = "PIANTA BIENNALE COLTIVATA COME ANNUALE, VIENE UTILIZZATA PER LA PRODUZIONE DELLE RADICI INGROSSATE E PER I GERMOGLI FOGLIOSI (NOTI COME “BROCCOLETTI”). PREDILIGE TERRENI FRESCHI, DI MEDIO IMPASTO, RICCHI DI SOSTANZA ORGANICA. DOPO AVER PROCEDUTO ALLA VANGATURA, SI SEMINA A DIMORA IN FILE DISTANTI 15-20 CM PER LE VARIETÀ DA RADICI E 40-50 CM PER QUELLE DA BROCCOLETTI; SI PUÒ PROCEDERE SCALARMENTE, PER AVERE IL PRODOTTO TUTTO L’ANNO.",
                   CureColturali = "Cresce bene in zone dal clima temperatoumido, mentre teme la siccità e le temperature troppo elevate. Durante la coltivazione occorre effettuare alcune sarchiature, eliminare le piante infestanti, annaffiare e concimare almeno una volta.",
                   Raccolta = "La raccolta si effettua in diversi periodi dell’anno, secondo le epoche di semina (il ciclo ha una durata variabile dai 2 ai 4 mesi). Se il fusto viene tagliato a livello del terreno, si formano prontamente nuovi getti.",
                   PropietaeBenefici = "Alimenti ricchi di vitamine (A, B e C), di fosforo, calcio (le crucifere ne sono la principale fonte di origine animale), ferro utile nell'anemia, e potassio utile per il controllo della pressione. Le rape hanno inoltre importanti proprietà disintossicanti (perchè ricche di zolfo) e antiossidanti (grazie alla ricchezza di flavonoidi).",

                    Varieta1 = "Brassica rapa L. subsp. rapa (o rapa comune, coltivata per la radice.",
                    Varieta2 = "Brassica rapa L. subsp. sylvestris (conosciuta comunemente come cime di rapa)",
                    Varieta3 = "Brassica rapa L. subsp. campestris (conosciuta come ravizzone)",

                    Malattia1 = "",
                    Malattia2 = "",
                    Malattia3 = "",
                },

                new Orto
                {
                   NomeComunePianta = "RAPANELLO",
                   NomeFamiglia = "Crucifere",
                   NomeScientificoPianta = "Raphanus sativus",
                   FotoPianta = "ms-appx:///Immagini/Orto/Rapanello/RAPANELLO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Orto/Abete-*.jpg",
                   LavoriOrto = "ms-appx:///Immagini/Orto/Rapanello/calendario_lavori_rapanello.jpg",


                   Semina = "IL CICLO COLTURALE DURA DA 3 SETTIMANE NEL PERIODO ESTIVO A 2-3 MESI DURANTE L’INVERNO. SUL TERRENO BEN AFFINATO, LIVELLATO E FERTILE SI SEMINA, A 1-2 CM DI PROFONDITÀ, SU FILE DISTANTI 10-15 CM, A DISTANZA DI 3-4 CM SULLA FILA. IL TEMPO DI GERMINAZIONE È MINIMO, DATO CHE IN ESTATE GIÀ IN 2-3 GIORNI È POSSIBILE VEDERE IL PRIMO GERMOGLIO. LA SEMINA SI EFFETTUA DIRETTAMENTE A DIMORA PER TUTTO L’ANNO (TRANNE NEI MESI PIÙ FREDDI), ANCHE IN VASO O CASSETTA.",
                   CureColturali = "Predilige terreni sciolti e ben dotati di sostanza organica; suoli sassosi portano alla produzione di radici deformi. Le sarchiature sono importanti in primaveraestate, quando è maggiore il rischio di competizione con le malerbe. L’irrigazione è fondamentale per assicurare radici succose e tenere: va apportata quotidianamente in piccola quantità. ",
                   Raccolta = "La raccolta si effettua appena, scalzando il colletto, la radice appare ben formata.",
                   PropietaeBenefici = "",

                    Varieta1 = "",
                    Varieta2 = "",
                    Varieta3 = "",

                    Malattia1 = "",
                    Malattia2 = "",
                    Malattia3 = "",
                },

                new Orto
                {
                   NomeComunePianta = "SEDANO",
                   NomeFamiglia = "Ombrellifere",
                   NomeScientificoPianta = "Apium graveolens dulce",
                   FotoPianta = "ms-appx:///Immagini/Orto/Sedano/SEDANO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Orto/Abete-*.jpg",
                   LavoriOrto = "ms-appx:///Immagini/Orto/Sedano/calendario_lavori_sedano.jpg",


                   Semina = "SI SEMINA IN SEMENZAIO ALL’INIZIO DI MARZO, CON TRAPIANTO A DIMORA ALL’INIZIO DI MAGGIO, OPPURE A DIMORA IN MAGGIO-GIUGNO PER LA RACCOLTA AUTUNNALE. ATTENZIONE NELLA SEMINA: 1 G DI SEMENTE CONTIENE FINO A 2.000 SEMI. LE PRODE DEVONO ESSERE SOPRAELEVATE DI 10-15 CM; IL TRAPIANTO SI ESEGUE QUANDO LE PIANTINE SONO ALTE 15 CM, PONENDOLE A 50 CM TRA LE FILE E 30 CM SULLA FILA; SUBITO DOPO VA SOMMINISTRATA MOLTA ACQUA, PERCHÉ LA PIANTA SOFFRE NELL’OPERAZIONE.",
                   CureColturali = "Nell’interfila si interviene con zappettature per rimpere la crosta superficiale ed eliminare le malerbe. L’irrigazione deve essere leggera ma regolare, senza mai bagnare il fogliame; la siccità rende dure e fibrose le coste. L’imbianchimento si esegue legando le piante asciutte e coprendo di terra la base dei cespi. Le coste esterne, più verdi e tenaci, serviranno come aroma in cucina, quelle interne, chiare e croccanti, potranno essere consumate crude. ",
                   Raccolta = "Durante tutto il ciclo di coltivazione si possono asportare le coste esterne a mano a mano che servono. Una volta raggiunto il pieno sviluppo, i cespi vanno poi raccolti interi, tagliandoli alla base.",
                   PropietaeBenefici = "Foglie e radici hanno proprietà diuretiche, sudorifere e depurative e collaborano a ritrovare il benessere in caso di reumatismi, uricemia, renella e obesità. Inoltre il sedano stimola la digestione e la secrezione biliare. Il succo centrifugato, bevuto prima dei pasti principali, è un ottimo rimineralizzante. I frutti del sedano, che maturano nel secondo anno di coltivazione, favoriscono l’eliminazione dei gas intestinali.",

                    Varieta1 = "DA COSTE VERDI Vert d’Elne, Gigante di Romagna, Verde da Taglio. ",
                    Varieta2 = "DA COSTE BIANCHE Dorato d’Asti, Bianco Pieno. ",
                    Varieta3 = "DA COSTE ROSSE (sopporta meglio il freddo) Rosso di Torino, Martine Red. ",
                    Varieta4 = "SEDANO RAPA Gigante di Praga, Elne, Di Parigi.",

                    Malattia1 = "Rhizoctonia, Sclerotinia e batteriosi: eseguite la rotazione delle colture (attendete 3-4 anni prima di coltivare il sedano nella stessa proda), rispettate le distanze di trapianto e assicurate un ottimo sgrondo delle acque piovane. ",
                    Malattia2 = "Septoriosi: eseguite la rotazione delle colture, rispettate le distanze di trapianto, non bagnate le foglie in fase di irrigazione e imbianchite solo le piante asciutte.",
                    Malattia3 = "",
                },

                new Orto
                {
                   NomeComunePianta = "SPINACIO",
                   NomeFamiglia = "Chenopodiacee",
                   NomeScientificoPianta = "Spinacia oleracea",
                   FotoPianta = "ms-appx:///Immagini/Orto/Spinacio/SPINACIO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Orto/Abete-*.jpg",
                   LavoriOrto = "ms-appx:///Immagini/Orto/Spinacio/calendario_lavori_spinacio.jpg",


                   Semina = "LA SEMINA AVVIENE A DIMORA IN OGNI MOMENTO DELL’ANNO, TRANNE QUELLI PIÙ FREDDI (QUANDO I SEMI NON GERMINANO) O PIÙ CALDI (QUANDO LE PIANTINE VANNO SUBITO A FIORE). SEMINANDO A FINE ESTATE, LE PIANTINE DURANO PER TUTTO L’INVERNO. I SEMI SONO GROSSI E FACILI DA DISTRIBUIRE, A DISTANZA DI 6-8 CM, IN TUTTE LE DIREZIONI. IL TERRENO DEVE ESSERE SOLEGGIATO E SCIOLTO. SEMBRA CHE SI OTTENGANO MIGLIORI RISULTATI IN CONSOCIAZIONE CON IL PISELLO.",
                   CureColturali = "Per la coltivazione si scelga un appezzamento ben esposto al sole, con terreno sciolto. Se la semina è stata molto ravvicinata, è bene diradare quando le piantine sono alte pochi centimetri e hanno prodotto le prime foglie vere. La pianta è sensibile alla siccità:  è importante ricorrere a irrigazioni frequenti, oppure coprire la coltura con uno strato di compost o torba, che impedisce la rapida evaporazione dell’acqua superficiale.  ",
                   Raccolta = "Si possono raccogliere tutte insieme le foglie riunite in rosette, recidendole mantenendo una piccola porzione di radice. La raccolta può anche essere scalare, tagliando alla base del picciolo solo le foglie più esterne e sviluppate. In questo caso la coltura avrà una durata più prolungata, perché dal centro della rosetta continueranno a formarsi nuove foglie. Da 10 mq di terreno si possono ottenere 20-30 kg di spinaci.",
                   PropietaeBenefici = "Ricchi di fibre e di sali minerali come potassio, ferro, calcio e fosforo, per conservare il loro prezioso contenuto di vitamina A (di poco inferiore a quello della carota) e C gli spinaci dovrebbero essere consumati crudi (queste vitamine sono termolabili e si degradano con la cottura). Dal punto di vista delle proprietà curative, gli spinaci hanno un’azione lassativa, stimolano l’attività del cuore e del pancreas e collaborano alla risoluzione dell’anemia.",

                    Varieta1 = "Si distinguono varietà a foglie bollose, adatte per la coltivazione invernale, e varietà a foglie lisce, che necessitano di giornate lunghe, e quindi sono più adatte per la coltivazione nelle altre stagioni. ",
                    Varieta2 = "SPINACI A FOGLIE BOLLOSE Gigante d’inverno, Riccio di Castelnuovo, Riccio di Asti, Merlo nero, Mostruoso di Virofl ay, Samos F1.",
                    Varieta3 = "SPINACI A FOGLIE LISCE Virofl ay, Matador, Estivado.",

                    Malattia1 = "Afidi: in caso di infestazione si può intervenire con prodotti a base di piretro, rispettando però, in vista della raccolta, i tempi di carenza in genere segnalati in etichetta.",
                    Malattia2 = "Mosca dello spinacio: le larve di questo insetto scavano gallerie nello spessore delle foglie, danneggiando soprattutto le piantine ai primi stadi di sviluppo. ",
                    Malattia3 = "Peronospora: nei terreni dove questa malattia crittogamica si è già manifestata bisogna attendere qualche anno prima di rifare la stessa coltura e, soprattutto, usare ibridi F1, perché sono più resistenti. Qualora la malattia si instauri, ricordate che eventuali trattamenti con prodotti chimici determinano la non commestibilità del raccolto. Sicuramente sono più a rischio i raccolti autunnali.",
                },

                new Orto
                {
                   NomeComunePianta = "VALERIANA",
                   NomeFamiglia = "Valerianacee",
                   NomeScientificoPianta = "Valerianella locusta",
                   FotoPianta = "ms-appx:///Immagini/Orto/Valeriana/VALERIANA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Orto/Abete-*.jpg",
                   LavoriOrto = "ms-appx:///Immagini/Orto/Valeriana/calendario_lavori_valerianella.jpg",


                   Semina = "L’AIUOLA DESTINATA ALLA VALERIANELLA NON NECESSITA DI LAVORAZIONI, DATO CHE SI TRATTA DI UN’INSALATA RUSTICA E POCO ESIGENTE CHE PREFERISCE TERRENI POVERI. SI SEMINA A SPAGLIO, DISTRIBUENDO UNIFORMEMENTE IL SEME IN DOSE DI 1-1,5 G/MQ E COPRENDOLO CON UN SOTTILE STRATO DI TERRA; POI SI COMPATTA E SI IRRIGA DOLCEMENTE. LA SEMINA SI EFFETTUA A FINE ESTATE PER LA RACCOLTA AUTUNNO-INVERNALE (ANCHE SOTTO TUNNEL) E A FINE INVERNO PER QUELLA PRIMAVERILE.",
                   CureColturali = "L’irrigazione è limitata a sporadici casi di siccità, così come la rimozione di eventuali erbe infestanti. Pur non soffrendo la competizione di quest’ultime (nella flora spontanea convive con le colture dei campi), mantenendo il terreno pulito si garantisce uno sviluppo maggiore e più rapido delle rosette. Coprendo la valerianella con foglie secche di felce o noce si ottiene il prolungamento del raccolto fino al cuore dell’inverno. ",
                   Raccolta = "Quando la valerianella ha formato una rosetta ricca di foglie, si provvede alla raccolta del cespo intero prelevando anche una piccola porzione di radici. Le piante dovrebbero essere asciutte per evitare che abbiano luogo marciumi durante la conservazione, con conseguente danneggiamento dell’ortaggio. Il primo raccolto autunnale può essere fatto tagliando le foglie al colletto: in una decina di giorni se ne formeranno altre, che andranno raccolte con le radici. Da 1 mq si può ottenere fi no a 1 kg di insalatina. ",
                   PropietaeBenefici = "La valerianella ha virtù sedative del sistema nervoso, antispastiche, antinevralgiche, leggermente ipnotiche. Le sue radici contengono circa l’1% di un olio essenziale dall’effetto antispastico. La pianta agisce quindi come tranquillante e calmante; favorisce il sonno, è un blando analgesico e anticonvulsivo e abbassa la pressione arteriosa. Il cataplasma di foglie pestate può alleviare il dolore in caso di contusioni, lombaggini, sciatica, stiramenti muscolari e dolori reumatici.",

                    Varieta1 = "A FOGLIE GRANDI Poco resistente al gelo: d’Olanda a Seme Grosso. ",
                    Varieta2 = "A FOGLIE PICCOLE Più lisce e lucide: Verde a Cuore Pieno, compatta con foglie poco carnose; D’Etampes, dotata di una buona resistenza al freddo; Verde di Cambrai.",
                    Varieta3 = "",

                    Malattia1 = "Muffa grigia, Sclerotinia e Pythium: assicurate un ottimo sgrondo dell’acqua dal terreno, distruggete i residui di coltivazione e utilizzate solo letame ben maturo. ",
                    Malattia2 = "Lumache: per proteggere le prode di valerianella dalle lumache, che sono ghiotte di questo ortaggio, utilizzate un pezzo di rete zincata a maglie fini con il quale circondare la proda. La rete dovrà essere interrata per circa 15 cm e sporgere per almeno 30-40 centimetri.",
                    Malattia3 = "",
                },

                new Orto
                {
                   NomeComunePianta = "ZUCCHINO",
                   NomeFamiglia = "Cucurbitacee",
                   NomeScientificoPianta = "Cucurbita pepo",
                   FotoPianta = "ms-appx:///Immagini/Orto/Zucchino/ZUCCHINO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Orto/Abete-*.jpg",
                   LavoriOrto = "ms-appx:///Immagini/Orto/Zucchino/calendario_lavori_zucchino.jpg",


                   Semina = "SI SEMINA IN AMBIENTE PROTETTO, CON TEMPERATURA DI ALMENO 20 °C, A PARTIRE DALLA SECODNA METÀ DI MARZO PER OTTENERE PIANTINE CON 3-5 FOGLIE VERE ENTRO LA METÀ DI MAGGIO, QUANDO AVVIENE IL TRAPIANTO ALL’APERTO. LE FILE DEVONO ESSERE A 100-120 CM DI DISTANZA TRA LORO, CON TRAPIANTO SULLA FILA A 70-80 CM DI DISTANZA E A 8-10 CM DI PROFONDITÀ PER INSERIRE IL PANE DI TERRA. TUTT’INTORNO È BENE ESEGUIRE UNA BUONA RINCALZATURA FINO AL COLLETTO. ",
                   CureColturali = "Per evitare le sarchiature nei primi tempi di sviluppo è consigliabile porre un telo di plastica nera per pacciamatura. L’irrigazione va praticata solo quando necessario e sempre per infiltrazione laterale, evitando di bagnare il fogliame, molto soggetto al mal bianco. Si possono porre tutori per l’allevamento in verticale, legandovi i fusti. ",
                   Raccolta = "La zucchina si raccoglie immatura, quando è lunga 15-25 cm, recidendo il peduncolo con un coltello affilato, evitando di tirare. È necessario ispezionare la coltura quasi ogni giorno, perché i frutti crescono rapidamente e diventano inservibili (ricchi di semi e acquosi) quando raggiungono grandi dimensioni. Da 10 mq di coltura si ottengono circa 30-35 kg di prodotto.",
                   PropietaeBenefici = "La polpa e il succo hanno proprietà diuretiche e lassative; inoltre, applicate direttamente sulla pelle, hanno un’azione cosmetica ammorbidente e vitaminizzante. Povera di calorie e ricca di acqua, la zucchina è uno degli ortaggi estivi più indicati nelle diete ipocaloriche e contro la ritenzione idrica nei tessuti.",

                    Varieta1 = "DIAMANT Colore verde lucente, frutto lungo, produzione precoce, pianta con vegetazione allargata che facilita il raccolto. ",
                    Varieta2 = "PRESIDENT Verde medio scuro, pianta aperta per facilitare la raccolta, adatta per seconda coltura. ",
                    Varieta3 = "ROMANESCO Standard striato, frutto lungo; produzione medio-tardiva.",
                    Varieta4 = "TARMINO Colore verde scuro lucente, taglia media adatta per colture a pieno campo; molto produttivo. ",

                    Malattia1 = "Marciumi: rotazione delle colture (4 anni prima di ricoltivare la zucchina nello stesso terreno), buon drenaggio dell’acqua e concimazioni azotate ridotte.",
                    Malattia2 = "Oidio: colpisce in genere a fine coltura; solo in casi estremi irrorate nelle ore più fresche della giornata con un prodotto a base di zolfo bagnabile-80 (8-10 g/10 l di acqua).",
                    Malattia3 = "",
                },

                new Orto
                {
                   NomeComunePianta = "ZUCCHE",
                   NomeFamiglia = "Cucurbitacee",
                   NomeScientificoPianta = "Cucurbita maxima, C. moschata",
                   FotoPianta = "ms-appx:///Immagini/Orto/Zucche/ZUCCHE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Orto/Abete-*.jpg",
                   LavoriOrto = "ms-appx:///Immagini/Orto/Zucche/calendario_lavori_zucche.jpg",


                   Semina = "DOPO UN’ACCURATA PREPARAZIONE DEL TERRENO E UNA NOTEVOLE CONCIMAZIONE CON COMPOST O LETAME MATURO, SI SEMINA A DIMORA IN POSTARELLE (3 SEMI NELLA STESSA BUCHETTA A 2-3 CM DI PROFONDITÀ), DALLA FINE DI APRILE ALLA FINE DI MAGGIO. QUANDO LE PIANTINE HANNO 3-4 FOGLIE VERE, SI DIRADA IN OGNI POSTARELLA, CONSERVANDO SOLO LA PIANTINA PIÙ SANA E VIGOROSA. LA DISTANZA TRA LE FILE E SULLA FILA È DI ALMENO 1,5 METRI. SI PUÒ SEMINARE IN AMBIENTE PROTETTO IN MARZO.",
                   CureColturali = "Le infestanti vanno sarchiate solo finché rimane lo spazio vuoto tra le piante; in alternativa si può disporre il telo da pacciamatura. La cimatura si esegue quando si sono sviluppate 4-5 foglie sullo stelo. I frutti vanno diradati quando hanno le dimensioni di una noce, lasciandone 2 per pianta a bacca grossa e 5 se a bacca piccola. Si irriga regolarmente in estate fino al completo ingrossamento dei frutti.",
                   Raccolta = "Quando si verificano l’appassimento della vegetazione e il disseccamento del peduncolo, le zucche sono pronte per essere raccolte. Benché i primi frutti si possano già asportare all’inizio di settembre, la permanenza in terra sino a quando non cominciano le piogge autunnali ne garantisce una migliore conservazione. Il picciolo va staccato di netto con l’aiuto di un coltello affilato per impedire il passaggio dell’aria all’interno del frutto, con possibile insorgenza di marciumi.",
                   PropietaeBenefici = "La zucca è un alimento amico delle diete povere di calorie per la scarsità in termini glucidici. Essendo arancione è ricca di caroteni, pro-vitamina A, vitamine B e C e di minerali (fosforo, magnesio, ferro e potassio). I semi non sono tossici.",

                    Varieta1 = "Sono centinaia le varietà selezionate in tutto il mondo e alcune di quelle tipiche italiane sono considerate tra le più buone, come Marina di Chioggia. ",
                    Varieta2 = "STANDARD Buttermut, Gigante Quintale, Lunga di Napoli, Tromba d’Albenga",
                    Varieta3 = "ZUCCHETTE ORNAMENTALI Mandarin, Griffes du Diable.",

                    Malattia1 = "Oidio: colpisce le zucche a fine estate formando una sottile patina bianca sulla pagina superiore delle foglie. Si combatte con prodotti a base di zolfo",
                    Malattia2 = "Afidi: colonizzano gli apici vegetativi provocando un indebolimento della nuova vegetazione e possibili virosi. ",
                    Malattia3 = "Marciumi: eseguite la rotazione delle colture (aspettate 4 anni prima di coltivare la zucca nello stesso terreno), curate il drenaggio dell’acqua in eccesso e limitate le concimazioni azotate e le irrigazioni.",
                    Malattia4 = "Peronospora: assicuratevi che il terreno sgrondi facilmente l’acqua piovana; contenete le concimazioni e le irrigazioni.",
                },

                
            };

            return data;
        }

        // TODO WTS: Remove this once your MasterDetail pages are displaying real data
        public static async Task<IEnumerable<Orto>> GetSampleModelDataAsync()
        {
            await Task.CompletedTask;

            return AllOrto();
        }

        
    }
}
