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
//52 ARBUSTI
    public class Arbusti
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

        public string LinkNomeComunePianta { get; set; }


    }

    public static class ArbustiDataService
    {
        private static IEnumerable<Arbusti> AllArbusti()
        {
            // The following is order summary data
            var data = new ObservableCollection<Arbusti>
            {
               
                new Arbusti
                {
                   NomeComunePianta = "ABELIA",
                   NomeFamiglia = "Caprifoliacee",
                   NomeScientificoPianta = "Abelia grandiflora",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/ABELIA/ABELIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",
                   LinkNomeComunePianta = "https://www.bing.com/search?q=ABELIA",

                   DescrizioneBotanica = "OLTRE AD A. GRANDIFLORA VIENE COLTIVATA ANCHE A. CHINENSIS. ENTRAMBE SONO MOLTO DECORATIVE, SIA COME ESEMPLARI SINGOLI, SIA IN MACCHIE, SIA NELLE BORDURE MISTE INSIEME CON PIANTE ERBACEE. RAGGIUNGONO UN’ALTEZZA COMPRESA FRA 1,50 E 1,80 M. IL FOGLIAME SI PRESENTA VERDE CON SFUMATURE ROSSASTRE, VARIEGATO IN ALCUNE VARIETÀ; LE FOGLIE SONO PICCOLE. I FIORI, CHE SBOCCIANO IN TARDA ESTATE, SONO BIANCO-ROSATI O ROSSI, A TUBO, PICCOLI MA NUMEROSI.",
                   Coltivazione = "Nelle zone alpine è necessario coltivarla in vaso (diametro minimo 40 cm), da riparare durante l’inverno in serra fredda; in Val Padana gli esemplari in piena terra, se battuti dal vento, vanno coperti con un telo di non tessuto. Preferisce il sole o la mezz’ombra. Vuole un terreno profondo e fertile, ben drenato. Si concima con letame o stallatico in autunno e in primavera. I nuovi impianti vanno annaffiati nel primo anno.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",

                   
                },

                new Arbusti
                {
                   NomeComunePianta = "ARANCIO TRIFOGLIATO",
                   NomeFamiglia = "Rutacee",
                   NomeScientificoPianta = "Poncirus trifoliata",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/ARANCIO TRIFOGLIATO/ARANCIO TRIFOGLIATO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "È UN SEMISEMPREVERDE (PERDE LE FOGLIE NELLE ZONE FREDDE) DAI CARATTERISTICI RAMI VERDI E SPINOSI. RAGGIUNGE UN’ALTEZZA MASSIMA DI 3 M E PUÒ ESSERE ALLEVATO COME ESEMPLARE SINGOLO O IN SIEPI DIFENSIVE. PRESENTA FOGLIE COMPOSTE DA 3 FOGLIOLINE. IN MAGGIO-GIUGNO PRODUCE GRANDI FIORI BIANCHI A FORMA DI FARFALLA, DELICATAMENTE PROFUMATI. DA AGOSTO IN POI SONO VISIBILI I FRUTTI, PICCOLI AGRUMI VERDI DALLA BUCCIA RUGOSA E PELOSA, NON COMMESTIBILI.",
                   Coltivazione = "Resiste al freddo sino alla Val Padana e può essere coltivato in piena terra o in vaso grande. Preferisce posizioni soleggiate, ma tollera anche l’ombra, dove però non fiorisce. L’unica preferenza riguarda i suoli ben drenati. Necessita di acqua solo durante la prima estate. Una concimazione in autunno e una in primavera, con un prodotto granulare a lenta cessione per piante da fiore, migliora la fioritura.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Arbusti
                {
                   NomeComunePianta = "AZALEA E RODODENDRO",
                   NomeFamiglia = "Ericacee",
                   NomeScientificoPianta = "Rhododendron",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/Azalea e Rododendro/AZALEA E RODODENDRO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "LA DIFFERENZA TRA AZALEE E RODODENDRI HA CARATTERE SPECIALISTICO. PIÙ COMUNEMENTE SI PARLA DI PIANTE DA INTERNI E DA ESTERNI, ENTRAMBE APPARTENENTI AL GENERE RHODODENDRON, CHE COMPRENDE SPECIE DAI 20 CM AI 10 M D’ALTEZZA, SEMPREVERDI, SEMISEMPREVERDI O DECIDUE. SI FANNO APPREZZARE PER LA FIORITURA, IN APRILE-MAGGIO, RICCA DI COLORI (BIANCO, GIALLO, ROSA, ARANCIO, ROSSO, PORPORA, VIOLA) E, A VOLTE, DI PROFUMI. VARIETÀ E IBRIDI ORMAI NON SI CONTANO PIÙ.",
                   Coltivazione = "Tutti i Rhododendron da esterni resistono al gelo anche intenso, non altrettanto invece quelli da interni (azalee). Sono piante acidofile: desiderano un terriccio acido, acqua decalcificata in abbondanza, fertilizzante per acidofile. Amano la mezz’ombra e i climi freschi: sono indicate per il Nord e Centro Italia. Soprattutto in estate non devono mancare le annaffiature. Si coltivano in piena terra come in vaso.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Arbusti
                {
                   NomeComunePianta = "BERBERIS",
                   NomeFamiglia = "Berberidacee",
                   NomeScientificoPianta = "Berberis thunbergii",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/BERBERIS/Berberis.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "CHIAMATA ANCHE CRESPINO, FORMA CESPUGLI INTRICATI E IMPENETRABILI, ANCHE PER LA PRESENZA DI CORTE E AFFILATE SPINE SUI RAMI. SI UTILIZZA COME ESEMPLARE ISOLATO O IN MACCHIE, MA SOPRATTUTTO PER SIEPI DIFENSIVE. RAGGIUNGE I 3 M D’ALTEZZA. CADUCIFOGLIA, PRESENTA PICCOLE FOGLIE ROSSE IN PRIMAVERA E IN AUTUNNO, VERDI IN ESTATE. IN APRILE-MAGGIO SI COPRE DI MINUSCOLI FIORI GIALLI, CHE POI SI TRASFORMANO IN PICCOLI FRUTTI NERI DURANTE L’ESTATE.",
                   Coltivazione = "Tollera il gelo e il caldo intenso, l’inquinamento, i terreni poveri, secchi e sassosi, i pendii e le scarpate (che consolida con le robuste e profonde radici), la mancanza d’acqua (ma non subito dopo l’impianto), le potature anche drastiche (che portano a un rinnovato vigore vegetativo). Resiste in ogni posizione; al sole, a mezz’ombra e all’ombra (dove però le tinte sono meno accentuate). Non necessita di concimazioni.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Arbusti
                {
                   NomeComunePianta = "BIANCOSPINO",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Crataegus",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/BIANCOSPINO/Biancospino.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "NUMEROSE SONO LE SPECIE APPARTENENTI AL GENERE CRATAEGUS: C. MONOGYNA (BIANCOSPINO), C. AZAROLUS (AZZERUOLO, DAI FRUTTI COMMESTIBILI) E ALTRE SPECIE E VARIETÀ FLORICOLE ORNAMENTALI. SI UTILIZZA PER BORDURE MISTE O PER SIEPI DIFENSIVE (I RAMI SONO SPINOSI). PRESENTA FOGLIE LOBATE O LANCEOLATE, CADUCHE. FIORISCE IN MAGGIO IN RICCHE INFIORESCENZE BIANCO CREMA O ROSATE DA CUI, IN AGOSTO, SI FORMANO I FRUTTI, ROSSI, BIANCHI O NERI A SECONDA DELLA SPECIE.",
                   Coltivazione = "Genere robusto e rustico, vive bene dalle Alpi alle coste della Sicilia, senza particolari precauzioni. Gradisce il sole o la mezz’ombra. Predilige suoli leggeri, anche poveri o moderatamente sassosi, sempre ben drenati. Necessita di annaffiature solo nel primo anno dall’impianto; non è indispensabile concimare. Tollera senza problemi l’inquinamento urbano. È preferibile la coltivazione in piena terra rispetto al vaso.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Arbusti
                {
                   NomeComunePianta = "BOSSO",
                   NomeFamiglia = "Buxacee",
                   NomeScientificoPianta = "Buxus sempervirens",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/BOSSO/Bosso.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "ARBUSTO CARATTERIZZATO DALLA LENTEZZA DI CRESCITA (5 CM IN UN ANNO, MA ANCHE MENO IN ALCUNE VARIETÀ FLORICOLE), UTILIZZATO NEI GIARDINI ALL’ITALIANA PER SIEPI BASSE E PER L’ARTE TOPIARIA (SI PRESTA A ESSERE MODELLATO CON LE FORBICI NEI SOGGETTI PIÙ DISPARATI, ANCHE FORGIATI CON L’AIUTO DEL FILO DI FERRO). HA FOGLIE PICCOLE, PERSISTENTI, DAL CARATTERISTICO AROMA, CHE SI SPRIGIONA SOPRATTUTTO QUANDO SONO BATTUTE DAL SOLE. LA FIORITURA È INSIGNIFICANTE.",
                   Coltivazione = "Non teme il freddo del Nord Italia, né il caldo torrido del Meridione. Sopporta senza problemi l’inquinamento urbano e l’aria salsa delle coste marine. Resiste alla siccità, anche protratta per un paio di mesi (con l’eccezione dell’anno seguente all’impianto), e alla mancanza di concime. Vive bene anche in vasi di dimensioni contenute. Preferisce la mezz’ombra e i terreni leggeri, sciolti, anche sassosi.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Arbusti
                {
                   NomeComunePianta = "BUDDLEIA",
                   NomeFamiglia = "Calicantacee",
                   NomeScientificoPianta = "Buddleja davidii",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/BUDDLEIA/Buddleia.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "UNA SPECIE CONOSCIUTA ANCHE CON IL NOME DI ALBERO DELLE FARFALLE, PERCHÉ I SUOI FIORI, RIUNITI IN VISTOSE PANNOCCHIE DI COLORE VIOLA (ROSA O BIANCHI NELLE VARIETÀ FLORICOLE) LEGGERMENTE PROFUMATE, ATTIRANO NUMEROSISSIMI DA MAGGIO AD AGOSTO QUESTI INSETTI, CHE SI NUTRONO DEL LORO NETTARE. SI UTILIZZA DA SOLA O IN GRUPPI. RAGGIUNGE I 3 M D’ALTEZZA E DI DIAMETRO, FORMANDO UNA CHIOMA LEGGERA DI FOGLIE ARGENTATE, CHE CADONO IN AUTUNNO.",
                   Coltivazione = "Resiste al freddo della Val Padana, mentre sulle Alpi va coltivata in vaso (diametro minimo 40 cm). Desidera un terreno fertile e sciolto, ben drenato. L’esposizione preferita è in pieno sole, ma può tollerare la mezz’ombra (dove fiorisce un po’ meno). Richiede molta acqua nel primo anno, poi solo durante i periodi più caldi. Va potata decisamente alla fine dell’inverno, per contenerne l’esuberanza.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Arbusti
                {
                   NomeComunePianta = "CALICANTO",
                   NomeFamiglia = "Calicantacee",
                   NomeScientificoPianta = "Callistemon citrinus",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/CALICANTO/Calicanto.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "ARBUSTO MOLTO RUSTICO, CHE RESISTE AL GELO DELLA VAL PADANA SENZA PROTEZIONI. HA LA CARATTERISTICA DI FIORIRE NEL CUORE DELL’INVERNO, TRA GENNAIO E MARZO, SUI RAMI SPOGLI. I FIORI, PICCOLI E GIALLASTRI, EMANANO UN PROFUMO DOLCISSIMO: VA PIANTATO LUNGO I VIALETTI DI PASSAGGIO, IN MODO DA GODERNE APPIENO NELLE CORTE GIORNATE INVERNALI. NEI RESTANTI MESI HA UN ASPETTO UN PO’ ANONIMO: È BENE SCHERMARLO CON ALTRI ARBUSTI CADUCIFOGLI PIÙ INTERESSANTI.",
                   Coltivazione = "Si coltiva in piena terra, su qualunque tipo di substrato, purché con un minimo di drenaggio. Desidera un’esposizione soleggiata soprattutto in autunno-inverno; a mezz’ombra fiorirà meno. Va annaffiato nella prima estate dopo l’impianto. Gradisce una concimazione organica (letame maturo o stallatico secco) in autunno e in primavera. Si può potare all’inizio della primavera, per restituire la forma al cespuglio.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Arbusti
                {
                   NomeComunePianta = "CALLISTEMON",
                   NomeFamiglia = "Mirtacee",
                   NomeScientificoPianta = "Callistemon citrinus",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/CALLISTEMON/Callistemon.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "CURIOSO CESPUGLIO DI ORIGINE AUSTRALIANA, CHIAMATO ANCHE ALBERO DEGLI SCOVOLINI, A CAUSA DEI PARTICOLARI FIORI ROSSI CHE RICHIAMANO LA FORMA DELL’OGGETTO IN QUESTIONE. LA FIORITURA SI VERIFICA TRA MAGGIO E GIUGNO E ATTIRA NUMEROSI INSETTI. RAGGIUNGE AL MASSIMO I 2 M D’ALTEZZA, MENTRE I RAMI ARCUATI OCCUPANO FINO A 2,5 M DI DIAMETRO. NE SONO STATE RICAVATE VARIETÀ FLORICOLE CON FIORI DI COLORE LILLA, GIALLO O BIANCO. SI UTILIZZA IN BORDURA CON PIANTE ERBACEE.",
                   Coltivazione = "Abbastanza sensibile al freddo, dalla Val Padana in su va coltivato in vaso grande (diametro minimo 38 cm), da riparare in inverno. Si adatta bene a qualunque tipo di suolo, tranne quelli alcalini; in vaso è bene alleggerire il substrato da giardino con torba e pomice. Desidera il pieno sole per produrre bene i fiori. Si avvantaggia di una concimazione autunnale e una primaverile con fertilizzante per acidofile.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Arbusti
                {
                   NomeComunePianta = "CAMELIA",
                   NomeFamiglia = "Teacee",
                   NomeScientificoPianta = " Camellia japonica",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/CAMELIA/Camelia.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "ACIDOFILA SEMPREVERDE, MOLTO LONGEVA (PUÒ VIVERE FINO A 200 ANNI), CHE, IN PIENA TERRA IN GIARDINO, PUÒ RAGGIUNGERE ANCHE I 7 M D’ALTEZZA. HA FOGLIE CORIACEE, PERSISTENTI, LUCIDE, COLOR VERDE SCURO. ALL’INIZIO DELLA PRIMAVERA PRODUCE GRANDI FIORI A COPPA, BIANCHI, ROSA O ROSSI, SEMPLICI, SEMIDOPPI O DOPPI A SECONDA DELLE VARIETÀ. C. SASANQUA PRODUCE, INVECE, FIORI SEMPLICI, NEGLI STESSI COLORI, LEGGERMENTE PROFUMATI, DA NOVEMBRE A GENNAIO.",
                   Coltivazione = "Resiste bene al freddo anche intenso (ma sulle Alpi è meglio coltivarla in vaso, da riparare in serra fredda) se posizionata in piena terra. Come acidofila, va posta in terriccio acido, innaffiata con acqua decalcificata e concimata con un prodotto per acidofile. Ama i climi freschi e umidi, necessita di acqua a ridosso della fioritura e in estate; va fertilizzata in atunnno e poi, nuovamente, da febbraio ad aprile.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Arbusti
                {
                   NomeComunePianta = "CEANOTO",
                   NomeFamiglia = "Ramnacee",
                   NomeScientificoPianta = "Ceanothus burkwoodii",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/CEANOTO/Ceanoto.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "ARBUSTO A CRESCITA RAPIDA, MA SENSIBILE ALL’UMIDITÀ E AL GELO. RAGGIUNGE UN’ALTEZZA MASSIMA DI 3 M E UN DIAMETRO DI 2,5 M; HA FOGLIAME MEDIAMENTE CORIACEO, SEMISEMPREVERDE. DA GIUGNO AD AGOSTO PRODUCE PANNOCCHIE DI COLORE DALL’AZZURRO AL VIOLA, DI FORMA LEGGERMENTE SFERICA O CILINDRICA. ESISTONO ALTRE SPECIE, COME C. THYRSIFLORUS, DAL PORTAMENTO PROSTRATO, ANCORA PIÙ SENSIBILE AL FREDDO, E C. DENTATUS, CARATTERIZZATO DA FOGLIE PICCOLE.",
                   Coltivazione = "Dalla Val Padana in su deve essere coltivato in vaso grande (diametro minimo 40 cm). Deve anche essere riparato dal vento freddo. Desidera un terreno ben drenato, soffice e ricco di sostanza organica. Richiede un’esposizione in pieno sole. Gradisce molte annaffiature nel primo anno dall’impianto; in seguito, basta intervenire nelle estati più calde (in piena terra). Va concimato in autunno e in primavera.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Arbusti
                {
                   NomeComunePianta = "CISTO",
                   NomeFamiglia = "Cistacee",
                   NomeScientificoPianta = "Cistus",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/CISTO/Cisto.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "AL GENERE APPARTENGONO ARBUSTI SEMPREVERDI ADATTI AL CLIMA MEDITERRANEO, SOTTO FORMA DI NUMEROSE SPECIE, TUTTE A FIORITURA ESTIVA, NEI COLORI BIANCO, ROSA, ROSSO. TRA LE SPECIE PIÙ DIFFUSE, C. ALBIDUS (FIORI ROSA CON MACCHIA GIALLA), C. LADANIFERUS (FIORI BIANCHI MACCHIATI DI PORPORA), C. MONSPELIENSIS (FIORI BIANCHI), C. SALVIFOLIUS (FIORI BIANCHI MACCHIATI DI GIALLO), C. VILLOSUS (FIORI ROSA MACCHIATI DI GIALLO). I FIORI DURANO UN GIORNO SOLO.",
                   Coltivazione = "Prediligono un substrato acido, anche sassoso e molto povero e possono essere coltivati in vaso solo se molto grande (da 50 cm di diametro in su). Tollerano i venti salmastri della riva del mare. Desiderano un’esposizione soleggiata. Vanno concimati in autunno e in primavera, con un prodotto granulare a lenta cessione per arbusti da fiore. Non necessitano di potatura, se non per eliminare i rami vecchi o rotti.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Arbusti
                {
                   NomeComunePianta = "CORBEZZOLO",
                   NomeFamiglia = "Ericaee",
                   NomeScientificoPianta = "Arbutus unedo",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/CORBEZZOLO/Corbezzolo.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "ARBUSTO MOLTO DECORATIVO, GRAZIE AL FOGLIAME SEMPREVERDE DI UN BEL COLORE VERDE TENERO, AI FIORI A FORMA DI CAMPANELLINO BIANCO RIUNITI IN MAZZETTI E AI FRUTTI TONDI DELLA GRANDEZZA DI UNA CILIEGIA, DAPPRIMA VERDI, POI GIALLI E INFINE ROSSI, CHE SPESSO COESISTONO CON I FIORI, IN AUTUNNO. SI IMPIEGA COME ESEMPLARE ISOLATO (PUÒ RAGGIUNGERE I 4-5 M D’ALTEZZA, MA LA CRESCITA È PIUTTOSTO LENTA) OPPURE COME MACCHIA COSTITUITA DA PIÙ SOGGETTI.",
                   Coltivazione = "Necessita di un substrato acido, anche non molto fertile, ma ben drenato. Può vivere in vaso purché grande (dai 50 cm in su di diametro). Resiste al gelo fino alla Val Padana; sulle Alpi è preferibile la coltivazione in vaso, oppure in posizioni molto soleggiate e perfettamente riparate dai venti freddi. Non necessita di irrigazioni (salvo il primo anno) né di potature. Può essere concimato in autunno e primavera.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Arbusti
                {
                   NomeComunePianta = "CORNUS",
                   NomeFamiglia = "Cornacee",
                   NomeScientificoPianta = "Cornus",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/CORNUS/Cornus.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "GENERE DI ARBUSTI DALLE CARATTERISTICHE PIÙ DISPARATE: C. SANGUINEA E C. ALBA SI DISTINGUE PER I RAMI ROSSI CHE SPICCANO NUDI IN INVERNO, NEL GIARDINO, C. KOUSA PRODUCE 'FIORI' (IN REALTÀ SONO BRATTEE) VISTOSI E CANDIDI, C. FLORIDA LI HA GRANDI E ROSATI, C. CANADENSIS HA PORTAMENTO TAPPEZZANTE. TUTTI HANNO FOGLIE PICCOLE E CADUCHE E, DAI FIORI, REGALANO IN AUTUNNO PICCOLI FRUTTI COLORATI E DECORATIVI. PRIMA DI CADERE, D’AUTUNNO LE FOGLIE ASSUMONO COLORI ACCESI.",
                   Coltivazione = "Tollerano il gelo anche intenso e prolungato, soprattutto se coltivati in piena terra (in vaso solo se molto grande, da 50 cm in su di diametro). Desiderano un terreno fertile e fresco, ben drenato. Amano il pieno sole e al più la mezz’ombra. Non necessitano di irrigazioni o concimazioni particolari, salvo che nel primo anno dall’impianto. La potatura si effettua solo su rami rotti o vecchi, o per ridurre l’ingombro.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Arbusti
                {
                   NomeComunePianta = "COTOGNO GIAPPONESE",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Chaenomeles japonica",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/COTOGNO GIAPPONESE/Cotogno Giapponese.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "PICCOLO ARBUSTO (AL MASSIMO 1,5 M D’ALTEZZA) CARATTERIZZATO DA RAMI CONTORTI E INTRICATI, SPINOSI, SUI QUALI, IN MARZO, COMPAIONO, PRIMA DELLA NASCITA DELLE FOGLIE, I FIORI A FORMA DI COPPA, SEMPLICI O DOPPI, NEI TONI DEL ROSA E DEL ROSSO (ESISTE ANCHE UNA VARIETÀ BIANCA). DURANTE L’ESTATE RISULTA UN PO’ ANONIMO, FINCHÉ NON SI SVILUPPANO I FRUTTI, SIMILI A PICCOLE MELE DI COLORE PRIMA VERDE E POI GIALLO. SI IMPIEGA COME ESEMPLARE ISOLATO O PER BASSE SIEPI DIFENSIVE.",
                   Coltivazione = "Resiste senza problemi a temperature molto sotto lo zero, ma non ama l’aria salmastra. Si adatta a ogni tipo di terreno, anche non molto drenato, e necessita di irrigazioni solo nel primo anno dopo l’impianto. La concimazione si riduce a un apporto primaverile e uno autunnale, con fertilizzanti organici. Ha bisogno di potature ogni primavera dopo la fioritura, per ridurre l’intrico dei rami che crescono verso l’interno.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Arbusti
                {
                   NomeComunePianta = "COTONEASTER",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Cotoneaster",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/COTONEASTER/Cotoneaster.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "GENERE DI ARBUSTI MOLTO DIVERSI A SECONDA DELLE SPECIE: POSSONO AVERE PORTAMENTO ERETTO, OPPURE PROSTRATO E TAPPEZZANTE, POSSONO ESSERE SEMPREVERDI O DECIDUI, POSSONO AVERE FOGLIE GRANDI O ANCHE MOLTO PICCOLE, POSSONO CRESCERE DA 15 CM A 3 METRI. TUTTI FIORISCONO IN MAGGIO-GIUGNO IN BIANCO E PRODUCONO, DA AGOSTO IN POI, PICCOLE BACCHE ROSSE MOLTO DECORATIVE E GRADITE AGLI UCCELLINI. SONO CARATTERIZZATI DA NUMEROSI RAMI, SPESSO INTRICATI.",
                   Coltivazione = "Resistono bene al gelo anche intenso, e al caldo (ma meno ai venti salmastri). Si adattano a qualunque tipo di terreno, anche poco drenato o pesante, e alla vita in vaso (da 35 cm di diametro in su). Non abbisognano di irrigazione se non nel primo anno dall’impianto, né di concimazioni (ma un apporto organico in autunno migliora i colori e la produzione di frutti). Vanno potati per ridurre l’intrico dei rami.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Arbusti
                {
                   NomeComunePianta = "DAFNE",
                   NomeFamiglia = "Timeleacee",
                   NomeScientificoPianta = "Daphne",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/DAFNE/Dafne.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "PICCOLI ARBUSTI (ALTI FINO A 50 CM), DA UTILIZZARE PER BORDURE BASSE E PER FIANCHEGGIARE SENTIERI E VIALETTI, O COME MACCHIE NELLE AIUOLE. HANNO CRESCITA MOLTO LENTA. IL GENERE COMPRENDE NUMEROSE SPECIE, DECIDUE O SEMPREVERDI, FRA CUI D. MEZEREUM, CHE FIORISCE IN FEBBRAIO-MARZO CON COROLLE PROFUMATE ROSA INTENSO; D. CNEORUM, TAPPEZZANTE CHE FIORISCE IN APRILE-GIUGNO; D. X BURKWOODII, CON FIORI ROSA PALLIDO IN MAGGIO-GIUGNO",
                   Coltivazione = "Resistono bene al gelo alpino, tollerano meno bene il caldo, non sopportano i venti salmastri. Si adattano a qualunque terreno, purché non arido (vanno sempre irrigate bene in estate). Prediligono un’esposizione soleggiata, o tutt’al più a mezz’ombra, per fiorire bene. Si possono concimare in autunno con un prodotto organico. Non necessitano di potature, data la lentezza di crescita, se non per eliminare rami rotti",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Arbusti
                {
                   NomeComunePianta = "DEUTZIA",
                   NomeFamiglia = "Sassifragacee",
                   NomeScientificoPianta = "Deutzia",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/DEUTZIA/Deutzia.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "ARBUSTO A FOGLIA CADUCA, RUSTICO, IDEALE COME ESEMPLARE ISOLATO O IN MACCHIE DI PIÙ SOGGETTI, O ANCHE PER SIEPI FIORITE O QUINTE. FIORISCE IN MAGGIO AMMANTANDOSI SUI RAMI DI PICCOLI MA NUMEROSISSIMI FIORI CANDIDI, PROFUMATI, IN INFIORESCENZE ALLUNGATE. SI RICORDANO, TRA LE SPECIE, D. GRACILIS CON FIORI PROFUMATI; D. X KALMIIFLORA CON FIORI A FORMA DI STELLA BIANCHI E ROSA; D. X ROSEA DI TAGLIA NANA, CON FIORI BIANCO-ROSATI A FORMA CAMPANULATA.",
                   Coltivazione = "Resiste bene al freddo, anche molto intenso, e al caldo. Si adatta a ogni tipo di terreno, pure povero (ma in questo caso va concimato almeno in autunno, con un prodotto di natura organica). Desidera un’esposizione soleggiata, ma tollera la mezz’ombra (dove però fiorisce meno). Va irrigata nel primo anno dopo l’impianto. Deve essere potata drasticamente subito dopo la fioritura, per contenerne lo sviluppo.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                 new Arbusti
                {
                   NomeComunePianta = "ELEAGNO",
                   NomeFamiglia = "Oleacee",
                   NomeScientificoPianta = "Elaeagnus",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/ELEAGNO/Eleagno.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "GENERE MOLTO UTILIZZATO AI FINI DECORATIVI, PERCHÉ COMPRENDE NUMEROSE SPECIE DALLE CARATTERISTICHE DIVERSIFICATE: SEMPREVERDI O DECIDUE, SPINOSE O INERMI, CON FOGLIE VERDI O SCREZIATE, A PORTAMENTO ERETTO O PROSTRATO/RICADENTE. E. X REFLEXA HA LUNGHI RAMI FLESSIBILI, RICADENTI E QUASI TAPPEZZANTI; E. PUNGENS, SPINOSO, HA FOGLIAME SEMPREVERDE VARIEGATO, MOLTO ORNAMENTALE IN INVERNO; E. X EBBINGEI È VIGOROSO E DI RAPIDA CRESCITA, IDEALE PER SIEPI FITTE.",
                   Coltivazione = "Si tratta di arbusti che non temono il freddo, se coltivati in piena terra (in vaso vanno coperti con un telo), ma poco resistenti al caldo e all’aria salmastra. Sopportano ogni tipo di terreno, anche pesante e poco drenato. Amano il pieno sole (a mezz’ombra la fioritura e i colori del fogliame perdono molto), ma devono essere protetti dai venti freddi. Non necessitano d’acqua, dopo il primo anno dall’impianto.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                 new Arbusti
                {
                   NomeComunePianta = "ESCALLONIA",
                   NomeFamiglia = "Escalloniacee",
                   NomeScientificoPianta = "Escallonia rubra",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/ESCALLONIA/Escallonia.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "QUESTO ARBUSTO SEMPREVERDE SI CARATTERIZZA PER LA CHIOMA ARROTONDATA, FORMATA DA FOGLIE LUCIDE, AROMATICHE, PICCOLE, LANCEOLATE, DENTATE. MOLTO VIGOROSO, IN GIUGNO-LUGLIO SI RIEMPIE DI PICCOLI FIORI TUBULOSI, RIUNITI IN PANNOCCHIE, DI COLORE ROSSO VIVO (MA BIANCO O ROSA NELLE VARIETÀ). POICHÉ TOLLERA I VENTI SALMASTRI E IL CALDO TORRIDO, È IDEALE AL MARE, SIA COME ESEMPLARE ISOLATO, SIA IN MACCHIE COLORATE, SIA SOPRATTUTTO PER SIEPI FRANGIVENTO.",
                   Coltivazione = "Non resiste al freddo della Val Padana, dove deve essere coltivato solo in vaso (diametro minimo 40 cm), mentre è ideale in piena terra nel Centro-Sud. Cresce bene in qualunque terreno ben drenato, anche se argilloso. Desidera l’esposizione in pieno sole. Trascorso il primo anno dall’impianto, in giardino non sono più necessarie le annaffiature (in vaso è bene bagnare durante l’estate). Non necessita di potature.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                 new Arbusti
                {
                   NomeComunePianta = "FILADELFO",
                   NomeFamiglia = "Sassifragacee",
                   NomeScientificoPianta = " Philadelphus coronarius",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/FILADELFO/Filadelfo.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "CHIAMATO ANCHE FIOR D’ANGELO O FIORRANCIO, È UN ARBUSTO DECIDUO DALLE RAMIFICAZIONI ERETTE O LEGGERMENTE RICURVE, CON FOGLIE OVALI DALLE NERVATURE MOLTO EVIDENTI, DI COLOR VERDE SCURO. IN MAGGIO SI AMMANTA DI GRANDI FIORI BIANCHI, RIUNITI IN INFIORESCENZE TERMINALI O ALL’ASCELLA DELLE FOGLIE, DAL PROFUMO INTENSO E FIORITO. SI IMPIEGA COME SINGOLO ESEMPLARE AL CENTRO DELL’AIUOLA, MA ANCHE COME MACCHIA E PER SIEPI DI BORDURA.",
                   Coltivazione = "Resiste senza problemi a temperature molto basse sotto lo zero, anche sull’arco alpino. Si trova a suo agio su qualunque terreno, anche argilloso, povero, sassoso o calcareo. Predilige l’esposizione in pieno sole, dove la fioritura sarà più ricca. Va annaffiato solo nel primo anno dopo l’impianto. Si concima in autunno e in primavera, con un fertilizzante organico. Le potature non sono necessarie.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                 new Arbusti
                {
                   NomeComunePianta = "FORSIZIA",
                   NomeFamiglia = "Oleacee",
                   NomeScientificoPianta = "Forsythia x intermedia",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/FORSIZIA/Forsizia.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "LA SUA FIORITURA, TRA FEBBRAIO E MARZO, PREANNUNCIA IN ANTICIPO IL RITORNO DELLA PRIMAVERA: SI RIEMPIE DI FIORI GIALLI, CHE SBOCCIANO SUI RAMI ANCORA NUDI, QUANDO QUASI TUTTI GLI ALTRI ARBUSTI SONO ANCORA ADDORMENTATI. IN SEGUITO, SPUNTANO LE FOGLIE, PICCOLE E LANCEOLATE, E L’ARBUSTO DIVENTA UN PO’ ANONIMO. È CONSIGLIABILE, DA SOLO O IN GRUPPI, IN POSIZIONI DA DOVE SIA VISIBILE DALL’ABITAZIONE IN INVERNO, MA VENGA POI NASCOSTO DA ALTRE PIANTE IN ESTATE.",
                   Coltivazione = "Facilissima da coltivare, resiste al gelo intenso e al caldo torrido, ai venti freddi o salmastri, e perfino all’inquinamento urbano. Vive bene su qualunque tipo di terreno, anche non perfettamente drenato o argilloso. Vuole acqua solo nel primo anno dall’impianto e può vivere in un vaso grande (minimo 50 cm di diametro). Si giova di un po’ di concime organico in autunno. Si pota subito dopo la fioritura.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                 new Arbusti
                {
                   NomeComunePianta = "FOTINIA",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Photinia x fraseri",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/FOTINIA/Fotinia.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "È UN ARBUSTO CHE SI È MOLTO DIFFUSO NELL’ULTIMO DECENNIO, QUANDO È STATO IMPIEGATO PREVALENTEMENTE COME SIEPE, GRAZIE AL FOGLIAME NUOVO CHE, IN PRIMAVERA, SI TINGE DI UN SINGOLARE ROSSO PORPORA. ALL’INIZIO DEL SECOLO SCORSO ERA INVECE UTILIZZATO COME ALBERO, FORMA ANCORA VISIBILE (E SPETTACOLARE) IN ALCUNI GIARDINI STORICI. IN MAGGIO OFFRE ANCHE UN’AROMATICA FIORITURA COLOR BIANCO CREMA, MOLTO GRADITA ALLE API. È UNA SPECIE SEMPREVERDE.",
                   Coltivazione = "Resiste al freddo della Val Padana e al caldo torrido. Non ha particolari esigenze in fatto di terreno, anche se preferisce suoli piuttosto drenati. La collocazione al sole, oltre ad assicurare la fioritura, favorisce la colorazione rossa del fogliame. Per ottenere un secondo arrossamento durante la stagione, è bene potare la pianta nel mese di giugno. Riguardo all’acqua e al concime non avanza specifiche richieste.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                 new Arbusti
                {
                   NomeComunePianta = "GINEPRO",
                   NomeFamiglia = "Cipressacee",
                   NomeScientificoPianta = "Juniperus communis",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/GINEPRO/Ginepro.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "SEMPREVERDE APPARTENENTE AL GRUPPO DELLE CONIFERE, È CARATTERIZZATA DA CORTI AGHI APPUNTITI RIUNITI IN FASCETTI DI 3. PIANTA DIOICA, HA ESEMPLARI MASCHILI E SOGGETTI FEMMINILI, CHE PORTANO I FRUTTI. QUESTI SONO PICCOLI CONI VERDI CHE MATURANO NELL’ARCO DI 3 ANNI, DIVENENDO BLU E POI NERI. I FRUTTI, CHE SI CHIAMANO GALBULI, SONO UTILIZZATI IN CUCINA PER AROMATIZZARE CARNI E LIQUORI. SI IMPIEGA COME SINGOLO ESEMPLARE O PER SIEPI DIFENSIVE (SPINOSE).",
                   Coltivazione = "J. communis è tipico dell’arco alpino, mentre nel Sud si trovano J. oxycedrus e J. phoeniceus, che crescono spontaneamente anche nei pressi delle rive del mare. Prediligono un terreno leggermente acido, sciolto, ben drenato. Non necessitano di annaffiature, dopo i primi mesi dall’impianto. L’esposizione è abbastanza indifferente, così come la concimazione. Si può spuntare leggermente per eliminare i rami secchi.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                 new Arbusti
                {
                   NomeComunePianta = "GINESTRE",
                   NomeFamiglia = "Leguminose",
                   NomeScientificoPianta = "Genista, Spartium, Cytisus, Coronilla, Ulex",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/GINESTRE/Ginestre.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "TUTTE LE GINESTRE SONO PIANTE ROBUSTE E RUSTICHE, ADATTE COME SINGOLI ESEMPLARI, COME MACCHIE, COME BORDURA E SOPRATTUTTO SULLE SCARPATE, DOVE CONSOLIDANO IL TERRENO CON LE ROBUSTE RADICI. SONO ARBUSTI BASSI (MASSIMO 2 M D’ALTEZZA), FITTAMENTE RAMIFICATI, CON RAMI DI COLORE VERDE, SUI QUALI IN MAGGIO-LUGLIO SBOCCIANO I FIORI, DI COLORE GIALLO INTENSO (ESISTONO VARIETÀ A FIORE BIANCO), IN MEZZO ALLE FOGLIE PICCOLE, ADERENTI AI RAMI E CADUCHE IN AUTUNNO.",
                   Coltivazione = "Temono il gelo e amano il pieno sole per fiorire bene. Non necessitano di concime (ricavano azoto dall’aria tramite le radici), né di annaffiature (salvo i primi mesi dall’impianto), né di potature (lo sviluppo è sempre contenuto). Genista ama i suoli acidi, mentre le altre specie preferiscono terreni alcalini; tutte desiderano un buon drenaggio. Il genere Ulex comprende arbusti spinosi, da impiegare anche come siepe difensiva.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                 new Arbusti
                {
                   NomeComunePianta = "HEBE",
                   NomeFamiglia = "Scrofulariacee",
                   NomeScientificoPianta = "Hebe",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/Hebe/HEBE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "ARBUSTO SEMPREVERDE CHE FORMA PICCOLI CESPUGLI TONDEGGIANTI (ALTEZZA MASSIMA 1,5 M), RICCHI DI FOGLIE OVALI, COLOR GRIGIO-VERDE, MA PIÙ FREQUENTEMENTE VARIEGATE DI GIALLO O DI BIANCO NELLE VARIETÀ. IN ESTATE PRODUCE LUNGHE SPIGHE DI FIORELLINI DI COLORE DAL BIANCO AL VIOLA, CHE SORGONO DAL FOGLIAME; ALCUNE SPECIE REGALANO UNA SECONDA FIORITURA DURANTE I MESI AUTUNNO-INVERNALI. SI UTILIZZA PER BORDURE DI VIALETTI O PICCOLE MACCHIE.",
                   Coltivazione = "Tollera il freddo della Val Padana se è collocata in una posizione protetta dai venti e ben soleggiata, oppure se il vaso viene protetto con teli di non tessuto. Preferisce suoli sciolti, leggeri e ben drenati, ma si adatta anche a quelli argillosi. Al sole la fioritura è garantita. Necessita di acqua solo dopo l’impianto e se viene coltivata in contenitore. Dopo la fioritura è bene spuntare i rami per mantenere la forma compatta.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                 new Arbusti
                {
                   NomeComunePianta = "IBISCO",
                   NomeFamiglia = "Malvacee",
                   NomeScientificoPianta = "Hibiscus syriacus",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/IBISCO/Ibisco.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "ROBUSTO CADUCIFOGLIO MOLTO RUSTICO E VERSATILE: SI UTILIZZA AD ALBERELLO COME ESEMPLARE ISOLATO O IN FILARE LUNGO IL VIALETTO O LA RECINZIONE, E COME CESPUGLIO IN FORMA SINGOLA, IN MACCHIA O PER SIEPI. SUO GRANDE PREGIO È LA FIORITURA IN LUGLIO-SETTEMBRE, QUANDO POCHI ALTRI ARBUSTI SONO IN FIORE: LE COROLLE GRANDI SONO BIANCHE, ROSA, BLU O VIOLA E VENGONO PRODOTTE IN ABBONDANZA E SENZA SOSTA. PUÒ RAGGIUNGERE I 3 M D’ALTEZZA.",
                   Coltivazione = "Non ha problemi sulle Alpi né al mare, non lo scalfiscono i venti freddi né quelli salmastri. Predilige però suoli profondi e freschi, comunque ben drenati. Ama il sole, per poter fiorire bene e a lungo. Va concimato con prodotti organici in autunno, primavera e all’inizio dell’estate. Si annaffia solo nel primo anno dopo l’impianto. Ha una minore resa se coltivato in vaso (molto grande, minimo 50 cm di diametro). Tollera le potature.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                 new Arbusti
                {
                   NomeComunePianta = "IPERICO",
                   NomeFamiglia = "Guttacee",
                   NomeScientificoPianta = "Hypericum calycinum",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/IPERICO/Iperico.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "BEL CESPUGLIO DI ALTEZZA CONTENUTA (MASSIMO 1,5 M), MA TENDENTE A CRESCERE IN DIAMETRO (FINO A 3 M), CON FOGLIAME PERSISTENTE, OVATO, LEGGERMENTE CORIACEO. DA GIUGNO A SETTEMBRE SI RIEMPIE DI COROLLE COLOR GIALLO INTENSO, CON AL CENTRO UN CARATTERISTICO CIUFFO DI STAMI, DI MEDIE DIMENSIONI. POSSONO SEGUIRE FRUTTI DI COLORE PRIMA VERDE E POI ROSSO. SI UTILIZZA IN GENERE COME SINGOLO ESEMPLARE AL CENTRO DI UN’AIUOLA, O IN MACCHIE BASSE.",
                   Coltivazione = "Resiste al gelo come alla calura più spinta, ai venti freddi e a quelli marini carichi di sale. Per fiorire bene, necessita di una posizione soleggiata. Il terreno deve essere preferibilmente profondo e fresco, fertile e possibilmente un po’ acido. Abbisogna d’acqua nel primo anno dall’impianto e in caso di estati particolarmente asciutte. Può vivere in vaso (diametro minimo 35 cm). Si pota in inverno, solo per ridurne l’ingombro",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                 new Arbusti
                {
                   NomeComunePianta = "KALMIA",
                   NomeFamiglia = "Ericacee",
                   NomeScientificoPianta = "Kalmia angustifolia",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/KALMIA/Kalmia.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "ACIDOFILA DIFFUSA COME PIANTA DA VASO, VIVE BENE ANCHE IN GIARDINO, FORMANDO BORDURE O PICCOLE MACCHIE: IL CESPUGLIO SEMPREVERDE RAGGIUNGE AL MASSIMO 1,20 M D’ALTEZZA. DA MAGGIO FINO A LUGLIO PRODUCE FIORI RIUNITI IN INFIORESCENZE A OMBRELLO, TONDEGGIANTI O APPIATTITE, ALL’APICE DEI RAMI, DI COLORE BIANCO O ROSA. ESISTONO ANCHE VARIETÀ DAI FIORI PARTICOLARMENTE GRANDI O IN SFUMATURE CROMATICHE DEI TONI PRINCIPALI O VARIEGATI.",
                   Coltivazione = "Resiste al freddo, un po’ meno al caldo. Essendo un’acidofila, desidera un terreno acido, un’annaffiatura con acqua decalcificata e un concime specifico per questa categoria di piante. Predilige un’esposizione a mezz’ombra, comunque senza raggi diretti nelle ore centrali delle giornate estive. Il terreno deve sempre essere mantenuto fresco e umido, in particolare durante l’estate. Si fertilizza in primavera e in autunno.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                 new Arbusti
                {
                   NomeComunePianta = "KERRIA",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Kerria japonica",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/KERRIA/Kerria.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "INDISTRUTTIBILE ARBUSTO CADUCIFOGLIO DAI FUSTI VERDI, PRIVO DI RAMIFICAZIONI MA FACILE A EMETTERE POLLONI RADICALI, ANCHE A MOLTA DISTANZA DAL CEPPO. IL PORTAMENTO È LEGGERO E ARCUATO. SI UTILIZZA PER SIEPI E MACCHIE. LE FOGLIE, CHE HANNO COLORE VERDE TENERO, SONO LANCEOLATE CON MARGINE SEGHETTATO. IN APRILE-MAGGIO REGALA ABBONDANTI COROLLE GIALLE, SEMPLICI, SEMIDOPPIE O DOPPIE A SECONDA DELLA VARIETÀ; IN AGOSTO-SETTEMBRE OFFRE UNA SECONDA PICCOLA FIORITURA.",
                   Coltivazione = "Non teme il caldo torrido né il gelo intenso, i venti freddi e quelli marini, la mancanza d’acqua (salvo che nel primo anno dopo l’impianto) e di concime (fiorisce comunque, basta che sia posizionato in luogo soleggiato). Resiste su ogni tipo di terreno, anche sciolto o pesante. Tollera le potature, necessarie in autunno per ridurne l’ingombro notevole dovuto alla veloce crescita. Inadatto alla vita in vaso.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                 new Arbusti
                {
                   NomeComunePianta = "LAUROCERASO",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Prunus laurocerasus",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/LAUROCERASO/Lauroceraso.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "DIFFUSISSIMO ARBUSTO DA SIEPE, APPREZZATO PER LA SUA ROBUSTEZZA E VERSATILITÀ. OLTRE CHE PER RECINZIONI E BORDURE DI VIALETTI, SI PUÒ UTILIZZARE, ALLEVANDOLO AD ALBERO, COME SINGOLO ESEMPLARE IN UN PUNTO FOCALE (PUÒ RAGGIUNGERE I 10 M D’ALTEZZA). LE FOGLIE PERSISTENTI SONO GRANDI, LANCEOLATE, LUCIDE, CORIACEE. IN APRILE-MAGGIO FIORISCE IN BIANCO CREMA, CON COROLLE RIUNITE IN INFIORESCENZE A GRAPPOLO ERETTE VERSO L’ALTO, ODOROSE. SEGUONO LE BACCHE NERE.",
                   Coltivazione = "Tollera il gelo e il calore del Sud, ogni tipo di vento (ma è preferibile limitare quello salmastro) e la mancanza d’acqua (ma solo dopo almeno un anno dall’impianto). Al sole fiorisce, ma vive anche all’ombra. Gradisce una manciata di fertilizzante a lunga cessione per arbusti in autunno e in primavera. Sopporta le potature, anche ripetute, a patto di non usare la tosasiepi, che taglia a metà le foglie, esponendole a malattie.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                 new Arbusti
                {
                   NomeComunePianta = "LIGUSTRO",
                   NomeFamiglia = "Oleacee",
                   NomeScientificoPianta = "Ligustrum",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/LIGUSTRO/Ligustro.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "NUMEROSE SONO LE SPECIE E VARIETÀ DI LIGUSTRO UTILIZZATE IN GIARDINO: L. LUCIDUM HA FOGLIE GRANDI E VIENE IN GENERE ALLEVATO AD ALBERELLO; L. OVALIFOLIUM È IL PREDILETTO PER SIEPI, L. VULGARE SI IMPIEGA PER BASSE BORDURE. SI TRATTA DI SPECIE A FOGLIA PERSISTENTE O SEMIPERSISTENTE CHE, TRA APRILE E GIUGNO, FIORISCONO MINUTE COROLLE RIUNITE IN GRAPPOLI ODOROSISSIMI. ESISTONO ANCHE SPECIE E VARIETÀ CON FOGLIE VARIEGATE DI GIALLO O DI BIANCO, BISOGNOSE DI LUCE.",
                   Coltivazione = "Si adatta bene a qualsiasi tipo di terreno, anche compatto o povero e sassoso, ma gradisce una concimazione autunnale e primaverile con letame maturo o un prodotto granulare a lenta cessione. Dopo il primo anno, si diradano le annaffiature ma non si sospendono mai del tutto. Gli esemplari da siepe si potano 3-4 volte l’anno (febbraio, aprile, luglio, ottobre); quelli ad alberetto si riformano se necessario, a fine inverno.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                 new Arbusti
                {
                   NomeComunePianta = "LILLA'",
                   NomeFamiglia = "Oleacee",
                   NomeScientificoPianta = "Syringa vulgaris",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/Lillà/LILLA'.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "ARBUSTO CADUCIFOGLIO MOLTO UTILIZZATO NEL PERIODO LIBERTY (INIZIO NOVECENTO) E OGGI NUOVAMENTE DI MODA, GRAZIE ALLE NUMEROSE VARIETÀ ELABORATE DAI FLORICOLTORI, IN GRADO DI FIORIRE NON SOLO NEL COLOR LILLÀ, MA ANCHE IN BIANCO, ROSA, FUCSIA, PORPORA E BLU, ANCHE CON PETALI VARIEGATI, SEMPRE RIUNITI IN VISTOSE PANNOCCHIE. LE FOGLIE SONO CUORIFORMI, LEGGERE, COLOR VERDE BRILLANTE. SI UTILIZZA DA SOLO O IN MACCHIE, O ANCHE PER SIEPI FIORITE.",
                   Coltivazione = "Resiste bene alle temperature sotto lo zero (pure sull’arco alpino), ma anche al mare, esposto ai venti salmastri. Preferisce terreni fertili, leggermente pesanti, ma vive anche in suoli sciolti e sassosi. Necessita di una posizione ben soleggiata per fiorire bene. Per tutta la vita ha bisogno di irrigazioni di soccorso in estate, se non piove. Gradisce un apporto di letame in autunno e primavera. Va spuntato dopo la fioritura.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                 new Arbusti
                {
                   NomeComunePianta = "MAGGIOCIONDOLO",
                   NomeFamiglia = "Leguminose",
                   NomeScientificoPianta = "Laburnum anagyroides",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/Maggiociondolo/MAGGIOCIONDOLO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "BELL’ARBUSTO LEGGERO, DAI LUNGHI RAMI ARCUATI E FLESSIBILI, COPERTI DA FOGLIE TRIFOGLIATE LEGGERMENTE ARGENTATE. TRA APRILE E MAGGIO PRODUCE LUNGHI GRAPPOLI DI FIORI GIALLI, MOLTO VISTOSI E APPENA PROFUMATI, A CUI SEGUONO I BACCELLI IN ESTATE. DÀ IL MEGLIO DI SÉ COME ESEMPLARE ISOLATO, ALLEVATO AD ALBERETTO O SOTTO FORMA DI MACCHIA, MA ANCHE SU PERGOLE E ARCHI. RAGGIUNGE UN’ALTEZZA MASSIMA DI 2,5 M; ESISTONO VARIETÀ A FOGLIE DORATE O A FIORITURA AUTUNNALE.",
                   Coltivazione = "Preferisce i climi freschi, ma può resistere anche al mare, in posizione ventilata. Gradisce un suolo fresco e fertile, ma si adatta anche ad altre situazioni. Non necessita di concimazione perché, come tutte le leguminose, è in grado di utilizzare l’azoto atmosferico. Va annaffiato nel primo anno dopo l’impianto. Non abbisogna di potature, salvo che per la rimonda e per restituire la forma al cespuglio.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                 new Arbusti
                {
                   NomeComunePianta = "MAHONIA",
                   NomeFamiglia = "Berberidacee",
                   NomeScientificoPianta = "Mahonia aquifolium",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/Mahonia/MAHONIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "ARBUSTO ORNAMENTALE SEMPREVERDE, BEN RAMIFICATO SIN DALLA BASE MA DI DIMENSIONI ABBASTANZA CONTENUTE, SOPRATTUTTO IN ALTEZZA (AL MASSIMO 1,80 M). POSSIEDE FOGLIE CORIACEE MUNITE DI SPINE LUNGO I MARGINI, DI COLORE CANGIANTE DURANTE LE STAGIONI, DAL VERDE GLAUCO AL VERDE SCURO, FINO AL ROSSO PORPORA IN AUTUNNO (VARIETÀ ATROPURPUREA). PRODUCE TRA GENNAIO E APRILE PICCOLE MA NUMEROSE PANNOCCHIE DI FIORI GIALLI PROFUMATISSIMI, MOLTO AMATI DALLE API",
                   Coltivazione = "Non teme il freddo ed è coltivabile in piena terra o in un vaso molto grande (diametro minimo 50 cm). Preferisce un terreno fertile e ben drenato, meglio se leggermente acido. L’esposizione a mezz’ombra garantisce la massima fioritura. Le annaffiature sono necessarie solo nel primo periodo dopo l’impianto. Gradisce un po’ di concime organico somministrato in autunno e dopo la fioritura. Non necessita di potatura.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                 new Arbusti
                {
                   NomeComunePianta = "NANDINA",
                   NomeFamiglia = "Berberidacee",
                   NomeScientificoPianta = "Nandina domestica",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/Nandina/NANDINA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "ARBUSTO SEMPREVERDE CARATTERIZZATO DA UN PORTAMENTO LEGGERO E AGGRAZIATO, DATO DAI LUNGHI RAMI CHE PARTONO DALLA BASE, DENSI DI FOGLIOLINE DI UN VERDE INTENSO CHE PUÒ DIVENIRE ROSSO NELLA VARIETÀ ATROPURPUREA. IN MAGGIO PRODUCE GRAPPOLI DI FIORELLINI BIANCO CREMA, NON PARTICOLARMENTE VISTOSI, DAI QUALI SI SVILUPPANO IN ESTATE-AUTUNNO ABBONDANTI BACCHE DI COLORE SCARLATTO, CHE PERDURANO FINO A PRIMAVERA, SE NON VENGONO DIVORATE DAGLI UCCELLINI.",
                   Coltivazione = "Pianta che sopporta il freddo (meno tollerante al caldo torrido), ama terreni leggermente acidi, freschi, profondi, meglio se anche fertili. Può vivere in vaso, purché grande (dai 35 cm di diametro in su). Si trova bene in pieno sole come in mezz’ombra. Necessita di un substrato sempre appena umido, soprattutto in piena estate. Gradisce una concimazione organica o granulare in autunno e in primavera.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                 new Arbusti
                {
                   NomeComunePianta = "OLEANDRO",
                   NomeFamiglia = "Apocinacee",
                   NomeScientificoPianta = "Nerium oleander",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/Oleandro/OLEANDRO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "VERSATILE SEMPREVERDE IN GRADO DI RENDERE BENE IN MOLTEPLICI SITUAZIONI: IN VASO O PIENA TERRA, A CESPUGLIO O AD ALBERETTO, COME ESEMPLARE SINGOLO, IN MACCHIA O IN SIEPE, PERFINO COME ARREDO DA SPARTITRAFFICO SU STRADE E AUTOSTRADE, IN CITTÀ, AL MARE E IN MONTAGNA. DOTATO DI RAMI LUNGHI ED ELASTICI, ORNATI DA FOGLIE LANCEOLATE E CORIACEE, FIORISCE TRA MAGGIO E SETTEMBRE CON COROLLE SEMPLICI, SEMIDOPPIE O DOPPIE, BIANCHE, GIALLE, ROSA, ROSSE.",
                   Coltivazione = "Sopporta temperature di –5/–8 °C, soprattutto in piena terra e con una protezione di tessuto non tessuto: su Prealpi e Alpi è invece consigliabile coltivarlo in vaso, da ritirare in serra fredda d’inverno. Per fiorire necessita del pieno sole. Il substrato è indifferente (è migliore quello sciolto). Le annaffiature servono solo subito dopo l’impianto, oppure in vaso in estate. Necessario concimare con prodotti a lenta cessione.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                 new Arbusti
                {
                   NomeComunePianta = "ORTENSIA",
                   NomeFamiglia = "Idrangeacee",
                   NomeScientificoPianta = "Hydrangea macrophylla",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/Ortensia/ORTENSIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "LA CLASSICA ORTENSIA DALLE GRANDI INFIORESCENZE ROSA, AZZURRE, VIOLA O BIANCHE È OGGI AFFIANCATA DA ALTRE SPECIE E VARIETÀ DIVENUTE PIUTTOSTO DIFFUSE: LA LACECAP CON INFIORESCENZE SIMILI A PIZZI; H. ARBORESCENS CON FIORI CANDIDI IN CORIMBI PIATTI; H. QUERCIFOLIA DAL FOGLIAME COLORATO E INCISO ECC. ARBUSTO CADUCIFOGLIO, FIORISCE TRA MAGGIO E LUGLIO (ANCHE OLTRE ALTRE SPECIE) E LE INFIORESCENZE RISULTANO DECORATIVE ANCHE UNA VOLTA SECCATESI SUI RAMI.",
                   Coltivazione = "Non teme il freddo, anche intenso, ma fatica a tollerare il caldo torrido: in estate deve essere aiutata con generose irrigazioni. Non ama il pieno sole, preferendo la mezz’ombra o l’ombra. Desidera un substrato profondo e fresco, ben drenato e sempre appena umido. Va concimata con prodotti per piante da fiore, meglio se specifici per ortensie: alcuni conferiscono anche il colore blu che si perde su terra calcarea.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                 new Arbusti
                {
                   NomeComunePianta = "OSMANTHUS",
                   NomeFamiglia = "Oleacee",
                   NomeScientificoPianta = "Osmanthus fragrans",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/Osmanthus/OSMANTHUS.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "SEMPREVERDE CARATTERIZZATO DA UNA CRESCITA MOLTO LENTA (E DA GRANDE LONGEVITÀ) CHE PUÒ PORTARE L’ARBUSTO A UN’ALTEZZA DI 4-6 METRI. BEN RAMIFICATO, È COPERTO DA FOGLIE DI COLORE VERDE SCURO, CORIACEE, MUNITE DI CORTE SPINE SUI MARGINI. IN SETTEMBRE-OTTOBRE PRODUCE MINUSCOLI FIORI BIANCHI, DIRETTAMENTE SUI RAMI, DAL PROFUMO DOLCISSIMO CHE ATTIRA LE API. IDEALE COME ESEMPLARE SINGOLO AD ALBERETTO, IN MACCHIE, PER BORDURE O PER SIEPI.",
                   Coltivazione = "Resiste a temperature di poco sotto lo zero, a patto di collocarlo in posizione riparata dai venti freddi. Nelle zone più gelide è preferibile coltivarlo in vaso (grande, dai 35 cm di diametro in su) da riparare in serra fredda. Preferisce posizioni al sole o a mezz’ombra, e terreni freschi e profondi, ben drenati. Va annaffiato nel primo periodo dopo l’impianto e concimato in autunno e in primavera. Non ama le potature.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                 new Arbusti
                {
                   NomeComunePianta = "PEONIA",
                   NomeFamiglia = "Peoniacee",
                   NomeScientificoPianta = "Paeonia suffruticosa, P. lactiflora",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/Peonia/PEONIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "P. SUFFRUTICOSA È LA COSIDDETTA PEONIA ARBOREA, P. LACTIFLORA QUELLA ERBACEA: LA PRIMA MANTIENE LA PARTE AEREA LEGNOSA ANCHE IN INVERNO, PUR PERDENDO LE FOGLIE; LA SECONDA MUORE NELLA COMPONENTE AEREA, CHE VIE NE RIPRODOTTA IN PRIMAVERA. ENTRAMBE SONO MUNITE DI FOGLIE GRANDI E FRASTAGLIATE, E TRA APRILE E MAGGIO PRODUCONO GLI SPETTACOLARI FIORI, SEMPLICI O DOPPI, BIANCHI, GIALLI, ROSA, ROSSI O PORPORA, SPESSO PROFUMATI (SOPRATTUTTO NELLE ARBOREE).",
                   Coltivazione = "Tollerano temperature molto rigide sotto lo zero, così come lunghe estati calde. Necessitano di un substrato fresco e profondo, fertile, leggermente torboso (non alcalino). Preferiscono il pieno sole o, al massimo, una leggera ombra. Per una buona fioritura è bene concimarle con prodotti organici o granulari in autunno e in primavera. La peonia erbacea non abbisogna di potature, quella arborea per ridurre la forma.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                 new Arbusti
                {
                   NomeComunePianta = "PIERIS",
                   NomeFamiglia = "Ericacee",
                   NomeScientificoPianta = "Pieris japonica",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/Pieris/PIERIS.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "CHIAMATA ANCHE ANDROMEDA, È UN ARBUSTO SEMPREVERDE COLTIVATO PER IL FOGLIAME, MOLTO ORNAMENTALE DA GIOVANE, CHE ESIBISCE ACCESE TONALITÀ ROSSO-FUCSIA E RAME PRIMA DI ASSUMERE IL VERDE INTENSO DEFINITIVO DELLE FOGLIE ADULTE. IN APRILE-MAGGIO PRODUCE GRAZIOSI FIORELLINI CAMPANULATI, BIANCHI, RIUNITI IN PANNOCCHIE, CHE SI FORMANO GIÀ IN AUTUNNO MA, IN CLIMI FREDDI, RIMANGONO CHIUSI PER TUTTO L’INVERNO. RENDE BENE DA SOLA O IN BORDURE.",
                   Coltivazione = "Sopporta i rigori degli inverni alpini, in piena terra, mentre in vaso è bene venga ricoverata in serra fredda. È un’acidofila: desidera quindi terreno acido, acqua decalcificata e concime specifico per questa categoria di piante. La distribuzione del fertilizzante deve avvenire in settembre e in aprile. In genere non servono le potature, dato che si tratta di un arbusto a crescita molto lenta; vanno però tolte le infioorescenze appassite.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                 new Arbusti
                {
                   NomeComunePianta = "PIRACANTA",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Pyracantha coccinea",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/Piracanta/PIRACANTA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "TIPICO ARBUSTO DA SIEPE, UTILIZZATO SIA PER LE VIRTÙ ORNAMENTALI SIA PER QUELLE DIFENSIVE. GLI INTRICATI RAMI SONO INFATTI MUNITI DI ROBUSTE SPINE. LE FOGLIE SEMPREVERDI SONO PICCOLE E ARROTONDATE ALL’APICE. IN MAGGIO COMPAIONO LE INFIORESCENZE A CORIMBO, DATE DA PICCOLI FIORI BIANCO CREMA, INTENSAMENTE ODOROSI. DA ESSI SCATURISCONO, DA AGOSTO IN POI, GRUPPI DI BACCHE ROSSE (ARANCIO O GIALLE NELLE VARIETÀ FLORICOLE), PERSISTENTI PER TUTTO L’INVERNO.",
                   Coltivazione = "Robusto e rustico, resiste al gelo più intenso e al caldo più afoso. Non ha preferenze in fatto di terreno, anche se un suolo fresco e fertile è gradito. In pieno sole fiorisce in abbondanza, cosa che non avviene all’ombra. Le annaffiature servono solo all’impianto. Le concimazioni si riducono a un po’ di letame in autunno. È bene non potare l’esemplare prima della fioritura, per non privarsi delle bacche autunnali.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                 new Arbusti
                {
                   NomeComunePianta = "PITTOSFORO",
                   NomeFamiglia = "Passifloracee",
                   NomeScientificoPianta = "Pittosporum tobira",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/Pittosforo/PITTOSFORO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "ELEGANTE SEMPREVERDE MOLTO UTILIZZATO PER SIEPI COMPATTE, MA ANCHE PER RICAVARNE ALBERETTI CHE, NEI DECENNI, PRODUCONO RAMI DALLE FORME CONTORTE, MA CERTAMENTE ASSAI DECORATIVE. È CARATTERIZZATO DA FOGLIE CORIACEE, OVALI CON APICE ARROTONDATO, MOLTO LUCIDE, COLOR VERDE BRILLANTE. IN MAGGIO SI RIEMPIE DI FIORELLINI CANDIDI RIUNITI IN INFIORESCENZE A OMBRELLO, PROFUMATISSIMI. DA ESSI SI SVILUPPANO IN ESTATE I FRUTTICINI DI COLORE VERDE.",
                   Coltivazione = "Resiste a temperature di poco sotto lo zero, mentre tollera senza problemi il caldo estivo, il pieno sole e i venti salmastri anche forti. Preferisce un terreno sciolto, ben drenato, moderatamente fertile. Va annaffiato solo nei primi tempi dopo l’impianto. La concimazione può essere effeettuata con sostanze organiche in autunno. Sopporta di buon grado ogni genere di potatura, anche molto drastica.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                 new Arbusti
                {
                   NomeComunePianta = "PLUMBAGO",
                   NomeFamiglia = "Plumbaginacee",
                   NomeScientificoPianta = "Plumbago capensis",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/Plumbago/PLUMBAGO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "ARBUSTO DISORDINATO, CARATTERIZZATO DALL’EMISSIONE DI NUMEROSI TRALCI ALLUNGATI, ESILI E ARCUATI, LUNGO I QUALI, ALL’ASCELLA DELLE FOGLIE, AVVIENE LA FIORITURA, COSTITUITA DA INFIORESCENZE A OMBRELLA FORMATE DA FIORI DI COLORE AZZURRO LAVANDA. È UN ARBUSTO CADUCIFOGLIO, CON FOGLIE PICCOLE E ARROTONDATE ALL’APICE. LA PIANTA È COSPARSA DI SOSTANZE LEGGERMENTE APPICCICOSE CHE ATTIRANO LE FORMICHE. IMPIEGABILE COME PIANTA ISOLATA O IN BORDURA.",
                   Coltivazione = "Teme il freddo: dalla Val Padana in su va coltivato solo in vaso (minimo 30 cm di diametro), da proteggere in serra fredda o sul pianerottolo in inverno. Predilige un terriccio fertile e sciolto, ben drenato, e un’esposizione in pieno sole. Necessita d’acqua durante l’estate e se viene allevato in vaso. Va concimato da marzo a settembre, con un prodotto liquido per piante da fiore. Si può potare in inverno per riordinare la forma.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                 new Arbusti
                {
                   NomeComunePianta = "SKIMMIA",
                   NomeFamiglia = "Rutacee",
                   NomeScientificoPianta = "Skimmia japonica",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/Skimmia/SKIMMIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "SEMPREVERDE DI PICCOLE DIMENSIONI (MASSIMO 1,5 M D’ALTEZZA), A CRESCITA MOLTO LENTA, CON ELEGANTI FOGLIE LANCEOLATE, LUCIDE, GRANDI, CORIACEE. È UNA PIANTA DIOICA, CIOÈ CON ESEMPLARI MASCHILI E SOGGETTI FEMMINILI. LA FIORITURA È GRADEVOLE, IN MARZO-APRILE, DATA DA FIORI BIANCO CREMA RIUNITI IN PANNOCCHIE. NE DERIVANO (SOLO SU PIANTE FEMMINE) LE BACCHE ESTIVO-AUTUNNALI, MOLTO DECORATIVE, DI COLORE ROSA CARICO O ROSSO VIVO, CHE PERMANGONO FINO A PRIMAVERA.",
                   Coltivazione = "Rustica, resiste ﬁ no a –15 °C, mentre è meno indicata per zone con caldo afoso in estate. Desidera il pieno sole per fornire una bella fioritura, ma resiste anche a mezz’ombra. Preferisce un terriccio fresco e profondo, non calcareo (meglio leggermente acido), da mantenere sempre leggermente umido, soprattutto in estate. È coltivabile anche in vaso. Richiede acqua decalcificata e concime per acidofile.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                 new Arbusti
                {
                   NomeComunePianta = "SOMMACCO",
                   NomeFamiglia = "Anacardiacee",
                   NomeScientificoPianta = "Rhus typhina",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/Sommacco/SOMMACCO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "ARBUSTO O PICCOLO ALBERO DECIDUO, DA UTILIZZARE ISOLATO O IN MACCHIA. HA RAMI FINEMENTE PELOSI E FOGLIE PENNATE, LUNGHE 10-20 CM. IN AUTUNNO, PRIMA DI CADERE, IL FOGLIAME ASSUME I TONI DEL GIALLO, ARANCIO E ROSSO, PER UN MAGNIFICO EFFETTO DECORATIVO. I FIORI SONO RIUNITI IN PANNOCCHIE GIALLO-VERDASTRE, PELOSE, DELLA STESSA LUNGHEZZA DELLE FOGLIE. R. COTINUS, DETTO SCOTANO O ALBERO DELLE PARRUCCHE, PRODUCE VISTOSE INFRUTTESCENZE FILAMENTOSE.",
                   Coltivazione = "Facilissimo da coltivare, non teme il freddo né il caldo, vive bene in città come al mare o in montagna. Si adatta a ogni tipo di terreno e situazione ambientale, ma solo se collocato in pieno sole sviluppa tutta la gamma di colori che le foglie sono in grado di esprimere. Non necessita di acqua (tranne che dopo l’impianto), né di concime. Per la forma ad alberetto è bene eliminare i polloni basali.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                 new Arbusti
                {
                   NomeComunePianta = "SPIREA",
                   NomeFamiglia = "Rosacee ",
                   NomeScientificoPianta = "Spiraea x bumalda",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/Spirea/SPIREA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "ARBUSTO CADUCIFOGLIO DECORATIVO DAL PORTAMENTO VAPOROSO E DAI LUNGHI RAMI ARCUATI. HA DIMENSIONI CONTENUTE IN ALTEZZA (MASSIMO 1,80 M), MA ESPANSE IN LARGHEZZA (FINO A 3 M DI DIAMETRO). PRODUCE CORIMBI APPIATTITI COLOR CREMISI DA GIUGNO AD AGOSTO. S. ARGUTA REGALA FIORI BIANCHI SULL’INTERO RAMO, COME S. THUNBERGII E S. X VANHOUTTEI (CHE PERÒ FIORISCE IN MAGGIO). S. JAPONICA SI AMMANTA DI FIORI ROSA CARICO. SI UTILIZZANO COME SOGGETTI SINGOLI O PER MACCHIE.",
                   Coltivazione = "Resiste al gelo alpino e al calore. Ama terreni freschi, profondi, fertili e poco calcarei. In pieno sole la fioritura è più abbondante, ma sopporta anche la mezz’ombra. Necessita di acqua solo dopo l’impianto. È preferibile concimarla con prodotti organici in autunno e in primavera. Si pota per ridurne l’ingombro, subito dopo la fioritura. Diffcoltosa da coltivare in vaso, a meno che non sia una vasca da oltre 50 cm di lato.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                 new Arbusti
                {
                   NomeComunePianta = "VIBURNI",
                   NomeFamiglia = "Idrangeacee",
                   NomeScientificoPianta = "Viburnum",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/Viburni/VIBURNI.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "V. TINUS O LENTAGGINE È UN SEMPREVERDE DAL FOGLIAME SCURO E CORIACEO; FIORISCE DA GENNAIO AD APRILE CON CORIMBI DI FIORI BIANCO-ROSATI E PRODUCE BACCHE COLOR BLU METALLIZZATO DA AGOSTO A MARZO. V. OPULUS (PALLON DI MAGGIO) È UN CADUCIFOGLIO CHE IN MAGGIO SI RIEMPIE DI CORIMBI ROTONDI DI FIORI CANDIDI, A CUI SEGUONO BACCHE ROSSE E POI NERE. V. FRAGRANS È UN CADUCIFOGLIO CHE SI AMMANTA DI CORIMBI DI FIORI BIANCO-ROSATI PROFUMATI.",
                   Coltivazione = "In generale resistono al freddo (V. tinus solo fino a –5/–8 °C) e al caldo. Amano terreni freschi e profondi, ben drenati e fertili. Desiderano posizioni soleggiate o a mezz’ombra. Vanno annaffiati solo dopo l’impianto. È bene concimarli in autunno e primavera con sostanze organiche. Possono vivere anche in vasi grandi (da 50 cm di lato in su). Si potano solo per ridurne l’ingombro, dopo la fioritura o sui rami spogli.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                 new Arbusti
                {
                   NomeComunePianta = "WEIGELA",
                   NomeFamiglia = "Caprifoliacee",
                   NomeScientificoPianta = "Weigela florida",
                   FotoPianta = "ms-appx:///Immagini/ARBUSTI/Weigela/WEIGELA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ARBUSTI/Abete-*.jpg",

                   DescrizioneBotanica = "RUSTICO ARBUSTO CADUCIFOGLIO, IDEALE COME ESEMPLARE ISOLATO O PER MACCHIE DECORATIVE. HA FOGLIE LANCEOLATE, DALLE NERVATURE EVIDENTI, CONSISTENTI E RUVIDE, COLOR VERDE BRILLANTE. FIORISCE DA LUGLIO A SETTEMBRE, RIEMPIENDOSI DI FIORI ROSA CARICO (MA ESISTONO ANCHE SPECIE E VARIETÀ A FIORE BIANCO O ROSA PALLIDO). LA VARIETÀ VARIEGATA È CARATTERIZZATA DA FOGLIOLINE COLOR VERDE TENERO BORDATE DI GIALLO CHIARO, IN UN GRADEVOLE CONTRASTO CON I FIORI ROSA.",
                   Coltivazione = "Non teme il freddo alpino né il caldo torrido, a condizione che il terreno ove insiste sia sempre leggermente umido. Predilige un suolo fresco e profondo, preferibilmente non troppo calcareo. Ama esposizioni soleggiate o, tutt’al più, a mezz’ombra, per non sacrificare la fioritura. Necessita di annaffiature soprattutto durante l’estate. Va concimato in autunno e primavera con un prodotto organico. Si pota solo se necessario.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                




            };

            return data;
        }

        // TODO WTS: Remove this once your MasterDetail pages are displaying real data
        public static async Task<IEnumerable<Arbusti>> GetSampleModelDataAsync()
        {
            await Task.CompletedTask;

            return AllArbusti();
        }

        
    }
}
