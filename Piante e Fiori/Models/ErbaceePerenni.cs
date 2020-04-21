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
//34 ERBACEE PERENNI
    public class ErbaceePerenni
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
        public string AltreCaratteristiche { get; set; }


    }

    public static class ErbaceePerenniDataService
    {
        private static IEnumerable<ErbaceePerenni> AllErbaceePerenni()
        {
            // The following is order summary data
            var data = new ObservableCollection<ErbaceePerenni>
            {
               
                new ErbaceePerenni
                {
                   NomeComunePianta = "ACHILLEA",
                   NomeFamiglia = "Composite",
                   NomeScientificoPianta = "Achillea filipendulina",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Achillea/ACHILLEA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "A. FILIPENDULINA È CARATTERIZZATA DA FOGLIE PICCOLE E FITTE E FIORI COLORATI IN GIALLO, RIUNITI IN INFIORESCENZE A OMBRELLA MOLTO VISTOSE, CHE APPAIONO DA GIUGNO FINO A SETTEMBRE. LA PARTE AEREA (IL FUSTO E LE FOGLIE) IN AUTUNNO APPASSISCE, E POI MUORE: VA LASCIATA FINO ALLA FINE DELL’INVERNO, COME PROTEZIONE CHE RIPARA LE RADICI DAL GELO; GIÀ NEL MESE DI MARZO SPUNTERANNO I NUOVI GERMOGLI CHE CRESCERANNO E SI SVILUPPERANNO MOLTO RAPIDAMENTE.",
                   Coltivazione = "Non teme il gelo e può essere piantata sia in piena terra sia in vaso (grande) anche sulle Alpi. Deve ricevere molto sole durante tutto l’anno. Il terreno preferito è fertile, profondo, ma soprattutto ben drenato. In primavera-estate va annaffiata con moderazione ogni giorno. In autunno è bene apportare una dose di concime organico. All’inizio di marzo si può moltiplicare per divisione dei cespi.",
                   Potatura = "",
                   Malattie = "",
                },

                new ErbaceePerenni
                {
                   NomeComunePianta = "ALCHEMILLA",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Alchemilla vulgaris",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Alchemilla/ALCHEMILLA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "LA PIANTA È CARATTERIZZATA DA UN FUSTO ERETTO E DA FOGLIE PALMATE E DENTATE, CHE PRESENTANO DAI 7 AGLI 11 LOBI, DONANDO ALLA FOGLIA L’ASPETTO DI UN GRANDE VENTAGLIO. I FIORI SONO MOLTO PICCOLI, GIALLASTRI, RIUNITI IN MAZZETTI E FANNO LA PROPRIA COMPARSA DA MAGGIO A SETTEMBRE. È UNA SPECIE MOLTO COMUNE NELL’AMBIENTE NATURALE, CHE SI PUÒ COLTIVARE NEI GIARDINI A SCOPO ORNAMENTALE, PER ESEMPIO IN BORDURE, AIUOLE, GIARDINI ROCCIOSI, O A SCOPO OFFICINALE.",
                   Coltivazione = " Sopporta senza problemi il gelo, anche perché la parte aerea in questo caso si secca e muore, per rispuntare nella primavera successiva (quando si elimina la parte appassita). Richiede una posizione a mezz’ombra, su un terreno fresco e leggermente umido, ma ben drenato. Le irrigazioni devono essere frequenti in estate. La concimazione non è necessaria. Si moltiplica per divisione del cespo in primavera.",
                   Potatura = "",
                   Malattie = "",
                },

                new ErbaceePerenni
                {
                   NomeComunePianta = "ANEMONE",
                   NomeFamiglia = "Ranuncolacee",
                   NomeScientificoPianta = "Anemone x hybrida",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Anemone/ANEMONE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "IL GENERE ANEMONE COMPRENDE NUMEROSISSIME SPECIE PERENNI, ALCUNE CON RADICI TUBEROSE E FIORITURA PRIMAVERILE, ALTRE CON RADICI FIBROSE E FIORITURA ESTIVO-AUTUNNALE. FRA LE PRIME SI RICORDANO A. NEMOROSA, A. BLANDA, A. APENNINA, FACENTI PARTE DELLA FLORA SPONTANEA ITALIANA; TRA LE SECONDE I NUMEROSISSIMI IBRIDI FLORICOLI (A. X HYBRIDA), A. JAPONICA E A. HUPEHENSIS, TUTTI DI TAGLIA SUPERIORE A 1 M E DAI GRANDI FIORI BIANCHI, ROSA O ROSSI.",
                   Coltivazione = "Sono tutte specie rustiche, che resistono agli inverni più gelidi, perdendo la parte aerea, che rispunta in primavera. Richiedono una posizione a mezz’ombra e un suolo sempre leggermente umido ma ben drenato, fresco e ricco di humus. Necessitano di abbondanti innaffiature estive. Gradiscono una leggera concimazione organica autunnale. Tendono a espandersi e i cespi vanno divisi quasi ogni anno.",
                   Potatura = "",
                   Malattie = "",
                },

                new ErbaceePerenni
                {
                   NomeComunePianta = "AQUILEGIA",
                   NomeFamiglia = "Ranuncolacee",
                   NomeScientificoPianta = "Aquilegia vulgaris",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Aquilegia/AQUILEGIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "LE AQUILEGIE RAGGIUNGONO IL MASSIMO DELLO SPLENDORE IN APRILE-MAGGIO, QUANDO SI PRODUCONO NELLO SPETTACOLO DELLA FIORITURA, RIEMPIENDOSI DI COROLLE DALL’ARCHITETTURA COMPLESSA, A CAMPANELLA CON SPERONI E ARRICCIATURE. LA SPECIE SPONTANEA FIORISCE IN VIOLA, MA LA FACILITÀ CON CUI LE PIANTE SI IBRIDANO HA CREATO VARIETÀ IN TUTTI I COLORI (COMPRESO IL BIANCO E IL VIOLA-NERO), ANCHE MESCOLATI IN VARIE COMBINAZIONI TRA LORO NELLE DIVERSE PARTI DEL FIORE.",
                   Coltivazione = "Sono piante assolutamente rustiche, che non temono il gelo alpino, ma faticano a sopravvivere in zone molto calde o marittime. Necessitano di un terreno piuttosto fertile, sempre umido ma ben drenato, con esposizione soleggiata o a mezz’ombra. Trascorso il primo anno dall’impianto, si diffondono rapidamente e si ibridano con grande facilità fra di loro. In vaso necessitano di trapianti annuali e abbondanti concimazioni.",
                   Potatura = "",
                   Malattie = "",
                },

                new ErbaceePerenni
                {
                   NomeComunePianta = "ASTER (ASTRI)",
                   NomeFamiglia = "Composite",
                   NomeScientificoPianta = "Aster novae-angliae, A. novi-belgii, A. amellus",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Aster/ASTER.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "SI TRATTA DI UN GENERE RICCO DI OLTRE 200 SPECIE, DA CUI SONO STATE RICAVATE NUMEROSE VARIETÀ, TUTTE CARATTERIZZATE DA UNA FIORITURA GENEROSA E PROLUNGATA. A. NOVAE-ANGLIAE E A. NOVI-BELGI, DISPONIBILI IN VARI COLORI E IN GENERE DI TAGLIA GRANDE, SONO I COSIDDETTI “SETTEMBRINI”, DAL PERIODO DI FIORITURA; A. AMELLUS ANTICIPA I FIORI, VIOLA CHIARO (MA ANCHE DI QUESTA SPECIE SONO STATE RICAVATE VARIETÀ FLORICOLE MULTICOLORI), GIÀ IN AGOSTO, ED È PIÙ BASSO.",
                   Coltivazione = "In generale gli astri resistono alle basse temperature; richiedono un suolo fertile, ben lavorato e drenato, al sole o in mezz’ombra (A. amellus preferisce il sole pieno). L’irrigazione deve essere abbondante durante la stagione estiva; la concimazione va effettuata in autunno e in primavera, con prodotti organici o chimici. Durante l’inverno la vegetazione appassita va tagliata a 20 cm d’altezza. Non resistono in vaso.",
                   Potatura = "",
                   Malattie = "",
                },

                new ErbaceePerenni
                {
                   NomeComunePianta = "AUBREZIA",
                   NomeFamiglia = "Crucifere",
                   NomeScientificoPianta = "Aubrietia",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Aubrezia/AUBREZIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "TAPPEZZANTE MOLTO UTILIZZATA NEI GIARDINI ROCCIOSI, SU MURETTI A SECCO E SCARPATE SASSOSE O IN VASI DI LEGNO O PIETRA, DOVE SI ALLARGA VELOCEMENTE CREANDO PARTICOLARI CUSCINI DI PICCOLE FOGLIE TONDEGGIANTI, COLOR GRIGIO-VERDE, LEGGERMENTE PELOSE. DALLA PRIMAVERA ALLA FINE DELL’ESTATE PRODUCE NUMEROSISSIMI, PICCOLI FIORELLINI DI COLORE ROSA, VIOLA O BLU. SI UTILIZZA ANCHE AI PIEDI DI ARBUSTI O ALBERI, PERCHÉ NON SUPERA I 10-15 CM D’ALTEZZA.",
                   Coltivazione = "Non teme il freddo. La fioritura è migliore in posizioni soleggiate, a patto che le radici rimangano al fresco (tra le rocce, su terreno leggermente umido ecc.). Il suolo ideale è di natura calcarea, più in generale è sciolto, soffice, leggero, molto ben drenato. Si annaffia con moderazione ma regolarmente, in estate, fornendo un concime per piante fiorite ogni 15 giorni. Si moltiplica per divisione del cespo o da seme.",
                   Potatura = "",
                   Malattie = "",
                },

                new ErbaceePerenni
                {
                   NomeComunePianta = "BERGENIA",
                   NomeFamiglia = "Sassifragacee",
                   NomeScientificoPianta = "Bergenia crassifolia",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Bergenia/BERGENIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "PICCOLA SEMPREVERDE, CARATTERIZZATA DA FOLTI CIUFFI DI GRANDI FOGLIE TONDEGGIANTI, OVALI O CUORIFORMI, CON BORDI DENTELLATI, DI COLORE VERDE SCURO, CHE SI ARROSSANO IN AUTUNNO. DAL CENTRO DEI CIUFFI, ALLA METÀ-FINE DELL’INVERNO, SI SVILUPPANO STELI CHE SVETTANO SOPRA IL FOGLIAME, SU CUI SBOCCIANO MAZZETTI DI PICCOLI FIORI CAMPANULATI, DI COLORE BIANCO, ROSA, ROSSO O PORPORA, CHE PERMANGONO A LUNGO. IDEALE PER BASSE BORDURE DI AIUOLE E VIALETTI.",
                   Coltivazione = "Non teme il gelo, con la sola eccezione di B. ciliata, che non resiste sulle Alpi. Non ha preferenze di esposizione, ma d’estate va ombreggiata, se è posta in pieno sole, per evitare bruciature sulle foglie. Risulta indifferente al terreno, che deve solo essere ben drenato. Necessita di irrigazioni abbondanti in primavera-estate. In autunno si concima con un prodotto organico. Si moltiplica per divisione dei cespi.",
                   Potatura = "",
                   Malattie = "",
                },

                new ErbaceePerenni
                {
                   NomeComunePianta = "CAMPANULA",
                   NomeFamiglia = "Campanulacee",
                   NomeScientificoPianta = "Campanula carpatica, C. persicifolia",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Campanula/CAMPANULA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "LE CAMPANULE DA GIARDINO E DA VASO SONO MOLTO NUMEROSE: SI UTILIZZANO PER LE FIORITURE MA ANCHE PER LA CAPACITÀ TAPPEZZANTE (PER ESEMPIO IN C. PORTENSCHLAGIANA), CHE LE PORTA A RICOPRIRE VELOCEMENTE LO SPAZIO ASSEGNATO. ESISTONO ANCHE MOLTEPLICI CAMPANULE SPONTANEE NELLA FLORA ITALIANA. IL COLORE TIPICO DEL FIORE (GRANDE O PICCOLO, RIVOLTO VERSO L’ALTO O IL BASSO) È IL VIOLA, MA OGGI CI SONO VARIETÀ FLORICOLE BLU, ROSA, PORPORA E BIANCHE.",
                   Coltivazione = "Sopportano il gelo, soprattutto se leggermente pacciamate alla base, spesso senza nemmeno perdere la parte aerea. Desiderano un terriccio fertile, sciolto e ben drenato, in estate umido se la collocazione è in pieno sole (preferiscono la mezz’ombra). Vanno irrigate in abbondanza in estate, concimando ogni 10 giorni con un prodotto per piante da fiore. Si moltiplicano per seme o per divisione del cespo in primavera.",
                   Potatura = "",
                   Malattie = "",
                },

                new ErbaceePerenni
                {
                   NomeComunePianta = "CENTAUREA",
                   NomeFamiglia = "Composite",
                   NomeScientificoPianta = "Centaurea cyanus",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Centaurea/CENTAUREA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "C. CYANUS È IL FIORDALISO, ORMAI SCOMPARSO DAI CAMPI MA OGGI DISPONIBILE IN COLTIVAZIONE, NEL CLASSICO ESEMPLARE BLU E IN VARIETÀ ROSA O BIANCHE. ESISTONO ANCHE ALTRE CENTAUREE ORNAMENTALI, RAPPRESENTATE DA VARIETÀ FLORICOLE NEI TONI PREVALENTEMENTE DEL ROSA E ROSSO, ANCHE CON INFIORESCENZE SEMIDOPPIE O DOPPIE, MA TUTTE PRIVE DELLE SPINE (CHE SPESSO SONO PRESENTI NELLE CENTAUREE SPONTANEE NELLA FLORA ITALIANA). FIORISCONO TRA MAGGIO E AGOSTO.",
                   Coltivazione = " Tutte le centauree resistono al gelo, anche se perdono la parte aerea. Non hanno esigenze particolari in fatto di terreno, che deve però essere ben drenato. L’esposizione migliore è al sole, ma tollerano la mezz’ombra. Le irrigazioni, in estate, si possono limitare a due-tre interventi a settimana, con poca acqua e concimando ogni 15 giorni con un prodotto per piante da fiore. Si moltiplicano per seme e divisione del cespo.",
                   Potatura = "",
                   Malattie = "",
                },

                new ErbaceePerenni
                {
                   NomeComunePianta = "COSMEA",
                   NomeFamiglia = "Composite",
                   NomeScientificoPianta = "Cosmos bipinnatus",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Cosmea/COSMEA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "AL GENERE COSMOS APPARTENGONO SIA PIANTE ANNUALI SIA PERENNI. TUTTE COSTITUISCONO GRANDI CESPUGLI ALTI (FINO A 1,3 M), CHE TENDONO AD ALLARGARSI IN DIAMETRO. LE FOGLIE SONO LACINIATE (DIVISE IN SOTTILISSIMI SEGMENTI). I FIORI SONO GRANDI, SEMPLICI, CON CENTRO GIALLO E PETALI MOLTO COLORATI, BIANCHI, GIALLI, ROSA O ROSSI (MARRONE NELLA VARIETÀ ‘CHOCOLATE’) E PERSISTONO CONTINUAMENTE RICAMBIATI DA GIUGNO FINO A OTTOBRE.",
                   Coltivazione = "C. bipinnatus teme il freddo, tanto da essere spesso oggetto di coltivazione annuale; solo in climi miti riesce a sopravvivere all’inverno, a volte spogliandosi della parte aerea. Non ha preferenze in fatto di suolo, mentre desidera una posizione ben soleggiata. L’irrigazione deve essere costante e abbondante durante la bella stagione, integrata da concimazioni regolari con prodotti per piante da fiore ogni 10 giorni.",
                   Potatura = "",
                   Malattie = "",
                },

                 new ErbaceePerenni
                {
                   NomeComunePianta = "DELFINIUM",
                   NomeFamiglia = "Ranuncolacee",
                   NomeScientificoPianta = "Delphinium ajacis",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Delfinium/DELFINIUM.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "IL GENERE COMPRENDE SPECIE ANNUALI E PERENNI, COSTITUITE DA FOLTI CIUFFI DI GRANDI FOGLIE PALMATE, FINEMENTE DIVISE, DI COLORE VERDE BRILLANTE. SONO COLTIVATI PER LE ALTE  (1-1,5 M) SPIGHE DI FIORI A COPPA, SEMPLICI O DOPPI, DI COLORE BLU, ROSA O BIANCO, IN MAGGIO-GIUGNO. ELIMINANDO LE SPIGHE APPASSITE, SI OTTIENE UNA RIFIORITURA DI SPIGHE PIÙ PICCOLE IN SETTEMBRE. ESISTONO ANCHE VARIETÀ FLORICOLE DA COLTIVARE IN VASO, ALTE AL MASSIMO 40 CENTIMETRI.",
                   Coltivazione = "Non teme il freddo: in inverno perde la parte aerea, che ricostituisce in primavera. Preferisce terreni sciolti, ben drenati e fertili, e posizioni soleggiate (anche la mezz’ombra ma con qualche ora di sole al giorno). Necessita di molta acqua, somministrata con regolarità in primavera ed estate, con concimazioni costanti ogni 10 giorni, a cui deve seguire anche una somministrazione di fertilizzante organico in autunno.",
                   Potatura = "",
                   Malattie = "",
                },

                new ErbaceePerenni
                {
                   NomeComunePianta = "DICENTRA",
                   NomeFamiglia = "Papaveracee",
                   NomeScientificoPianta = "Dicentra spectabilis",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Dicentra/DICENTRA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "CHIAMATA IN ITALIANO “CUOR DI MARIA”, DEVE LA DENOMINAZIONE ALLA FORMA DEI FIORI, APPUNTO A CUORE PENDULO DAL RAMETTO, DI COLORE ROSA CON CENTRO BIANCO NELLA SPECIE, TUTTO ROSA O ROSSO O BIANCO NELLE VARIETÀ FLORICOLE. LA FIORITURA AVVIENE IN APRILE-GIUGNO. LA PIANTA È PERENNE GRAZIE ALLE RADICI RIZOMATOSE. HA PICCOLE FOGLIE LEGGERE, LOBATE, COMPOSTE, COLOR VERDE CHIARO. SI IMPIEGA IN MACCHIA NELLE AIUOLE O ANCHE IN VASO, PURCHÉ PIUTTOSTO GRANDE.",
                   Coltivazione = "Resiste senza problemi anche sulle Alpi, purché ben pacciamata alla base. Gradisce un terreno ricco, sciolto e ben drenato, preferibilmente alcalino (sopporta poco i suoli acidi). Preferisce una posizione a mezz’ombra, soprattutto durante l’estate. Le annaffiature devono essere regolari in estate, anche se non molto abbondanti. Si concima con letame maturo o stallatico in autunno e in marzo-aprile.",
                   Potatura = "",
                   Malattie = "",
                },

                new ErbaceePerenni
                {
                   NomeComunePianta = "DIGITALE",
                   NomeFamiglia = "Scrofulariacee",
                   NomeScientificoPianta = "Digitalis purpurea",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Digitale/Digitale.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTA BIENNALE CHE NEL PRIMO ANNO DI VITA FORMA LA ROSETTA BASALE DI LUNGHE FOGLIE LANCEOLATE VERDE SCURO, COPERTE DA PELURIA BIANCASTRA, E NEL SECONDO ANNO DAL CENTRO DELLA ROSETTA, IN GIUGNO, PRODUCE UN LUNGO STELO CHE PORTA GRANDI FIORI CAMPANULATI, DI DIMENSIONI DECRESCENTI DALLA BASE ALL’APICE, DI COLORI DIVERSI (BIANCO, ROSA, VIOLA, GIALLO, MACULATI DI SCURO), CHE DURANO UN MESE. TAGLIANDO LA SPIGA APPASSITA, LA PIANTA IN SETTEMBRE RIFIORISCE.",
                   Coltivazione = "Resiste al gelo se le rosette vengono pacciamate. Ama i suoli sciolti, ben drenati, fertili, meglio se con pH leggermente acido. È indifferente all’esposizione, anche se in estate il pieno sole va schermato con una rete ombreggiante. Va annaffiata con regolarità in estate, ma senza eccessi. Si concima in autunno con letame ben maturo o stallatico secco. Si riproduce mediante semina, in autunno.",
                   Potatura = "",
                   Malattie = "",
                },

                new ErbaceePerenni
                {
                   NomeComunePianta = "ECHINACEA",
                   NomeFamiglia = "Composite",
                   NomeScientificoPianta = "Echinacea purpurea",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Echinacea/ECHINACEA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "VISTOSA MARGHERITA DAI FIORI DI 12-15 CM DI DIAMETRO, NELLA SPECIE DI COLORE ROSA, MA ANCHE PORPORA E BIANCHI NELLE VARIETÀ, PORTATI DA STELI ALTI FINO A 1,5 METRI. ALLA BASE SI SVILUPPA UN CIUFFO DI FOGLIE GRANDI, LANCEOLATE E ALLUNGATE, RUVIDE PER LA PRESENZA DI CORTI PELI RIGIDI. E. PURPUREA È ALTA 1,5 M, E. ANGUSTIFOLIA RAGGIUNGE 1,2 M, LE VARIETÀ FLORICOLE SONO IN GENERE PIÙ CONTENUTE. SI ABBINANO ALLE RUDBECKIE, DALLE GRANDI MARGHERITE GIALLE O MARRONI.",
                   Coltivazione = "Assolutamente rustiche (anche sulle Alpi), vanno coltivate su terreni ricchi di humus, lavorati con cura e un po’ umidi ma ben drenati. Gradiscono una buona esposizione al sole, ma tollerano bene anche l’ombra. Si possono coltivare in vaso (grande). Al termine della fioritura, vanno tagliate drasticamente per stimolare la produzione di nuovi boccioli. Vanno annaffiate poco ma regolarmente e concimate in autunno con letame.",
                   Potatura = "",
                   Malattie = "",
                },

                new ErbaceePerenni
                {
                   NomeComunePianta = "ELLEBORO",
                   NomeFamiglia = "Ranuncolacee",
                   NomeScientificoPianta = "Helleborus niger, H. viridis",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Elleboro/ELLEBORO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "VIENE CHIAMATO ANCHE ROSA DI NATALE, PERCHÉ I SUOI FIORI SI APRONO TRA DICEMBRE E FEBBRAIO, NELLE GIORNATE PIÙ TIEPIDE, ANCHE SOTTO LA NEVE. HA GRANDI FOGLIE PALMATE, COMPOSTE DA SEGMENTI OVALI, DI COLORE VERDE SCURO. I FIORI, PORTATI DA SOTTILI STELI CARNOSI, SONO SINGOLI O A GRAPPOLI, MOLTO GRANDI, E RICORDANO EFFETTIVAMENTE I FIORI DELLA ROSA CANINA; SONO BIANCHI, VERDASTRI O PORPORA NELLE SPECIE, MA ANCHE GIALLI O NERI NELLE VARIETÀ FLORICOLE.",
                   Coltivazione = " Il gelo non costituisce un problema, mentre il caldo e la salsedine portano a morte la pianta. Necessitano di un terreno umido, profondo, fresco, non troppo drenato. L’esposizione deve essere soleggiata in pieno inverno, ma in ombra dalla primavera all’autunno. Va annaffiato con regolarità per tutto l’anno, in modo da mantenere il terriccio sempre umido ma non inzuppato. Si concima in autunno e in primavera.",
                   Potatura = "",
                   Malattie = "",
                },

                new ErbaceePerenni
                {
                   NomeComunePianta = "ENOTERA",
                   NomeFamiglia = "Onagracee",
                   NomeScientificoPianta = "Oenothera biennis, O. missouriensis",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Enotera/ENOTERA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "SI TRATTA DI UNA PIANTA BIENNALE, PELOSA E APPICCICOSA, CHE NEL PRIMO ANNO DI VITA PRODUCE UNA ROSETTA DI FOGLIE OVATE, E NEL SECONDO SVILUPPA IL FUSTO CON LE FOGLIE LANCEOLATE FINO A PRODURRE I FIORI (TRA GIUGNO E SETTEMBRE), CHE SONO GRANDI, GIALLO INTENSO, PROFUMATI, RIUNITI IN UN’INFIORESCENZA A SPIGA, PER UN’ALTEZZA COMPRESA FRA 50 E 150 CENTIMETRI. LE VARIETÀ ALTE SI UTILIZZANO COME QUINTE NELLE AIUOLE, QUELLE BASSE PER BORDURE DI AIUOLE E VIALETTI.",
                   Coltivazione = "Si tratta di un genere piuttosto rustico (da pacciamare in inverno nel Nord Italia), che predilige un suolo sciolto, leggero, mediamente fertile, molto ben drenato, e un’esposizione soleggiata. Le annaffiature devono esser regolari in estate, anche se distanziate e non troppo abbondanti. La concimazione è limitata a un apporto autunnale di sostanza organica come il letame maturo o lo stallatico secco.",
                   Potatura = "",
                   Malattie = "",
                },

                new ErbaceePerenni
                {
                   NomeComunePianta = "ERICA",
                   NomeFamiglia = "Ericacee",
                   NomeScientificoPianta = "Erica carnea, Calluna vulgaris",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Erica/ERICA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "PICCOLI SEMPREVERDI TAPPEZZANTI, CHE FIORISCONO TRA SETTEMBRE E NOVEMBRE, CON MINUTI FIORI ROSA NELLE SPECIE, ROSSI, LILLA, BIANCHI, GIALLI O VERDI NELLE VARIETÀ FLORICOLE, TANTO FITTI A VOLTE DA NASCONDERE IL FOGLIAME. HANNO FOGLIE AGHIFORMI DI COLORE VERDE BRILLANTE (MA ANCHE GRIGIE, ROSSASTRE O GIALLASTRE NELLE CULTIVAR). VENGONO IN GENERE IMPIEGATE COME PIANTE DA VASO PER COMPOSIZIONI AUTUNNALI, MA SI POSSONO ANCHE UTILIZZARE NELLE AIUOLE IN GIARDINO.",
                   Coltivazione = "Il freddo non è un fattore limitante, mentre lo sono il caldo e la salsedine. Il terreno deve avere pH acido (sono piante acidofile) ed essere fresco, profondo, fertile e umido. L’esposizione deve essere a mezz’ombra in inverno e in ombra, dalla primavera all’inizio dell’autunno. L’acqua, da somministrare in abbondanza in estate, deve essere decalcificata. Si concima con un prodotto specifico per piante acidofile.",
                   Potatura = "",
                   Malattie = "",
                },

                new ErbaceePerenni
                {
                   NomeComunePianta = "ERINGIO",
                   NomeFamiglia = "Ombrellifere",
                   NomeScientificoPianta = "Eryngium giganteum, E. amethystinum",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Eringio/ERINGIO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTA CARATTERIZZATA DA FOGLIE GRANDI, RIGIDE, GLAUCHE O VIOLACEE, PROFONDAMENTE INCISE E DOTATE DI SPINE LUNGHE E ACUTE SUI BORDI. PRODUCE INFIORESCENZE GLOBOSE DATE DA MINUTI FIORI DI COLORE VERDE, BLU METALLICO O VIOLA, MUNITE DI BRATTEE ACUMINATE E SPINOSE. NELL’INSIEME, LA PIANTA APPARE SPETTACOLARE DAL PUNTO DI VISTA ARCHITETTONICO E CROMATICO, E QUINDI MOLTO DECORATIVA PER BORDURE O PUNTI FOCALI BASSI, IN GIARDINO.",
                   Coltivazione = " L’eringio resiste al gelo alpino (E. alpinum) e al caldo torrido e salso delle coste (E. maritimum): in entrambi i casi la parte aerea appassisce e muore. Vuole un’esposizione soleggiata su un terreno leggero, fertile, sciolto, anche calcareo o sassoso o scosceso. Le irrigazioni vanno limitate ai periodi più caldi, in quantità non abbondante. La concimazione si riduce a un apporto autunnale di sostanza organica.",
                   Potatura = "",
                   Malattie = "",
                },

                new ErbaceePerenni
                {
                   NomeComunePianta = "EUCHERA",
                   NomeFamiglia = "Crucifere",
                   NomeScientificoPianta = "Heuchera sanguinea",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Euchera/EUCHERA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "TAPPEZZANTE ALTA 30-40 CM, CHE FORMA CUSCINI DI FOGLIE TONDEGGIANTI O A FORMA DI CUORE, IN GENERE LOBATE O DENTELLATE, NELLA SPECIE CLASSICA DI COLORE VERDE SCURO SCREZIATO DI VERDE CHIARO, NELLE VARIETÀ FLORICOLE COLOR PORPORA SCURO METALLIZZATO, CIOCCOLATO, GRIGIO ARGENTO, CARAMELLO, AMBRA, VERDE MELA. I FIORELLINI BIANCHI, ROSATI O PORPORA, MINUTI E DISPOSTI SU STELI ALTI 50-60 CM, SBOCCIANO IN AGOSTO-SETTEMBRE.",
                   Coltivazione = "Non teme assolutamente il freddo. Richiede un terreno fertile, fresco, sciolto ben drenato e leggermente umido; non ama i suoli argillosi e pesanti. La posizione deve essere soleggiata o, tutt’al più, a mezz’ombra. Desidera annaffiature frequenti e costanti durante la bella stagione, abbinate ogni 15 giorni a una dose di fertilizzante per piante da fiore. È una tipica pianta da bordura nelle aiuole o lungo i sentieri.",
                   Potatura = "",
                   Malattie = "",
                },

                new ErbaceePerenni
                {
                   NomeComunePianta = "EUFORBIA",
                   NomeFamiglia = "Euforbiacee",
                   NomeScientificoPianta = "Euphorbia characias, E. amygdaloides",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Euforbia/EUFORBIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "AL GENERE EUPHORBIA APPARTENGONO SPECIE DIVERSISSIME FRA DI LORO, COME LA STELLA DI NATALE E NUMEROSE SUCCULENTE. LE EUFORBIE ERBACEE, MOLTO APPREZZATE IN GRAN BRETAGNA, SI UTILIZZANO IN GIARDINO NELLE AIUOLE, LE PIÙ ALTE COME QUINTA, LE PIÙ BASSE COME BORDURA. HANNO PORTAMENTO ESPANSO O COMPATTO, CON FOGLIE OBLUNGHE DISPOSTE A STELLA, VERDE SCURO, GLAUCHE O PURPUREE. LE INFIORESCENZE APICALI, IN APRILE-MAGGIO, SONO GIALLE O VERDASTRE.",
                   Coltivazione = "Non temono il freddo se pacciamate alla base. Prediligono esposizioni soleggiate o in mezz’ombra, in suolo fertile, fresco, ben drenato. Sopportano molto bene le carenze idriche, ma gradiscono regolari annaffiature estive. Non vanno potate durante la bella stagione (eventualmente contenute con legacci e tutori), mentre si taglia l’intero stelo fino alla base legnosa della pianta, dopo che l’infiorescenza si è seccata.",
                   Potatura = "",
                   Malattie = "",
                },

                 new ErbaceePerenni
                {
                   NomeComunePianta = "GAROFANINO",
                   NomeFamiglia = "Cariofillacee",
                   NomeScientificoPianta = "Dianthus barbatus",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Garofanino/GAROFANINO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "I GAROFANINI (O GAROFANI DEI POETI) HANNO FUSTI CORTI E RIGIDI, SUDDIVISI DA NODI LARGHI E VISTOSI, DI COLORE VERDE O VERDE GLAUCO. IL FOGLIAME È LINEARE O LANCEOLATO, DI DIMENSIONI RIDOTTE, CONSISTENTE, SEMPREVERDE. I FIORI, DI 2-3 CM DI DIAMETRO, SBOCCIANO IN APRILE-MAGGIO, CON UNA RIFIORITURA MINORE IN SETTEMBRE-OTTOBRE; SONO SINGOLI O DOPPI, PORTATI DA STELI ALTI 10-15 CM, HANNO COLORE BIANCO, ROSA, ROSSO O PORPORA, ANCHE MACULATO O SCREZIATO.",
                   Coltivazione = " Non temono il freddo ma l’eccesso di calore: in estate vanno ombreggiati e ben annaffiati, con regolarità ma senza inzuppare il substrato né bagnare il fogliame. Si adattano a qualunque terreno, purché ben drenato. Necessitano di sole dall’autunno alla primavera. Le irrigazioni vanno sospese in inverno. Si concimano con un prodotto organico in autunno e, da marzo a settembre, con un concime liquido per piante da fiore.",
                   Potatura = "",
                   Malattie = "",
                },

                new ErbaceePerenni
                {
                   NomeComunePianta = "HEMEROCALLIS",
                   NomeFamiglia = "Liliacee",
                   NomeScientificoPianta = "Hemerocallis",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Hemerocallis/HEMEROCALLIS.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTA DOTATA DI FOGLIE SEMISEMPREVERDI, PRODUCE TRA GIUGNO E SETTEMBRE A SECONDA DELLE VARIETÀ (OLTRE 30.000, DATA LA FACILITÀ DI IBRIDAZIONE) GRANDI FIORI A FORMA DI GIGLIO, NEI TONI DEL BIANCO, GIALLO, ARANCIONE, ROSSO, ROSA, MARRONE, PERSINO SCREZIATI; ALCUNE CULTIVAR SONO ANCHE RIFIORENTI. IDEALI PER LE BORDURE MISTE, DATO IL PORTAMENTO MOLLEMENTE RICADENTE MA PARZIALMENTE SVETTANTE, SONO UTILIZZABILI ANCHE COME FIORI RECISI.",
                   Coltivazione = " Sono piante completamente rustiche e vivono bene dalle coste meridionali fino alle Alpi (dove è preferibile pacciamare la base in inverno). Desiderano un suolo fertile e umido, ma sempre ben drenato, con buona esposizione soleggiata o a mezz’ombra se il sole è troppo forte. Prima e durante la fioritura vanno annaffiate con generosità e regolarità, concimando con un prodotto per piante da fiore.",
                   Potatura = "",
                   Malattie = "",
                },

                new ErbaceePerenni
                {
                   NomeComunePianta = "HOSTA",
                   NomeFamiglia = "Liliacee",
                   NomeScientificoPianta = "Hosta",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Hosta/HOSTA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTA COLTIVATA PRINCIPALMENTE PER IL FOGLIAME MOLTO DECORATIVO, GRANDE, CUORIFORME TONDEGGIANTE O ALLUNGATO, SEMPRE APPUNTITO, PERCORSO DA PROFONDE NERVATURE, DI COLORE VERDE SCURO, BLUASTRO, GLAUCO, CHIARO, SCREZIATO DI BIANCO O GIALLO, A SECONDA DELLE VARIETÀ. LA FIORITURA, CHE SI VERIFICA IN GIUGNO-AGOSTO, PASSA IN SECONDO PIANO: È DATA DA PANNOCCHIE RADE, ALTE 40-50 CM, DI FIORI CAMPANULATI BIANCHI, LILLA, AZZURRI O BLUASTRI, SPESSO PROFUMATI.",
                   Coltivazione = "Tollera il gelo se pacciamata alla base: si può lasciare il fogliame, che in autunno appassisce e muore, a protezione delle radici fino a marzo. L’esposizione deve essere in ombra (molto luminosa per le cultivar a foglia chiara o variegata). Richiede un terreno fertile, fresco, leggero, drenato e leggermente umido. Le annaffiature devono essere regolari e abbondanti in estate. Si concima in autunno e primavera.",
                   Potatura = "",
                   Malattie = "",
                },

                new ErbaceePerenni
                {
                   NomeComunePianta = "KNIFOFIA",
                   NomeFamiglia = "Liliacee",
                   NomeScientificoPianta = "Kniphofia uvaria",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Knifofia/KNIFOFIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTA CHE SI FA NOTARE PER LA PARTICOLARE INFIORESCENZA, CHE COMPARE IN GIUGNO-AGOSTO ED È FORMATA DA FIORI TUBULARI BIANCHI, GIALLI, ARANCIONE, ROSSI O MARRONE (A SECONDA DELLE VARIETÀ FLORICOLE), ANCHE MESCOLATI NELLA STESSA INFIORESCENZA, ADDENSATI IN UN GRAPPOLO LUNGO FINO A 20 CM, PORTATO A SUA VOLTA DA UNO STELO ALTO FINO A 1 METRO. ALLA BASE C’È UN CESPUGLIO DI FOGLIE NASTRIFORMI, COLOR VERDE SCURO, CHE SI ALLARGA FINO A 50 CM DI DIAMETRO.",
                   Coltivazione = "In generale sono piante rustiche, da proteggere con una pacciamatura alla base sulle Alpi durante l’inverno. Amano un terreno fertile, un po’ sabbioso, umido ma ben drenato. L’esposizione deve essere soleggiata o a mezz’ombra. Le annaffiature sono necessarie solo nel periodo più caldo; le concimazioni si limitano a un apporto autunnale e uno estivo di sostanza organica. Si moltiplicano dividendo il cespo.",
                   Potatura = "",
                   Malattie = "",
                },

                new ErbaceePerenni
                {
                   NomeComunePianta = "LUPINO",
                   NomeFamiglia = "Leguminose",
                   NomeScientificoPianta = "Lupinus polyphyllus",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Lupino/LUPINO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "GENERE MOLTO AMATO IN GRAN BRETAGNA E GERMANIA, COMPRENDE PIANTE ANNUALI E PERENNI, CHE PRESENTANO GRANDI FOGLIE PALMATE, FORMATE DA NUMEROSE FOGLIOLINE; FRA ESSE SI ERGONO ALTI (DA 50 A 150 CM) RACEMI DENSAMENTE COSPARSI DI FIORI DI DIVERSI COLORI (BLU, VIOLETTO, BIANCO, GIALLO, ROSSO, ROSA, ANCHE MESCOLATI FRA LORO). LA FIORITURA AVVIENE IN MAGGIO-GIUGNO. L’UTILIZZO È COME QUINTA NELLE AIUOLE E PER BORDURE ALTE; SCONSIGLIATA LA COLTIVAZIONE IN VASO.",
                   Coltivazione = "Resiste al gelo con una piccola pacciamatura alla base; non tollera invece il caldo eccessivo e la salsedine. Richiede un terreno fertile, profondo, fresco, leggermente acido, ben drenato ma non asciutto. L’esposizione deve essere soleggiata o a mezz’ombra. Le irrigazioni devono essere abbondanti e regolari in primavera-estate. La concimazione si effettua in autunno e primavera con un prodotto organico a lenta cessione.",
                   Potatura = "",
                   Malattie = "",
                },

                new ErbaceePerenni
                {
                   NomeComunePianta = "MALVE DA FIORE",
                   NomeFamiglia = "Malvacee",
                   NomeScientificoPianta = "Lavatera trimestris, Alcea rosea",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Malve da Fiore/MALVE DA FIORE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "LAVATERA TRIMESTRIS È LA MALVA REGINA, CHE FORMA GRANDI CESPUGLI, LARGHI FINO A 1 M E ALTI FINO A 1,3 M, COPERTI DI NUMEROSI FIORI A CAMPANA BIANCHI, ROSA, ROSSI, CON VENATURE A CONTRASTO, DA LUGLIO A OTTOBRE. ALCEA (O ALTHAEA) ROSEA È IL MALVONE O MALVAROSA, CHE CREA, DA UNA ROSA BASALE DI GRANDI FOGLIE, ALTI FUSTI (FINO A 2 M) CHE PORTANO GRANDI FIORI A OMBRELLO, BIANCHI, ROSA, GIALLI, SALMONE, ROSSI, PORPORA, ANCHE DOPPI, IN LUGLIO-AGOSTO.",
                   Coltivazione = "L. trimestris sopravvive all’inverno solo nelle zone più miti, mentre A. rosea vive anche sulle Alpi oltreché nel Meridione costiero. Desiderano un terreno leggero, sciolto, mediamente fertile, anche arido o sassoso, e un’esposizione in pieno sole. Le annaffiature si limitano a interventi sporadici durante i periodi più caldi. La concimazione consiste in un apporto autunnale e uno primaverile a lenta cessione.",
                   Potatura = "",
                   Malattie = "",
                },

                new ErbaceePerenni
                {
                   NomeComunePianta = "NICOTIANA",
                   NomeFamiglia = "Solanacee",
                   NomeScientificoPianta = "Nicotiana",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Nicotiana/NICOTIANA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "CHIAMATA ANCHE TABACCO DA FIORE, È RAPPRESENTATA DA NUMEROSE CULTIVAR, SIA ALTE (80-150 CM) PER LA COLTIVAZIONE IN PIENA TERRA, SIA BASSE (30-40 CM) PER LA COLTIVAZIONE IN VASO. TUTTE SONO MOLTO PROFUMATE: SPICCA NICOTIANA AFFINIS, A FIORE BIANCO, CHE PROFUMA SOLO DI SERA. TRA LE PIÙ ALTE C’È N. SYLVESTRIS, CHE RAGGIUNGE IL METRO E MEZZO. N. LANGSDORFII HA CURIOSI FIORI VERDI, PICCOLI E IMBUTIFORMI; ‘LIME GREEN’ HA FIORI VERDI STELLATI.",
                   Coltivazione = "Non tollera il freddo (deperisce già a +5 °C). Richiede un terreno molto fertile e ricco di humus, umido ma comunque ben drenato. La posizione migliore è in in ombra leggera, soprattutto nelle zone molto calde in estate. Necessita di abbondanti e regolari annaffiature estive (soprattutto al Sud), durante le quali effettuare periodiche concimazioni con prodotti liquidi per piante da fiore ogni 15 giorni.",
                   Potatura = "",
                   Malattie = "",
                },

                new ErbaceePerenni
                {
                   NomeComunePianta = "PAPAVERO ORIENTALE",
                   NomeFamiglia = "Papaveracee",
                   NomeScientificoPianta = "Papaver orientale, P. nudicaule",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Papavero Orientale/PAPAVERO ORIENTALE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "IL GENERE COMPRENDE SPECIE ANNUALI E PERENNI, TUTTE CARATTERIZZATE DA UNA ROSETTA DI FOGLIE DENTATE DA CUI SI ERGONO GLI STELI FIORALI IN MAGGIO-LUGLIO. PAPAVER ORIENTALE PRODUCE GRANDI FIORI (FINO A 15 CM DI DIAMETRO) BIANCHI, ROSA O ROSSI CON CENTRO NERO, SEMPLICI O DOPPI. P. NUDICAULE PORTA FIORI (DIAMETRO 6-7 CM) BIANCHI, GIALLI, ROSA O ARANCIONI. P. SOMNIFERUM (PAPAVERO DA OPPIO), DAI GRANDI FIORI ROSA DOPPI, NON È COLTIVABILE IN ITALIA PER LEGGE.",
                   Coltivazione = "Sono tutte specie che non temono il gelo, perché perdono la parte aerea in autunno, per ricrearla in primavera. Amano terreni mediamente fertili, sciolti, leggeri, molto ben drenati, anche aridi o sassosi. L’esposizione deve essere in pieno sole. Si annaffiano sporadicamente in estate, all’occorrenza. Si concimano in autunno e in primavera con un prodotto a lenta cessione. Non sono adatti alla coltivazione in vaso.",
                   Potatura = "",
                   Malattie = "",
                },

                new ErbaceePerenni
                {
                   NomeComunePianta = "PHLOX",
                   NomeFamiglia = "Polemoniacee",
                   NomeScientificoPianta = "Phlox paniculata, P. douglasii, P. subulata",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Phlox/PHLOX.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "IL GENERE ANNOVERA PIANTE ANNUALI E PERENNI. QUELLE PIÙ COLTIVATE SONO PHLOX PANICULATA, P. DOUGLASII, P. SUBULATA, CIASCUNA RICCA DI VARIETÀ FLORICOLE DI OGNI FORMA E COLORE. HANNO FUSTI ERBACEI RAMIFICATI, ALTI DA 40 A 120 CM, A PORTAMENTO ERETTO O STRISCIANTE, CHE TERMINANO CON NUMEROSI CORIMBI DI FIORI TUBULOSI, DI 2-3 CM DI DIAMETRO, VARIAMENTE COLORATI E SCREZIATI (TUTTI I COLORI TRANNE BLU E VIOLA), DI GRANDE EFFETTO DECORATIVO.",
                   Coltivazione = "Non temono assolutamente il freddo. Desiderano un terreno fertile, sciolto, abbastanza fresco e ben drenato. L’esposizione deve essere soleggiata o al massimo a mezz’ombra. Necessitano di annaffiature regolari e mediamente abbondanti durante il periodo più caldo. Si concimano con un prodotto per piante da fiore ogni 15 giorni in primavera-estate; con uno organico a lenta cessione in autunno.",
                   Potatura = "",
                   Malattie = "",
                },

                new ErbaceePerenni
                {
                   NomeComunePianta = "PULSATILLA",
                   NomeFamiglia = "Ranuncolacee",
                   NomeScientificoPianta = "Anemone pulsatilla",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Pulsatilla/PULSATILLA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "SPECIE SPONTANEA SULLE NOSTRE MONTAGNE, IN MARZO-APRILE PRODUCE FIORI SOLITARI COMPOSTI DA PETALI-SEPALI VIOLETTI, FINEMENTE PELOSI, CON FOGLIE FRASTAGLIATE COME RICAMI, MOLTO DECORATIVE, CHE VANNO VIA VIA RIMPICCIOLENDOSI LUNGO LO STELO DEI FIORI. È ADATTA AL GIARDINO ROCCIOSO PERCHÉ RAGGIUNGE UN’ALTEZZA MASSIMA DI 10 CENTIMETRI. PULSATILLA ALPINA HA FIORI ESTIVI BIANCHI O GIALLI; P. VERNALIS HA FIORI PRIMAVERILI VIOLACEI E BIANCHI.",
                   Coltivazione = "Per l’origine alpina non teme il gelo, ma non resiste in zone calde o costiere. Necessita di un terreno fresco, fertile, non pesante, ben drenato ma sempre leggermente umido. L’esposizione deve essere soleggiata, ma a mezz’ombra in piena estate. L’irrigazione deve essere regolare e piuttosto abbondante durante il periodo più caldo. La concimazione si riduce a un apporto autunnale di concime organico.",
                   Potatura = "",
                   Malattie = "",
                },

                new ErbaceePerenni
                {
                   NomeComunePianta = "RUDBECKIA",
                   NomeFamiglia = "Composite",
                   NomeScientificoPianta = "Rudbeckia",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Rudbeckia/RUDBECKIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTA CHE SVILUPPA LARGHI CESPI ERETTI, DATI DA SOTTILI FUSTI SEMILEGNOSI, CHE PORTANO NUMEROSE FOGLIE DI COLORE VERDE CHIARO, LANCEOLATE, LUNGHE FINO A 10-15 CM, CHE RIMPICCIOLISCONO VERSO L’APICE DEI FUSTI (CHE SONO RAMIFICATI), DOVE SBOCCIANO LARGHI FIORI A MARGHERITA, CON DIAMETRO DI 10 CM, DI COLORE GIALLO, ARANCIO, ROSSO, CON CENTRO MARRONE (L’ALTEZZA TOTALE ARRIVA A 110 CENTIMETRI). LA FIORITURA AVVIENE DA LUGLIO A OTTOBRE.",
                   Coltivazione = "Non teme il freddo né il caldo; tollera l’inquinamento e la salsedine. Vive bene in ogni terreno, anche se predilige quelli abbastanza fertili e molto ben drenati. Può essere coltivata anche in vaso, purché sia grande. Richiede un’esposizione soleggiata o al massimo a mezz’ombra. Le annaffiature devono essere regolari e mediamente abbondanti in estate, accompagnate da concimazioni liquide ogni 15 giorni.",
                   Potatura = "",
                   Malattie = "",
                },

                new ErbaceePerenni
                {
                   NomeComunePianta = "SANTOLINA",
                   NomeFamiglia = "Composite",
                   NomeScientificoPianta = "Santolina chamaecyparissus",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Santolina/SANTOLINA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTA DAL PORTAMENTO ERETTO O SEMIPROSTRATO A FORMARE UN CUSCINO COMPATTO, MOLTO AROMATICA, UNIFORMEMENTE GRIGIO-TOMENTOSA, CON PICCOLI FUSTI ERETTI E RAMIFICATI, ALTI 30-50 CM. LE FOGLIE HANNO LA LAMINA A CONTORNO STRETTAMENTE LINEARE, PETTINATO-DENTATA, BREVEMENTE INCISA. IN GIUGNO-LUGLIO PRODUCE PICCOLI FIORI GIALLO-ORO, ARROTONDATI, RIUNITI IN INFIORESCENZE GLOBOSE APICALI MOLTO VISTOSE CHE SI PRESTANO PER COMPOSIZIONI SECCHE.",
                   Coltivazione = "Resiste al freddo e anche al gelo se viene abbondantemente pacciamata alla base. Predilige terreni poveri e ben drenati, anche sassosi e aridi o scoscesi, con esposizione in pieno sole. Non teme la siccità: va annaffiata in estate solo se coltivata in vaso. Non necessita di concime. Sopporta bene le potature, che è consigliabile eseguire a inizio primavera soprattutto per rinnovare le piante più vecchie che tendono ad “aprirsi”.",
                   Potatura = "",
                   Malattie = "",
                },

                new ErbaceePerenni
                {
                   NomeComunePianta = "VIOLACCIOCCA",
                   NomeFamiglia = "Crucifere",
                   NomeScientificoPianta = "Matthiola incana, Cheiranthus",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Violaciocca/VIOLACCIOCCA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "PERENNI SPESSO COLTIVATE COME ANNUALI, HANNO FUSTI ERETTI, ALTI 25-40 CM, RAMIFICATI ALL’APICE, CON FOGLIE VERDI FINEMENTE PUBESCENTI. TRA MARZO E GIUGNO PRODUCONO NUMEROSE SPIGHE RICOPERTE DA PICCOLI FIORI A QUATTRO PETALI, MOLTO PROFUMATI, DI COLORE ROSA, ROSSO, GIALLO, ARANCIONE O PORPORA, ANCHE CON ZONATURE O MACCHIE DI COLOR BRONZO. PER UNA FIORITURA PIÙ ABBONDANTE, SI CONSIGLIA DI RIMUOVERE SUBITO LE SPIGHE DI FIORI APPASSITI.",
                   Coltivazione = "Resistono al freddo padano ma non al gelo alpino. Amano i terreni mediamente fertili, leggermente alcalini, ben drenati; quelli poveri vanno arricchiti con letame maturo. Preferiscono una collocazione in pieno sole, ma accettano la mezz’ombra. Necessitano di irrigazioni estive frequenti e abbondanti. Si concimano per tutta la primavera, con prodotti per piante da fiore, per avere una piccola rifioritura in settembre.",
                   Potatura = "",
                   Malattie = "",
                },

                new ErbaceePerenni
                {
                   NomeComunePianta = "VIOLE",
                   NomeFamiglia = "Violacee",
                   NomeScientificoPianta = "Viola x hybrida, V. tricolor, V. odorata",
                   FotoPianta = "ms-appx:///Immagini/Erbacee/Viole/VIOLE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Erbacee/Abete-*.jpg",

                   DescrizioneBotanica = "V. X HYBRIDA È LA VIOLA DEL PENSIERO, DAI FIORI GRANDI, MULTICOLORI, SPESSO CON OCCHIO NERO ALLA BASE. V. TRICOLOR È UNA VIOLA SPONTANEA CON FIORI PICCOLI NEI TRE COLORI, BIANCO, GIALLO, VIOLA. V. ODORATA È LA VIOLA MAMMOLA, SPONTANEA NEI BOSCHI, DAI PICCOLI FIORI COLOR VIOLA PALLIDO, PROFUMATISSIMI (LE ALTRE SONO INODORI). LE FOGLIE SONO VERDE SCURO, OVATE O CUORIFORMI; LA FIORITURA AVVIENE IN MARZO-APRILE PER LA PRIMA, IN AUTUNNO-INVERNO PER LE ALTRE.",
                   Coltivazione = "Non temono il gelo. Sono indifferenti riguardo al terreno, che deve solo essere ben drenato e leggermente umido. Necessitano del pieno sole dall’autunno ad aprile, e della mezz’ombra o ombra negli altri mesi. Vanno annaffiate durante i mesi più caldi, con regolarità ma non in eccesso. Si concimano in autunno e in primavera con un prodotto a lenta cessione. Si moltpilicano per talea o anche per seme.",
                   Potatura = "",
                   Malattie = "",
                },



            };

            return data;
        }

        // TODO WTS: Remove this once your MasterDetail pages are displaying real data
        public static async Task<IEnumerable<ErbaceePerenni>> GetSampleModelDataAsync()
        {
            await Task.CompletedTask;

            return AllErbaceePerenni();
        }

        
    }
}
