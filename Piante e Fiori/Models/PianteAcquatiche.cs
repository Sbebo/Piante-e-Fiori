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
//22 PIANTE DA ACQUATICHE E DA RIVA
    public class PianteAcquatiche
    {
        public string NomeComunePianta { get; set; }
        public string NomeFamiglia { get; set; }
        public string NomeScientificoPianta { get; set; }
        public string FotoPianta { get; set; }
        public string SourceGalleryFotografica { get; set; }

        public string DescrizioneBotanica { get; set; }
        public string Coltivazione { get; set; }
        public string Malattie { get; set; }
        public string Potatura { get; set; }
        public string Propagazione { get; set; }


    }

    public static class PianteAcquaticheDataService
    {
        private static IEnumerable<PianteAcquatiche> AllPianteAcquatiche()
        {
            // The following is order summary data
            var data = new ObservableCollection<PianteAcquatiche>
            {
               
                new PianteAcquatiche
                {
                   NomeComunePianta = "ASTILBE",
                   NomeFamiglia = "Sassifragacee",
                   NomeScientificoPianta = "Astilbe",
                   FotoPianta = "ms-appx:///Immagini/Acquatiche/Astilbe/ASTILBE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Acquatiche/Abete-*.jpg",

                   DescrizioneBotanica = "L’ASTILBE GRADISCE LE POSIZIONI UMIDE VICINO ALLE SPONDE, DOVE PRODUCE IN ESTATE NUVOLE DI FIORI ROSA, COMPOSTI DA FIORELLINI RACCOLTI IN INFIORESCENZE PIUMOSE E LEGGERE. SONO PARTICOLARMENTE DECORATIVE PIANTATE IN GRUPPI, IN ABBINAMENTO A IRIS E PRIMULE. IL FOGLIAME È PROFONDAMENTE DIVISO, CON RIFLESSI COLOR RAME QUANDO È GIOVANE, ESISTONO ANCHE ASTILBE A FIORE BIANCO, DI UNA BELLEZZA MOLTO DELICATA, COME A. GRANDIS E A. JAPONICA. ",
                   Coltivazione = "Erbacea perenne rizomatosa, rustica e facile, richiede una posizione al sole o alla mezz’ombra e un terreno soffice, sciolto, umido, costantemente irrigato in estate. Tollera il freddo anche intenso, teme di più il caldo torrido, per questo preferisce la mezz’ombra al pieno sole. Si può collocare anche all’ombra, dove però la fioritura sarà molto meno esuberante. Le varietà più piccole si coltivano anche in vaso.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                   
                },

                new PianteAcquatiche
                {
                   NomeComunePianta = "BUTOMUS",
                   NomeFamiglia = "Botumacee",
                   NomeScientificoPianta = "Butomus umbellatus",
                   FotoPianta = "ms-appx:///Immagini/Acquatiche/Butomus/BUTOMUS.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Acquatiche/Abete-*.jpg",

                   DescrizioneBotanica = "NOTO ANCHE COME GIUNCO FIORITO, PROSPERA NEI TERRENI PALUDOSI E LUNGO I MARGINI DI LAGHETTI TRANQUILLI. HA FOGLIE LUNGHE (ANCHE 90 CM) E LINEARI, PORPORA E POI VERDI, LARGHE APPENA 1 CM, CHE SI SVILUPPANO DALLA BASE E CIRCONDANO IL FUSTO. IN ESTATE PRODUCE OMBRELLE LARGHE 10 CM DI MINUTI FIORI ROSA A COPPA.",
                   Coltivazione = "Diffusa come pianta spontanea in Europa e in Asia, è una pianta rustica e facile, a crescita lenta. Si sviluppa da un grosso rizoma carnoso e gradisce suoli ricchi di humus e posizioni soleggiate o in leggera ombra. Sopporta il gelo, mentre soffre quando il caldo è torrido (necessaria la mezz’ombra nei climi più caldi). Perfetta per rive e bordi, può essere piantata anche in una zona sommersa, con acqua profonda 15 cm al massimo. A fine estate produce capsule contenenti decine di semi.",
                   Malattie = "",
                },

                new PianteAcquatiche
                {
                   NomeComunePianta = "CALLA",
                   NomeFamiglia = "Aracee",
                   NomeScientificoPianta = "Zantedeschia aethiopica",
                   FotoPianta = "ms-appx:///Immagini/Acquatiche/Calla/CALLA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Acquatiche/Abete-*.jpg",

                   DescrizioneBotanica = "ELEGANTE E AUSTERA, LA CALLA DÀ UN TOCCO SOFISTICATO AL GIARDINO ACQUATICO, DOVE ADORNA LE RIVE CON I SUOI LUNGHI STELI CIRCONDATI DA FOGLIE VERDE SCURO, CHE PORTANO I CARATTERISTICI FIORI. QUSTI ULTIMI SONO COSTITUITI DA UNA SINGOLA SPATA, GENERALMENTE DI COLORE BIANCO, PRODOTTA TRA MAGGIO E LUGLIO, DELICATAMENTE PROFUMATA.",
                   Coltivazione = "Pianta palustre da bordura per laghetto, perenne, rizomatosa, semirustica, ama vivere con le radici in acqua e i suoi rizomi si trovano a loro agio se leggermente sommersi. Si coltiva in posizioni soleggiate o comunque molto luminose. Gradisce un terreno ricco di sostanza organica. Dal momento che teme il gelo, la si può collocare in appositi cestini traforati sui bordi del laghetto: in questo modo, nel periodo invernale, è possibile estrarre agevolmente le piante per ripararle.",
                   Malattie = "",
                },

                new PianteAcquatiche
                {
                   NomeComunePianta = "CALTHA",
                   NomeFamiglia = "Ranunculacee",
                   NomeScientificoPianta = "Caltha palustris",
                   FotoPianta = "ms-appx:///Immagini/Acquatiche/Caltha/CALTHA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Acquatiche/Abete-*.jpg",

                   DescrizioneBotanica = "ANCHE CHIAMATA RANUNCOLO ACQUATICO, QUESTA PIANTA PER TERRENI PALUDOSI E ACQUE POCO PROFONDE SFOGGIA IN PRIMAVERA GRAZIOSI FIORI DI UN VISTOSO GIALLO ORO, CHE SI STAGLIANO CONTRO LE FOGLIE A FORMA DI CUORE, VERDI CON RIFLESSI PURPUREI. LA VARIETÀ ‘PLENA’ È MOLTO ORNAMENTALE CON I SUOI FIORI DOPPI; ‘ALBA’, ORIGINARIA DELL’HIMALAYA, È PIÙ PICCOLA E HA FIORI BIANCHI. ‘POLYPETALA’ È LA VARIETÀ PIÙ ALTA: ADATTA A GRANDI BACINI, CREA AMPIE MACCHIE DI VEGETAZIONE.",
                   Coltivazione = "Si pianta da marzo a settembre, in acqua profonda, al massimo 15 cm, ed è tra le prime piante acquatiche a fiorire: in aprile produce una profusione di corolle, larghe circa 3-4 cm, con 5 petali arrotondati. È una pianta perenne, rustica, molto diffusa in Europa, che ama le posizioni soleggiate ai margini degli stagni, ma tollera anche una leggera ombra. Preferisce un terreno lievemente acido, umido e fertile.",
                   Malattie = "",
                },

                new PianteAcquatiche
                {
                   NomeComunePianta = "CASTAGNA D’ACQUA",
                   NomeFamiglia = "Trapacee",
                   NomeScientificoPianta = "Trapa natans",
                   FotoPianta = "ms-appx:///Immagini/Acquatiche/CastagnaAcqua/CASTAGNAACQUA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Acquatiche/Abete-*.jpg",

                   DescrizioneBotanica = "FLUTTUA LIBERAMENTE SUL PELO DELL’ACQUA, PRODUCENDO RADICI CHE CRESCONO SOTT’ACQUA E ASSORBONO I SALI MINERALI IN ESSA DISCIOLTI. PER QUESTO, LA CASTAGNA D’ACQUA AGISCE COME DEPURATORE BIOLOGICO, CHE RIDUCE L’INQUINAMENTO ORGANICO DELL’ACQUA. HA FOGLIE VERDI ROMBOIDALI GALLEGGIANTI E DENTATE, DISPOSTE A ROSETTA SU UN PICCIOLO ROSSASTRO. IN PRIMAVERA SBOCCIANO FIORI SOLITARI BIANCHI O ROSA, CHE GALLEGGIANO AL DI SOPRA DELLE FOGLIE.",
                   Coltivazione = " Pianta facile e inesigente, originaria dell’Asia ma ampiamente diffusa in Europa, preferisce vivere al sole, ma tollera egregiamente anche l’ombra. Viene coltivata come annuale, ma produce grossi frutti conici, ognuno dei quali contiene un seme da piantare nel fondo del bacino: ogni primavera dai semi si sviluppa una nuova rosetta di foglie. Le radici ancorano la pianta al terreno e gradiscono qualsiasi tipo di suolo.",
                   Malattie = "",
                },

                new PianteAcquatiche
                {
                   NomeComunePianta = "ELODEA",
                   NomeFamiglia = "Idrocaritacee",
                   NomeScientificoPianta = "Elodea canadensis",
                   FotoPianta = "ms-appx:///Immagini/Acquatiche/Elodea/ELODEA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Acquatiche/Abete-*.jpg",

                   DescrizioneBotanica = "MEGLIO NOTA COME PESTE D’ACQUA, ACERRIMA NEMICA DELLE ALGHE E GRANDE ALLEATA DEI PESCI, QUESTA PIANTA AGISCE COME UN FILTRO NATURALE. SI TRATTA DI UN’ACQUATICA PERENNE DAL POTERE OSSIGENANTE, CHE RIMANE COMPLETAMENTE SOMMERSA, ALLUNGANDO DAL FONDALE I SUOI FUSTI SOTTILI E CARNOSI, LUNGHI PIÙ DI UN METRO. I FUSTI PORTANO INNUMEREVOLI FOGLIOLINE VERDE SCURO E, DA LUGLIO A SETTEMBRE , PICCOLI FIORI COLOR ROSA O LAVANDA. ",
                   Coltivazione = "Prospera sul fondale di laghetti profondi da 20 a 200 cm, con una preferenza per le acque calme, ricche di elementi minerali e ben esposte al sole: troppa ombra può farla morire. É rustica e non teme il gelo: i fusti, generalmente ﬂ essibili, con il freddo si irrigidiscono e si spezzano in porzioni che radicano a contatto con il fondale. É opportuno controllarne lo sviluppo, che può diventare eccessivo.",
                   Malattie = "",
                },

                new PianteAcquatiche
                {
                   NomeComunePianta = "GIACINTO D’ACQUA",
                   NomeFamiglia = "Pontederiacee",
                   NomeScientificoPianta = "Eichornia crassipes",
                   FotoPianta = "ms-appx:///Immagini/Acquatiche/GiacintoAcqua/GIACINTOACQUA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Acquatiche/Abete-*.jpg",

                   DescrizioneBotanica = "TRA LE PIANTE GALLEGGIANTI, IL GIACINTO D’ACQUA È UNA DELLE PIÙ BELLE. I FIORI RICORDANO QUELLI DELLA OMONIMA BULBOSA O DI UN’ORCHIDEA. HANNO COLORE AZZURRO-LAVANDA, SONO RIUNITI IN SPIGHE DI 10 CM E PERDURANO A LUNGO IN ESTATE, PORTANDO UNA NOTA DI COLORE INSOLITA NEL LAGHETTO E GARANTENDO UN PRONTO EFFETTO STREPITOSO. ",
                   Coltivazione = "Erbacea perenne rizomatosa tropicale, è adatta alle zone a clima mite, dove può moltiplicarsi a dismisura, diventando in breve tempo invadente: nelle zone con clima freddo, però, muore in autunno. Si coltiva al sole, in acque profonde da 15 a 45 cm, dalle quali emerge per 20-30 centimetri. Le foglie hanno forma di cuore, sono lucide e di un verde brillante. Pur essendo galleggiante (le radici non vanno interrate), ha bisogno di terreno fertile, in modo da trarre i sali minerali che questo cede all’acqua.",
                   Malattie = "",
                },

                new PianteAcquatiche
                {
                   NomeComunePianta = "GUNNERA",
                   NomeFamiglia = "Gunneracee",
                   NomeScientificoPianta = "Gunnera manicata",
                   FotoPianta = "ms-appx:///Immagini/Acquatiche/Gunnera/GUNNERA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Acquatiche/Abete-*.jpg",

                   DescrizioneBotanica = "TRIONFA CON LE SUE GIGANTESCHE FOGLIE, COLOR VERDE SCURO, RENIFORMI, LOBATE E DENTATE, CHE RAGGIUNGONO FINO A 3 M DI DIAMETRO. QUESTA PIANTA PERENNE, FACILE E ADATTABILE, A PORTAMENTO CESPITOSO, PROSPERA IN RIVA AI LAGHETTI E SUL BORDO DEI CORSI D’ACQUA, DONANDO UN ASPETTO ESOTICO ALL’INSIEME. ",
                   Coltivazione = " Originaria del Brasile, mediamente rustica, Gunnera manicata non teme le gelate tardive: le eventuali foglie annerite vegnono rapidamente sostituite da nuovi germogli. Si pianta in posizioni soleggiate o a mezz’ombra, in terreni umidi e profondi, al riparo dei venti che potrebbero danneggiare le foglie. I fiori, insignificanti, sono pannocchie rosso-brune che compaiono in aprile. Per proteggere la pianta dal gelo, è sufficiente reciderne le foglie ormai secche e disporle attorno al colletto, insieme a uno strato di terriccio.",
                   Malattie = "",
                },

                new PianteAcquatiche
                {
                   NomeComunePianta = "HOUTTUYNIA",
                   NomeFamiglia = "Saururacee",
                   NomeScientificoPianta = "Houttuynia cordata",
                   FotoPianta = "ms-appx:///Immagini/Acquatiche/Hottuynia/HOUTTUYNIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Acquatiche/Abete-*.jpg",

                   DescrizioneBotanica = "È UNA GRAZIOSA PIANTA PALUSTRE CON LE FOGLIE A FORMA DI CUORE, PROFUMATE, E I FIORI BIANCHI. PARTICOLARMENTE DECORATIVE SONO LE VARIETÀ ‘PLENA’ E ‘VARIEGATA’: LA PRIMA HA FIORI DOPPI E CRESCITA VIGOROSA, LA SECONDA HA FOGLIE TRICOLORI, GIALLO, VERDE E ROSSO, E SVILUPPO PIÙ LENTO E COMPATTO. ",
                   Coltivazione = "Originaria di Cina e Giappone, Houttuynia è un’erbacea perenne palustre, che deve avere le radici nell’acqua: deve essere interrata lungo le rive in acqua profonda 7-10 cm, con terreno ricco e sciolto. Rustica e vigorosa, si allarga rapidamente, ma in autunno secca completamente per poi rispuntare l’anno successivo. Cresce bene sia al sole che in mezz’ombra, non teme il freddo, e raggiunge un’altezza massima di 30-40 centimetri. Il fogliame delle varietà variegate diventa più intensamente colorato se la pianta è in pieno sole. ",
                   Malattie = "",
                },

                new PianteAcquatiche
                {
                   NomeComunePianta = "IBISCO PALUSTRE",
                   NomeFamiglia = "Malvacee",
                   NomeScientificoPianta = "Hibiscus palustris",
                   FotoPianta = "ms-appx:///Immagini/Acquatiche/Ibisco Palustre/IBISCO PALUSTRE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Acquatiche/Abete-*.jpg",

                   DescrizioneBotanica = "COME GLI ALTRI RAPPRESENTANTI DELLA SUA FAMIGLIA, ANCHE L’IBISCO PALUSTRE È APPREZZATO PER LA FIORITURA VISTOSA, ABBONDANTE E SPETTACOLARE: GRANDI COROLLE IMBUTIFORMI, LARGHE 15 CM, DI COLOR PORPORA, IN GIUGNO E LUGLIO, PORTATE SU STELI SOTTILI E FLESSUOSI. È MOLTO DECORATIVO, DA COLLOCARE SULLA SPONDA A RIDOSSO DELL’ACQUA.",
                   Coltivazione = " Originario del sud degli Stati Uniti, l’ibisco palustre è un’erbacea perenne semirustica, adatta a posizioni soleggiate, o in ombra parziale, e a terreni molto umidi, anche vicino ad acque salmastre. La pianta sviluppa fusti alti fino a 150 cm e larghe foglie ovali o trilobate e dentate. La rimozione dei fiori appassiti stimola una nuova produzione. In autunno perde la parte aerea, che riemetterà in primavera. Sopporta temperature di poco inferiori allo zero, se la base è adeguatamente protetta da pacciamatura.",
                   Malattie = "",
                },

                new PianteAcquatiche
                {
                   NomeComunePianta = "IRIS",
                   NomeFamiglia = "Iridacee",
                   NomeScientificoPianta = "Iris pseudacorus, I. laevigata",
                   FotoPianta = "ms-appx:///Immagini/Acquatiche/Iris/IRIS.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Acquatiche/Abete-*.jpg",

                   DescrizioneBotanica = "UN CLASSICO PER I BORDI DELLO STAGNO: GLI IRIS PRODUCONO FIORI SPLENDIDI, ANCHE SE POCO DURATURI, E FOGLIE DECORATIVE, LINEARI E VERTICALI. TRA I MIGLIORI IRIS ACQUATICI SI DISTINGUE IRIS PSEUDACORUS, DAI GRANDI FIORI GIALLI IN MAGGIO-GIUGNO PORTATI SU STELI ALTI FINO A 150 CM; PERFETTO ANCHE IRIS LAEVIGATA, DAI FIORI BLU A SEI PETALI FINI E ALLUNGATI.",
                   Coltivazione = " Gli iris acquatici sono vigorosi, ma senza diventare invadenti, e si adattano a qualsiasi laghetto. Il rizoma vive bene sia immerso nell’acqua sia a ridosso della sponda. Molto rustica, resiste al gelo. I. pseudacorus, dalle foglie verdi-azzurre, include varietà adatte ad acque profonde dai 15 ai 45 cm; ‘Variegata’ presenta foglie straite di giallo. I. laevigata, dalle foglie verde chiaro, è adatto ad acqua profonde 5-10 cm; ‘Alba’ ha fiori bianchi e ‘Variegata’ ha fiori azzurri e foglie striate d’argento. ",
                   Malattie = "",
                },

                new PianteAcquatiche
                {
                   NomeComunePianta = "LEMNA",
                   NomeFamiglia = "Lemnacee",
                   NomeScientificoPianta = "Lemna minor",
                   FotoPianta = "ms-appx:///Immagini/Acquatiche/Lemna/LEMNA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Acquatiche/Abete-*.jpg",

                   DescrizioneBotanica = "LA LEMNA, O LENTICCHIA D’ACQUA, È UNA PIANTA GALLEGGIANTE CHE FORMA RAPIDAMENTE UN DENSO TAPPETO SUL PELO DELL’ACQUA, CON LE SUE MINUSCOLE FOGLIE (DA POCHI MILLIMETRI A 5 CM) TONDEGGIANTI E VERDI, CHE SONO IN REALTÀ TANTE PIANTINE, ESSENDO OGNUNA DOTATA DI RADICE. DIFFUSA NEI CLIMI TEMPERATI, QUESTA PIANTA PUÒ DIVENTARE INVADENTE. ",
                   Coltivazione = "Prospera in acqua ferme, laghetti bassi e lenti, paludi. Svolge l’importante funzione di filtrare l’acqua e contrastare le alghe, ma è necessario contenerla: basta infatti introdurre poche foglie e, in primavera, ognuna di esse si dividerà, producendo un nuovo esemplare e creando rapidamente una colonia che potrebbe arrivare a sottrarre luce alle altre piante. La temperatura ideale è tra i 20 e i 30 °C: in clima troppo freddo o troppo caldo, le piccole piante affondano nell’acqua.",
                   Malattie = "",
                },

                new PianteAcquatiche
                {
                   NomeComunePianta = "LISICHYTON",
                   NomeFamiglia = "Aracee",
                   NomeScientificoPianta = "Lysichiton americanum",
                   FotoPianta = "ms-appx:///Immagini/Acquatiche/Lisichyton/LISICHYTON.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Acquatiche/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTA PERENNE DI ORIGINE NORD AMERICANA, AMA I SUOLI UMIDI, I LUOGHI PALUDOSI, I MARGINI DEI LAGHETTI. NON PASSA CERTO INOSSERVATA: TRA MARZO E MAGGIO, PRIMA DELLO SVILUPPO COMPLETO DELLE FOGLIE, COMPAIONO LE ELEGANTI BRATTEE GIALLE, CHE AVVOLGONO L’INFIORESCENZA, UN VISTOSO SPADICE LUNGO 10-15 CM, DALL’ODORE SGRADEVOLE (MA AMATO DAGLI INSETTI IMPOLLINATORI). LE FOGLIE SONO GIGANTESCHE (PIÙ DI 1 M), LANCEOLATE E ACUMINATE ALL’APICE.",
                   Coltivazione = "Rustica e longeva, tende a formare una grande massa di rizomi che va contenuta. Si coltiva in terreno profondo, molto umido, ricco di sostanza organica. Si ottiene per semina (da rinvasare e mettere a dimora solo dopo un paio di anni) o per divisione dei cespi. Ama il sole, ma tollera la mezz’ombra. La specie L. camtschatcense è più piccola, ha foglie verde-azzurro e splendide brattee candide.",
                   Malattie = "",
                },

                new PianteAcquatiche
                {
                   NomeComunePianta = "LOTO",
                   NomeFamiglia = "Nelumbonacee",
                   NomeScientificoPianta = "Nelumbo nucifera",
                   FotoPianta = "ms-appx:///Immagini/Acquatiche/Loto/LOTO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Acquatiche/Abete-*.jpg",

                   DescrizioneBotanica = "AMATO PER LA BELLEZZA STREPITOSA E LE DIMENSIONI DEI FIORI, IL LOTO È ANCHE UNA PIANTA RUSTICA E ROBUSTA. A DIFFERENZA DELLE NINFEE, PRODUCE FOGLIE CHE SI SOLLEVANO DALL’ACQUA. PERFINO LE CAPSULE DEI SEMI RISULTANO MOLTO DECORATIVE. I FIORI SONO GENERALMENTE GRANDI E VISTOSI (ANCHE 50 CM), MA ESISTONO VARIETÀ NANIZZATE, ADATTE ANCHE ALLA COLTIVAZIONE IN VASO. NELUMBO LUTEA, AMERICANA, PRESENTA ANCHE FIORITURE GIALLE, ASSENTI NELLA SPECIE ORIENTALE.",
                   Coltivazione = "Il loto ha bisogno di molte ore di sole e di acqua ferma. Chiede molto spazio: in media 2 mq per ogni esemplare. Va collocato in terriccio argilloso e limoso, ricco di sostanza organica naturale. È rustico, non teme il gelo e può essere coltivato senza problemi anche nel Nord Italia, fino ai piedi delle Alpi. Si colloca in cesti di plastica forata, per contenerne lo sviluppo. Le fioriture migliori si ottengono in acqua calda, sui 23-35 °C. ",
                   Malattie = "",
                },

                new PianteAcquatiche
                {
                   NomeComunePianta = "LYTHRUM",
                   NomeFamiglia = "Litracee",
                   NomeScientificoPianta = "Lythrum salicaria",
                   FotoPianta = "ms-appx:///Immagini/Acquatiche/Lythrum/LYTHRUM.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Acquatiche/Abete-*.jpg",

                   DescrizioneBotanica = "ADORNA IL LAGHETTO CON UNA RICCA FIORITURA DA GIUGNO A SETTEMBRE: NUMEROSE, SVETTANTI SPIGHE DI COLORE ROSA INTENSO CHE SI ERGONO FINO A 80 CM DI ALTEZZA NEI PRESSI DELLE RIVE DELLO SPECCHIO D’ACQUA. LA VARIETÀ ‘DROPMORE’ HA FIORI PORPORA E ‘THE BEACON” HA SPIGHE CREMISI E MOLTO DENSE.",
                   Coltivazione = "Erbacea perenne rustica originaria dell’Europa e dell’Asia, ama i suoli umidi, ma deve avere le radici fuori dall’acqua, ben ancorate al terreno. Si pianta in ottobre o in marzo, in qualsiasi tipo di terreno, preferibilmente al sole o anche a mezz’ombra. In autunno gli steli semilegnosi e bruni vanno tagliati alla base. I rizomi si sviluppano vigorosamente e la pianta tende ad autoseminarsi: è bene contenerne lo sviluppo per evitare che soffochi gli altri vegetali. Esiste anche una specie del tutto simile ma di dimensioni più contenute: L. virgatum.",
                   Malattie = "",
                },

                new PianteAcquatiche
                {
                   NomeComunePianta = "MYRIOPHYLLUM",
                   NomeFamiglia = "Aloragacee",
                   NomeScientificoPianta = "Myriophyllum aquaticum",
                   FotoPianta = "ms-appx:///Immagini/Acquatiche/Myriophyllum/MYRIOPHYLLUM.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Acquatiche/Abete-*.jpg",

                   DescrizioneBotanica = "NOTA ANCHE COME “MILLEFOGLIO D’ACQUA” QUESTA ACQUATICA PERENNE PIÙ CHE PER LA BELLEZZA È COLTIVATA PER L’UTILITÀ: SVOLGE UNA FUNZIONE OSSIGENANTE, MANTENENDO LIMPIDA L’ACQUA. DAL RIZOMA, DENSO DI RADICI, SI ALZANO SOTTILI FUSTI, CHE EMERGONO DALL’ACQUA COPERTI DI INNUMEREVOLI FOGLIOLINE DI UN BEL VERDE BRILLANTE, RIUNITE IN MAZZETTI PIUMOSI. IN ESTATE PRODUCE PANNOCCHIE DI FIORELLINI ROSSI, ROSA O BIANCHI, SEGUITE DA CAPSULE CONTENENTI I SEMI.",
                   Coltivazione = "Pianta perenne rizomatosa, originaria dell’Europa e dell’Asia, prospera sia al sole che all’ombra, è rustica e non teme il freddo. Preferisce laghetti bassi e lenti, ma può svilupparsi anche in bacini molto profondi grazie alla capacità dei fusti di allungarsi per molti metri. Nei climi caldi può diventare infestante. Il portamento strisciante la rende decorativa anche se piantata sulla riva, con un eﬀ etto di cascata verso l’acqua.",
                   Malattie = "",
                },

                new PianteAcquatiche
                {
                   NomeComunePianta = "NINFEE",
                   NomeFamiglia = "Ninfeacee",
                   NomeScientificoPianta = "Nymphaea",
                   FotoPianta = "ms-appx:///Immagini/Acquatiche/Ninfee/NINFEE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Acquatiche/Abete-*.jpg",

                   DescrizioneBotanica = "SONO LE VERE REGINE DEL LAGHETTO. ESISTONO NINFEE TROPICALI E NINFEE RUSTICHE. LE PRIME SI COLTIVANO IN CLIMI MITI OPPURE SI RICOVERANO IN INVERNO IN VASCHE CON TEMPERATURE SUPERIORI AI 10°C; LE SECONDE SONO ADATTE ALLA COLTIVAZIONE ALL’APERTO IN QUASI TUTTA ITALIA (ECCETTO LE ALPI). ",
                   Coltivazione = "Si piantano tra marzo e aprile (con temperature non inferiori a 10 °C), sul fondo oppure, preferibilmente, in vasi di plastica forati, con terra argillosa, da immergere nel laghetto in base alla profondità richiesta dalla pianta. La coltivazione in vaso permette di contenerne lo sviluppo esuberante e di ritirarle in inverno (necessario per le ninfee tropicali). Vanno controllate in estate e autunno per impedire che si espandano troppo, sia con le foglie in superficie, sia moltiplicandosi in eccesso. ",

                   Malattie = "",
                },

                new PianteAcquatiche
                {
                   NomeComunePianta = "PAPIRO",
                   NomeFamiglia = "Ciperacee",
                   NomeScientificoPianta = "Cyperus papyrus",
                   FotoPianta = "ms-appx:///Immagini/Acquatiche/Papiro/PAPIRO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Acquatiche/Abete-*.jpg",

                   DescrizioneBotanica = "CON LE SUE TIPICHE OMBRELLE E GLI STELI NUDI, ALTI E SOTTILI, REGALA UNA PIACEVOLE NOTA ESOTICA AI MARGINI DELLE VASCHE E DEI LAGHETTI. IL PAPIRO EGIZIANO (CYPERUS PAPYRUS) HA OMBRELLE PIUMOSE DI UN VIVO COLOR VERDE-GIALLO PARTICOLARMENTE DECORATIVE E PUÒ RAGGIUNGERE I 3 M DI ALTEZZA. C. ALTERNIFOLIUS È LA SPECIE PIÙ DIFFUSA, CON FOGLIE A OMBRELLA SU STELI RIGIDI, E ALTEZZA FINO A 1,5 M, MENTRE C. LONGUS PRESENTA FOGLIE A PUNTA, PIÙ LUNGHE. ",
                   Coltivazione = "Tutti i papiri apprezzano gli ambienti umidi e soleggiati. Il papiro egiziano è una specie delicata, che nei climi freddi va riparata d’inverno, così come C. alternifolius, entrambe di origine africana. La specie europea (C. longus) è rustica e non teme il freddo. Si pianta tra aprile e giugno, al sole o in mezz’ombra, in contenitori forati sul fondo con terriccio fertile, da sommergere fino a 45 cm. In autunno si asportano le foglie vecchie.",
                   Malattie = "",
                },

                new PianteAcquatiche
                {
                   NomeComunePianta = "PONTEDERIA",
                   NomeFamiglia = "Pontederiacee",
                   NomeScientificoPianta = "Pontederia cordata",
                   FotoPianta = "ms-appx:///Immagini/Acquatiche/Pontederia/PONTEDERIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Acquatiche/Abete-*.jpg",

                   DescrizioneBotanica = "È UNA MAGNIFICA PIANTA PERENNE DI ORIGINE AMERICANA CHE SI COLTIVA AI MARGINI DEI LAGHETTI. MOSTRA BELLE FOGLIE A FORMA DI CUORE, LUCIDE, VERDE INTENSO TALVOLTA CON MACCHIE BRUNE E SPIGHE DI FIORI LUNGHE CIRCA 5-10 CM, DI UN APPARISCENTE AZZURRO-BLU, CHE SBOCCIANO IN ESTATE. LA FIORITURA È DURATURA E SI INOLTRA FINO ALL’AUTUNNO. LA VARIETÀ ‘ALBA’ MOSTRA UN’INFIORESCENZA BIANCA, INSOLITA E BELLISSIMA.",
                   Coltivazione = "Si tratta di una pianta da rizoma, vigorosa nella crescita, con la tendenza a formare dense colonie, da contenere nel tempo. Si coltiva in contenitori riempiti con terriccio mescolato a sabbia. Ama il sole, ma accetta anche la mezz’ombra. Non teme il freddo intenso, purché le radici affondino in acqua abbastanza profonda (in modo che non geli) o siano protette da pacciamatura.",
                   Malattie = "",
                },

                new PianteAcquatiche
                {
                   NomeComunePianta = "SAGITTARIA",
                   NomeFamiglia = "Alismatacee",
                   NomeScientificoPianta = "Sagittaria latifolia, S. sagittifolia",
                   FotoPianta = "ms-appx:///Immagini/Acquatiche/Sagittaria/SAGITTARIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Acquatiche/Abete-*.jpg",

                   DescrizioneBotanica = "COLTIVATA COME PIANTA ORNAMENTALE IN ACQUE POCO PROFONDE, A CORRENTE LENTA, LUNGO I MARGINI DEI LAGHETTI, QUESTA PERENNE DAI BEI FIORELLINI ESTIVI E DALLE FOGLIE SAGITTATE COMPRENDE UNA VENTINA DI SPECIE, DI CUI MOLTE RUSTICHE E DI FACILE COLTIVAZIONE. SAGITTARIA LATIFOLIA HA PICCOLI FIORI BIANCHI E PIATTI CON CUORE GIALLO E SI ACCONTENTA DI 10 CM D’ACQUA. S. SAGITTIFOLIA HA FIORI BIANCHI SOFFUSI DI ROSA, CON STAMI MARRONI O PISTILLI VERDI, E CHIEDE ALMENO 20 CM D’ACQUA.",
                   Coltivazione = "Sia Sagittaria latifolia che S. sagittifolia sono specie rustiche. Chiedono un terreno fertile, preferisono una posizione soleggiata ma tollerano l’ombra. I rizomi si piantano tra marzo e aprile a una profondità di 5-8 centimetri. I fusti alti devono essere sostenuti con tutori, soprattutto nelle aree esposte al vento. La sagittaria si diffonde rapidamente per mezzo dei rizomi stoloniferi sotterranei e può diventare invadente.",
                   Malattie = "",
                },

                new PianteAcquatiche
                {
                   NomeComunePianta = "TIFA",
                   NomeFamiglia = "Tifacee",
                   NomeScientificoPianta = "Typha palustris, T. latifolia, T. minima",
                   FotoPianta = "ms-appx:///Immagini/Acquatiche/Tifa/TIFA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Acquatiche/Abete-*.jpg",

                   DescrizioneBotanica = "LA TIFA, O CANNA, È UN’ERBACEA PERENNE MOLTO DECORATIVA PER IL LUNGO FUSTO ERETTO (ALTO FINO A 2,5 M) E PER LE SPIGHE CILINDRICHE SCURE E ROBUSTE, COTONOSE, CHE RIMANGONO INALTERATE PER TUTTO L’INVERNO. CREA RAPIDAMENTE DENSE COLONIE. LE FOGLIE SONO LINEARI DI UN BEL COLORE VERDE TENDENTE AL BLU. LA SPIGA COMPRENDE IN ALTO I FIORI MASCHILI (STRETTI E BIANCASTRI) E IN BASSO QUELLI VISTOSI FEMMINILI, UTILIZZATI ANCHE NELLE COMPOSIZIONI DI FIORI ESSICCATI.",
                   Coltivazione = "Questa pianta, che cresce da rizoma, prospera nei luoghi paludosi e lungo i corsi d’acqua. Come tutte le canne, ha la tendenza a diventare invadente: si può contenere chiudendo la zolla in un contenitore di plastica, in cui l’acqua entri dall’alto. È utilizzata negli impianti di fitodepurazione per la sua straordinaria resistenza ai fattori inquinanti. Le sue radici contrastano l’erosione e la pianta offre riparo a insetti, uccellini e anfibi.",
                   Malattie = "",
                },

                new PianteAcquatiche
                {
                   NomeComunePianta = "VICTORIA AMAZONICA",
                   NomeFamiglia = "Ninfeacee",
                   NomeScientificoPianta = "Victoria amazonica",
                   FotoPianta = "ms-appx:///Immagini/Acquatiche/Victoria Amazonica/VICTORIA AMAZONICA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Acquatiche/Abete-*.jpg",

                   DescrizioneBotanica = "È CONOSCIUTA PER LE SUE ENORMI FOGLIE CIRCOLARI, DAL BORDO RIVOLTO ALL’INSÙ, CHE POSSONO RAGGIUNGERE IL DIAMETRO DI 2 M E, QUANDO SI FORMANO, CRESCONO DI MEZZO METRO QUADRATO AL GIORNO. LISCE SULLA SUPERFICIE SUPERIORE, PRESENTANO SU QUELLA INFERIORE SPESSE NERVATURE E SPINE CHE LE DIFENDONO DAI PESCI. L’ARIA INTRAPPOLATA TRA LE NERVATURE PERMETTE IL GALLEGGIAMENTO. SONO TANTO FORTI DA POTER SOPPORTARE SENZA PROBLEMI IL PESO DI UN BAMBINO.",
                   Coltivazione = "Originaria delle regioni amazzoniche, dove colonizza fiumi caldi e lenti, ha bisogno di acqua ferma, con una temperatura di circa 27 °C. La sua introduzione va valutata con cura in relazione alle dimensioni del laghetto: in una stagione, la pianta può produrre da 40 a 50 foglie, capaci di ricoprire la superficie, togliendo luce alle altre piante. I fiori sono notturni, intensamente profumati, di 30 cm di diametro e virano dal bianco al viola. ",
                   Malattie = "",
                },

                

            };

            return data;
        }

        // TODO WTS: Remove this once your MasterDetail pages are displaying real data
        public static async Task<IEnumerable<PianteAcquatiche>> GetSampleModelDataAsync()
        {
            await Task.CompletedTask;

            return AllPianteAcquatiche();
        }

        
    }
}
