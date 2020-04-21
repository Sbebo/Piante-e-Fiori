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
//37 PIANTE ESOTICHE
    public class PianteEsotiche
    {
        public string NomeComunePianta { get; set; }
        public string NomeFamiglia { get; set; }
        public string NomeScientificoPianta { get; set; }
        public string FotoPianta { get; set; }
        public string SourceGalleryFotografica { get; set; }

        public string DescrizioneBotanica { get; set; }
        public string Coltivazione { get; set; }
	    public string Propagazione { get; set; }
        public string Malattie { get; set; }
        public string AltreCaratteristiche { get; set; }


    }

    public static class PianteEsoticheDataService
    {
        private static IEnumerable<PianteEsotiche> AllPianteEsotiche()
        {
            // The following is order summary data
            var data = new ObservableCollection<PianteEsotiche>
            {
               
                new PianteEsotiche
                {
                   NomeComunePianta = "ABUTILON",
                   NomeFamiglia = "Malvacee",
                   NomeScientificoPianta = "Abutilon megapotamicum",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Abutilon/ABUTILON.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "ARBUSTO SEMIRUSTICO ALTO FINO A 2,5 M, CON FOGLIE OVATE, DENTATE E APPUNTITE (DA CUI IL NOME COMUNE DI ACERO DA FIORE). NE ESISTE ANCHE UNA VARIETÀ A FOGLIE VARIEGATE. DA MAGGIO A OTTOBRE PRODUCE NUMEROSISSIMI FIORI PENDULI LUNGHI 3-4 CM COSTITUITI DA UN CALICE ROSSO, DAL QUALE FUORIESCONO I PETALI COLOR GIALLO LIMONE, DA CUI SBUCANO POI GLI STAMI ROSSI. ESISTONO NUMEROSE ALTRE SPECIE E VARIETÀ CON FIORI BIANCHI, GIALLI, ARANCIO O ROSA.",
                   Coltivazione = " Si tratta di piante da coltivare in piena terra solo nel Sud, mentre al Nord è meglio il vaso (grande, almeno 30 cm di diametro) o una posizione veramente molto riparata e soleggiata. Al Sud è meglio una collocazione a mezz’ombra, con irrigazioni regolari in estate, su terra ben asciutta (di natura leggera, fertile e molto ben drenata). Vanno concimate da maggio a settembre con un prodotto per piante a fiore.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "ANIGOZANTHOS",
                   NomeFamiglia = "Emodoracee",
                   NomeScientificoPianta = "Anigozanthos",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Anigozanthos/ANIGOZANTHOS.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "PERENNE RIZOMATOSA DI ORIGINE AUSTRALIANA, FORMA AMPI CESPI DI FOGLIE COLOR VERDE VERDE-GRIGIO, NASTRIFORMI E ARCUATE. IN PRIMAVERA-ESTATE PRODUCE SOTTILI FUSTI SCURI, RAMIFICATI E PELOSI, ALTI FINO A 100-150 CM, AL CUI APICE SI APRONO I FIORI, TUBOLARI E ALLUNGATI, COPERTI DA FITTA PELURIA PORPORA, ROSSA, ARANCIO, GIALLA O VERDE, CHE RACCHIUDE PICCOLE COROLLE CHIARE. LA FORMA DEI FIORI RICORDA LE ZAMPE DEL CANGURO (IL NOME COMUNE DELLA PIANTA).",
                   Coltivazione = "Non resiste al freddo: risultano pericolose temperature di 0 °C. Si coltiva, quindi, in piena terra solo nel Sud, in vaso (anche come pianta d’appartamento) nel Nord, ricoverando la pianta sul pianerottolo d’inverno. Con la cattiva stagione può perdere la parte aerea. Assai poco esigente: bastano un substrato leggero e molto ben drenato, annaffiature all’occorrenza in estate, poco concime organico in primavera.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "ARISTOLOCHIA",
                   NomeFamiglia = "Aristolochiacee",
                   NomeScientificoPianta = "Aristolochia macrophylla",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Aristolochia/ARISTOLOCHIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "ROBUSTO RAMPICANTE PERENNE, DOTATO DI GRANDI FOGLIE, LARGHE FINO A 30 CM, DI COLORE VERDE SCURO BLUASTRO. GLI ENORMI FIORI (STESSE DIMENSIONI DELLE FOGLIE) HANNO FORMA A PIPA, PORPORA SCURO ALL’INTERNO E VERDE GIALLASTRO ALL’ESTERNO. EMANANO UN PARTICOLARE ODORE CHE ATTIRA GLI INSETTI IMPOLLINATORI “INTRAPPOLANDOLI” FINCHÉ NON HANNO COMPIUTO “IL LORO DOVERE” DI FECONDATORI. SI ALLUNGA FINO A 5-6 M SU TRALICCI E PERGOLE, COPRENDOLI DEL TUTTO.",
                   Coltivazione = "Teme temperature inferiori a +7 °C: anche al Sud, se coltivato in piena terra, desidera una posizione ben riparata dai venti freddi e possibilmente soleggiata d’inverno (ma a mezz’ombra d’estate). Al Nord si alleva come annuale, oppure in vaso (minimo 40 cm di lato), anche al sole. Vuole un substrato leggero e fertile, non acido, ben drenato, da mantenere sempre umido e molto concimato in estate.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "ASARINA",
                   NomeFamiglia = "Scrofulariacee",
                   NomeScientificoPianta = "Asarina scandens",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Asarina/ASARINA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "RAMPICANTE ERBACEA PERENNE (ORIGINARIA DEL CENTRO AMERICA) CHE PRODUCE LUNGHI (FINO A 3 M DI LUNGHEZZA) FUSTI SOTTILI, VOLUBILI, COPERTI DA PICCOLE FOGLIE TRILOBATE O CUORIFORMI, APPUNTITE, COLOR VERDE CHIARO. DA MAGGIO A OTTOBRE SI RIEMPIE DI NUMEROSI FIORI A TROMBETTA, ROSA O VIOLA CON GOLA CHIARA. DATO IL PORTAMENTO RICADENTE O RAMPICANTE, SI PUÒ COLTIVARE IN BASKET O INDIRIZZANDONE I FUSTI SU GRATICCI, ARCHI E PICCOLE RINGHIERE.",
                   Coltivazione = "Si coltiva in piena terra in Meridione, in vaso oppure come annuale al Nord (fra l’altro, si autorisemina facilmente), perché non sopporta temperature inferiori a +3 °C; con l’arrivo del freddo, comunque, la pianta perde la parte aerea. Necessita di una terra soffice, fertile, molto drenata. Si annaffia in abbondanza in estate, lasciando asciugare il substrato; nel contempo si concima ogni 15 giorni con un prodotto liquido.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "BAMBÙ",
                   NomeFamiglia = "Graminacee",
                   NomeScientificoPianta = "Phyllostachys, Sasa, Bambusa, Fargesia",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Bambu/BAMBU.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "PHYLLOSTACHYS NIGRA RESISTE BENE AL FREDDO DELLA VAL PADANA; HA FUSTI NERI, MENTRE P. VIRIDIS LI HA VERDI (E GIALLI NELLA VARIETÀ SULPHUREA): TUTTI RAGGIUNGONO I 30 M D’ALTEZZA. SASA PALMATA TOCCA I 3 M D’ALTEZZA E LA PIANTA ADULTA RECA FUSTI NERI. BAMBUSA PREDILIGE CLIMI TEMPERATI E SI ELEVA A 20 M D’ALTEZZA. FARGESIA SI FERMA A 5 M D’ALTEZZA, RESISTE AL GELO, MA NON AL SOLE DIRETTO. PLEIOBLASTUS SI PUÒ ALLEVARE ANCHE IN VASO O SU SCARPATE DA CONSOLIDARE.",
                   Coltivazione = "Si tratta di perenni rizomatose molto robuste, caratterizzate da grande capacità pollonifera, anche a grandi distanze dal punto d’impianto: in piena terra è consigliabile isolare le radici con lastre di metallo, vetroresina o cemento. Desiderano esposizioni al sole o mezz’ombra, suoli umidi ma ben drenati, annaffiature frequenti, riparo dei venti che rovinano le foglie. Il fogliame caduto va mantenuto come pacciame.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "BANKSIA",
                   NomeFamiglia = "Proteacee",
                   NomeScientificoPianta = "Banksia ericifolia",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Banksia/BANKSIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "ARBUSTO AUSTRALIANO, VIGOROSO E RUSTICO, A CRESCITA RAPIDA (MASSIMO 4 M D’ALTEZZA). HA FOGLIE “AGHIFORMI”, PICCOLE, SEMPREVERDI, DI COLORE VERDE GRIGIASTRO CON UNA SOTTILE PELURIA. DA MAGGIO AD AGOSTO PRODUCE GRANDI INFIORESCENZE A FORMA DI PANNOCCHIA, ALTE FINO A 30 CM, DI COLORE GIALLO O ARANCIONE, A CUI SEGUONO POI I FRUTTI, UNA SORTA DI PIGNE DURE, DI COLORE VERDE. UTILIZZABILE COME ESEMPLARE SINGOLO, IN BORDURA O ANCHE PER SIEPI.",
                   Coltivazione = "Non teme il freddo della Val Padana (ma deve essere riparato dai venti freddi ed esposto in pieno sole), né il caldo torrido del Meridione. Può essere coltivato anche in vaso (dai 30 cm di lato in su). Desidera un terreno acido, asciutto e ben drenato. Si annaffia all’occorrenza in estate, dopo che il substrato si è ben asciugato (anche in vaso). Si concima una volta al mese, con un prodotto per acidoﬁ le da fiore.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "BAUHINIA",
                   NomeFamiglia = "Leguminose",
                   NomeScientificoPianta = "Bauhinia grandiflora",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Bauhinia/BAUHINIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "CHIAMATA ANCHE ALBERO DELLE ORCHIDEE PER LA FORMA DEI FIORI, CHE RICORDA VAGAMENTE QUELLI DELLE ORCHIDEACEE. È UN ARBUSTO PERENNE CON FUSTO SEMILEGNOSO, COPERTO DA BELLE FOGLIE BILOBATE, SIMILI A FARFALLE. DA GIUGNO AD AGOSTO PRODUCE MOLTI FIORI PIUTTOSTO GRANDI, DI COLORE BIANCO, GIALLO, ROSA O ROSSO, IN GRAPPOLI DI 5-6 COROLLE. IN AUTUNNO NE DERIVANO LUNGHE CAPSULE LEGNOSE PIENE DI SEMI. PUÒ RAGGIUNGERE I 4 M D’ALTEZZA, IN POSIZIONE FAVOREVOLE.",
                   Coltivazione = "Resiste fino a +8 °C, quindi al Sud si può coltivare in piena terra solo in posizione molto riparata e soleggiata, mentre al Nord va allevata solo in vaso (minimo 40 cm di lato) da ricoverare in inverno. Desidera un substrato ben drenato e fertile, alcune annaffiature in estate (dopo che la terra si è ben asciugata) con concime liquido per piante da fiore, ogni 15 giorni. Va potata ogni inverno per contenerla.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "BRAHEA",
                   NomeFamiglia = "Arecacee",
                   NomeScientificoPianta = "Brahea armata",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Brahea/BRAHEA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "PALMA RUSTICA E SEMPREVERDE DALLA CRESCITA LENTA (ALTA NON PIÙ DI 15 M) E DAL ROBUSTO FUSTO ERETTO (MASSIMO 50 CM DI DIAMETRO). HA CHIOMA TONDEGGIANTE, SOTTO LA QUALE RIMANGONO A LUNGO LE FRONDE SECCHE PRIMA DI STACCARSI; LE FRONDE, GRANDI E RIGIDE, VERDE BLUASTRO PRUINOSO, SONO PORTATE DA UN LUNGO PICCIOLO CARNOSO E RIGIDO, CON NUMEROSE SPINE ACUMINATE. IN PRIMAVERA PRODUCE LUNGHE INFIORESCENZE ARCUATE, DATE DA NUMEROSI PICCOLI FIORI BIANCHI",
                   Coltivazione = "Resiste fino a –10 °C, a condizione che il terreno sia asciutto o comunque con un drenaggio perfetto: tollera infatti mesi di siccità, ma non il ristagno idrico. Il substrato deve essere anche leggero, non necessariamente fertile. Non abbisogna di concimazione, né di potature o pulizia del tronco: le grandi foglie secche cadono spontaneamente (basta saper aspettare), lasciando una cicatrice pulita sul fusto.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "BUTIA",
                   NomeFamiglia = "Betulacee",
                   NomeScientificoPianta = "Butia capitata",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Butia/BUTIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "PALMA SEMPREVERDE DALLA CRESCITA LENTA, ALTA FINO A 6 M, DAL TRONCO CORTO E ALLARGATO, CULMINANTE CON UNA CHIOMA ARROTONDATA, FORMATA DA LUNGHE (FINO A 2 M) FRONDE ARCUATE DI COLORE VERDE BLUASTRO. IN PRIMAVERA SI SVILUPPANO TRA LE FRONDE GRANDI PANNOCCHIE DI PICCOLI FIORI COLOR CREMA O TENDENTI AL PORPORA, DAL PROFUMO FRUTTATO. SEGUONO MOLTISSIMI FRUTTI RICCHI DI UNA POLPA SUCCOSA, MA FIBROSA E CON UN NOCCIOLO DURISSIMO.",
                   Coltivazione = "Può resistere fino a 0 °C, purché collocata in posizione riparata, in pieno sole e in suolo molto drenato. Al Nord può essere coltivata in vaso (minimo 50 cm di lato). Cresce bene su terreni fertili, anche a mezz’ombra nelle zone più calde. Una volta ambientata non necessita di molta acqua, né di concime. Vanno eliminate le vecchie fronde rimaste attaccate al tronco, ma solo dopo che si sono completamente disseccate.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "CALLIANDRA",
                   NomeFamiglia = "Leguminose",
                   NomeScientificoPianta = "Calliandra eriophylla",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Calliandra/CALLIANDRA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "PICCOLO (MASSIMO 75 CM D’ALTEZZA) ARBUSTO SEMPREVERDE DALLA FORMA AGGRAZIATA E ARROTONDATA. PRESENTA FOGLIE COMPOSTE DA NUMEROSE FOGLIOLINE MOLTO PICCOLE E OVATE. TRA APRILE E SETTEMBRE SBOCCIANO ININTERROTTAMENTE I FIORI, SIMILI A CURIOSI E SOFFICI PIUMINI DA CIPRIA DI COLORE ROSSO SCARLATTO, DEL DIAMETRO DI 4-5 CENTIMETRI. C. SURINAMENSIS PRODUCE INVECE FIORI VIOLA CON LA BASE BIANCA. C. HAEMATOCEPHALA È UN ALBERELLO DI 3 M D’ALTEZZA.",
                   Coltivazione = "Teme il freddo (le temperature sotto i 3 °C risultano già nocive): in Meridione va posta in posizione riparata e soleggiata, nel Nord va coltivata in vaso da proteggere in inverno. Desidera sempre la piena esposizione al sole. Necessita di un substrato fertile e ben drenato. Va annaffiata solo quando il terriccio si è ben asciugato. Ogni 15 giorni da marzo va concimata con un prodotto per piante da fiore.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "CASSIA (O SENNA)",
                   NomeFamiglia = "Leguminose",
                   NomeScientificoPianta = "Cassia corymbosa (o Senna c.)",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Cassia/CASSIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "ERBACEA PERENNE DAL PORTAMENTO A CESPUGLIO, PUÒ RAGGIUNGERE I 2,5 M D’ALTEZZA. HA UNA CHIOMA TONDEGGIANTE, COSTITUITA DA GRANDI FOGLIE COMPOSTE DA NUMEROSISSIME FOGLIOLINE OVALI. È SEMISEMPREVERDE (PERDE IL FOGLIAME ALL’AVVENTO DELLE BASSE TEMPERATURE). DA MAGGIO AD AGOSTO PRODUCE NUMEROSE PANNOCCHIE DI VISTOSI FIORI DI COLORE GIALLO INTENSO. SI PUÒ COLTIVARE COME PUNTO FOCALE IN UN’AIUOLA O IN GRANDI MACCHIE DI COLORE.",
                   Coltivazione = "Resiste al freddo fino a +5 °C, liberandosi del fogliame. In piena terra, al Sud, va posta in luogo riparato dai venti freddi e soleggiato durante l’inverno. Al Nord può essere coltivata solo in vaso, da ricoverare in serra calda d’inverno. Desidera un terreno leggero e ben drenato. Va annaffiata durante l’estate se non piove a sufficienza, dopo che la terra si è asciugata. Non abbisogna di concime, come tutte le leguminose.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "CESALPINIA",
                   NomeFamiglia = "Leguminose",
                   NomeScientificoPianta = "Caesalpinia gillesii",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Cesalpinia/CESALPINIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "PICCOLO (MASSIMO 4 M D’ALTEZZA) ARBUSTO PERENNE DAL PORTAMENTO LEGGERO E APERTO, CHE TENDE PROGRESSIVAMENTE A SPOGLIARSI IN BASSO, CON NUMEROSI RAMI ARCUATI SU CUI SI SVILUPPANO LE FOGLIE COMPOSTE DA MOLTEPLICI FOGLIOLINE OVALI (CADUCHE IN INVERNO). TRA MAGGIO E LUGLIO SI FORMANO I VISTOSI FIORI, PORTATI IN RACEMI LUNGHI FINO A 20 CM, DOTATI DI 5 PETALI GIALLI CON 10 STAMI DI COLOR ROSSO SCARLATTO, MOLTO LUNGHI E SPORGENTI. ADATTA COME PICCOLO PUNTO FOCALE.",
                   Coltivazione = "Sopporta il freddo della Val Padana se collocata in posizione riparata dai venti freddi e soleggiata anche durante l’inverno. Al Sud invece resiste senza problemi in piena terra, meglio se non esposta alle correnti. Desidera un substrato fertile e sciolto, sempre molto drenato. Si annaffia in estate quando il terriccio si è asciugato. Va concimata da marzo a settembre, con un prodotto per piante da fiore.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "CESTRUM",
                   NomeFamiglia = "Solanacee",
                   NomeScientificoPianta = "Cestrum nocturnum",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Cestrum/CESTRUM.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "PICCOLO (ALTEZZA MASSIMA 4 M) ARBUSTO SEMPREVERDE, CON LUNGHI FUSTI ERETTI A FORMARE AMPI CESPI E NUMEROSE FOGLIOLINE OVALI, LUCIDE, APPUNTITE, ALTERNE, DI COLORE VERDE BRILLANTE. DA GIUGNO A SETTEMBRE ALL’APICE DEI FUSTI SBOCCIANO, DI NOTTE, GROSSE INFIORESCENZE TONDEGGIANTI, COSTITUITE DA NUMEROSI FIORI TUBOLARI ALLUNGATI, DI COLORE GIALLO-VERDASTRO, INTENSAMENTE PROFUMATI. DA PORRE NELLA ZONA OVE SI SOGGIORNA NELLE SERATE ESTIVE.",
                   Coltivazione = "In piena terra può essere coltivato solo nelle zone costiere del Sud, sempre in posizione riparata dai venti freddi; al Nord vive solo in vaso (diametro minimo 50 cm) da riparare in serra calda d’inverno. Vuole il pieno sole, un susbtrato leggero, fertile e ben drenato, annaffiature regolari per tutta l’estate (soprattutto in vaso), concimazioni costanti ogni 15 giorni. I fiori appassiti vanno tagliati con costanza.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "CHAMAEROPS",
                   NomeFamiglia = "Palme",
                   NomeScientificoPianta = "Chamaerops humilis",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Chamaerops/CHAMAEROPS.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "UNICA PALMA ORIGINARIA DELL’ITALIA, CHIAMATA ANCHE PALMA DI SAN PIETRO, HA CRESCITA MOLTO LENTA E RIMANE BASSA (MASSIMO 2 M D’ALTEZZA). IL FUSTO, CORTO E SQUAMOSO, È IN GENERE SINGOLO (RARAMENTE SI FORMANO ALTRI FUSTI DALLO STESSO PIEDE). LA CHIOMA È DATA DA FRONDE ARCUATE, LUNGHE FINO A 1,5 M, DI COLORE VERDE INTENSO, PORTATE DA UN PICCIOLO LUNGO E SPINOSO. LE INFIORESCENZE A PANNOCCHIA SI FORMANO ALLA BASE DELLE FOGLIE; SEGUONO FRUTTI ROSSI O GIALLI.",
                   Coltivazione = "Tollera fino a +3 °C, ma sopporta i venti freddi. Nel Nord è coltivabile solo in vaso, da avvolgere con protezioni in inverno. Ama il pieno sole, al massimo la mezz’ombra. Desidera un substrato fertile e sciolto, leggero e soprattutto molto drenato. Necessita di annaffiature solo nel primo anno dopo l’impianto, quando la terra è ben asciutta. Nei primi anni si giova di fertilizzanti organici distribuiti in autunno.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "CHOISYA",
                   NomeFamiglia = "Rutacee",
                   NomeScientificoPianta = "Choisya ternata",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Choisya/CHOISYA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "CHIAMATA ANCHE ARANCIO DEL MESSICO, È UN ARBUSTO DI PICCOLA TAGLIA (ALTEZZA MASSIMA 3 M), A PORTAMENTO COMPATTO E TONDEGGIANTE. IL FOGLIAME, SEMPREVERDE, È FORMATO DA FOGLIE DIVISE IN TRE FOGLIOLINE LUCIDE, VERDE INTENSO E PROFUMATE. IN APRILE (E SPESSO ANCHE IN SETTEMBRE) ALL’ASCELLA DEI RAMI SBOCCIANO I FIORI, PIUTTOSTO GRANDI, BIANCHI E PROFUMATISSIMI (SIMILI A QUELLI DELL’ARANCIO). DA POSIZIONARE PRESSO IL GAZEBO O LA ZONA RELAX.",
                   Coltivazione = "Tollera temperature fino a 5 °C, se collocato in posizione soleggiata e riparata dai venti invernali. Nel Nord Italia è bene coltivarla in vaso, da ricoverare sul pianerottolo d’inverno. Preferisce il pieno sole, ma sopporta la mezz’ombra. Vuole un terreno leggero, ben drenato, leggermente acido. Va annaffiata in estate, se non piove, e concimata ogni 15 giorni con un prodotto per piante da fiore. Va potata per dare aria all’interno.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "CLIANTHUS",
                   NomeFamiglia = "Leguminose",
                   NomeScientificoPianta = "Clianthus puniceus",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Clianthus/CLIANTHUS.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "CHIAMATO ANCHE BECCO DI PAPPAGALLO, È UN ARBUSTO SEMPREVERDE (SPOGLIANTE IN CLIMI FREDDI) RAMPICANTE, CON TRALCI LUNGHI FINO A 4 M, MUNITI DI VITICCI. LE FOGLIE SONO PENNATE, DATE DA FOGLIOLINE OVALI, DI COLORE VERDE BRILLANTE. DA GIUGNO A OTTOBRE PRODUCE FIORI DI COLORE SCARLATTO, RIUNITI IN RACEMI ALL’ASCELLA FOGLIARE, A CUI SEGUONO I FRUTTI, LUNGHI BACCELLI CON SEMI A FORMA DI FAGIOLO. IDEALE PER COPRIRE UN MURO, UNA RECINZIONE O UN GRATICCIO.",
                   Coltivazione = "Resiste al freddo fino a –5 °C se è collocata in un punto ben riparato dal vento (che rovina anche il delicato fogliame) e molto soleggiato. Al Nord va coltivata in vaso e ricoverata in serra fredda. Vuole un suolo soffice e fertile, ben drenato. Teme la siccità e va quindi innaffiata regolarmente in estate, appena il terriccio tende ad asciugarsi. Si concima da marzo a settembre, con un prodotto per piante da fiore.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "CUPHEA",
                   NomeFamiglia = "Litracee",
                   NomeScientificoPianta = "Cuphea hyssopifolia",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Cuphea/CUPHEA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "ERBACEA PERENNE, SEMPREVERDE, FORMA UN CESPUGLIO DELL’ALTEZZA MASSIMA DI 90 CENTIMETRI. HA FOGLIE LINEARI, LANCEOLATE, DI COLORE VERDE SCURO; POSSONO CADERE IN INVERNO SE LA TEMPERATURA È TROPPO BASSA. IN GIUGNO E FINO AD AGOSTO PRODUCE FIORI TUBULARI, DI COLORE BIANCO, ROSA O LILLA A SECONDA DELLA VARIETÀ FLORICOLA. È ADATTA A FORMARE BORDURE NELLE AIUOLE O NEI VIALETTI DI PASSAGGIO, OPPURE COME FULCRO NELLE AIUOLE STESSE.",
                   Coltivazione = " Resiste fino a +5 °C, va quindi coltivata in piena terra solo nel Sud, in posizione riparata dai venti freddi e molto soleggiata in inverno; al Nord va allevata in vaso, da proteggere sul pianerottolo, oppure come annuale. Necessita di un terreno fertile e leggero, ben drenato. Va annaffiata con regolarità durante il periodo estivo; altrettanto va concimata con un prodotto liquido. I rami vanno potati di un terzo dopo la fioritura.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "CYCAS",
                   NomeFamiglia = "Cicadacee",
                   NomeScientificoPianta = "Cycas revoluta",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Cycas/CYCAS.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTA PERENNE DI ORIGINE ANTICHISSIMA, COSTITUITA DA UN FUSTO CORTO, LEGNOSO, COPERTO DA SCAGLIE BRUNE, AL CUI APICE SI DIPARTE UNA LARGA CORONA DI LUNGHE FOGLIE PENNATE, RIGIDE, DI COLOR VERDE SCURO, PERENNI. È UNA SPECIE DIOICA (HA ESEMPLARI SOLO MASCHILI O FEMMINILI) CHE FORMA DUE TIPI DIVERSI DI INFIORESCENZE; DALLA FEMMINA NASCONO GLI OVOLI, I SEMI DI UNA NUOVA PIANTA. HA CRESCITA MOLTO LENTA (MA È LONGEVA) E RAGGIUNGE UN’ALTEZZA MASSIMA DI 3 METRI.",
                   Coltivazione = " Resiste solo fino a +5 °C, quindi si coltiva in piena terra solo nel Sud, riparandola dai venti freddi, mentre nel Nord è pianta da vaso (da ricoverare in serra fredda o sul pianerottolo). Vuole un’esposizione al sole o mezz’ombra, un terriccio sciolto e molto ben drenato, annaffiature moderate in estate (ma solo con substrato ben asciutto), concimazioni mensili con un prodotto a base di azoto.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "ERYTHRINA",
                   NomeFamiglia = "Leguminose",
                   NomeScientificoPianta = "Erythrina crista-galli",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Erythrina/ERYTHRINA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "ARBUSTO ERETTO SEMIRAMPICANTE CHE PRODUCE LUNGHI FUSTI (FINO A 4 M), MUNITI DI SPINE, MOLTO RAMIFICATI, INDIRIZZABILI SU GRIGLIATI. LE FOGLIE, SEMPREVERDI (MA CADUCHE CON IL FREDDO), SONO LANCEOLATE, COLOR VERDE INTENSO. DA GIUGNO AD AGOSTO PRODUCE VISTOSI GRAPPOLI DI FIORI COLOR ROSSO SCARLATTO DA CUI DERIVANO POI LUNGHI BACCELLI NERASTRI. UTILIZZABILE COME PUNTO FOCALE ADDOSSATO A UN MURO, A UN TRALICCIO O ALLA STRUTTURA DI UN GAZEBO.",
                   Coltivazione = "Sopporta fino a +3 °C, a patto di essere in posizione soleggiata d’inverno e riparata dai venti freddi. Nel Nord va coltivata in vaso (almeno 50 cm di diametro) e spostata in serra fredda in ottobre. Desidera terreni freschi e fertili, ben drenati. Va annaffiata con regolarità in estate, su terriccio asciutto. La concimazione si effettua da aprile a settembre con prodotti per piante da fiore o a lenta cessione.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "EUGENIA",
                   NomeFamiglia = "Mirtacee",
                   NomeScientificoPianta = "Eugenia myrtifolia",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Eugenia/EUGENIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTA ARBUSTIVA SEMPREVERDE CHE PUÒ RAGGIUNGERE I 4,5 M D’ALTEZZA. BEN ACCESTITA E RAMIFICATA, DALLA CHIOMA FOLTA, È DOTATA DI FOGLIE LANCEOLATE, CORIACEE, ROBUSTE, COLOR VERDE SCURO, SIMILI A QUELLE DEL MEDITERRANEO MIRTO. I FIORI, RIUNITI IN PANNOCCHIE ALL’APICE DEI RAMI, SONO PICCOLI MA GRAZIOSI PER L’INTENSO COLORE VIOLA DEI BOCCIOLI E PER I NUMEROSI STAMI BIANCHI; COMPAIONO TRA GIUGNO E LUGLIO. I PICCOLI FRUTTI VIOLACEI HANNO POLPA ACIDULA COMMESTIBILE.",
                   Coltivazione = "È abbastanza rustica: resiste fino a –5 °C in posizione soleggiata e protetta dai venti freddi; in alternativa si può coltivare in vaso grande (minimo 40 cm di lato). Desidera un substrato fertile, leggero, ben drenato. In estate può abbisognare di irrigazioni di soccorso, su terra ben asciutta. Si concima in autunno e primavera, con un prodotto organico o a lenta cessione. Sopporta bene le potature (è adatta anche a formare siepi).",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "IOCHROMA",
                   NomeFamiglia = "Solanacee",
                   NomeScientificoPianta = "Iochroma cyaneus",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Iochroma/IOCHROMA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "ARBUSTO CADUCIFOGLIO, ALTO FINO A 3 M, CON FUSTI LEGNOSI E RAMIFICATI. HA FOGLIE GRANDI, CORIACEE, COPERTE DI PELURIA, DI COLORE VERDE SCURO. DA MAGGIO A OTTOBRE PRODUCE GRANDI INFIORESCENZE A OMBRELLO, RIVOLTE VERSO IL BASSO, DATE DA LUNGHI FIORI TUBOLARI, DI COLORE VIOLA SCURO (ROSSO, GIALLO, BIANCO O ROSA NELLE VARIETÀ). LA FIORITURA SI PROLUNGA PER QUASI TUTTO L’ANNO (E LE FOGLIE PERMANGONO) NEI CLIMI PIÙ MITI. ADATTA COME PUNTO FOCALE IN GIARDINO.",
                   Coltivazione = "Tollera temperature fino a 0 °C: è coltivabile in piena terra nel Sud, in vaso (diametro 40 cm) da riparare in serra fredda nel Nord. Desidera un posto al sole o a mezz’ombra. Ama terreni freschi, soffici, profondi e molto ben drenati. In estate va annaffiata all’occorrenza, su terra ben asciutta, e va concimata da marzo a ottobre. Si devono eliminare i polloni basali. In inverno i rami vanno potati di un terzo.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "JACARANDA",
                   NomeFamiglia = "Bignoniacee",
                   NomeScientificoPianta = "Jacaranda mimosifolia",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Jacaranda/JACARANDA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "ALBERO ALTO FINO A 12 M, DAL PORTAMENTO ERETTO E DALLA CHIOMA DENSA E ARROTONDATA (DIAMETRO UGUALE ALL’ALTEZZA). LE FOGLIE SONO BIPINNATE, SIMILI A QUELLE DELLA MIMOSA, DI COLORE VERDE BRILLANTE. IN APRILE-MAGGIO PRODUCE GRAPPOLI APICALI FORMATI DA FIORI A TROMBONE, GRANDI, DI COLORE BLU-VIOLA. NE DERIVANO LUNGHI BACCELLI CUOIOSI CHE CONTENGONO NUMEROSI SEMI SCURI. PER IL COLORE DEI FIORI VIENE ANCHE CHIAMATO ALBERO DEL GLICINE.",
                   Coltivazione = "Tollera temperature fino a 0 °C; nel Nord Italia va coltivata in vaso (minimo 50 cm di lato), da proteggere con coperture invernali, finché le dimensioni lo consentono. Vuole posizioni soleggiate, terreno sciolto, fertile e molto ben drenato, annaffiature estive regolari solo per gli esemplari giovani, concimazioni autunnali e primaverili. Resiste al vento (anche freddo) e alle potature (necessarie sui getti rovinati dal gelo).",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "MANDEVILLEA",
                   NomeFamiglia = "Apocinacee",
                   NomeScientificoPianta = "Mandevilla splendens, M. laxa",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Mandevillea/MANDEVILLEA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "SEMPREVERDE RAMPICANTE, DAI FUSTI SOTTILI E CARNOSI A CRESCITA RAPIDA, DA INDIRIZZARE SU TRALICCI, GRIGLIATI, GAZEBO, PERGOLE. LE FOGLIE SONO GRANDI, OVALI, SCURE, LUCIDE, CORIACEE, CON NERVATURE EVIDENTI SUPERIORMENTE. DA APRILE A OTTOBRE PRODUCE GRANDI FIORI A TROMBA, RIUNITI IN RACEMI, DELICATAMENTE PROFUMATI, ROSSI, ROSA O BIANCHI, CON GOLA GIALLO LIMONE. TUTTE LE PARTI DELLA PIANTA, SE TAGLIATE, EMETTONO UN LATTICE BIANCO CHE PUÒ DARE LUOGO A IRRITAZIONI.",
                   Coltivazione = "Resiste solo fino a +8 °C: nel Sud, se coltivata in terra, necessita di una protezione con teli di non tessuto; nel Nord va allevata in vaso da ricoverare in serra calda d’inverno. Con il freddo perde le foglie. Desidera posizioni soleggiate e terreno sciolto, fertile e ben drenato. Si annaffia in estate, all’occorrenza, dopo che il substrato si è asciugato. Va concimata da marzo a settembre, con un prodotto per piante da fiore.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "PANDOREA",
                   NomeFamiglia = "Bignoniacee",
                   NomeScientificoPianta = "Pandorea jasminoides",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Pandorea/PANDOREA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "RAMPICANTE SEMPREVERDE DALLA CRESCITA VIGOROSA E RAPIDA, RAGGIUNGE UNA LUNGHEZZA DI 5 M, CON FUSTI SOTTILI E RAMIFICATI, LIGNIFICATI ALLA BASE. LE FOGLIE SONO COMPOSTE COSTITUITE DA 5-7 FOGLIOLINE LANCEOLATE, SPESSE, DI COLORE VERDE SCURO. DA MAGGIO A SETTEMBRE PRODUCE NUMEROSI FIORI A TROMBETTA, DI COLORE ROSA CHIARO (BIANCHI IN VARIETÀ FLORICOLE) CON GOLA FUCSIA, DELICATAMENTE PROFUMATI. IDEALE PER RECINZIONI, PERGOLE, GRATICCI, GAZEBO.",
                   Coltivazione = "Resiste a 0 °C: al Sud va coltivata in posizione riparata dai venti; al Nord in vaso grande (minimo 50 cm di lato); l’esposizione deve sempre essere a sole pieno. In caso di gelate perde la parte aerea. Si adatta a qualunque tipo di terreno, purché perfettamente drenato. Necessita di annaffiature estive regolari, ma solo dopo che la terra si è asciugata. Va concimata da marzo a settembre con un prodotto per piante da fiore.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "PETREA",
                   NomeFamiglia = "Verbenacee",
                   NomeScientificoPianta = "Petraea volubilis",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Petrea/PETREA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTA RAMPICANTE SEMPREVERDE, DAI LUNGHI FUSTI VOLUBILI (FINO A 6 M DI LUNGHEZZA) CHE SI STRINGONO AI SUPPORTI (RECINZIONI, GRATICCI, PERGOLE, GAZEBO, ARCHI ECC.) SENZA BISOGNO DI AIUTO NELLA SALITA. PRESENTA GRANDI FOGLIE CORIACEE E RUGOSE, DI COLORE VERDE SCURO. DA MAGGIO AD AGOSTO PRODUCE SPETTACOLARI INFIORESCENZE PENDULE DI FIORI COLOR BLU INTENSO, CON 5 PETALI A FORMA DI STELLA E CENTRO VIOLA, GRANDI (6 CM DI DIAMETRO).",
                   Coltivazione = "Resiste fino a +5 °C, quindi in Meridione si può coltivare in piena terra in posizione riparata dai venti invernali e ben soleggiata in inverno, tenendo a portata di mano un telo protettivo; nel Nord va allevata in vaso (diametro minimo 40 cm), da spostare in serra calda o sul pianerottolo in novembre. Desidera una posizione soleggiata, un terreno fertile, profondo, umido ma ben drenato, annaffiature regolari per tutta l’estate.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "PHOENIX",
                   NomeFamiglia = "Palme",
                   NomeScientificoPianta = "Phoenix canariensis, P. dactylifera",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Phoenix/PHOENIX.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "GRANDI PALME, ALTE FINO A 20 M, PRESENTANO UN FUSTO, ALL’APICE DEL QUALE SI FORMA UNA CORONA DI FOGLIE LARGHE, PENNATE, ARCUATE E PENDENTI, CHE RAGGIUNGONO I 3 M DI LUNGHEZZA. IN MARZO-APRILE, NELLE TERRE D’ORIGINE (NORD AFRICA) PRODUCONO FIORI GIALLO-MARRONI IN INFIORESCENZE PENDENTI, LUNGHE FINO A 1 M. NE DERIVANO FRUTTI CARNOSI, SIMILI AI DATTERI (P. DACTYLIFERA FORMA INFATTI I DATTERI COMMESTIBILI, MA DIFFICILMENTE LI PRODUCE IN ITALIA).",
                   Coltivazione = "Da giovani non tollerano temperature inferiori a 8 °C, da adulte sopportano qualche giorno a 0 °C prima di riportare seri danni alla chioma. Nel Nord Italia si può coltivare P. canariensis, ma solo in punti molto riparati e soleggiati. Vogliono posizioni soleggiate, terra fertile e ben drenata, annaffiature regolari nei primi anni dopo l’impianto in estate, concimazioni con azoto sempre sulle piante giovani.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "PLUMERIA",
                   NomeFamiglia = "Apocinacee",
                   NomeScientificoPianta = "Plumeria acutifolia",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Plumeria/PLUMERIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "CHIAMATA ANCHE FRANGIPANI, È UN ARBUSTO DAI GROSSI RAMI CARNOSI, VERDI, ALL’APICE DEI QUALI SI DIPANANO LE FOGLIE, GRANDI, LANCEOLATE, APPUNTITE, DELICATE. I FIORI COMPAIONO ALL’APICE DEI RAMI, PRIMA DELLE FOGLIE: HANNO LA FORMA DI QUELLI DELL’OLEANDRO, MA SONO PIÙ GRANDI (5 CM DI DIAMETRO), BIANCHI, ROSA, GIALLI, ARANCIO O ROSSI, CON CENTRO DI COLORE DIVERSO DAL BORDO, DALL’ODORE MOLTO INTENSO. IL LATTICE CHE SGORGA DAI RAMI È VELENOSO.",
                   Coltivazione = "Soffre a temperature inferiori a 10 °C: in piena terra può essere coltivata solo nel Meridione costiero, in posizione riparata dai venti e soleggiata; altrove è bene allevarla in vaso, da ricoverare in serra calda in inverno. Desidera un terriccio fertile, leggero e molto ben drenato. Va annaffiata in estate quando il substrato si asciuga. Si concima da aprile a settembre, con un prodotto per piante da fiore.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "PROTEA",
                   NomeFamiglia = "Proteacee",
                   NomeScientificoPianta = "Protea cynaroides",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Protea/PROTEA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "ARBUSTI SEMPREVERDI DAI LUNGHI FUSTI ERETTI, POCO RAMIFICATI, RIGIDI, ALTI FINO A 1,5 METRI. LE FOGLIE SONO ALLUNGATE, OVALI O LANCEOLATE, DI COLORE VERDE SCURO, CEROSE. IN GIUGNO-AGOSTO EMETTONO LE INFIORESCENZE LARGHE 25 CM, DATE DA MOLTI PICCOLI FIORI RIUNITI AL CENTRO, CIRCONDATI DA LUNGHE BRATTEE COLORATE; ASSOMIGLIANO A GRANDI CARCIOFI O A PIGNE. I FIORI NON SONO NUMEROSI, MA DURANO PER SETTIMANE. LE BRATTEE SONO BIANCHE, ROSA, ROSSE, ARANCIONI.",
                   Coltivazione = "Tollera temperature fino a +5 °C: in Meridione deve alloggiare in posizione riparata e soleggiata, tenendo a portata di mano un telo protettivo; nel Nord va coltivata solo in vaso (almeno 50 cm di lato) e deve essere protetta in inverno. Necessita di terreni sciolti, profondi, molto ben drenati, anche aridi, sassosi e poveri. Si annaffia regolarmente in estate, dopo che il substrato si è asciugato. Gradisce concimazioni azotate in estate.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "SABAL",
                   NomeFamiglia = "Arecacee",
                   NomeScientificoPianta = "Sabal minor",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Sabal/SABAL.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "PALMA DI PICCOLE DIMENSIONI (FINO A 2,5 M DI ALTEZZA) DAL CORTO FUSTO TONDEGGIANTE, FORMATO DAI PEZZI DI PICCIOLI DELLE FOGLIE CADUTE. LE FRONDE SONO DI COLORE VERDE SULLA PAGINA SUPERIORE, VERDE BLUASTRO SU QUELLA INFERIORE, CON UN LUNGO (1 M) PICCIOLO, SPESSO E RIGIDO. IN PRIMAVERA PRODUCE PICCOLI FIORI BIANCHI O BRUNI, IN INFIORESCENZE ERETTE E RAMIFICATE, CHE SI DIPARTONO DAL FOGLIAME; AI FIORI SEGUONO NUMEROSI FRUTTI SCURI, OVALI.",
                   Coltivazione = "Può sopportare temperature fino a –10 °C ed è quindi coltivabile in piena terra anche nel Nord Italia, scegliendo posizioni riparate dal vento e soleggiate solo durante l’inverno (in estate preferisce una posizione a mezz’ombra o in ombra). Si può allevare anche in vaso, purché molto grande (diametro dai 50 cm in su). Vuole una terra fertile, soffice, ben drenata e annaffiature regolari durante l’estate.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "SESBANIA",
                   NomeFamiglia = "Leguminose",
                   NomeScientificoPianta = "Sesbania punicea",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Sesbania/SESBANIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "ARBUSTO SEMPREVERDE, ALTO FINO A 2,5 M E LARGO ALTRETTANTO, CON RAMI LUNGHI E ROBUSTI CHE SI DIPARTONO VERSO L’ALTO E POI VERSO L’ESTERNO, DAPPRIMA IN FORMA DISORDINATA E POI DANDO AL CESPUGLIO UNA FORMA ROTONDEGGIANTE. HA FOGLIE COMPOSTE DA FOGLIOLINE OVALI, LEGGERE E DELICATE. DA LUGLIO A SETTEMBRE PRODUCE VISTOSI FIORI DI COLORE ROSSO-ARANCIO BRILLANTE, PORTATI IN GRAPPOLI. SI PUÒ UTILIZZARE COME ESEMPLARE ISOLATO O IN GRUPPI.",
                   Coltivazione = "Tollera temperature fino a +5 °C, quindi va coltivata al Sud in luogo riparato e soleggiato, tenendo a portata di mano un telo protettivo in inverno; nel Nord si alleva in vaso (dai 40 cm di lato in su). Vuole una collocazione ben esposta al sole. Desidera una terra fertile, leggera, ben drenata ma umida: in estate va annaffiata regolarmente. Si concima con un prodotto per piante da fiore, da maggio ad agosto.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "SOLANDRA",
                   NomeFamiglia = "Solanacee",
                   NomeScientificoPianta = "Solandra maxima",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Solandra/SOLANDRA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "ARBUSTO SEMPREVERDE DALLO SVILUPPO RAPIDO E VIGOROSO (ARRIVA A 8 M D’ALTEZZA E DIAMETRO), PRESENTA GRANDI FOGLIE DALLE NERVATURE BEN VISIBILI, LEGGERMENTE VELLUTATE, MORBIDE. IN GIUGNO-AGOSTO PRODUCE GRANDI FIORI A CAMPANA, COLOR GIALLO ORO CON CENTRO NERO O VIOLA, DI DURATA LIMITATA MA CONTINUAMENTE RINNOVATI DI GIORNO IN GIORNO. COSTITUISCE UN INDUBBIO PUNTO D’ATTRAZIONE E MERITA UNO SPAZIO ADEGUATO E UNA COLLOCAZIONE CHE LA VALORIZZI.",
                   Coltivazione = "Teme il freddo: soffre già a +8 °C, quindi in Meridione va addossata a un muro soleggiato e che la ripari dai venti; al Nord va allevata in un grande vaso (minimo 40 cm di lato). Desidera il pieno sole, un substrato leggero ma molto fertile e ben drenato, e irrigazioni regolari durante tutta l’estate. La concimazione deve aiutare lo sviluppo: da marzo a settembre va eseguita ogni 10 giorni con un prodotto per piante da fiore.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "STEPHANOTIS",
                   NomeFamiglia = "Asclepiadacee",
                   NomeScientificoPianta = "Stephanotis floribunda",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Stephanotis/STEPHANOTIS.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "DETTO ANCHE GELSOMINO DEL MADAGASCAR, È UN RAMPICANTE SEMPREVERDE VIGOROSO (RAGGIUNGE IN NATURA I 5 M DI LUNGHEZZA), CON FUSTI SPESSI, CHE DIVENTANO SEMILEGNOSI NEGLI ANNI. HA FOGLIE OVALI, CUOIOSE E LUCIDE, DI COLORE VERDE SCURO. DA MAGGIO A LUGLIO PRODUCE PICCOLI GRAPPOLI DI FIORI BIANCHI A FORMA DI STELLA, CARNOSI, INTENSAMENTE PROFUMATI, SIMILI A QUELLI DEL GELSOMINO. IDEALE SU TRALICCI, PICCOLE RECINZIONI, GAZEBI, PERGOLE.",
                   Coltivazione = "Teme temperature inferiori ai 12 °C: anche nel Sud è preferibile coltivarlo in vaso per spostarlo in serra fredda all’occorrenza. Necessita di un’esposizione a mezz’ombra e protetta dai venti. Vuole un substrato fertile e leggero, ben drenato. Va annaffiato con regolarità per tutta l’estate, appena la terra si è asciugata. Gradisce concimazioni costanti da marzo a settembre con un prodotto per piante da fiore.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "STRELITZIA",
                   NomeFamiglia = "Musacee",
                   NomeScientificoPianta = "Strelitzia reginae",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Strelitzia/STRELITZIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTA PERENNE SEMPREVERDE, PRIVA DI FUSTO O CON UN FALSO FUSTO FORMATO DALLA BASE DEI PICCIOLI FOGLIARI. LE FOGLIE, APPRESSATE, HANNO UNA GRANDE LAMINA (OLTRE 30 CM DI LUNGHEZZA) LUCIDA, CORIACEA, OVALE-LANCEOLATA, DI COLORE VERDE SCURO. I FIORI, PORTATI DA PICCIOLI PIÙ ALTI DELLE FOGLIE, SONO SPETTACOLARI, FORMATI DA UNA BRATTEA VERDE DALLA QUALE FUORIESCONO SEPALI, PETALI E STAMI ARANCIO E BLU-VIOLA. LA FIORITURA PUÒ DURARE DA OTTOBRE A MAGGIO.",
                   Coltivazione = "Soffre a temperature inferiori a +5 °C; in particolare teme i venti freddi che rovinano il fogliame e l’architettura dei fiori. Vive in piena terra solo al Sud, in zone riparate dalle correnti e possibilmente soleggiate d’inverno (in estate preferisce la mezz’ombra). Al Nord va coltivata in un vaso di almeno 35 cm di lato. Vuole terra fertile, leggera, molto ben drenata; concimazioni autunnali e primaverili; buone irrigazioni regolari.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "STREPTOSOLEN",
                   NomeFamiglia = "Solanacee",
                   NomeScientificoPianta = "Streptosolen jamesonii",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Streptosolen/STREPTOSOLEN.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "ARBUSTO SEMPREVERDE ORIGINARIO DELLA COLOMBIA, UN PO’ SCOMPOSTO NEL PORTAMENTO (SI PUÒ INDIRIZZARNE E FISSARNE I RAMI LUNGO SUPPORTI COME TRALICCI O GRIGLIATI PER COPRIRLI COME SE FOSSE UN RAMPICANTE), ALTO FINO A 2 METRI. PRESENTA FOGLIE OVATE, RUGOSE, LUNGHE 5 CM, COLOR VERDE INTENSO. DA MAGGIO AD AGOSTO PRODUCE FIORI A TROMBETTA, DEL DIAMETRO DI 2 CM, DI COLORE GIALLO-ARANCIO VIVO, PORTATI IN INFIORESCENZE A CORIMBO ALL’APICE DEI RAMI.",
                   Coltivazione = "Tollera temperature fino a +6 °C: si può quindi allevare in giardino solo nel Sud, in un punto riparato dal vento e soleggiato in inverno, proteggendolo con un telo nelle nottate più fredde; al Nord va coltivato in vaso (diametro minimo 40 cm). Richiede un substrato fertile, leggero, ben drenato e concimazioni quindicinali da marzo ad agosto, con un prodotto per piante da fiore. Va potato subito dopo la fioritura.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "THUNBERGIA",
                   NomeFamiglia = "Acantacee",
                   NomeScientificoPianta = "Thunbergia alata, T. grandiflora",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Thunbergia/THUNBERGIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTE PERENNI E SEMPREVERDI. T. ALATA HA SOTTILI FUSTI VOLUBILI, LEGNOSI ALLA BASE, LUNGHI FINO A 3 M, CON FOGLIE APPAIATE, OVATO-TRIANGOLARI, LUNGHE 8 CM E VERDE SCURO; DA GIUGNO A SETTEMBRE PRODUCE FIORI DI 5 CM, SOLITARI, A TROMBETTA, DI COLORE GIALLO-ARANCIO CON CENTRO MARRONE. T. GRANDIFLORA, MOLTO VIGOROSA, HA FUSTI CHE ARRIVANO AI 10 M DI LUNGHEZZA; PRODUCE FIORI DI 8 CM, IN GRAPPOLI PENDULI, DI COLORE AZZURRO LAVANDA CON GOLA BIANCA O GIALLO CHIARO.",
                   Coltivazione = "Temono temperature inferiori a +10 °C: al Nord vengono coltivate come annuali, mentre al Sud perdono la parte aerea in inverno. Preferiscono la mezz’ombra. Richiedono un terriccio leggermente acido, leggero, fertile, ben drenato. Devono essere annaffiate regolarmente nella bella stagione. Vanno concimate da marzo a settembre con un prodotto per piante da fioore. I fiori appassiti vanno rimossi costantemente.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "TIBOUCHINA",
                   NomeFamiglia = "Melastomacee",
                   NomeScientificoPianta = "Tibouchina semidecandra",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Tibouchina/TIBOUCHINA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "ARBUSTO SEMPREVERDE DAI FUSTI LEGNOSI E QUADRANGOLARI, ALTO FINO A 2,5 M (MA RAGGIUNGE SOLO 1 M SE COLTIVATO IN VASO, ANCHE DA MANTENERE IN APPARTAMENTO). HA FOGLIE OBLUNGO-OVATE, PELOSE, DI 15 CM DI LUNGHEZZA, DI COLORE VERDE BRONZO CON NERVATURE MARCATE COLOR VERDE PALLIDO. DA LUGLIO A NOVEMBRE PRODUCE FIORI SPETTACOLARI, DI CIRCA 8 CM DI DIAMETRO, A TUBO CON 5 GRANDI PETALI DI COLORE VIOLA-PORPORA, RIUNITI IN RACEMI APICALI.",
                   Coltivazione = " Soffre sotto i 12 °C: se coltivata in piena terra va pacciamata alla base e la pianta perderà comunque la parte aerea. Nel Nord va allevata in vaso, da ricoverare in serra calda o in casa. Predilige la mezz’ombra luminosa. Desidera un substrato fertile, leggero e ben drenato. Va annaffiata regolarmente in estate e concimata con un prodotto liquido per piante da fiore ogni tre settimane. Si pota alla fine della fioritura se necessario.",
		           Propagazione = "",
                   Malattie = "",
                },

                new PianteEsotiche
                {
                   NomeComunePianta = "TRACHYCARPUS",
                   NomeFamiglia = "Arecacee",
                   NomeScientificoPianta = "Trachycarpus fortunei",
                   FotoPianta = "ms-appx:///Immagini/Esotiche/Trachycarpus/TRACHYCARPUS.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Esotiche/Abete-*.jpg",

                   DescrizioneBotanica = "PALMA ALTA FINO A 12 M, CON FUSTI RICOPERTI DAI RESTI SFILACCIATI DELLE BASI FOGLIARI. LE FOGLIE, PORTATE IN CIMA AL FUSTO, LARGHE FINO A 90 CM, SONO A VENTAGLIO, COMPOSTE DA SEGMENTI SALDATI DALLA BASE A CIRCA METÀ FOGLIA; I PICCIOLI SONO LUNGHI DA 40 A 90 CENTIMETRI. I FIORI MASCHILI SONO GIALLI, QUELLI FEMMINILI VERDASTRI, CON DIAMETRO DI 4 MM, PORTATI SU INFIORESCENZE LUNGHE 1 METRO. LE INFRUTTESCENZE A GRAPPOLO PORTANO FRUTTI DI COLORE VARIABILE DAL GIALLO AL NERO.",
                   Coltivazione = "Resiste fino a –10 °C ed è quindi coltivabile all’aperto anche in Val Padana, in posizione soleggiata e riparata dai venti freddi. Desidera un substrato leggero, fertile e ben drenato. Solo le piante giovani necessitano di annaffiature estive, mentre gli esemplari adulti si accontentano delle precipitazioni. Si deve concimare con stallatico maturo o secco in autunno e primavera nei primi anni e poi ogni tre anni.",
		           Propagazione = "",
                   Malattie = "",
                },

                
               
            };

            return data;
        }

        // TODO WTS: Remove this once your MasterDetail pages are displaying real data
        public static async Task<IEnumerable<PianteEsotiche>> GetSampleModelDataAsync()
        {
            await Task.CompletedTask;

            return AllPianteEsotiche();
        }

        
    }
}
