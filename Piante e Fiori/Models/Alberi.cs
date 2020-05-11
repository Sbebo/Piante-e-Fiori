
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Piante_e_Fiori.Models;


namespace Piante_e_Fiori.Models
{
//40 ALBERI
    public class Alberi
    {
        public long AlberoID { get; set; }
        public string NomeComunePianta { get; set; }
        public string NomeFamiglia { get; set; }
        public string NomeScientificoPianta { get; set; }
        public string FotoPianta { get; set; }
        public string SourceGalleryFotografica { get; set; }

        public string DescrizioneBotanica { get; set; }
        public string Coltivazione { get; set; }
        public string Propagazione { get; set; }
        public string Potatura { get; set; }
        public string Malattie { get; set; }
        public string AltreCaratteristiche { get; set; }

        public string SimboloPosizione { get; set; } //sole, ombra, parziale
        public string SimboloAcqua { get; set; } //media tanta poca
        public string SimboloDurata { get; set; } //annuale o biennale
        public string SimboloFogliame { get; set; } //caduco o persistente


        public string ShortDescription => $"Albero ID: {AlberoID}";
    }

    public static class AlberiDataService
    {
        private static IEnumerable<Alberi> AllAlberi()
        {
            // The following is order summary data
            var data = new ObservableCollection<Alberi>
            {
                new Alberi
                {
                   NomeComunePianta = "ABETE",
                   NomeFamiglia = "Pinacee",
                   NomeScientificoPianta = "Picea excelsa",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Abete/ABETE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ALBERI/Abete-*.jpg",

                   DescrizioneBotanica = "P. EXCELSA È L'ABETE ROSSO O PECCIO, QUELLO CHE PIÙ COMUNEMENTE VIENE USATO COME ALBERO DI NATALE. SPONTANEO IN ITALIA È ANCHE L'ABETE BIANCO (ABIES ALBA). VENGONO COLTIVATI INOLTRE P. GLAUCA (ABETE ARGENTATO), P. PUNGENS, P. OMORIKA E ALTRI. SONO TUTTE AGHIFOGLIE DALLO SVILUPPO RAPIDO E IMPONENTE (FINO A 20-40 M D'ALTEZZA E 6 M DI DIAMETRO) DI CUI TENERE CONTO PER LO SPAZIO OCCUPATO IN GIARDINO. SOTTO LE LORO FRONDE È INOLTRE DIFFICILE CHE CRESCANO ALTRE PIANTE",
                   Coltivazione = "Sono tutti alberi che prediligono climi freddi: in pianura hanno in genere un'esistenza stentata. Amano, inoltre, suoli leggermente acidi, oltre che profondi e freschi. Vanno posizionati a suffciente distanza da edifici e manufatti, in base alla dimensione che avranno da adulti: non sopportano infatti le potature, men che meno le capitozzature (come tutte le conifere), che li lasciano deturpati e incapaci di crescere.",
                   Propagazione = "La propagazione in natura avviene generalmente tramite seme, mentre a livello vivaistico sono più praticate la talea e l'innesto. Generalmente queste ultime vengono preferite sia perché permettono di avere esemplari adulti in un tempo più breve sia perché è l'unico metodo che garantisca la preservazione dei caratteri originali di alcune cultivar. Il ripopolamento di un'area può essere ottenuto tramite autodisseminazione, semina diretta da pare dell'uomo o tramite inserimento di piccoli esemplari. I coni cominciano ad aprirsi e a decomporsi dalla fine di settembre-inizio ottobre. il più delle volte per un singolo albero vi sono annate con grande produzione e altre più scarse, con un'alternanza di 2 o 5 anni.  I semi danno origine a piantie in primavera, ma la germinabilità è piuttosto bassa, intorno al 50%. Per ottenere buoni risultati, quindi, è consigliabile porre a dimora almeno 15 pinoli per volta. Fortunatamente l'abete tollera molto bene l'ombra e quindi, anche se inizialmente svantaggiato per questa bassa germinabilità, riesce a far sviluppare bene le proprie piantine fino a quando non raggiungano l'altezza adatta ad esporle alla luce solare e dominare l'ambiente. La crescita inizialmente, per i primi 30 anni, è abbastanza lenta. Una volta raggiunta quell'età cresce invece esponenzialmente.  Gli esemplari ideali per la messa a dimora sono quelli con un'età dai 2 ai 4 anni.",
                   Potatura = "Le specie ad allevamento libero richiedono scarsi ma mirati interventi di potatura, soprattutto tesi ad eliminare le cime doppie o il riassestamento della medesima accidentalmente danneggiata ed anche per la eliminazione di rami scomposti o troppo bassi, che si possono rovinare facilmente per i frequenti passaggi con attrezzi vari. Talvolta la potatura viene fatta fuori periodo ottimale (autunno - inverno), come ad esempio per l'eliminazione dei 'nidi di processionarie' insetti che si sviluppano nel periodo primaverile o per l'eliminazione di branche che manifestano patologie tipo i cancri rameali. Sui tagli di potatura o sulle ferite è bene intervenire in ogni caso con cicatrizzante al fine di proteggere la ferita da penetrazione di patogeni.",
                   Malattie = "L'abete è in generale un albero molto resistente. Può subire, però, attacchi da parte di afidi oppure chermi lanigeri che possono provocare danni, in particolar modo all'apparato fogliare. Un altro insetto molto pericoloso è la processionaria, le larve dai cui si sviluppano le falene. Questo insetto nidifica tra i rami dell'abete rosso. Esso rappresenta un serio pericolo per la pianta, dato che si ciba degli aghi dell'abete e in poco tempo è in grado di distruggere interi rami. Inoltre la processionaria è molto pericolosa anche per l'uomo e per gli animali domestici, in particolar modo per i cani, dato che il suo pelo ha un forte effetto urticante. Per eliminare il problema è sufficiente rimuovere, prestando molta attenzione, il nido e tutti gli insetti evitando di entrare in contatto diretto con essi.",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sempreverde.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/moderate-rain.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun&Cloud.png",

                },
                new Alberi
                {
                   NomeComunePianta = "ACACIA",
                   NomeFamiglia = "Leguminose",
                   NomeScientificoPianta = "Acacia dealbata",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Acacia/ACACIA(MIMOSA).jpg",

                   DescrizioneBotanica = "L'ACACIA O MIMOSA È ADATTA ALLE ZONE PIÙ MITI, PER QUANTO, IN POSIZIONE MOLTO RIPARATA E SOLEGGIATA, SI POSSA TENTARE DI COLTIVARLA ANCHE IN VAL PADANA. PUÒ RAGGIUNGERE L'ALTEZZA DI 20 (DIAMETRO MASSIMO 8 M). PRESENTA FOGLIE COMPOSTE, CHE CADONO IN INVERNO. IN GENNAIO-MARZO PRODUCE UNA VISTOSA FIORITURA PROFUMATA, DI UN INTENSO COLORE GIALLO, DIVENUTA IL SIMBOLO DELLA FESTA DELLA DONNA. NEI RESTANTI MESI SI TRATTA, PERÒ, DI UN ALBERO UN PO' ANONIMO.",
                   Coltivazione = "Non resiste al freddo: risultano pericolose già temperature di 0 °C. Ama il sole e le temperature elevate, alle quali reagisce senza richiedere annaﬃature (nel caso di esemplari già adulti in piena terra). Richiede un terreno leggero, sciolto, anche sassoso ma fertile. Per favorire la ﬁoritura si può concimare in autunno. Le potature si eﬀettuano solo se necessario, per ripulire l'albero. Può vivere anche in un grande vaso.",
                   Propagazione = "Acacia dealbata è propagata per seme con facilità, mentre la talea è pratica poco usata a causa della bassa radicazione delle marze (entrambe vanno effettuata in primavera). Diffuso è anche l'innesto, che sfrutta semenzali della congenere Acacia retinoides. La messa a dimora si effettua dall'autunno alla primavera. È quasi ovunque consigliabile procedere in primavera, per evitare un eventuali gelate che potrebbero danneggiare irreparabilmente un giovane albero.",
                   Potatura = "Le potature si effettuano in primavera, alla fine della fioritura. Questo, oltre a favorire una crescita compatta e armoniosa eviterà la comparsa del baccelli, poco gradevoli e, conseguentemente, un'eccessiva autodisseminazione. Si deve intervenire anche con una certa frequenza per eliminare getti provenienti dal piede che indeboliscono la chioma. Alla fine dell'inverno intervenire eliminando le branche eventualmente compromesse dal gelo.",
                   Malattie = "I parassiti più frequenti sono le cocciniglie e le metcalfe. Le prime si combattono con olio bianco attivato da insetticidi possibilmente sistemici. Le seconde si prevengono scegliendo esposizioni ben soleggiate e bagnando spesso la chioma. Getti potenti di acqua possono essere utili a rimuovere anche le uova e le larve, difficilmente raggiungibili da insetticidi dato lo spesso strato ceroso che le circonda. Una fisiopatia comune è la clorosi: è frequente, prevalentemente su piante non innestate, in terreni a pH neutro o alcalino. Si previene distribuendo dalla fine dell'inverno abbondanti dosi di solfato di ferro (che aiuta ad acidificare). Sono sufficienti generalmente due o tre somministrazioni a distanza di 10 giorni. Nei casi più gravi si può ricorrere a del ferro chelato.",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun.png",

                },
                new Alberi
                {
                   NomeComunePianta = "ACERO",
                   NomeFamiglia = "Aceracee",
                   NomeScientificoPianta = " Acer platanoide, A. japonicum",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Acero/ACERO.jpg",

                   DescrizioneBotanica = "A. PLATANOIDES (ACERO PLATANOIDE) HA FOGLIE CHE RICORDANO QUELLE DEL PLATANO (COME ANCHE A. PSEUDOPLATANUS), MENTRE A. JAPONICUM HA FOGLIE PROFONDAMENTE INCISE E DI COLORE ROSSO, COME QUASI TUTTE LE VARIETÀ GIAPPONESI. LE SPECIE ITALIANE (A. CAMPESTRE, A. MONSPESSULANUM, A. NEGUNDO, A. OPULUS) HANNO ALTEZZE VARIABILI DA 10 A 20 M, MENTRE QUELLE GIAPPONESI (A. PALMATUM) SONO IN GENERE DI TAGLIA INFERIORE (COLTIVABILI ANCHE IN VASI GRANDI). LE FOGLIE SONO GENERALMENTE OPPOSTE, SPESSO LOBATE, A VOLTE SONO DENTATE, ALTRE DIVISE IN TANTE FOGLIOLINE. I PICCOLI FIORI MASCHILI E FEMMINILI VARIANO DAL CREMA AL GIALLO, AL VERDE, AL ROSSO, AL VIOLA. SONO TALVOLTA SEPARATI SULLA STESSA PIANTA O SU PIANTE DIVERSE, DI SOLITO SBOCCIANO ALL'APERURA DELLE GIOVANI FOGLIE. I FRUTTI ALATI SONO DIVISI IN DUE META'. CORTECCIA GRIGIO-MARRONE E LISCIA.",
                   Coltivazione = "Le specie Italiane sono resistenti al gelo, possono vivere anche in pieno sole, vogliono un substrato fresco e profondo, leggermente acido, e vanno annaffiate solo nel primo anno dall'impianto. Le specie e varietà giapponesi possono subire danni a –5 °C, soprattutto se allevate in vaso; necessitano di una posizione all'ombra, di un substrato acido e di molta acqua durante l'estate. Desiderano tutte un clima fresco.",
                   Propagazione = "Alla fioritura degli aceri, segue la fruttificazione. I frutti dell'acero sono samare, ovvero delle minuscole noci appiattite, dotate di una sorta di ala laterale, di consistenza papiracea. Le samare si sviluppano appaiate, attaccate noce contro noce, in questo modo le due ali permettono al frutto di spostarsi grazie al vento di molti metri dalla pianta madre e per potersi sviluppare lontano dall'ombra di alberi più alti ed ampi. Il problema principale con la semina degli aceri è dovuto alla spessa cuticola che li riveste, che risulta completamente impermeabile. Per poter quindi seminare gli aceri è fondamentale praticare la stratificazione: si pongono per alcuni mesi i semi (chiusi in una busta di plastica con poca sabbia) in frigorifero; oppure si rimuove parte della cuticola esterna con carta vetrata fine per favorire la penetrazione dell'acqua e stimolare la germinazione dei semi. Le talee di acero si preparano in primavera inoltrata prelevando rametti semilegnosi. Data la scarsa tendenza alla radicazione è consigliabile preparare numerose talee.",
                   Potatura = "Lo sfoltimento della chioma, invece, è un'operazione da compiere in modo regolare per non pregiudicare la salute delle piante. Si tratta di intervenire principalmente sui rami più vecchi, eliminando quelli che impediscono la crescita di quelli più giovani e interni alla chioma, per lasciar loro adeguato spazio e adeguate risorse dal punto di vista dell'aria e della luce. Meglio eliminare anche i rami che si sviluppano direttamente dalla corona dell'acero, per prevenire attacchi fungini e malattie nella pianta. Tutte le operazioni devono essere effettuate avendo cura di non danneggiare il colletto dei rami e compiendo tagli decisi con strumenti sterili: in questo modo le ferite potranno rimarginarsi più semplicemente, senza comportare infezioni.",
                   Malattie = "Gli aceri vengono spesso attaccati da malattie fungine, quali l'oidio o la ruggine. Tali malattie risultano maggiormente dannose se la pianta è giovane, in quanto la perdita di parte del fogliame può compromettere lo sviluppo futuro. In questi casi quindi è bene intervenire tempestivamente, con fungicidi a base di rame o zolfo. Gli esemplari di grandi dimensioni sono meno soggetti a sviluppare malattie e a manifestare alcun sintomo di sofferenza. Spesso i minatori fogliari costituiscono un problema durante le fasi giovanili dell'acero e si consiglia l'utilizzo di un insetticida. Negli esemplari adulti la presenza di insetti sulle foglie porta a una defogliazione anticipata (già a fine estate o inizio autunno). In questi casi è però importante rimuovere il fogliame dal terreno e distruggerlo, in modo che non funga da incubatrice per gli insetti per l'anno successivo.",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun&Cloud.png",

                },
                new Alberi
                {
                   NomeComunePianta = "AGRIFOGLIO",
                   NomeFamiglia = "Agrifogliacee",
                   NomeScientificoPianta = "Ilex aquifolium",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Agrifoglio/AGRIFOGLIO.jpg",

                   DescrizioneBotanica = "I. AQUIFOLIUM È LA SPECIE ITALIANA, CARATTERIZZATA DA CRESCITA LENTA (VOLENDO, SI PUÒ ALLEVARE ANCHE A CESPUGLIO), RAMI INTRICATI E FOGLIE PERENNI, CORIACEE, SPINOSE, COLOR VERDE SCURO O VARIEGATE DI BIANCO O GIALLO. FIORISCE IN MODO INSIGNIFICANTE IN GIUGNO E, DA AGOSTO, SULLE PIANTE FEMMINILI (È UN GENERE DIOICO, A SESSI SEPARATI), SI FORMANO LE BACCHE ROSSE (GIALLE O BIANCHE NELLE VARIETÀ). FRA LE ALTRE SPECIE, I. X ALTACLARENSIS NON È SPINOSO.",
                   Coltivazione = "Tollera il gelo e il caldo intenso, l'inquinamento, ogni tipo di terreno (ma preferisce suoli freschi e profondi, leggermente acidi) e di esposizione (ma al sole si avranno più bacche). Non richiede potature né concimazioni; in estate è bene aiutare le piante giovani con l'irrigazione. Utilizzabile come esemplare arboreo singolo o per siepi difensive, magari mescolando le specie e le varietà diverse per il fogliame. Gli agrifogli non amano venire spostati, travasati, estirpati. A seguito di una di queste operazioni lo stress radicale porta alla defogliazione parziale o totale della chioma, che nel giro di qualche settimana si riforma.",
                   Propagazione = "La moltiplicazione avviene con la semina dei semi freschi, per mezzo di talea semilegnosa, per margotta o per innesto. Le drupe di Ilex aquifolium contengono semi fertili che in natura cadono e rimangono nel terreno umido e freddo fino alla primavera sucessiva, quando germoglieranno. Per la semina si può procedere in due modi: si raccolgono in autunno i frutti, si separano i semi dalla polpa, e si fanno seccare questi ultimi all'aria aperta. Si procede con la semina in contenitore da tenere all'aperto e in luogo freddo e ombreggiato fino alla germinazione. Se si dispone di semi già secchi riporli in frigorifero per qualche giorno per soddisfare il fabbisogno di freddo (altrimenti germineranno dopo qualche anno).  In ogni caso, anche i semi freschi, non germineranno all'arrivo della primavera, ma impiegheranno qualche mese in più. Spesso, per evitare di riprodurre degli esemplari maschili, si preferisce propagare l'agrifoglio per talea, prelevandola da un esemplare femminile, saremo così sicuri che a maturità la nostra futura pianta produrrà le tipiche bacche rosse. Le talee si prelevano in primavera inoltrata o a fine estate, tagliando gli apici e i rami che non hanno fiori. Le talee vanno private delle foglie basali e immerse nell'ormone radicante e sucessivamente nel terreno. Il vassoio di taleaggio va riposto in luogo fresco e ombreggiato, e va annaffiato regolarmente, evitando che il terreno asciughi completamente.",
                   Potatura = "La potatura dell'agrifoglio non è assolutamente necessaria . Questo arbusto, infatti, cresce molto lentamente . Servono soltanto sparuti interventi mirati a salvaguardare la simmetria dell'intera pianta. La potatura deve essere effettuata due volte all'anno. La prima deve avvenire all'inizio dell'estate, quindi verso giugno, mentre la seconda deve essere effettuata alla fine della stessa stagione, verso agosto.",
                   Malattie = "L'agrifoglio è una pianta abbastanza resistente anche se alcuni tipi di fungo possono creare margiumi radicali (in presenza di terreni pesanti), e gli insetti minatori rovinare le foglie.",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sempreverde.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun&Cloud.png",

                },

                new Alberi
                {
                   NomeComunePianta = "AILANTO",
                   NomeFamiglia = "Simarubacee",
                   NomeScientificoPianta = "Ailanthus altissima",
                   FotoPianta = "ms-appx:///Immagini/ALBERI//Ailanto/AILANTO.jpg",

                   DescrizioneBotanica = "ALBERO ASIATICO PERFETTAMENTE ACCLIMATATO IN TUTTA ITALIA. CARATTERIZZATO DA CRESCITA RAPIDISSIMA E ROBUSTE RADICI POLLONIFERE, PUÒ ESSERE INDICATO PER CONSOLIDARE SCARPATE O DOVE SERVA MOLTA OMBRA IN POCHI ANNI. RAGGIUNGE I 25 M D'ALTEZZA E I 12 M DI DIAMETRO DELLA CHIOMA, DECIDUA. TENDE TUTTAVIA A DIVENIRE INFESTANTE, PER LA CAPACITÀ POLLONANTE, ANCHE A GRANDE DISTANZA, DAL TRONCO E PER L'ENORME NUMERO DI SEMI (FINO A  300000), MOLTO VITALI, CHE PRODUCE FIN DA GIOVANE. I SEMI VENGONO RILASCIATI TUTTI NELLO STESSO PERIODO: LA DISSEMINAZIONE AVVIENE A SCAGLIONI A PARTIRE DA NOVEMBRE FINO A MAGGIO.",
                   Coltivazione = "Robusto e rustico, tollera ogni genere di avversità senza veder compromesso il suo vigore: gelo, neve, caldo torrido, solleone, inquinamento urbano ed extraurbano, potature drastiche e capitozzature ecc. Si adatta a ogni tipo di suolo ed esposizione, resiste senz'acqua ﬁn da giovane e cresce perﬁno tra le fessure dell'asfalto, che in seguito verrà sollevato dalle radici in esplorazione. Attenzione quindi nel decidere di allevarlo! Le foglie, i fiori e la corteccia emanano un odore sgradevole; in taluni casi sembra che gli ailanthus secernano una tossina che impedisce l'attecchimento di altri alberi nelle vicinanze.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun&Cloud.png",

                },

                new Alberi
                {
                   NomeComunePianta = "ALBERO DI GIUDA",
                   NomeFamiglia = "Leguminose",
                   NomeScientificoPianta = "Cercis siliquastrum",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Albero di Giuda/ALBERO DI GIUDA.jpg",

                   DescrizioneBotanica = "PICCOLO ALBERO (ALTEZZA MASSIMA 12 M, DIAMETRO 5 M) DECIDUO, INDICATO PER PICCOLI GIARDINI. SUI RAMI DALLA CORTECCIA LISCIA E SCURA VENGONO PRODOTTI IN APRILE, PRIMA I FIORI, DI COLORE ROSA, ABBONDANTISSIMI, E POI LE FOGLIE, TONDEGGIANTI, CONSISTENTI E DI COLORE VERDE BRILLANTE. DALL'ESTATE E PER TUTTO L'AUTUNNO PERMANGONO I FRUTTI, BACCELLI APPIATTITI E BRUNI. PUÒ ESSERE ALLEVATO ANCHE A CESPUGLIO, SE NON SI ELIMINANO I POLLONI BASALI.",
                   Coltivazione = "Non teme il freddo della Val Padana, né il caldo torrido del Meridione. Sopporta l'inquinamento urbano e resiste alla siccità (con l'eccezione dell'anno seguente all'impianto) e alla mancanza di concime (come tutte le leguminose, ricava l'azoto direttamente attraverso le radici). Preferisce il pieno sole (per una migliore ﬁoritura). Non ha esigenze in materia di terreno. Tollera le potature, ma solo se indispensabili.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun.png",
                },

                new Alberi
                {
                   NomeComunePianta = "ALBIZZIA",
                   NomeFamiglia = "Leguminose",
                   NomeScientificoPianta = "Albizzia julibrissin",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Albizzia/ALBIZZIA.jpg",

                   DescrizioneBotanica = "DETTA ANCHE GAGGIA O ACACIA DI COSTANTINOPOLI (MA È DI ORIGINE AUSTRALIANA), È UN ELEGANTE ALBERELLO (ALTEZZA MASSIMA 12 M, DIAMETRO MASSIMO 10 M) DALLA TIPICA FORMA A OMBRELLO, CARATTERIZZATO DA UN FOGLIAME DECIDUO LEGGERISSIMO, COSTITUITO DA FOGLIE COMPOSTE DA MINUTE FOGLIOLINE. IN GIUGNO-LUGLIO PRODUCE I FIORI, CARATTERIZZATI DA VISTOSI STAMI ROSA, SIMILI A PIUMINI, RIUNITI IN CORIMBI MOLTO APPARISCENTI. INDICATO PER GIARDINI PICCOLI O MEDI.",
                   Coltivazione = "Resiste al freddo della Val Padana e al caldo delle coste meridionali; è insensibile all'inquinamento urbano. Richiede un'esposizione soleggiata (per fiorire in abbondanza) ma riparata dai venti freddi. Non ha preferenze in fatto di terreno (ma stenta a crescere in substrati acidi). Necessita di annaffiature solo nei primi anni di vita, durante l'estate. Non servono concimazioni perché ricava l'azoto atmosferico attraverso le radici.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun.png",
                },

                new Alberi
                {
                   NomeComunePianta = "BAGOLARO",
                   NomeFamiglia = "Ulmacee",
                   NomeScientificoPianta = "Celtis australis",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Bagolaro/BAGOLARO.jpg",

                   DescrizioneBotanica = "MAESTOSO E SLANCIATO ALBERO DALLE DIMENSIONI IMPONENTI (FINO A 25 M D'ALTEZZA E 15 M DI DIAMETRO), MOLTO UTILIZZATO PER ALBERATURE STRADALI CHE CONFERISCONO UN'OMBRA FITTA, GRAZIE AL FOGLIAME DENSO (DECIDUO), DATO DA FOGLIE LANCEOLATE, DENTATE, VERDE SCURO. ALLA FIORITURA (INFIORESCENZE ASCELLARI BIANCASTRE INSIGNIFICANTI), IN APRILE-MAGGIO, SEGUE IN ESTATE LA PRODUZIONE DI DRUPE VERDI E POI SCURE QUANDO MATURE, COMMESTIBILI, APPETITE DAGLI UCCELLI. CHIAMATO ANCHE SPACCASASSI PER IL ROBUSTO APPARATO RADICALE.",
                   Coltivazione = "Non teme né il gelo né la calura. Predilige terreni sassosi, poveri, compatti, comunque ben drenati. L'esposizione in pieno sole è la più indicata: all'ombra tende ad allungarsi ancora di più. Si annaffia solo dopo l'impianto; non necessita di particolari concimazioni. Attenzione alla presenza di manufatti o edifici: le sue radici, molto estese e vigorose, sono in grado di sollevare il calcestruzzo e l'asfalto.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun.png",
                },

                new Alberi
                {
                   NomeComunePianta = "BETULLA",
                   NomeFamiglia = "Betulacee",
                   NomeScientificoPianta = "Betula pendula",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Betulla/BETULLA.jpg",

                   DescrizioneBotanica = "ELEGANTE E LEGGERO ALBERO DALLA CORTECCIA BIANCA E LISCIA, SCREZIATA DI SCURO. RAGGIUNGE I 25 M D'ALTEZZA, PER UN DIAMETRO DI 15 M. LE FOGLIE A FORMA DI CUORE SONO LUCIDE E COLOR VERDE BRILLANTE. B. PENDULA È LA BETULLA BIANCA (O PENDULA O D'ARGENTO). B. PUBESCENS, MENO DIFFUSA, È LA BETULLA PELOSA (O DELLE TORBIERE). RICHIEDE MOLTO SPAZIO E OFFRE UNA SPLENDIDA SCENOGRAFIA SE SI PRESENTA IN GRUPPI DI 3-4 ESEMPLARI, A POCA DISTANZA UNO DALL'ALTRO.",
                   Coltivazione = "Albero tipico del Nord Europa, desidera climi freschi (resiste ﬁno a –25 °C), anche ventosi, ed è inadatto alle coste. Necessita di terreno acido, anche povero o sassoso (con le robuste radici è in grado di consolidare pendii e scarpate o suoli bruciati da incendi), meglio se leggermente umido, ma con un discreto drenaggio. Solo nei primi anni dall'impianto occorre annaffiare durante i periodi più caldi dell'estate. Possono sopportare brevi periodi di caldo e lunghi periodi di siccità.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun&Cloud.png",
                },

                new Alberi
                {
                   NomeComunePianta = "CARPINO BIANCO",
                   NomeFamiglia = "Betulacee",
                   NomeScientificoPianta = "Carpinus betulus",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Carpino Bianco/CARPINO BIANCO.jpg",

                   DescrizioneBotanica = "ALBERO DI MEDIA ALTEZZA (20 M, DIAMETRO 12 M) DAL PORTAMENTO ERETTO. PRESENTA CORTECCIA LISCIA E GRIGIA. HA FOGLIE OVATE, APPUNTITE E SEGHETTATE, CADUCHE IN INVERNO (MA IL DISTACCO PUÒ AVVENIRE IN PRIMAVERA, ALL'EMISSIONE DELLE NUOVE FOGLIE: PER QUESTO MOTIVO LA VARIETÀ PYRAMIDALIS SI UTILIZZA PER SIEPI FRANGIVISTA CHE NON SI SPOGLINO IN INVERNO). LE FOGLIE SONO VERDE SCURO SULLA PAGINA SUPERIORE E PIU' CHIARE SU QUELLA INFERIORE; IN AUTUNNO SI COLORANO DI UN APPARISCENTE ROSSO SCURO-ARANCIATO, PRIMA DI CADERE. I FIORI FEMMINILI E QUELLI MASCHILI CRESCONO SEPARATI, MA SULLA STESSA PIANTA. QUELLI MASCHILI SONO AMENTI ALLUNGATI E PENDULI DI COLORE GIALLASTRO; QUELLI FEMMINILI SONO DAPPRIMA ERETTI, POI SI ALLUNGANO A DIVENTARE PENDULI, DI COLORE BIANCO PANNA. PRODUCE FRUTTI AEREI (SAMARE) COSTITUITI DA UN SEME CENTRALE E DA UNA MEMBRANA TRILOBATA, FACILMENTE TRASPORTATA DAL VENTO.",
                   Coltivazione = "Resiste bene al freddo intenso e al caldo torrido, come pure ai venti freddi o salmastri. Preferisce un'esposizione aperta e soleggiata, ma vive bene anche a mezz'ombra o all'ombra. Desidera suoli freschi e profondi, fertili, leggermente umidi ma ben drenati; in realtà si adatta però a ogni tipo di terreno. Va annaffiato nei primissimi anni dopo l'impianto.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun.png",
                },

                new Alberi
                {
                   NomeComunePianta = "CATALPA",
                   NomeFamiglia = "Bignoniacee",
                   NomeScientificoPianta = "Catalpa bignonioides",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Catalpa/CATALPA.jpg",

                   DescrizioneBotanica = "CHIAMATA ANCHE ALBERO DEI SIGARI (PER LA FORMA ALLUNGATA DEI FRUTTI), RAGGIUNGE I 15 M DI ALTEZZA E 8 M DI DIAMETRO. HA FOGLIE DECIDUE, GRANDI, OVATO-ARROTONDATE E LOBATE. IN GIUGNO PRODUCE GRANDI FIORI A IMBUTO, CANDIDI, RIUNITI IN PANNOCCHIE PIRAMIDALI DI 15-20 CM DI LUNGHEZZA. NE DERIVANO LUNGHI BACCELLI PENDULI, CHE PERMANGONO SULLA PIANTA SINO ALLA PRIMAVERA. È INDICATA PER GIARDINI DI MEDIE DIMENSIONI O COME PUNTO FOCALE IN SPAZI PIÙ AMPI.",
                   Coltivazione = "Resiste al freddo della Val Padana e delle Prealpi e al caldo delle coste meridionali. Ama terreni profondi, fertili e molto ben drenati. L'esposizione deve essere soleggiata, per favorire una ricca fioritura, ma vive anche a mezz'ombra o in ombra. Va annaffiata solo nei primi anni dall'impianto. Per una migliore produzione di corolle, è bene somministrare un po' di concime organico in autunno.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun.png",
                },

                new Alberi
                {
                   NomeComunePianta = "CEDRO",
                   NomeFamiglia = "Pinacee",
                   NomeScientificoPianta = "Cedrus libani, C. atlanticus, C. deodara",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Cedro/CEDRO.jpg",

                   DescrizioneBotanica = "GRANDI AGHIFOGLIE SEMPREVERDI MOLTO UTILIZZATE IN PARCHI E GIARDINI, DOVE PERÒ HANNO BISOGNO DI MOLTO SPAZIO, ARRIVANDO A 30-40 M D’ALTEZZA E 20-30 M DI DIAMETRO (TENDONO PERÒ, PROGRESSIVAMENTE, A SPOGLIARSI ALLA BASE, TRANNE C. DEODARA). GLI ESEMPLARI GIOVANI HANNO CHIOMA PIRAMIDALE CHE POI TENDE AD ALLARGARSI. NE ESISTONO VARIETÀ AD AGHI GLAUCHI. IN PRIMAVERA PRODUCONO GROSSE PIGNE ERETTE; IN AUTUNNO I CONI MASCHILI RILASCIANO IL POLLINE.",
                   Coltivazione = "Non temono il gelo intenso, né i venti freddi e incessanti. Preferiscono un terreno fresco, profondo, leggero, povero, leggermente acido, ma crescono senza problemi anche su altri tipi di substrati, persino calcarei o argillosi. Non necessitano di annaffiature, se non appena dopo l’impianto. Anche la concimazione non è indispensabile. Nei primi anni è bene eliminare i rametti più esili nella parte bassa del tronco.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sempreverde.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun.png",
                },

                new Alberi
                {
                   NomeComunePianta = "CIPRESSO",
                   NomeFamiglia = "Cipressacee",
                   NomeScientificoPianta = "Cupressus sempervirens, C. leylandii",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Cipresso/CIPRESSO.jpg",

                   DescrizioneBotanica = "C. SEMPERVIRENS, ALTO FINO A 15 M, IN GENERE A PORTAMENTO COLONNARE, È UN ALBERO DALLA CHIOMA COMPATTA, DI COLORE VERDE BRILLANTE, DATA DA FOGLIE PICCOLE, OPPOSTE, SQUAMIFORMI, DAL CARATTERISTICO ODORE; I FRUTTI (CHIAMATI GALBULI) SONO TONDEGGIANTI, PRIMA VERDI E POI SCURI. C. LEYLANDII (O CUPRESSOCYPARIS L.), ALTO FINO A 25 M, HA PORTAMENTO ESPANSO E FOGLIE SQUAMOSE DI COLORE VERDE-BLUASTRO (MA ANCHE GIALLE IN ALCUNE VARIETÀ FLORICOLE).",
                   Coltivazione = "Non temono il freddo (C. leylandii è ancora più resistente), ma il vento e la neve possono danneggiarne le chiome sempreverdi, così come un eccessivo inquinamento urbano. Non è esigente in fatto di terreno, basta che sia ben drenato. Una posizione soleggiata ne favorisce la crescita. Le annaffiature sono gradite nei primi anni dall’impianto. Una concimazione autunnale è apprezzata, ma non indispensabile.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sempreverde.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun.png",
                },

                new Alberi
                {
                   NomeComunePianta = "DAVIDIA",
                   NomeFamiglia = "Nissacee",
                   NomeScientificoPianta = "Davidia involucrata",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Davidia/DAVIDIA.jpg",

                   DescrizioneBotanica = "CHIAMATO ANCHE ALBERO DEI FAZZOLETTI, PERCHÉ, DURANTE LA FIORITURA, LE VISTOSE BRATTEE BIANCHE CHE PROTEGGONO LE STRUTTURE FIORALI SOMIGLIANO A FAZZOLETTI APPESI AI RAMI. ALTO FINO A 18 M, HA UNA CHIOMA ARROTONDATA DI FOGLIE CUORIFORMI. DOPO I 10 ANNI D’ETÀ, IN MAGGIO, SI SVILUPPANO I FIORI, VERDASTRI E INSIGNIFICANTI, AVVOLTI DALLE BRATTEE BIANCHE PENDULE. PIANTA DA VALORIZZARE CON UNA POSIZIONE ISOLATA IN UN PUNTO FOCALE DEL GIARDINO.",
                   Coltivazione = "Gli esemplari adulti tollerano il gelo anche intenso e prolungato; quelli giovani vanno protetti con un telo durante l’inverno. È una pianta che preferisce una posizione a mezz’ombra: in pieno sole necessita di annaﬃature regolari, che in ombra non sono necessarie, se non nelle estati più calde e asciutte. Desidera terreni freschi, profondi, ricchi e ben drenati. Va concimata in primavera con un prodotto organico.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun&Cloud.png",
                },

                new Alberi
                {
                   NomeComunePianta = "EUCALIPTO",
                   NomeFamiglia = "Mirtacee",
                   NomeScientificoPianta = "Eucalyptus globulus",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Eucalipto/Eucalipto.jpg",

                   DescrizioneBotanica = "ALBERO SEMPREVERDE A CRESCITA MOLTO RAPIDA, MA NON MOLTO LONGEVO. RAGGIUNGE I 20 M D’ALTEZZA IN GIARDINO, PER 8 M DI DIAMETRO. HA UNA CARATTERISTICA CORTECCIA GRIGIA SQUAMATA IN ROSSO. LE FOGLIE SONO LANCEOLATE, STRETTE, APPUNTITE, COLOR VERDE-AZZURRO. IN ESTATE PRODUCE PICCOLI FIORI A POMPON, DI COLORE VERDASTRO, SEGUITI DA PICCOLI FRUTTI TONDEGGIANTI. PUÒ ESSERE ALLEVATO ANCHE A CESPUGLIO, SE VIENE CIMATO CONTINUAMENTE NELLE FASI GIOVANILI.",
                   Coltivazione = "Tollera temperature fino a +5 °C, resiste al vento salmastro ed è quindi indicato per località balneari a clima mite. Preferisce un’esposizione soleggiata o a mezz’ombra. Prospera su terreni freschi e profondi, leggermente umidi, anche non ben drenati, ma resiste persino su terreni poveri e aridi: le lunghe radici si spingono a cercare acqua in profondità (non va quindi posto in vicinanza di edifici e tubature idriche).",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sempreverde.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun&Cloud.png",
                },

                new Alberi
                {
                   NomeComunePianta = "FAGGIO",
                   NomeFamiglia = "Fagacee",
                   NomeScientificoPianta = "Fagus sylvatica",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Faggio/FAGGIO.jpg",

                   DescrizioneBotanica = "MAESTOSO E IMPONENTE ALBERO A CRESCITA LENTA (MA MOLTO LONGEVO) CHE PUÒ RAGGIUNGERE I 30 M D’ALTEZZA E 25 DI DIAMETRO. LA CHIOMA HA FORMA ARROTONDATA ED È FORMATA DA PICCOLE FOGLIE OVALI, LUCIDE, ONDULATE, CHE IN AUTUNNO, PRIMA DI CADERE, DIVENGONO ARANCIATE. DAI FIORI, INSIGNIFICANTI, SI SVILUPPANO IN ESTATE I FRUTTI, CHIAMATI FAGGIOLE, SIMILI A PICCOLE GHIANDE. LA VARIETÀ PURPUREA HA FOGLIE ARROSSATE, LA PENDULA RAMI RICADENTI.",
                   Coltivazione = "Resiste al gelo intenso, meno al caldo torrido. Desidera un suolo fresco, profondo, ricco di sostanza organica, ben drenato. Predilige un’esposizione soleggiata, ma si trova bene anche a mezz’ombra. Necessita di acqua nei primi anni dopo l’impianto. Una concimazione con letame in autunno, nei primi anni, è più che sufficiente. Necessita di ampi spazi, in considerazione del volume che occupa da adulto.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun.png",
                },

                new Alberi
                {
                   NomeComunePianta = "FRASSINO",
                   NomeFamiglia = "Oleacee",
                   NomeScientificoPianta = "Fraxinus excelsior, F. ornus",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Frassino/FRASSINO.jpg",

                   DescrizioneBotanica = "F. EXCELSIOR, O FRASSINO COMUNE, È UN ALBERO DELL’ALTEZZA DI 25 M CON GRANDI FOGLIE COMPOSTE E FIORITURA INSIGNIFICANTE; NECESSITA DI UN AMPIO SPAZIO DI COLTIVAZIONE. F. ORNUS, O ORNIELLO O ALBERO DELLA MANNA, RAGGIUNGE I 20 M D’ALTEZZA, PORTA FOGLIE COMPOSTE DA NUMEROSE FOGLIOLINE E FIORISCE IN GIUGNO, IN PANNOCCHIE VISTOSE DI MINUTI FIORI BIANCHI PROFUMATISSIMI; PUÒ FUNGERE DA PUNTO FOCALE (SPOGLIANTE) IN UNA POSIZIONE PARTICOLARE DEL GIARDINO.",
                   Coltivazione = "Resistono al freddo intenso (meglio il frassino dell’orniello) e al caldo del Meridione; sono indifferenti ai venti freddi o salmastri. Preferiscono posizioni in pieno sole, ma anche la mezz’ombra è adatta. Necessitano di un terreno ricco, ben drenato e molto profondo (l’apparato radicale scende nelle viscere del suolo); non tollerano substrati asciutti e sassosi. Vanno irrigati nei primi anni dopo l’impianto, durante l’estate",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun.png",
                },

                new Alberi
                {
                   NomeComunePianta = "GINKGO BILOBA",
                   NomeFamiglia = "Ginkgoacee",
                   NomeScientificoPianta = "Ginkgo biloba",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Ginkgo Biloba/GINKGO BILOBA.jpg",

                   DescrizioneBotanica = "DEFINITO ANCHE COME FOSSILE VIVENTE PERCHÉ È L’UNICO ALBERO SOPRAVVISSUTO DELL’ERA GIURASSICA. PUÒ RAGGIUNGERE I 30-40 M D’ALTEZZA ED È CARATTERIZZATO DA RAMI DIRITTI, ORNATI DA PARTICOLARI FOGLIE A VENTAGLIO, COLOR VERDE TENERO, CHE SI TINGONO D’ORO PRIMA DI CADERE, IN AUTUNNO. È UNA SPECIE DIOICA (ESISTONO PIANTE FEMMINILI E ALBERI MASCHILI): ATTENZIONE AI GINKGO FEMMINA CHE RILASCIANO, D’AUTUNNO, FRUTTI SIMILI A CILIEGIE, MA DALL’ODORE NAUSEABONDO.",
                   Coltivazione = "Resiste al gelo (fino a –35 °C) e ai venti freddi, all’inquinamento urbano e alla siccità (va però annaffiato bene nei primi anni dopo l’impianto). Lento nella crescita, viene aiutato da concimazioni azotate in primavera ed estate. Preferisce esposizioni soleggiate o a mezz’ombra. Gradisce terreni acidi e non pesanti, ma si adatta anche a situazioni non ottimali. Non va potato: i rami tagliati tendono a seccarsi.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun&Cloud.png",
                },

                new Alberi
                {
                   NomeComunePianta = "IPPOCASTANO",
                   NomeFamiglia = "Sapindacee",
                   NomeScientificoPianta = "Aesculus hippocastanum",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Ippocastano/IPPOCASTANO.jpg",

                   DescrizioneBotanica = "IMPONENTE ALBERO (FINO A 25 M D’ALTEZZA E 10 DI DIAMETRO) MOLTO UTILIZZATO NELLE ALBERATURE STRADALI, NONOSTANTE LA SCARSA RESISTENZA ALL’INQUINAMENTO. DAL TRONCO A CORTECCIA SCURA SI DIPARTONO RAMI CHE PORTANO FOGLIE DECIDUE, MOLTO GRANDI, PALMATE, COMPOSTE DA 5-7 FOGLIOLINE OVATO-LANCEOLATE. IN APRILE-MAGGIO PRODUCE VISTOSE INFIORESCENZE A PANNOCCHIA ERETTA, DATE DA FIORI BIANCHI CON CENTRO ROSSO. A. X CARNEA HA FIORI ROSA E SVILUPPO INFERIORE.",
                   Coltivazione = "Resiste bene al freddo (ma non al gelo intenso e prolungato), meno al caldo e al vento forte. Non è indicato per zone marittime. Preferisce suoli fertili, freschi, profondi, ben drenati. Predilige un’esposizione soleggiata o a mezz’ombra. Necessita di annaffiature nei primi anni dopo l’impianto. Gradisce una concimazione con fertilizzanti organici in autunno e in primavera. Da valutare lo spazio occupato dalla pianta adulta.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun.png",
                },

                new Alberi
                {
                   NomeComunePianta = "LAGERSTROEMIA",
                   NomeFamiglia = "Litracee",
                   NomeScientificoPianta = "Lagerstroemia indica",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Lagerstroemia/LAGERSTROEMIA.jpg",

                   DescrizioneBotanica = "PICCOLO ALBERO (ALTEZZA MASSIMA 2,5 M) CHE SI PUÒ ALLEVARE ANCHE A CESPUGLIO, GRAZIE AI NUMEROSI POLLONI BASALI. IDEALE PER PICCOLI GIARDINI E VIALETTI. CARATTERIZZATO DA UNA CORTECCIA LISCIA, LUCIDA, SQUAMATA IN STRISCE GRIGIE E DA RAMI CONTORTI, MOLTO DECORATIVI IN INVERNO. HA FOGLIE PICCOLE, OVALI ARROTONDATE, CHE SI TINGONO DI ROSSO PRIMA DI CADERE, IN AUTUNNO. DA GIUGNO A SETTEMBRE PRODUCE GRANDI PANNOCCHIE ERETTE DI FIORI BIANCHI, ROSA, ROSSI O VIOLA.",
                   Coltivazione = "Resiste al freddo della Val Padana, al caldo delle zone costiere, ai venti freddi e a quelli salsi, come pure all’inquinamento urbano. Necessita di un’esposizione soleggiata per fiorire bene. Non è esigente in fatto di terreno, anche se preferisce quelli fertili, argillosi, calcarei, ben drenati. Deve essere irrigata subito dopo l’impianto. Va concimata con prodotti organici, in autunno e primavera. Si pota per riordinarla.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun.png",
                },

                new Alberi
                {
                   NomeComunePianta = "LIQUIDAMBAR",
                   NomeFamiglia = "Hamamelidacee",
                   NomeScientificoPianta = "Liquidambar styraciflua",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Liquidambar/LIQUIDAMBAR.jpg",

                   DescrizioneBotanica = "ELEGANTE ALBERO DI 30 M D’ALTEZZA, DOTATO DI FOGLIE GRANDI, A FORMA DI STELLA, DI COLORE VERDE BRILLANTE, CHE PRIMA DI CADERE, IN AUTUNNO, ASSUMONO COLORI AFFASCINANTI (SOPRATTUTTO NELLE VARIETÀ FLORICOLE), COME IL PORPORA E L’ARANCIO. DAI FIORI PRIMAVERILI POCO APPARISCENTI SI SVILUPPANO IN ESTATE FRUTTI TONDEGGIANTI, MOLTO SPINOSI, CON DIAMETRO DI 3-4 CM. DATE LE DIMENSIONI, È NECESSARIO PREVEDERE UNO SPAZIO ADEGUATO: È INDICATO PER GRANDI GIARDINI",
                   Coltivazione = "Resistente al freddo intenso e all’inquinamento. Ama il sole o tutt’al più la mezz’ombra. Il substrato preferito è umido, fertile, sciolto, ben drenato, molto profondo (le radici scendono a esplorare il suolo), leggermente acido, ma si adatta, in realtà, a qualunque tipo di terreno. Va annaffiato con regolarità nei periodi più secchi e caldi dell’anno, anche da adulto. Per favorire la crescita, va concimato con azoto in primavera.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun.png",
                },

                new Alberi
                {
                   NomeComunePianta = "LIRIODENDRO",
                   NomeFamiglia = "Magnoliacee",
                   NomeScientificoPianta = "Liriodendron tulipifera",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Liriodendro/LIRIODENDRO.jpg",

                   DescrizioneBotanica = "CHIAMATO ANCHE ALBERO DEI TULIPANI, PER VIA DELLA CURIOSA FORMA DEI FIORI, CHE COMPAIONO IN GIUGNO E SOMIGLIANO A QUELLI DEI TULIPANI, IN UN COLOR VERDE GIALLASTRO CON CENTRO ARANCIONE, DA CUI DERIVANO GROSSI FRUTTI A FORMA DI PIGNA. RAGGIUNGE I 20-25 M D’ALTEZZA. HA FOGLIE GRANDI, QUADRILOBATE, VERDE INTENSO CHE DIVIENE GIALLO VIVO IN AUTUNNO, PRIMA DI CADERE. NECESSITA DI UNO SPAZIO AMPIO PER PROSPERARE E FIORIRE: INDICATO PER GRANDI GIARDINI.",
                   Coltivazione = "Resiste all’inquinamento urbano e al gelo, ma non al caldo torrido delle coste meridionali. Va posizionato in pieno sole nelle località più fredde, a mezz’ombra in quelle più miti. Predilige terreni umidi, freschi, profondi e con pH acido. Va annaffiato anche da adulto, dalla primavera all’autunno, e soprattutto se l’estate è calda e secca. Necessita di concime organico in autunno e primavera, per favorire la fioritura.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun&Cloud.png",
                },

                new Alberi
                {
                   NomeComunePianta = "MAGNOLIA",
                   NomeFamiglia = "Magnoliacee",
                   NomeScientificoPianta = "Magnolia grandiflora, M. japonica",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Magnolia/MAGNOLIA.jpg",

                   DescrizioneBotanica = "M. GRANDIFLORA È UN SEMPREVERDE CHE PUÒ RAGGIUNGERE I 12 M D’ALTEZZA E I 4 M DI DIAMETRO. PRESENTA GRANDI FOGLIE LANCEOLATE, CORIACEE, VERDE LUCIDO SULLA PAGINA SUPERIORE E PELOSE IN QUELLA INFERIORE. IN GIUGNO PRODUCE GRANDI FIORI A COPPA DI COLORE BIANCO, DA CUI DERIVANO FRUTTI A FORMA DI PIGNA CON SEMI ROSSI. M. JAPONICA, DECIDUA, NON SUPERA I 10 M D’ALTEZZA ED EMETTE SUI RAMI NUDI, IN MARZO, GRANDI FIORI A COPPA BIANCHI O VIOLA, SEGUITI DALLE FOGLIE.",
                   Coltivazione = "Resistono al freddo e al caldo della Val Padana, ma le gelate tardive possono danneggiare i bocci di M. japonica. Desiderano terreni freschi, profondi e ben drenati, con pH leggermente acido. Necessitano di un’esposizione soleggiata o tutt’al più a mezz’ombra. Vanno annaffiate nei primi anni dopo l’impianto. Si concimano in autunno e primavera, con un fertilizzante organico. Hanno crescita lenta e non amano le potature.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sempreverde.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun.png",
                },

                new Alberi
                {
                   NomeComunePianta = "MELO DA FIORE",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Malus",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Melo da Fiore/MELO DA FIORE.jpg",

                   DescrizioneBotanica = "PICCOLI ALBERI (MASSIMO 3 M D’ALTEZZA) DALLA CORTECCIA GRIGIA E DAI NUMEROSI RAMI COPERTI DI FOGLIE OVATE, VERDE LUCIDO. IN APRILE-MAGGIO SI COPRONO DI FIORI BIANCHI O ROSATI, ANCHE DOPPI A SECONDA DELLE VARIETÀ, CHE DA AGOSTO SI TRASFORMANO IN PICCOLI POMI GIALLI O ROSSI, NON COMMESTIBILI (PER LA DUREZZA DELLA POLPA) MA MOLTO DECORATIVI. SONO INDICATI PER PICCOLI GIARDINI E PER CHI AMA IL BIRDWATCHING (OSSERVAZIONE DEGLI UCCELLINI CHE SI CIBANO DEI FRUTTI).",
                   Coltivazione = "Non temono né il gelo né il caldo. Preferiscono suoli fertili e ben drenati, non pesanti. L’esposizione deve assolutamente essere soleggiata, per ottenere la fioritura e poi la fruttificazione. Necessitano di acqua nei primi mesi dopo l’impianto e nelle estati particolarmente calde e asciutte. Si concimano in autunno e in primavera. Si possono allevare anche in vaso, purché abbastanza grande (da 35 cm di diametro in su).",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun.png",
                },

                new Alberi
                {
                   NomeComunePianta = "OLMO",
                   NomeFamiglia = "Ulmacee",
                   NomeScientificoPianta = "Ulmus campestris",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Olmo/OLMO.jpg",

                   DescrizioneBotanica = "GRANDE ALBERO (FINO A 30 M D’ALTEZZA) DECIDUO, INDICATO PER GIARDINI MOLTO GRANDI, COME PUNTO D’ATTRAZIONE. HA FOGLIE PICCOLE, OVATE, ASIMMETRICHE. LA FIORITURA, INSIGNIFICANTE, AVVIENE IN MARZO. SEGUE SUBITO LA PRODUZIONE DEI FRUTTI, DATI DA UN SEME CENTRALE AVVOLTO IN UN DISCO CARTACEO GIALLASTRO (SAMARA), CHE VIENE TRASPORTATO DAL VENTO (IN QUESTA FASE LE SAMARE CHE VOLANO SONO MIGLIAIA E INVADONO ANCHE I MANUFATTI E GLI AMBIENTI DOMESTICI).",
                   Coltivazione = "Resiste alle gelate, all’inquinamento, alla salinità dell’aria e al vento. Desidera posizioni semi-ombreggiate o di pieno sole, rifuggendo dall’ombra. Predilige suoli profondi, freschi o mediamente ricchi di acqua, ma si adatta anche a situazioni meno favorevoli, quali i terreni siccitosi. Indifferente al substrato, è coltivabile nei terreni di natura silicea, calcarea, compatta e anche argillosa. Va annaffiato nei primi anni di vita.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun&Cloud.png",
                },

                new Alberi
                {
                   NomeComunePianta = "ONTANO",
                   NomeFamiglia = "Betulacee",
                   NomeScientificoPianta = "Alnus glutinosa",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Ontano/ONTANO.jpg",

                   DescrizioneBotanica = "ALBERO DI MEDIE DIMENSIONI (20-25 M D’ALTEZZA), CHIAMATO ONTANO NERO, È CARATTERIZZATO DA FOGLIE TONDEGGIANTI, DI COLORE VERDE SCURO LUCIDO. ALL’INIZIO DELLA PRIMAVERA, PRIMA DELLE FOGLIE, PRODUCE INFIORESCENZE (AMENTI) MASCHILI E FEMMINILI, CHE IN TARDA ESTATE SI TRASFORMANO IN FRUTTI, FALSE PIGNE LEGNOSE DI COLORE VERDE CHIARO CHE POSSONO RIMANERE PER ANNI SUI RAMI. A. INCANA (ONTANO BIANCO) HA DELLE CARATTERISTICHE FOGLIE PELOSE SULLA PAGINA INFERIORE.",
                   Coltivazione = "Non teme il freddo, né il caldo. Ha una crescita veloce ma una vita non molto lunga (50 anni al massimo). Preferisce posizioni soleggiate e terreni sassosi, poveri e intrisi d’acqua (non tollera i suoli acidi o secchi). Necessita di annaffiature per tutta la vita, se il substrato non trattiene l’acqua utile alla pianta. Non abbisogna di concime: le radici ricavano l’azoto direttamente dall’aria (come le leguminose).",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun.png",
                },

                new Alberi
                {
                   NomeComunePianta = "PAULONIA",
                   NomeFamiglia = "Scrofulariacee",
                   NomeScientificoPianta = "Paulownia tomentosa",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Paulonia/PAULONIA.jpg",

                   DescrizioneBotanica = "GRAZIOSO ALBERO (MASSIMO 15 M D’ALTEZZA) FITTAMENTE RAMIFICATO, DALLE ENORMI FOGLIE CUORIFORMI PELOSE. IN APRILE-MAGGIO PRODUCE SUI RAMI NUDI GRANDI (FINO A 15 CM DI LUNGHEZZA) GRAPPOLI DI FIORI VIOLA A TROMBA, DAI QUALI DERIVANO IN ESTATE I FRUTTI, GROSSI BACCELLI LEGNOSI, CHE CONTENGONO PICCOLI SEMI. HA UNA CRESCITA VIGOROSA E NECESSITA DI AMPIO SPAZIO, PENSANDO ALLE DIMENSIONI DEFINITIVE DELLA PIANTA. VIENE ANCHE COLTIVATA PER RICAVARNE IL LEGNO.",
                   Coltivazione = "Tollera il freddo e il caldo, l’inquinamento urbano e le situazioni più infelici, a eccezione dei luoghi ventosi, dove le grandi foglie morbide si lacerano irrimediabilmente. Si adatta a qualunque terreno. Preferisce l’esposizione al sole o, tutt’al più, a mezz’ombra. Necessita di annaffiature solo nei primi anni di vita, in estate. È consigliabile concimarla ogni autunno e primavera con un prodotto organico. Sopporta le potature.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun.png",
                },

                new Alberi
                {
                   NomeComunePianta = "PERO DA FIORE",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Pyrus calleryana Chanticleer",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Pero da Fiore/PERO DA FIORE.jpg",

                   DescrizioneBotanica = "ALBERELLO (MASSIMO 6 M D’ALTEZZA X 4 DI DIAMETRO) A PORTAMENTO PIRAMIDALE, CARATTERIZZATO DALL’ECCEZIONALE FIORITURA PRIMAVERILE (IN APRILE), QUANDO SI RIEMPIE DI COROLLE CANDIDE DOPPIE, CHE RIVESTONO INTERAMENTE I RAMI, NASCONDENDOLI. SEGUONO IN AGOSTO MINUSCOLE PERE GIALLE, NON COMMESTIBILI MA MOLTO GRADITE AGLI UCCELLINI. IL FOGLIAME, VERDE LUCIDO IN ESTATE, DIVIENE GIALLO E ROSSO IN AUTUNNO, PRIMA DI CADERE. MOLTO ADATTO PER PICCOLI GIARDINI.",
                   Coltivazione = "Resiste al gelo, alla calura, ai venti freddi e all’inquinamento urbano. Per fiorire bene, necessita di una posizione ben soleggiata. Si adatta a qualunque terreno, purché non umido o poco drenato. Va concimato in autunno e in primavera con un prodotto granulare per arbusti da fiore. Si può potare, se necessario. Ottimo per consolidare pendii e scarpate, grazie al robusto ed esteso apparato radicale.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun.png",
                },

                new Alberi
                {
                   NomeComunePianta = "PINO ",
                   NomeFamiglia = "Pinacee",
                   NomeScientificoPianta = "Pinus",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Pino/PINO.jpg",

                   DescrizioneBotanica = "P. SYLVESTRIS (PINO SILVESTRE), P. NIGRA (PINO NERO), P. MUGO (PINO MUGO), P. CEMBRA (PINO CEMBRO O CRIMOLO) SONO SPECIE ADATTE ALLA MONTAGNA; P. PINEA (PINO DOMESTICO, DA PINOLI), P. PINASTER (PINO MARITTIMO, DA PINOLI), P. HALEPENSIS (PINO D’ALEPPO) SONO INVECE IDONEI ALLE COSTE MARINE. SI DISTINGUONO FRA DI LORO PER IL PORTAMENTO, IL NUMERO DI AGHI PER FASCETTO E LA LORO LUNGHEZZA. SI TRATTA SEMPRE DI ALBERI ESPANSI, CHE NECESSITANO DELL’ADEGUATO SPAZIO IN GIARDINO.",
                   Coltivazione = "I pini montani resistono al gelo, ma possono subire rotture di rami sotto il peso della neve (a eccezione del mugo e del cembro, compatti e prostrati); non tollerano il caldo intenso; desiderano suoli freschi, mediamente fertili e senza ristagni d’acqua. I pini marini resistono sino alla Val Padana; richiedono terreni asciutti, sciolti e ben drenati. Tutti i pini non amano le potature e soprattutto le capitozzature",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sempreverde.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun&Cloud.png",
                },

                new Alberi
                {
                   NomeComunePianta = "PIOPPO",
                   NomeFamiglia = "Salicacee",
                   NomeScientificoPianta = "Populus nigra, P. alba, P. tremula",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Pioppo/PIOPPO.jpg",

                   DescrizioneBotanica = "P. NIGRA (PIOPPO NERO) È ALTO FINO A 25 M, HA CORTECCIA SCURA, FOGLIE A CUORE VERDE LUCIDO E LA PIANTA FEMMINILE PRODUCE FRUTTI DOTATI DI PIUMINO (PAPPO), CAUSA DI ALLERGIE E SPORCIZIA; LA VARIETÀ CIPRESSINA HA PORTAMENTO PIRAMIDALE. P. ALBA (PIOPPO BIANCO) TOCCA I 30 M, HA CORTECCIA BIANCA CON MACCHIE NERE, FOGLIE OVALI LOBATE CON PAGINA INFERIORE PELOSA E BIANCA. P. TREMULA (PIOPPO TREMULO) HA FOGLIE TONDE E LOBATE, BIANCHE E PELOSE AL DI SOTTO, FREMENTI AL VENTO.",
                   Coltivazione = "Non temono il caldo né il freddo, purché non troppo intensi. Amano il sole ma vivono bene anche a mezz’ombra. Preferiscono suoli umidi, profondi, freschi, ma si adattano anche ad altre situazioni. Necessitano comunque di acqua nei primi anni di vita. Hanno crescita molto rapida, ma sono anche piuttosto longevi; si impiegano per consolidare scarpate. Tollerano l’inquinamento urbano e le potature, compresa la capitozzatura.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun&Cloud.png",
                },

                new Alberi
                {
                   NomeComunePianta = "PLATANO",
                   NomeFamiglia = "Platanacee",
                   NomeScientificoPianta = " Platanus occidentalis",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Platano/PLATANO.jpg",

                   DescrizioneBotanica = "GRANDE ALBERO (FINO A 30 M D’ALTEZZA E DI DIAMETRO DELLA CHIOMA) CARATTERIZZATO DA CORTECCIA CHIARA CHE SI SCREPOLA IN PLACCHE. LE FOGLIE A 3-5 LOBI SONO GRANDI E LUCIDE, DECIDUE IN AUTUNNO. DAI FIORI INSIGNIFICANTI SCATURISCONO FRUTTI TONDEGGIANTI CHE LIBERANO MOLTISSIMI SEMI. LARGAMENTE UTILIZZATO PER ALBERATURE STRADALI, IN GIARDINO DEVE RICEVERE LO SPAZIO ADEGUATO. P. ACERIFOLIA, MOLTO DIFFUSO IN ITALIA, È L’IBRIDO FRA P. OCCIDENTALIS E P. ORIENTALIS.",
                   Coltivazione = "Non teme il caldo e il freddo, né l’inquinamento urbano. Desidera posizioni soleggiate, ma resiste anche in mezzo sole o all’ombra. Preferisce un terreno ben drenato e profondo, ma vive in realtà su qualunque substrato. Va annaffiato solo nel primo anno dopo l’impianto, nel periodo estivo se non piove. Si giova di concime organico in autunno nei primi anni di vita. Può essere potato senza alcun problema.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun.png",
                },

                new Alberi
                {
                   NomeComunePianta = "PRUNUS DA FIORE",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Prunus",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Prunus da Fiore/PRUNUS DA FIORE.jpg",

                   DescrizioneBotanica = "PRUNUS PISSARDII È UN ALBERELLO ALTO AL MASSIMO 10 M, CON FOGLIAME PURPUREO E FIORITURA ROSEA IN MARZO, PRIMA DELL’EMISSIONE DELLE FOGLIE. P. SUBHIRTELLA AUTUMNALIS FIORISCE IN BIANCO TRA DICEMBRE E FEBBRAIO. P. KANZAN È IL CILIEGIO DA FIORE, CHE IN MAGGIO SI RIEMPIE DI FIORI ROSA DOPPI. P. MUME PRODUCE FIORI SEMPLICI ROSA TRA GENNAIO E MARZO. P. TENELLA È IL MANDORLO DA FIORE, CHE SI AMMANTA IN GENNAIO DI FIORI BIANCHI, ROSA O ROSSI. SONO ALBERI ADATTI A PICCOLI GIARDINI.",
                   Coltivazione = "Resistono tutti alle basse temperature e al caldo estivo, nonché all’inquinamento urbano. Per le dimensioni contenute, alcuni si coltivano in vaso. Preferiscono suoli leggeri e ben drenati, fertili, ma si adattano anche ad altre tipologie. Vanno annaffiati solo nel primo anno dopo l’impianto. È bene concimare ogni anno in autunno, con un fertilizzante organico. Tollerano le potature, che però non sono indispensabili.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun.png",
                },

                new Alberi
                {
                   NomeComunePianta = "QUERCIA",
                   NomeFamiglia = "Fagacee",
                   NomeScientificoPianta = "Quercus",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Quercia/QUERCIA.jpg",

                   DescrizioneBotanica = "TRA LE QUERCE CADUCIFOGLIE Q. PETRAEA (ROVERE) AMA SUOLI LEGGERMENTE ACIDI, COME Q. CERRIS (CERRO) Q. ROBUR (FARNIA) RAGGIUNGE LE MAGGIORI DIMENSIONI (OLTRE 30 M D'ALTEZZA E DIAMETRO DELLA CHIOMA); Q. RUBER (QUERCIA ROSSA) HA GRANDI FOGLIE ARROSSATE IN PRIMAVERA E AUTUNNO. TRA LE SEMPREVERDI Q. ILEX (LECCIO) HA FOGLIE PELOSE NELLA PAGINA INFERIORE; Q. TROJANA PREFERISCE AMBIENTI A CLIMA MITE. TUTTE HANNO CRESCITA MOLTO LENTA E TAGLIA GRANDE.",
                   Coltivazione = "Le caducifoglie resistono ai geli alpini e al caldo estivo. Si adattano a ogni tipo di suolo, con qualche preferenza specifica. Preferiscono un'esposizione soleggiata, ma non è indispensabile. Vanno irrigate solo nell'anno successivo all'impianto. Nei primi anni si concimano ogni autunno, per favorirne l'accrescimento. In genere, non necessitano di potature, alle quali comunque non reagiscono negativamente.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun&Cloud.png",
                },

                new Alberi
                {
                   NomeComunePianta = "ROBINIA",
                   NomeFamiglia = "Leguminose",
                   NomeScientificoPianta = "Robinia pseudacacia",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Robinia/ROBINIA.jpg",

                   DescrizioneBotanica = "ALBERO RUSTICO DALLA CRESCITA VELOCE MA POCO LONGEVO; PUÒ TOCCARE I 20 M D’ALTEZZA. SUI RAMI SPINOSI SI ADDENSANO LE FOGLIE FORMATE DA FOGLIOLINE OVALI ARROTONDATE. FIORISCE IN APRILE-MAGGIO, IN BIANCO, CON VISTOSE PANNOCCHIE PENDULE MOLTO PROFUMATE. I FIORI ATTIRANO LE API, CHE NE RICAVANO IL MIELE D’ACACIA. ALBERO ADATTO AL CONSOLIDAMENTO DI PENDII E SCARPATE E A TERRENI POVERI. TENDE PERÒ A DIVENIRE INFESTANTE, PERCHÉ I SEMI SONO MOLTO FERTILI.",
                   Coltivazione = "Non teme il freddo, ma è meno resistente al caldo torrido, che ne limita lo sviluppo, così come i venti salsi o la salinità nel suolo. Non ha preferenze in fatto di terreno, che può essere anche sassoso, sabbioso o, viceversa, molto compatto. Si annaffia solo nel primo periodo dopo l’impianto. Non va concimata perché, come tutte le leguminose, sfrutta l’azoto atmosferico con le radici. La potatura ne stimola la crescita.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun.png",
                },

                new Alberi
                {
                   NomeComunePianta = "SALICE",
                   NomeFamiglia = "Salicacee",
                   NomeScientificoPianta = "Salix",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Salice/SALICE.jpg",

                   DescrizioneBotanica = "I SALICI SONO ALBERI RUSTICI, ROBUSTI E FRUGALI, ALLEVABILI ANCHE A CESPUGLIO. S. VIMINALIS (SALICE DA VIMINI) HA LUNGHI RAMI FLESSIBILI; S. ALBA (SALICE BIANCO) FOGLIE LANCEOLATE E STRETTE; S. CAPREA (SALICONE) PREDILIGE GLI AMBIENTI ALPINI; S. BABYLONICA (SALICE PIANGENTE) LUNGHISSIMI RAMI PENDULI CHE SFIORANO IL TERRENO. SI POSSONO UTILIZZARE COME ESEMPLARE ISOLATO O IN BOSCHETTI, MESCOLATI AD ALTRE SPECIE CHE, UGUALMENTE, AMANO I TERRENI UMIDI.",
                   Coltivazione = "Resistono sia al freddo sia al caldo, ma non ai terreni asciutti: il suolo ideale è umido, anche poco drenato, mediamente fertile, abbastanza sciolto. All’impianto vanno annaffiati in abbondanza e, per tutta la vita, non bisogna mai far asciugare il terreno. Prediligono il sole, ma vivono anche all’ombra. Non è necessario concimare, ma gradiscono un apporto autunnale. Tollerano ogni genere di potatura, anche la capitozzatura.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun&Cloud.png",
                },

                new Alberi
                {
                   NomeComunePianta = "SORBO",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Sorbus",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Sorbo/SORBO.jpg",

                   DescrizioneBotanica = "S. AUCUPARIA È UN LEGGERO ALBERELLO (MASSIMO 15 M D’ALTEZZA) CON FOGLIE COMPOSTE DA FOGLIOLINE MINUTE, FIORI BIANCO CREMA IN CORIMBI IN MAGGIO E FRUTTI ARANCIONI (GIALLI O ROSSI NELLA VARIETÀ FLORICOLE) DA AGOSTO ALL’INVERNO. S. DOMESTICA (FARINELLO) È SIMILE MA PRODUCE FRUTTI PIÙ GRANDI (SORBOLE) COMMESTIBILI. S. ARIA (SORBO MONTANO) HA FOGLIE INTERE, LOBATE, E PRODUCE FRUTTI DI GRANDEZZA INTERMEDIA FRA LE ALTRE DUE SPECIE. SONO TUTTI CADUCIFOGLI.",
                   Coltivazione = "Sopportano temperature molto rigide, sotto lo zero, ma non tollerano il caldo: sono adatti per zone collinari o, meglio, montane. Desiderano suoli profondi, freschi e fertili. Amano esposizioni soleggiate o, tutt’al più, a mezz’ombra. Le annaffiature sono necessarie nell’anno dopo l’impianto e ogni qual volta non piova a sufficienza. Le concimazioni con prodotti organici, in autunno e primavera, sono molto apprezzate.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun&Cloud.png",
                },

                new Alberi
                {
                   NomeComunePianta = "TAMERICE",
                   NomeFamiglia = "Idrangeacee",
                   NomeScientificoPianta = "Tamarix gallica",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Tamerice/TAMERICE.jpg",

                   DescrizioneBotanica = "PICCOLO ALBERO (MASSIMO 6 M D’ALTEZZA) A FOGLIE CADUCHE CHE SPESSO TENDE A CRESCERE INCLINATO, SOPRATTUTTO SE SFERZATO DAL VENTO, CHE TOLLERA SENZA PROBLEMI. HA FOGLIE SQUAMIFORMI DI COLORE VERDE CHIARO GRIGIASTRO. IN MARZO-APRILE I RAMI SI RIEMPIONO DI PICCOLE SPIGHE DI FIORI MINUSCOLI, DI COLORE ROSA TENUE; LA FIORITURA È COSÌ ABBONDANTE CHE LA PIANTA APPARE COME UNA NUVOLA DI FIORI. IDEALE PER PICCOLI SPAZI IN CLIMI MITI.",
                   Coltivazione = "Sopporta il freddo della Val Padana, il vento anche salso e il caldo più torrido. Fiorisce bene solo in posizioni molto soleggiate. Desidera terreni leggeri, molto ben drenati, anche poveri, sabbiosi, sassosi o secchi. Va annaffiata solo subito dopo l’impianto, in seguito tollera siccità anche molto prolungate. Gradisce una concimazione autunnale con un fertilizzante organico. Tollera le potature di riordino.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun.png",
                },

                new Alberi
                {
                   NomeComunePianta = "TASSO",
                   NomeFamiglia = "Tassacee",
                   NomeScientificoPianta = "Taxus baccata",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Tasso/TASSO.jpg",

                   DescrizioneBotanica = "CONIFERA DALLA CRESCITA MOLTO LENTA (MA È MOLTO LONGEVA), DA ALLEVARE SIA AD ALBERO SIA AD ARBUSTO. I RAMI SONO COPERTI DA AGHI PIATTI E MORBIDI. LA SPECIE È A SESSI SEPARATI (ESISTONO ESEMPLARI SOLO FEMMINILI E ALTRI SOLO MASCHILI). I 'FIORI' COMPAIONO IN MARZO. IN SETTEMBRE LA PIANTE FEMMINILI PORTANO VISTOSI FRUTTI COMPOSTI DA UN INVOLUCRO CARNOSO ROSSO (ARILLO), AL CENTRO DEL QUALE È POSTO UN GROSSO SEME NERO. TUTTA LA PIANTA È VELENOSA TRANNE L’ARILLO.",
                   Coltivazione = "Non teme le temperature più rigide, né il caldo intenso, ma non è indicato per zone costiere. Desidera un substrato fertile, profondo e fresco, ben drenato. L’esposizione è indifferente: vive bene anche all’ombra. Desidera annaffiature regolari nel primo anno e ogni qual volta il substrato si asciughi troppo. Una leggera concimazione autunnale con fertilizzante organico ne migliora la crescita e la fruttifficazione.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sempreverde.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun&Cloud.png",
                },

                new Alberi
                {
                   NomeComunePianta = "TIGLIO",
                   NomeFamiglia = "Tigliacee",
                   NomeScientificoPianta = "Tilia platyphyllos",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Tiglio/TIGLIO.jpg",

                   DescrizioneBotanica = "ALBERO DI GRANDI DIMENSIONI (FINO A 35 M D’ALTEZZA E 20 M DI DIAMETRO DELLA CHIOMA), A CRESCITA ABBASTANZA LENTA E MOLTO LONGEVO. LE FOGLIE, CADUCHE, SONO GRANDI, CUORIFORMI, CON MARGINE DENTATO. IN MAGGIO-GIUGNO PRODUCE FIORI BIANCHI, PICCOLI, PROFUMATISSIMI, CHE ATTIRANO LE API. IL SEME, MUNITO DI ALA, VIENE POI TRASPORTATO DAL VENTO. NECESSITANO DI GRANDI SPAZI, IN RELAZIONE ALLE DIMENSIONI DELL’ALBERO ADULTO, CHE PRODUCE ANCHE UN’OMBRA MOLTO FITTA.",
                   Coltivazione = "Tollera temperature rigide ed estati calde, ma non i venti forti che lacerano le foglie e quelli salsi. Desidera esposizioni soleggiate per fiorire in abbondanza. Il suolo preferito è profondo, fresco e fertile, ma sopporta anche altre tipologie, perfino con drenaggio non ottimale. Va annaffiato nel primo anno dopo l’impianto. Una concimazione autunnale ne facilita la fioritura. Vanno sempre eliminati i polloni basali.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Decidua.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun.png",
                },

                new Alberi
                {
                   NomeComunePianta = "TUIA",
                   NomeFamiglia = "Cipressacee",
                   NomeScientificoPianta = "Thuja occidentalis",
                   FotoPianta = "ms-appx:///Immagini/ALBERI/Tuia/TUIA.jpg",

                   DescrizioneBotanica = "ALBERO SEMPREVERDE DI GRANDI DIMENSIONI (FINO A 30 M D’ALTEZZA) CHE SPESSO VIENE ALLEVATO A CESPUGLIO COME PIANTA DA SIEPE. MUNITO DI FOGLIE APPIATTITE E SQUAMIFORMI, DI COLORE VERDE-GRIGIO (MA ANCHE VARIEGATE D’ORO IN ALCUNE VARIETÀ FLORICOLE), HA UNA CHIOMA DENSA ED ERETTA, A VOLTE PIRAMIDALE. PRODUCE PICCOLE PIGNE TONDEGGIAN TI CON PROTUBERANZE IRREGOLARI, VERDI E POI BLU-NERE, PRUINOSE. NE ESISTONO ANCHE CULTIVAR A SVILUPPO NANO.",
                   Coltivazione = "Sopporta i rigori degli inverni alpini, il vento freddo e il calore intenso, ma non le correnti salmastre delle coste. Vive bene in qualunque esposizione (ma all’ombra tende a svuotarsi al centro). Ama terreni freschi e profondi, soffici e molto ben drenati. Nei primi anni dopo l’impianto è necessario annaffiare se non piove. Una leggera concimazione in autunno è gradita. Resiste benissimo alle potature, anche drastiche.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   SimboloFogliame = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sempreverde.png",
                   SimboloDurata = "ms-appx:///Immagini/SimboliSchedeBotaniche/Perenne.png",
                   SimboloAcqua = "ms-appx:///Immagini/SimboliSchedeBotaniche/Acqua.png",
                   SimboloPosizione = "ms-appx:///Immagini/SimboliSchedeBotaniche/Sun&Cloud.png",
                },

            };

            return data;
        }

        // TODO WTS: Remove this once your MasterDetail pages are displaying real data
        public static async Task<IEnumerable<Alberi>> GetSampleModelDataAsync()
        {
            await Task.CompletedTask;

            return AllAlberi();
        }

        // TODO WTS: Remove this once your ContentGrid page is displaying real data.
        public static async Task<IEnumerable<Alberi>> GetContentGridDataAsync()
        {
           

            await Task.CompletedTask;
            return  AllAlberi(); 
        }
    }

}
