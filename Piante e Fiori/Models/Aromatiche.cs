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
//34 AROMATICHE
    public class Aromatiche
    {
        public string NomeComunePianta { get; set; }
        public string NomeFamiglia { get; set; }
        public string NomeScientificoPianta { get; set; }
        public string FotoPianta { get; set; }
        public string SourceGalleryFotografica { get; set; }

        public string Introduzione { get; set; }
        public string DescrizioneeColtivazione { get; set; }
        public string RaccoltaeConservazione { get; set; }
        public string SaluteeBellezza1 { get; set; }
        public string SaluteeBellezza2 { get; set; }
        public string Incucina1 { get; set; }
        public string Incucina2 { get; set; }

        public string Propagazione { get; set; }
        public string Potatura { get; set; }
        public string Malattie { get; set; }
        


    }

    public static class AromaticheDataService
    {
        private static IEnumerable<Aromatiche> AllAromatiche()
        {
            // The following is order summary data
            var data = new ObservableCollection<Aromatiche>
            {
               
                new Aromatiche
                {
                   NomeComunePianta = "ALLORO",
                   NomeFamiglia = "Lauracee",
                   NomeScientificoPianta = "Laurus nobilis",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Alloro/ALLORO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "NOTO ANCHE COME LAURO, È UNA DELLE PIANTE PIÙ TIPICHE E PROFUMATE DELLA MACCHIA MEDITERRANEA, IL CUI IMPIEGO VERSATILE SPAZIA DAL GIARDINO ALLA CUCINA. ELEGANTE E ORNAMENTALE, BEN SI PRESTA A CREARE SIEPI IN FORMA LIBERA O GEOMETRICA. IN CUCINA NON PUÒ MANCARE NEL BOUQUET GARNI PER L’ARROSTO. LE SUE FOGLIE NELL'ANTICA GRECIA INCORONAVANO I VINCITORI DEI GIOCHI OLIMPICI E ANCORA OGGI È IN USO CINGERE IL CAPO DEI NEOLAUREATI CON RAMI D'ALLORO.",
                   DescrizioneeColtivazione = "L’alloro è un albero o un arbusto sempreverde che può superare 6-8 m di altezza, con foglie coriacee, lanceolate, di colore verde scuro. È una specie dioica, cioè con sessi separati: solo le piante femminili sviluppano bacche scure, di circa un centimetro di diametro. Può essere coltivato in vaso, oppure messo a dimora in piena terra a inizio primavera, in posizione soleggiata. Per la formazione di siepi le piante vanno distanziate di 45 cm l’una dall’altra.",
                   RaccoltaeConservazione = "Le foglie possono essere usate fresche oppure secche, conservate in barattoli di vetro. Il momento migliore per la raccolta è a fine inverno.",
                   SaluteeBellezza1 = "Pianta dai mille usi: le foglie essiccate tengono lontane le tarme dagli armadi, mentre quelle fresche, inserite tra le pagine dei libri, ne impediscono l’ingiallimento. Usate in infuso sono digestive, antifermentative e alleviano il mal di gola.",
                   SaluteeBellezza2 = "L’olio essenziale d’alloro ha virtù espettoranti, diuretiche e stomachiche (stimolanti della digestione); è inoltre utile per curare distorsioni, dolori reumatici, articolari e, non ultimo, per effettuare suffumigi che danno sollievo nelle malattie da raffreddamento.",
                   Incucina1 = "Le foglie di alloro si usano per insaporire secondi piatti, nella preparazione di marinate o per aromatizzare verdure e funghi sottolio. È sufficiente mezza foglia, senza eccedere con le carni bianche.",
                   Incucina2 = "Le bacche dell’alloro possono essere usate per produrre liquori.",

                   Propagazione = "Avviene per talea a fine estate. Le talee vanno interrate in un substto di torba e sabbia. In agosto si può utilizzare anche la propaggine, sfruttando lunghi rami bassi, incisi sulla parte inferiore. ",
                   Potatura = "Necessaria per eliminare i rami danneggiati o secchi. ",
                   Malattie = "Si può verificare la presenza di cocciniglie, eliminabili semplicemente con medicinali appositi. I danni di questi parassiti sono diretti, ma anche indiretti, sulla melata che producono infatti, si possono creare delle fumaggini. ",
                },

                new Aromatiche
                {
                   NomeComunePianta = "ANETO",
                   NomeFamiglia = "Ombrellifere",
                   NomeScientificoPianta = "Anethum graveolens",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Aneto/ANETO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "SIMILE AL FINOCCHIO, L’ANETO È APPREZZATO PER LE FOGLIE E PER I FRUTTI: LE PRIME SI UTILIZZANO FRESCHE PER INSAPORIRE INSALATE, PIATTI DI PESCE, VERDURE LESSATE E ZUPPE; I SECONDI, SIMILI A SEMI, HANNO UN SAPORE SIMILE ALL’ANICE E AROMATIZZANO MARINATE, SOTTACETI, CARNI E PESCI.",
                   DescrizioneeColtivazione = "Pianta annuale erbacea simile al finocchio, l’aneto raggiunge 90 cm di altezza. Dal fusto eretto e cavo si dipartono rametti con foglie sottili e penniformi, di colore verde-azzurro brillante. I fiori sono molto piccoli, gialli, riuniti in ombrelle di 5-10 cm di diametro. L’aneto ama l’esposizione al sole e le irrigazioni abbondanti, ma necessita di terreno ben drenato. Si può coltivare anche in vasi e fioriere sul terrazzo.",
                   RaccoltaeConservazione = "In cucina è preferibile usare le foglie fresche, ma si possono anche essiccare o surgelare, perdendo però così parte del colore e del sapore. I frutti si raccolgono in agosto, a maturazione avvenuta, quando diventano bruni. Si tagliano le ombrelle e si lasciano essiccare fino a che i frutti non si staccano. Si conservano poi in vasi a chiusura ermetica. ",
                   SaluteeBellezza1 = "I semi di aneto hanno caratteristiche terapeutiche simili a quelli dell’anice e del finocchio. Utili per curare le inﬁ ammazioni della bocca, aiutano la digestione, attenuano i dolori intestinali, il vomito, il singhiozzo ed eliminano i gas intestinali. Se masticati, sono anche un ottimo rimedio per chi soffre di alitosi. L’infuso ottenuto con i semi è un valido diuretico ed è un ingrediente immancabile per le tisane che stimolano la produzione di latte nelle donne in fase di allattamento.",
                   Incucina1 = "Tagliolini al salmone profumati all’aneto PER 4 PERSONE Fate imbiondire in una noce di burro una cipolla tagliata sottile; aggiungete 40 g di farina e 300 ml di latte, poi cuocete adagio fino a ottenere una salsa densa. Aggiungete 300 g di salmone affumicato a pezzetti e una manciata di aneto fresco tritato. Aggiustate di sale e spolverizzate con un po’ di pepe. Lessate 300-350 g di tagliolini in abbondante acqua salata, conditeli con la salsa e guarnite i piatti con un ciuffo di aneto fresco.",
                   Incucina2 = "",

                   Propagazione = "Per avere foglie fresche di aneto durante tutto il periodo estivo va seminato mensilmente, a partire da marzo-aprile, in file distanti tra loro 30 cm circa. Le piantine devono essere poi diradate in modo che siano intervallate sulla fila di 30 centimetri.",
                   Potatura = "Avviene per semi che vengono raccolti quando iniziano a diventare scuri. ",
                   Malattie = "Non è soggetta a particolari malattie.",
                },

                new Aromatiche
                {
                   NomeComunePianta = "ANGELICA",
                   NomeFamiglia = "Ombrellifere",
                   NomeScientificoPianta = "Angelica archangelica",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Angelica/ANGELICA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "È UNA PIANTA PROFUMATA IN OGNI SUA PARTE: PERFINO LE RADICI EMANANO UNA GRADEVOLE FRAGRANZA. UTILIZZATA IN ERBORISTERIA PER LA SALUTE E LA BELLEZZA, TROVA IMPIEGO ANCHE IN CUCINA: LE RADICI E I FRUTTI SI USANO PER PRODURRE LIQUORI E PER AROMATIZZARE GRIGLIATE E MARINATE, LE FOGLIE IN SALSE E ZUPPE, I FUSTI VENGONO CANDITI. ",
                   DescrizioneeColtivazione = "La pianta dell’angelica raggiunge anche 2 m di altezza. Il fusto è eretto e cavo, le foglie sono pennate. I fiori piccoli, di colore bianco-verdastro, sono riuniti in vistose ombrelle composte, e danno origine a semi di forma allungata.  Per stimolare la produzione di foglie è bene rimuovere le infiorescenze mano a mano che si formano. In questo modo le piante possono vivere anche alcuni anni. In caso contrario, l’angelica si comporta da biennale: il primo anno si sviluppa, il secondo fiorisce e va a seme e poi muore. ",
                   RaccoltaeConservazione = "I fusti per i canditi si raccolgono tra maggio e giugno, come pure le foglie da essiccare, che vanno staccate quando sono verde chiaro. Le radici, invece, si dissotterrano all’inizio dell’autunno. I frutti si raccolgono in agosto, come per l’aneto.",
                   SaluteeBellezza1 = "L’angelica, usata in piccole quantità, ha effetto stimolante, mentre in dosi elevate l’azione si inverte, sino a condurre a uno stato di forte depressione.",
                   SaluteeBellezza2 = "L’olio essenziale di angelica trova impiego nella cosiddetta “acqua delle carmelitane”, che è un noto sedativo; se assunto in forti dosi può risultare velenoso. Il succo fresco della pianta può irritare le mucose e la pelle, per cui è bene manipolare con prudenza le parti fresche. Le radici in passato venivano masticate come protezione dalle malattie infettive.",
                   Incucina1 = "Orata all’angelica PER 4 PERSONE Dopo averla pulita, tagliate a pezzetti un’orata di circa un chilo. Fate appassire un porro tagliato a rondelle in olio extravergine di oliva, aggiungete l’orata e fatela insaporire. Bagnate con mezzo bicchiere di vino bianco e lasciatelo evaporare. Aggiungete poca acqua o un mestolo di brodo assieme a una manciata di piccioli e foglie fresche di angelica tritati. Salate, pepate e lasciate cuocere circa mezz’ora a fuoco basso.",
                   Incucina2 = "",

                   Propagazione = "Si semina in marzo o in settembre in posizione soleggiata, in terreno ricco di sostanza organica, a file distanti tra loro circa 90 centimetri. Una volta nate, le piantine devono essere diradate lungo la fila, tenendo una distanza di 30 centimetri.",
                   Potatura = "La moltiplicazione avviene spesso spontaneamente. In caso contrario si può effettuare la semina all'inizio dell'autunno (tenendo presente che i semi devono essere freschi, in quanto perdono, in pochi mesi, la loro capacità germinativa) o si può procedere alla divisione dei cespi.",
                   Malattie = "Non è soggetta a malattie o ad attacchi parassitari.",
                },

                new Aromatiche
                {
                   NomeComunePianta = "ANICE",
                   NomeFamiglia = "Ombrellifere",
                   NomeScientificoPianta = "Pimpinella anisum",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Anice/ANICE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "I FRUTTI DELL'ANICE, IMPROPIAMENTE CHIAMATI SEMI, SONO MOLTO UTILIZZATI PER AROMATIZZARE LIQUORI, AI QUALI TRASFERISCONO LE LORO PROPRIETÀ DIGESTIVE. IN CUCINA SI USANO NELLA PREPARAZIONE DI DOLCI E PANE, MA ANCHE PER CUCINARE CARNI IN UMIDO O MARINATE, ALLA GRIGLIA O AL CARTOCCIO. LE FOGLIE FRESCHE INSAPORISCONO SALSE, SUGHI E ZUPPE. L'ANICE COMUNE NON VA CONFUSO CON L'ANICE STELLATO: IL PRIMO È CARATTERISTICO DELLE REGIONI MEDITERRANEE, MENTRE IL SECONDO È ORIGINARIO DEL SUDEST ASIATICO; HA SAPORE SIMILE MA MOLTO PIÙ INTENSO",
                   DescrizioneeColtivazione = "Può raggiungere 60 cm di altezza; il fusto presenta una fine peluria, con foglie basali lobato-incise e foglie superiori molto frastagliate. Le infiorescenze sono a forma di ombrella composta e portano piccoli fiori bianchi che si schiudono in giugno. I frutti maturano tra agosto e settembre. L’anice si coltiva in terreni di medio impasto, fertili, ricchi di calcare e ben esposti al sole.",
                   RaccoltaeConservazione = "La raccolta va fatta tra agosto e settembre, preferibilmente al mattino, quando la pianta è ancora umida, per evitare che i frutti si stacchino e cadano. Una volta seccate, le ombrelle vanno sbattute per far cadere i frutti, da conservare in contenitori a chiusura ermetica.",
                   SaluteeBellezza1 = "L’anice ha proprietà disinfettanti, antibatteriche e aromatizzanti. Il suo olio essenziale, costituito principalmente da anetolo, è utilizzato per confezionare dentifrici e saponi. Masticare semi di anice calma il singhiozzo. In erboristeria vengono sfruttate le proprietà digestivo-carminative, espettoranti e galattofore (che favoriscono la produzione di latte).",
                   SaluteeBellezza2 = "",
                   Incucina1 = "Tortelloni fritti all’anice PER 6 PERSONE Preparate un impasto omogeneo con 400 g di farina di segale, 100 g di farina di frumento, 30 g di burro fuso, 2 bicchieri di acqua tiepida, un cucchiaino di semi di anice e una presa di sale. Dividete il composto in 12 parti, da stendere ciascuna in una sfoglia del diametro di circa 18 centimetri. Preparate il ripieno con 200 g di ricotta, 120 g di zucchero e 150 g di semi di papavero macinati, amalgamate bene e distribuitelo su 6 dei 12 dischi preparati. Coprite ogni disco con uno dei 6 dischi rimasti e sigillate bene i bordi. Friggete i tortelloni in abbondante olio di oliva bollente, poi scolateli bene. Preparate un intingolo con 50 g di miele, 150 g di semi di papavero, un bicchiere d’acqua e fatelo bollire per un minuto. Irrorate i tortelloni e gustate questa dolce ricetta caratteristica delle Dolomiti.",
                   Incucina2 = "Liquore all’anice Pestate 25 g di semi di anice e metteteli a macerare per 2 mesi in mezzo litro di grappa insieme con un pizzico di cannella, uno di vanillina, 500 g di zucchero e 250 g di acqua. Trascorso tale tempo, filtrate e imbottigliate. È ottimo come digestivo.",

                   Propagazione = "La semina si effettua tra marzo e aprile su file distanti tra loro 60 centimetri. Quando hanno emesso le prime 4 foglie, le piantine vanno diradate, mantenendo una distanza sulla fila di 30 centimetri.",
                   Potatura = "Non è necessario effettuare potature particolari.",
                   Malattie = "Non è soggetta a malattie o ad attacchi parassitari.",
                },
                
                new Aromatiche
                {
                   NomeComunePianta = "BASILICO",
                   NomeFamiglia = "Labiate",
                   NomeScientificoPianta = "Ocimum basilicum",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Basilico/BASILICO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "É UNO DEGLI AROMI PIÙ UTILIZZATI NELLA CUCINA ITALIANA. I PIÙ DIFFUSI SONO IL BASILICO GENOVESE, DAL PROFUMO INTENSO E UTILIZZATO NEL CELEBRE PESTO, E IL NAPOLETANO, A FOGLIA DI LATTUGA, PIÙ DELICATO. DI GRANDE VERSATILITÀ GRAZIE AL SUO SAPORE FRESCO, IL BASILICO SI SPOSA CON UN GRAN NUMERO DI PIATTI ESTIVI, A CUI REGALA AROMA E COLORE.",
                   DescrizioneeColtivazione = "Il basilico è una pianta erbacea annuale della famiglia delle labiate, che comprende un gran numero di specie aromatiche d’uso comune; raggiunge 30-50 cm di altezza. Può essere coltivato sia nell’orto, in piena terra, sia in vaso, sul balcone o sul davanzale di una finestra. Per favorire lo sviluppo di un gran numero di foglie è necessario cimare spesso le piante e, raggiunta l’altezza definitiva, bisogna asportare le infiorescenze in formazione.  Essendo originario dell’Asia tropicale, il basilico necessita di climi caldo-temperati e di elevata umidità del terreno durante il ciclo di vegetazione.",
                   RaccoltaeConservazione = "La raccolta delle foglie fresche si protrae per tutta l’estate, se la pianta viene cimata. Per mantenere a lungo l’aroma del basilico, è consigliabile frullare le foglie, eventualmente aggiungendo ottimo olio extravergine di oliva, e conservarle in frigorifero, oppure in freezer, suddivise in piccole porzioni, in modo che siano sempre pronte all’utilizzo.  Le foglie ben pulite ma non lavate possono anche essere conservate intere in freezer, mentre mantengono poco l’aroma se vengono essiccate.",
                   SaluteeBellezza1 = "Del basilico sono note le proprietà aromatiche, stimolanti e toniche dell’organismo, utili per curare casi di debolezza, apatia ed esaurimento. È inoltre un eccellente stimolante dell’appetito e della digestione, soprattutto nelle dispepsie, ed è consigliato come carminativo e come antispasmodico per calmare le nausee e attenuare i crampi allo stomaco, oltre che per favorire la diuresi.",
                   SaluteeBellezza2 = "",
                   Incucina1 = "Pesto genovese Pestate una tazza di foglie di basilico pulite in un mortaio assieme a uno spicchio di aglio e a una presa di sale grosso. Aggiungete 2 cucchiai di pinoli, un cucchiaio di pecorino e uno di grana grattugiati. Pestate il tutto fino a ottenere un composto omogeneo e trasferitelo in una ciotola, in cui verserete a ﬁlo un bicchiere di olio extravergine di oliva amalgamandolo con cura. Continuate a mescolare con un cucchiaio di legno fino a ottenere una crema densa e perfettamente omogenea. Al momento dell’uso, diluitelo con un po’ di acqua di cottura della pasta. Si possono anche frullare gli ingredienti con il mixer, ma il risultato finale non uguaglierà comunque l’eccellenza del metodo tradizionale.",
                   Incucina2 = "",

                   Propagazione = "Si semina a marzo in semenzaio al riparo (i semi non germinano con temperature inferiori a 18 °C). Le piantine vanno messe in piena terra in maggio, a una distanza di 30 cm sulla fi la e di 40 cm tra le file.",
                   Potatura = "Prima della fioritura asportare i germogli apicali per mantenere forte l'aroma.",
                   Malattie = "Non è soggetto a malattie o parassiti particolari, va difeso dalle lumache nei giardini.",
                },

                new Aromatiche
                {
                   NomeComunePianta = "BORRAGINE",
                   NomeFamiglia = "Borraginacee",
                   NomeScientificoPianta = "Borago officinalis",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Borragine/BORRAGINE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "GRAZIOSA ANNUALE DAI FIORELLINI STELLATI BLU E DALLE GRANDI FOGLIE PELOSE (RICOPERTE DI PELI ISPIDI), CHE CONFERISCONO ALLE INSALATE UN OTTIMO SAPORE DI CETRIOLO E SI CONSUMANO ANCHE LESSATE O IMPANATE E FRITTE. I FIORI VENGONO CANDITI O IMMERSI NELL’ACETO PER PROFUMARLO.",
                   DescrizioneeColtivazione = "Cresce spontanea ai margini di strade e in mezzo alle colture, sempre in terreno fertile, sino a 1.800 m di quota. È una pianta erbacea alta 30-60 cm, molto ramificata, con numerose foglie ovate, quelle inferiori di grandi dimensioni, sempre più piccole verso l’apice, dove sbocciano i fiori a stella di colore azzurro vivo. Resistente al freddo, del tutto inesigente e veloce a svilupparsi, cresce però più rigogliosa nei terreni ben concimati e un po’ umidi, in pieno sole. Poiché tende a disseminarsi ovunque trasformandosi in infestante, è consigliabile rimuovere gli apici al termine della fioritura per impedire che vada a seme. Oltrettutto, con la formazione dei semi la pianta chiude il ciclo vegetativo e muore.",
                   RaccoltaeConservazione = "Durante il periodo di sviluppo si raccolgono solo le foglie che servono per l’uso immediato, perché appassiscono facilmente. Si conservano bene in freezer, pulite e non lavate, eventualmente già impanate per i fritti. L’essiccazione non dà buoni risultati per l’uso gastronomico (le foglie perdono il caratteristico sapore) mentre per l’uso medicinale va effettuata quanto più velocemente possibile, all’aria e all’ombra, appendendo a testa in giù le sommità fiorite.",
                   SaluteeBellezza1 = " La medicina popolare assegna alla borragine proprietà emollienti, sudorifere, diuretiche, lassative e depurative.",
                   SaluteeBellezza2 = "",
                   Incucina1 = "Torta salata di borragine Lavate 8 grosse manciate di foglie, scottatele in un dito di acqua bollente salata per 5 minuti e scolatele. Mentre raffreddano, preparate una besciamella con mezzo litro di latte, 4 cucchiai di farina e un pezzetto di burro. A fuoco spento salate, aggiungete qualche cucchiaiata di grana grattugiato e insaporite con pepe e noce moscata. Passate nel mixer le foglie di borragine con la besciamella e 4 uova. Aggiustate di sale e versate in una tortiera precedentemente rivestita di pasta sfoglia. Spolverate con pangrattato e qualche ricciolo di burro prima di passare in forno a 180 °C per circa 50 minuti. Questa torta è ottima tipieda o fredda.",
                   Incucina2 = "L’infuso di borragine (50 g di fiori e foglie in un litro d’acqua bollente per 10 minuti) è un disinfettante e lenitivo del cavo orale se usato come colluttorio; aggiunto all’acqua del bagno, ammorbidisce la pelle e calma il prurito. Le foglie fresche pestate e applicate su ascessi, scottature e infiammazioni della pelle alleviano il dolore e sono emollienti.",

                   Propagazione = "Nell’orto va seminata all’inizio della primavera per l’uso in estate, oppure in autunno per il raccolto tardo invernale e primaverile.",
                   Potatura = "Non è necessario effettuare potature particolari.",
                   Malattie = "Non è soggetta a particolari malattie o parassiti.",
                },

                new Aromatiche
                {
                   NomeComunePianta = "CALENDULA",
                   NomeFamiglia = "Composite",
                   NomeScientificoPianta = "Calendula officinalis",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Calendula/CALENDULA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "ASSOMIGLIA MOLTO ALLA MARGHERITA, DALLA QUALE SI DISTINGUE PER L’INTENSO AROMA CHE EMANANO LE FOGLIE QUANDO VENGONO STROFINATE E PER IL VIVIDO COLORE GIALLO-ARANCIO DEI FIORI (RACCOLTI IN CAPOLINI DI 3-5 CM DI DIAMETRO), CHE LA RENDONO MOLTO DECORATIVA.",
                   DescrizioneeColtivazione = "Pianta perenne che produce bassi cespuglietti di foglie verde chiaro da cui si ergono gli robusti steli vellutati che fioriscono per tutta l’estate e, nei climi miti, per quasi tutto l’anno. Si coltiva con facilità, in giardino oppure in vaso. Ha bisogno di terreno fertile e ben drenato, posizioni soleggiate e irrigazioni costanti in estate. I fiori appassiti devono essere eliminati con regolarità.",
                   RaccoltaeConservazione = "La raccolta viene in genere eseguita manualmente, effettuando più passaggi in campo, seguendo la scalarità di fioritura della coltura. I fiori una volta raccolti vanno disposti in strati di 15-20 cm. L'essiccazione va eseguita subito dopo la raccolta, utilizzando all'inizio temeperature elevate (50-60°C) per eliminare velocemente rugiada condensa da respirazione ed acqua da vegetazione, nonchè per fissarne il colore. Poi la temperatura va subito abbassata per non denaturare i principi attivi. I fiori devono essere conservati in luoghi asciutti.",
                   SaluteeBellezza1 = "La calendula presenta spiccate proprietà antiffiammatorie, antisettiche, cicatrizzanti, rinfrescanti, emollienti e dermofunzionali. Per questo viene impiegata per produrre preparati as uso esterno, topico o che rientrano in formulazioni più complesse per la detergenza e l'igiene della persona. Viene anche impiegata sotto forma di tintura madre in oleoliti o pomate in caso di punture di insetti, ferite, eczemi, dermatiti, foruncoli, irritazioni e arrossamenti.",
                   SaluteeBellezza2 = "",
                   Incucina1 = " I petali si impiegano crudi per colorare risotti, insalate, frittate. I fiori in boccio si possono mettere sottaceto o candire.",
                   Incucina2 = "",

                   Propagazione = "Tramite semina in primavera direttamente all'aperto, diradando successivamente le piantine, appena sono maneggiabili.",
                   Potatura = "E' sufficiente recidere i fiori appassiti.",
                   Malattie = "Può essere soggetta a vari tipi di fungo. La presenza dell'oidio è evidenziata dalla muffa farinosa che possiamo trovare sulla pianta. Tale muffa si combatte con karathane. Il cosidetto 'mosaico del cetriolo' è causa di deformazioni e chiazze gialle sulle foglie: eliminare le parti colpite. Le foglie, possono essere infestate da larve minatrici ( Phytomyza atricormis), contro le quali sono efficaci gli esteri fosforici. ",
                },

                new Aromatiche
                {
                   NomeComunePianta = "CAMOMILLA",
                   NomeFamiglia = "Composite",
                   NomeScientificoPianta = "Chamaemelum nobile, Matricaria chamomilla",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Camomilla/CAMOMILLA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "DI CAMOMILLA NON CE N’È UNA SOLA: LA PIÙ NOTA È LA CAMOMILLA ROMANA (CHAMAEMELUM NOBILE), DAI CAPOLINI PIÙ GRANDI, MENTRE QUELLA CHE COLONIZZA LE STRADINE DI CAMPAGNA È LA CAMOMILLA COMUNE (MATRICARIA CHAMOMILLA). CONDIVIDONO LE STESSE POPRIETÀ: ANTINFIAMMATORIE, SEDATIVE E ANTISPASMODICHE. ",
                   DescrizioneeColtivazione = "Piante erbacee alte circa 50 cm, la camomilla romana è perenne strisciante, la comune è annuale ed eretta. Le foglie sono alterne e sessili. Le infiorescenze (capolini) sono costituite da fiori gialli, tubolari ed ermafroditi al centro, e da fiori bianchi, ligulati, femminili in posizione distale. Facili e inesigenti, si coltivano in piena terra o in vaso, al sole, su terra anche povera. Desiderano poca acqua e un ottimo drenaggio. ",
                   RaccoltaeConservazione = "I capolini si raccolgono in estate in piena fioritura, si fanno essiccare in luoghi asciutti, ombrosi e ventilati, e si conservano in barattoli di vetro al riparo dalla luce. Per ottenere la massima quantità di olio essenziale, i capolini devono essere raccolti quando la maggior parte dei fiori ligulati si trova in posizione orizzontale rispetto allo stelo.",
                   SaluteeBellezza1 = "La camomilla ha importanti proprietà antibatteriche e neutralizzanti, cicatrizzanti, disodoranti, muscolotrope, spasmolitiche e antiflogistiche. Stimola inoltre il metabolismo cutaneo. ",
                   SaluteeBellezza2 = "",
                   Incucina1 = "I capolini sono ottimi per bagni rilassanti, impacchi emollienti e tisane calmanti e digestive che favoriscono il sonno.",
                   Incucina2 = "",

                   Propagazione = "Avviene per seme.",
                   Potatura = "Eliminare le parti sfiorite che rendono sgraziata la pianta.",
                   Malattie = "Non è soggetta a malattie o parassiti particolari.",
                },

                new Aromatiche
                {
                   NomeComunePianta = "CAPPERO",
                   NomeFamiglia = "Capparidacee",
                   NomeScientificoPianta = "Capparis spinosa",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Cappero/CAPPERO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "IL CAPPERO È UN ARBUSTO TIPICO DEI PAESI CALDI CHE CRESCE SPONTANEO SU VECCHI MURI E TRA LE ROCCE. IL SUO FRUTTO, UNA BACCA ALLUNGATA PRIMA VERDE E POI ROSSICCIA, È UN INGREDIENTE BASE DELLA CUCINA MEDITERRANEA, MOLTO DIFFUSO SOPRATTUTTO IN SICILIA. ",
                   DescrizioneeColtivazione = "È una suffruticosa perenne, dalle forti radici che si abbarbicano sui muri, da dove pendono i fusti lunghi fino a 1,5 m, che portano foglioline tondeggianti e lucide e bellissimi fiori estivi biancorosati dotati di lunghi stami violetti. Si coltiva (preferibilmente per talea) in terreni sassosi, aridi, calcarei, in giardini rocciosi o su muretti a secco, in posizione soleggiata, esposta a Sud nel Settentrione. Richiede pochissima acqua.",
                   RaccoltaeConservazione = "Le proprietà aromatiche sono contenute nei boccioli del fiore, comunemente chiamati capperi. Utilizzati in gastronomia da millenni, si raccolgono ancora chiusi e si conservano in macerazione sotto sale o sotto aceto.",
                   SaluteeBellezza1 = "I capperi contengono più quercetina in rapporto al peso di ogni altra pianta. In erboristeria è utilizzata la corteccia della radice. I principi attivi hanno proprietà diuretiche e protettrici dei vasi sanguigni. Può essere utilizzata nella cura della gotta, delle emorroidi, delle varici. Un infuso preparato con radici di cappero e germogli giovani era utilizzato in medicina popolare per alleviare i reumatismi. ",
                   SaluteeBellezza2 = "",
                   Incucina1 = "I capperi sono solitamente usati per aromatizzare le pietanze e si sposano bene con una grande varietà di cibi: dalla carne, al pesce, alla pasta. I capperi piccoli sono i più saporiti; vanno però conservati per sprigionare il tipico aroma: dopo un giorno all’aria aperta, si pongono sotto sale o sott’aceto.",
                   Incucina2 = "In ambito culinario vengono utilizzate anche le giovani foglie come insalata, previa cottura per pochi minuti in acqua bollente. ",

                   Propagazione = "La talea si esegue in estate, prelevando un pezzo di 7–10 cm di un ramo legnoso di 2-3 anni d'età, quindi lo si pone in una cassetta riempita di torba e sabbia. Per favorire la radicazione è consigliato l'uso di polveri radicanti. Formatesi le radici, si prelevano le piantine e si invasano singolarmente in vasetti di circa 10 cm di diametro. La propagazione per seme è difficoltosa dato che la germinazione dei semi è buona solo se i semi sono seminati immediatamente dalla raccolta dai frutti.",
                   Potatura = "Non è necessario effettuare potature particolari.",
                   Malattie = "Non è soggeto a parassiti o malattie specifiche. I problemi possono derivare dalla collocazione in terreni non adatti: il cappero può ingiallire a causa di marciumi che coinvolgono l'apparato radicale. ",
                },

                new Aromatiche
                {
                   NomeComunePianta = "CEDRINA",
                   NomeFamiglia = "Verbenaceae",
                   NomeScientificoPianta = "Lippia citriodora",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Cedrina/CEDRINA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "PIANTA ORIGINARIA DEL CILE, CONOSCIUTA ANCHE COME ERBA LUIGIA, LA CEDRINA È APPREZZATA PER LE SUE FOGLIE ODOROSE DI LIMONE CHE TROVANO IMPIEGO SIA FRESCHE SIA SECCHE NELLE MISCELE AROMATICHE PER ARROSTI, GRIGLIATE E MARINATE, PER GUARNIRE PIATTI DI PORTATA E NELLA PREPARAZIONE DI LIQUORI ALLE ERBE. ",
                   DescrizioneeColtivazione = "La cedrina è una pianta arbustiva che può superare il metro di altezza, con foglie ruvide, lanceolate, di colore verde chiaro, e piccoli fiori bianco-rosei, tubuliformi, riuniti in pannocchie lunghe una decina di centimetri che si formano in estate. Alla ripresa vegetativa primaverile le piante vanno potate energicamente, per mantenerle di dimensioni contenute. Temono il gelo, ma quasi sempre sopravvivono emettendo nuovi germogli dalla base.",
                   RaccoltaeConservazione = "In genere si utilizzano le foglie fresche, da utilizzare al momento. Per la conservazione, invece, la raccolta va eseguita al mattino, scegliendo le foglie più sviluppate e sane, da far seccare all’ombra e da riporre in un vaso di vetro a chiusura ermetica. Il momento migliore per la raccolta è all’inizio della fioritura, quando le foglie sono più profumate. Non attendete però la completa formazione delle infiorescenze, che sottraggono energia e proprietà alla pianta.",
                   SaluteeBellezza1 = "Le foglie della cedrina sono utilizzate per aromatizzare tisane. Così come quelle di salvia, possono essere utilizzate per pulire gengive e denti, sfregandole energicamente e ottenendo anche l’effetto di profumare l’alito. ",
                   SaluteeBellezza2 = "Inoltre, si possono fare bagni aromatici, deodoranti e stimolanti immergendo un pugno di foglie, chiuse in un sacchetto di tela, nell’acqua calda della vasca da bagno.",
                   Incucina1 = "Liquore alla cedrina Raccogliete 40 foglie di cedrina, unite la scorza di un’arancia e quella di un limone non trattati, 2 chiodi di garofano, un pezzetto di cannella, 400 g di alcol puro per liquori, 400 g di acqua e 300 g di zucchero. Mettete tutti gli ingredienti, esclusi acqua e zucchero, in infusione per 12 giorni, poi preparate uno sciroppo sciogliendo sul fuoco a fiamma bassa lo zucchero nell’acqua. Unite l’infuso allo sciroppo raffreddato, scuotete, filtrate, imbottigliate e lasciate invecchiare per un anno. Il liquore ha proprietà digestive e corroboranti.",
                   Incucina2 = "",

                   Propagazione = "Si propaga per talea: le nuove piantine devono essere interrate a maggio, in vaso o in piena terra alla distanza di un metro l’una dall’altra, in zone riparate ed esposte in pieno sole. ",
                   Potatura = "Eliminare le parti secche o danneggiate.",
                   Malattie = "La pianta non è particolarmente soggetta all'attacco di parassiti e malattie. In ogni caso, se gli apici delle foglie e dei germogli appassiscono significa che la pianta soffre la siccità. E' importante tenere il terreno ben drenato perché i ristagni d'acqua provocano l'ingiallimento delle foglie.",
                },

                new Aromatiche
                {
                   NomeComunePianta = "CERFOGLIO",
                   NomeFamiglia = "Ombrellifere",
                   NomeScientificoPianta = "Anthriscus cerefolium",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Cerfoglio/CERFOGLIO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "LE FOGLIE SONO MOLTO SIMILI AL PREZZEMOLO, MENTRE LA FRAGRANZA RICORDA DECISAMENTE L’ANICE. IN CUCINA SE NE UTILIZZANO I FRUTTI E LE FOGLIE: I PRIMI PER MISCELE AROMATICHE, LE SECONDE PER INSAPORIRE SUGHI, SALSE, ZUPPE, FRITTATE, VERDURE E PIETANZE AL CARTOCCIO. ",
                   DescrizioneeColtivazione = "Specie biennale che raggiunge 45 cm di altezza, il cerfoglio ha foglie incise, sottili, portate da un lungo gambo. I fiorellini, bianchi, sono riuniti in ombrelle del diametro di 7-8 cm e compaiono nell’estate dell’anno successivo alla semina. Nelle zone con climi gelidi, le piante vanno coperte durante l’inverno. ",
                   RaccoltaeConservazione = "Generalmente le foglie si utilizzano fresche, raccogliendole al momento. Possono anche essere essiccate, raccogliendole dopo 6-8 settimane dalla germogliazione e comunque prima della fioritura. L’essiccazione è però piuttosto lenta. Per prolungare la produzione di foglie fresche è bene asportare le ombrelle dei fiori prima che siano completamente formate. I frutti vanno raccolti seguendo lo stesso procedimento adottato per le altre ombrellifere, quali aneto e angelica. Allo stato spontaneo il cerfoglio può facilmente essere confuso con altre piante velenose, motivo per cui è bene che la raccolta in natura sia effettuata solo da persone esperte.",
                   SaluteeBellezza1 = "Il decotto di cerfoglio è un ottimo tonico per le pelli grasse. L’infuso è consigliato nelle cure depurative e contro l’ipertensione, poiché aiuta ad abbassare la pressione. Le foglie stimolano l’appetito e la digestione e sono leggermente diuretiche. Il succo fresco con il latte tiepido calma la tosse, mentre aggiunto a un po’ d’acqua è dissetante. L’impacco di foglie tritate calma le infiammazioni provocate da punture di insetti.",
                   SaluteeBellezza2 = "",
                   Incucina1 = "Vellutata al cerfoglio PER 4 PERSONE Sciogliete un cucchiaio di burro in una pentola bassa e fatevi appassire per alcuni minuti 3 cipolle affettate grossolanamente; aggiungete un cucchiaio di farina, mescolate e coprite d’acqua. Lasciate cuocere per 15 minuti, quindi aggiungete 2 cucchiaini di sale, 150 g di cerfoglio tritato e 1,5 dl di panna. Riducete il tutto in purea direttamente nella pentola con il frullatore a immersione, portate a bollore, aggiustate di sale, spolverate di pepe bianco e servite la vellutata ben calda, decorando il piatto con un ciuffo di foglie fresche di cerfoglio.",
                   Incucina2 = "",

                   Propagazione = "Per avere a disposizione foglie fresche tutto l’anno, è consigliabile seminare a intervalli mensili da marzo ad agosto, diradando poi le piantine per distanziarle sulla fila e tra le file di circa 30 centimetri.",
                   Potatura = "Per favorire lo sviluppo vegetativo e mantenere elevata la qualità aromatica delle foglie è meglio cimare le infiorescenze man mano che si formano. Le foglie fresche vanno colte tagliando il picciolo alla base della pianta, in questo modo sarà agevolato lo sviluppo di nuovi germogli.",
                   Malattie = "Non presenta sensibilità a nessuna malattia in particolare.",
                },

                new Aromatiche
                {
                   NomeComunePianta = "CONSOLIDA",
                   NomeFamiglia = "Borraginacee",
                   NomeScientificoPianta = "Symphytum officianale",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Consolida/CONSOLIDA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "QUESTA GRAZIOSA ERBACEA DIFFUSA LUNGO I FOSSI E NELLE ZONE UMIDE, È UN VERO CONCENTRATO DI SOSTANZE SALUTARI: CONTIENE TANTISSIME PROTEINE (PER ESSERE UN VEGETALE), SALI MINERALI E VITAMINE A, C, B12.",
                   DescrizioneeColtivazione = "Pianta perenne, presenta una radice a fittone lunga fino a 3 m, fusti cavi e pelosi alti fino a 1 m, foglie lanceolate e ruvide e piccoli fiori lilla o bianchi, penduli e campanulati, nella tarda primavera. La consolida si mette a dimora in posizione soleggiata, in terreno umido e ricco di sostanze nutritive. ",
                   RaccoltaeConservazione = "Le foglie si raccolgono in estate e si usano in insalata o lessate. ",
                   SaluteeBellezza1 = " L’infuso di foglie essiccate calma la tosse, mentre quello di radici essiccate si unisce all’acqua del bagno e svolge un’azione emolliente. I cataplasmi di foglie e radici curano contusioni e dolori articolari.",
                   SaluteeBellezza2 = "",
                   Incucina1 = "I gambi vengono sbollentati come gli asparagi. ",
                   Incucina2 = "",

                   Propagazione = "Avviene per seme in primavera.",
                   Potatura = "Non è necessario effettuare potature particolari.",
                   Malattie = "Non presenta sensibilità a nessuna malattia in particolare. ",
                },

                new Aromatiche
                {
                   NomeComunePianta = "CORIANDOLO",
                   NomeFamiglia = "Ombrellifere",
                   NomeScientificoPianta = "Coriandrum sativum",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Coriandolo/CORIANDOLO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "IL PROFUMO DEL FRUTTO RICORDA LA SCORZA DEGLI AGRUMI, E IN PARTICOLARE DELL’ARANCIA ED È UNO DEI PRINCIPALI INGREDIENTI DEL CURRY, MA SI USA ANCHE IN MOLTE ALTRE PREPARAZIONI DOLCI E SALATE. E ANCORA IN PROFUMERIA E IN PASTICCERIA. ",
                   DescrizioneeColtivazione = "La pianta del coriandolo ha fusto eretto e liscio che può raggiungere il metro di altezza, con foglie maleodoranti finemente divise, fiori bianchi riuniti in ombrelle e piccoli frutti sferici di colore chiaro. Pianta annuale che teme il freddo.",
                   RaccoltaeConservazione = "La raccolta va effettuata in agosto, quando le ombrelle ingialliscono e i frutti sono ormai maturi. Il momento migliore è al mattino, mentre le piante sono ancora umide di rugiada, perché dalle ombrelle secche i semi cadono facilmente. I frutti ben essiccati si conservano a lungo in vasi di vetro dotati di chiusura ermetica, riposti in un luogo fresco e asciutto.",
                   SaluteeBellezza1 = "Grazie alle sue proprietà stomachiche e carminative, il coriandolo può risolvere problemi di digestione lenta, spasmi gastrici e anche colon irritabile da stress.",
                   SaluteeBellezza2 = "Un pugno di frutti di coriandolo in infusione nell’acqua calda del bagno o in quella del pediluvio ha effetto stimolante e deodorante. In cosmetica, l’olio è utilizzato come componente della fragranza di saponette, creme, lozioni e profumi.",
                   Incucina1 = "Liquore al miele e coriandolo Fate sciogliere su fuoco basso 500 g di miele di acacia o di tiglio. Fuori dal fuoco aggiungete 400 g di alcol etilico a 70°, 100 ml di acqua, 150 ml di vino bianco, la scorza grattugiata di un limone non trattato e qualche frutto di coriandolo pestato e ridotto in polvere. Amalgamate bene gli ingrediente, imbottigliate il tutto e lasciate riposare il liquore per un paio di mesi, inﬁ ne filtrate e imbottigliate di nuovo in un recipiente pulito.",
                   Incucina2 = "",

                   Propagazione = "Si seminata nella tarda primavera in terreni esposti al sole e riparati, distanziando i semi di 30 cm tra le file e diradando le piantine a 15 cm sulla fila.",
                   Potatura = "Non è necessario effettuare potature particolari.",
                   Malattie = "non è soggetta a particolari tipi di malatite o parassiti.",
                },

                new Aromatiche
                {
                   NomeComunePianta = "CUMINO",
                   NomeFamiglia = "Apiacee",
                   NomeScientificoPianta = "Carum Carvi",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Cumino/CUMINO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "IL CUMINO, NOTO ANCHE COME CARVI, PUÒ ESSERE OSSERVATO IN NATURA NEI PRATI ALPINI AL DI SOPRA DEI 1000 M. IN CUCINA SE NE USANO SIA LE FOGLIE FRESCHE SIA I FRUTTI DI SALSE, ARROSTI E GRIGLIATE. IN ALTO ADIGE, COSÌ COME IN ALTRI PAESI DI TRADIZIONE GERMANICA, IL CUMINO È UTILIZZATO PER AROMATIZZARE E DECORARE VARI TIPI DI PANE. ",
                   DescrizioneeColtivazione = "Specie biennale con fusto ramificato, ha piccoli fiori bianchi o bianco-rosati riuniti in ombrelle.   ",
                   RaccoltaeConservazione = "La fioritura avviene l’anno successivo a quello della semina, tra maggio e luglio. La raccolta dei frutti va fatta prima della completa maturazione, tra metà luglio e metà agosto, tagliando le ombrelle e facendole seccare a testa in giù. Durante l’essiccazione parte dei frutti si distaccherà spontaneamente; per separare i restanti sarà sufficiente sbattere le ombrelle ormai secche, conservando poi i frutti in un barattolo ermetico.",
                   SaluteeBellezza1 = "Per uso esterno il cumino stimola la circolazione periferica e ha un’azione disinfettante su mucose e pelle. Per un buon bagno stimolante e purificante mettete nell’acqua calda un pugno di frutti. Tradizionalmente il cumino viene usato nelle tisane per accentuare la secrezione lattea delle donne in allattamento e per conferire al latte un sapore gradito ai neonati. Una bevanda digestiva a fine pasto si ottiene mettendo in infusione per 20 minuti un pizzico di frutti di cumino in una tazza da tè di acqua bollente.",
                   SaluteeBellezza2 = "",
                   Incucina1 = "Arrosto con patate al cumino PER 4 PERSONE Tagliate in grossi pezzi 1,2 kg di carne di maiale (spuntature e spalla), insaporite con un pizzico di sale e pepe, qualche spicchio di aglio schiacciato e una presa di semi di cumino. Fate rosolare la carne in una pentola con un po’ di olio extravergine di oliva e cucinatela aggiungendo poca acqua. Dopo 30 minuti circa di cottura aggiungete un chilo di patate sbucciate e tagliate a tocchi. Aggiustate di sale e fate cuocere ancora per circa un’ora, aggiungendo acqua all’occorrenza. Prima di portare in tavola il recipiente di cottura, cospargete la pietanza con altri semi di cumino.",
                   Incucina2 = "",

                   Propagazione = "Si semina in primavera in terreno sciolto, fresco e ben esposto, in file distanti 40 centimetri. Quando le piantine sono alte circa 5 cm, si diradano sulla fila a una distanza di circa 25 cm tra loro.",
                   Potatura = "Non è necessario effettuare potature particolari.",
                   Malattie = "non è soggetta a particolari tipi di malatite o parassiti.",
                },

                new Aromatiche
                {
                   NomeComunePianta = "ERBA CIPOLLINA",
                   NomeFamiglia = "Liliacee",
                   NomeScientificoPianta = "Allium schoenoprasum",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Erba Cipollina/ERBA CIPOLLINA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "QUESTA PICCOLA BULBOSA DELLA FAMIGLIA DEI GIGLI HA UN ALLEGRO EFFETTO DECORATIVO ANCHE NELLE AIUOLE E NELLE BORDURE, SIA PER LA DUREVOLE FIORITURA ESTIVA ROSA, CON BEI CAPOLINI SFERICI, SIA PER I FASCI DI LUNGHE FOGLIE CAVE E CILINDRICHE, AMPIAMENTE UTILIZZATE IN CUCINA PER IL CARATTERISTICO AROMA DI CIPOLLA, MA PIÙ DELICATO E DOLCE. ANCHE IL BULBO TROVA IMPIEGO IN CUCINA, SIA CRUDO PER CONDIRE INSALATE, SIA COTTO PER INSAPORIRE PIETANZE.",
                   DescrizioneeColtivazione = "L’erba cipollina è una bulbosa perenne della famiglia delle liliacee con foglie sottili e tubolari di colore verde scuro, che raggiungono 25 cm di altezza. I fiori sono rosa intenso, riuniti in capolini globosi portati da lunghi steli. Ama i terreni fertili e profondi, ma si adatta piuttosto bene anche alla coltivazione in vaso. Per favorire la produzione di foglie è bene tagliare le infiorescenze man mano che si sviluppano. Ogni 2-3 anni, in ottobre, si dividono e si trapiantano i cespi.  Le foglie si seccano completamente durante l’inverno, per rispuntare nuovamente in primavera. Una nota a parte va dedicata all’aspetto ornamentale di questa aromatica. Se piantata in giardino, con la sua fioritura di giugno rallegra aiuole e bordure e, ai piedi delle rose, ha una funzione repellente contro gli afidi, che infestano di frequente la regina dei fiori. ",
                   RaccoltaeConservazione = "La raccolta si effettua tagliando le foglie alla base. Vanno usate fresche poiché sia l’essiccazione sia il congelamento non danno risultati soddisfacenti. Per avere foglie fresche anche d’inverno, è sufficiente coltivare qualche piantina sui davanzali interni della cucina.",
                   SaluteeBellezza1 = "Pur non avendo un impiego corrente in erboristeria, a questa pianta, come ad altre della stessa famiglia, sono riconosciute proprietà diuretiche e antiscorbutiche. Insieme con il rafano, i chiodi di garofano e altre erbe aromatiche, l’erba cipollina trova impiego anche nella produzione di un ottimo aceto aromatizzato, coadiuvante della buona digestione.",
                   SaluteeBellezza2 = "",
                   Incucina1 = "Melanzane piccanti all’erba cipollina Sbucciate e tagliate a striscioline 2 kg di melanzane, cospargetele di sale e mettetele per mezz’ora a perdere l’acqua di vegetazione. Fate bollire un litro di aceto di vino bianco con 2 cucchiai di zucchero, unite le melanzane e riportate a bollore per qualche minuto, poi scolate conservando il liquido. Alle melanzane calde unite 120 ml di olio extravergine di oliva, 2 cucchiai di origano e 3 cucchiai di erba cipollina tritata. Trasferite il tutto in vasi puliti, unendo mezzo peperoncino e 4 spicchi di aglio puliti per ogni barattolo. Pressate le melanzane con un cucchiaio e irrorate con l’aceto di cottura raffreddato prima di chiudere i vasi.",
                   Incucina2 = "",

                   Propagazione = "La propagazione avviene per seme o per divisione dei cespi. La semina può essere effettuata in piena terra tra marzo e aprile, in solchi poco profondi. Le piantine ottenute in semenzaio vanno invece trapiantate a primavera inoltrata, tenendo 40-50 cm di distanza tra le file e 25 cm sulla fila. ",
                   Potatura = "Può avvenire per seme o per divisione dei cespi.",
                   Malattie = "E' una pianta molto resistente all' attacco di parassiti.",
                },

                new Aromatiche
                {
                   NomeComunePianta = "FINOCCHIO SELVATICO",
                   NomeFamiglia = "Ombrellifere",
                   NomeScientificoPianta = "Foeniculum vulgare",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Finocchio Selvatico/FINOCCHIO SELVATICO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "AROMATICA INTENSAMENTE ODOROSA, MOLTO APPREZZATA PER L’INCONFONDIBILE SAPORE, IL FINOCCHIO SELVATICO O FINOCCHIETTO È AMPIAMENTE UTILIZZATO IN CUCINA E HA SPICCATE PROPRIETÀ DIGESTIVE. CRESCE NELLE REGIONI DELL'ITALIA CENTRALE E MERIDIONALE E SI TROVA ALLO STATO SPONTANEO NEI CAMPI INCOLTI E LUNGO LE BORDURE DELLE STRADE.",
                   DescrizioneeColtivazione = "Pianta erbacea perenne alta fino a 1,5 m, possiede una grossa radice a fittone. Le foglie sono filiformi e dotate di una guaina che riveste il fusto. I fiori, bianchi e piccoli, sono riuniti in ombrelle; i frutti sono costituiti da due semi schiacciati. Il finocchio è una specie rustica che teme il freddo e le eccessive annaffiature ma, a parte questo, non richiede particolari cure e si adatta con facilità a qualsiasi tipo di terreno. ",
                   RaccoltaeConservazione = "Il finocchio ha la caratteristica di contenere il tipico aroma che lo contraddistingue in tutte le parti della pianta: semi, foglie, rametti giovani, germogli. A parte i semi, che devono essere raccolti nel periodo di maturazione (da ottobre a novembre), tutte le altre parti possono essere raccolte al momento dell’utilizzo. I semi si conservano facilmente all’interno di vasi o barattoli di vetro, senza bisogno di effettuare alcun trattamento. Le altre parti si mantengono bene in frigorifero e le foglie, ottime per aromatizzare zuppe e minestre, possono anche essere congelate.",
                   SaluteeBellezza1 = "Il finocchio è ricco di proprietà digestive, diuretiche, antispasmodiche e antifermentative. Uno dei suoi costituenti principali, l’anetolo, ha qualità balsamiche e ﬂ uidiﬁ ca le secrezioni catarrali. ",
                   SaluteeBellezza2 = "L’infuso ricavato con i semi è noto, oltre che per la capacità di favorire i processi digestivi, perché stimola e aumenta la montata lattea nelle puerpere. Inoltre, rende il sapore del latte più dolce e gradevole.",
                   Incucina1 = "Pane al finocchio Setacciate sulla spianatoia un chilo di farina a fontana con una presa di sale, versate al centro 30 g di lievito sciolto in acqua tiepida zuccherata e impastate unendo 2 bicchieri di birra a temperatura ambiente. Incorporate la scorza grattugiata di un’arancia, 20 g di semi di ﬁ nocchio e amalgamate il tutto. Date al pane la forma desiderata, fatelo lievitare finché non raddoppia il suo volume e cuocetelo a 180 °C in forno caldo per circa 20 minuti.",
                   Incucina2 = "",

                   Propagazione = "La propagazione avviene per seme, anche spontaneamente se si lasciano alcuni frutti attaccati alla pianta. Questi, infatti, cadendo si pianteranno nel terreno e genereranno nuovi esemplari, per cui non sarà necessario ripetere la semina. ",
                   Potatura = "Poiché, se non si interviene, il finocchio ha la tendenza a divenire infestante, è opportuno recidere la pianta alla base dopo la raccolta dei frutti, così da permettere ai nuovi germogli di formarsi e svilupparsi.",
                   Malattie = "Può essere soggetto a marciumi in caso di eccessi idrici o di ambiente troppo umido.",
                },

                new Aromatiche
                {
                   NomeComunePianta = "ISSOPO",
                   NomeFamiglia = "Lamiacee",
                   NomeScientificoPianta = "Hyssopus officinalis",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Issopo/ISSOPO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "MOLTO DECORATIVO CON LE SUE BELLE SPIGHE DI FIORI BLU IN GIUGNO-LUGLIO, L’ISSOPO VIENE COLTIVATO PER LE SUE PROPRIETÀ AROMATICHE E PER IL SUO VALORE ORNAMENTALE: IN GIARDINO FORMA BORDURE DENSE E PROFUMATE (TUTTA LA PIANTA È FRAGRANTE).",
                   DescrizioneeColtivazione = "Erbacea perenne, ha rami eretti, foglie piccole e lanceolate e fiori vagamente simili a quelli della lavanda. Si coltiva in terra o in vaso, in pieno sole, con terreno povero e ben drenato. Teme il freddo e l’umido. Desidera poca acqua e concime organico solo in autunno. ",
                   RaccoltaeConservazione = "Si utilizzano le foglie e le cime fiorite: le prime aggiungono un gradevole sapore amarognolo e piccante a insalate, minestre, arrosti e ragù, i fiori entrano nella composizione dei liquori d’erbe. ",
                   SaluteeBellezza1 = "Essiccato (a mazzetti, a testa in giù, all’ombra) si utilizza per infusi disintossicanti, espettoranti, digestivi.",
                   SaluteeBellezza2 = "",
                   Incucina1 = "",
                   Incucina2 = "",

                   Propagazione = "Avviene per seme o per divisione dei cespi.",
                   Potatura = "Non è necessario effettuare potature particolari.",
                   Malattie = "Non è soggetto a malattie o parassiti particolari.",
                },

                new Aromatiche
                {
                   NomeComunePianta = "LAVANDA",
                   NomeFamiglia = "Labiate",
                   NomeScientificoPianta = "Lavandula officinalis",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Lavanda/LAVANDA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "È RICCA DI FASCINO PER IL SUO IRRESISTIBILE PROFUMO DI PULITO E PER IL PORTAMENTO ARROTONDATO DEI SUOI CESPUGLI CHE LA RENDE IDEALE PER REALIZZARE BORDURE DI GRANDE EFFETTO. TANTI SONO I TIPI IN COLTIVAZIONE, MA L. OFFICINALIS È QUELLA CON LE CARATTERISTICHE AROMATICHE PIÙ SPICCATE. IN CUCINA VENGONO USATI SIA I FIORI SIA LE FOGLIE, FRESCHI O ESSICCATI, PER GRIGLIATE, ARROSTI E MARINATE. LE SOMMITÀ FIORITE ENTRANO ANCHE NELLA FAMOSA MISCELA  DI 'ERBE DI PROVENZA', MENTRE DA FRESCHE POSSONO DECORARE PIATTI DI PRESENTAZIONE. LA LAVANDA È TRA LE PIANTE MELLIFERE: SE NE RICAVA UN MIELE DELICATAMENTE AROMATICO E MOLTO PROFUMATO.",
                   DescrizioneeColtivazione = "La lavanda è un cespuglio sempreverde, spontaneo negli ambienti aridi mediterranei, con foglie lanceolate di colore grigio-verde. La fioritura avviene a inizio estate, in verticilli dei piccoli fiori odorosi azzurro-porpora, ma anche bianchi, rosa o blu nelle numerose varietà.  ",
                   RaccoltaeConservazione = "La raccolta delle infiorescenze si effettua quando la fioritura della spiga è iniziata ma non troppo avanzata, nelle ore centrali della giornata con i fiori ben asciutti, recidendo anche una porzione di stelo, in modo da poterne fare mazzetti da appendere per l’essiccazione. La quantità di essenza contenuta nei fiori dipende dalla specie, dalla zona di coltivazione e dal clima.",
                   SaluteeBellezza1 = "I fiori di lavanda purificano la pelle: sono perciò utilissimi per la cura della cute grassa e acneica; favoriscono inoltre la cicatrizzazione di piaghe e ferite, stimolano la circolazione superficiale e migliorano quella cutanea del cuoio capelluto. La tintura di lavanda è utilizzata per frizionare i capelli grassi e combattere la forfora. La lavanda serve anche per purificare l’alito e la bocca mediante sciacqui e gargarismi. Per un bagno balsamico e rilassante mettete in infusione una grossa manciata di fiori, racchiusi in un sacchetto di tela, nell’acqua della vasca. L’essenza di lavanda è anche un repellente contro gli insetti.",
                   SaluteeBellezza2 = "",
                   Incucina1 = "Luccio grigliato alla provenzale PER 4-5 PERSONE Pulite e asciugate un luccio di circa un chilo, incidendolo sui fianchi per favorirne la cottura. Fatelo marinare in olio extravergine di oliva, foglie di lavanda, santoreggia, timo, sale e pepe, girandolo più volte. Cuocete il pesce sulla griglia e servitelo aperto a libro, condito con una spolverata di nepitella tritata e un filo di olio extravergine di oliva.",
                   Incucina2 = "",

                   Propagazione = "La propagazione avviene prevalentemente per talee radicate, piantate in primavera a una distanza di 60-70 cm l’una dall’altra in terreni esposti al sole e ben drenati. Le piante acquistate in vaso, già dotate di rami secondari alla base del fusto, possono essere piantate in qualsiasi momento, esclusi i periodi più freddi e umidi.",
                   Potatura = "La lavanda tende a lignificare alla base e a diventare disordinata spogliandosi nella parte bassa. Per mantenere compatta la vegetazione e garantirle lunga vita, i cespugli devono essere potati tutti gli anni a 15 cm da terra quando è terminata la fioritura.",
                   Malattie = "Possibile infezione da fungo e presenza di insetti, entrambe eliminabili con appositi medicinali. Il gelo può causare danni, rendendo la pianta sgraziata e sguarnita alla base. ",
                },

                new Aromatiche
                {
                   NomeComunePianta = "MAGGIORANA",
                   NomeFamiglia = "Labiate",
                   NomeScientificoPianta = "Origanum majorana",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Maggiorana/MAGGIORANA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "PICCOLO CESPUGLIO, HA PROFUMO MOLTO GRADEVOLE. VIENE SPESSO CONFUSA CON L’ORIGANO PER L’ASPETTO E PER LA FRAGRANZA, MA HA UN AROMA PIÙ DELICATO E UN GUSTO PIÙ DOLCE. INSAPORISCE INSALATE, PESCE, UOVA, SALSE DI POMODORO E CARNI, CHE CONTRIBUISCE A RENDERE PIÙ DIGERIBILI. ",
                   DescrizioneeColtivazione = "La maggiorana è ricoperta da una fitta e minuta peluria, che conferisce una colorazione verde-grigiastra alle foglie, piccole e fitte. I fiori, riuniti in piccole spighe, sono di colore bianco, rosa o malva e sbocciano da luglio a settembre. Poiché teme i ristagni idrici, la maggiorana va coltivata in terreni leggeri e ben drenati. Per favorire l’irrobustimento degli esemplari, il primo anno è bene tagliare le sommità fiorite.",
                   RaccoltaeConservazione = "La raccolta va effettuata durante il periodo estivo, prima della completa fioritura, tagliando gli steli a una decina di centimetri dal suolo. Dopo l’essiccazione in ambiente aerato, si conserva in barattoli chiusi o in sacchetti di tela, al riparo dall’umidità e dalla luce. Se l’essiccazione non è avvenuta rapidamente, l’aroma risulta, però, meno intenso di quello delle piante fresche.",
                   SaluteeBellezza1 = "La maggiorana ha anche proprietà medicamentose: le sommità fiorite hanno effetti anticatarrali, digestivi e antispasmodici, per cui si rivela un valido aiuto contro le mestruazioni dolorose. L’olio essenziale, assunto in piccole dosi, è efficace contro il mal di testa e come tranquillante.",
                   SaluteeBellezza2 = "Dato che contribuisce a liberare il naso dal muco e a ridurre l’eventuale gonfiore degli occhi, in suffumigi e inalazioni la maggiorana è un buon rimedio per il raffreddore, mentre aggiunta all’acqua calda del bagno ha effetto tonificante e rilassante. Contro il torcicollo mettete qualche manciata di fiori secchi in un sacchetto di tela e, dopo averlo scaldato, applicatelo sulla parte dolorante.",
                   Incucina1 = "Pollo ripieno alla maggiorana PER 4 PERSONE Pulite e lavate un pollo di un chilo e salatelo dentro e fuori, strofinandolo esternamente con un battuto di santoreggia e maggiorana. A parte preparate un ripieno con 50 g di cipolla e uno spicchio di aglio rosolati nel burro insieme con 250 g di funghi coltivati tagliati a pezzi piccoli e lasciati asciugare a fuoco vivace. Aggiungete prezzemolo, abbondante maggiorana e uno spicchio di aglio tritati. Farcite il pollo e legatelo perché il ripieno non esca. Rivestitelo con 150 g di pancetta a fette, avvolgetelo in un foglio di carta stagnola bagnandolo prima con mezzo bicchiere di vino rosso e cuocete in forno a 180 °C per circa 45 minuti. Servite il pollo con delle patate arrosto.",
                   Incucina2 = "",

                   Propagazione = "Può essere seminata direttamente in piena terra a primavera inoltrata, su file distanti 30 cm, oppure da fine aprile si trapiantano le piantine da semenzaio.",
                   Potatura = "Non è necessario effettuare potature particolari.",
                   Malattie = "Non è soggetta a particolari malattie.",
                },

                new Aromatiche
                {
                   NomeComunePianta = "MALVA",
                   NomeFamiglia = "Malvacee",
                   NomeScientificoPianta = "Malva sylvestris",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Malva/MALVA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "PIANTA GRAZIOSA E MOLTO DIFFUSA, LA MALVA È UTILIZZATA DA TEMPI REMOTI PER LA SALUTE E NOTA ANCHE COME “RIMEDIO PER OGNI MALE”. ",
                   DescrizioneeColtivazione = "Cespuglio biennale eretto o prostrata, di piccola dimensione (60-80 cm), la malva ha foglie a cinque o sette lobi e bei fiori rosa-viola, con striature scure. Ama i terreni freschi e ricchi, i climi temperati, le posizioni soleggiate. Se ben innaffiata, germina velocemente. ",
                   RaccoltaeConservazione = "Da giugno a settembre si raccolgono i fiori appena schiusi e le foglie tenere per colorare le insalate. I boccioli si conservano sotto sale o sott’aceto come i capperi.",
                   SaluteeBellezza1 = "La tisana combatte tosse e raffreddore e ha proprietà depurative per l’organismo, che libera dalle tossine.",
                   SaluteeBellezza2 = "",
                   Incucina1 = " Le foglie sono un’ottima verdura cotta, anche nei risotti e nelle frittate. In erboristeria, fiori e foglie essiccate hanno effetto antinfiammatorio, lassativo ed emolliente.",
                   Incucina2 = "",

                   Propagazione = "Si effettua in primavera attraverso la semina. Quando le piantine saranno maneggiabili si possono rinvasare.",
                   Potatura = "Si eliminano le parti danneggiate e i fiori appassiti.",
                   Malattie = "Possibili presenze di funghi e di virosi (arricciamento della pianta) eliminabili con appositi prodotti. ",
                },

                new Aromatiche
                {
                   NomeComunePianta = "MELISSA",
                   NomeFamiglia = "Labiate",
                   NomeScientificoPianta = "Melissa officinalis",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Melissa/MELISSA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "FURONO I ROMANI A INTRODURRE IN EUROPA QUESTA PIANTA PROFUMATISSIMA: BASTA STROFINARE LE FOGLIE PERCHÉ SPRIGIONINO UN’INTENSA FRAGRANZA DI LIMONE. È MOLTO AMATA IN CUCINA E IN ERBORISTERIA, PER GLI EFFETTI SEDATIVI E ANTISTRESS. ",
                   DescrizioneeColtivazione = "La melissa è un’erbacea perenne rizomatosa, con fusti alti 50-80 cm eretti, ornati da foglie ovate verde brillante, un po’ bollose e pelose. Nella prima metà dell’estate produce verticillastri di fiorellini candidi di scarso significato ornamentale. È una delle poche erbe aromatiche che preferiscono la coltivazione in mezz’ombra (insieme a prezzemolo e menta), in terra ben vangata e arricchita di letame maturo. Perché si mantenga ordinata e compatta, i suoi steli vanno drasticamente accorciati a metà primavera e poi a metà estate. Poiché tende a diventare invadente se si trova a suo agio, va controllata, eliminando i rizomi in eccesso. ",
                   RaccoltaeConservazione = "Le foglie possono essere usate sia fresche sia essiccate: in entrambi i casi conservano il caratteristico aroma, se possibile ancora più accentuato nel secco. Per l’asportazione si tagliano con le forbici i rami interi nelle ore più calde della giornata e si appendono a testa in giù, all’aria e all’ombra, raggruppati in mazzetti. Le foglie essiccate si conservano bene per oltre un anno chiuse in sacchetti di carta. Le sommità fiorite si raccolgono a inizio fioritura, tra giugno e luglio.",
                   SaluteeBellezza1 = "L’infuso di melissa (20 g di foglie fresche in un litro di acqua bollente per 15 minuti) toglie la stanchezza, rilassa la muscolatura dopo lo sport e gli sforzi eccessivi, concilia il sonno, cura i crampi, la cattiva digestione e il mal di testa. È un rimedio semplice ed efficace anche per i bambini irrequieti, febbricitanti e insonni. Una bevanda corroborante per quando fa molto freddo si prepara versando in una tazza di acqua bollente un bicchierino del cosiddetto vino di melissa. Questo si prepara lasciando macerare per 15 giorni in mezzo litro di vino bianco 2 manciate di foglie di melissa appena colte, la parte gialla della scorza di un limone non trattato, 10 chiodi di garofano e un pezzetto di cannella. Questo macerato è utile, puro, su una zolletta di zucchero contro crampi, vomito, vertigini e palpitazioni.",
                   SaluteeBellezza2 = "",
                   Incucina1 = "Torta di riso alla melissa Fate cuocere 300 g di riso in un litro di latte sino a quando tutto il liquido è stato assorbito. Togliete dal fuoco e lasciate raffreddare. In una terrina intanto montare 3 tuorli con 200 g di zucchero, una bustina di vanillina e un pizzico di sale. Quando il composto si è ben schiarito, unite il riso cotto nel latte e aggiungete un pugno di foglie di melissa tritate fini. A parte montate a neve gli albumi delle uova e uniteli delicatamente alla miscela che, versata in una tortiera imburrata, andrà cotta in forno a 180 °C per circa 50 minuti.",
                   Incucina2 = "",

                   Propagazione = "Si può seminare in primavera, ma per ottenere facilmente una nuova pianta basta chiedere una piccola porzione di radice a chiunque la coltivi. ",
                   Potatura = "Si eliminano i fiori appassiti e le parti danneggiate.",
                   Malattie = "E' immune da malattie, difende le piante vicine.",
                },

                new Aromatiche
                {
                   NomeComunePianta = "MENTA",
                   NomeFamiglia = "Labiate",
                   NomeScientificoPianta = "Mentha piperita",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Menta/MENTA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "ERBA AROMATICA TRA LE PIÙ NOTE E PROFUMATE, LA MENTA BRILLA PER CARATTERISTICHE TERAPEUTICHE OLTRE AD ESSERE VERSATILE IN CUCINA. DIFFUSA ALLO STATO SELVATICO, È ANCHE FACILE DA COLTIVARE. ",
                   DescrizioneeColtivazione = "Appartenente alla famiglia delle labiate, è una pianta perenne dal fusto quadrangolare verde-violaceo, foglie opposte ovali e seghettate, fiori biancorosati riuniti in glomeruli, a loro volta raggruppati in infiorescenze a forma di spiga. Ama i terreni freschi e fertili in mezz’ombra e richiede molta acqua.",
                   RaccoltaeConservazione = "Le foglie vanno raccolte prima della fioritura, tra luglio e agosto, ed essiccate in un luogo ombreggiato e ventilato. Per un secondo raccolto, si tagliano le piante a livello del suolo prima che sboccino i fiori.",
                   SaluteeBellezza1 = "La menta può essere utilizzata come antisettico delle vie respiratorie per purificarle e decongestionarle e contro raffreddori e sinusiti, mediante suffumigi. Cataplasmi di foglie fresche pestate hanno azione calmante per le affezioni della pelle, pruriti e punture d’insetti.",
                   SaluteeBellezza2 = "Gli infusi e i tè alla menta sono tonici, leggermente astringenti e rinfrescano le pelli irritabili e sensibili; sotto forma di gargarismi e risciacqui, leniscono le inﬁ ammazioni delle mucose della bocca.",
                   Incucina1 = "Sorbetto di pompelmo alla menta Fate cuocere a fuoco basso per una decina di minuti la scorza di un pompelmo non trattato con 3,8 dl di acqua e 130 g di zucchero, filtrate e lasciate raffreddare. In una terrina mescolate lo sciroppo di zucchero così ottenuto con 5 dl di succo di pompelmo e un paio di cucchiaini di menta fresca tritata. Mettete il preparato in freezer in vaschette basse; quando il sorbetto inizia a solidificare, frullatelo per renderlo cremoso, poi rimettetelo in freezer fino al momento di servirlo.",
                   Incucina2 = "Salsa aromatica di ricotta e menta Mondate e sciacquate rapidamente 2-3 rametti di menta fresca, un ciuffo di finocchio selvatico e un rametto di melissa. Pulite uno scalogno e tritatelo assieme alle erbe. Raccogliete il tutto in una ciotola e unite, mescolando, poco olio extravergine di oliva, qualche goccia di succo di limone e un pizzico di sale. Ottenuto un composto omogeneno, incorporate la ricotta passata al setaccio. Mescolate per amalgamare, spolverizzate con del pepe e aggiungete, se serve, ancora olio e limone. Questa salsa è ottima con uova, carne o verdure bollite.",

                   Propagazione = "Si propaga per mezzo di stoloni, che devono essere interrati a due a due in autunno, a una distanza di 20 cm sulla fila, con 40 cm tra le file.",
                   Potatura = "Eliminare le parti secche o danneggiate, quando si espande troppo ridimensionare la pianta, perchè può diventare invasiva (almeno un taglio ogni primavera). ",
                   Malattie = "Puo' essere soggetta ad afidi e ruggine che crea delle macchie brunastre. Si consiglia di eliminare subito le parti colpite, bruciano la pianta dopo everle messo della paglia sopra. ",
                },

                
                new Aromatiche
                {
                   NomeComunePianta = "MIRTO",
                   NomeFamiglia = "Labiate",
                   NomeScientificoPianta = "Myrtus communis",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Mirto/MIRTO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "IL MIRTO È UNA PIANTA TIPICA DELLA MAPPA MEDITERRANEA. SIA I FRUTTI (BACCGE SFERICHE CARNOSE) SIA LE FOGLIE, FRESHE O ESSICCATE, VENGONO USATI NELLA PREPARAZIONE DI PIATTI A BASE DI CARNE E PESCE. CON I FRUTTI FRESCHI SI POSSONO REALIZZARE SALSE E INSAPORIRE RISOTTI, OLTRE A GUARNIRE PIATTI DI PORTATA. IN SARDEGNA IL MIRTO È USATO PER VARIE RICETTE TIPICHE CHE SPAZIOANO DAL PORCEDDU (MAIALINO) ALLO SPIEDO, AL LIQUORE OMONIMO.",
                   DescrizioneeColtivazione = "Il mirto è un arbusto sempreverde che può raggiungere 4 m di altezza, con esili rami che portano piccole foglie ovali, molto profumate. I fiori, bianchi o leggermente rosati, anch’essi profumati, si sviluppano tra maggio e luglio all’ascella delle foglie. Nei mesi invernali maturano i frutti, di colore bluastro, simili ai mirtilli. È una pianta che si adatta molto bene anche alla coltivazione in vaso.",
                   RaccoltaeConservazione = "Le foglie da essiccare si raccolgono nella tarda primavera, anche se è preferibile utilizzarle fresche. I frutti maturano tra l’autunno e l’inverno, e vengono tradizionalmente lasciati macerare sotto spirito per la preparazione del celebre liquore. I fiori sbocciano tra maggio e agosto, in alcuni casi anche fino all’autunno; sono utilizzati in cosmesi e per la preparazione di profumatissimi pot-pourri. Le foglie, che vanno essiccate in luoghi asciutti e arieggiati, si mantengono a lungo in sacchetti di tela, mentre i frutti vanno consumati freschi o si conservano sott’aceto.",
                   SaluteeBellezza1 = "Il profumo di foglie e frutti del mirto è dovuto alla presenza di un olio essenziale, il mirtolo, che per uso esterno ha buone proprietà sedative e antireumatiche. Le foglie sono balsamiche e antisettiche, mentre i frutti hanno un’azione astringente, carminativa e tonica. L’infuso può essere utilizzato come detergente intimo per lenire inﬁ ammazioni e pruriti. Con il mirto si preparava la cosiddetta “acqua degli angeli”, un tonico per la pelle ottenuto dalla distillazione di foglie e fiori.",
                   SaluteeBellezza2 = "",
                   Incucina1 = "Porcellino arrosto al mirto Prendete un maialino da latte di 3-4 kg, con la carne tenerissima che rende caratteristica questa ricetta. Preparate il fuoco dello spiedo con legno di piante aromatiche, tra le quali il ginepro, per migliorare il gusto della carne. Il maialino, dopo essere stato svuotato delle interiora, lavato, asciugato, salato e profumato con molte foglie di mirto, deve essere infilzato e messo a cuocere con l’interno rivolto verso la fiamma. A tre quarti di cottura, ungete bene la carne passandovi un pezzo di lardo di circa 100 g conficcato su una forchetta e precedentemente scaldato per farlo colare meglio. Dopo circa 3 ore girate il maialino ripetutamente sullo spiedo, per ottenere una bella rosolatura e una cotenna croccante. Nell’impossibilità di preparare questa ricetta con lo spiedo, potete arrostire il porcellino nel forno. La carne va servita calda, ma può pure essere mangiata fredda, dopo essere stata coperta con foglie di mirto.",
                   Incucina2 = "",

                   Propagazione = "Si propaga in autunno per talee, da interrare a una distanza di un metro sia tra le file sia sulla fila. ",
                   Potatura = "Non viene richiesta nessuna potatura particolare.",
                   Malattie = "Può essere soggetto ad attacchi da parte di afidi e cocciniglia. I funghi provocano l'ingiallimento del fogliame e macchie fogliari. ",
                },

                
                new Aromatiche
                {
                   NomeComunePianta = "ORIGANO",
                   NomeFamiglia = "Labiate",
                   NomeScientificoPianta = "Origanum vulgare",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Origano/ORIGANO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "L SUO PROFUMO EVOCA ISTANTANEAMENTE SAPORI MEDITERRANEI, A PARTIRE DALLA PIZZA NAPOLETANA E DAI CONDIMENTI “ALLA PIZZAIOLA”. IN CUCINA SI CONSUMANO LE FOGLIOLINE, FRESCHE O ESSICCATE, MENTRE IN ERBORISTERIA SI USANO LE SOMMITÀ FIORITE, DALL’AZIONE TONICA, DIGESTIVA E STIMOLANTE. ",
                   DescrizioneeColtivazione = "Pianta perenne stolonifera comune nei prati aridi e negli incolti del Sud Italia, l’origano può raggiungere 80 cm di altezza. È considerato un suffrutice, cioè una specie con base del fusto legnosa come un cespuglio. Ha foglie piccole e fiori rosa carico riuniti in infiorescenze simili a spighe, che compaiono in estate. Tipico della flora mediterranea, l’origano teme il freddo e i terreni compatti e argillosi, che trattengono l’acqua. Perché sia più intensamente profumato, deve vivere in pieno sole, va irrigato pochissimo e mai concimato.",
                   RaccoltaeConservazione = "Le foglie fresche si raccolgono al momento durante tutta l’estate. Per la conservazione, invece, si taglia a fine estate la parte erbacea dei rametti, completa degli scapi fiorali, e si fa essiccare all’ombra in un luogo ventilato. È una delle erbe aromatiche che con l’essiccazione, se avviene rapidamente con tempo asciutto, guadagna in sapore.",
                   SaluteeBellezza1 = "L’origano, in suffumigi e inalazioni, libera il naso, attenua il senso di occlusione, la pesantezza al capo e le nevralgie. Una manciata delle sue foglie nell’acqua del bagno o del pediluvio ha proprietà stimolanti, purificanti e deodoranti per le pelli impure e per le estremità affaticate. L’essenza è utilizzata contro le nevralgie. Nella farmacopea popolare, il succo fresco applicato con un po’ di cotone su un dente cariato serve a lenire il dolore.",
                   SaluteeBellezza2 = "",
                   Incucina1 = "Pizza con origano e aglio PER 4 PERSONE Fate sciogliere 30 g di lievito di birra in poca acqua tiepida e lasciatelo agire per 15 minuti circa, finché sulla superficie non si forma una schiumetta. Ponete un chilo di farina sulla spianatoia a fontana e impastate incorporando il lievito e un cucchiaio di sale, finché il composto non diventa liscio e inizia a fare le bolle. Avvolgete poi la pasta in un tovagliolo pulito e lasciatela lievitare 2 ore prima di utilizzarla. Stendete la pasta su una placca da forno unta, fino a uno spessore di tre millimetri. Pulite 3-4 spicchi di aglio e tagliateli a fettine piuttosto spesse, distribuendole sulla base e premetele con le dita per farle affondare. Irrorate la pizza con olio, salate, pepate e cospargete di abbondante origano. Cuocete la pizza in forno già caldo a 230-250 °C per 35-40 minuti. ",
                   Incucina2 = "Olive all’origano PER 4 PERSONE Lavate e asciugate 40 olive nere e fatele soffriggere in una padella con olio extravergine di oliva e uno spicchio di aglio schiacciato. Unite mezzo bicchiere di aceto e aggiungete una manciata di origano. Cuocete qualche minuto e servite.",

                   Propagazione = "Può essere moltiplicato a inizio primavera per divisione dei cespi oppure per semina in semenzaio protetto, lasciando sviluppare le piantine per 60-90 giorni prima di metterle a dimora a 60 cm tra le file e a 30 cm sulla fila. ",
                   Potatura = "Non richiede nessuna potatura.",
                   Malattie = "Le foglie possono essere scottate dal sole.",
                },

                new Aromatiche
                {
                   NomeComunePianta = "PEPERONCINO",
                   NomeFamiglia = "Solanacee",
                   NomeScientificoPianta = "Capsicum annuum",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Peperoncino/PEPERONCINO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "PROTAGONISTA DEI PIATTI SPEZIATI E PICCANTI, IL PEPERONCINO SI DECLINA IN PIÙ DI 200 SPECIE E VARIETÀ, DI FORMA, COLORE, DIMENSIONE E GRADO DI PICCANTEZZA MOLTO DIVERSI. SE NE CONSUMANO I VARIOPINTI FRUTTI, A BACCA CAVA E RICCA DI SEMI, PER INSAPORIRE SUGHI, CARNI, VERDURE, FORMAGGI, SOTTOLI.",
                   DescrizioneeColtivazione = "Pianta annuale della famiglia delle solanacee (come melanzana e pomodoro). Se il clima è caldo e asciutto e gli apporti idrici sono ridotti, i frutti diventano più piccanti.",
                   RaccoltaeConservazione = "È preferibile lasciar appassire i peperoncini il più a lungo possibile attaccati alla pianta, estirpando quest’ultima solo quando arriva alla fine del suo ciclo vegetativo e appendendola a testa in giù a completare l’essiccazione. Dopo di che si staccano i frutti e si conservano in vasi chiusi, affinché non perdano l’aroma. Volendo, si possono macinare o tritare e amalgamare con olio extravergine di oliva.",
                   SaluteeBellezza1 = "Il peperoncino, oltre a spiccate proprietà stimolanti, digestive e antiscorbutiche, grazie all’alto contenuto di vitamine A e C ha effetti vasodilatatori, e forse per questo un tempo era considerato un potente afrodisiaco. Il consumo regolare di piccole dosi di peperoncino nei cibi favorisce la ﬂ uidiﬁ cazione del sangue. In soluzione alcolica, usato per gargarismi, stimola l’apparato oro-faringeo e schiarisce la voce. Macinato e applicato su appositi cerotti ha proprietà revulsive per il trattamento di reumatismi, artrosi, nevralgie e geloni, poiché stimola le terminazioni nervose periferiche e fa affluire il sangue nella zona trattata.",
                   SaluteeBellezza2 = "",
                   Incucina1 = "Tomini sott’olio al peperoncino Tagliate alcuni tomini a cubetti di circa mezzo centimetro, metteteli in un vaso di vetro a chiusura ermetica alternandoli a falde di peperoni cotti alla griglia e privati della pelle, peperoncino piccante essiccato a pezzetti, aglio tagliato a rondelle, origano e grani di pepe nero. Coprite il tutto con olio extravergine di oliva. Chiudete poi il barattolo e capovolgetelo per far risalire eventuali bolle d’aria, quindi aprite e aggiungete altro olio fino ad arrivare a coprire bene i cubetti di formaggio. Lasciate insaporire la preparazione per qualche giorno, poi consumatela nell’arco di 2-3 settimane; mantenete il contenitore in frigorifero.",
                   Incucina2 = "",

                   Propagazione = "Da seminare in febbraio-marzo in semenzaio al riparo, con trapianto delle piantine all’aperto in aprile-maggio al Nord, mentre al Sud i tempi sono anticipati di almeno un mese. La distanza tra le piante è di 30 cm sulla fila e di 50 cm tra le file.  ",
                   Potatura = "Non necessaria.",
                   Malattie = "Possono essere soggette a funghi dovuti ad eccesso di umidità o ad attacchi di cocciniglia. Intervenire con appositi prodotti. ",
                },

                new Aromatiche
                {
                   NomeComunePianta = "PREZZEMOLO",
                   NomeFamiglia = "Ombrellifere",
                   NomeScientificoPianta = "Petroselinum hortense",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Prezzemolo/PREZZEMOLO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "INGREDIENTE FONDAMENTALE IN CUCINA, DOVE SPOSA QUALUNQUE PIETANZA, È INSUPERABILE NELLE MISCELE AROMATICHE, COME LA CELEBRE SALSA VERDE. LA VARIETÀ A FOGLIA LISCIA RENDE PIÙ DI QUELLA RICCIA, O FRANCESE, UTILE PER DECORARE I PIATTI. PER ESALTARNE L'AROMA, DOPO LA RACCOLTA E PRIMA DELL'USO TRITATO È CONSIGLIABILE LASCIARE IL MAZZETTO DI PREZZEMOLO CON LA BASE IMMERSA IN UN BICCHIERE DI ACQUA PER QUALCHE ORA.",
                   DescrizioneeColtivazione = "Il prezzemolo ama i terreni fertili e sempre un po’ freschi, al sole o in mezz’ombra.  I fiori, raccolti in infiorescenze ad ombrella, si formano solo nel secondo anno dalla semina, ragion per cui, se si desidera raccogliere i semi, occorre mantenere la coltura per 2 anni.",
                   RaccoltaeConservazione = "La raccolta inizia circa 2 mesi dopo la semina e si protrae fino alla fine dell’estate, tagliando alla base solo le foglie esterne, in modo da consentire lo sviluppo di nuove foglie al centro. Per la conservazione si può ricorrere al congelamento: un sistema molto pratico è quello di staccare le singole foglioline, pulirle, asciugarle, chiuderle in un sacchetto per la congelazione e surgelarle. Prima dell’uso si stringe nel pugno il sacchetto ancora congelato: in questo modo le foglie si sbricioleranno e risulteranno già pronte, come se fossero appena tritate.",
                   SaluteeBellezza1 = "Il prezzemolo è ricchissimo di vitamine in particolare la C, A, K, acido folico e altre vitamine del gruppo B ma vanta la presenza anche di minerali tra cui potassio, calcio e ferro. Si tratta poi di un ottimo diuretico che può aiutare in caso di ritenzione idrica e favorire la perdita di peso. Ricco anche di sostanze antiossidanti come i flavonoidi (oltre che la stessa vitamina C) contrasta l’azione dei radicali liberi e ha un buon effetto antinfiammatorio.",
                   SaluteeBellezza2 = "",
                   Incucina1 = "Tortelloni di ricotta al prezzemolo PER 4 PERSONE Impastate 400 g di farina, 4 uova e una presa di sale, stendete una sfoglia sottile e tagliatela in quadrati di 6-8 cm di lato. Preparate il ripieno con 400 g di ricotta, 2 uova, 40 g di parmigiano grattugiato, 40 g di prezzemolo tritato, sale, pepe e un pizzico di noce moscata. Mettete un cucchiaino di composto su ogni quadrato di pasta, ripiegate e chiudete premendo bene i bordi. Cuocete in abbondante acqua salata bollente, scolando dopo pochi minuti. Servite condendo con burro fuso e abbondante grana grattugiato, oppure con salsa di pomodoro.",
                   Incucina2 = "",

                   Propagazione = "La semina avviene tra marzo e aprile; quando le piantine sono sufficientemente sviluppate si procede al diradamento, mantenendo una distanza sulla fila di una decina di centimetri tra una pianta e l’altra e 20 cm tra le file; per le varietà a grande sviluppo, come la popolarissima Gigante d’Italia, è bene aumentare ulteriormente le distanze.",
                   Potatura = "Tagliare tutti i nuovi steli che vanno a fiore, altrimenti la pianta non produrrà nuovi getti ",
                   Malattie = "Puo' esere attaccato da larve di maggiolino,larve di ozziorrinco e afidi.Può essere soggeto a carenze da ferro. ",
                },


                new Aromatiche
                {
                   NomeComunePianta = "RAFANO",
                   NomeFamiglia = "Crucifere",
                   NomeScientificoPianta = "Armoracia rusticana",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Rafano/RAFANO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "IL RAFANO È COLTIVATO PER LA GROSSA RADICE A FITTONE DALL'AROMA PICCANTE CHE È NOTA ANCHE CON IL NOME DI CREN. GRATTUGIATA CON L'AGGIUNTA DI ZUCCHERO E UNA GOCCIA DI ACETO DIVENTA UNA SALSA MOLTO FORTE, ADATTA AD ACCOMPAGNARE I BOLLITI, MOLTO APPREZZATA NELLA TRADIZIONE GASTRONOMICA TEDESCA. ANCHE LE FOGLIE GIOVANI, FINEMENTE TRITATE, POSSONO ESSERE UTILIZZATE PER AROMATIZZARE SALSE.",
                   DescrizioneeColtivazione = "Il rafano é una specie perenne; caratterizzata da una radice molto grossa e carnosa. Il fusto erbaceo è eretto, con una rosetta di grandi foglie ovate e dentellate alla base. Preferisce i terreni un po’ pesanti, umidi, fertili, al sole o in mezz’ombra.",
                   RaccoltaeConservazione = "La raccolta si effettua solitamente a partire dall’inizio dell’autunno. Le radici devono essere pulite con cura, preferibilmente senza usare acqua, e poi vanno lasciate asciugare. Si conservano molto bene nel frigorifero, chiuse in sacchetti o contenitori dotati di coperchio, per un tempo che varia da parecchie settimane a una quindicina di giorni, se mantenute a temperatura ambiente. Se si desidera, invece, prolungare maggiormente i tempi di conservazione, un’alternativa valida è la surgelazione.",
                   SaluteeBellezza1 = "In erboristeria si sfruttano le proprietà anticatarrali, depurative, antireumatiche e calmanti per l’acidità di stomaco. Per uso esterno, tramite frizioni, il rafano induce l’afflusso di sangue nelle zone trattate e si rivela, perciò, utile contro i dolori reumatici, della sciatica e le contusioni.",
                   SaluteeBellezza2 = "",
                   Incucina1 = "Salsa al rafano (cren) Chi non conosce il cren è meglio che per la prima volta lo assaggi in una versione con aggiunta di panna, nella quale il suo forte sapore sia mitigato. Mettete 100 g di rafano grattugiato in una ciotola e aggiungete della mollica di pane bagnata in un po’ di latte e strizzata. Amalgamate il tutto con un paio di cucchiaini di zucchero, 2 cucchiaiate di panna montata non zuccherata, qualche goccia di aceto e un pizzico di sale. È una salsa adatta per le carni bollite, anche quando vengono servite fredde.",
                   Incucina2 = "Liquore digestivo al rafano Mettete 2 manciate di radici spezzettate a macerare per una decina di giorni in un litro di birra o di vino. Filtrate, imbottigliate e bevetene a bicchierini in caso di necessità.",

                   Propagazione = "Si moltiplica alla fine dell’inverno, piantando nel terreno dei pezzetti di radice. ",
                   Potatura = "Eliminare le parti secche.",
                   Malattie = "Non è soggetta a particolari malattie.",
                },

                new Aromatiche
                {
                   NomeComunePianta = "ROSMARINO",
                   NomeFamiglia = "Labiate",
                   NomeScientificoPianta = "Rosmarinus officinalis",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Rosmarino/ROSMARINO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "RE DELLA FLORA E DELLA TRADIZIONE GASTRONOMICA MEDITERRANEE, IL ROSMARINO È MOLTO APPREZZATO SIA PER IL CARATTERISTICO SAPORE, SIA PER LE PROPRIETÀ OFFICINALI, SIA PER IL VALORE DECORATIVO. LE SUE FOGLIE AROMATICHE SONO DISPONIBILI PER TUTTO L’ANNO. ",
                   DescrizioneeColtivazione = "Il rosmarino è un arbusto sempreverde che può raggiungere 2 m di altezza; ha foglie piccole, strette e coriacee e fiori azzurri, bianchi o violetti che sbocciano a fine inverno. Ama i climi miti e cresce bene nei terreni siccitosi, sabbiosi e calcarei, ma può essere coltivato ovunque, purché in posizione esposta a sud e riparata d’inverno. Le piante si mettono a dimora all’inizio della primavera a una distanza di 20 cm sulla fi la e di un metro tra le fi le.",
                   RaccoltaeConservazione = "Le foglie del rosmarino sono disponibili fresche in qualunque periodo dell’anno, ma d’inverno il loro profumo è meno intenso. Si adattano comunque bene all’essiccazione, anche se così si perde parte dell’aroma. In estate, nelle ore più calde della giornata, si tagliano i rametti, e si appendono ad essiccare a testa in giù, raccolti in mazzetti, in un luogo ombroso e ventilato. Può anche essere surgelato, per esempio legato con altri aromi per il brodo (porro, alloro, sedano ecc.).",
                   SaluteeBellezza1 = "Per uso esterno il rosmarino è un buon antisettico. L’olio essenziale, frizionato sulle zone doloranti, cura contusioni, distorsioni, dolori articolari e muscolari, reumatismi e torcicollo. Per questo motivo entra nella composizione di creme per i massaggi. In cosmesi, le lozioni e i bagni di rosmarino deodorano, stimolano, tonificano e purificano la pelle, mentre le tinture rivitalizzano la circolazione del cuoio capelluto. I dentifrici e i collutori a base di rosmarino rinforzano e proteggono le gengive, mentre gli sciacqui con l’infuso curano le afte (ulcere) del cavo orale. Gli infusi con le sommità ﬁ orite favoriscono la depurazione dell’organismo e hanno proprietà diuretiche.",
                   SaluteeBellezza2 = "",
                   Incucina1 = "Schiacciata aromatica al rosmarino Disponete 500 g di farina a fontana sulla spianatoia, unite 30 g di lievito di birra, dopo averlo fatto sciogliere in poca acqua tiepida e lasciato riposare una decina di minuti finché non si forma una schiumetta; lavorate il tutto aggiungendo l’acqua necessaria a ottenere un impasto elastico e morbido. Lasciate lievitare per circa un’ora e mezza, finché l’impasto non sarà raddoppiato di volume. Stendetelo ﬁ no a ottenere una sfoglia alta circa un centimetro, da lasciare lievitare per altri 20 minuti. Ungete con olio una tortiera dai bordi bassi e foderatela con la sfoglia, che pizzicherete formando delle fossette. Spolverizzate con sale grosso e aromatizzate con un paio di cucchiai di un trito misto di rosmarino, maggiorana, salvia e timo. Irrorate con olio extravergine di oliva. Cuocete in forno già caldo a 200 °C per una ventina di minuti. La superﬁ cie della schiacciata dovrà risultare dorata.",
                   Incucina2 = "",

                   Propagazione = "La moltiplicazione del rosmarino può avvenire per seme o per talea apicale (in estate). In entrambi i casi sarà facile ottenere nuovi individui di questa pianta a patto che ci siano le condizioni climatiche ideali.",
                   Potatura = "Eliminare i rami secchi o danneggiati. E' una pianta rustica che si adatta molto bene alle potature, infatti, è possibile coltivarla per creare siepi della forma desiderata. ",
                   Malattie = "Non è soggetto a malattie di grave intensità ma può essere colpito da cocciniglie o fumaggini. ",
                },

                new Aromatiche
                {
                   NomeComunePianta = "RUMEX",
                   NomeFamiglia = "Poligonacee",
                   NomeScientificoPianta = "Rumex acetosa, R. hortensis",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Rumex/RUMEX.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "ANCHE NOTO COME ACETOSA O ERBA BRUSCA, COMUNE NEI PRATI DI TUTTA ITALIA, PRESENTA FOGLIE DALLA FRAGRANZA ERBACEA E DAL SAPORE ACIDULO RICCHE DI VITAMINA C E SALI MINERALI.",
                   DescrizioneeColtivazione = "Pianta erbacea perenne, il rumex presenta una grossa radice, che sviluppa una rosetta di foglie allungate e delle pannocchie di fiori estivi rossicci. Ama i terreni leggermente umidi e il pieno sole. Si può coltivare anche in vaso e si può raccogliere tutto l’anno, anche recidendo alla base la pianta: la radice emetterà nuova vegetazione. ",
                   RaccoltaeConservazione = "Si raccolgono e conservano le foglie",
                   SaluteeBellezza1 = " In erboristeria, l’infuso ha proprietà diuretiche, rinfrescanti, antinfiammatorie, febbrifughe.",
                   SaluteeBellezza2 = "",
                   Incucina1 = " In cucina, utilizzata a piccole dosi, aggiunge una nota acidula a insalate e verdure cotte. Entra anche nella composizione di una salsa che accompagna pesce e carne.",
                   Incucina2 = "",

                   Propagazione = "Per seme in primavera.",
                   Potatura = "Non necessaria.",
                   Malattie = "Non è soggetta a particolari malattie.",
                },

                new Aromatiche
                {
                   NomeComunePianta = "RUTA",
                   NomeFamiglia = "Rutacee",
                   NomeScientificoPianta = "Ruta graveolens",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Ruta/RUTA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "ERBACEA DAL FOGLIAME LEGGERO, CHE DA MAGGIO A SETTEMBRE DIVENTA BELLA E VISTOSA GRAZIE ALLE INFIORESCENZE GIALLE. ESISTE ANCHE UNA VARIETÀ A FOGLIA GRIGIO-AZZURRA, ANCORA PIÙ DECORATIVA. IN ITALIA È MOLTO DIFFUSA IN SARDEGNA.",
                   DescrizioneeColtivazione = "Pianta suffruticosa alta fino a 1 m, che produce un cespuglio e può creare piccole siepi, ha foglie frastagliate dall’aroma intenso, per questo non a tutti gradito. Si coltiva in piena terra o in vaso, con terra mediamente fertile e fresca, in pieno sole. ",
                   RaccoltaeConservazione = "Si utilizzano le cime più tenere e le foglie, fresche o essiccate, raccolte prima della fioritura. ",
                   SaluteeBellezza1 = "Ha proprietà digestive e antispasmodiche per l’intestino. ",
                   SaluteeBellezza2 = "",
                   Incucina1 = " In cucina è poco usata: a piccole dosi aromatizza pesce e insalate, olio e aceto. È invece molto impiegata per produrre liquori, soprattutto la famosa grappa. ",
                   Incucina2 = "",

                   Propagazione = "Per seme in primavera.",
                   Potatura = "Non necessaria.",
                   Malattie = "Non è soggetta a particolari malattie.",
                },

                new Aromatiche
                {
                   NomeComunePianta = "SALVIA",
                   NomeFamiglia = "Labiate",
                   NomeScientificoPianta = "Salvia officinalis",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Salvia/SALVIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "DERIVA IL SUO NOME DAL LATINO SALUS (SALUTE) PROPRIO PER LA SUA RICCHEZZA DI VIRTÙ TERAPEUTICHE. HA UN AROMA DECISO INDICATO PER ACCOMPAGNARE LE CARNI SAPORITE, MA LE SUE FOGLIE SONO UNA PRELIBATEZZA ANCHE IMPANATE E FRITTE. È UN’OTTIMA PIANTA MELLIFERA. OGGI ESISTONO MOLTISSIME VARIETÀ. LE FOGLIE DI SALVIA HANNO INOLTRE LA PROPRIETÀ DI RIDURRE LA DIFFUSIONE DELL'ODORE DEL PESCE IN COTTURA. ",
                   DescrizioneeColtivazione = "La salvia è una pianta suffruticosa sempreverde con rami legnosi alla base ed erbacei all’apice. Ha foglie di colore verde argentato chiaro, per effetto anche della finissima peluria che le ricopre. Fiorisce a inizio estate in spighe di piccole corolle blu-viola o bianco-rosate. Cresce bene in tutti i terreni soleggiati, anche piuttosto poveri e aridi; non sopporta i ristagni d’acqua. Come la lavanda, anche questa specie deve essere tagliata drasticamente perché non diventi troppo legnosa e spoglia alla base; l’operazione va effettuata in primavera, prima dell’emissione delle nuove foglie.",
                   RaccoltaeConservazione = "Essendo disponibili tutto l’anno, le foglie fresche possono essere raccolte al momento dell’uso. Se devono essere conservate essiccate o congelate, vanno invece colte prima della fioritura. I tempi di essiccazione sono piuttosto lunghi; se è necessario accelerarli, dopo l’appassimento all’aria si possono passare per molte ore le foglie in forno tiepido con lo sportello aperto.",
                   SaluteeBellezza1 = "L’olio essenziale di salvia è un antisettico naturale e, nell’industria cosmetica, entra nella composizione dell’acqua di colonia, oltre che di saponi, detersivi, creme, dentrifrici e lozioni. La salvia ha proprietà toniche, stimolanti, digestive, carminative e limita la sudorazione. L’infuso di foglie può essere usato per gargarismi e sciacqui in caso di infiammazioni del cavo orale, nonché come detergente, calmante ed emolliente. Strofinare qualche foglia di salvia sui denti è un metodo popolare per pulirli e sbiancarli.",
                   SaluteeBellezza2 = "",
                   Incucina1 = "Zuppa ligure alla salvia PER 4 PERSONE Mettete a bagno separatamente per 12 ore 200 g di ceci, 150 g di fagioli cannellini e 150 g di grano saraceno. Sciacquate i ceci e cuoceteli per 2 ore e mezza in acqua. Una volta cotti, passatene la metà al passaverdura e riportate il tutto a bollore, aggiungendo una cipolla affettata, i fagioli e un mazzetto di salvia. Dopo 40 minuti unite anche il grano saraceno e proseguite la cottura per altri 20 minuti. Aggiustate di sale e pepe e servite ben caldo.",
                   Incucina2 = "",

                   Propagazione = "La propagazione si esegue per talea in autunno, con radicazione in semenzaio e trapianto in piena terra in aprile. La distanza tra le file e sulla fila deve essere di 40 centimetri.",
                   Potatura = "Cimare le piante più giovani per favorire la ramificazione.",
                   Malattie = "Non è soggetta a particolari malattie. Può essere colpita dagli afidi: trattare con prodotti specifici.",
                },

                new Aromatiche
                {
                   NomeComunePianta = "SANTOREGGIA",
                   NomeFamiglia = "Composite",
                   NomeScientificoPianta = "Satureja hortensis",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Santoreggia/SANTOREGGIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "LA SANTOREGGIA È UN'ERBA AROMATICA DAL PROFUMO SIMILE A QUELLO DEL TIMO. IN CUCINA SI UTILIZZANO LE FOGLIE FRESCHE O ESSICCATE PER RIPIENI, MARINATE, PER CONDIRE ARROSTI, DA SOLE O MESCOLATE CON ALTRE ERBE AROMATICHE. SONO INOLTRE INDICATE PER INSAPORIRE I LEGUMI.",
                   DescrizioneeColtivazione = "La santoreggia, coltivata negli orti come aromatica, è una specie annuale con fusto eretto molto ramifi cato, foglie lineari e fiori rosa. La specie selvatica, Satureja montana, chiamata anche “falso timo”, è invece una pianta perenne cespugliosa con fusti lignifi cati alla base e fiori bianchi o rosati. ",
                   RaccoltaeConservazione = "Le foglie della specie annuale possono essere utilizzate fresche per tutta l’estate, mentre quelle della specie perenne sono disponibili tutto l’anno. In ogni caso, la raccolta per la conservazione si effettua prima della fioritura, prelevando le parti apicali dei fusti che possono essere essiccate oppure surgelate.",
                   SaluteeBellezza1 = "Conosciuta anche come erba di San Giulio, la santoreggia è compresa nel cosiddetto “paniere delle erbe della felicità”. Per uso esterno serve come cicatrizzante, antireumatico, blando antisettico e stimolante. L’infuso di santoreggia in sciacqui e gargarismi cura le piccole ulcere della bocca e della gola. Una manciata di foglie nell’acqua del bagno o del pediluvio tonifica la pelle e ha azione stimolante, purificante e deodorante. Usata in compresse sulle punture di insetti, la santoreggia calma rapidamente il gonfiore e il dolore. Questa pianta è inoltre sfruttata in erboristeria per combattere il vomito, la diarrea e la cattiva digestione.",
                   SaluteeBellezza2 = "",
                   Incucina1 = "Seppie ripiene alla santoreggia PER 4 PERSONE Pulite 16 seppie di piccole dimensioni e farcitele con pane ammollato nel latte e poi strizzato, 4 spicchi di aglio e un po’ di prezzemolo tritati, sale e pepe. Mettete le seppie in una piroﬁ la, irroratele con olio extravergine di oliva e cuocetele in forno per circa mezz’ora. Passato questo tempo, girate le seppie e spolverizzatele con un trito di foglie di santoreggia. Terminate la cottura e servite.",
                   Incucina2 = "",

                   Propagazione = "La specie annuale si semina in aprile direttamente a dimora, con successivo diradamento perché ogni pianta possa disporre di 20 cm sulla fila e di 40 cm tra le fi le. La specie perenne, sempreverde, si propaga invece per divisione dei cespi a inizio primavera.",
                   Potatura = "Eliminare le parti secche.",
                   Malattie = "Non è soggetta a particolari malattie o parassiti.",
                },

                new Aromatiche
                {
                   NomeComunePianta = "TARASSACO",
                   NomeFamiglia = "Composite",
                   NomeScientificoPianta = "Taraxacum officinale",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Tarassaco/TARASSACO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "IL DENTE DI LEONE, O SOFFIONE, È L’ERBA DEPURATIVA PER ECCELLENZA: BASTA AGGIUNGERE LE FOGLIE AMAROGNOLE ALLE INSALATE PRIMAVERILI PER REGALARSI UNA CURA DISINTOSSICANTE DEL FEGATO E DELL’ORGANISMO.",
                   DescrizioneeColtivazione = "Erbacea perenne, ha foglie a rosetta e fiori gialli da febbraio a ottobre, che poi diventano “soffioni” che trasportano i semi in volo per l’autopropagazione. Molto diffuso allo stato spontaneo. ",
                   RaccoltaeConservazione = "Le foglie si raccolgono fino ad aprile, i fiori quando sono in boccio o in fioritura (eliminando il verde che diventa molto amaro). ",
                   SaluteeBellezza2 = "Il tarassaco è ricco di vitamine (A, B, C, D) e sali minerali.",
                   Incucina1 = "Le foglie si usano in insalata; i cespi si lessano e poi si passano in padella; i boccioli si conservano sott’aceto o sotto sale come i capperi; i petali colorano le misticanze.",
                   Incucina2 = "",

                   Propagazione = "Si può coltivare per semina primaverile in terreno ricco di sostanza organica.",
                   Potatura = "Non necessaria.",
                   Malattie = "Non è soggetto a particolari malattie o parassiti.",
                },
                
                
                new Aromatiche
                {
                   NomeComunePianta = "TIMO",
                   NomeFamiglia = "Labiate",
                   NomeScientificoPianta = "Thymus vulgaris",
                   FotoPianta = "ms-appx:///Immagini/AROMATICHE/Timo/TIMO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/AROMATICHE/Abete-*.jpg",

                   Introduzione = "BEN RICONOSCIBILE PER IL BUON AROMA FRESCO E PENETRANTE, IL TIMO È MOLTO DIFFUSO IN ITALIA: I SUOI CUSCINETTI COMPATTI SONO GRAZIOSI NELLE BORDURE E NEI GIARDINI ROCCIOSI. È DISPONIBILE IN TANTE SPECIE E VARIETÀ, COME IL TIMO SERPILLO (T. SERPILLUM), IL TIMO AL LIMONE (T. ‘ANDERSON GOLD’, T. ‘BERTRAM ANDERSON’), QUELLO ALL’ARANCIA (T. X CITRODORUS). ",
                   DescrizioneeColtivazione = "Specie perenne sempreverde, fittamente ramificata, il timo raggiunge 15-20 cm di altezza. Le sue foglioline lanceolate sono piccole, verde-argenteo, mentre i fiori, che si aprono da maggio a luglio, sono rosa. Cresce in terreni ben drenati, asciutti ed esposti al sole.  Si semina a marzo in semenzaio, ricoprendo i minuscoli semi con pochi millimetri di terra. Le piantine si trapiantano in autunno o, nei climi più freddi, nella primavera dell’anno successivo, a una distanza sulla fila di 30 cm e tra le fi le di 50 centimetri.",
                   RaccoltaeConservazione = "Le foglie fresche possono essere raccolte durante tutto l’arco dell’anno al momento del bisogno, cimando i rametti. Per la conservazione si tagliano invece tutti i rami a pochi centimetri dal suolo all’inizio della fioritura, facendoli essiccare raggruppati in mazzetti collocati a testa in giù, in un luogo ventilato e ombroso. I rametti essiccati vanno poi conservati in contenitori ben chiusi.",
                   SaluteeBellezza1 = "Un tempo, i rami di timo si bruciavano per profumare le stanze e tenere lontani gli insetti fastidiosi e, in effetti, studi recenti hanno dimostrato che l’olio contenuto nella pianta è letale per le zanzare. Le sue principali proprietà sono dovute al contenuto in timolo (potente fungicida) e carvacrolo. L’olio, sia bianco sia rosso, viene impiegato come componente dell’aroma in molti prodotti alimentari, incluse le bevande alcoliche (liquori) e non alcoliche, in semifreddi, canditi, prodotti da forno, gelatine, budini, carni, insaccati e condimenti. La polvere ricavata dalle foglie è un eccellente dentifricio antisettico, inoffensivo per lo smalto e tonificante per le gengive.",
                   SaluteeBellezza2 = "",
                   Incucina1 = "Fegatini di pollo al timo Rosolate una cipolla tritata ﬁ ne con un po’ di burro e 150 g di fegatini di pollo. Cuocete per qualche minuto a fuoco basso, aggiungete un cucchiaio raso di timo fresco tritato, un cucchiaino di farina, 3 cucchiai di brodo caldo, sale e pepe e fate cuocere altri 10 minuti a fuoco lento. Servite accompagnando con crostini di pane.",
                   Incucina2 = "",

                   Propagazione = "La propagazione può avvenire anche per divisione dei cespi, in marzo-aprile, oppure per talee prelevate all’inizio dell’estate.",
                   Potatura = "Eliminare le parti secche o danneggiate.",
                   Malattie = "Puo' essere soggetto ad afidi o marciumi radicali se coltivato in substrati non idonei. ",
                },

                


            };

            return data;
        }

        // TODO WTS: Remove this once your MasterDetail pages are displaying real data
        public static async Task<IEnumerable<Aromatiche>> GetSampleModelDataAsync()
        {
            await Task.CompletedTask;

            return AllAromatiche();
        }


    }
}
