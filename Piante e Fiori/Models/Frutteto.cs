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
//16 ALBERI DA FRUTTO
    public class Frutteto
    {
        public string NomeComunePianta { get; set; }
        public string NomeFamiglia { get; set; }
        public string NomeScientificoPianta { get; set; }
        public string FotoPianta { get; set; }
        public string SourceGalleryFotografica { get; set; }

        public string Storia { get; set; }
        public string Caratteristiche { get; set; }
        public string Clima { get; set; }
        public string Terreno { get; set; }
        public string FormaAllevamento { get; set; }
        public string Piantagione { get; set; }
        public string ConcimazioneeIrrigazione { get; set; }
        public string Potatura { get; set; }
        public string RaccoltaeConservazione { get; set; }

        public string ProblemieSoluzioni1 { get; set; }
        public string ProblemieSoluzioni2 { get; set; }
        public string ProblemieSoluzioni3 { get; set; }
        public string ProblemieSoluzioni4 { get; set; }
        public string ProblemieSoluzioni5 { get; set; }

        public string VarietaConsigliate1 { get; set; }
        public string VarietaConsigliate2 { get; set; } 
        public string VarietaConsigliate3 { get; set; }
        public string VarietaConsigliate4 { get; set; }
        public string VarietaConsigliate5 { get; set; }

    }

    public static class FruttetoDataService
    {
        private static IEnumerable<Frutteto> AllFrutteto()
        {
            // The following is order summary data
            var data = new ObservableCollection<Frutteto>
            {
               
                new Frutteto
                {
                   NomeComunePianta = "ALBICOCCO",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Prunus americana",
                   FotoPianta = "ms-appx:///Immagini/FRUTTETO/Albicocco/ALBICOCCO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Storia = "Gli antichi Romani lo conoscevano come pesca o mela dell’Armenia, e questo “errore“ si è tramandato nel nome botanico dell’albicocco, appunto Prunus armeniaca. Come quasi tutti gli alberi da frutto diffusi nei nostri climi, è di origine asiatica. Furono gli Arabi a realizzare le prime coltivazioni in Europa; in precedenza non aveva larga diffusione, pur essendo già noto nel primo secolo dopo Cristo. ",
                   Caratteristiche = "L’albero si sviluppa considerevolmente, sia nella parte aerea sia nelle radici; presenta foglie cuoriformi prive di peluria e provviste di un lungo picciolo. I fiori compaiono in primavera (anche già a fine febbraio), prima della fogliazione, e sono bianco-rosati, singoli o in gruppi di 2 o 3. Le varietà più diffuse sono tutte autocompatibili: è quindi possibile allevare in giardino o nell’orto anche un singolo esemplare. Il frutto, con buccia delicatamente pelosa, è di colore aranciato con sfumature rosate nei punti colpiti dal sole. Il seme (armellina) racchiuso nel nocciolo è spesso dolce, commestibile e, come una mandorla amara, ricco di amigdalina che sviluppa cianuro, per cui conviene non abusarne. Il contenuto di vitamina A è elevatissimo.",
                   Clima = "Resiste bene sia al freddo sia al caldo, predilige comunque il pieno sole e un clima temperato-caldo. Nelle zone con inverno molto lungo la sua coltivazione è limitata più che altro dalla precoce fioritura, che può essere distrutta dalle brinate. Nella scelta della varietà per il Nord è quindi essenziale orientarsi verso quelle con fioritura tardiva. Non va piantato in zone soggette a forte vento. ",
                   Terreno = "Come le altre drupacee, preferisce quelli sciolti, freschi, profondi e possibilmente ben irrigati, ma teme l’umidità costante che causa asfissia radicale. ",
                   FormaAllevamento = "Nei giardini viene coltivato generalmente in forma libera; è consigliabile comunque una riduzione dell’altezza del tronco. Se si preferisce una forma guidata, optare per il vaso basso e la palmetta a branche oblique. ",
                   Piantagione = "Va messo a dimora in autunno come astone di un anno, innestato su franco o mirabolano. Entra in produzione a partire dal terzo anno e produce ottimamente fino ai 20 anni. ",
                   ConcimazioneeIrrigazione = " Si consiglia di distribuire del letame sul fondo della buca di piantagione, coprendolo poi con della terra per impedire il contatto diretto con le radici. Nei primi anni di concimare solo con azoto, in seguito fornire 300-400 g per pianta di concime complesso NPK 2:1:2. Richiede un paio di irrigazioni in estate, ma non si deve bagnare a partire da un mese prima della raccolta per evitare la spaccatura dei frutti. ",
                   Potatura = "Sensibilissimo ai tagli. Per evitare eccessiva formazione di gomma sulle ferite, va potato dopo la raccolta dei frutti solo per ripulire la chioma, intervenendo su rami di piccole dimensioni. ",
                   RaccoltaeConservazione = " I frutti vanno raccolti maturi tra giugno e luglio; la conservazione del prodotto fresco si riduce a pochi giorni.",

                   ProblemieSoluzioni1 = "Apoplessia: appena prima o appena dopo la maturazione dei frutti, può verificarsi l’improvvisa morte della pianta. L’origine di questo evento non è ancora accertata; non esiste cura. ",
                   ProblemieSoluzioni2 = "Monilia: i frutti maturi sono estremamente sensibili a questa malattia fungina, che si presenta sotto forma larvata che li fa apparire appassiti, o in forma virulenta (presenza di muffa a circoli). La soluzione consiste nel non irrigare prima della raccolta, che va effettuata nel giro di pochi giorni.",
                   ProblemieSoluzioni3 = "",
                   ProblemieSoluzioni4 = "",
                   ProblemieSoluzioni5 = "",

                   VarietaConsigliate1 = "Bella di Imola: adatta alle regioni settentrionali. Frutto grosso, produzione costante e precocissima. ",
                   VarietaConsigliate2 = "Ivonne Liverani: varietà resistente alla monilia e alle gelate primaverili. Frutto medio-grosso, di colore giallo intenso. ",
                   VarietaConsigliate3 = "Monaco: ideale al Sud, molto produttiva. Matura a giugno.",
                   VarietaConsigliate4 = "San Castrese: adatta a tutte le regioni italiane. Frutto grosso e aranciato, matura a luglio al Nord e a metà giugno al Sud.",
                   VarietaConsigliate5 = "",
                },

                new Frutteto
                {
                   NomeComunePianta = "ARANCIO",
                   NomeFamiglia = "Rutacee",
                   NomeScientificoPianta = "Citrus sinensis",
                   FotoPianta = "ms-appx:///Immagini/FRUTTETO/Arancio/ARANCIO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Storia = "Si deve probabilmente ai mercanti arabi l’introduzione dell’arancio in Sicilia. Questa pianta dall’aspetto splendido e dalla celebre fioritura profumata fu poi diffusa in tutta Europa come pregiata e delicata specie ornamentale, per la quale venivano spese enormi fortune nella costruzione di serre (aranciere) destinate a proteggere gli esemplari dal freddo. L’albero di arancio è longevo, vive anche un secolo; i frutti sono ricchissimi di vitamina C, soprattutto se consumati allo stato fresco e subito dopo la raccolta. I profumati fiori d’arancio si chiamano zagare, da un’antica parola araba che significa «splendore scintillante».",
                   Caratteristiche = "Albero o arbusto sempreverde da esterno che adulto presenta una chioma arrotolata e che può raggiungere un'altezza di 10 metri. Le foglie hanno colore verde intenso, ovate e appuntite all'apice, provviste di grandi alette sul picciolo. I rami più vigorosi sono molto spinosi; ha un robusto apparato radicale con fittone. I fiori sono ermafroditi, bianchi, profumati e presentano 5 petali. ",
                   Clima = "Non resiste al gelo. Gli esemplari innestati sul ponciro (agrume molto rustico con frutti non commestibili) risultano più resistenti a brevi e occasionali gelate.",
                   Terreno = "Non deve essere argilloso e impermeabile perché i ristagni provocano sofferenza radicale. Gradisce un substrato neutro (privo di calcare). ",
                   FormaAllevamento = "Lo sviluppo naturale tende a formare piante con chioma globosa; è consigliabile assecondare questo sviluppo, limitandosi a mantenerlo compatto e ordinato. La dimensione della pianta adulta dipende dal portainnesto scelto: gli aranci su limone selvatico formano esemplari di dimensioni imponenti.",
                   Piantagione = "Preparate una buca ampia, arricchendo la terra con sostanza organica; il periodo consigliato è l’inizio della primavera. ",
                   ConcimazioneeIrrigazione = "Consigliabili interventi con prodotti a lenta cessione, in autunno. Le piante di arancio hanno un notevole fabbisogno idrico, soprattutto in primavera e in fase di maturazione dei frutti che, in caso di sofferenza idrica, cadono prematuramente. ",
                   Potatura = "Non è consigliabile effettuare potature drastiche. I tagli devono piuttosto limitarsi alla pulizia e al riordino dei rami che escono dalla sagoma. Gli esemplari coltivati a siepe richiedono spuntature per conservare la superficie verticale appiattita. Meglio intervenire quando le piante sono in vegetazione: le potature invernali provocano la formazione di cicatrici sul legno che favoriscono gli attacchi fungini. Nei climi afosi è consigliabile mantenere libero e aerato il centro della chioma. ",
                   RaccoltaeConservazione = "Le arance bionde offrono un raccolto distribuito su un periodo più lungo rispetto a quelle pigmentate, come le Tarocco. A differenza del limone, il processo di maturazione si arresta una volta staccato il frutto dalla pianta; è quindi consigliabile raccogliere in base al consumo familiare e allo stadio di maturazione dei frutti nelle diverse parti della chioma. Nei Paesi tropicali, la buccia del frutto spesso rimane di colore verde. Le arance non cerate consentono l’utilizzo della scorza, ricca di oli essenziali, per canditi, conserve e preparazioni gastronomiche varie.",

                   ProblemieSoluzioni1 = "Caduta precoce dei frutticini: indica carenza idrica, stress ambientale (inaridimento da vento) o terreno povero. ",
                   ProblemieSoluzioni2 = "Cocciniglia: le infestazioni estese vanno trattate con olio bianco, nel periodo invernale, per agire sulle uova.",
                   ProblemieSoluzioni3 = "Fumaggine: muffa nerastra che si forma sulle foglie. Indica la presenza di parassiti (cocciniglie o afidi): eliminando i fitofagi, il problema si attenua e sparisce.",
                   ProblemieSoluzioni4 = "",
                   ProblemieSoluzioni5 = "",

                   VarietaConsigliate1 = "A differenza del limone che accetta vasi di media dimensione, l’arancio ha bisogno di grandi mastelli in legno, cotto o plastica, quest’ultima consigliabile se la pianta vive in giardini o terrazzi ventosi, perché riduce i rischi di disseccamento rapido del suolo. Per calcolare la dimensione del vaso, prevedete un diametro pari ai due terzi di quello della chioma dell’esemplare in coltivazione. ",
                   VarietaConsigliate2 = "Durante l’inverno, le piante ricoverate in ambiente protetto vanno sorvegliate spesso, analizzando i germogli e le pagine inferiori delle foglie: negli ambienti chiusi, con luminosità ridotta, si manifestano numerose patologie e fisiopatie. Come prevenzione arieggiate l’ambiente nelle ore più calde della giornata.",
                   VarietaConsigliate3 = "",
                   VarietaConsigliate4 = "",
                   VarietaConsigliate5 = "",
                },


                new Frutteto
                {
                   NomeComunePianta = "CILIEGIO",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Prunus avium, P. cerasum",
                   FotoPianta = "ms-appx:///Immagini/FRUTTETO/Ciliegio/CILIEGIO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/FRUTTETO/Abete-*.jpg",

                   Storia = "Ogni anno, nei primi giorni di aprile, i giapponesi si riversano nei parchi delle loro città per ammirare la fioritura dei ciliegi: il fiore di questo albero, chiamato Sakura, rappresenta l’anima del Giappone. La delicatezza, il colore pallido, la brevità della sua esistenza sono per i nipponici il simbolo della fragilità, ma anche della bellezza dell’esistenza. Nel resto del mondo, la parola “ciliegio” evoca invece grappoli di frutti rossi e dolci, chiamati duroni o duracine, tenerine o visciole a seconda della consistenza della polpa. Nulla a che fare con la pianta di amarene o ciliegio acido (Prunus cerasus).",
                   Caratteristiche = "Il ciliegio ha dimensioni e portamento maestoso; il legno rossiccio è usato in ebanisteria, ma è poco pregiato perché si imbarca facilmente; la corteccia si stacca a nastro. Le foglie sono ovali, pendule e ampie. I fiori, riuniti in mazzetti anche di 6, bianchi, compaiono prima delle foglie. I frutti sono piccoli, globosi, di colore rosso variabile fino al nero, con polpa aderente al nocciolo.",
                   Clima = "Resiste bene al freddo, mal sopporta invece l’eccessivo caldo estivo; si adatta a tutte le regioni italiane. Le piogge intense durante la fioritura compromettono la produzione perché provocano la caduta anticipata dei fiori. Nell’Italia settentrionale si coltivano preferibilmente varietà a polpa dura, mentre nel Meridione si preferiscono quelle a polpa tenera. ",
                   Terreno = "Ottimi quelli sciolti, profondi, anche sassosi: da evitare suoli argillosi e compatti, in cui ristagna l’acqua. ",
                   FormaAllevamento = "Innestato su franco tende ad espandersi considerevolmente, per cui è preferibile allevarlo in ampi spazi e controllare l’eccessivo sviluppo con la potatura. Innestato su amarena, invece, mantiene un portamento limitato, in forma di palmetta o bandiera. ",
                   Piantagione = "In autunno. Se innestato su franco, le distanze sul fiore e tra le file saranno di 12 cm, minori se su amarena; anche l’entrata in produzione dipende dal portainnesto: tardiva (7-10 anni, poi produttivo per 100 anni) nel primo caso, più precoce nel secondo (ma meno longevo).",
                   ConcimazioneeIrrigazione = "Una buona letamazione ogni 2 anni è consigliata per gli alberi dei frutteti familiari. Per incrementare la produzione si può distribuire concime chimico in rapporto 2:1:1. La precocità di produzione dei frutti non richiede interventi irrigui.",
                   Potatura = "Produce abbondante gomma dalle ferite ed è meglio non esagerare con i tagli. Sono sufficienti leggeri interventi dopo la raccolta, solo per eliminare i rami secchi e sfoltire l’interno della chioma. ",
                   RaccoltaeConservazione = "Le ciliegie devono essere raccolte mature sulla pianta e non si conservano allo stato fresco se non per pochi giorni. Sono ideali per la trasformazione in confetture, canditi o preparazioni sotto spirito. La raccolta per il frutto da consumo fresco è manuale. Si usano scuotitori solo per le varietà destinate alla trasformazione. La maturazione avviene entro giugno: tradizione vuole che la scadenza per gustare le ciliegie sia il 24 giugno, giorno di San Giovanni, per cui i bachi che si trovano nei frutti maturi vengono detti “giovannini”.",

                   ProblemieSoluzioni1 = "Mosca della ciliegia: sono i vermetti che si trovano dentro i frutti bacati. La mosca depone un uovo all’interno di ogni frutto; le larve si nutrono della polpa provocando la cascola preraccolta. Nei frutteti familiari si combattono scegliendo varietà precoci o anticipando la raccolta.",
                   ProblemieSoluzioni2 = "",
                   ProblemieSoluzioni3 = "",
                   ProblemieSoluzioni4 = "",
                   ProblemieSoluzioni5 = "",

                   VarietaConsigliate1 = "Bigarreau: gruppo di duroni dal frutto grosso, a polpa bianca o rosata e buccia rosso scuro (Burlat, Moreau, Napoleon). ",
                   VarietaConsigliate2 = "Durone Classico: Nero, della Marca, dell’Anella, di Pistoia, di Cesena… Grosse ciliegie duracine, diffuse anche al di fuori della zona di provenienza. ",
                   VarietaConsigliate3 = "More: di Cesena, di Vignola, della Punta. Gruppo di varietà del tipo Tenerina, dal colore scuro, sapore dolce, frutto grosso.",
                   VarietaConsigliate4 = "",
                   VarietaConsigliate5 = "",
                },


                new Frutteto
                {
                   NomeComunePianta = "FICO",
                   NomeFamiglia = "Moracee",
                   NomeScientificoPianta = "Ficus carica",
                   FotoPianta = "ms-appx:///Immagini/FRUTTETO/Fico/FICO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Storia = "La leggenda racconta che Romolo e Remo furono ritrovati sotto un fico mentre la lupa li allattava. Questa pianta mediterranea era già coltivata dagli Egizi e a Babilonia; nell’Odissea, Ulisse attende, precariamente appeso ad una pianta di fico sullo scoglio di Cariddi, che Scilla risputi la chiglia e l’albero della sua nave. Credenza popolare vuole che il latte prodotto dal distacco delle foglie, dei frutti e dei rami, possa essere usato come crema abbronzante. Mai diceria è stata più dannosa: spalmarsi sul corpo il lattice ed esporsi al sole provoca ustioni dolorose e difficili da curare. La sostanza è invece utile per far cagliare il latte.",
                   Caratteristiche = "Il fico è una specie molto pollonifera, tanto da trasformarsi spesso in arbusto. Ha tronco liscio e grigio, rami flessuosi ma robusti. Sia questi sia le foglie o i frutti, quando vengono staccati, emettono un lattice bianco. Le foglie sono grandi, a 3 o 5 lobi anche sulla stessa pianta, coriacee, ruvide e pelose. I frutti sono infiorescenze a ricettacolo a forma di trottola, di colore verde o nero a maturità. Fruttifica in epoche diverse, più volte all’anno: a giugno maturano i fichi “fioroni” o “primaticci” che compaiono sui germogli e all’ascella delle foglie nell’autunno dell’anno precedente. I fichi veri, detti anche “forniti”, compaiono sulla pianta a primavera e maturano ad agosto-settembre. Quelli che maturano in ottobre vengono chiamati “tardivi” o “cimaruoli”. Alcune varietà, considerate unifere, producono solo quelli veri.",
                   Clima = "Pianta mediterranea, soffre il freddo: nelle regioni settentrionali può essere coltivato solo in posizioni riparate. A –10 °C l’intera pianta può morire. La pioggia è dannosa quando la pianta è carica di frutti. Foglie e frutti subiscono scottature se l’insolazione è intensa.",
                   Terreno = "Allo stato selvatico vive in zone impervie; si adatta bene a suoli ciottolosi, sciolti e poveri. Sopporta comunque ogni tipo di terreno, a eccezione di quelli argillosi e impermeabili.",
                   FormaAllevamento = "Viene allevato in forma naturale, in alternativa si può scegliere il vaso a 4 branche. ",
                   Piantagione = "Si riproduce facilmente staccando i polloni radicati che annualmente spuntano alla base del fusto, o anche per talea di rami di 2-3 anni, lunghe 30-50 centimetri. In vivaio si trovano astoni innestati con le varietà migliori. L’impianto è autunnale e la produzione ha inizio al terzo-quarto anno. La massima produzione è raggiunta intorno ai 30 anni per poi decrescere; verso i 60 anni la pianta muore.",
                   ConcimazioneeIrrigazione = "Buone dosi di letame favoriscono sviluppo e produzione. Le piante altamente produttive richiedono somministrazioni idriche durante il periodo di maturazione dei frutti. In assenza di possibilità di innaffiare, sarchiare spesso il terreno. ",
                   Potatura = "Il fico non ama gli interventi di taglio. Le ferite si rimarginano con diffi coltà anche per la fuoriuscita di latice dalle ferite. Si eliminano quindi solo i rami rotti e secchi.",
                   RaccoltaeConservazione = "",

                   ProblemieSoluzioni1 = "Marciume radicale: in terreni pesanti la pianta viene attaccata da un fungo che causa marcescenza delle radici. La parte aerea deperisce, le foglie ingialliscono e la pianta muore. Non ci sono cure: l’unica strategia è la prevenzione, preparando il sito d’impianto con un buon drenaggio.",
                   ProblemieSoluzioni2 = "",
                   ProblemieSoluzioni3 = "",
                   ProblemieSoluzioni4 = "",
                   ProblemieSoluzioni5 = "",

                   VarietaConsigliate1 = "Brogiotto Bianco: ottima cultivar, molto diffusa. La produzione si concentra sui fichi veri, pressoché assenti i fioroni.",
                   VarietaConsigliate2 = "Brogiotto Nero: come il bianco, ma con frutti scuri.",
                   VarietaConsigliate3 = "Dottato: è fra le varietà più diffuse in Italia. Produce frutti grossi e dolci che a maturità si presentano giallastri. Raramente compaiono i fioroni.",
                   VarietaConsigliate4 = "",
                   VarietaConsigliate5 = "",
                },

                                
                new Frutteto
                {
                   NomeComunePianta = "KAKI O LOTO",
                   NomeFamiglia = "Ebenacee",
                   NomeScientificoPianta = "Diospyros kaki",
                   FotoPianta = "ms-appx:///Immagini/FRUTTETO/Kaki/KAKI.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Storia = "Specie originaria della Cina ma particolarmente apprezzata in Giappone, dove è molto diffusa fin da epoche lontane. In Europa arrivò solo alla fine dell’Ottocento e subito si diffuse negli orti e nei giardini soprattutto per la qualità ornamentale delle foglie e dei frutti. Nei climi continentali europei è l’ultimo frutto a essere colto dalla pianta prima dell’inverno. ",
                   Caratteristiche = "L’albero adulto raggiunge anche i 12 m di altezza, con chioma globosa. È una delle poche specie poligamo-dioiche: vi sono infatti piante maschili, piante femminili, piante con fiori maschili ed ermafroditi e altre con fiori femminili ed ermafroditi. Questi ultimi sono solitari, provvisti di un originale e vistoso calice verde. Le foglie, grandi e ovate, sono verde scuro, lucenti nella pagina superiore e pelose in quella inferiore. A parte gli esemplari che portano solo fiori maschili, gli altri sono tutti molto produttivi. Una singola pianta adulta può produrre anche 3 q di frutti l’anno. Il kaki è una bacca sferica che a maturità assume una colorazione arancio brillante, a volte rosata. Può contenere o no i semi: nel primo caso c’è stata normale fecondazione, nel secondo la produzione dei frutti è avvenuta per partenocarpia, ossia senza l’intervento del polline.",
                   Clima = "Predilige la zona caldo-temperata, ma resiste bene anche in aree con inverni freddi. Teme le gelate primaverili, mentre elevate temperature estive migliorano le qualità organolettiche dei frutti. Soffre molto la siccità.",
                   Terreno = "Fresco, profondo, fertile. Teme l’umidità e il ristagno di acqua.",
                   FormaAllevamento = "In frutticoltura da reddito si adottano principalmente forme a vaso, piramide o anche forme appiattite come la palmetta. Nei giardini e negli orti viene preferita la forma naturale, molto bella. L’albero necessita di spazio per potersi espandere: tra gli esemplari servono distanze di 6x6 m e anche 5x8 metri.",
                   Piantagione = "Si mettono a dimora in autunno astoni innestati di un anno. L’entrata in produzione è rapida e già al terzo-quarto anno dall’impianto si hanno produzioni abbondanti. Oggi sono in commercio solo piante femminili: la produzione è quasi esclusivamente partenocarpica.",
                   ConcimazioneeIrrigazione = "Una concimazione organica annuale sopperisce alle esigenze anche degli esemplari più produttivi. Per portare a maturazione i frutti, la pianta richiede costanti irrigazioni estive.",
                   Potatura = "Esige solo interventi di rimonda e pulizia. Sugli esemplari vecchi, una drastica riduzione della chioma è d’aiuto per rinvigorire la vegetazione. Le piante producono sui rami dell’anno, quindi si può facilmente “sbagliare” taglio senza incorrere in una mancata produzione.",
                   RaccoltaeConservazione = "I kaki si raccolgono in autunno, dopo la caduta delle foglie. I frutti con semi maturano sulla pianta; quelli partenocarpici (apireni) alla raccolta non sono eduli perché astringenti e amari e vanno conservati in casa per un breve periodo prima del consumo. Per accelerare la maturazione (ammezzimento) è bene chiudere i frutti in un sacchetto con alcune mele, che esalano il gas etilene: questa sostanza in pochi giorni porterà i kaki alla giusta maturazione.",

                   ProblemieSoluzioni1 = "Gelate invernali: nei primi anni dopo l’impianto, il kaki è poco resistente al freddo. Conviene fasciare la base e il primo tratto del tronco con paglia. Nelle aree settentrionali con inverni precoci e molto freddi meglio scegliere esemplari innestati su Diospyros lotus, specie molto resistente al gelo.",
                   ProblemieSoluzioni2 = "",
                   ProblemieSoluzioni3 = "",
                   ProblemieSoluzioni4 = "",
                   ProblemieSoluzioni5 = "",

                   VarietaConsigliate1 = "Farmacista Honorati: produce frutti di buona qualità che necessitano di ammezzimento.",
                   VarietaConsigliate2 = "Fuju: una delle numerosissime varietà giapponesi, dal frutto grande, profumato e molto dolce.",
                   VarietaConsigliate3 = "Mercatelli: varietà che raggiunge la maturazione sulla pianta. È usato anche come ottimo impollinatore.",
                   VarietaConsigliate4 = "Vaniglia: frutti profumati, grossi e dolci. Albero molto bello.",
                   VarietaConsigliate5 = "",
                },


                new Frutteto
                {
                   NomeComunePianta = "KIWI O ACTNIDIA",
                   NomeFamiglia = "Actinidiacee",
                   NomeScientificoPianta = "Actinida chinensis",
                   FotoPianta = "ms-appx:///Immagini/FRUTTETO/Kiwi/KIWI.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Storia = "Solo negli anni Settanta la coltivazione del kiwi si è diffusa nelle nostre regioni sia a livello amatoriale sia in frutteti specializzati. Il merito del successo di questo frutto di origine cinese è dovuto alle qualità organolettiche e all’alto tenore in vitamina C, superiore anche a quello degli agrumi. Oggi l’Italia è il maggior produttore mondiale. Il nome, dato dagli inglesi, gli deriva dalla somiglianza che i frutti avrebbero con l’omonimo uccello dal corpo tozzo e dal piumaggio marrone e arruffato, simbolo della Nuova Zelanda, dove la specie è largamente coltivata da tempo.",
                   Caratteristiche = "L’aspetto della pianta è quello di un arbusto lianoso con rami ricoperti di peluria marrone, simile alla vite per la tendenza ad attorcigliarsi ai pali o agli alberi vicini, allungando i tralci anche per decine di metri. Le foglie sono grandi, tondeggianti, quasi cuoriformi, provviste di un lungo peduncolo peloso. La pagina superiore è liscia, quella inferiore è tomentosa. Si tratta di una specie dioica, cioè a sessi divisi: le piante produttive portano fiori esclusivamente femminili e le piante maschili hanno fiori solo polliniferi. È necessario intercalare una pianta maschio ogni 3-5 femmine per ottenere la fecondazione. I fiori con petali biancogiallastri sono profumati e si aprono in maggio-giugno. Il frutto è una bacca ovale con buccia rivestita dalla stessa peluria marrone che ricopre i tralci. La polpa è verde smeraldo e contiene, in cerchi concentrici, numerosi piccoli semi neri.",
                   Clima = "Si adatta a ogni situazione climatica, resiste anche a –25 °C e sopporta temperature elevate. Necessita però di almeno 700 ore di freddo (sotto i 7 °C) per svolgere al meglio ogni fase fenologica. I frutti temono le gelate autunnali, mentre i germogli quelle primaverili. Mal sopporta i venti forti e salmastri.",
                   Terreno = "Deve essere sciolto, profondo e ricco in sostanza organica, a pH neutro o subacido, senza calcare attivo. ",
                   FormaAllevamento = "Come per la vite si usano la pergola e la pergoletta, anche doppie, e il tendone. ",
                   Piantagione = "Nelle regioni del Nord si mettono a dimora le talee radicate. Al Sud si preferisce la pianta innestata.",
                   ConcimazioneeIrrigazione = "Ogni 2-3 anni si avvantaggia della distribuzione di letame, nel tardo autunno o fine inverno.",
                   Potatura = "Produce sui rami dell’anno; dopo la raccolta si eliminano i rami che hanno fruttifi cato lasciando poche gemme. Potare in primavera tardi porta all’abbondante produzione del “pianto”, linfa zuccherina che esce dalle ferite. In estate, è consigliato sfoltire la chioma per arieggiare e illuminare meglio i futuri rami produttivi. Gli esemplari maschili vanno ridimensionati energicamente in estate. ",
                   RaccoltaeConservazione = "La raccolta avviene a metà autunno. Se le condizioni climatiche sono buone, i frutti possono rimanere sui rami fino a gennaio.",

                   ProblemieSoluzioni1 = "Assenza di impollinazione: problemi di spazio possono far optare per la messa a dimora di una sola pianta di kiwi; in questo caso dovrà essere una femmina dotata di un ramo innestato con un esemplare maschile. Non è però una pratica consigliata, in quanto può succedere che errori di potatura o danneggiamenti possono privare la pianta dell’impollinatore.",
                   ProblemieSoluzioni2 = "Mosca della frutta: il parassita più pericoloso e anche l’unico che richieda interventi fitoiatrici. Si manifesta in tutti i mesi estivi e nel frutteto passa da una specie all’altra deponendo le uova in molti frutti, compreso il kiwi in quanto, per un periodo di tempo, è l’unico ad essere ancora sull’albero.",
                   ProblemieSoluzioni3 = "",
                   ProblemieSoluzioni4 = "",
                   ProblemieSoluzioni5 = "",

                   VarietaConsigliate1 = "Allison: frutti poco serbevoli. Matura una decina di giorni prima della Hayward.",
                   VarietaConsigliate2 = "Arguta: allevata come pianta ornamentale. Le nuove varietà hanno frutti dolci, privi di peluria e di colore verde pallido.",
                   VarietaConsigliate3 = "Hayward: è quella maggiormente coltivata: il gusto è leggermente acidulo. La maturazione avviene a metà ottobre.",
                   VarietaConsigliate4 = "Tomuri: varietà maschile utilizzata come impollinatore.",
                   VarietaConsigliate5 = "",
                },

                new Frutteto
                {
                   NomeComunePianta = "LIMONE",
                   NomeFamiglia = "",
                   NomeScientificoPianta = "Citrus limon",
                   FotoPianta = "ms-appx:///Immagini/FRUTTETO/Limone/LIMONE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Storia = "Rispetto agli altri agrumi, il limone è ineguagliabile dal punto di vista nutrizionale e terapeutico. I suoi principi attivi sono contenuti nel succo, astringente e rinfrescante nonché ricchissimo di vitamine, ma anche la scorza è ricca di un’essenza dalle forti proprietà antisettiche. Il limone era usato già nell’antichità contro molte malattie, come lo scorbuto. Fin dal 1500 i limoni di Sorrento erano celebri per la qualità e il sapore: oggi questa varietà è protetta dal marchio IGP.",
                   Caratteristiche = "",
                   Clima = "In zone con inverni freddi non resiste all’aperto. In piena terra può essere coltivato solo dove non c’è rischio di scendere sotto i 2-3 °C.",
                   Terreno = "Ha bisogno di un substrato molto fertile, ricco di sostanza organica. Indispensabile un ottimo drenaggio. ",
                   FormaAllevamento = "Lo sviluppo naturale è da preferire, ma accetta di essere coltivato anche a spalliera o a pergola: quest’ultima è consigliabile solo nei climi miti, per la difficoltà di proteggere la struttura dal gelo. ",
                   Piantagione = " Va fatta in terreno molto fertile. Le piante producono frutti per decenni, sia in piena terra sia in vaso. ",
                   ConcimazioneeIrrigazione = "Concime organico in primavera. In estate e a inizio autunno, concime chimico a lenta cessione. Il limone ha bisogno di molta acqua, avendo un apparato radicale superfi ciale e quindi esposto al rischio di inaridirsi. Essendo una pianta rifiorente, le necessità di irrigazione sono pressoché costanti durante l’anno.",
                   Potatura = "La chioma va mantenuta pulita e sana, liberando il centro per favorire una ricca aerazione. Nel caso dei limoni a spalliera è opportuno potare i rami che escono dalla sagoma e orientare sulla struttura gli steli giovani, piegandoli verso il basso per fermare la vegetazione. ",
                   RaccoltaeConservazione = "Il raccolto migliore è quello invernale, ma essendo una pianta rifiorente è possibile avere frutti anche in estate (limoni Verdelli). Il Femminello siciliano viene raccolto più volte l’anno. Raccogliete i frutti asciutti, senza graffiare la buccia. A livello domestico non è consigliabile la ceratura con additivi alimentari, praticata per migliorarne l’aspetto e la durata. In luogo fresco e umido, i limoni si conservano per circa 5-6 settimane.",

                   ProblemieSoluzioni1 = "Afidi: impiegare infusi a base di ortica o insetticidi biologici.",
                   ProblemieSoluzioni2 = "Clorosi: le foglie sbiadiscono a causa della carenza di ferro. Impiegare un preparato a base di chelati di ferro.",
                   ProblemieSoluzioni3 = "Cocciniglie: ove possibile, eliminare manualmente gli insetti, ai primi segnali di infestazione; spennellare le zone colpite con una soluzione di acqua e sapone di Marsiglia.",
                   ProblemieSoluzioni4 = "",
                   ProblemieSoluzioni5 = "",

                   VarietaConsigliate1 = "A partire dal Rinascimento, i limoni vennero coltivati non solo per le virtù alimentari e terapeutiche, ma anche a scopo ornamentale, in grandi vasi di terracotta. ",
                   VarietaConsigliate2 = "Occorrono contenitori capienti e dotati di perfetto drenaggio: sul fondo del vaso è opportuno stendere uno strato di palline d’argilla. Il rinvaso va fatto con terriccio sciolto; esistono in commercio substrati specifici per agrumi. ",
                   VarietaConsigliate3 = "Durante l’estate, posizionare le piante al sole o in ombra solo nel pomeriggio, in zona non soggetta al vento. In inverno non è possibile conservare i limoni in casa: sopra i 10-12 °C, in ambiente secco, gli esemplari soccombono rapidamente.",
                   VarietaConsigliate4 = "",
                   VarietaConsigliate5 = "",
                },

                new Frutteto
                {
                   NomeComunePianta = "MANDORLO",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Amygdalus communis",
                   FotoPianta = "ms-appx:///Immagini/FRUTTETO/Mandorlo/MANDORLO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Storia = "La sua origine è contesa fra la Cina e i Paesi mediterranei. Furono i Greci a portare la pianta in Sicilia e da lì i Romani ne diffusero la coltivazione in tutta l’Italia meridionale. Columella e Plinio elencano una serie di tecniche per migliorare sia le piante sia la produzione: la più curiosa, già proposta da Teofrasto (IV secolo a. C.) recita che praticando dei buchi ai piedi di una pianta di mandorlo amaro, questo avrebbe prodotto semi dolci. Ancora oggi non è facile distinguere l’albero delle mandorle amare da quello delle dolci, ma in commercio si trova ormai solo quest’ultimo.",
                   Caratteristiche = "Il mandorlo è un albero dall’ampia chioma, con radice fittonante che diventa ampia e fascicolata nei terreni sassosi. Il tronco è contorto e rugoso. Le foglie, simili a quelle del pesco, si riconoscono per l’assenza delle ghiandole basali e per il picciolo più lungo. I fiori sono biancorosati e compaiono prima delle foglie, a fine inverno. In Sicilia, già a gennaio la Valle dei Templi di Agrigento è tutta una fioritura di mandorli. Il frutto, simile ad una pesca, non presenta polpa ma un mallo verde, peloso e carnoso che avvolge un guscio legnoso contenente una o due mandorle, la parte edule della pianta, molto ricca di olio (60%).Il fiore è autosterile: occorre quindi piantare almeno due varietà, con epoca di fioritura simultanea. Le varietà da mandorla amara producono frutti ricchi di amigdalina, glucoside che a contatto con l’acqua si trasforma in acido cianidrico. Bastano pochi frutti per causare avvelenamento. Vengono utilizzate, previo trattamento, solo per l’estrazione dell’olio e la produzione di dolci (amaretti).",
                   Clima = "Adatta a climi temperati, vive bene anche al Nord perché può resisterre ad abbassamenti termici consistenti (anche –20 °C). Il limite produttivo, dato dalla precoce fioritura, può essere superato scegliendo varietà a fi oritura tardiva. Non gradisce elevata umidità atmosferica.",
                   Terreno = "Pianta rustica, per suoli poveri, calcarei, salini ma senza ristagni.",
                   FormaAllevamento = "Nei mandorleti specializzati viene allevato a vaso. Negli orti e giardini conviene la forma naturale, esteticamente pregevole.",
                   Piantagione = "Il mandorlo mal sopporta i trapianti, conviene quindi acquistarlo con il pane di terra o in vaso, oppure innestare a dimora i semenzali. Entra in produzione verso il sesto anno e può produrre fino a 80 anni d’età.",
                   ConcimazioneeIrrigazione = "È pianta per terreni poveri; consigliate concimazioni azotate nel periodo di allevamento e con fertilizzanti ternari (1:3:2) durante la produzione. L’irrigazione è necessaria per avere buone produzioni. Somministrare acqua una decina di giorni prima della raccolta agevola il distacco dei frutti.",
                   Potatura = "Non ama i tagli per cui conviene eliminare solo i rami secchi o deformi ed effettuare leggeri diradamenti. Per migliorare la cicatrizzazione, intervenire a settembre, dopo la raccolta dei frutti.",
                   RaccoltaeConservazione = "La maturazione avviene ad agosto-settembre. Fresche o secche, le mandorle vengono consumate al naturale o trasformate in prodotti dolciari. L’olio di mandorle trova largo impiego in liquoreria, pasticceria e cosmesi.",

                   ProblemieSoluzioni1 = "Gelate primaverili: possono distruggere i fiori compromettendo anche per alcuni anni la produzione. Evitare di piantare in zone fredde o esposte al vento. In caso di freddo tardivo, se possibile conviene coprire la chioma con un velo di tessuto agricolo.",
                   ProblemieSoluzioni2 = "",
                   ProblemieSoluzioni3 = "",
                   ProblemieSoluzioni4 = "",
                   ProblemieSoluzioni5 = "",

                   VarietaConsigliate1 = "Etnea o Etna: frutto morbido, adatto al consumo fresco, molto diffusa in Sicilia.",
                   VarietaConsigliate2 = "Mollese: a nocciolo tenero, con una resa in seme del 50%. Adatta al consumo fresco e alle trasformazioni per pasticceria.",
                   VarietaConsigliate3 = "Pizzuta di Avola: impareggiabile per forma e gusto. Piattissima, ovoidale e regolare, è la più usata per la confetteria e per la preparazione dei dolci tradizionali del Sud.",
                   VarietaConsigliate4 = "",
                   VarietaConsigliate5 = "",
                },


                new Frutteto
                {
                   NomeComunePianta = "MELO",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Malus domestica",
                   FotoPianta = "ms-appx:///Immagini/FRUTTETO/Melo/MELO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Storia = "Il primo frutto citato nella Bibbia ha origini antichissime e tracce di questo albero e dei frutti sono presenti in reperti di epoca preistorica. Nella mitologia pagana, Venere e Apollo tengono spesso una mela in mano quale simbolo erotico. Ancora oggi, in molti Paesi europei la mela è presente nei riti nuziali, assieme a noci e nocciole, a simboleggiare fecondità, prosperità e abbondanza. Di origine europea e transcaucasica, il melo è stato esportato nelle Americhe e in Australia solo intorno al 1600. Oggi, nel mondo, sono coltivate almeno 5.000 diverse varietà, che si distinguono in base all’epoca di maturazione o di raccolta dei frutti (estive, autunnali e invernali), o in base alla destinazione d’uso (consumo fresco, consumo cotto e da sidro).",
                   Caratteristiche = "La pianta è vigorosa, con tronco eretto e chioma globosa. I rami, di colore rossiccio e coperti di lenticelle bianche, si allungano man mano che il fusto cresce. Le foglie sono disposte in modo alterno, hanno forma ovale-appuntita e sono pelose nella pagina inferiore. I fiori spuntano in concomitanza con le foglie, riuniti in mazzetti (corimbi) di 3-8 fiori, con petali bianchi all’interno e rosso-rosati all’esterno. Solitamente la fioritura avviene in aprile, con oscillazioni che variano di anno in anno entro un arco di tempo di circa 10 giorni. Il frutto presenta forma e colori molto variabili. Quasi tutte le varietà di melo sono autosterili e per questo motivo in un piccolo frutteto è buona norma inserire sempre più di una varietà per consentire l’impollinazione incrociata ad opera degli insetti pronubi. Nei filari dei meleti specializzati si usa inserire alcuni esemplari di meli da fiore che forniscono polline utile in abbondanza. Questi meli producono anche frutticini che possono trovare impiego in marmellate e conserve o per puro utilizzo ornamentale.",
                   Clima = "Predilige le zone fredde e umide, anche se è coltivato ovunque; nelle zone calde deve essere allevato a quota di circa 800-1.200 metri.",
                   Terreno = "Adatto ad ogni tipo di terreno, predilige quelli a struttura robusta e compatta purché non troppo umidi; non gradisce l’eccessiva presenza di calcare.",
                   FormaAllevamento = "Può essere allevato in ogni forma. Oggi nei meleti specializzati si preferisce farlo sviluppare a fusetto, per consentire di aumentare considerevolmente il numero di piante per ettaro. Fra le forme obbligate la più usata è la palmetta a branche oblique.",
                   Piantagione = "In commercio si trovano solo piante innestate su portainnesti clonali nanizzanti, che consentono l’allevamento anche in vaso. Il melo va messo a dimora in autunno o in primavera; l’astone di 2-3 anni entra subito in produzione e non deve essere cimato. La durata produttiva è di circa 25-30 anni. Se innestato su franco, il suo sviluppo è considerevole: entra in produzione anche dopo 10 anni ma rimane produttivo fino a 90 anni. ",
                   ConcimazioneeIrrigazione = "Nel periodo produttivo, una pianta di melo asporta dal terreno una notevole quantità di potassio, elemento che presiede alla sintesi degli zuccheri: all’atto della concimazione bisogna quindi orientarsi su prodotti ricchi di questo macroelemento. Solitamente, prima della fioritura o a fine inverno si fornisce un concime complesso ternario, in cui l’azoto è presente sotto forma di nitrato. Una seconda concimazione è consigliabile un mese prima della raccolta. Utilizzando letame ogni anno, a fine inverno, si può ridurre la quantità di concime chimico da fornire nel corso della stagione vegetativa. L’irrigazione va effettuata solo in piena estate, ed è buona norma sospenderla un mese prima della raccolta per evitare di ottenere frutti acquosi. Piccole dosi d’acqua ravvicinate nel tempo favoriscono l’ingrossamento dei frutti. ",
                   Potatura = "Fuso e fusetto richiedono interventi frequenti per mantenere la vegetazione ridotta e compatta. Si effettuano tagli, ma anche piegature, legature e curvature. Le forme libere e semilibere vengono potate in inverno: si effettua il diradamento dei rami, l’eliminazione di succhioni o il loro accorciamento a 3-4 gemme per favorire le formazioni a frutto. ",
                   RaccoltaeConservazione = "La maturazione è scalare; si cominciano a cogliere prima i frutti colorati dal sole. Varietà come la Granny Smith possono restare sull’albero a lungo. Alcune varietà si conservano per mesi e mesi.",

                   ProblemieSoluzioni1 = "Afidi: attaccano i germogli, che si arricciano; trattare con aficida specifico in caso di attacchi massicci.",
                   ProblemieSoluzioni2 = "Carpocapsa: è la nota larva dei frutti (baco). Si combatte con trattamenti ogni 20 giorni a partire dalla comparsa della farfalla. Si utilizzano prevalentemente antiparassitari di sintesi (carbammati).",
                   ProblemieSoluzioni3 = "Cascola preraccolta: fenomeno fisiologico che causa la caduta dei frutti prima della maturazione. Alcune varietà sono più sensibili. Può essere limitato con concimazioni azotate.",
                   ProblemieSoluzioni4 = "Ticchiolatura: malattia grave che colpisce foglie, fiori e frutti, riconoscibile per la presenza di macchie tondeggianti e necrotiche. Sono necessari trattamenti anticrittogamici anche settimanali durante la fase vegetativa e trattamenti invernali a base di rame.",
                   ProblemieSoluzioni5 = "",

                   VarietaConsigliate1 = "Florina: resistente alla ticchiolatura, ha buccia rossa e ottimo sapore. Presenta una certa alternanza di produzione che può essere controllata con la potatura, che dovrà essere moderata nella fase di allevamento e poi equilibrata quando la pianta è in produzione. ",
                   VarietaConsigliate2 = "Granny Smith: vecchia varietà di origine australiana, frutto verde a maturità. Si raccoglie ad ottobre. ",
                   VarietaConsigliate3 = "Golden (gruppo): buccia gialla o rossa, maturazione settembrina, ottima conservazione in atmosfera controllata.",
                   VarietaConsigliate4 = "Mondial Gala: maturazione precoce, fine agosto, buccia rossorosata, frutto di eccellente qualità. ",
                   VarietaConsigliate5 = "Varietà antiche locali: sono numerosissime, spesso tipiche di aree geograﬁ che ristrette. Interessanti nel frutteto familiare se si desiderano sapori insoliti e piante di facilissima cura.",
                },


                new Frutteto
                {
                   NomeComunePianta = "MELOGRANO",
                   NomeFamiglia = "Punicacee",
                   NomeScientificoPianta = "Punica granatum",
                   FotoPianta = "ms-appx:///Immagini/FRUTTETO/Melograno/MELOGRANO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Storia = "«L’albero a cui tendevi la pargoletta mano, il verde melograno dai bei vermigli fior» nel Pianto antico del Carducci il melograno è ammantato di tristezza e malinconia, ma fin dall’antichità questa bella pianta è stata invece simbolo di gioia e fecondità. Salomone fece scolpire i frutti sui capitelli della sua dimora, e Maometto immaginò la pianta in Paradiso, assieme alle palme. «Spicchio di melagrana è la tua guancia dentro il tuo velo», recita lo sposo nel biblico Cantico dei Cantici. La melagrana è un portafortuna prezioso, da consumare nella cena di Capodanno come simbolo di dolcezza e prosperità, affinché l’anno nuovo porti meriti e fortune numerosi quanto i chicchi che contiene. Oggi non viene quasi più coltivato per la produzione dei frutti, ma usato nei giardini e in vaso, per la bellezza dei fi ori e la colorazione autunnale delle foglie. Rientra tra quelle “piante antiche” che richiedono poche cure e producono ottimi frutti.",
                   Caratteristiche = "Originario dell’Asia, è un arbusto o un piccolo albero a portamento decombente, di lento accrescimento e molto longevo, con rami flessibili, spinosi e rosati. Le foglie sono piccole, lanceolate, rosse da giovani poi verdi e, prima di cadere in autunno, giallo-rosse. I fiori, privi di peduncolo, sono rosso vivo, piccoli (più grandi nelle varietà ornamentali) e autofertili: si presentano sulla pianta in continuazione dalla primavera fino ad estate inoltrata. I frutti (detti “balauste”) sono molto voluminosi e a maturità hanno la scorza giallo-rosata. Sono formati da numerosi settori ricchi di semi rivestiti di una polpa carnosa commestibile, leggermente acidula e succosa.",
                   Clima = "Pianta da clima caldo-temperato, sopporta bene il calore estivo e poco il freddo, l’umidità e le piogge, che causano la spaccatura dei frutti prossimi alla maturazione. Va sempre posizionato in pieno sole e nelle zone più fredde conviene proteggere gli esemplari in vaso. ",
                   Terreno = "Deve essere ricco di sostanza organica, fresco, profondo e di medio impasto. Resiste bene al calcare, alla salinità e alla siccità. ",
                   FormaAllevamento = "Ad alberello naturale. Nelle regioni settentrionali, conviene allevare più fusti per premunirsi da morie di singole branche, dovute al gelo. Adatto alla coltivazione in vaso. ",
                   Piantagione = "Si possono mettere a dimora in autunno polloni radicati provenienti da piante con frutti grossi, oppure talee di ramo fatte radicare in vaso o astoni innestati. La produzione inizia intorno al quarto anno e si mantiene in piena produttività anche per 30 anni. ",
                   ConcimazioneeIrrigazione = "Sono di certo consigliabili apporti di letame maturo ogni anno a fine inverno. L’irrigazione deve proseguire in tutto il periodo estivo e deve essere interrotta circa un mese prima della maturazione dei frutti. ",
                   Potatura = "Si devono eliminare tutti i rami terminali che hanno fruttificato. Se allevato ad alberello, conviene asportare tutti i succhioni che spuntano alla base.",
                   RaccoltaeConservazione = "Le melagrane si raccolgono in autunno staccando il frutto con una piccola porzione di ramo che lo sostiene, per non danneggiare la fragile branca.",

                   ProblemieSoluzioni1 = "Non necessita di trattamenti perché è pianta tendenzialmente sana. Eventuali alterazioni alle foglie sono dovute alla ridotta esposizione al sole. ",
                   ProblemieSoluzioni2 = "Caduta precoce del fogliame: se la pianta si spoglia precocemente delle foglie in autunno, la causa è una eccessiva umidità nel terreno e/o nell’atmosfera. Essendo una pianta rustica, con ogni probabilità si riprenderà la primavera successiva.",
                   ProblemieSoluzioni3 = "",
                   ProblemieSoluzioni4 = "",
                   ProblemieSoluzioni5 = "",

                   VarietaConsigliate1 = "Alappia Dolce: varietà dai frutti di ottima qualità. ",
                   VarietaConsigliate2 = "Amara Verace: contrariamente al nome, anche questa produce frutti voluminosi e dolcissimi. ",
                   VarietaConsigliate3 = "Dolce Nostrana: a frutto grosso e semi molto dolci, altamente produttiva, la migliore per avere melagrane grosse e numerose.",
                   VarietaConsigliate4 = "",
                   VarietaConsigliate5 = "",
                },


                new Frutteto
                {
                   NomeComunePianta = "OLIVO",
                   NomeFamiglia = "Oleacee",
                   NomeScientificoPianta = "Olea europaea",
                   FotoPianta = "ms-appx:///Immagini/FRUTTETO/Olivo/OLIVO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Storia = "Ritrovamenti preistorici di noccioli e foglie hanno dimostrato la presenza dell’olivo in varie regioni italiane in epoche lontanissime, quando questo nutriente frutto costituiva già un prezioso alimento per l’uomo. Il mito del ritorno della colomba all’arca di Noè con il ramoscello di olivo in bocca quale simbolo di pace è anch’esso antichissimo. ",
                   Caratteristiche = "Di origine orientale, con foglie sempreverdi, l’olivo presenta radici superficiali ed espanse, chioma a forma conica, tronco cilindrico e contorto di colore grigio scuro con legno duro e pesante. Le foglie sono lanceolate, coriacee, grigiastre, munite di picciolo corto e lembo ricurvo verso il basso. I fiori, piccoli e abbondantissimi, sono in gruppi di 10-15 e formano una infiorescenza a grappolo chiamata “mignola”. Lo sviluppo delle infiorescenze, detto mignolatura, ha inizio verso marzo-aprile e culmina nella fioritura vera e propria, da fine maggio ai primi di giugno. Le varietà più diffuse sono autosterili.",
                   Clima = "L’olivo è pianta tipicamente mediterranea. In Italia è presente in tutte le regioni meridionali, sulle coste anche al Nord ed è diffusa in prossimità dei laghi prealpini, dove il clima è connotato da inverni miti e umidità moderata. L’olivo è caratterizzato da elevato bisogno di illuminazione solare. ",
                   Terreno = "Pianta poco esigente e di grande adattabilità. Predilige suoli sciolti o di medio impasto, freschi e ben drenati, anche calcarei. ",
                   FormaAllevamento = "Tipicamente a vaso o a siepone, ma nei giardini conviene la forma libera, molto bella. Si adatta alla coltivazione in vaso, come ornamentale. ",
                   Piantagione = "Si mettono a dimora gli astoni innestati o i polloni provvisti di radice alla ripresa vegetativa, in marzo. La pianta inizia a fruttifi care verso il terzo-quarto anno, mentre la piena produttività avviene verso il nono-decimo e la maturità è raggiunta dopo i 50 anni. È una pianta longeva: in condizioni favorevoli un olivo può vivere anche mille anni.",
                   ConcimazioneeIrrigazione = "Richiede azoto in abbondanza durante tutta la fase vegetativa. Fosforo e potassio si possono distribuire una volta l’anno in primavera. Carenze idriche prolungate possono provocare cascola dei frutti e bassa produzione. ",
                   Potatura = "Durante la fase di formazione, conviene dare alla pianta una struttura il più aperta possibile. Per infittire i palchi, cimare i rametti nel periodo vegetativo.",
                   RaccoltaeConservazione = "Il frutto viene raccolto percuotendo le fronde (bacchiatura) con pertiche e con l’ausilio di attrezzi a pettine o a rastrello (brucatura). Sono usati anche vibratori meccanici. La raccolta avviene da ottobre fino a tutto dicembre. L’oliva per il consumo da tavola (varietà dette “da mensa”) non è edule alla raccolta: per poter essere consumata deve subire alcuni trattamenti.",

                   ProblemieSoluzioni1 = "Mosca dell’olivo: insetto molto dannoso, compare all’inizio della primavera e in giugno-luglio depone un uovo per frutticino. Le larve si nutrono della polpa, mentre gli adulti ricominciano a ovideporre: si ha un nuovo ciclo ogni 3 settimane. Si combatte con esche avvelenate da distribuire alla comparsa della prima generazione. ",
                   ProblemieSoluzioni2 = "Rogna nera dell’olivo: batterio che penetra attraverso ferite o nelle punture della mosca. Provoca escrescenze tondeggianti e rugose sui giovani rami e sulle branche. Passa anche su altri organi, in particolare i frutti, che si coprono di macchie. Si combatte disinfettando le ferite e gli attrezzi di potatura ed eliminando i rami infetti.",
                   ProblemieSoluzioni3 = "",
                   ProblemieSoluzioni4 = "",
                   ProblemieSoluzioni5 = "",

                   VarietaConsigliate1 = "Ascolana tenera: oliva da mensa, portamento assurgente. Frutti di dimensioni medie, polpa tenera e gustosa. ",
                   VarietaConsigliate2 = "Frantoio: olivo da olio, precoce messa a frutto. Molto diffusa. La pianta è di medio vigore; presenta un portamento pendulo. ",
                   VarietaConsigliate3 = "Leccino: olivo da olio, mediamente resistente ai parassiti. Produzione precoce, contemporaneità di maturazione. Pianta vigorosa, con portamento a rami penduli.",
                   VarietaConsigliate4 = "",
                   VarietaConsigliate5 = "",            
                },


                new Frutteto
                {
                   NomeComunePianta = "PERO",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Pyrus communis",
                   FotoPianta = "ms-appx:///Immagini/FRUTTETO/Pero/PERO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Storia = "Pianta coltivata da epoche lontane, pare sia di origine asiatica. Omero, nel libro VII dell’Odissea, così descrive i famosi giardini di Alcinoo: «Alte vi crescon verdeggianti piante, il pero e il melograno». L’amore per questi frutti da parte dei Reali di Francia ha dato origine nel Cinquecento a una famosa scuola nei giardini di Versailles, dove appositi poiriers selezionavano le varietà migliori e ne creavano di nuove per la mensa del Re. E ancora oggi molte delle varietà coltivate hanno origine in Francia, dove il frutto ha larghissima diffusione tanto nelle campagne come negli orti e giardini famigliari; vi sono varietà specifiche da cuocere, da sidro, da confettare o sciroppare. Accusata per secoli di causare pesantezza e di essere indigesta, la pera ben matura è oggi considerata da tutti un tesoro di aromi e di freschezza per il palato.",
                   Caratteristiche = "Il pero è un albero dalla chioma conica; sul tronco la corteccia è grigiastra e si fessura facilmente. Il legno è utilizzato in ebanisteria, apprezzato per il suo colore bianco rosato e la grana fine. Le foglie, verde brillante e glabre, sono ovali, lungamente picciolate. Alla base delle foglie si trovano due stipole che cadono al germogliamento. Fiorisce prevalentemente all’estremità dei rami, con numerosi fiori bianchi riuniti in corimbi avvolti da un mazzetto di foglie. I fiori si aprono verso la fine di marzo e la fioritura si prolunga per anche 20 giorni. Ciò rappresenta un limite per la coltivazione, perché nelle zone più fredde possono facilmente essere esposte a gelate e brinate. Le varietà più coltivate sono autosterili. Il frutto varia di aspetto, colore e forma a seconda della varietà. Quelle antiche sono di pezzatura più piccola, ma non per questo di minore pregio dal punto di vista del sapore, spesso eccellente.",
                   Clima = "Predilige areali temperati, anche se numerose varietà sono presenti in zone più fredde. Quando le temperature sono elevate e il clima è siccitoso meglio orientarsi su varietà a maturazione precoce.",
                   Terreno = "Soffre nei terreni siccitosi e dove si verifica ristagno di acqua. Quando è innestato su cotogno non deve essere coltivato in terreni calcarei.",
                   FormaAllevamento = "Sopporta benissimo i tagli e le manipolazioni, quindi possono essere usate forme appiattite come la palmetta, il cordone orizzontale, verticale o obliquo, la ipsilon. L’enorme vigore che manifesta nei terreni fertili consiglia di non utilizzare la piramide e il vaso. Su portainnesti nanizzanti, il pero può essere coltivato su balconi o terrazzi, purché in contenitore piuttosto ampio.",
                   Piantagione = "La messa a dimora degli astoni innestati si effettua in autunno. Innestati su cotogno o su clonali, i peri entrano in produzione precocemente e producono per 30-40 anni. Su franco, la produzione dura anche 80 anni, ma l’entrata in produzione è tardiva. Sul filare la distanza è 1,5-2 m, mentre tra le file aumenta leggermente. A causa della diffusa autosterilità tra le cultivar, conviene mettere a dimora almeno due varietà diverse. ",
                   ConcimazioneeIrrigazione = "Ogni 2 anni, dopo la piantagione, si può concimare con letame maturo, integrando con concimi chimici a base di azoto, fosforo e potassio in proporzione di 1:3:3. Le irrigazioni estive devono essere di portata limitata ma frequenti. Nei terreni di medio impasto e fertili non sono necessarie. ",
                   Potatura = "Le varietà poco produttive (Abate Fetel e Passa Crassana) preferiscono l’accorciamento dei rami e l’eliminazione di alcune formazioni a frutto, mentre le altre (Butirre, Cosce, Decane, Kaiser, William) preferiscono il diradamento dei rami. ",
                   RaccoltaeConservazione = "Dopo la raccolta le pere vanno conservate al fresco. Alcune varietà invernali, che vengono raccolte a fine ottobre, contengono nella polpa alcune formazioni (sclereidi) che rendono il frutto praticamente immangiabile. Conservate in cantina, al raggiungimento della maturazione fisiologica (anche marzo-aprile) le formazioni si ammorbidiscono e scompaiono, rendendo il frutto morbido e succoso.",

                   ProblemieSoluzioni1 = "Psilla del pero: l’adulto punge le parti più giovani di ogni organo, mentre le forme giovanili rilasciano abbondante melata che imbratta e porta all’asfissia i tessuti vegetali già danneggiati. Nel frutteto famigliare conviene lavare con getti d’acqua, anche violenti, le parti che manifestano presenza di melata. ",
                   ProblemieSoluzioni2 = "Ticchiolatura: è la malattia più grave e virulenta. Conviene praticare sempre un trattamento preventivo nella fase di prefioritura con prodotti a base di rame (poltiglia bordolese) e poi, al presentarsi dei sintomi, con prodotti citotropici.",
                   ProblemieSoluzioni3 = "",
                   ProblemieSoluzioni4 = "",
                   ProblemieSoluzioni5 = "",

                   VarietaConsigliate1 = "Abate Fetel: molto apprezzata per la forma e il sapore. Presenta difformità di produzione ed è autoincompatibile. Matura all’inizio di settembre. ",
                   VarietaConsigliate2 = "Decana d’Inverno: voluminosa, di colore verde e di buone caratteristiche, si raccoglie a fine ottobre e matura lentamente, conservandosi a lungo. ",
                   VarietaConsigliate3 = "Kaiser Alexander: frutto dalla buccia rugginosa, è una vecchia e pregevole cultivar. Matura a fine settembre. ",
                   VarietaConsigliate4 = "Passa Crassana: per decenni è stata la pera regina dell’inverno, a maturazione completa si presenta succosa e dolce. Praticamente autoincompatibile.",
                   VarietaConsigliate5 = "William Rossa o Gialla: il frutto è adatto sia al consumo fresco sia alla produzione di pere sciroppate. Ottima per gusto e sapore, matura in agosto.",
                },


                new Frutteto
                {
                   NomeComunePianta = "PESCO",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Persica vulgaris, P. laevis",
                   FotoPianta = "ms-appx:///Immagini/FRUTTETO/Pesco/PESCO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Storia = "Persica significa «proveniente dalla Persia», ma l’origine del pesco è sicuramente la Cina, dove viene coltivato da millenni. Ad Alessandro Magno va il merito di averlo portato nel mondo greco-romano e ai Romani quello di averlo diffuso in tutta l’Europa. ",
                   Caratteristiche = "È una specie di dimensioni mediopiccole, con foglie lanceolate a margine dentellato e provviste di un corto picciolo. Le foglie si inseriscono in modo alterno sui rametti inizialmente verdi poi rossastri, che diventano legnosi negli anni. I fiori, rosa, si presentano prima delle foglie, in marzo-aprile, singoli o riuniti in gruppi di 3-4. Le varietà coltivate sono quasi tutte autofertili. Il frutto è una drupa sferica che presenta forma, colore di buccia, polpa e dimensioni differenti a seconda della varietà. La pesca classica ha la buccia rivestita da una fitta peluria, le nettarine o pesche noci sono invece glabre. La polpa, bianca o gialla, è soda e morbida nei frutti da consumo fresco, più consistente e a tessitura fine nelle pesche dette percoche o duracine, utilizzate per le trasformazioni industriali (pesche sciroppate e succhi). Commercialmente, le pesche sono classificate in funzione del periodo di raccolta, che va dalla fine di maggio a quasi tutto settembre.",
                   Clima = "Preferisce il clima mite, ma nelle zone mediterranee molto calde occorre scegliere le varietà con basso fabbisogno in freddo. Per fiorire e fruttifi care, infatti, le piante necessitano di un elevato numero di ore di freddo (sotto i 7 °C). ",
                   Terreno = "Vive bene solo nei suoli sciolti, profondi, anche sassosi. Non sopporta quelli umidi e argillosi. Resiste al calcare se innestato su mandorlo. La pianta muore su terreni in cui precedentemente sono stati coltivati altri peschi (negli anni provocano un accumulo di tossine nel suolo). ",
                   FormaAllevamento = "Oggi si tende ad allevare il pesco basso, a vaso o a palmetta, per facilitare la raccolta senza scale. Anche nelle forme semilibere si tende ad abbassare la vegetazione. ",
                   Piantagione = "Si esegue in autunno, impiegando astoni innestati di 2 anni: già nella primavera successiva inizia la produzione che prosegue per circa 20 anni. Il pesco può essere coltivato in vaso. ",
                   ConcimazioneeIrrigazione = "Gradisce concimazioni azotate (il rapporto NPK è sempre 2:1:1). Si distribuisce in inverno un concime ternario e in primavera si integra con altro azoto. L’irrigazione è importante nel mese che precede la raccolta dei frutti: le dosi, abbondanti, vanno distribuite a intervalli di 10 giorni. ",
                   Potatura = "In produzione devono essere energiche. Con l’invecchiamento, infatti, la pianta tende a spostare la vegetazione verso l’alto, e quindi sono necessari frequenti tagli di ritorno. Il diradamento dei frutticini in estate dà luogo a frutti più grossi. ",
                   RaccoltaeConservazione = "Per ritardare la raccolta delle varietà tardive si può effettuare l’insacchettatura dei singoli frutti ancora acerbi, quando hanno raggiunto le dimensioni definitive. Un vantaggio di questa pratica è la certezza che i frutti non si ammaleranno e non serviranno trattamenti antiparassitari.",

                   ProblemieSoluzioni1 = "Bolla del pesco: è la malattia più diffusa nelle regioni settentrionali con primavera umida. Si riconosce per le strane e rosate bollosità sulle foglie, che poi cadono. Con l’aumento della temperatura la malattia scompare. Si combatte con due trattamenti invernali a base di prodotti rameici.",
                   ProblemieSoluzioni2 = "",
                   ProblemieSoluzioni3 = "",
                   ProblemieSoluzioni4 = "",
                   ProblemieSoluzioni5 = "",

                   VarietaConsigliate1 = "Andross: percoca vigorosa e produttiva, matura nel mese di agosto. ",
                   VarietaConsigliate2 = "Maria Elisa: nettarina gialla di origine italiana, con vigoria e produttività molto elevate. La pezzatura è medio-grossa e la polpa è gialla venata di rosso.",
                   VarietaConsigliate3 = "Redhaven: la più diffusa, a polpa gialla; matura a luglio. ",
                   VarietaConsigliate4 = "Springcrest: grossa, a polpa gialla, matura a giugno. ",
                   VarietaConsigliate5 = "White Crest: a polpa bianca. Vigore medio, produttività discreta, frutto molto profumato.",
                },


                new Frutteto
                {
                   NomeComunePianta = "SUSINO CINOGIAPPONESE",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Prunus salicina o triflora (giapponese), P. simonii (cinese)",
                   FotoPianta = "ms-appx:///Immagini/FRUTTETO/Susino Cinogiapponese/SUSINO CINOGIAPPONESE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Storia = "Le varietà coltivate in Italia provengono quasi tutte dall’incrocio della specie giapponese con quella cinese, che si coltivano comunque anche singolarmente. ",
                   Caratteristiche = "Fruttiferi di medie dimensioni, con chioma ombrelliforme e rami tendenti al pendulo. Le foglie sono di forma allungata, lanceolate, sottili e poco consistenti. I fiori sono riuniti in mazzetti di tre e si aprono a marzo-aprile, prima di quelli di pesco e susino europeo: sono presenti soprattutto sui rami misti e compaiono prima delle foglie. Sono autosterili, necessitano perciò della presenza o della vicinanza di altre piante di susino. Il frutto è tondeggiante, mediamente piccolo, molto succoso, con il nocciolo aderente alla polpa. Sono tutte varietà adatte al solo consumo fresco in quanto difficili da conservare o trasformare. La produzione del susino cinogiapponese è abbondante e il periodo di maturazione è compreso tra la metà di giugno e la fine di ottobre, a differenza di quello europeo che dà raccolto tra agosto e settembre. Nei primi anni in un orto familiare una pianta di susino cinogiapponese arriva a produrre 4-5 kg di frutti: non è raro trovare esemplari adulti che producono anche oltre 200 kg per pianta.",
                   Clima = "Prediligono un clima caldo e nelle zone temperate più fredde presentano problemi divenendo scarsamente o instabilmente produttive, nonché più suscettibili ad alcune malattie. La fioritura precoce induce nella pianta una minor resistenza al freddo e alle gelate tardive.",
                   Terreno = "Di medio impasto, tendenti allo sciolto. Si adatta a quelli compatti solo se inserito su portinnesti adatti. ",
                   FormaAllevamento = "Negli orti famigliari si usa la forma libera. Può essere anche allevato a vaso o in forme obbligate come palmette e cordoni.",
                   Piantagione = "Si mettono a dimora in autunno. Nelle regioni settentrionali è preferibile aspettare l’inizio primavera per evitare che un inverno troppo freddo danneggi il giovane astone.",
                   ConcimazioneeIrrigazione = "Nei giardini cresce e produce con una semplice letamazione annuale. Le concimazioni chimiche, se necessarie, si effettuano una volta all’anno prima della ripresa vegetativa. L’irrigazione è fondamentale nei periodi di fioritura, allegagione e accrescimento del frutto, per garantirne il giusto sviluppo.",
                   Potatura = "Gli esemplari di susino cinogiapponese richiedono interventi decisi ed energici nella fase di produzione: è necessario diradare i rami produttivi durante la potatura invernale. Se non si è molto esperti, si può potare anche in fase di fioritura. Durante l’estate sarà poi necessario eliminare i vigorosi succhioninati in corrispondenza dei tagli, lasciandone di norma uno solo. ",
                   RaccoltaeConservazione = "La maturazione delle susine è scalare e la raccolta dalla pianta si esaurisce nell’arco di 2 settimane o poco più. Alcune cultivar, come Angeleno, a frutto grosso, possono essere conservate per circa 2 mesi in ambiente fresco, se raccolte non ben mature: il processo avviene anche quando il frutto è staccato dalla pianta. ",

                   ProblemieSoluzioni1 = "Batteriosi: il cancro e la maculatura delle drupacee sono patologie batteriche gravi, riconoscibili per le estese aree decolorate sui rami; causano alterazioni sui frutti e li portano alla marcescenza. Favoriscono inoltre l’avvento di altri patogeni. Asportare rami e frutti colpiti, non farli entrare in contatto con piante anche ornamentali.",
                   ProblemieSoluzioni2 = "",
                   ProblemieSoluzioni3 = "",
                   ProblemieSoluzioni4 = "",
                   ProblemieSoluzioni5 = "",

                   VarietaConsigliate1 = "Angeleno: è la cultivar più diffusa ed è impollinata con successo dalle successive varietà. Il frutto è grosso e violaceo, di eccellente qualità. ",
                   VarietaConsigliate2 = "Sorriso di Primavera: di fruttiﬁ cazione precoce, offre abbondanti frutti di colore giallo rosato. Cultivar autoincompatibile. Ottimo impollinatore.",
                   VarietaConsigliate3 = "",
                   VarietaConsigliate4 = "",
                   VarietaConsigliate5 = "",
                },


                new Frutteto
                {
                   NomeComunePianta = "SUSINO EUROPEO (PRUGNO)",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Prunus domestica",
                   FotoPianta = "ms-appx:///Immagini/FRUTTETO/Susino Europeo/SUSINO EUROPEO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Storia = "La coltivazione del susino in Europa risale a più di 2.000 anni fa e ancora oggi ha grande diffusione; molte sono le specie spontanee presenti nei nostri boschi. Le prugne sono da sempre considerate ottime contro la stitichezza: già la Scuola Medica Salernitana reputava che i frutti fossero “rinfrescanti e lassativi”. ",
                   Caratteristiche = "Albero di medio sviluppo, il prugno ha rami eretti e colorazione della corteccia grigio-rossastra. Le foglie sono ovali, pelose nella pagina inferiore, di consistenza coriacea. I fiori, riuniti in mazzetti di due, si aprono prima dell’emissione delle foglie. Quasi tutte le varietà sono autofertili, ciò consente la coltivazione anche di un esemplare isolato. Il colore dei frutti varia a seconda delle varietà, dal verde al giallo, al rosso, al viola bluastro, mentre la forma è oblunga-ovoidale e il nocciolo si stacca facilmente dalla polpa. Numerose sono le varietà, alcune adatte al consumo fresco, altre all’essiccamento, alla produzione di confetture e alla distillazione per liquori. ",
                   Clima = "Coltivato in tutte le regioni italiane, predilige il clima temperato ma sopporta bene il freddo: la sua diffusione si spinge fino ai Paesi del Nord Europa. ",
                   Terreno = "Fresco, di medio impasto e possibilmente irriguo anche se le radici temono i ristagni di acqua. Resiste bene anche nei suoli argillosi o compatti.",
                   FormaAllevamento = "Lo sviluppo limitato (3-5 m) consente l’allevamento anche in forma libera. Nei frutteti specializzati si utilizza il vaso o la palmetta, con distanze fra le piante di 5-7 metri. ",
                   Piantagione = "Si utilizzano piante innestate su Prunus a portamento basso, come il Mirabolano, o portinnesti clonali che si adattano a climi e terreni diversi e già al secondo anno dall’impianto entrano in produzione. Nei primi anni le piante danno poco; solo dopo il sesto anno la produzione diventa abbondante e costante: la durata dell’impianto è di circa 20 anni. ",
                   ConcimazioneeIrrigazione = "Si concima nel periodo di riposo invernale somministrando concimi semplici o complessi: circa 1,5 kg di prodotto per pianta all’anno con un rapporto NPK di 2:1:1. La concimazione organica con letame si effettua ogni 2 o 3 anni. Frequenti irrigazioni consentono un buon ingrossamento dei frutti: nelle zone temperate vanno effettuate prima della maturazione, ogni 20-30 giorni se la stagione è siccitosa. Dopo la fruttificazione si deve irrigare solo raramente. Interventi sono necessari sulle giovani piante per impostare la forma di allevamento. Durante la fase produttiva richiede una potatura leggera, diradamento dei rami mal orientati e tagli all’interno della chioma. Si interviene nel periodo di riposo invernale, quando il freddo è meno intenso. In estate è consigliabile la potatura verde, che si effettua asportando o raccorciando i rami troppo sviluppati. Negli anni di massima produzione, può essere necessario il diradamento dei frutti sui rami.",
                   Potatura = "Interventi sono necessari sulle giovani piante per impostare la forma di allevamento. Durante la fase produttiva richiede una potatura leggera, diradamento dei rami mal orientati e tagli all’interno della chioma. Si interviene nel periodo di riposo invernale, quando il freddo è meno intenso. In estate è consigliabile la potatura verde, che si effettua asportando o raccorciando i rami troppo sviluppati. Negli anni di massima produzione, può essere necessario il diradamento dei frutti sui rami.",
                   RaccoltaeConservazione = "",

                   ProblemieSoluzioni1 = "Afidi e cocciniglie: i primi si presentano sulle parti terminali dei germogli, mentre le seconde si distribuiscono su tronchi e rami. Si combattono in inverno con trattamenti a base di oli bianchi e polisolfuri, d’estate con aﬁ cidi specifici. ",
                   ProblemieSoluzioni2 = "Mosca della frutta: depone le uova sui frutti e sulle foglie, e causa la caduta precoce dei frutticini quando la larva è penetrata verso il seme. Si interviene al bisogno con trattamenti a base di prodotti fosforganici (rimedio efficace anche contro le tignole). ",
                   ProblemieSoluzioni3 = "Tignole: si nutrono di gemme producendo ragnatele sui germogli.",
                   ProblemieSoluzioni4 = "",
                   ProblemieSoluzioni5 = "",

                   VarietaConsigliate1 = "Bluefre: per essiccamento. Autofertile, matura in agosto. ",
                   VarietaConsigliate2 = "Regina Claudia (gialla e verde): varietà antiche, maturano a fine agosto; molto produttive, frutti di eccellente qualità. ",
                   VarietaConsigliate3 = "Ruth Gestetter: varietà antica (1927) molto precoce, presenta frutto rosso bluastro scuro. È una varietà autosterile. ",
                   VarietaConsigliate4 = "Stanley: varietà tardiva (settembre) e autofertile. I frutti violacei si adattano bene anche all’essiccamento.",
                   VarietaConsigliate5 = "",
                },


                new Frutteto
                {
                   NomeComunePianta = "UVA DA TAVOLA",
                   NomeFamiglia = "Vitacee",
                   NomeScientificoPianta = "Vitis vinifera",
                   FotoPianta = "ms-appx:///Immagini/FRUTTETO/Uva da Tavola/UVA DA TAVOLA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Storia = "Narra la Bibbia, “Genesi” 9,20, che «Noè uscito dall’Arca cominciò a far l’agricoltore e piantò una vigna». Secondo i paleontologi la presenza della vite è accertata sulla Terra prima della comparsa dell’uomo. Comunque sia, la vite e i suoi frutti sono entrati a far parte della storia dell’uomo non solo come alimento, ma anche come simbolo religioso e culturale. Inizialmente si trattava di piante destinate alla produzione di vino, ma già i Romani utilizzavano le varietà più dolci e ad acino grosso per il consumo fresco (Verdea, Moscati). ",
                   Caratteristiche = "La vite è un arbusto a rami flessibili, con foglie (pampini) grandi e a 5 punte. I fiori, riuniti in grappoli, si presentano alla metà di maggio. I frutti sono bacche di colore, forma e dimensioni estremamente diverse. Dopo la diffusione della fillossera, che distrusse in pochi anni la viticoltura di tutti i Paesi europei, la vite si alleva innestata su “piede americano”, resistente al parassita. Da quel momento (fine Ottocento) è iniziata la coltivazione dei cosiddetti ibridi produttori diretti, incrocio fra viti europee e americane, adatte alla produzione di un leggero vinello (fragolino) e al consumo fresco. ",
                   Clima = "Le molte varietà e i portainnesti consentono alla vite di adattarsi ad ogni fascia climatica, purché in pieno sole. ",
                   Terreno = "Innestata su portainnesti idonei, si adatta a qualsiasi tipo e composizione di terreno, da quelli asfittici a quelli a elevato tenore di calcare attivo. ",
                   FormaAllevamento = "Quella più tipica è il tendone, ma in giardini e orti spesso si preferiscono la pergola o gli alberelli, adatti anche alla coltura in vaso. ",
                   Piantagione = "Le barbatelle di 2 anni, poste a dimora in autunno, nell’estate successiva danno già i primi grappoli. La durata in produzione si aggira sui 40 anni, ma non è raro trovare pergolati più vecchi. ",
                   ConcimazioneeIrrigazione = "La produzione ottenibile (anche 1.000 q/ettaro) richiede abbondante concime ternario, in primavera e in autunno. L’ingrossamento degli acini richiede dosi crescenti di acqua a partire dal momento della fioritura. Si devono sospendere poi le irrigazioni 15 giorni prima della raccolta per evitare la spaccatura degli acini. ",
                   Potatura = "Produce sui rami dell’anno. Negli alberelli è bene lasciare 3-4 gemme per tralcio: sui germogli, a partire dal quarto-quinto nodo, si formeranno grappoli di fiori. Nelle coltivazioni a tendone e a pergola è necessario mantenere uno o più tralci permanenti per favorire lo sviluppo della vegetazione. Potare in autunno o a fine inverno, per non incorrere nel fenomeno del “pianto” (abbondante fuoriuscita di linfa dai tagli). ",
                   RaccoltaeConservazione = "I grappoli si raccolgono da agosto fino ai primi di ottobre, secondo le varietà. L’uva da tavola va raccolta con le forbici, lasciando un pezzo del tralcio.",

                   ProblemieSoluzioni1 = "Malattie classiche: trattamenti periodici e preventivi sono necessari contro la peronospora, l’oidio e la botrite. Si utilizzano rispettivamente prodotti rameici, zolfo e antibotritici specifici. ",
                   ProblemieSoluzioni2 = "Nuovi problemi: flavescenza dorata e mal dell’esca sono patologie che si sono diffuse negli ultimi anni. Entrambe non sono curabili: unico rimedio è l’asportazione delle piante colpite. La flavescenza dorata fa assumere alla pianta un aspetto incurvato, l’attività vegetativa si blocca, le foglie si arrotolano e ingialliscono. Il mal dell’esca colpisce foglie, grappoli e rami, che degenerano velocemente. È necessario, dopo aver asportato le piante, disinfettare il terreno e ripiantare solo nuovi esemplari di provenienza sicura.",
                   ProblemieSoluzioni3 = "",
                   ProblemieSoluzioni4 = "",
                   ProblemieSoluzioni5 = "",

                   VarietaConsigliate1 = "Fragola Bianca e Nera: detta anche “uva americana”. In quanto ibrido produttore diretto, non richiede trattamenti e attira poco le vespe. Acini profumatissimi. ",
                   VarietaConsigliate2 = "Regina: con questo nome si raggruppano diverse varietà (Regina Nera, di Firenze, dei Vigneti…), tutte con acini gialli o neri, grossi e dolci, che maturano in agosto-settembre. ",
                   VarietaConsigliate3 = "Moscato: d’Adda, d’Amburgo, di Terracina, rispettivamente viola, nero e giallo. Maturano in settembre con acini medi molto dolci. Di questo gruppo esistono molte altre varietà.",
                   VarietaConsigliate4 = "",
                   VarietaConsigliate5 = "",
                },


                


 

            };

            return data;
        }

        // TODO WTS: Remove this once your MasterDetail pages are displaying real data
        public static async Task<IEnumerable<Frutteto>> GetSampleModelDataAsync()
        {
            await Task.CompletedTask;

            return AllFrutteto();
        }


    }
}
