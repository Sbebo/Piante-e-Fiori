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
//7 ALTRI FRUTTI (SELVATICI)
    public class AltriFrutti
    {
        public string NomeComunePianta { get; set; }
        public string NomeFamiglia { get; set; }
        public string NomeScientificoPianta { get; set; }
        public string FotoPianta { get; set; }
        public string SourceGalleryFotografica { get; set; }

        public string ClimaeTerreno { get; set; }
        public string CureConsigliate { get; set; }
        public string RaccoltaeConservazione { get; set; }
        
        public string VarietaConsigliate1 { get; set; }
        public string VarietaConsigliate2 { get; set; } 
        public string VarietaConsigliate3 { get; set; }
        public string VarietaConsigliate4 { get; set; }
        public string VarietaConsigliate5 { get; set; }

        public string SimboloPosizione { get; set; } //sole, ombra, parziale
        public string SimboloAcqua { get; set; } //media tanta poca
        public string SimboloDurata { get; set; } //annuale o biennale
        public string SimboloFogliame { get; set; } //caduco o persistente
    }

    public static class AltriFruttiDataService
    {
        private static IEnumerable<AltriFrutti> AllAltriFrutti()
        {
            // The following is order summary data
            var data = new ObservableCollection<AltriFrutti>
            {
               
                new AltriFrutti
                {
                   NomeComunePianta = "CASTAGNO",
                   NomeFamiglia = "Fagacee",
                   NomeScientificoPianta = "Castanea sativa",
                   FotoPianta = "ms-appx:///Immagini/ALTRIFRUTTI/Castagno/CASTAGNO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/FRUTTIMONTANI/Abete-*.jpg",

                   
                   ClimaeTerreno = "Il castagno è coltivato dalla bassa collina fino ai 1.200 m; non resiste al caldo e ha bisogno di non soffrire la sete in estate-autunno. Le sue poderose radici richiedono terreno fertile e profondo, meglio se neutro o acido. Indispensabile il pieno sole. Al momento della piantumazione siate previdenti e calcolate lo spazio necessario allo sviluppo della pianta, che assume dimensioni maestose. In Italia esistono esemplari antichissimi: il Castagno dei 100 cavalli di Sant’Alfio, in Sicilia, ha più di 2.000 anni.",
                   CureConsigliate = "Le potature si limitano a una pulizia primaverile. Gli esemplari giovani gradiscono concime organico a fine inverno e un prodotto azotato in settembre-ottobre per favorire la fioritura, la cui impollinazione è affidata al vento. ",
                   RaccoltaeConservazione = "I frutti maturi cadono a terra e si estraggono dal riccio. Individuare quelli bacati è semplice: basta metterli in acqua ed eliminare i frutti che galleggiano. La permanenza in acqua per qualche giorno e la conservazione in luogo fresco, appoggiati su graticci o in cassette con sabbia asciutta, mantengono i frutti ottimi per circa 2 mesi.",

                   VarietaConsigliate1 = "Esistono numerose varietà tipiche locali, da preferire perché nel tempo selezionate per quel particolare clima e terreno. ",
                   VarietaConsigliate2 = "Castagna: le varietà locali italiane sono decine, alcune specifiche per l’essiccamento o la produzione di farina. Oggi alcune varietà sono protette dal marchio IGP. ",
                   VarietaConsigliate3 = "Marrone: i frutti (in genere solo uno in ogni riccio) sono grossi e dolci. Molte varietà di marroni sono autosterili e occorre piantare nelle vicinanze varietà di castagne compatibili.",
                   VarietaConsigliate4 = "",
                   VarietaConsigliate5 = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun.png",

                },

                 new AltriFrutti
                {
                   NomeComunePianta = "NOCE",
                   NomeFamiglia = "Juglandacee",
                   NomeScientificoPianta = "Juglans regia, J. nigra",
                   FotoPianta = "ms-appx:///Immagini/ALTRIFRUTTI/Noce/NOCE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/FRUTTIMONTANI/Abete-*.jpg",

                   
                   ClimaeTerreno = "Questo albero maestoso non ha grandi esigenze e resiste bene sia al freddo sia al caldo, dalla pianura alla media collina. Lo sviluppo migliore avviene in terreni fertili e non troppo asciutti, senza ristagni a livello radicale. Tollera il suolo calcareo. ",
                   CureConsigliate = "La pianta viene coltivata nella sua forma naturale; le varietà allevate per ottenere il pregiato legno devono avere l’impalcatura dei rami ad almeno 4-5 m da terra. Non ama subire potature sul legno vecchio, in quanto le ferite si rimarginano con difficoltà. Per questo conviene ogni anno effettuare una pulizia generale e uno sfoltimento dei rami giovani in eccesso, per evitare poi di dover tagliare grossi rami. Conviene irrigare solo gli esemplari giovani; in seguito, la pianta è autosufficiente. ",
                   RaccoltaeConservazione = "I frutti si raccolgono scrollando o scuotendo i rami con l’aiuto di un bastone; il mallo va tolto subito dopo la raccolta, altrimenti si annerisce e diventa duro. Le noci si conservano per mesi in luogo fresco e asciutto; quelle commercializzate vengono sbiancate con anidride solforosa.",

                   VarietaConsigliate1 = "Franquette e Hartley: francese la prima e americana la seconda, sono varietà adatte per le regioni del Centro-Nord. La prima dà piante interessanti sia per il frutto sia per il legno di alta qualità. ",
                   VarietaConsigliate2 = "Noce di Sorrento: è la varietà più celebre. Il gheriglio, di grosse dimensioni, si stacca facilmente intero.",
                   VarietaConsigliate3 = "Noce Pecan: la specie Carya illinoensis è affine al noce comune ed è usata anche come albero ornamentale. In Italia è coltivata in Puglia. I frutti maturano a novembre, hanno guscio tenero e gheriglio di ottimo sapore. Preferisce i climi caldi.",
                   VarietaConsigliate4 = "",
                   VarietaConsigliate5 = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun&Cloud.png",

                 },

                new AltriFrutti
                {
                   NomeComunePianta = "NOCCIOLO",
                   NomeFamiglia = "Corilacee",
                   NomeScientificoPianta = "Corylus avellana",
                   FotoPianta = "ms-appx:///Immagini/ALTRIFRUTTI/Nocciolo/NOCCIOLO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/FRUTTIMONTANI/Abete-*.jpg",

                   
                   ClimaeTerreno = "Arbusto o albero a ceppaia, il nocciolo è pianta tipica del sottobosco mediterraneo e prealpino. Robusta e rustica, resiste al freddo ed è poco esigente in fatto di terreno. Meglio evitare le zone battute dal vento.",
                   CureConsigliate = "In Italia la produzione di nocciole è concentrata in Campania e Piemonte, in impianti ad elevata tecnologia, su filari che consentono la raccolta meccanizzata. A livello familiare conviene lasciare le piante a cespuglio o ceppaia, mantenendo 5-6 branche per ogni esemplare. Occorrono 4-5 anni prima che un giovane nocciolo entri in produzione. Il nocciolo fruttifica sui rami di un anno, che in seguito non sono più produttivi: è quindi necessario rinnovare ogni anno la chioma. Le concimazioni sono suggerite solo nelle fasi giovanili e gli interventi parassitari non sono necessari.",
                   RaccoltaeConservazione = "I frutti caduti a terra sono al giusto grado di maturazione. Dopo aver tolto l’involucro di foglie, le nocciole vanno fatte asciugare al sole; stese in cassette su uno strato di sale grosso, in ambiente privo di umidità, si conservano per mesi.",

                   VarietaConsigliate1 = "Nocciola Romana: antica varietà del Lazio e in particolare del Viterbese. È in corso la procedura per il marchio DOP.",
                   VarietaConsigliate2 = "Tonda Gentile delle Langhe: dà pregiati frutti grossi, è adatta alla coltivazione in aree collinari con terreno fresco e fertile. La nocciola piemontese è protetta dal marchio IGP.",
                   VarietaConsigliate3 = "Tonda di Giffoni: anche questa varietà IGP, tipica del Salernitano, è di eccellente qualità; per zone calde e asciutte.",
                   VarietaConsigliate4 = "",
                   VarietaConsigliate5 = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun.png",

                },

                new AltriFrutti
                {
                   NomeComunePianta = "FICO D'INDIA",
                   NomeFamiglia = "Cactacee",
                   NomeScientificoPianta = "Opuntia ficus-indica",
                   FotoPianta = "ms-appx:///Immagini/ALTRIFRUTTI/Fico d'India/FICO D'INDIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/FRUTTIMONTANI/Abete-*.jpg",

                   
                   ClimaeTerreno = "Ha un fusto formato da pale (cladodi) carnose che svolgono la fotosintesi clorofilliana e sono coperte da numerose spine, molto piccole, disposte intorno alle gemme. Supporta lunghi periodi di siccità.",
                   CureConsigliate = "La forma di allevamento è simile a quella a vaso. Non necessita di irrigazione, mentre la concimazione deve essere a base di fosforo e potassio in primavera. Se il clima lo consente, si eliminano in maggio le nuove pale e i fiori per favorire le corolle di giugno, che in novembre danno frutti migliori per dimensioni (“bastardoni”). La potatura è volta ad arieggiare la pianta, scongiurando i contatti fra le pale. ",
                   RaccoltaeConservazione = "Nell'area mediterranea, la raccolta del fico d'india (Opuntia ficus-indica) può avvenire da luglio a fine agosto quando la fioritura ha luogo nella tarda primavera (maggio-giugno), oppure da fine settembre a dicembre quando la fioritura si è avuta a fine luglio dopo la scozzolatura, tecnica coltura che consiste nell'asportazione dei frutti e di tutte le pale giovani emessi nel normale flusso vegetativo primaverile. Generalmente viene effettuata durante il periodo della fioritura, nella prima quindicina di giugno. Lo scopo è quello di ottenere una seconda fruttificazione, di maggiore pregio e posticipata nel tempo (autunno). ",

                   VarietaConsigliate1 = "Le varietà, gialla, bianca e rossa, si riferiscono al colore del frutto-",
                   VarietaConsigliate2 = "",
                   VarietaConsigliate3 = "",
                   VarietaConsigliate4 = "",
                   VarietaConsigliate5 = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sempreverde.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun.png",

                },

                new AltriFrutti
                {
                   NomeComunePianta = "RIBES",
                   NomeFamiglia = "Sassifragacee",
                   NomeScientificoPianta = "Ribes rubrum, R. nigrum",
                   FotoPianta = "ms-appx:///Immagini/ALTRIFRUTTI/Ribes/RIBES.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/FRUTTIMONTANI/Abete-*.jpg",

                   
                   ClimaeTerreno = "Le piante di ribes, disponibili con frutti rossi o bianchi (Ribes rubrum) o con bacche nere (R. nigrum, dal gusto acidulo non a tutti gradito), tollerano il freddo invernale, che anzi è necessario perché fruttifichino con regolarità. Si adattano anche a terreni poco fertili, purché non siano siccitosi o troppo umidi. I ribes rosso e bianco gradiscono suoli a reazione neutra o piuttosto acida (pH 6-7); il nero vuole un terreno neutro o un po’ alcalino (pH 7-8).",
                   CureConsigliate = "Le coltivazioni da reddito sono disposte su filari per favorire gli interventi di cura; in giardino o ai bordi del frutteto le piante possono formare cespugli o piccole siepi. Ogni anno è necessario potare a fine inverno per favorire la produzione di nuovi steli, che porteranno i frutti. Consigliabile concimare con sostanza organica nel tardo autunno. Le coltivazioni da reddito sono disposte su filari per favorire gli interventi di cura; in giardino o ai bordi del frutteto le piante possono formare cespugli o piccole siepi. Ogni anno è necessario potare a fine inverno per favorire la produzione di nuovi steli, che porteranno i frutti. Consigliabile concimare con sostanza organica nel tardo autunno.",
                   RaccoltaeConservazione = "Si raccolgono staccando il peduncolo che porta il grappolo di frutti. I frutti maturi lasciati sulla pianta si conservano per diversi giorni, il che consente una raccolta scalare. Oltre al consumo fresco, sono utilizzabili per succhi, gelatine e conserve.",

                   VarietaConsigliate1 = "Le varietà a frutto rosso o bianco sono tutte di facile coltivazione; sono disponibili a maturazione precoce (Junifer) o tardiva (Rosetta): potendo piantare più di un esemplare, si ottiene un raccolto distribuito su molte settimane, tra luglio e agosto. Essendo autoimpollinanti, la fruttificazione è sempre garantita.",
                   VarietaConsigliate2 = "Il ribes a frutto nero, poco diffuso in Italia, è molto coltivato in Francia per la produzione del noto liquore Cassis. La varietà Noir de Bourgogne è fra le migliori; dà raccolto in agosto.",
                   VarietaConsigliate3 = "",
                   VarietaConsigliate4 = "",
                   VarietaConsigliate5 = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun&Cloud.png",

                },

                new AltriFrutti
                {
                   NomeComunePianta = "LAMPONE",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Rubus idaeus",
                   FotoPianta = "ms-appx:///Immagini/ALTRIFRUTTI/Lampone/LAMPONE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/FRUTTIMONTANI/Abete-*.jpg",

                   ClimaeTerreno = "Il più coltivato fra i frutti di bosco è anche il più esigente in fatto di terreno, che deve essere a pH acido, fertile e drenato. Il caldo eccessivo nuoce, mentre non sono un problema le temperature rigide (anche –20 °C). ",
                   CureConsigliate = "Occorre riconoscere le varietà unifere, che producono una sola volta l’anno, e le varietà bifere o rifiorenti che fruttifi cano sia sui rami dell’anno precedente, a inizio estate, sia sui polloni dell’anno, a settembre. Sopprimendo la fruttificazione estiva sulle varietà bifere, quella autunnale risulta migliore. I lamponi si allevano in filari con l’ausilio di pali e fili orizzontali ai quali si legano i tralci o si indirizzano i polloni nel caso di varietà rifiorenti. Per evitare lo sviluppo delle infestanti è consigliabile proteggere il suolo con teli di plastica nera. Le irrigazioni vanno effettuate al piede, senza bagnare le foglie per ridurre il rischio di malattie fungine su foglie e frutti.",
                   RaccoltaeConservazione = "Il frutto è al punto giusto quando si stacca senza fatica dal peduncolo. I lamponi si conservano bene anche surgelati, avendo l’accortezza di farli scongelare lentamente.",

                   VarietaConsigliate1 = "Fall Gold: curiosa varietà di origine americana, con frutti giallo oro. ",
                   VarietaConsigliate2 = "Glen Moy: unifera, buona produzione precoce, adatta alla surgelazione.",
                   VarietaConsigliate3 = "Ruby: varietà bifera di buona adattabilità e con frutti di grossa pezzatura. ",
                   VarietaConsigliate4 = "September: bifera, con frutti autunnali particolarmente dolci.",
                   VarietaConsigliate5 = "Zeva: pianta bifera, interessante e di aspetto decorativo, non ha bisogno ",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun&Cloud.png",

                },

                new AltriFrutti
                {
                   NomeComunePianta = "UVA SPINA",
                   NomeFamiglia = "Ribes grossularia var. uva-crispa",
                   NomeScientificoPianta = "",
                   FotoPianta = "ms-appx:///Immagini/ALTRIFRUTTI/Uva Spina/UVA SPINA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/FRUTTIMONTANI/Abete-*.jpg",

                   
                   ClimaeTerreno = "Questo arbusto, affine al ribes, è spontaneo nei boschi dell’Europa settentrionale e in alcune aree della fascia prealpina italiana. Come il ribes, non accetta il suolo arido. Ha buona resistenza al freddo; se viene coltivato in situazioni afose e costantemente umide si ammala facilmente di oidio e altre patologie fungine. Non è molto esigente circa il pH, che può essere anche un po’ calcareo.",
                   CureConsigliate = "Per una produzione da reddito, le piante sono allevate su bassi filari. In giardino può essere lasciata anche a portamento espanso, tenendo presente che i rami portano spine pungenti, con la sola esclusione delle varietà del gruppo Josta. Risente della competizione con le erbe infestanti, ed è dunque consigliabile effettuare una pacciamatura con teli o corteccia tritata. La potatura si effettua ogni anno in autunno o inverno, per stimolare la produzione di nuovi getti: i frutti nascono infatti sui rami dell’anno.",
                   RaccoltaeConservazione = "I frutti maturi possono rimanere a lungo sulla pianta. L’uva spina è surgelabile o trasformabile in conserve e succhi, terapeutici per le affezioni della gola e della faringe.",

                   VarietaConsigliate1 = "Careless: varietà ottenuta in Inghilterra, dove il frutto è molto diffuso. Produce grossi frutti verdi, dolci e succosi. ",
                   VarietaConsigliate2 = "Hinnomaki: frutti rossastri e polposi, per il consumo fresco. ",
                   VarietaConsigliate3 = "Josta: gruppo di varietà olandesi ottenute incrociando l’uva spina con il ribes nero. I frutti, di grossa dimensione e prodotti in notevole quantità da cespugli di media dimensione, hanno sapore gradevole. Le piante sono prive di spine.",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun.png",

                },

                

            };

            return data;
        }

        // TODO WTS: Remove this once your MasterDetail pages are displaying real data
        public static async Task<IEnumerable<AltriFrutti>> GetSampleModelDataAsync()
        {
            await Task.CompletedTask;

            return AllAltriFrutti();
        }


    }
}
