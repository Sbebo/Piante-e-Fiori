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

    public class CalendarioLunare
    {
        public string Mese { get; set; }

        public string Giardino1 { get; set; }
        public string Giardino2 { get; set; }

        public string Orto1 { get; set; }
        public string Orto2 { get; set; }

        public string Frutteto1 { get; set; }
        public string Frutteto2 { get; set; }

        public string CasaEBalcone1 { get; set; }
        public string CasaEBalcone2 { get; set; }

        public string FiorieLuna { get; set; }
	public string FiorieLuna1 { get; set; }
	public string FiorieLuna2 { get; set; }


    }

    public static class CalendarioLunareDataService
    {
        private static IEnumerable<CalendarioLunare> AllCalendarioLunare()
        {
            // The following is order summary data
            var data = new ObservableCollection<CalendarioLunare>
            {
                //GENNAIO
                new CalendarioLunare
                {
                   Mese = "GENNAIO ",
                   Giardino1 = "Con la Luna in fase calante, se non è un periodo di forte gelo, si può cominciare a potare i rosai.",
                   Giardino2 = "È il momento giusto, sempre con luna calante, per affrontare i primi lavori di ripulitura su alberi e arbusti, eliminando i rami morti, spezzati e quelli disordinati, che rovinano la silhouette della pianta.",

                   Orto1 = "Con la luna calante si può seminare la lattuga in semenzaio caldo; a dimora, sotto protezione, seminate le specie di lattuga da taglio, la valerianella, lattuga e radicchi da taglio. Se possedete un’asparagiaia è ora di concimarla con prodotti organici. Procedete alla forzatura dell’indivia e all’imbianchimento del radicchio.",
                   Orto2 = "Con la luna crescente potete seminare in semenzaio riscaldato le piante da orto che daranno prodotto in estate: il basilico, le melanzane, i peperoni e i pomodori.",

                   Frutteto1 = "In fase calante, potete iniziare le operazioni di potatura di lamponi e ribes, meli e peri. Approffittate di questo momento anche per sfoltire la chioma dei castagni.",
                   Frutteto2 = "In fase crescente è già tempo di trapiantare alberi e arbusti da frutto, se il terreno non è gelato, e in particolare le Drupacee acquistate in vaso o in astone (albicocco, ciliegio). In clima mediterraneo, si raccolgono in questo periodo arance, limoni, mandarini e pompelmi.",

                   CasaEBalcone1 = "In fase calante, effettuate le pulizie del balcone e procedete al lavaggio dei vasi.",
                   CasaEBalcone2 = "In fase crescente, in serra o semenzaio riscaldato, cominciate le semine di fiori annuali come begonia e petunia.",

                   FiorieLuna = "Uno dei fiori più sensibili alla Luna è l’orchidea: molte specie sono in ﬁ ore in questo periodo. Gli esemplari in fioritura vanno lasciati tranquilli nei 4 o 5 giorni che precedono il novilunio, quando sono da evitare tutte le operazioni di trapianto e di concimazione."
                },

                new CalendarioLunare
                {
                   Mese = "FEBBRAIO ",
                   Giardino1 = "In fase calante terminate i lavori di taglio e pulizia di alberi, rosai e arbusti in genere. Lavorate il terreno per le nuove piantagioni, smuovete con la zappa il sottochioma degli alberi.",
                   Giardino2 = "In fase crescente cominciate a seminare le piante ornamentali e a piantare a dimora gli alberi e arbusti a foglia caduca, i rampicanti e le prime bulbose estive, se il terreno non è molto freddo e umido.",

                   Orto1 = "Con la luna calante si seminano al riparo il sedano e a dimora le bietole, la lattuga, i radicchi da taglio, gli spinaci e le cipolle; si concima l’asparagiaia.",
                   Orto2 = "Con la luna crescente si seminano in semenzaio riscaldato i fagioli e i fagiolini e a dimora, sotto tunnel, carote, piselli e ravanelli.",

                   Frutteto1 = "In fase calante si portano a termine le potature degli alberi da frutto e si eseguono i trattamenti di prevenzione.",
                   Frutteto2 = "In fase crescente è tempo di effettuare i nuovi impianti di specie da frutto, sia arboree che arbustive (lamponi, ribes ecc.), dopo aver preparato il terreno alcuni giorni prima (deve rimanere esposto alle intemperie per raggiungere un buon livello di morbidezza e un alto grado di lavorabilità).",

                   CasaEBalcone1 = "In fase calante si rinvasano le piante da interno per rigenerarle dopo l’inverno; in alternativa, si rinnova il terriccio superficiale, se le piante non necessitano di un vaso più grande.",
                   CasaEBalcone2 = "Con la luna crescente, si semina in serra il ciclamino e si trapiantano le begonie, le dalie e gli altri fiori estivi",

                   FiorieLuna = "Il mandorlo ha una predilezione per la luna nuova e per i primi giorni della fase crescente: i suoi fiori sbocciano sempre durante il primo quarto. Nello stesso periodo, è consigliabile piantare albicocchi e susini, che verranno beneficiati nel loro rapido attecchimento."
                },

                new CalendarioLunare
                {
                   Mese = "MARZO ",
                   Giardino1 = "In fase calante si completano i lavori di taglio, potatura e pulizia di alberi, rosai a cespuglio e arbusti ornamentali in genere, che non erano stati potati in febbraio. Si potano anche le siepi sempreverdi se il clima non è rigido e non si prevedono repentini abbassamenti di temperatura. Preparate il terreno per le bordure nelle quali pensate di trapiantare le perenni e le annuali estive, lavorandolo e zappettandolo senza andare in profondità.",
                   Giardino2 = "Con la luna crescente si mettono a dimora le perenni ancora in fase quiescente e le specie stagionali che non temono il freddo, come primule e viole. In clima mite, dove il terreno è ormai tiepido, si piantano i rizomi di dalia.",

                   Orto1 = "Con la luna calante si seminano ortaggi da foglia come bietole da costa, lattuga, rucola, radicchi da taglio e cipolle; si concima e rincalza l’asparagiaia; si stende la pacciamatura intorno alle piantine di fragola appena messe a dimora.",
                   Orto2 = "Con la luna crescente si seminano a dimora carote, fave e ravanelli; si moltiplicano le specie aromatiche e ofﬁ cinali per divisione dei cespi, da ripiantare subito.",

                   Frutteto1 = "In fase calante si ﬁ niscono le potature e la pulizia degli alberi da frutto; si concima e si rinnova la pacciamatura intorno ai tronchi; si eseguono i trattamenti di prevenzione dalle avversità.",
                   Frutteto2 = "In fase crescente si possono mettere a dimora nuovi esemplari e in particolare meli e peri, che sono molto sensibili alla luna di marzo.",

                   CasaEBalcone1 = "In fase calante è tempo di effettuare il rinvaso delle piante tropicali da appartamento, tagliando le radici secche o troppo fitte, e trasferendole in un vaso più grande, ma non di molto.",
                   CasaEBalcone2 = "In fase crescente si dividono i cespi troppo fitti di felci, aracee e bromeliacee, piantando le porzioni in vasi di 15 cm, da tenere in cassone fino a primavera. In cantina, con luna calante si imbottigliano i vini frizzanti.",

                   FiorieLuna = "La magnolia giapponese, con grandi corolle che appaiono prima del fogliame, inizia in marzo a schiudere i suoi fiori appariscenti, profumati, bianco-rosati, che precedono le foglie. Va piantata in fase di luna crescente perché, in questo modo, viene favorito sia il buon attecchimento, sia la propensione dell’esemplare a fiorire con molta generosità."
                },

                new CalendarioLunare
                {
                   Mese = "APRILE ",
                   Giardino1 = "In fase calante si piantano le bulbose estive, gli arbusti sempreverdi e le erbacee perenni. Si lavora il terreno dove necessario, si concima e si irriga. Si sfalcia il tappeto erboso. Si riportano le piante acquatiche nel laghetto.",
                   Giardino2 = "In fase crescente si procede alla semina o al rinnovamento del manto erboso.",

                   Orto1 = "Con la luna calante si seminano lattughe, bietola, spinaci, patate, aglio e cipolla; si vanga il terreno, si zappettano e sarchiano le malerbe, si dispongono i tutori per i piselli rampicanti.",
                   Orto2 = "Con la luna crescente si seminano aromatiche, Solanacee, legumi, Cucurbitacee come melone e anguria, carote e ravanelli. Procedete alla forzatura dell’indivia e all’imbianchimento del radicchio. Potete seminare in semenzaio riscaldato il basilico, le melanzane, i peperoni e i pomodori. ",

                   Frutteto1 = "Con la luna calante si terminano gli innesti, si completa la lavorazione del terreno e si concima. ",
                   Frutteto2 = "In fase crescente si mettono a dimora olivi e vite.",

                   CasaEBalcone1 = "In fase calante si terminano i rinvasi e si sostituisce il terriccio superficiale delle piante in contenitore. Si sfoltiscono le piante in vaso per ripristinarne la silhouette. Si rinvasano i gerani dopo aver potato la chioma e accorciato le radici. ",
                   CasaEBalcone2 = "In fase crescente, si riportano gradualmente all’aperto le piante in vaso che sono ancora al riparo. ",

                   FiorieLuna = "Tra il primo e l’ultimo quarto azalee e rododendri danno il meglio in quanto a fioritura. Nonostante ciò, le azalee non amano essere trattate quando la luna è crescente: effettuate tutti i lavori, e in particolare le concimazioni, quando questa è calante."
                },

                new CalendarioLunare
                {
                   Mese = "MAGGIO ",
                   Giardino1 = "In fase calante si cimano le erbacee perenni per favorire la formazione di esemplari compatti e vigorosi. Si eliminano i polloni che nascono dal portainnesto delle rose, recidendo gli steli alla base, e si tolgono i boccioli in eccesso, per ottenere rose più grandi e più intensamente profumate. Sempre in questa fase si potano gli arbusti che hanno terminato la loro fioritura primaverile, come la forsizia e il cotogno da fiore. ",
                   Giardino2 = "In fase crescente si seminano le erbacee perenni a dimora o in semenzaio e si trapiantano le annuali e le bulbose a fioritura estiva acquistate in vasetto.",

                   Orto1 = "Con la luna calante si seminano lattughe e radicchi da taglio, bietole spinaci; si cimano meloni e angurie per ottenere frutti meno numerosi, ma più grossi e di migliore qualità, si rincalzano gli ortaggi e si esegue la sfemminellatura del pomodoro, si dispongono i tutori per i rampicanti, si effettua la pacciamatura della fragola.",
                   Orto2 = "In luna crescente si eseguono le operazioni di semine e trapianti (specie aromatiche e in particolare il basilico, ortaggi estivi come pomodoro e melanzana, legumi, zucche e zucchine ecc). ",

                   Frutteto1 = "In fase calante si esegue la potatura verde per alleggerire la chioma. Si diradano i frutti delle drupacee, si pota l’olivo. ",
                   Frutteto2 = "In fase crescente si piantano olivi, che gradiscono il trapianto quando il clima è mite e la terra abbastanza calda; in montagna si mettono a dimora mirtilli, lamponi, mora e ribes.",

                   CasaEBalcone1 = "In fase crescente si collocano in vasi e cassette le annuali da fiore e le bulbose come canna d’India, giglio e dalia.",
                   CasaEBalcone2 = "In fase di luna calante si portano in terrazzo i vasi di gerani che ancora non erano stati rimessi in vegetazione, effettuando una potatura di pulizia della chioma.",

                   FiorieLuna = "Il pisello odoroso e il nasturzio rampicante sono specie che si seminano preferibilmente con luna crescente, anche in vaso, quando il loro sviluppo verticale sarà più vigoroso. Le erbe infestanti del prato si estirpano nei primi giorni di luna crescente."
                },

                new CalendarioLunare
                {
                   Mese = "GIUGNO ",
                   Giardino1 = "In fase calante si tolgono dal terreno i bulbi ormai sfioriti e si ripongono per l’anno venturo; si sarchiano le aiuole da fiore; si fa una pacciamatura sotto ad alberi e arbusti, si potano quelli sfioriti. ",
                   Giardino2 = "Con la luna crescente si stendono i rotoli o le zolle di tappeto erboso pronto all’impianto; si trapiantano le annuali e le perenni a fIoritura autunnale.",

                   Orto1 = "In fase calante si cimano anguria e melone; si stende una pacciamatura; si rincalzano fagioli, melanzane, peperoni e patate; si dispongono i tutori per i rampicanti.",
                   Orto2 = "Con la luna crescente si seminano fagioli di tutti i tipi, barbabietole, carote e zucchine. ",

                   Frutteto1 = "In fase calante si esegue la potatura verde su Drupacee e vite e si diradano i grappoli d’uva. ",
                   Frutteto2 = "In fase crescente si trapiantano i giovani esemplari di kiwi acquistati in vaso.",

                   CasaEBalcone1 = "In fase calante si tolgono dai vasi i bulbi le cui foglie sono ormai ingiallite, si puliscono e si ripongono; si potano le rose e gli arbusti in vaso sfioriti.",
                   CasaEBalcone2 = "In fase crescente, si prendono talee delle specie legnose per riprodurle; si raccolgono le erbe aromatiche da essiccare.",

                   FiorieLuna = "Secondo le leggende popolari, le erbe raccolte nella notte di San Giovanni, 24 giugno, benedette dal Santo e dai particolari influssi astrali, sarebbero in grado di scacciare le malattie."
                },

                new CalendarioLunare
                {
                   Mese = "LUGLIO ",
                   Giardino1 = "In fase calante si cimano le erbacee ormai sfiorite, si potano leggermente le rose rampicanti non rifiorenti per ridurre il fogliame e arieggiare il centro della chioma. Si regolano siepi topiarie e arbusti; si prepara il terreno per seminare il prato; si applica una pacciamatura alle bulbose estive.",
                   Giardino2 = "In fase crescente si riproducono per talea gli arbusti da fiore, come l’ibisco di Siria, e i rampicanti come il rincospermo, la bignonia e il glicine; si dividono gli esemplari di iris, ripiantandoli entro un giorno o due al massimo; si seminano le erbacee perenni, che sbocceranno solo l’anno seguente. ",

                   Orto1 = "Con la luna calante si seminano in piena terra ortaggi a ciclo autunnale come la barbabietola e il finocchio precoce da coltivare sotto tunnel; si stende la pacciamatura intorno ai cavoli; si cimano le piante di angurie, meloni, cetrioli e zucche per evitare che si formino frutti piccoli.",
                   Orto2 = "Con la luna crescente si seminano fagioli di tutti i tipi, rape, bietole, carote tardo-estive e autunnali e zucchine, che faranno in tempo a maturare prima dell’arrivo dell’autunno, se saranno sempre irrigate con generosità.",

                   Frutteto1 = "In fase calante si esegue la potatura verde su albicocchi, ciliegi, peschi e su specie come i meli da fiore, che stanno producendo piccoli frutti ornamentali utilizzabili anche per la preparazione di marmellate; si eliminano i succhioni su melo e pero.",
                   Frutteto2 = "In fase crescente si inizia la piantagione delle fragole che daranno frutti l’anno seguente.",

                   CasaEBalcone1 = "In fase calante si potano le rose rampicanti e gli arbusti in vaso che sono ormai sfioriti; si asportano i germogli secondari delle dalie per avere fiori più grossi; si fanno marmellate e sciroppi con i frutti raccolti nell’orto e nel frutteto.",
                   CasaEBalcone2 = "In fase crescente, si preparano talee, si trapianta il crisantemo in vaso; si raccolgono le erbe aromatiche da essiccare.",

                   FiorieLuna = "L’iperico e la lavanda vanno trattati all’inizio della luna crescente, la riproduzione per talea deve essere effettuata 3 giorni prima del plenilunio.",
		           FiorieLuna1 = "La begonia non ama i chiari di luna: lasciatela stare in prossimità del plenilunio, evitando ogni operazione (concimazioni, trapianti o altro, compresi gli eventuali interventi antiparassitari)."
                },

                new CalendarioLunare
                {
                   Mese = "AGOSTO ",
                   Giardino1 = "In fase calante si cimano i rampicanti sempreverdi e il glicine; si potano le siepi sempreverdi; si eliminano i fiori appassiti dagli arbusti estivi; si preparano le buche per le piantagioni autunnali, da lasciare aperte in modo che sentano le piogge di fine estate.",
                   Giardino2 = "In fase crescente si cominciano a piantare, se il terreno è già rinfrescato e il clima non è torrido, i bulbi di narcisi e di crochi; si dividono i cespi delle erbacee perenni sfiorite, ripiantandole in substrato fertile.",

                   Orto1 = "Con la luna calante si cimano le Solanacee e le Cucurbitacee; si diradano i polloni di carciofo; si rincalzano finocchio e porro.",
                   Orto2 = "Con la luna crescente si vangano e concimano le parcelle liberate da precedenti coltivazioni; si trapiantano cavoli e lattughe invernali acquistate in vasetti e vassoi alveolari, allestendo un ombrario per evitare che i giovani esemplari siano bruciati dal sole.",

                   Frutteto1 = "In fase calante si continuano i lavori di potatura verde sulle susine tardive e sulle piante di pesco; si raccolgono i frutti da conservare in forma di marmellate e gelatine.",
                   Frutteto2 = "In fase crescente si allestisce il fragoleto in una zona ben esposta al sole e in terreno profondo, arricchito con stallatico. ",

                   CasaEBalcone1 = "In fase calante si continua la potatura di arbusti e rampicanti sfioriti; si eliminano costantemente e con cura i fiori sfioriti nelle fioriere; si preparano ancora prelibate conserve e marmellate.",
                   CasaEBalcone2 = "In fase crescente, si prelevano talee dai gerani e dalle fucsie per riprodurre le varietà preferite.",

                   FiorieLuna = "Le dalie, amanti del sole, mostrano uguale simpatia per la luce lunare: si avvantaggiano dei chiari di luna ed è consigliabile attender la luna crescente per la divisione dei cespi.",
		           FiorieLuna1 = "L’ortensia è un arbusto che dimostra simpatia per la luna crescente, durante la quale accetta bene trattamenti e potature. In questo periodo si possono tagliare i fiori da utilizzare, sistemati nei vasi, per la decorazione della casa.",
	               FiorieLuna2 = "Se le piante di rosa vengono infestate dagli afidi, favoriti dal clima meno caldo e più umido tipico della ﬁ ne dell’estate, è bene effettuare un trattamento antiparassitario di tipo biologico (piretro o infuso di ortica) da somministrare durante la fase di luna crescente."
                },

                new CalendarioLunare
                {
                   Mese = "SETTEMBRE ",
                   Giardino1 = "In fase calante si prepara il terreno per le piantagioni autunnali; si asportano i boccioli in eccesso dalle dalie; si esegue una potatura leggera sugli arbusti in modo da regolarne la forma.",
                   Giardino2 = "In fase crescente si seminano i nuovi tappeti erbosi; si seminano le perenni e le annuali rustiche; si interrano i bulbi a fioritura precoce.",

                   Orto1 = "Con la luna calante si seminano in semenzaio le cipolle, in piena terra si seminano ortaggi invernali come spinaci, valerianella, lattughe da taglio e anche i radicchi; si rincalza la carciofaia; si imbianchiscono le indivie.",
                   Orto2 = "Con la luna crescente si seminano prezzemolo e ravanelli sotto tunnel, per un raccolto invernale.",

                   Frutteto1 = "In fase calante si esegue la potatura verde del kiwi e della vite; si prepara e si concima il terreno con sostanza organica.",
                   Frutteto2 = "In fase crescente si cominciano a effettuare i nuovi impianti di specie da frutto acquistate in contenitore, se il clima è già fresco e si possono garantire irrigazioni regolari per tutto l’autunno in caso di scarsità di pioggia.",

                   CasaEBalcone1 = "In fase calante si eliminano i germogli più laterali dei crisantemi in vaso; verso fine mese si riportano in casa le orchidee e le piante da appartamento tropicali, che hanno passato l’estate all’aperto.",
                   CasaEBalcone2 = "In fase crescente, si preparano talee dalle rose e dalle altre piante ornamentali sul terrazzo; si raccolgono, inoltre, le erbe aromatiche da essiccare.",

                   FiorieLuna = "L’aconito preferisce essere piantato subito dopo il novilunio di settembre.",
		           FiorieLuna1 = "Le begonie, ancora in fiore, non amano la luce lunare: eseguite qualsiasi trattamento e intervento lontano dal plenilunio."
                },

                new CalendarioLunare
                {
                   Mese = "OTTOBRE ",
                   Giardino1 = "In fase calante si potano gli arbusti ormai sfioriti, gli alberi e i rosai esauriti; si preparano le buche per i nuovi rosai.",
                   Giardino2 = "In fase crescente si seminano i nuovi prati e si rinnovano quelli rovinati; si piantano i bulbi a fioritura precoce e primaverile; si piantano alberi e rose.",

                   Orto1 = "Con la luna calante si seminano le lattughe da taglio e la valerianella, si pianta l’aglio e si trapianta la cipolla; si fa la concimazione delle parcelle per le nuove semine; si imbianchiscono le indivie.",
                   Orto2 = "Con la luna crescente si riproducono per divisione dei cespi le erbe aromatiche.",

                   Frutteto1 = "In fase calante si prepara e si concima il terreno, e si distribuisce la pacciamatura.",
                   Frutteto2 = "In fase crescente si effettuano i trapianti di nuovi esemplari arborei e arbustivi, come l’uvaspina e le varietà di mora.",

                   CasaEBalcone1 = "In fase calante si prelevano dai vasi e si ripongono i bulbi estivi, ormai sfioriti, dopo averli ben puliti e lasciati asciugare; si prelevano le piante delicate dal balcone per metterle al riparo.",
                   CasaEBalcone2 = "In fase crescente, si piantano nei vasi i bulbi a ﬁ oritura primaverile. Si seminano in semenzaio riscaldato le specie annuali da trapiantare in vasi e cassette solo a fine inverno.",

                   FiorieLuna = "Il tulipano si colloca nel terreno in tardo autunno, con luna crescente, per farlo fiorire rigoglioso in primavera.",
		           FiorieLuna1 = "Il muscari invece darà il meglio di sé se viene interrato subito prima della luna piena, in ottobre o novembre."                
		},

                new CalendarioLunare
                {
                   Mese = "NOVEMBRE ",
                   Giardino1 = "In fase calante si preparano la buche d’impianto per gli arbusti, si potano i bambù, si esegue la concimazione nelle aiuole, nelle bordure e alla base degli arbusti.",
                   Giardino2 = "In fase crescente si interrano i bulbi primaverili, si trapiantano le biennali, si dividono le erbacee perenni e si mettono a dimora i nuovi alberi, gli arbusti, le siepi e i rosai.",

                   Orto1 = "Con la luna calante si semina l’aglio; si prepara il terreno per le piantagioni primaverili e si vangano le parcelle delle colture che hanno concluso il loro ciclo; si imbianchiscono le indivie, i cardi e i porri.",
                   Orto2 = "In luna crescente si seminano fave e piselli; si raccolgono bietole, carote e finocchi.",

                   Frutteto1 = "Con la luna calante si lavora la terra del frutteto, integrandone la fertilità con materiale organizo (stallatico maturo, terriccio da compost) e si raccolgono le foglie rastrellando con cura ai piedi delle piante.",
                   Frutteto2 = "In luna crescente si possono mettere a dimora nuovi esemplari di specie arboree e arbustive (lampone, ribes), se il terreno non è ancora gelato.",

                   CasaEBalcone1 = "In fase calante si predispongono le protezioni contro il gelo, cimando i tralci più lunghi prima di riparare le piante.",
                   CasaEBalcone2 = "In fase crescente si piantano i tulipani, i narcisi e gli altri bulbi a fioritura primaverile in vasi oppure in cassette.",

                   FiorieLuna = "In fase crescente si piantano i tulipani, i narcisi e gli altri bulbi a fioritura primaverile in vasi oppure in cassette.",
		           FiorieLuna1 = "Il giglio reagisce bene alla luna crescente: aspettate questa fase per dividere i cespi."
                },

                new CalendarioLunare
                {
                   Mese = "DICEMBRE ",
                   Giardino1 = "Con la luna calante si prepara il terreno per le semine primaverili, lavorandolo in modo da rompere le zolle ed esporre al gelo il primo strato: sarà il freddo a eliminare i parassiti svernanti. Sempre in questa fase si predispone la pacciamatura per le erbacee perenni, utilizzando foglie secche e corteccia; si tagliano alla base i crisantemi ormai appassiti.",
                   Giardino2 = "Con la luna crescente, se il suolo non è ancora gelato, si possono piantare i nuovi esemplari di rose e i giovani alberi, gli arbusti e le specie rampicanti come il glicine, il rincospermo e la bignonia.",

                   Orto1 = "Con la luna calante si sgombrano le aiuole e si preparano le semine primaverili: si lavora il terreno e si concima; si seminano a dimora in coltura protetta lattuga e radicchio da taglio; si raccoglie l’indivia belga e il radicchio rosso.",
                   Orto2 = "In fase crescente si seminano i ravanelli, a dimora, sotto protezione.",

                   Frutteto1 = "Con la luna calante si potano le specie da frutto, si raccolgono le olive e gli agrumi e si prelevano le marze per gli innesti da effettuare in gennaio.",
                   Frutteto2 = "",

                   CasaEBalcone1 = "Con la luna calante si collocano nei vasetti le bulbose da forzare per averle fiorite a Natale e a gennaio, tenendole prima al fresco e poi in casa, ben esposte alla luce. Sempre in fase calante si predispongono le protezioni per le piante del balcone, coprendole con teli, mettendole in serra o spostandole in ambiente con temperature intorno ai 12 °C, come una veranda o un pianerottolo.",
                   CasaEBalcone2 = "",

                   FiorieLuna = "La peonia preferisce essere trapiantata con luna calante, quando le sue radici sono a riposo.",
		           FiorieLuna1 = "Recidete i rami di agrifoglio per le decorazioni in luna crescente: dureranno più a lungo."
                },




            };

            return data;
        }

        // TODO WTS: Remove this once your MasterDetail pages are displaying real data
        public static async Task<IEnumerable<CalendarioLunare>> GetSampleModelDataAsync()
        {
            await Task.CompletedTask;

            return AllCalendarioLunare();
        }

        
    }
}
