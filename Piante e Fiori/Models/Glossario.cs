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

    public class Glossario
    {
        public string NomeTermine { get; set; }
        public string DefinizioneTermine { get; set; }
       

    }

    public static class GlossarioDataService
    {
        private static IEnumerable<Glossario> AllGlossario()
        {
            // The following is order summary data
            var data = new ObservableCollection<Glossario>
            {
                //LETTERA A
                new Glossario
                {
                   NomeTermine = "ACAULE",
                   DefinizioneTermine = "La pianta che ha uno stelo poco sviluppato, che quasi non si vede."
                },
                
                new Glossario
                {
                   NomeTermine = "ACCESTIMENTO, ACCESTIRE ",
                   DefinizioneTermine = "Modalità di accrescimento tipica delle graminacee del tappeto erboso e di altre erbacee perenni. Consiste nella formazione di uno o più culmi (fusti), secondari, terziari ecc., a partire dal culmo principale primario, formando un cespuglio largo e compatto."
                },

                new Glossario
                {
                   NomeTermine = "ACHENIO",
                   DefinizioneTermine = "Frutto secco indeiscente munito di pericarpo sottile racchiudente un unico seme."
                },

               new Glossario
                {
                   NomeTermine = "ACQUA DECALCIFICATA ",
                   DefinizioneTermine = "Acqua sottoposta a bollitura o a riposo per 2-3 giorni, nell’innafﬁ atoio o in un secchio, afﬁ nché si riduca la percentuale di calcare prima di usarla (lasciando sul fondo il deposito) per innafﬁ are le piante. L’acqua proveniente da impianti idraulici dotati di addolcitore presenta una signiﬁ cativa diminuzione delle percentuali di calcio e magnesio."
                },

               new Glossario
                {
                   NomeTermine = "AFIDI",
                   DefinizioneTermine = "Detti anche “pidocchi delle piante”, sono insetti appartenenti a diverse specie, di colore giallo, verde, grigio o nero, che per nutrirsi pungono e succhiano, deformandoli e arrestandone la crescita, i giovani germogli, le foglioline, i boccioli e i frutti. Possono trasmettere pericolosi virus vegetali, e quindi vanno combattuti ﬁ n dal loro primo apparire."
                },

               new Glossario
                {
                   NomeTermine = "AGHI",
                   DefinizioneTermine = "Foglie trasformate, tipiche delle conifere, divenute strettissime a causa della fortissima riduzione della lamina fogliare, avvenuta anche per minimizzare la superﬁ cie d’appoggio offerta alla neve. La cuticola è ispessita, conferendo l’aspetto rigido all’ago, per resistere meglio al freddo. Gli aghi rimangono sulla pianta per circa 3-4 anni, dopodiché, durante la stagione vegetativa, vengono rinnovati man mano."
                },

               new Glossario
                {
                   NomeTermine = "AGRICOLTURA BIODINAMICA",
                   DefinizioneTermine = "Metodo di coltura che vieta l’impiego dei prodotti chimici di sintesi, limitando anche quelli permessi in agricoltura biologica; segue la ﬁ losoﬁ a steineriana (da Rudolf Steiner, Lezioni di agricoltura, 1924) che vede il cielo e la terra (con le costellazioni, i minerali, le piante e gli animali) come un unico organismo vivente. L’agricoltore biodinamico incrementa la fertilità del terreno seguendone le leggi naturali. Gli allevamenti, i campi, i prati e i boschi vengono curati allo stesso livello. L’azienda produce da sé i concimi, i preparati biodinamici, le sementi e il bestiame, in un ciclo chiuso che mira all’autosufﬁ cienza. "
                },

                new Glossario
                {
                   NomeTermine = "AGRICOLTURA BIOLOGICA",
                   DefinizioneTermine = "Metodo di coltura che vieta l’impiego di prodotti chimici di sintesi, sostituiti con prodotti di origine naturale per la lotta e la difesa in determinati periodi. Si avvale della prevenzione degli agenti patogeni (monitoraggio mediante trappole), delle rotazioni (ogni anno una specie diversa sullo stesso terreno), della diversiﬁ cazione colturale (più specie coltivate in appezzamenti vicini) e della consociazione (più specie coltivate nello stesso appezzamento). Favorisce la ricostituzione di ambienti seminaturali, con la piantagione di alberi e siepi. Ha una resa per ettaro inferiore a quella dell’agricoltura tradizionale. I prodotti biologici devono essere certiﬁ cati da un Organismo di controllo autorizzato dal Ministero dell’agricoltura."
                },

                new Glossario
                {
                   NomeTermine = "AGRICOLTURA INTEGRATA",
                   DefinizioneTermine = "Pratica agricola che mira a un razionale impiego di prodotti di sintesi, utilizzati solo in caso estremo e sostituiti, ove possibile, da prodotti e mezzi biologici di lotta e di concimazione."
                },

                new Glossario
                {
                   NomeTermine = "AGRICOLTURA TRADIZIONALE",
                   DefinizioneTermine = "Pratica agricola che prevede l’impiego di prodotti di sintesi, di origine chimica, sia per la concimazione che per la difesa ﬁ tosanitaria. Sui prodotti ottenuti da agricoltura tradizionale vengono effettuati controlli casuali presso i mercati ortofrutticoli per accertare una presenza di residui di ﬁ tofarmaci entro i limiti consentiti dalla legge."
                },

                new Glossario
                {
                   NomeTermine = "ALBURNO",
                   DefinizioneTermine = "La parte più esterna del cilindro centrale del tronco. Contiene i fasci vascolari che conducono la linfa grezza verso il fogliame, ove avverrà la fotosintesi."
                },

                new Glossario
                {
                   NomeTermine = "ALLEGAGIONE",
                   DefinizioneTermine = "La fase, successiva all’impollinazione del fiore e alla fecondazione dell’ovulo, che dà luogo alla trasformazione dell’ovario ﬁ orale in frutto (inizialmente chiamato “frutticino”)."
                },

                new Glossario
                {
                   NomeTermine = "ALLELOPATIA",
                   DefinizioneTermine = "Emissione, da parte delle radici o delle foglie delle piante, di sostanze che impediscono la nascita di altre piante della stessa specie in un raggio proporzionale alle dimensioni dell’apparato radicale. Fra le più note piante allelopatiche, il noce e la salvia, che crescono solitamente in singoli esemplari isolati, proprio perché le loro radici producono sostanze che inibiscono la germinazione di semi della medesima specie nel terreno limitrofo."
                },

                new Glossario
                {
                   NomeTermine = "ALLOCTONO",
                   DefinizioneTermine = "Non originario della zona in cui l’organismo vive ed è diffuso; vi è stato introdotto dagli animali o dall’uomo."
                },

                new Glossario
                {
                   NomeTermine = "ALTERNANZA DI PRODUZIONE",
                   DefinizioneTermine = "Fenomeno per cui l’albero da frutto alterna un anno in cui la produzione dei frutti è insufﬁ ciente a uno in cui i frutti prodotti sono tanti, di piccola pezzatura. Le cause che concorrono a determinare questo fenomeno sono molteplici: caratteristiche varietali, anomalo andamento stagionale, potature errate, concimazioni squilibrate soprattutto riguardo all’azoto. Per esempio, nel melo le cultivar soggette ad alternanza sono ‘Renetta del Canada’, ‘Imperatore’ e ‘Golden Delicious’."
                },

                new Glossario
                {
                   NomeTermine = "AMENTO",
                   DefinizioneTermine = "Inﬁ orescenza a spiga, pendula e ﬂ essibile al vento, formata dai minuscoli ﬁ ori, generalmente maschili ma talora anche femminili, privi di peduncolo, cioè sessili, direttamente attaccati all’asse ﬁ orale portante."
                },

                new Glossario
                {
                   NomeTermine = "AMMENDAMENTO, AMMENDANTE",
                   DefinizioneTermine = "Aggiunta al terreno di sostanze di varia natura (organica e inorganica) per migliorarne la struttura (granulometria, porosità, tessitura ecc.) e per alleggerire la struttura del suolo, favorendo così l’aerazione e la permeabilità dello stesso."
                },

                new Glossario
                {
                   NomeTermine = "AMPIO SPETTRO",
                   DefinizioneTermine = "Sostanza o prodotto non speciﬁ co, in grado cioè di agire contro un’ampia gamma di funghi patogeni o di parassiti animali, anziché contro uno solo."
                },

                new Glossario
                {
                   NomeTermine = "ANEMOFILA",
                   DefinizioneTermine = "Impollinazione che avviene mediante il vento che trasporta i minuscoli e leggerissimi granuli pollinici, nella speranza di incontrare gli ovari femminili."
                },

                new Glossario
                {
                   NomeTermine = "ANTOCIANI",
                   DefinizioneTermine = "Pigmenti coloranti nelle tinte comprese fra il rosso e il viola, tipici dei vegetali. Li troviamo nelle foglie verdi (visibili solo in autunno) e nei frutti."
                },

                new Glossario
                {
                   NomeTermine = "ARIEGGIATURA",
                   DefinizioneTermine = "Pratica di miglioramento del terreno nel tappeto erboso, in varie forme, per consentire il passaggio di aria nel terreno a favore della respirazione radicale."
                },

                new Glossario
                {
                   NomeTermine = "ASFISSIA RADICALE",
                   DefinizioneTermine = "Mancanza di ossigeno nel terreno, dovuta sia a eccesso d’acqua che a compattamento della terra. Le radici non possono traspirare, né espandersi, per mancanza di spazi liberi tra le particelle di terreno."
                },

                new Glossario
                {
                   NomeTermine = "ASSOCIAZIONE VEGETALE",
                   DefinizioneTermine = "In natura le diverse specie vegetali non compaiono in maniera casuale, bensì associandosi fra di loro sulla base dei fattori ambientali e climatici propri del territorio che le accoglie. La composizione in specie di un’associazione vegetale fornisce così molte informazioni sui fattori climatici e geopedologici del territorio nel quale essa si trova. Per esempio, un’associazione che comprende piante come pioppi, salici e ontani indica un clima continentale (freddo in inverno e caldo in estate) e un terreno a pH neutro-basico molto umido."
                },

                new Glossario
                {
                   NomeTermine = "AUTOCOMPATIBILE, AUTOFERTILE",
                   DefinizioneTermine = "Varietà i cui fiori sono in grado di impollinare altri fiori della stessa varietà (e quindi anche della stessa pianta)."
                },

                new Glossario
                {
                   NomeTermine = "AUTOCTONO",
                   DefinizioneTermine = "Organismo originario della zona in cui vive ed è diffuso."
                },

                new Glossario
                {
                   NomeTermine = "AUTOINCOMPATIBILE, AUTOSTERILE",
                   DefinizioneTermine = "Varietà i cui ﬁ ori non sono in grado di impollinarsi a vicenda, ma necessitano dell’apporto di polline da parte di fiori di altre varietà."
                },

                new Glossario
                {
                   NomeTermine = "AZOTOFISSAZIONE",
                   DefinizioneTermine = "Tutte le Leguminose hanno la capacità di ospitare nelle radici, all’interno di particolari noduli, i Rhizobium, batteri simbionti azotoﬁ ssatori in grado di sfruttare l’azoto atmosferico (in forma molecolare, che per i vegetali è indisponibile), tramutandolo in azoto ammoniacale e cedendolo così alla pianta, che risulta perciò avvantaggiata nella sua nutrizione. In cambio, i batteri ricevono gli zuccheri elaborati dalla pianta."
                },
                
                // B
                new Glossario
                {
                   NomeTermine = "BACCA",
                   DefinizioneTermine = "Tipo di frutto carnoso formato da una buccia (epicarpo) sottile, una polpa (mesocarpo) carnosa, e un “cuore” (endocarpo) polposo o liquido nel quale sono contenuti numerosi semi."
                },

                new Glossario
                {
                   NomeTermine = "BACILLUS THURINGIENSIS",
                   DefinizioneTermine = "Batterio che produce spore a struttura cristallina totalmente innocue per i vertebrati, cioè per l’uomo e gli altri animali superiori. Se questi cristalli vengono ingeriti da larve di Lepidotteri (farfalle) o Ditteri (mosche e zanzare), liberano nell’intestino di esse una tossina che, rapidamente, ne causa la morte. È quindi un insetticida biologico molto selettivo."
                },

                new Glossario
                {
                   NomeTermine = "BARBATELLA",
                   DefinizioneTermine = "Piantina di vite ottenuta per talea e fornita di radici avventizie fascicolate distribuite in palchi (da cui il nome, perché i fasci delle radici assomigliano a una barba)."
                },

                new Glossario
                {
                   NomeTermine = "BASSO IMPATTO AMBIENTALE",
                   DefinizioneTermine = "Metodo di coltura che limita i suoi effetti sull’ambiente, utilizzando prodotti chimici di sintesi solo nei casi estremi (adottando nei restanti casi prodotti organici o minerali e misure preventive), limitando le lavorazioni del terreno, evitando la monocoltura ecc"
                },

                new Glossario
                {
                   NomeTermine = "BIFERA",
                   DefinizioneTermine = "Varietà che produce i frutti due volte per stagione, come accade in alcune varietà di lampone."
                },

                new Glossario
                {
                   NomeTermine = "BIODIVERSITA",
                   DefinizioneTermine = "Termine che indica tutta la gamma della diversità biologica, cioè la ricchezza quantitativa delle specie (e varietà), la complessità degli ecosistemi, e la variabilità genetica. Fra le piante coltivate in agricoltura intensiva e fra gli animali da reddito, la biodiversità è in netto calo, a favore di poche varietà o razze, appositamente selezionate per ottenere la maggiore resa. Le innumerevoli varietà e razze del passato stanno scomparendo, abbandonate perché poco produttive o poco richieste dal mercato."
                },

                new Glossario
                {
                   NomeTermine = "BIOGAS",
                   DefinizioneTermine = "Gas naturale ottenuto come prodotto di scarto da parte di batteri anaerobi (che vivono in assenza di ossigeno); si forma anche, in quantità modeste, nel cumulo del compostaggio."
                },

                new Glossario
                {
                   NomeTermine = "BIOTOPO",
                   DefinizioneTermine = "Dal greco bios, vita, e topos, luogo. È un ambiente che accoglie gli organismi viventi, vegetali e animali di ogni ordine e grado, ed è composto di materia non vivente (aria, acqua, terra e roccia), per esempio il biotopo ﬂ uviale (circoscritto alla riva e alle sponde del ﬁ ume), il biotopo campestre (composto dai terreni coltivati) ecc."
                },

                new Glossario
                {
                   NomeTermine = "BIRDWATCHING",
                   DefinizioneTermine = "Attività naturalistica di osservazione degli uccelli, migratori e stanziali."
                },

                new Glossario
                {
                   NomeTermine = "BORSA",
                   DefinizioneTermine = "Tipo di branca (ramo) fruttifera, caratteristica del pero e del melo, che si è ingrossata perché contiene le sostanze nutritive che passano nel picciòlo, e di qui nel frutto. Può anche avere gemme laterali che danno dardi o brindilli."
                },

                new Glossario
                {
                   NomeTermine = "BOTANICA SISTEMATICA",
                   DefinizioneTermine = "Branca delle scienze che si occupa della classificazione delle piante."
                },

                new Glossario
                {
                   NomeTermine = "BRANCA",
                   DefinizioneTermine = "Ramo di 2-3 anni che porta rami di vario genere dell’anno, dardi e lamburde. Può portare anche una branca di 2 anni, che a sua volta porta dardi o lamburde."
                },

                new Glossario
                {
                   NomeTermine = "BRATTEA",
                   DefinizioneTermine = "Foglia modiﬁ cata, talora ﬁ no a diventare irriconoscibile, poiché assume forme, colori e funzioni diverse dall’origine, per supplire a una determinata funzione per la quale la specie non possiede le strutture apposite. Un caso tipico di brattee sono i “fiori” della stella di Natale."
                },

                new Glossario
                {
                   NomeTermine = "BRINDILLO",
                   DefinizioneTermine = "Ramo di albero da frutto sottile e non molto lungo presente sia su Pomacee sia su Drupacee. È provvisto di gemme a legno, ma in cima può avere, anziché una gemma a foglia, una gemma a fiore, nel qual caso si chiama brindillo coronato."
                },

                new Glossario
                {
                   NomeTermine = "BULBILLI",
                   DefinizioneTermine = "Gemme capaci di staccarsi dalla pianta madre e di dare vita a una nuova pianta. Possono essere collocati sotto terra, affiancati ai bulbi dai quali vengono originati, o sul fusto aereo, generalmente all’ascella delle foglie."
                },

                new Glossario
                {
                   NomeTermine = "BULBO",
                   DefinizioneTermine = "Organo di riserva sotterraneo che comprende un fusto corto e largo dotato di radici all’apice inferiore, protetto da foglie modiﬁ cate. È l’organo di sopravvivenza delle piante geoﬁ te durante la stagione sfavorevole (generalmente quella invernale)."
                },

                //C
                new Glossario
                {
                   NomeTermine = "CALCARE ATTIVO",
                   DefinizioneTermine = "Parte di calcare presente nel terreno in una forma che passa in soluzione nell’acqua e può essere assorbita dalle radici delle piante. Può disturbare o danneggiare le specie che non lo amano (piante calcifughe o acidofile)."
                },

                new Glossario
                {
                   NomeTermine = "CALCE SPENTA",
                   DefinizioneTermine = "Composto di calcio, serve per correggere un terreno acido o compatto, perché ha un’azione più rapida del calcare."
                },

                new Glossario
                {
                   NomeTermine = "CALICE",
                   DefinizioneTermine = "Involucro ﬁ orale, vale a dire la parte più esterna a funzione protettiva, costituito da un numero variabile di sepali di colore verde."
                },

                new Glossario
                {
                   NomeTermine = "CALLO",
                   DefinizioneTermine = "Ingrossamento più o meno pronunciato che si forma nella cicatrizzazione dei tessuti tagliati e combacianti nell’innesto."
                },

                new Glossario
                {
                   NomeTermine = "CAMBIO",
                   DefinizioneTermine = "Più propriamente “zona del cambio”, la porzione di tessuti interni al fusto di alberi e arbusti ove ogni anno si formano nuovi vasi legnosi, idonei al trasporto di linfa grezza dal basso verso l’alto, e librosi, atti al trasporto della linfa elaborata nel vegetale."
                },

                new Glossario
                {
                   NomeTermine = "CANCRO RAMEALE",
                   DefinizioneTermine = "Malattia provocata da un fungo (Nectria galligena), che colpisce le parti legnose ed è molto pericolosa per piante giovani situate in zone umide. Si manifesta con un annerimento localizzato del ramo o del tronco, all’apice del quale le foglie avvizziscono. Nel punto annerito si formano tumefazioni ed escrescenze, a volte con emissione di un liquido appiccicoso. È necessario tagliare subito la parte malata almeno 30-50 cm al di sotto."
                },

                new Glossario
                {
                   NomeTermine = "CAPOLINI",
                   DefinizioneTermine = "Infiorescenze tipiche delle Composite (margherite, crisantemi, calendole, cicoria, dente di leone, ecc.), caratterizzate da un allargamento della parte apicale dello stelo ﬁ orale, che si appiattisce a mo’ di disco accogliendo alla sommità i singoli ﬁ ori. Di norma, le Composite hanno due tipi di ﬁ ori, quelli “ligulati” (ﬁ ori del raggio), sterili e disposti all’esterno del capolino in una raggiera che simula i petali, e quelli “tubulosi” (ﬁ ori del disco), fertili e collocati al centro dell’inﬁ orescenza. Dunque, la margherita e le sue sorelle producono “falsi fiori”, utili per attirare l’attenzione degli insetti impollinatori."
                },

                new Glossario
                {
                   NomeTermine = "CARBOIDRATI",
                   DefinizioneTermine = "Altra denominazione degli zuccheri, dovuta alla loro composizione, che è data da carbonio, idrogeno e ossigeno."
                },

                new Glossario
                {
                   NomeTermine = "CASCOLA",
                   DefinizioneTermine = "Fenomeno fisiologico che consiste nella caduta di una parte più o meno consistente di frutticini durante la fase di allegagione. Di norma, cadono solo quei frutti che non avrebbero alcuna possibilità di svilupparsi sino alla ﬁ ne, perché non fecondati, troppo deboli, malformati, o in competizione elevata con altri frutti nelle vicinanze (assai frequente a maggio e a volte prima del raccolto)."
                },

                new Glossario
                {
                   NomeTermine = "CERCHI DELLE STREGHE",
                   DefinizioneTermine = "Formazioni fungine nel prato, disposte a forma di cerchio a causa dell’andamento circolare del micelio; entro questi circoli l’erba cresce stentata a causa degli essudati paratossici emessi dal micelio stesso."
                },

                new Glossario
                {
                   NomeTermine = "CESPITOSA",
                   DefinizioneTermine = "Pianta i cui fusti si sviluppano a partire da un cespo unico."
                },

                new Glossario
                {
                   NomeTermine = "CETONIE",
                   DefinizioneTermine = "Coleotteri, come le coccinelle, i maggiolini e i cervi volanti, caratterizzati da livrea verde scuro metallizzato. Si tratta di ali modiﬁ cate (elitre) che hanno perso la funzione di volo per acquisire quella di protezione del corpo molle. Il volo, pesante, rumoroso e irregolare, viene assicurato dal secondo paio d’ali, sottostanti alle elitre e ripiegate in fase di riposo."
                },

                new Glossario
                {
                   NomeTermine = "CIMATURA",
                   DefinizioneTermine = "Asportazione dell’apice dei germogli, di solito effettuata durante la potatura verde, per provocare la formazione di gemme a ﬁ ore su quei germogli e sui rami o sulle branche da cui quelli partono. Si effettua anche per regolare la vegetazione nei getti troppo robusti"
                },

                new Glossario
                {
                   NomeTermine = "CIPPATURA",
                   DefinizioneTermine = "Frantumazione dei residui legnosi di potatura delle piante, utili per pacciamature, concimazioni o combustione a seconda del grado di frantumazione."
                },

                new Glossario
                {
                   NomeTermine = "CLONI",
                   DefinizioneTermine = "Insieme di organismi geneticamente identici derivanti da un solo individuo mediante riproduzione agamica (cioè non sessuata, quindi senza rimescolamento genetico). Il clone possiede le stesse informazioni genetiche dell’organismo di partenza. L’esempio tipico è la pianta ottenuta per talea."
                },

                new Glossario
                {
                   NomeTermine = "CLOROFILLA",
                   DefinizioneTermine = "Pigmento indispensabile insieme ad acqua, minerali, sole, anidride carbonica per la realizzazione del processo di fotosintesi. La cloroﬁ lla è di colore verde e ha una struttura chimica simile (presenta magnesio al posto di ferro) all’emoglobina sanguigna animale."
                },

                new Glossario
                {
                   NomeTermine = "CLOROSI",
                   DefinizioneTermine = "Malattia o disturbo della pianta che si manifesta attraverso la riduzione o la perdita della normale colorazione verde, per cui la pianta diviene color verde chiaro o giallo. È dovuta a condizioni (assenza di luce o carenza di ferro o di magnesio) che bloccano la normale produzione di clorofilla."
                },

                new Glossario
                {
                   NomeTermine = "COCCINIGLIA",
                   DefinizioneTermine = "Insetto fitofago che si presenta in varie forme (bianca e cotonosa, a scudetto ecc.), molto dannoso e tenace."
                },

                new Glossario
                {
                   NomeTermine = "COLLETTO",
                   DefinizioneTermine = "Punto di produzione delle parti aeree a opera dell’apparato radicale della pianta, collocato all’intersezione fra radici e fusto."
                },

                new Glossario
                {
                   NomeTermine = "COMPATTAMENTO",
                   DefinizioneTermine = "Pressatura della terra atta a ridurre gli spazi liberi, ove aria e acqua possano circolare. È causa, in situazioni estreme, di asﬁ ssia delle radici. Il fenomeno è tipico dei terreni argillosi, ma si veriﬁ ca anche in altri suoli (mai in quelli sabbiosi), dopo una decina d’anni dall’ultima lavorazione."
                },

                new Glossario
                {
                   NomeTermine = "COMPOSTAGGIO",
                   DefinizioneTermine = "Processo che consente di trasformare le sostanze organiche di scarto, di natura animale e vegetale (per esempio, residui di cucina, resti di potatura, fogliame ecc.), in humus, terra ricca di sali minerali"
                },

                new Glossario
                {
                   NomeTermine = "CONCIME A LENTA CESSIONE",
                   DefinizioneTermine = "Concime che viene rilasciato lentamente nel terreno, divenendo disponibile per le radici, con gradualità e continuità, per circa 3-4 mesi o più, a seconda della sua formulazione."
                },

                new Glossario
                {
                   NomeTermine = "CONCIME BILANCIATO",
                   DefinizioneTermine = "Concime che contiene i tre nutrienti principali (azoto, fosforo e potassio) in percentuale bilanciata, cioè uguale."
                },

                new Glossario
                {
                   NomeTermine = "CONCIME MINERALE",
                   DefinizioneTermine = "Concime a base di elementi minerali inorganici, come azoto (urea, nitrato d’ammonio, solfato ammonico ecc.), potassio (solfato di potassio), fosforo (fosfati, perfosfati ecc.), ferro (sequestrene, chelati ecc.) e altri. "
                },

                new Glossario
                {
                   NomeTermine = "CONCIME ORGANICO",
                   DefinizioneTermine = "Concime a base di sostanza organica (letame, cornunghia, farina d’ossa, guano, pellicino, pollina ecc.) parzialmente decomposta, nella quale si trovano carbonio, idrogeno, ossigeno e azoto (spesso con aggiunta di altri elementi), uniti in forma complessa. "
                },

                new Glossario
                {
                   NomeTermine = "CONCIME TERNARIO",
                   DefinizioneTermine = "Concime che contiene azoto, fosforo e potassio (N-P-K) in parti uguali. L’azoto serve alla crescita della pianta, il fosforo ne rafforza le difese, incentivando la produzione dei fiori, e il potassio mantiene le colorazioni brillanti."
                },

                new Glossario
                {
                   NomeTermine = "CORDONE",
                   DefinizioneTermine = "Fusto semplice, con tante corte ramiﬁ cazioni a frutto; può essere orientato in varie direzioni (doppio, semplice, inclinato, orizzontale semplice e doppio, verticale) e pertanto richiede poco spazio e portinnesti deboli)."
                },

                new Glossario
                {
                   NomeTermine = "CORIMBO",
                   DefinizioneTermine = "Infiorescenza con un asse principale su cui si introducono peduncoli ﬁ orali più lunghi se inseriti in basso e viceversa, in modo che i fiori risultino tutti alla stessa altezza."
                },

                new Glossario
                {
                   NomeTermine = "CORNUNGHIA",
                   DefinizioneTermine = "Concime organico derivato dalla macellazione bovina, ricavato dalla lavorazione dei residui delle corna e degli zoccoli (unghie)."
                },

                new Glossario
                {
                   NomeTermine = "COROLLA",
                   DefinizioneTermine = "La parte generalmente più appariscente del ﬁ ore, contenuta all’interno del calice, e costituita dai petali, solitamente colorati e più o meno grandi e numerosi. La bellezza e la vistosità della corolla sono funzionali all’impollinazione, cioè servono ad attirare il maggior numero di insetti pronubi (impollinatori)."
                },

                new Glossario
                {
                   NomeTermine = "CORTECCIA",
                   DefinizioneTermine = "In gergo tecnico si chiama “ritidoma” o “scorza”, ed è costituita da cellule morte, ma robuste e compatte. La corteccia vera e propria, secondo la terminologia botanica, è invece lo strato immediatamente sottostante a quello esterno, composto da cellule vive aventi il compito di ispessirsi per isolare i tessuti interni dall’ambiente circostante e, al tempo stesso, di dilatarsi per assecondare l’accrescimento del tronco. Sono queste stesse cellule che, l’autunno successivo, in parte moriranno per andare a far parte, negli anni a venire, della scorza."
                },

                new Glossario
                {
                   NomeTermine = "CRENATO",
                   DefinizioneTermine = "Detto del margine della foglia, a indicare una fitta serie di minuti dentini che ne increspano il bordo."
                },

                new Glossario
                {
                   NomeTermine = "CULMO",
                   DefinizioneTermine = "Fusto tipico delle graminacee, dotato di nodi, pieni, e di lunghi internodi cavi."
                },

                new Glossario
                {
                   NomeTermine = "CULTIVAR (VARIETA')",
                   DefinizioneTermine = "Da cultivated variety, varietà prodotta dall’uomo, cioè coltivata, derivata mediante incrocio e/o selezione da una determinata specie. I fruttiferi (piante da frutto) coltivati sono in genere sempre cultivar."
                },

                //D
                new Glossario
                {
                   NomeTermine = "DARDO",
                   DefinizioneTermine = "Piccolo ramo rigido, quasi perpendicolare al ramo, terminante da giovane in una gemma appuntita a foglia/a legno, e, dopo due o più anni, in una gemma più tondeggiante a fiore/a frutto."
                },

                new Glossario
                {
                   NomeTermine = "DECIDUA",
                   DefinizioneTermine = "Specie che perde le foglie in autunno, per limitare i danni da gelo."
                },

                new Glossario
                {
                   NomeTermine = "DICOTILEDONE",
                   DefinizioneTermine = "Classe vegetale comprendente piante che portano nel seme due cotiledoni (foglioline carnose) a nutrimento dell’embrione."
                },

                new Glossario
                {
                   NomeTermine = "DILAVAMENTO",
                   DefinizioneTermine = "Processo provocato dall’acqua che, scendendo in profondità nel terreno, trasporta gli elementi chimici solubili, impoverendo il terreno."
                },

                new Glossario
                {
                   NomeTermine = "DINAMISMO DELLA VEGETAZIONE",
                   DefinizioneTermine = "Tendenza delle specie vegetali a formare associazioni sempre più evolute e specializzate, ﬁ no a raggiungere un equilibrio perfetto, chiamato climax, che può rimanere per tempi lunghissimi in assenza di cambiamenti ambientali signiﬁ cativi, quasi sempre provocati dall’uomo o da fenomeni naturali (eruzioni ecc.)."
                },

                new Glossario
                {
                   NomeTermine = "DIOICA",
                   DefinizioneTermine = "Specie che presenta gli organi riproduttivi maschili (gameti maschili) e femminili (gameti femminili) su esemplari distinti, maschili o femminili. Normalmente, la pianta maschile e quella femminile non presentano grosse differenze, pertanto sono riconoscibili solo al momento della produzione dei gameti. Afﬁ nché una pianta dioica femminile produca frutti e semi è quindi indispensabile la presenza di una pianta (impollinatrice) che possieda ﬁ ori maschili in grado di produrre polline."
                },

                new Glossario
                {
                   NomeTermine = "DIRADAMENTO",
                   DefinizioneTermine = "Eliminazione di una parte dei frutticini (in genere da un terzo a metà), praticata manualmente (o con prodotti chimici nella frutticoltura industriale) per favorire il raggiungimento di un’adeguata pezzatura dei frutti rimanenti. Si attua quando appare evidente che la pianta non è in grado di portare a sviluppo completo tutti i frutticini. "
                },

                new Glossario
                {
                   NomeTermine = "DISAFFINITA'",
                   DefinizioneTermine = "Detta di un innesto, è l’incompatibilità fra la marza e il portinnesto, che impedisce così un’unione durevole."
                },

                new Glossario
                {
                   NomeTermine = "DORMIENZA",
                   DefinizioneTermine = "Fase di riposo durante la quale tutte le funzioni vitali rallentano ﬁ no a cessare, per riprendere poi al ripristino di condizioni ambientali favorevoli. Avviene in inverno per le piante originarie delle zone fredde, in estate per quelle delle aree tropicali con lunghe stagioni aride."
                },

                new Glossario
                {
                   NomeTermine = "DRUPA",
                   DefinizioneTermine = "Frutto con una buccia (epicarpo) sottile, una polpa (mesocarpo) carnosa, e un cuore (endocarpo) duro e ligniﬁ cato a proteggere il seme, in genere singolo."
                },
                
                //E
                new Glossario
                {
                   NomeTermine = "ECOSISTEMA",
                   DefinizioneTermine = "Insieme dei rapporti fra gli organismi viventi (biocenosi, data da piante e animali) e l’habitat inanimato che li accoglie (biotopo). Ogni biotopo, in base alle sue caratteristiche, consente la sopravvivenza di una diversa biocenosi, che a sua volta inﬂ uisce sul biotopo in cui si trova modiﬁ candolo, generalmente in senso positivo (negli ecosistemi naturali). La scienza che studia gli ecosistemi è l’ecologia."
                },

                new Glossario
                {
                   NomeTermine = "ECOTIPO",
                   DefinizioneTermine = "Pianta appartenente a una specie rispetto alla quale possiede qualche carattere morfologico (e quindi genetico) leggermente diverso in risposta a uno stimolo derivante dall’ambiente. Per esempio, la mela ‘Annurca’, originaria della Campania dove si presenta piccola, schiacciata, color rosso intenso e molto saporita, se coltivata nel Nord Italia risulta più grossa, allungata, rosso chiaro e poco gustosa."
                },

                new Glossario
                {
                   NomeTermine = "EFFETTO LENTE",
                   DefinizioneTermine = "Effetto provocato dalle gocce d’acqua appoggiate sulle foglie quando vengono colpite dai raggi solari. Può determinare l’ustione del tessuto fogliare."
                },

                new Glossario
                {
                   NomeTermine = "ENDEMICO",
                   DefinizioneTermine = "Si dice di un tipo di pianta tipico di una determinata zona o regione geograﬁ ca circoscritta, e pertanto presente solo in essa."
                },

                new Glossario
                {
                   NomeTermine = "EPIFITA",
                   DefinizioneTermine = "Dal greco epì fiton, «che sta sopra una pianta». L’esempio tipico sono alcune orchidee e le tillandsie (“piante mangiafumo”)."
                },

                new Glossario
                {
                   NomeTermine = "ERMAFRODITA",
                   DefinizioneTermine = "Organismo o parte di esso avente nella medesima struttura gli organi riproduttivi di entrambi i sessi. La grande maggioranza dei fiori è ermafrodita, portando nel singolo fiore sia gli stami con le antere contenenti il polline (organi maschili), sia il pistillo (organo femminile formato da stimma, stilo e ovario con gli ovuli)."
                },

                new Glossario
                {
                   NomeTermine = "ESSENZE VOLATILI",
                   DefinizioneTermine = "Essenze presenti in alcune specie vegetali: oltre alla funzione termoregolatrice, hanno il compito di allontanare i fitofagi grazie al loro aroma ad essi sgradito. Sono tipiche delle piante aromatiche."
                },

                new Glossario
                {
                   NomeTermine = "EVAPOTRASPIRAZIONE",
                   DefinizioneTermine = "Quantità di acqua che traspira dalla pianta, evaporando, a causa della temperatura molto elevata dell’ambiente circostante."
                },
                
                //F
                new Glossario
                {
                   NomeTermine = "FARINA DI SANGUE (SANGUE SECCO)",
                   DefinizioneTermine = "Concime organico costituito dal sangue animale, prodotto di scarto della macellazione, sottoposto a trattamento di sterilizzazione ed essiccamento."
                },

                new Glossario
                {
                   NomeTermine = "FASCIA PEDOCLIMATICA",
                   DefinizioneTermine = "Fascia altitudinale o latitudinale nella quale sono presenti determinate condizioni di terreno (dal greco pedos) e di clima. A ogni fascia pedoclimatica corrisponde una precisa fascia vegetazionale."
                },

                new Glossario
                {
                   NomeTermine = "FASE FENOLOGICA",
                   DefinizioneTermine = "Momento del ciclo biologico della pianta. Nella fase fenologica di ﬁ oritura, si distingue la fase di bocciolo, quella di antesi, cioè di apertura del fiore, e quella di senescenza, cioè di appassimento."
                },

                new Glossario
                {
                   NomeTermine = "FELTRO",
                   DefinizioneTermine = "Ammasso di residui vegetali conglobati fra loro, derivante dallo sfalcio non rimosso e da altri rimasugli di steli e foglie. Si forma sulla superficie del terreno che ospita il tappeto erboso, proprio alla base degli steli e delle foglie prative, che tendono a venire soffocati nel loro fabbisogno d’aria."
                },

                new Glossario
                {
                   NomeTermine = "FEROMONI",
                   DefinizioneTermine = "Sostanze volatili, di origine organica, prodotte in natura da ghiandole specifiche degli insetti femmine (ma in molte specie anche dai maschi), che attirano anche da una discreta distanza, portate da correnti d’aria, gli insetti maschi. Tali sostanze possono essere sintetizzate chimicamente; non danneggiano l’ambiente e si utilizzano entro le apposite trappole."
                },

                new Glossario
                {
                   NomeTermine = "FILATURA",
                   DefinizioneTermine = "Processo di allungamento degli steli nella zona dell’internodo, determinato dalla ricerca della luce necessaria ma insufficiente."
                },

                new Glossario
                {
                   NomeTermine = "FITODEPURAZIONE",
                   DefinizioneTermine = "Tecnica che utilizza alcune specie vegetali per depurare le acque di scarico industriale o abitativo. Oltre a certe alghe, si utilizzano specie acquatiche quali l’alisma (Alisma plantago) e la lisimachia (Lysimachia vulgaris) e specie palustri (di luoghi umidi), come la cannuccia (Phragmites australis), la tifa (Typha latifolia), l’iris d’acqua (Iris pseudachorus), la menta (Mentha aquatica). Queste piante assorbono l’acqua inquinata e trattengono al proprio interno (o annullano) le sostanze nocive."
                },

                new Glossario
                {
                   NomeTermine = "FITOFARMACI",
                   DefinizioneTermine = "Sostanze attive e miscele destinate a proteggere i vegetali dagli organismi nocivi, conservarli, eliminare piante indesiderate, favorire o regolare i processi vitali. Spesso viene usato impropriamente come sinonimo il termine “pesticida”, dalla trasposizione del termine anglosassone pesticide (pest = insetto, avversità)."
                },

                new Glossario
                {
                   NomeTermine = "FLORA MICROBICA",
                   DefinizioneTermine = "Massa di microrganismi (batteri, funghi e animaletti vari) che hanno il compito di aiutare il terreno a nutrire le piante. Per incentivarne la presenza, oltre a somministrare sostanza organica, occorre accertarsi che il pH tenda alla neutralità o all’alcalinità, e far sì che l’arieggiamento sia sufficiente."
                },

                new Glossario
                {
                   NomeTermine = "FOGLIE IMPENNATE",
                   DefinizioneTermine = "Foglie composte, cioè date da un lungo picciolo (asse centrale) sul quale sono inseriti i piccioli delle singole foglioline, opposte l’una all’altra. Caratteristica della foglia imparipennata è la presenza di una fogliolina apicale che rende dispari il numero complessivo delle foglioline portate dalla foglia composta."
                },

                new Glossario
                {
                   NomeTermine = "FOGLIE LOBATE",
                   DefinizioneTermine = "Foglie la cui lamina è suddivisa, da un terzo ﬁ no a metà, in lobi (in numero variabile: 3-5-7 ecc.) mediante incisioni che partono dal margine."
                },

                new Glossario
                {
                   NomeTermine = "FOLLICOLI",
                   DefinizioneTermine = "Frutti secchi, con pareti sottili e rigide, che si aprono spontaneamente a maturità, lungo una linea a mo’ di cerniera, liberando molti semi."
                },

                new Glossario
                {
                   NomeTermine = "FOTOSINTESI CLOROFILLIANA",
                   DefinizioneTermine = "Funzione che permette a tutte le piante verdi di produrre energia, sotto forma di zuccheri semplici, a partire da acqua, minerali, anidride carbonica, clorofilla e luce solare."
                },

                new Glossario
                {
                   NomeTermine = "FRANCO",
                   DefinizioneTermine = "Pianta nata da seme che funge da portinnesto (parte della pianta che fornisce l’apparato radicale) per una marza (parte di una pianta che fornisce la chioma) di una varietà particolare della stessa specie o specie affine. È molto vigoroso e attualmente poco utilizzato, a favore di portinnesti provenienti da talee con caratteristiche uniformi e collaudate."
                },

                new Glossario
                {
                   NomeTermine = "FUMAGGINE",
                   DefinizioneTermine = "Formazione di incrostazioni scure e fuligginose sulla superficie di foglie e germogli provocate da microrganismi fungini: si sviluppano a spese della melata (sostanza zuccherina) che ricopre le parti di pianta infestate da afidi o altri parassiti."
                },

                new Glossario
                {
                   NomeTermine = "FUNGHI SAPROFITI",
                   DefinizioneTermine = "Specie molto utili all’ecosistema perché si nutrono di sostanza organica morta, decomponendola negli elementi originari e permettendo così il naturale ricircolo della materia, indispensabile per la vita delle piante superiori. "
                },
                
                //G-H-I
                new Glossario
                {
                   NomeTermine = "GRAFIOSI",
                   DefinizioneTermine = "Malattia dell’olmo provocata da un parassita (Ceratocystis ulmi) e diffusa da insetti scoliti, che porta a disseccamento l’albero. Negli anni ‘90 sono state decimate intere popolazioni di olmi, soprattutto nel Nord e Centro Italia. Oggi sembra che il patogeno non sia più così aggressivo."
                },

                new Glossario
                {
                   NomeTermine = "GUANO",
                   DefinizioneTermine = "Concime organico derivante dallo sterco (sterilizzato ed essiccato) di uccelli marini dell’oceano Pacifico depositato sugli scogli. È ricchissimo di azoto."
                },

                new Glossario
                {
                   NomeTermine = "HUMUS",
                   DefinizioneTermine = "Sostanza propria del terreno, costituita da particelle di terra inframmezzate a sostanza organica (composti di carbonio, idrogeno, ossigeno, azoto) in fase avanzata di decomposizione a opera dei microrganismi del terreno stesso, e a sostanza inorganica (sali minerali), che è già disponibile per l’assorbimento da parte delle radici."
                },

                new Glossario
                {
                   NomeTermine = "IBRIDAZIONE",
                   DefinizioneTermine = "Fecondazione che avviene mediante polline di altra varietà, per ottenere una nuova cultivar (si protegge con un cappuccio il fiore da fecondare, si preleva il polline desiderato e lo si applica con un pennellino sul fiore liberato)."
                },

                new Glossario
                {
                   NomeTermine = "IBRIDO",
                   DefinizioneTermine = "Organismo vegetale o animale derivante dall’incrocio fra due specie diverse. In genere, l’organismo che ne deriva è sterile, quindi, non può essere utilizzato per la riproduzione, come nel caso degli ibridi F1."
                },

                new Glossario
                {
                   NomeTermine = "IFE",
                   DefinizioneTermine = "Tipiche dei funghi, sono sottili ﬁ lamenti sparsi nel terreno a formare il micelio (paragonabile alle radici), o raggruppati a dare il corpo fruttifero, o carpoforo, cioè il fungo visibile e, all’interno di esso, a costituire l’imenio, cioè l’organo riproduttivo che produce le spore."
                },

                new Glossario
                {
                   NomeTermine = "IMPALCATURA",
                   DefinizioneTermine = "Posizione dalla quale si dipartono due branche (rami) opposte dal tronco principale, secondo assi orizzontali che si succedono in altezza."
                },

                new Glossario
                {
                   NomeTermine = "INTERNODO",
                   DefinizioneTermine = "Porzione di ramo compresa fra un nodo e il successivo. Ha solo la funzione vegetativa di accrescimento in lunghezza del ramo stesso, ma non contiene nessuna parte di tessuto atta alla propagazione della pianta, a differenza del nodo. È bene che l’internodo non sia troppo lungo, perché spesso è indizio di filatura per mancanza di luce o per soverchio vigore."
                },

                new Glossario
                {
                   NomeTermine = "INZAFFARDATURA",
                   DefinizioneTermine = "Procedura riguardante i fruttiferi (ma anche rosai o altri arbusti) a radice nuda. Appena prima della piantagione, se ne immerge per una decina di minuti l’apparato radicale in un secchio contenente una miscela di acqua, terra fertile e letame in parti uguali, con lo scopo di rivitalizzare le radici e nutrirle in questo momento delicato."
                },

                //L
                new Glossario
                {
                   NomeTermine = "LAMBURDA",
                   DefinizioneTermine = "Rametto in genere molto breve, caratteristico delle Pomacee. Termina con una gemma apicale a legno (lamburda vegetativa) o con una gemma mista (lamburda fiorifera)."
                },

                new Glossario
                {
                   NomeTermine = "LAME ELICOIDALI",
                   DefinizioneTermine = "Lame del tosaerba disposte su di un cilindro rotante ad asse orizzontale, ideali su prati molto fini dove il taglio perfettamente netto regala l’effetto a strisce. Sono sconsigliate sull’erba alta e, in genere, si impiegano per usi professionali."
                },

                new Glossario
                {
                   NomeTermine = "LAME ORIZZONTALI",
                   DefinizioneTermine = "Lame del tosaerba disposte orizzontalmente, che ruotano a grande velocità su di un asse verticale. È il dispositivo di taglio più economico e diffuso."
                },

                new Glossario
                {
                   NomeTermine = "LETAME",
                   DefinizioneTermine = "Concime organico derivante dai bovini. Va utilizzato solo una volta maturo, per evitare che l’azoto presente in quantità elevata bruci le radici. Di norma, la maturazione avviene lasciando il cumulo di deiezioni all’aperto, esposto agli agenti atmosferici e rivoltato almeno una volta al mese (come il compost), per almeno sei mesi. È ricco di elementi nutritivi."
                },
                
                //M
                new Glossario
                {
                   NomeTermine = "MALLO",
                   DefinizioneTermine = "Pericarpo (parte esterna) del frutto del noce."
                },

                new Glossario
                {
                   NomeTermine = "MARGOTTA",
                   DefinizioneTermine = "Sistema di propagazione che non stacca la pianta figlia dalla pianta madre finché la ﬁ glia non è ben radicata."
                },

                new Glossario
                {
                   NomeTermine = "MARZA (NESTO)",
                   DefinizioneTermine = "Piccola porzione di un ramo giovane non ancora del tutto ligniﬁ cato che presenta almeno due gemme. La marza viene inserita (innestata) con metodi vari d’innesto su di un’altra (detta, appunto, “portinnesto”) munita di apparato radicale."
                },

                new Glossario
                {
                   NomeTermine = "MAZZETTO DI MAGGIO",
                   DefinizioneTermine = "Formazione tipica delle piante da frutto; nasce da un dardo molto corto, che ha una gemma a foglia o a legno in cima, e tutt’intorno invece ha un gruppo di gemme a fiore o a frutto."
                },

                new Glossario
                {
                   NomeTermine = "MELATA",
                   DefinizioneTermine = "Liquido viscoso e zuccherino, rappresentato dagli escrementi di alcuni insetti (aﬁ di, psilla e cocciniglie). La vegetazione, soprattutto le foglie, quando ne è imbrattata appare lucida e appiccicosa, rappresentando spesso un substrato di crescita per crittogame (funghi) agenti della fumaggine."
                },

                new Glossario
                {
                   NomeTermine = "MERISTEMA",
                   DefinizioneTermine = "Tessuto (non differenziato o specializzato) giovane in attivo e rapido accrescimento, generalmente localizzato agli apici radicale e vegetativo. Viene utilizzato in laboratorio, per prelevare piccole porzioni che, allevate in maniera adatta, sono in grado di ricostituire una pianta figlia esattamente identica alla pianta madre (clone)."
                },

                new Glossario
                {
                   NomeTermine = "MICELIO",
                   DefinizioneTermine = "Tipico dei funghi, è una rete di filamenti, le ife, che possono essere sterili o vegetative, con funzione assorbimento delle sostanze nutritive e di ingrandimento dell’organismo fungino, oppure fertili o sessuate, a funzione riproduttiva."
                },

                new Glossario
                {
                   NomeTermine = "MICROCLIMA",
                   DefinizioneTermine = "Insieme delle condizioni climatiche che si creano vicino al suolo in un’area di estensione limitata (a volte pochi metri quadri)."
                },

                new Glossario
                {
                   NomeTermine = "MICRORGANISMI",
                   DefinizioneTermine = "Organismi viventi che hanno dimensioni minime (invisibili a occhio nudo), vale a dire batteri e funghi. Fra i batteri, alcuni possono sopravvivere solo in presenza di ossigeno (aerobi); altri solo in assenza di ossigeno (organismi anaerobi); altri ancora in entrambe le condizioni."
                },

                new Glossario
                {
                   NomeTermine = "MULCHING",
                   DefinizioneTermine = "Operazione di triturazione e rilascio dell’erba del prato durante la tosatura, per renderla disponibile alla decomposizione a opera degli agenti atmosferici e dei microrganismi del suolo."
                },

		//N-O
                new Glossario
                {
                   NomeTermine = "NEANIDE",
                   DefinizioneTermine = "Forma giovane di un insetto, con caratteristiche morfologiche simili all’insetto adulto, ma molto più piccola."
                },

                new Glossario
                {
                   NomeTermine = "NETTARE",
                   DefinizioneTermine = "Liquido prodotto dai fiori impollinati dagli insetti, per attirarli. È contenuto in piccole sacche alla base dei petali all’interno del fiore. Per raggiungere il nettare, l’insetto è costretto a sporcarsi di polline o a sfiorare l’ovario, compiendo così l’opera di impollinazione"
                },

                new Glossario
                {
                   NomeTermine = "NODO",
                   DefinizioneTermine = "Piccola porzione di tessuto localizzata sul ramo e contenente strutture (gemme) atte alla propagazione della pianta e allo sviluppo di elementi differenziati come la foglia o il ﬁ ore. La disposizione dei nodi sul ramo è regolare, con distanza deﬁ nita dall’internodo."
                },

                new Glossario
                {
                   NomeTermine = "OCCHIO (SCUDO, GEMMA)",
                   DefinizioneTermine = "Piccola sporgenza all’ascella di una foglia, appuntita, semicoperta da scaglie, e spesso da una parte e dall’altra è accompagnata da due gemme quasi invisibili. La gemma centrale può essere dormiente, anche per più anni, oppure vegetante, cioè pronta a svilupparsi in un ramo a foglia o a fiore."
                },

                new Glossario
                {
                   NomeTermine = "OIDIO",
                   DefinizioneTermine = "Malattia comune sulle piante ornamentali, ortive e da frutto, provocata da funghi (Podosphaera leucotricha, Oidium farinosum ecc.) che danneggiano le foglie, su cui compaiono macchie biancastre (“mal bianco”) e farinose. Si instaura in condizioni climatiche di umidità persistente e temperatura non troppo alta (primavera, autunno)."
                },

                new Glossario
                {
                   NomeTermine = "OLIO ESSENZIALE",
                   DefinizioneTermine = "Sostanza presente nelle piante aromatiche; in essa sono concentrati tutti i principi attivi di impiego ﬁ toterapico. L’essenza (principio attivo) è disciolta in una sorta di sostanza oleosa, che viene estratta dalla pianta con tecniche diverse (distillazione, spremitura ecc.)"
                },

		//P
                new Glossario
                {
                   NomeTermine = "PACCIAMATURA",
                   DefinizioneTermine = "Copertura del terreno con materiali di varia natura (cartone, film di plastica nera, paglia, foglie secche, residuo di sfalcio dell’erba, corteccia tritata, gusci di frutta secca ecc.), per impedire la nascita delle malerbe e mantenere umido il terreno. I materiali di natura organica si decompongono lentamente, restituendo sostanza organica al suolo. "
                },

                new Glossario
                {
                   NomeTermine = "PACK",
                   DefinizioneTermine = "Confezione per piante arbustive o arboree tolte dal terreno, che ne consente la sopravvivenza (in fase di riposo) per almeno un paio di mesi. È costituita da un involucro di plastica o carta plastiﬁ cata riempito con torba, trucioli, vermiculite o altro materiale semi-inerte a proteggere le radici nude, impedendone così la disidratazione."
                },

                new Glossario
                {
                   NomeTermine = "PAGINA",
                   DefinizioneTermine = "Faccia della foglia. La pagina superiore è quella rivolta verso la luce ed è spesso liscia e lucida; quella inferiore è perforata dai microscopici stomi, inﬁ nitesimali aperture per gli scambi con l’ambiente, e presenta di solito il rilievo dei vasi contenenti la linfa; può anche essere pelosa."
                },

                new Glossario
                {
                   NomeTermine = "PALMETTA",
                   DefinizioneTermine = "Fusto verticale dal quale partono rami orizzontali o obliqui; necessita di un sostegno sotto forma di palatura a spalliera o a controspalliera, di muro o di recinzione."
                },

                new Glossario
                {
                   NomeTermine = "PAPPO",
                   DefinizioneTermine = "Ciuffo di peli eterei che circonda il seme componendo così un frutto “alato”. Ha il compito di lasciarsi trasportare dal vento, per diffondere lontano il seme."
                },

                new Glossario
                {
                   NomeTermine = "PARTENOCARPIA",
                   DefinizioneTermine = "Sistema di diffusione asessuata (propagazione vegetativa), senza bisogno di impollinazione, che garantisce il mantenimento della specie, ma non la mescolanza genetica, poiché le caratteristiche provengono solo dalla pianta madre. In caso di condizioni ambientali improvvisamente avverse, tutte le piante scompariranno, perché tutte uguali tra loro."
                },

                new Glossario
                {
                   NomeTermine = "PATOGENO",
                   DefinizioneTermine = "Che genera malattia, oppure (come sostantivo) organismo animale (per esempio un insetto) o vegetale (per esempio un fungo) che provoca malattia."
                },

                new Glossario
                {
                   NomeTermine = "PH",
                   DefinizioneTermine = "Grado di acidità (pH inferiore a 7), alcalinità (pH maggiore di 7) o neutralità (pH pari a 7) di una sostanza in soluzione."
                },

                new Glossario
                {
                   NomeTermine = "POLLINA",
                   DefinizioneTermine = "Concime organico costituito dallo sterco (sterilizzato ed essiccato) del pollame. È ricchissimo di azoto prontamente disponibile (non bisogna esagerare con la somministrazione)."
                },

                new Glossario
                {
                   NomeTermine = "POLLONE",
                   DefinizioneTermine = "Germoglio proveniente dalle radici di alcune specie (tiglio, querce, ciliegio, susino ecc.), sviluppato anche ad alcuni metri dalla pianta d’origine. Per utilizzarlo per nuovi esemplari, si scava e si taglia la radice a 10 cm circa, da una parte e dall’altra, e si pianta. Se lasciato indisturbato si lignifica progressivamente a formare una sorta di cespuglio arboreo."
                },

                new Glossario
                {
                   NomeTermine = "PORTAINNESTO",
                   DefinizioneTermine = "Gli alberi da frutto (ma anche alcune specie di piante ornamentali) necessitano di un portinnesto, che permette la moltiplicazione, tramite l’innesto, di varietà altrimenti non propagabili. La scelta del portinnesto è fondamentale, perché determina le dimensioni e la resistenza della pianta di per sé (quindi può migliorarne le caratteristiche), mentre l’innesto (o marza) governa la tipologia del frutto (varietà)."
                },

                new Glossario
                {
                   NomeTermine = "PROPAGGINE",
                   DefinizioneTermine = "Metodo di propagazione analogo a quello della margotta, perché la pianta figlia rimane attaccata alla pianta madre finché non ha ben radicato."
                },

                new Glossario
                {
                   NomeTermine = "PROPOLI",
                   DefinizioneTermine = "Resina ricavata dalle api da gemme di pioppi, betulle, salici, ippocastano, pini, abeti, querce, olmi e altre specie, utilizzata come isolante per sigillare crepe dell’alveare e come disinfettante per imbalsamare insetti imprigionati nell’alveare. Contiene molti principi attivi terapeutici, impiegati nella medicina naturale, fra cui flavonoidi, oli essenziali, terpeni, acidi aromatici, cera. È antibiotica, antivirale, antinfiammatoria, anestetizzante, cicatrizzante, disinfettante, fungicida, immunostimolante, antiossidante. La propoli viene impiegata anche nel biogiardinaggio per difendere le piante ornamentali, da orto e da frutto dagli attacchi fungini (oidio, fumaggine, ticchiolatura, ruggine) e da alcuni tipi di insetti (afIdi e cocciniglie)."
                },

                new Glossario
                {
                   NomeTermine = "PRUINA",
                   DefinizioneTermine = "Patina formata da una sorta di polvere biancastra disposta sulla superficie della buccia di frutti (per esempio le susine, il kaki e l’uva), avente il compito di proteggere dagli agenti atmosferici e dai raggi solari."
                },
		
		//R
                new Glossario
                {
                   NomeTermine = "RACEMO",
                   DefinizioneTermine = "Infiorescenza composta da altre inﬁ orescenze, da grappoli (o racemi), a loro volta costituiti da un asse principale sul quale si dispongono alternativamente i fiori muniti di peduncolo (gambo)."
                },

                new Glossario
                {
                   NomeTermine = "RIZOMA",
                   DefinizioneTermine = "Fusti sotterranei, striscianti in orizzontale, con capacità di produrre radici e gemme per fusti aerei, e quindi per nuove piante."
                },

                new Glossario
                {
                   NomeTermine = "ROSETTA",
                   DefinizioneTermine = "Gruppo di foglie sovrapposte e disposte a cerchio, inserite allo stesso livello sul fusto o sul rizoma."
                },

                //S
		new Glossario
                {
                   NomeTermine = "SARMENTOSA",
                   DefinizioneTermine = "Pianta i cui fusti sono dotati di aculei o viticci per arrampicarsi."
                },

                new Glossario
                {
                   NomeTermine = "SESTO DI IMPIANTO",
                   DefinizioneTermine = "Distanza di piantagione di specie arboree e da frutto. Le misure variano in base a diversi fattori, quali terreno, vigore della varietà e forma d’allevamento. In sostanza, si ottiene una precisa geometria per la piantagione, la cui disposizione segue criteri di razionalità, di migliore utilizzo dello spazio disponibile, e di più agevole esecuzione delle operazioni colturali."
                },

                new Glossario
                {
                   NomeTermine = "SFEMMINELLATURA",
                   DefinizioneTermine = "Operazione di eliminazione dei boccioli e dei getti laterali che si formano all’ascella fra i rami e il fusto. Si effettua sulle piante di pomodoro, melanzana e peperone, ma anche sulle Cucurbitacee."
                },

                new Glossario
                {
                   NomeTermine = "SILIQUE",
                   DefinizioneTermine = "Frutti secchi simili per forma ai legumi, ma con un processo di formazione leggermente diverso."
                },

                new Glossario
                {
                   NomeTermine = "SISTEMICO",
                   DefinizioneTermine = "Fitofarmaco che, pur essendo assorbito da un solo organo della pianta (le radici o le foglie), viene poi traslocato mediante la linfa in tutte le parti della pianta, proteggendo efficacemente e in modo durevole dai patogeni."
                },

                new Glossario
                {
                   NomeTermine = "SOSTANZA ORGANICA",
                   DefinizioneTermine = "Sostanza complessa, formata da composti di carbonio, idrogeno, ossigeno, azoto, che in questo caso è presente nel terreno sotto forma morta, per esempio fogliame e rami in decomposizione ecc. Verrà perciò decomposta dai microrganismi del terreno, per ritornare sostanza semplice, cioè singoli elementi o sali minerali. Fra i microrganismi decompositori ci sono i funghi saprofiti e i batteri. Allo scopo è utile anche il lavoro svolto da animali e insetti come i lombrichi, i millepiedi, i porcellini di terra, le lumache ecc."
                },

                new Glossario
                {
                   NomeTermine = "SOVESCIO",
                   DefinizioneTermine = "Coltivazione di specie capaci di restituire azoto al terreno, come le Leguminose (compresa l’erba medica), la senape e il crescione. Poco prima di ricominciare a coltivare il terreno, si incorpora a esso la coltura (sovescio). Si effettua soprattutto nell’orto e nelle coltivazioni agricole."
                },

                new Glossario
                {
                   NomeTermine = "SPECIE PIONIERA",
                   DefinizioneTermine = "Organismo (batterio, pianta o animale) di poche esigenze, il che consente la sopravvivenza in ambienti inospitali, per esempio, nel caso dei vegetali, le dune sabbiose. Le specie pioniere, a ﬁ ne ciclo, arricchiscono l’ambiente di sostanze che favoriscono l’arrivo di specie più esigenti, permettendo così il processo di evoluzione dell’area."
                },

                new Glossario
                {
                   NomeTermine = "SPORA FUNGINA",
                   DefinizioneTermine = "Cellula riproduttiva analoga per funzione ai semi delle piante superiori, in grado di resistere per un certo tempo in condizioni ambientali avverse (cioè, generalmente, siccitose); si forma nell’imenio, l’intreccio di ife nel cappello del fungo. In ogni ambiente le spore fungine sono presenti in quantità di molti miliardi, ma poche sono quelle dannose e ancora più difficile è per queste ultime trovare l’ambiente adatto alla loro germinazione. Le spore dei funghi parassiti, trasportate dal vento e poi attivate dalla pioggia, dall’acqua d’irrigazione o dalla rugiada, sono pronte a colpire e ad aggredire i fruttiferi, soprattutto se le piante sono in condizioni (ambientali o sanitarie) non ottimali."
                },

                new Glossario
                {
                   NomeTermine = "STOLONI",
                   DefinizioneTermine = "Fusti allungati che strisciano sul terreno e, ai nodi, segnalati da un grappolo di foglie, emettono radici dando origine a nuove piantine."
                },

                new Glossario
                {
                   NomeTermine = "STOMI",
                   DefinizioneTermine = "Microscopiche aperture ovali situate di norma sulla pagina inferiore delle foglie, il cui movimento di apertura e chiusura è comandato da un complesso meccanismo basato sul turgore cellulare. Hanno il compito di aprirsi, di norma di giorno, per far entrare l’anidride carbonica indispensabile alla fotosintesi clorofilliana, che determina la vita e l’accrescimento della pianta."
                },

                new Glossario
                {
                   NomeTermine = "SUFFRUTICE",
                   DefinizioneTermine = "Pianta perenne di piccola taglia, con gemme portate appena al di sotto del colletto, ben protette nel terreno, e con lignificazione della sola parte basale dei rami, mentre la parte superiore rimane di natura erbacea e può seccarsi durante l’inverno. Sono suffrutici molte aromatiche come la salvia, la lavanda, il rosmarino ecc. "
                },
		
		//T
                new Glossario
                {
                   NomeTermine = "TALEA",
                   DefinizioneTermine = "Porzione di ramo (la gemma deve essere sempre al di sopra della cicatrice del picciolo della foglia caduta, e il taglio in basso deve essere appena sotto un nodo) erbaceo o legnoso, che, piantata in terra, in condizioni ottimali, radica e forma una nuova pianta. Per facilitare l’emissione di radici si possono usare i prodotti radicanti appositi, in polvere o liquidi."
                },

                new Glossario
                {
                   NomeTermine = "TICCHIOLATURA",
                   DefinizioneTermine = "Malattia provocata da funghi (Venturia inaequalis, Fusicladium dendriticum ecc.) che danneggiano foglie e frutti, su cui compaiono macchie nere e crostose. Si instaura in condizioni climatiche caldo-umide."
                },

                new Glossario
                {
                   NomeTermine = "TORMENTOSO",
                   DefinizioneTermine = "Ricoperto da una fine e fitta peluria, che serve a proteggere, rivestendoli, i tessuti sottostanti."
                },

                new Glossario
                {
                   NomeTermine = "TORBA",
                   DefinizioneTermine = "Substrato naturale provienente dalle torbiere, ambienti molto umidi, dove l’acqua ristagna sul terreno. Le piante che vi si trovano, in genere tipologie diverse di muschi e sfagni, al termine del ciclo vitale si decompongono solo in parte, a causa della forte acidità, andando a formare con i loro residui la torba usata in giardinaggio e agricoltura."
                },

                new Glossario
                {
                   NomeTermine = "TRAPPOLA A FEROMONI",
                   DefinizioneTermine = "Erogatori di feromoni sessuali (riprodotti in laboratorio) che agiscono sui maschi dei lepidotteri (farfalle), impedendo l’accoppiamento."
                },

                new Glossario
                {
                   NomeTermine = "TUBERO",
                   DefinizioneTermine = "Radice ingrossata a contenere sostanze di riserva, che servono in primavera per la nuova produzione di parti aeree. L’esempio più noto è la patata."
                },

		//U-V-Z
                new Glossario
                {
                   NomeTermine = "UNIFERO",
                   DefinizioneTermine = "Varietà che produce i frutti una sola volta per stagione (come accade a certe varietà di lampone)."
                },

                new Glossario
                {
                   NomeTermine = "VERMICULITE",
                   DefinizioneTermine = "Sostanza minerale inerte; si presenta in scaglie o granuli e viene impiegata, anche insieme ad altre sostanze (perlite), miscelata al terriccio per migliorarne la ritenzione idrica."
                },

                new Glossario
                {
                   NomeTermine = "VITICCI",
                   DefinizioneTermine = "Foglie (in questo caso germogli fogliari) modificate in lunghi filamenti che si arrotolano legandosi al supporto e favorendo, quindi, lo sviluppo di piante sarmentose (passiflora, rose ecc.) non dotate di radici aeree come l’edera."
                },

                new Glossario
                {
                   NomeTermine = "ZAMPE",
                   DefinizioneTermine = "Termine che identifica le formazioni radicali di alcune piante e in particolare degli asparagi, che vengono trapiantati a partire appunto da zampe (piantine) di una o due anni, per avviare l’asparagiaia, che rimane attiva mediamente per 8-10 anni."
                },

                



            };

            return data;
        }

        // TODO WTS: Remove this once your MasterDetail pages are displaying real data
        public static async Task<IEnumerable<Glossario>> GetSampleModelDataAsync()
        {
            await Task.CompletedTask;

            return AllGlossario();
        }

        
    }
}
