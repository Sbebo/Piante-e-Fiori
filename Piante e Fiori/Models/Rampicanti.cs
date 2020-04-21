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
//19 RAMPICANTI
    public class Rampicanti
    {
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


    }

    public static class RampicantiDataService
    {
        private static IEnumerable<Rampicanti> AllRampicanti()
        {
            // The following is order summary data
            var data = new ObservableCollection<Rampicanti>
            {
               
                new Rampicanti
                {
                   NomeComunePianta = "ACTINIDIA KOLOMIKTA",
                   NomeFamiglia = "Actinidiacee",
                   NomeScientificoPianta = "Actinidia kolomikta",
                   FotoPianta = "ms-appx:///Immagini/RAMPICANTI/Actinidia Kolomikta/ACTINIDIA KOLOMIKTA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "RUSTICO RAMPICANTE CHE NON TEME IL GELO, HA FUSTI CHE SI AVVOLGONO A SPIRALE SUI SOSTEGNI, PARTENDO DIRETTAMENTE DALLA BASE DELLA PIANTA. LE FOGLIE SONO VERDI APPENA EMESSE IN PRIMAVERA, PER POI PRENDERE STRIATURE BIANCHE E ARROSSARSI ALL’APICE, CON UN ECCEZIONALE EFFETTO DECORATIVO. IN MAGGIO PRODUCE PICCOLI FIORI BIANCHI, PROFUMATI, A FORMA DI COPPA. PIANTA DIOICA, FORMA I FRUTTI (COMMESTIBILI) SOLO SE CONVIVONO PIANTE MASCHILI E PIANTE FEMMINILI.",
                   Coltivazione = "In vivaio è più facile trovare piante maschili, le cui foglie hanno colori più intensi. Ama le posizioni a mezzo sole, ma vive anche all’ombra (il fogliame però sbiadisce un po’). Desidera un terriccio fresco, fertile, leggero e ben drenato. Va innaffiata in abbondanza in estate. Si pota moderatamente in inverno per dare una forma alla pianta e stimolare la produzione di foglie. Poco adatta alla vita in vaso.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rampicanti
                {
                   NomeComunePianta = "AKEBIA",
                   NomeFamiglia = "Lardizabalacee",
                   NomeScientificoPianta = "Akebia quinata",
                   FotoPianta = "ms-appx:///Immagini/RAMPICANTI/Akebia/AKEBIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "UN SEMISEMPREVERDE (PERDE LE FOGLIE NELLE ZONE FREDDE) I CUI FUSTI CRESCONO RAPIDAMENTE E VANNO INDIRIZZATI (ED EVENTUALMENTE LEGATI) SUL SUPPORTO (MURI, PERGOLE, GRATICCI). LE FOGLIE PALMATE SONO OVALI, CEROSE, PICCOLE MA MOLTO FITTE, ARROSSATE APPENA NASCONO. IN PRIMAVERA FIORISCE IN MARRONE-PORPORA, IN MAZZETTI NASCOSTI TRA IL FOGLIAME, PROFUMATI DELICATAMENTE. IN ESTATE SEGUONO I FRUTTI, BACCELLI TONDEGGIANTI CON NUMEROSI SEMI.",
                   Coltivazione = "Preferisce una posizione soleggiata, ma resiste anche all’ombra, dove però fiorisce molto meno. Ama terreni ricchi e profondi, molto ben drenati. Vive anche in vaso, purché molto grande. Gli esemplari giovani e quelli in vaso vanno annaffiati spesso in estate; quelli adulti in piena terra tollerano fino a 3 settimane di siccità. Si concima tra febbraio e aprile per favorire la fioritura. Si pota solo per ridurre l’ingombro.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rampicanti
                {
                   NomeComunePianta = "BIGNONIA",
                   NomeFamiglia = "Bignoniacee",
                   NomeScientificoPianta = "Campsis radicans",
                   FotoPianta = "ms-appx:///Immagini/RAMPICANTI/Bignonia/BIGNONIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "RUSTICA E ROBUSTA, È UNA PIANTA DECIDUA DAI FUSTI RAPIDI A CRESCERE, DA INDIRIZZARE E LEGARE AL SUPPORTO (MURO, PERGOLA, TRALICCIO, RECINZIONE ECC.) SOPRATTUTTO NEI PRIMI ANNI DI VITA. HA FOGLIE COMPOSTE, GRANDI, TRA LE QUALI IN GIUGNO-AGOSTO SI FORMANO I GRANDI FIORI COLOR ARANCIO INTENSO A FORMA DI TROMBETTA. IN MERIDIONE SI POSSONO UTILIZZARE ANCHE TECOMA STANS (GRANDI FIORI GIALLI) E MACFAYDENA UNGUISCATIS (FIORI ROSSI, PIÙ PICCOLI).",
                   Coltivazione = "Resiste al caldo e al gelo intenso. Desidera terreni freschi e profondi, drenati, abbastanza fertili. Per esposizioni soleggiate o a mezzo sole. Va annaffiata in abbondanza solo nei primi anni dopo l’impianto, poi non è più necessario bagnare. Gradisce una concimazione organica in autunno e in primavera. Tollera bene le potature, anche drastiche, per ridurre l’ingombro. È inadatta al vaso. I fiori attirano le formiche.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rampicanti
                {
                   NomeComunePianta = "BUGANVILLEA",
                   NomeFamiglia = "Nittaginacee",
                   NomeScientificoPianta = "Bougainvillea",
                   FotoPianta = "ms-appx:///Immagini/RAMPICANTI/Buganvillea/BUGANVILLEA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "SPLENDIDA SARMENTOSA SEMISEMPREVERDE (PERDE LE FOGLIE IN INVERNO NELLE ZONE FRESCHE), CARATTERIZZATA DA LUNGHI TRALCI CHE VANNO INDIRIZZATI E LEGATI SUL TUTORE (MURI, PERGOLE, TETTOIE, PORTICATI, RECINZIONI ECC.). PRESENTA FOGLIE CUORIFORMI COLOR VERDE BRILLANTE (ESISTE ANCHE UNA VARIETÀ VARIEGATA DI BIANCO). I FIORI, MINUSCOLI E BIANCHI, SONO ATTORNIATI DA BRATTEE COLORATE, VIOLA NELLA SPECIE, ROSSE, ARANCIO, GIALLE O BIANCHE NELLE VARIETÀ FLORICOLE.",
                   Coltivazione = "Indicata per zone calde, resiste in vaso (grande) nel Nord Italia, dove va protetta in serra calda durante l’inverno. Chiede il pieno sole e un terreno leggero, fertile e ben drenato. È meglio schermare il piede dai raggi solari. Si concima in autunno e in primavera con un prodotto a lenta cessione per piante da fiore. Necessita d’acqua in estate solo nei primi anni. Si può potare a fine inverno, per ridurre l’ingombro dei tralci.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },
                new Rampicanti
                {
                   NomeComunePianta = "CLEMATIDE",
                   NomeFamiglia = "Ranuncolacee",
                   NomeScientificoPianta = "Clematis",
                   FotoPianta = "ms-appx:///Immagini/RAMPICANTI/Clematide/CLEMATIDE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "OLTRE ALLE SPECIE C. ALPINA E C. MONTANA ESISTONO CENTINAIA DI VARIETÀ, CHE SI DIFFERENZIANO PER IL COLORE E LA FORMA (SEMPLICI, SEMIDOPPI, DOPPI) DEI FIORI, L’EPOCA DI FIORITURA (SOLO IN PRIMAVERA, SOLO IN ESTATE, IN PRIMAVERA E IN TARDA ESTATE) E LA RESISTENZA AL GELO (LA MAGGIORANZA DI ESSE È MOLTO RUSTICA, TANTO DA VIVERE SULLE ALPI). I FUSTI ESILI E VOLUBILI SI AVVILUPPANO DA SOLI ATTORNO AL SUPPORTO (PALI, RECINZIONI, COLONNE, TRALICCI).",
                   Coltivazione = "In inverno la parte aerea si secca, ma la pianta non è morta come sembra: in primavera germoglia nuovamente. Va potata in estate (varietà a fioritura primaverile), in autunno (varietà a doppia fioritura), in inverno (varietà a fioritura estiva). Ama suoli freschi e fertili, ben drenati. Necessita di sole, ma non alla base della pianta. Gradisce le annaffiature quando è giovane o vive in vaso, dove resiste bene se è grande.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rampicanti
                {
                   NomeComunePianta = "COBEA",
                   NomeFamiglia = "Polemoniacee",
                   NomeScientificoPianta = " Cobaea scandens",
                   FotoPianta = "ms-appx:///Immagini/RAMPICANTI/Cobea/COBEA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "VIGOROSA E RAPIDA NELLA CRESCITA (ARRIVA FINO A 7 M DI LUNGHEZZA DEI TRALCI), È INDICATA PER PERGOLE E GRIGLIATI, SUI QUALI SI ARRAMPICA DA SOLA TRAMITE I CIRRI PORTATI DALLE FOGLIE, CHE SONO COLOR VERDE BRILLANTE, PIUTTOSTO FITTE. DA LUGLIO A SETTEMBRE PRODUCE GRANDI (DIAMETRO 6 CM) FIORI A COPPA DI COLORE VIOLA (I BOCCI PERÒ SONO SEMPRE BIANCHI E SVILUPPANO LA TINTA MAN MANO CHE SI APRONO) NELLA SPECIE, CANDIDI NELLA VARIETÀ ALBA.",
                   Coltivazione = "È una pianta perenne ma teme il freddo: nel Nord Italia viene utilizzata come annuale, mentre in Meridione supera l’inverno, eventualmente liberandosi del fogliame. Ama il sole, ma non alla base della pianta. Il terreno deve essere fresco e umido, ben drenato. Le annaffiature devono essere costanti, tanto di più quanto maggiore è il caldo. Va concimata da aprile a settembre. Si può coltivare in vaso (diametro minimo 28 cm).",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rampicanti
                {
                   NomeComunePianta = "EDERA",
                   NomeFamiglia = "Araliacee",
                   NomeScientificoPianta = "Hedera helix",
                   FotoPianta = "ms-appx:///Immagini/RAMPICANTI/Edera/EDERA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "ROBUSTA, VIGOROSA E RUSTICA, PRODUCE LUNGHI TRALCI (FINO A 20 M) DOTATI DI MICROVENTOSE CON LE QUALI SI ATTACCA ESTERNAMENTE ALLE SUPERFICI (MURI, TRONCHI D’ALBERO, TRALICCI, PERGOLE ECC.). I TRALCI NON FIORIFERI HANNO FOGLIE A 3 O 5 LOBI, QUELLI FIORIFERI FOGLIE ROMBOIDALI. I FIORI, VERDI, COMPAIONO DOPO I 10 ANNI D’ETÀ; NE DERIVANO BACCHE NERE, VELENOSE PER L’UOMO MA NON PER GLI UCCELLI. NE ESISTONO NUMEROSE VARIETÀ, ANCHE A FOGLIA VARIEGATA O DA VASO.",
                   Coltivazione = "Tende a diventare infestante, se non viene controllata nella crescita mediante potature, anche energiche se necessario. Può essere utilizzata anche come tappezzante. Preferisce l’ombra (varietà a foglie verdi), ma cresce bene anche al sole (soprattutto le varietà variegate) se il piede è coperto. Desidera terreni freschi e profondi, anche poveri o non del tutto drenati. Non necessita di concime né di irrigazioni (salvo il primo anno).",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rampicanti
                {
                   NomeComunePianta = "FALSO GELSOMINO",
                   NomeFamiglia = "Apocinacee",
                   NomeScientificoPianta = "Trachelospermum jasminoides",
                   FotoPianta = "ms-appx:///Immagini/RAMPICANTI/Falso Gelsomino/FALSO GELSOMINO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "RUSTICO, RESISTE AL GELO DELLA VAL PADANA ANCHE SENZA PROTEZIONI (SE COLTIVATO IN PIENA TERRA). SVILUPPA (LENTAMENTE NEI PRIMI ANNI) TRALCI LEGNOSI E ROBUSTI FINO A 5 M DI LUNGHEZZA, CHE SI INSINUANO SU TRALICCI E RECINZIONI O PERGOLE. È UN SEMPREVERDE DALLE FOGLIE PICCOLE E CORIACEE, COLOR VERDE SCURO. IN MAGGIO-GIUGNO SI COPRE IN ABBONDANZA DI PICCOLI FIORI CANDIDI E PROFUMATISSIMI, MOLTO APPREZZATI DALLE API. VIENE CHIAMATO ANCHE RINCOSPERMO.",
                   Coltivazione = "Va coltivato in vaso sull’arco alpino (diametro minimo 40 cm). Richiede un terreno fertile, fresco, ben drenato, non pesante. Predilige un’esposizione soleggiata (con piede all’ombra), l’unica che garantisce una buona fioritura. Va annaffiato regolarmente nei primi anni e in vaso. Si concima in autunno e in primavera, con un prodotto a lenta cessione per arbusti da fiore. Si pota solo per ridurne lo sviluppo.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rampicanti
                {
                   NomeComunePianta = "GELSOMINO",
                   NomeFamiglia = "Oleacee",
                   NomeScientificoPianta = "Jasminum officinale",
                   FotoPianta = "ms-appx:///Immagini/RAMPICANTI/Gelsomino/GELSOMINO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "PERENNE SEMPREVERDE DAGLI ESILI FUSTI CHE VANNO INDIRIZZATI LUNGO IL SUPPORTO (RECINZIONE, TRALICCIO, PERGOLA). HA FOGLIE LANCEOLATE, COLOR VERDE INTENSO, POCO CORIACEE. PRODUCE IN GIUGNO-LUGLIO PICCOLI FIORI BIANCHI PROFUMATISSIMI (SOPRATTUTTO DI NOTTE). J. OFFICINALE È LA SPECIE PIÙ ROBUSTA E SEMIRUSTICA; J. GRANDIFLORUM ‘GRANDUCA DI TOSCANA’ HA I FIORI PIÙ GRANDI; J. SAMBAC, QUELLI PIÙ PROFUMATI; J. AZORICUM COROLLE VENATE DI ROSA NELLA GOLA.",
                   Coltivazione = "Resiste nel Nord Italia solo se coltivato in vaso grande (diametro minimo 40 cm), mentre al Sud vive in piena terra in posizioni riparate. Ama il pieno sole, anche al piede. Preferisce un suolo fertile, non pesante né sassoso. Va bagnato in estate nei primi anni di vita e in vaso. Si concima con stallatico maturo o secco in autunno e in primavera. Se l’ingombro suggerisce di potarlo, si procede con quest’operazione in inverno.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rampicanti
                {
                   NomeComunePianta = "GLICINE",
                   NomeFamiglia = "Leguminose",
                   NomeScientificoPianta = "Wisteria sinensis",
                   FotoPianta = "ms-appx:///Immagini/RAMPICANTI/Glicine/GLICINE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "SPLENDIDO RAMPICANTE DECIDUO DALLA CRESCITA VELOCISSIMA, RESISTE FINO A -15 °C. HA FUSTI ROBUSTI CHE SI AVVINGHIANO AL SOSTEGNO: ATTENZIONE, È IN GRADO DI PIEGARE IL FERRO E L’ACCIAIO (MA NON IL LEGNO). IDEALE PER PERGOLE, RECINZIONI, PORTICATI, TETTOIE. HA FOGLIE COMPOSTE, COLOR VERDE TENERO. IN APRILE-MAGGIO PRODUCE LUNGHI GRAPPOLI DI FIORI VIOLA (BIANCHI IN ALCUNE VARIETÀ FLORICOLE), AMATI DALLE API. HA UNA SECONDA FIORITURA, MODESTA, IN GIUGNO-LUGLIO.",
                   Coltivazione = "Si adatta bene a qualsiasi tipo di terreno, anche compatto o povero e sassoso, ma gradisce una concimazione autunnale e primaverile con letame maturo o un prodotto granulare a lenta cessione. Dopo il primo anno, non ha più bisogno di essere bagnato. Va potato in maggio dopo la fioritura, accorciando leggermente i tralci, e poi più severamente in settembre. Esistono anche varietà apposite per la coltivazione in vaso.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rampicanti
                {
                   NomeComunePianta = "HARDENBERGIA",
                   NomeFamiglia = "Leguminose",
                   NomeScientificoPianta = "Hardenbergia violacea",
                   FotoPianta = "ms-appx:///Immagini/RAMPICANTI/Hardenbergia/HARDENBERGIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "SEMPREVERDE DAL FUSTO LEGNOSO CHE SI ATTORCIGLIA DA SOLO ATTORNO A GRATICCI, PERGOLE, RECINZIONI, PALI, FINO A UNA LUNGHEZZA DI 3 METRI. HA FOGLIE ALLUNGATE E LANCEOLATE, MEDIAMENTE CORIACEE, COLOR VERDE SCURO. IN MARZO-APRILE SI RIEMPIE DI GRAPPOLI DI PICCOLI MA NUMEROSI FIORI DI COLORE VIOLA (BLU, BIANCHI O ROSA NELLE VARIETÀ FLORICOLE). H. COMPTONIANA ARRIVA FINO A 10 M DI LUNGHEZZA E HA FIORI BLU-VIOLA CON CENTRO VERDE BRILLANTE.",
                   Coltivazione = "Tollera temperature fino a –10 °C, se posizionata in luogo ben riparato dai venti e soleggiato; in alternativa si può coltivare in vaso grande (diametro minimo 32 cm). Ama il sole, anche al piede, e i terreni freschi, profondi, fertili, ben drenati. Soprattutto in estate, e se coltivata in vaso, ha bisogno di molta acqua. Si concima nel primo autunno e nel tardo inverno con letame o un prodotto a lenta cessione per arbusti da fiore.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rampicanti
                {
                   NomeComunePianta = "IPOMEA",
                   NomeFamiglia = "Convolvolacee",
                   NomeScientificoPianta = "Ipomoea purpurea",
                   FotoPianta = "ms-appx:///Immagini/RAMPICANTI/Ipomea/IPOMEA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "ANNUALE DALLA CRESCITA RAPIDISSIMA, FORMA LUNGHI TRALCI (FINO A 7 M) CHE SI AVVINGHIANO A QUALUNQUE SUPPORTO (PERGOLE, PALI, PIANTE, GRATICCI ECC.). LE FOGLIE SONO TENERE, GRANDI, CUORIFORMI. PRODUCE VISTOSE CAMPANELLE (DIAMETRO MAX 8 CM) VIOLA PORPO RA, CHE SI APRONO AL MATTINO E SI CHIUDONO DI POMERIGGIO. DURANO UN GIORNO SOLO, MA NE VENGONO CONTINUAMENTE PRODOTTI DI NUOVI. I. BONAENOCTIS È UNA PERENNE CHE SCHIUDE I FIORI BIANCHI E PROFUMATI DI NOTTE.",
                   Coltivazione = "Facilissima da coltivare, si semina in marzo in seminiera, in aprile a dimora, sia in piena terra sia in vaso (grande, diametro minimo 28 cm per una pianta). Si accontenta di qualunque terriccio, ma se è fertile e profondo i risultati saranno migliori. Per favorire la fioritura si concima ogni 15 giorni con un prodotto liquido per piante da fiore. Si possono raccogliere i semi da riseminare la primavera successiva.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rampicanti
                {
                   NomeComunePianta = "LONICERA",
                   NomeFamiglia = "Caprifogliacee",
                   NomeScientificoPianta = "Lonicera caprifolium",
                   FotoPianta = "ms-appx:///Immagini/RAMPICANTI/Lonicera/LONICERA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "IL CAPRIFOGLIO O MADRESELVA È UNA SARMENTOSA I CUI TRALCI (LUNGHEZZA MASSIMA 5 M) VANNO INDIRIZZATI SUL SUPPORTO (TRALICCIO, RECINZIONE, MURETTO). DECIDUA, HA FOGLIE OVALI A MARGINE LISCIO. IN GIUGNO-LUGLIO SI RIEMPIE DI FIORI PICCOLI, BIANCHI E GIALLI, DELICATAMENTE PROFUMATI. ALTRI RAMPICANTI SONO L. ETRUSCA (FIORI GIALLI), L. JAPONICA (BIANCHI E GIALLI), L. PERYCLIMENUM (GIALLI E ROSSI), L. TELLMANNIANA (GIALLI E ROSSI). ATTENZIONE: LE BACCHE SONO VELENOSE.",
                   Coltivazione = "Preferisce una posizione soleggiata (ma con il piede all’ombra) o a mezz’ombra. Il substrato deve essere fresco, profondo, fertile e umido, ma ben drenato. Le annaffiature devono essere regolari soprattutto in estate, per tutta la vita della pianta, sia in piena terra sia in vaso (diametro minimo 40 cm). Va concimata in autunno e in primavera, con letame ben maturo o stallatico secco. La potatura è leggera, a fine inverno.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rampicanti
                {
                   NomeComunePianta = "ORTENSIA RAMPICANTE",
                   NomeFamiglia = "Idrangeacee",
                   NomeScientificoPianta = "Hydrangea petiolaris",
                   FotoPianta = "ms-appx:///Immagini/RAMPICANTI/Ortensia Rampicante/ORTENSIA RAMPICANTE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "PERENNE SARMENTOSA I CUI TRALCI (LUNGHI FINO A 1,5 M) VANNO INDIRIZZATI SU TRALICCI O MURETTI (IN ALTERNATIVA SI IMPIEGA COME TAPPEZZANTE), SUI QUALI SI ATTACCANO POI DA SOLI GRAZIE ALLE RADICI AVVENTIZIE. HA FOGLIE OVALI, CONSISTENTI, CON MARGINE DENTATO. PRODUCE IN GIUGNO-LUGLIO INFIORESCENZE DI TIPO ‘LACECAP’ DI 8 CM DI DIAMETRO. PIÙ VISTOSA È SCHIZOPHRAGMA HYDRANGEOIDES, CHE OFFRE FINO A 10 CM DI DIAMETRO E UGUALE PORTAMENTO RAMPICANTE.",
                   Coltivazione = "Ideale per climi freschi o freddi, soffre nelle stazioni marittime e nel Sud Italia, mentre sopporta temperature fino a –15 °C. Preferisce la mezz’ombra. Desidera un terreno fresco, fertile e profondo, ben drenato e irrigato con regolarità soprattutto in estate. Può vivere in vaso grande (minimo 40 cm di diametro). Non necessita di potature, se non per contenerne le dimensioni; nel caso, si effettuano in febbraio.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rampicanti
                {
                   NomeComunePianta = "PASSIFLORA",
                   NomeFamiglia = "Passifloracee",
                   NomeScientificoPianta = "Passiflora coerulea",
                   FotoPianta = "ms-appx:///Immagini/RAMPICANTI/Passiflora/PASSIFLORA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "RAMPICANTE DI GRANDE CAPACITÀ DECORATIVA, È IN GRADO DI SOPRAVVIVERE ALL'INVERNO ANCHE IN ZONA ALPINA, SE POSIZIONATA IN LUOGO RIPARATO. I LUNGHI FUSTI (FINO A 7 M DI LUNGHEZZA) SI ATTORCIGLIANO DA SOLI AI SUPPORTI (RECINZIONI, PALI, GRATICCI, PERGOLE ECC.). DA GIUGNO IN POI PRODUCE GRANDI E CURIOSI FIORI ARCHITETTONICI, BIANCHI E VIOLA, DA CUI SCATURISCONO FRUTTI ARANCIONI; COMMESTIBILI. ESISTONO ALTRE SPECIE MENO RUSTICHE, DA COLTIVARE IN VASO, CHE VA PROTETTO.",
                   Coltivazione = "Vuole posizioni soleggiate, ma con la base della pianta all'ombra. In inverno le foglie cadono e la parte aerea si secca, ma in primavera emette prontamente i nuovi germogli. Predilige terreni fertili e freschi, ben drenati. Le annaffiature sono necessarie nei primi anni e in vaso (grande, diametro minimo 40 cm). Gradisce una concimazione a base di letame o stallatico in autunno, in primavera e all'inizio dell'estate.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rampicanti
                {
                   NomeComunePianta = "PISELLO ODOROSO",
                   NomeFamiglia = "Leguminose",
                   NomeScientificoPianta = "Lathyrus odoratus",
                   FotoPianta = "ms-appx:///Immagini/RAMPICANTI/Pisello Odoroso/PISELLO ODOROSO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "ANNUALE A CRESCITA RAPIDA, COMPRENDE DIVERSE VARIETÀ NELLE QUALI, PURTROPPO, PER SELEZIONARE LA BELLEZZA E GRANDEZZA DEI FIORI, È ANDATO PERSO IL PROFUMO. I TRALCI (LUNGHI FINO A 2 M) SI ATTORCIGLIANO DA SOLI SUI SUPPORTI (PALI, TRALICCI, RECINZIONI ECC.). LE FOGLIE PINNATE SONO DATE DA DUE FOGLIOLINE OVALI. I FIORI GRANDI, A FORMA DI FARFALLA, SONO BIANCHI, ROSA, ROSSI, BLU O VIOLA, E VENGONO PRODOTTI DA MAGGIO AD AGOSTO. ESISTONO ANCHE VARIETÀ COMPATTE.",
                   Coltivazione = "La coltivazione è semplicissima: si semina in marzo in seminiera, in aprile all’aperto, su terreno soffice, fresco, fertile e ben drenato. Necessita di molta acqua durante tutta la stagione, senza far asciugare il terriccio, con l’aggiunta di un fertilizzante liquido per piante da fiore ogni 15-20 giorni. Vanno eliminati regolarmente i fiori appassiti. Ama posizioni soleggiate, ma con piede all’ombra nelle zone più calde d’Italia.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rampicanti
                {
                   NomeComunePianta = "NASTURZIO RAMPICANTE",
                   NomeFamiglia = "Tropeolacee",
                   NomeScientificoPianta = "Tropaeolum majus",
                   FotoPianta = "ms-appx:///Immagini/RAMPICANTI/Nasturzio Rampicante/NASTURZIO RAMPICANTE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTA PERENNE COLTIVATA COME ANNUALE, HA FUSTI CHE SI ALLUNGANO FINO A 2,5 M E CHE VANNO INDIRIZZATI VERSO IL SUPPORTO (MURETTO, GRATICCIO, RECINZIONE). LE FOGLIE, TONDEGGIANTI, HANNO UN LUNGO PICCOLO AL CENTRO. I FIORI, GIALLI, ARANCIO, ROSSI O MARRONI, SONO GRANDI E PRODOTTI IN ABBONDANZA TRA GIUGNO E SETTEMBRE. I BOCCIOLI SI POSSONO METTERE SOTT’ACETO COME I CAPPERI. TUTTA LA PIANTA EMANA UN ODORE PARTICOLARE, CHE ALLONTANA GLI ANIMALETTI NOCIVI.",
                   Coltivazione = "Semplice da coltivare, si semina in marzo in seminiera e in aprile all’aperto. Desidera una posizione semiombreggiata, soprattutto nelle zone più calde. Il terriccio deve essere soffice, poco fertile (se è ricco, la pianta produce foglie piuttosto che fiori), ben drenato e costantemente inumidito da annaffiature regolari (soprattutto in estate). Adatto alla coltivazione in vaso (diametro minimo 28 cm).",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rampicanti
                {
                   NomeComunePianta = "VITE AMERICANA",
                   NomeFamiglia = "Vitacee",
                   NomeScientificoPianta = "Parthenocissus tricuspidata",
                   FotoPianta = "ms-appx:///Immagini/RAMPICANTI/Vite Americana/VITE AMERICANA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   Coltivazione = "La coltivazione è semplicissima: si semina in marzo in seminiera, in aprile all’aperto, su terreno soffice, fresco, fertile e ben drenato. Necessita di molta acqua durante tutta la stagione, senza far asciugare il terriccio, con l’aggiunta di un fertilizzante liquido per piante da fiore ogni 15-20 giorni. Vanno eliminati regolarmente i fiori appassiti. Ama posizioni soleggiate, ma con piede all’ombra nelle zone più calde d’Italia.",
                   DescrizioneBotanica = "Questa perenne non ha particolari esigenze: tollera il gelo e il caldo torrido, cresce al sole come all’ombra, su terreni freschi e fertili come poveri e sassosi (ma non su quelli aridi), senza grandi necessità idriche (tranne che nel primo anno dopo l’impianto) né di fertilizzazione. Si può potare in estate, se serve contenerne lo sviluppo (che è però meno intenso e rigoglioso rispetto alla vite canadese). Non adatta alla vita in vaso.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rampicanti
                {
                   NomeComunePianta = "VITE CANADESE",
                   NomeFamiglia = "Vitacee",
                   NomeScientificoPianta = "Parthenocissus quinquefolia",
                   FotoPianta = "ms-appx:///Immagini/RAMPICANTI/Vite Canadese/VITE CANADESE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "VIGOROSA, RUSTICA E RAMIFICATA, PRODUCE FUSTI LUNGHI FINO A 20 M, DOTATI DI VITICCI CON I QUALI SI AGGRAPPANO A QUALUNQUE SOSTEGNO: TRALICCI, MURI, PERGOLE, RECINZIONI, PALI ECC. HA FOGLIE FORMATE DA 3-5 FOGLIOLINE. IN MAGGIO-GIUGNO PRODUCE MINUSCOLI FIORELLINI GIALLO-VERDI, RIUNITI IN INFIORESCENZE, DA CUI IN AUTUNNO SI FORMANO I FRUTTI NERASTRI, SOMIGLIANTI AI GRAPPOLI D’UVA (MA COMMESTIBILI SOLO PER GLI UCCELLINI CHE NE SONO GHIOTTI).",
                   Coltivazione = "Anche questa perenne non ha esigenze: vive bene dalle Alpi alla Sicilia, al sole e all’ombra (dove però in autunno le foglie prima di cadere non avranno colori scintillanti di rosso e d’oro), su terreni ricchi e profondi, oppure poveri e pietrosi (purché non aridi), senz’acqua (eccetto il primo anno dopo l’impianto) né fertilizzanti. Va potata durante la stagione vegetativa per contenerne l’esuberante sviluppo.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

               




            };

            return data;
        }

        // TODO WTS: Remove this once your MasterDetail pages are displaying real data
        public static async Task<IEnumerable<Rampicanti>> GetSampleModelDataAsync()
        {
            await Task.CompletedTask;

            return AllRampicanti();
        }

        
    }
}
