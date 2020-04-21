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
//15 PIANTE GRASSE
    public class PianteGrasse
    {
        public string NomeComunePianta { get; set; }
        public string NomeFamiglia { get; set; }
        public string NomeScientificoPianta { get; set; }
        public string FotoPianta { get; set; }
        public string SourceGalleryFotografica { get; set; }

        public string DescrizioneBotanica { get; set; }
        public string Coltivazione { get; set; }
        public string Malattie { get; set; }
        public string AltreCaratteristiche { get; set; }


    }

    public static class PianteGrasseDataService
    {
        private static IEnumerable<PianteGrasse> AllPianteGrasse()
        {
            // The following is order summary data
            var data = new ObservableCollection<PianteGrasse>
            {
               
                new PianteGrasse
                {
                   NomeComunePianta = "AGAVE",
                   NomeFamiglia = "Agavacee",
                   NomeScientificoPianta = "Agave americana, A. victoria-reginae",
                   FotoPianta = "ms-appx:///Immagini/Grasse/Agave/AGAVE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Grasse/Abete-*.jpg",

                   DescrizioneBotanica = "LE RADICI SONO ESILI MA ABBONDANTI, CAPACI DI PENETRARE IN PROFONDITÀ ALLA RICERCA DELL’ACQUA. IL FUSTO È MOLTO CORTO. LE FOGLIE, CARNOSE E CON UNA SPINA ROBUSTA ALL’APICE, PARTONO NUMEROSE DALLA BASE, AFFASTELLATE FRA LORO. UNA CARATTERISTICA DELLE FOGLIE È QUELLA DI ESSERE MOLTO CARNOSE E TOZZE. LA FIORITURA AVVIENE SOLO SULLA PIANTA ADULTA, CHE MUORE SUBITO DOPO, LASCIANDO PERÒ I POLLONI BASALI. L’INFIORESCENZA È ALTA ANCHE 10 M.",
                   Coltivazione = "A. americana raggiunge grandi dimensioni: può essere allevata in piena terra solo nel Sud Italia, dove gli esemplari adulti non necessitano di protezioni, altrimenti in vaso nel Nord, da coprire bene o ritirare in serra fredda in inverno (temperatura minima –5 °C). A. victoria-reginae si alleva solo in vaso. Desiderano un terriccio sciolto e molto ben drenato. Non necessitano di irrigazioni né di concimazioni.",
                   Malattie = "",
                },

                new PianteGrasse
                {
                   NomeComunePianta = "ALOE",
                   NomeFamiglia = "Aloacee",
                   NomeScientificoPianta = "Aloe vera, A. ferox, A. saponaria",
                   FotoPianta = "ms-appx:///Immagini/Grasse/Aloe/ALOE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Grasse/Abete-*.jpg",

                   DescrizioneBotanica = "GENERE SIMILE AD AGAVE, DA CUI SI DIFFERENZIA PER LA MANCANZA DELLA SPINA APICALE (MA LE FOGLIE POSSONO ESSERE RICOPERTE DA SPINE AI MARGINI E ANCHE SULLA PAGINA INFERIORE) E PER LA FIORITURA CHE AVVIENE ANCHE IN SOGGETTI GIOVANI, SENZA CHE MUOIANO SUBITO DOPO. A. VERA È UNA PIANTA MEDICAMENTOSA, DA CUI SI RICAVA UNA SOSTANZA EMOLLIENTE. A. FEROX HA NUMEROSE SPINE SUI MARGINI E SULLA PAGINA INFERIORE DELLE FOGLIE. A. SAPONARIA HA FOGLIE MACULATE DI BIANCO.",
                   Coltivazione = "Tutte le aloe non tollerano temperature inferiori a 0 °C: nel Sud possono essere coltivate in piena terra, nel Nord solo in vaso, da ritirare sul pianerottolo o in un locale fresco in inverno. Il substrato deve essere leggero, molto ben drenato. Le irrigazioni, sospese durante l’inverno, si effettuano in vaso dalla primavera alla fine dell’estate, dopo che la terra si è ben asciugata. Si concimano da marzo a settembre.",
                   Malattie = "",
                },

                new PianteGrasse
                {
                   NomeComunePianta = "CACTUS DI NATALE",
                   NomeFamiglia = "Cactacee",
                   NomeScientificoPianta = "Schlumbergera",
                   FotoPianta = "ms-appx:///Immagini/Grasse/Cactus di Natale/CACTUS DI NATALE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Grasse/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTA CHE DEVE IL NOME COMUNE ALLA CARATTERISTICA DI AVVIARE LA FIORITURA NEL MESE DI NOVEMBRE, PROTRAENDOLA FINO A MARZO. CARATTERIZZATA DA FUSTI APPIATTITI, SOTTILI, SEGMENTATI, CON UN’EVIDENTE COSTOLATURA CENTRALE LONGITUDINALE E MARGINI LEGGERMENTE LOBATI, PRIVI DI SPINE. ALL’APICE DEI FUSTI SI FORMANO FIORI DI DIMENSIONI MEDIE, IN NUMERO DI 3-4 PER OGNI APICE, DI COLORE BIANCO, GIALLO, ARANCIO, ROSA, ROSSO, VIOLA A SECONDA DELLE VARIETÀ FLORICOLE.",
                   Coltivazione = "Non tollera temperature inferiori a +8 °C, né superiori a 18 °C (in fioritura: se si superano, i boccioli cadono). In genere viene coltivata in vaso. Necessita di un substrato mediamente fertile, soffice, fresco. Desidera molta luce, ma non i raggi diretti del sole. Le annaffiature devono essere molto moderate, solo dopo che il terriccio si è asciugato. La concimazione si effettua durante tutta l’estate e per tutta la fioritura.",
                   Malattie = "",
                },

                new PianteGrasse
                {
                   NomeComunePianta = "CALANCOE",
                   NomeFamiglia = "Crassulacee",
                   NomeScientificoPianta = "Kalanchoe blossfeldiana",
                   FotoPianta = "ms-appx:///Immagini/Grasse/Calancoe/CALANCOE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Grasse/Abete-*.jpg",

                   DescrizioneBotanica = "GENERE DI PIÙ DI 200 SPECIE, FRA LE QUALI LA PIÙ DIFFUSA È K. BLOSSFELDIANA. È CARATTERIZZATA DA FUSTI VERDI SUCCULENTI CHE DIVENGONO GRIGI E LEGNOSI NEGLI ESEMPLARI ADULTI, MOLTO RAMIFICATI, ALTI FINO A 50 CM; LE FOGLIE SONO DI MEDIE DIMENSIONI, CARNOSE, OVALI CON MARGINE DENTELLATO, COLOR VERDE SMERALDO. I FIORI, PORTATI IN INFIORESCENZE, SONO PICCOLI MA NUMEROSI, DI COLORE BIANCO, GIALLO, ARANCIO, ROSA O ROSSO, SEMPLICI, SEMIDOPPI O DOPPI NELLE VARIETÀ FLORICOLE.",
                   Coltivazione = "Resiste fino a +10 °C: al Sud si coltiva in piena terra solo in posizioni molto riparate e soleggiate; al Nord si alleva in vaso, da ricoverare in serra calda (ma non in casa) durante l’inverno. Il terriccio deve essere leggero e ben drenato; l’esposizione ben soleggiata. Le annaffiature sono più frequenti nella bella stagione, quasi nulle in inverno. La concimazione si effettua da marzo a settembre con un prodotto specifco.",
                   Malattie = "",
                },

                new PianteGrasse
                {
                   NomeComunePianta = "CRASSULA",
                   NomeFamiglia = "Crassulacee",
                   NomeScientificoPianta = "Crassula ovata",
                   FotoPianta = "ms-appx:///Immagini/Grasse/Crassula/CRASSULA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Grasse/Abete-*.jpg",

                   DescrizioneBotanica = "SONO OLTRE 300 LE SPECIE DI CRASSULA, FRA LE QUALI C. OVATA È LA PIÙ NOTA. È UN PICCOLO ALBERO, ALTO FINO A 1 M, CON FUSTO GRIGIO-MARRONE, ROBUSTO, CILINDRICO, RAMIFICATO IN ALTO A FORMARE UNA CHIOMA TONDEGGIANTE. LE FOGLIE SONO OVALI, ABBASTANZA PICCOLE, PIATTE, CARNOSE, NUMEROSE, COLOR VERDE INTENSO. FUSTO E FOGLIE SI ROMPONO FACILMENTE SE URTATI. IN AUTUNNO PRODUCE PICCOLI GRAPPOLI DI FIORELLINI BIANCHI, NUMEROSISSIMI.",
                   Coltivazione = "Può essere coltivata in piena terra solo nel Sud, in posizione riparata dai venti freddi e ben soleggiata; altrove si alleva in vaso (adatto alle dimensioni della pianta), da ritirare in serra calda durante l’inverno (soffre già a +10 °C). Il terriccio deve essere sciolto e molto ben drenato. Le irrigazioni devono essere limitate al periodo estivo, in vaso, e applicate solo su terra ben asciutta. Le concimazioni si effettuano da marzo a settembre.",
                   Malattie = "",
                },

                new PianteGrasse
                {
                   NomeComunePianta = "CUSCINO DELLA SUOCERA",
                   NomeFamiglia = "Cactacee",
                   NomeScientificoPianta = "Echinocactus grusonii",
                   FotoPianta = "ms-appx:///Immagini/Grasse/Cuscino della Suocera/CUSCINO DELLA SUOCERA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Grasse/Abete-*.jpg",

                   DescrizioneBotanica = "CHIAMATO ANCHE PALLA D’ORO, È UN CACTUS CON FORMA GLOBOSA E CRESCITA MOLTO LENTA: IN NATURA RAGGIUNGE I 90 CM DI DIAMETRO, IN VASO I 70 CM, MA IN ALCUNE DECINE DI ANNI. I FUSTI HANNO COSTOLE IN RILIEVO, ORNATE DA ROBUSTE SPINE GIALLE, LUNGHE FINO A 3 CM, E GROSSE AREOLE LANUGINOSE ALL’APICE DELLA PIANTA. I FIORI, PRODOTTI DOPO ALMENO 10 ANNI D’ETÀ, SONO IMBUTIFORMI, DI COLORE GIALLO, E POSSONO RAGGIUNGERE UNA LUNGHEZZA DI 7 CENTIMETRI.",
                   Coltivazione = "Resistono all’aperto in giardino solo nel Sud Italia (temperatura minima +5 °C); altrove vanno coltivati in vaso (di terracotta, preferibilmente a forma di ciotola, dato che l’apparato radicale non è molto espanso) da ricoverare in un luogo fresco in inverno. Necessita di un substrato leggero e ben drenato e di molta luce, anche diretta. Le annaffiature delle piante in vaso si effettuano nella bella stagione, su terra asciutta.",
                   Malattie = "",
                },

                new PianteGrasse
                {
                   NomeComunePianta = "ECHEVERIA",
                   NomeFamiglia = "Crassulacee",
                   NomeScientificoPianta = "Echeveria",
                   FotoPianta = "ms-appx:///Immagini/Grasse/Echeveria/ECHEVERIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Grasse/Abete-*.jpg",

                   DescrizioneBotanica = "GENERE CHE COMPRENDE UNA DECINA DI SPECIE, CARATTERIZZATE DA UNA DENSA ROSETTA DI FOGLIE ADDENSATE, DI DIAMETRO FINO AI 10 CM; DALLA BASE DELLA ROSETTA PRINCIPALE SI DIRAMANO STOLONI CHE PRODUCONO ANCH’ESSI ALL’APICE UNA ROSETTA FOGLIARE. LE FOGLIE SONO CARNOSE, OVALI O TRIANGOLARI, DI COLORE VERDE, GRIGIASTRO, GRIGIO-AZZURRO, ROSATO. FRA MAGGIO E AGOSTO DAL CENTRO DELLA ROSETTA SI DIPARTE UN LUNGO STELO CHE PORTA PICCOLI FIORI ROSA O GIALLI.",
                   Coltivazione = "Teme temperature inferiori a +5 °C: si coltiva in piena terra solo in Meridione; nel Nord va allevata in vaso da ricoverare in una stanza fresca. Il substrato deve essere leggero e molto ben drenato. Ama posizioni molto soleggiate. Le irrigazioni si applicano da maggio a settembre, sugli esemplari in vaso, solo su terra asciutta. Si concima nello stesso periodo con un prodotto specifico per piante grasse.",
                   Malattie = "",
                },

                new PianteGrasse
                {
                   NomeComunePianta = "ECHINOPSIS",
                   NomeFamiglia = "Cactacee",
                   NomeScientificoPianta = "Echinopsis",
                   FotoPianta = "ms-appx:///Immagini/Grasse/Echinopsis/ECHINOPSIS.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Grasse/Abete-*.jpg",

                   DescrizioneBotanica = "COMPRENDE UNA DECINA DI SPECIE, CON FUSTI GLOBOSI O TUBOLARI, COSTOLUTI, COLOR VERDE CHIARO O SCURO, CON PICCOLE AREOLE SUL BORDO DELLE COSTOLE, COPERTE DI SPINE. LE DIMENSIONI VARIANO DA 3 A 50 CM, SECONDO LA SPECIE. I FIORI, CHE COMPAIONO IN PIANTE ADULTE TRA GIUGNO E AGOSTO, SONO GRANDI (DIAMETRO FINO A 12 CM), A FORMA DI IMBUTO, BIANCHI O ROSA (IN ALTRE TINTE NEGLI IBRIDI); OGNI FIORE SI APRE AL MATTINO E SI CHIUDE LA SERA, PER UNA DURATA MASSIMA DI 3 GIORNI.",
                   Coltivazione = "In genere teme temperature inferiori a +5 °C, quindi va coltivato in piena terra solo nelle zone miti, mentre nel Nord Italia va allevato in vaso, da proteggere in un luogo fresco d’inverno. Necessita di un substrato leggero e molto ben drenato, da annaffiare solo da aprile a settembre, dopo che il terriccio si è asciugato. Va concimato con un prodotto apposito da aprile fino ad agosto. I fiori appassiti si staccano da soli.",
                   Malattie = "",
                },

                new PianteGrasse
                {
                   NomeComunePianta = "FEROCACTUS",
                   NomeFamiglia = "Cactacee",
                   NomeScientificoPianta = "Ferocactus",
                   FotoPianta = "ms-appx:///Immagini/Grasse/Ferocactus/FEROCACTUS.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Grasse/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTE DI FORMA GLOBOSA, PIÙ RARAMENTE CILINDRICA, DALLA CRESCITA MOLTO LENTA, PER UN DIAMETRO MASSIMO DI 50 CM. DOTATE DI COSTOLE MOLTO PRONUNCIATE, ORNATE DA SPINE GIALLO-ROSSE O ROSSE ROBUSTISSIME E LUNGHE FINO A 4 CENTIMETRI. ALL’APICE DELLA PIANTA SONO PRESENTI AREOLE LANUGINOSE. LA FIORITURA, SPETTACOLARE PER I GRANDI (FINO A 8 CM DI DIAMETRO) FIORI SINGOLI, ROSSI, ROSA O GIALLI, CHE DURANO UN SOLO GIORNO, AVVIENE UNICAMENTE IN ESEMPLARI ADULTI.",
                   Coltivazione = "Resiste fino a temperature di +5 °C. Si coltiva in piena terra nel Sud Italia, in vaso nel Nord, ricoverandolo in un luogo fresco durante l’inverno. Richiede un’esposizione luminosa, anche in pieno sole. Il terriccio deve essere ben drenato e sciolto. Le annaffiature si intensificano da aprile a settembre e si diradano negli altri mesi. Le concimazioni, nello stesso periodo, si effettuano con un concime apposito.",
                   Malattie = "",
                },

                new PianteGrasse
                {
                   NomeComunePianta = "LINGUA DI SUOCERA",
                   NomeFamiglia = "Cactacee",
                   NomeScientificoPianta = "Epiphyllum ackermannii",
                   FotoPianta = "ms-appx:///Immagini/Grasse/Lingua di Suocera/LINGUA DI SUOCERA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Grasse/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTA CARATTERIZZATA DA FUSTI APPIATTITI E ALLUNGATI, DI COLORE VERDE INTENSO, LUNGHI FINO A 80 CM, RICADENTI SE LA PIANTA VIENE COLTIVATA IN BASKET O SU UN PIEDISTALLO, CON MARGINI DENTELLATI O ONDULATI E ORNATI DA SOTTILI SPINE MORBIDE (FOGLIE TRASFORMATE). LUNGO I MARGINI SBOCCIANO I FIORI, A FORMA DI IMBUTO, GRANDI (FINO A 18 CM DI DIAMETRO), ROSSI IN E. ACKERMANNII, BIANCHI, GIALLI, ROSA, VIOLA O BICOLORI NELLE VARIETÀ, CHE DURANO UN SOLO GIORNO.",
                   Coltivazione = "Tollera temperature minime di +5 °C, al di sotto dei quali deve essere protetto in un ambiente fresco; la coltivazione in piena terra non viene di solito attuata nemmeno nel Sud a causa del portamento tappezzante. Il substrato deve essere leggero e ben drenato; l’esposizione a mezz’ombra; le annaffiature abbastanza frequenti da maggio ad agosto; le concimazioni nello stesso periodo, con un prodotto specifico",
                   Malattie = "",
                },

                new PianteGrasse
                {
                   NomeComunePianta = "MAMMILLARIA",
                   NomeFamiglia = "Cactacee",
                   NomeScientificoPianta = "Mammillaria",
                   FotoPianta = "ms-appx:///Immagini/Grasse/Mammillaria/MAMMILLARIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Grasse/Abete-*.jpg",

                   DescrizioneBotanica = "GENERE CHE COMPRENDE ALCUNE CENTINAIA DI SPECIE, CHE SI DIFFERENZIANO MOLTO PER FORMA: POSSONO AVERE FUSTO CILINDRICO O GLOBOSO, O ESSERE UNITI IN GRUPPI MOLTO DENSI. I FUSTI SONO ORNATI DA FITTI TUBERCOLI ALL’APICE DEI QUALI SONO COPERTI DI SPINE, CORTE, SOTTILI, MORBIDE E CHIARE. I FIORI, NUMEROSI E PICCOLI, SONO DISPOSTI A CORONA SULLA PUNTA DELLA PIANTA; HANNO COLORE GIALLO, ROSA, ROSSO O VIOLA E COMPAIONO GIÀ NEI PRIMI ANNI DI VITA.",
                   Coltivazione = "Tollera temperature fino a +8 °C; in genere si coltiva sempre in vaso, anche a causa delle piccole dimensioni (al massimo 20 cm di diametro), proteggendolo durante l’inverno in un luogo fresco. Richiede il pieno sole e un terriccio ben drenato e leggero. Si annaffia da aprile a settembre, solo dopo che il substrato si è del tutto asciugato. Per favorire la fioritura, si concima con un prodotto apposito nell’acqua d’irrigazione.",
                   Malattie = "",
                },

                new PianteGrasse
                {
                   NomeComunePianta = "MESEMBRIANTEMI",
                   NomeFamiglia = "Mesembriantemacee",
                   NomeScientificoPianta = "Delosperma, Lampranthus, Dorotheanthus",
                   FotoPianta = "ms-appx:///Immagini/Grasse/Mesembriantemi/MESEMBRIANTEMI.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Grasse/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTE TAPPEZZANTI PERENNI, DAI SOTTILI FUSTI PROSTRATI, MOLTO RAMIFICATI, CARNOSI, CHE PORTANO NUMEROSE FOGLIOLINE A FORMA DI TRIANGOLO APPUNTITO, CARNOSE, LUNGHE 3-4 CM, DI COLORE VERDE GRIGIASTRO. IN PRIMAVERA PRODUCONO NUMEROSISSIMI FIORI A FORMA DI MARGHERITA, DEL DIAMETRO DA 1 A 12 CM E DI COLORE BIANCO, ROSA, VIOLA O ROSSO, A SECONDA DELLA SPECIE. APTENIA CORDIFOLIA E DELOSPERMA COOPERI PROSEGUONO LA FIORITURA FINO A OTTOBRE.",
                   Coltivazione = "Tranne A. cordifolia (sensibile già a +10 °C), le altre specie sopportano fino a +5 °C. Solo in Meridione possono essere coltivate in piena terra; nel Nord vanno allevate in vaso, da ricoverare in un luogo fresco ma non freddo. Richiedono un terriccio sciolto e molto ben drenato. Solo se in vaso, vogliono annaffiature (primaverili-estive), che possono essere distanziate di 10 giorni. Vanno concimate con un prodotto apposito.",
                   Malattie = "",
                },

                new PianteGrasse
                {
                   NomeComunePianta = "SANSEVIERIA",
                   NomeFamiglia = "Agavacee",
                   NomeScientificoPianta = "Sansevieria trifasciata",
                   FotoPianta = "ms-appx:///Immagini/Grasse/Sanseveria/SANSEVIERIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Grasse/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTA IN GENERE COLTIVATA IN APPARTAMENTO, CARATTERIZZATA DALL’ASSENZA DEL FUSTO. LE FOGLIE, BASALI, SONO SPADIFORMI O CILINDRICHE A SECONDA DELLA SPECIE, APPUNTITE, DI COLORE VERDE SCURO UNIFORME O CON BANDE LONGITUDINALI BIANCHE E/O GIALLE, OPPURE DI COLORE VERDE GLAUCO O VERDE-BLUASTRO O VERDE-BRUNO. IN APPARTAMENTO LA FIORITURA DI SOLITO NON SI VERIFICA. SECONDO STUDI SCIENTIFICI, QUESTO GENERE DI PIANTE PUÒ ASSORBIRE LE RADIAZIONI ELETTROMAGNETICHE.",
                   Coltivazione = "Tollera temperature minime di +8 °C; viene in genere coltivata in vaso anche nell’Italia meridionale. Necessita di un terriccio mediamente fertile, molto ben drenato, soffice. Desidera un’esposizione luminosa ma al riparo dai raggi diretti del sole. Le irrigazioni devono essere sporadiche, soprattutto d’inverno, e sempre su terriccio ben asciutto. Le concimazioni si effettuano una volta al mese nella bella stagione.",
                   Malattie = "",
                },

                new PianteGrasse
                {
                   NomeComunePianta = "SEDUM",
                   NomeFamiglia = "Crassulacee",
                   NomeScientificoPianta = "Sedum telephium, S. cooperii",
                   FotoPianta = "ms-appx:///Immagini/Grasse/Sedum/SEDUM.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Grasse/Abete-*.jpg",

                   DescrizioneBotanica = "GENERE DI 500 SPECIE, CON FUSTI CARNOSI PIÙ O MENO LIGNIFICATI NEGLI ESEMPLARI ADULTI, LUNGHI FINO A 40 CM, CON FOGLIE SUCCULENTE AGHIFORMI, OVALI O LANCEOLATE, DI COLORE VERDE GLAUCO, GRIGIASTRO, BLUASTRO A SECONDA DELLE SPECIE. I FIORI SONO A FORMA DI STELLA, IN INFIORESCENZE APICALI PIÙ O MENO DENSE, DI GRANDEZZA VARIABILE, DI COLORE GIALLO (S. ACRE, S. COOPERII), ROSA (S. TELEPHIUM) O BIANCO (S. ALBUM), E SBOCCIANO TRA MARZO E SETTEMBRE.",
                   Coltivazione = " Esistono specie rustiche (S. album, S. acre, S. telephium, S. cooperii) che tollerano fino a –5/–8 °C, e altre più delicate che sopportano solo fino a +5 °C; le prime si coltivano anche sulle Alpi in piena terra, in posizione ben soleggiata. Necessitano di un substrato fresco, leggero, ben drenato. L’irrigazione non è necessaria, salvo che durante l’estate se il vaso è molto piccolo. La concimazione non è indispensabile.",
                   Malattie = "",
                },

                new PianteGrasse
                {
                   NomeComunePianta = "SEMPERVIVUM",
                   NomeFamiglia = "Crassulacee",
                   NomeScientificoPianta = "Sempervivum tectorum, S. aracnoideum",
                   FotoPianta = "ms-appx:///Immagini/Grasse/Sempervivum/SEMPERVIVUM.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Grasse/Abete-*.jpg",

                   DescrizioneBotanica = "GENERE CHE COMPRENDE ALCUNE DECINE DI SPECIE, CARATTERIZZATE DA DENSE ROSETTE GLOBOSE O APPIATTITE DI FOGLIE CARNOSE, DI COLORE DAL VERDE CHIARO AL VERDE-BLU, FINO AL NERO-PORPORA, A VOLTE COPERTE DA UNA FITTA PELURIA. LE ROSETTE FORMANO AMPI CUSCINI E PRODUCONO STOLONI CON NUOVE ROSETTE CHE POSSONO RADICARE FORMANDO NUOVE PIANTE. I SOGGETTI DI ALMENO 3 ANNI D’ETÀ PRODUCONO UN RACEMO DI PICCOLI FIORI STELLATI, ALL’APICE DI UN LUNGO STELO.",
                   Coltivazione = "Resistono fino a –10 °C e alcune specie anche oltre; sono coltivabili in piena terra anche sulle Alpi, in posizione soleggiata e su terra ben drenata, fresca, soffice. Le annaffiature non sono necessarie, salvo che in estate su piante coltivate in vasi piccoli. Anche le concimazioni non sono fondamentali. Si utilizzano come tappezzanti in vaso, nelle aiuole, su muretti e anche su piccoli tetti rustici (capanni, garage ecc.).",
                   Malattie = "",
                },

               
            };

            return data;
        }

        // TODO WTS: Remove this once your MasterDetail pages are displaying real data
        public static async Task<IEnumerable<PianteGrasse>> GetSampleModelDataAsync()
        {
            await Task.CompletedTask;

            return AllPianteGrasse();
        }

        
    }
}
