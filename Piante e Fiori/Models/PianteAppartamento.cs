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
//27 PIANTE DA APPARTAMENTO
    public class PianteAppartamento
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

    public static class PianteAppartamentoDataService
    {
        private static IEnumerable<PianteAppartamento> AllPianteAppartamento()
        {
            // The following is order summary data
            var data = new ObservableCollection<PianteAppartamento>
            {
               
                new PianteAppartamento
                {
                   NomeComunePianta = "AECHMEA",
                   NomeFamiglia = "Bromeliacee",
                   NomeScientificoPianta = "Aechmea fasciata (sin. Billbergia rhodocyanea)",
                   FotoPianta = "ms-appx:///Immagini/Appartamento/Aechmea/AECHMEA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Appartamento/Abete-*.jpg",

                   DescrizioneBotanica = "EPIFITA DALL’APPARATO RADICALE MOLTO RIDOTTO, È PRIVA DI FUSTO MA CON IL FOGLIAME PUÒ RAGGIUNGERE I 50 CM D’ALTEZZA. LE FOGLIE, LARGHE 10 E LUNGHE 45 CM, HANNO MARGINI SPINOSI, FORMA ALLUNGATA E COLORE GRIGIO-VERDASTRO CON STRIATURE TRASVERSALI GRIGIO-ARGENTO. L’INFIORESCENZA, ALTA FINO A 40 CM, È DATA DA PICCOLI FIORI AZZURRI, CHE APPASSISCONO IN POCHI GIORNI, PROTETTI DA FITTE BRATTEE SPINOSE DI COLORE ROSA DI LUNGA DURATA (FINO A 6 MESI).",
                   Coltivazione = "La temperatura ideale è compresa fra 15 e 20 °C (minima 12 °C). Desidera una posizione luminosa ma non interessata dai raggi solari, un substrato molto fertile, leggero, perfettamente drenato. Si annaffia con regolarità ma non spesso in estate, versando l’acqua al centro dell’imbuto di foglie. Si concima una volta al mese, con un prodotto per piante verdi. Il vaso deve essere il più piccolo possibile.",
                   Propagazione = "Avviene in autunno per divisione dei rizomi, che solitamente producono germogli durante tutta la stagione vegetativa. Le nuove piantine vanno tenute in un luogo caldo e umido fino alla primavera successiva, quando si possono rinvasare in un vaso di dimensioni generose ",
                   Potatura = "Si eliminano le foglie danneggiate o ingiallite ",
                   Malattie = "Le carenze nutrizionali causano un rapido ingiallimento delle foglie, che spesso vengono anche attaccate da afidi e cocciniglia ",
                },

                new PianteAppartamento
                {
                   NomeComunePianta = "ALOCASIA",
                   NomeFamiglia = "Aracee",
                   NomeScientificoPianta = "Alocasia macrorrhiza, A. sanderiana",
                   FotoPianta = "ms-appx:///Immagini/Appartamento/Alocasia/ALOCASIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Appartamento/Abete-*.jpg",

                   DescrizioneBotanica = "CHIAMATE ANCHE ORECCHIE D’ELEFANTE, PER LA DIMENSIONE DELLE FOGLIE, SONO PERENNI E SEMPREVERDI. A. MACRORRHIZA PUÒ RAGGIUNGERE ANCHE 5 M D’ALTEZZA, HA FOGLIE ERETTE CON PICCIOLI LUNGHI ANCHE 2 M, DALLA LAMINA LARGA, OVATA, LUCIDA E DI COLORE VERDE BRILLANTE, CON NERVATURE PALLIDE. A. SANDERIANA È CARATTERIZZATA DA FOGLIE SAGITTATE, DI COLORE VERDE SCURO VIVO CON NERVATURE METALLICHE E MARGINI ARGENTATI, ONDULATI O LOBATI.",
                   Coltivazione = "La temperatura ideale è compresa fra 20 e 25 °C (minima 15 °C). Va posta in luogo luminoso ma senza raggi diretti; va girata due volte al mese. Preferisce un substrato fertile, leggero, torboso. Va annaffiata di frequente d’estate (su terreno asciutto), di rado d’inverno. Si concima una volta al mese, nella bella stagione, con un prodotto liquido per piante verdi. Si eliminano alla base le foglie ingiallite.",
                   Potatura = "",
                   Malattie = "",
                },

                new PianteAppartamento
                {
                   NomeComunePianta = "ANTURIO",
                   NomeFamiglia = "Aracee",
                   NomeScientificoPianta = "Anthurium andreanum, A. scherzerianum",
                   FotoPianta = "ms-appx:///Immagini/Appartamento/Anturio/ANTURIO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Appartamento/Abete-*.jpg",

                   DescrizioneBotanica = "ALLO STADIO GIOVANILE NON PRESENTA FUSTO, CHE SI FORMA INVECE NELL’ADULTO E SU CUI SI SVILUPPANO RADICI AVVENTIZIE. PUÒ RAGGIUNGERE I 50 CM D’ALTEZZA E DIAMETRO GRAZIE ALLE FOGLIE, LA CUI BASE È AFFASTELLATA E IL CUI PICCIOLO È MOLTO LUNGO; SONO CUORIFORMI, APPUNTITE, CORIACEE, DI COLORE VERDE SCURO. L’INFIORESCENZA È COSTITUITA DA UNO SPADICE GIALLO E DA UNA SPATA LUNGA 10 CM A FORMA DI CUORE E DI COLORE ROSSO, ROSA, BIANCO, GIALLO, VERDE SECONDO LE CULTIVAR.",
                   Coltivazione = "Predilige temperature di 15-20 °C (minima 10 °C). Non tollera le correnti d’aria fredda e il sole diretto; sopporta una luminosità media. Desidera un terriccio torboso e leggero. Necessita di abbondanti annaffiature in estate e con riscaldamento acceso, prima che il susbtrato si asciughi. Gradisce anche vaporizzazioni giornaliere. Va concimato con un prodotto per piante da fiore da marzo a settembre. Si rinvasa ogni 3 anni.",
                   Potatura = "",
                   Malattie = "",
                },

                new PianteAppartamento
                {
                   NomeComunePianta = "ASPARAGINA",
                   NomeFamiglia = "Liliacee",
                   NomeScientificoPianta = "Asparagus sprengeri",
                   FotoPianta = "ms-appx:///Immagini/Appartamento/Asparagina/ASPARAGINA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Appartamento/Abete-*.jpg",

                   DescrizioneBotanica = "HA PORTAMENTO RICADENTE CON RAMIFICAZIONI LUNGHE FINO A 1,5 M, FITTAMENTE COPERTE DI FALSE FOGLIE (CHIAMATE CLADODI) LUNGHE, VAPOROSE E PIUMOSE, DI COLORE VERDE BRILLANTE. PRODUCE FIORI PICCOLI, INSIGNIFICANTI, BIANCO-ROSATI, DELICATAMENTE PROFUMATI, RIUNITI IN INFIORESCENZE A RACEMO, AI QUALI SEGUONO BACCHE ROSSE. NON AMA GLI AMBIENTI RISCALDATI IN INVERNO E PREFERISCE PIANEROTTOLI, VERANDE E ALTRI LOCALI FRESCHI E MOLTO LUMINOSI.",
                   Coltivazione = "Preferisce temperature comprese fra 15 e 18 °C (minima 10 °C). Desidera una media luminosità, senza raggi solari diretti. Richiede un terriccio leggermente acido, con torba e materiale drenante. Le annaffiature devono essere abbondanti in primavera-estate, rade in autunno-inverno. La concimazione, da aprile a settembre, va fatta con un prodotto per piante verdi. Si deve rinvasare ogni 2 anni in primavera.",
                   Potatura = "",
                   Malattie = "",
                },

                new PianteAppartamento
                {
                   NomeComunePianta = "ASPIDISTRA",
                   NomeFamiglia = "Liliacee",
                   NomeScientificoPianta = "Aspidistra elatior",
                   FotoPianta = "ms-appx:///Immagini/Appartamento/Aspidistra/ASPIDISTRA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Appartamento/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTA RIZOMATOSA PRIVA DI FUSTO, È DOTATA DI FOGLIE CON UN LUNGO PICCIOLO CHE PARTE DIRETTAMENTE DAL TERRENO E UNA LAMINA LANCEOLATO-ACUMINATA, CORIACEA, DI COLORE VERDE SCURO, LUNGA FINO A 50 CM. I FIORI, PICCOLI, CARNOSI E COLOR PORPORA, SONO ABBASTANZA INSIGNIFICANTI E SBOCCIANO ALL’ALTEZZA DEL SUBSTRATO. NE ESISTE UNA VARIETÀ VARIEGATA, CHE È CARATTERIZZATA DA STRIATURE BIANCHE LONGITUDINALI, DA MANTENERE CON UNA BUONA LUMINOSITÀ AMBIENTALE.",
                   Coltivazione = "Preferisce temperature comprese fra 15 e 20 °C (minima 3 °C). Soffre negli ambienti riscaldati, mentre si trova bene in verande, pianerottoli o porticati. Tollera ambienti poco luminosi; non sopporta i raggi solari diretti. Necessita di un substrato torboso e leggero. Va annaffiata all’occorrenza, dopo che il terriccio si è asciugato, maggiormente in estate, di rado in inverno. Si concima con un prodotto per piante verdi.",
                   Potatura = "",
                   Malattie = "",
                },

                new PianteAppartamento
                {
                   NomeComunePianta = "CALATEA",
                   NomeFamiglia = "Marantacee",
                   NomeScientificoPianta = "Calathea makoyana",
                   FotoPianta = "ms-appx:///Immagini/Appartamento/Calatea/CALATEA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Appartamento/Abete-*.jpg",

                   DescrizioneBotanica = "LA CALATEA, DETTA ANCHE PIANTA DEL PAVONE, PUÒ CRESCERE FINO A 60 CM D’ALTEZZA. HA FOGLIE LUNGHE 15 CM, DAI PICCIOLI ALLUNGATI, OVALI O ELLITTICHE, DI COLORE VERDE CHIARO CON MARGINI PIÙ SCURI E UN DISEGNO SIMMETRICO ESTESO AI DUE LATI DELLA NERVATURA CENTRALE, CON MACCHIE VERDE SCURO TONDEGGIANTI ALTERNATE AD ALTRE CILINDRICHE, CHE SI ESTENDONO FIN QUASI AL MARGINE. IL TESSUTO TRA LE MACCHIE È PALLIDO E TRASLUCIDO IN TRASPARENZA.",
                   Coltivazione = "Predilige temperature di 13-16 °C (minima 10 °C). Desidera ambienti poco luminosi e privi di raggi diretti del sole. Richiede un substrato acido, leggero, torboso, ben drenato. Necessita di annaffiature abbondanti nella bella stagione, appena il terriccio si è asciugato. Si concima con fertilizzanti liquidi per piante verdi, da marzo a ottobre. Va rinvasata ogni 3 anni, in un contenitore di una-due misure in più.",
                   Potatura = "",
                   Malattie = "",
                },

                new PianteAppartamento
                {
                   NomeComunePianta = "CLIVIA",
                   NomeFamiglia = "Amarillidacee",
                   NomeScientificoPianta = "Clivia miniata",
                   FotoPianta = "ms-appx:///Immagini/Appartamento/Clivia/CLIVIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Appartamento/Abete-*.jpg",

                   DescrizioneBotanica = "PRIVA DI FUSTO VERO E PROPRIO, PUÒ RAGGIUNGERE I 50 CM DI ALTEZZA GRAZIE ALLE FOGLIE AFFASTELLATE ALLA BASE. LE FOGLIE SONO NASTRIFORMI, LARGHE 6 CM, LUNGHE, INCURVATE VERSO L’ESTERNO, A LAMINA CORIACEA E LUCIDA, FORMATE DIRETTAMENTE DALLE RADICI, DI COLORE VERDE SCURO. TRA MARZO E AGOSTO PRODUCE UNO SCAPO FIORIFERO ERETTO CON ALL’APICE 10-20 FIORI IMBUTIFORMI, DI COLORE ROSSOà-ARANCIO. ESISTONO VARIETÀ A FIORI ROSA O GIALLI.",
                   Coltivazione = "Predilige temperature comprese tra 15 e 20 °C (minima 7 °C). Desidera una notevole luminosità, senza raggi solari diretti, con buona ventilazione. Il substrato deve essere fertile e leggero, ben drenato. Richiede annaffiature regolari in fioritura e in estate, appena il terriccio si asciuga; la sospensione dell’acqua in inverno favorisce la fioritura, così come la concimazione, da marzo, con un prodotto liquido per piante da fiore.",
                   Potatura = "",
                   Malattie = "",
                },

                new PianteAppartamento
                {
                   NomeComunePianta = "CROTON",
                   NomeFamiglia = "Euforbiacee",
                   NomeScientificoPianta = "Codiaeum variegatum var. pictum",
                   FotoPianta = "ms-appx:///Immagini/Appartamento/Croton/CROTON.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Appartamento/Abete-*.jpg",

                   DescrizioneBotanica = "ARBUSTO CHE RAGGIUNGE I 60 CM D’ALTEZZA IN APPARTAMENTO (8 M NELLE TERRE D’ORIGINE). PORTA FOGLIE ALTERNE, SEMPLICI, GLABRE, CORIACEE, DI FORMA VARIABILE (DA OVALE A LINEARE) A SECONDA DELLA CULTIVAR; COSÌ COME IL COLORE, CHE PUÒ ESSERE, SU UNA BASE VERDE BRILLANTE, SCREZIATO DI BIANCO, ROSA, ROSSO, ARANCIONE, GIALLO, MARRONE E NERASTRO. I FIORI, RIUNITI IN SPIGHE, SONO PICCOLI E INSIGNIFICANTI E IN GENERE SI ELIMINANO PER MANTENERE LA BELLEZZA DEL FOGLIAME.",
                   Coltivazione = "La temperatura ideale è fra 18 e 21 °C (minima 15 °C). Necessita di molta luce, anche con raggi solari diretti, ma non in piena estate. Desidera un terriccio fertile, leggero, torboso e ben drenato. Va annaffiato di frequente durante la stagione calda e in inverno, con riscaldamento acceso; gradisce anche nebulizzazioni giornaliere con acqua decalcificata sul fogliame. Va concimato da aprile a settembre.",
                   Potatura = "",
                   Malattie = "",
                },

                new PianteAppartamento
                {
                   NomeComunePianta = "DIFFEMBACHIA",
                   NomeFamiglia = "Aracee",
                   NomeScientificoPianta = "Dieffenbachia picta, D. amoena",
                   FotoPianta = "ms-appx:///Immagini/Appartamento/Diffembachia/DIFFEMBACHIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Appartamento/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTE CESPUGLIOSE O A FUSTO ERETTO E CARNOSO, CHE TENDE A INCLINARSI, ALTO FINO A 2,5 METRI. HANNO FOGLIE OBLUNGHE O LANCEOLATE, AD APICE ACUMINATO, DI COLORE VERDE CON VARIEGATURE VARIABILI A SECONDA DELLA SPECIE E VARIETÀ, PORTATE DA LUNGHI PICCIOLI GUAINANTI. LE INFIORESCENZE SONO INSIGNIFICANTI, DI COLORE BIANCO-VERDASTRO. ATTENZIONE AL MANEGGIAMENTO DELLE PARTI DELLA PIANTA: LA LINFA È TOSSICA, SIA PER CONTATTO SIA PER INGESTIONE. ",
                   Coltivazione = "Preferisce temperature di 20-24 °C (minima 15 °C). La luminosità deve essere elevata per mantenere la variegatura, ma senza raggi solari diretti. Il terriccio migliore è leggermente acido, a base di torba e sabbia, ben drenato. Richiede annaffiature regolari in estate e scarse in inverno, sempre dopo che il substrato si è asciugato. Va concimata tra i mesi di marzo e settembre, con un prodotto per piante verdi.",
                   Potatura = "",
                   Malattie = "",
                },

                new PianteAppartamento
                {
                   NomeComunePianta = "DRACENA",
                   NomeFamiglia = "Liliacee",
                   NomeScientificoPianta = "Dracaena deremensis, D. massangeana",
                   FotoPianta = "ms-appx:///Immagini/Appartamento/Dracena/DRACENA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Appartamento/Abete-*.jpg",

                   DescrizioneBotanica = "CHIAMATE ANCHE TRONCHETTO DELLA FELICITÀ, HANNO PORTAMENTO ARBORESCENTE E RAMIFICATO PER UN’ALTEZZA DI 1,50 M (IN NATURA 4 M). PRESENTANO FOGLIE LUNGHE FINO A 90 CM, NASTRIFORMI, SEMIERETTE, A SPIRALE SUL FUSTO, DI COLORE VERDE SCURO, CON BANDE LONGITUDINALI BIANCHE, ARGENTO, CREMA, GIALLE A SECONDA DELLE VARIETÀ. I FIORI, INSIGNIFICANTI, DI COLORE VERDASTRO O GIALLASTRO, RIUNITI IN PANNOCCHIE IN GENERE NON COMPAIONO IN APPARTAMENTO.",
                   Coltivazione = "La temperatura preferita è compresa tra 15 e 18 °C (minima 12 °C). Desiderano molta luce, per mantenere la variegatura delle foglie, priva di raggi solari diretti. Non tollerano le correnti d’aria. Richiedono un terriccio torboso e fertile, ben drenato. Le annaffiature, più abbondanti in estate, vanno somministrate su substrato asciutto. La concimazione, con un prodotto per piante verdi, si effettua da marzo a ottobre.",
                   Potatura = "",
                   Malattie = "",
                },

                new PianteAppartamento
                {
                   NomeComunePianta = "FALANGIO",
                   NomeFamiglia = "Liliacee",
                   NomeScientificoPianta = "Clorophytum comosum",
                   FotoPianta = "ms-appx:///Immagini/Appartamento/Falangio/FALANGIO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Appartamento/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTA CHE FORMA UN DENSO CESPO DI FOGLIE CARNOSE, LUNGHE E STRETTE, RICADENTE, DI COLOR VERDE CHIARO, CON STRIATURE GIALLE O BIANCHE A SECONDA DELLA VARIETÀ. TRA MAGGIO E GIUGNO PRODUCE LUNGHI FUSTI CARNOSI CHE PORTANO NUMEROSI FIORELLINI BIANCHI POCO VISTOSI; DOPO CHE I FIORI SONO APPASSITI IL FUSTO RICADE E, LADDOVE TOCCA IL TERRENO, SI FORMA UNA NUOVA PIANTINA (IL PROCEDIMENTO SI PUÒ APPLICARE ANCHE PER RICAVARNE TALEE).",
                   Coltivazione = "Predilige temperature comprese tra 15 e 20 °C (minima 5 °C). Ama posizioni molto luminose, per mantenere vivida la variegatura, senza contatto con i raggi solari. Non ha particolari esigenze in fatto di substrato, che deve comunque essere sciolto, fertile e ben drenato. Va annaffiato regolarmente in estate e in inverno, con il riscaldamento acceso, dopo che il terriccio si è asciugato. Si concima con un prodotto per piante verdi.",
                   Potatura = "",
                   Malattie = "",
                },

                new PianteAppartamento
                {
                   NomeComunePianta = "FELCI",
                   NomeFamiglia = "Polipodiacee",
                   NomeScientificoPianta = "Adiantum, Dryopteris, Platycerium",
                   FotoPianta = "ms-appx:///Immagini/Appartamento/Felci/FELCI.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Appartamento/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTE ERBACEE PRIVE DI FUSTO, CON FRONDE CHE SI DIPARTONO DIRETTAMENTE DAL TERRENO, MUNITE DI UN LUNGO PICCIOLO SU CUI SI INSERISCONO NUMEROSI SEGMENTI DI COLORE VERDE INTENSO (INTERE E LOBATE IN PLATYCERIUM, LA FELCE A CORNA D’ALCE), FLESSIBILI, IN PARTE ERETTE E IN PARTE ARCUATE, DELLA LUNGHEZZA FINO A 1 METRO. SONO ADATTE AD AMBIENTI UMIDI, COME LA STANZA DA BAGNO. LA COLLOCAZIONE MIGLIORE È IN BASKET O SU MENSOLE, MOBILETTI E SCAFFALI.",
                   Coltivazione = "Temono il caldo: la temperatura massima è di 20 °C, la minima di 10 °C. Necessitano di una collocazione luminosa ma priva di contatto con i raggi solari. Desiderano in genere un terriccio leggermente acido, torboso, leggero. Vanno annaffiate con regolarità, prima che il substrato si sia asciugato. Necessitano di vaporizzazioni giornaliere, soprattutto in estate e con riscaldamento acceso. Si concimano in primavera-estate.",
                   Potatura = "",
                   Malattie = "",
                },

                new PianteAppartamento
                {
                   NomeComunePianta = "FICUS",
                   NomeFamiglia = "Moracee",
                   NomeScientificoPianta = "Ficus benjamina, F. elastica, F. lyrata",
                   FotoPianta = "ms-appx:///Immagini/Appartamento/Ficus/FICUS.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Appartamento/Abete-*.jpg",

                   DescrizioneBotanica = "F. BENJAMINA HA UN TRONCO DIRITTO ED ELEGANTE, CON CHIOMA DENSA DI FOGLIE ELLITTICHE CON APICE ACUMINATO, CONSISTENTI, LUNGHE FINO A 12 CM, DI COLORE VERDE BRILLANTE DA GIOVANI, PIÙ SCURO DA ADULTE. I RAMI SONO SOTTILI E PENDULI. F. ELASTICA HA GIOVANI FOGLIE AVVOLTE IN UNA GUAINA ROSSA, OVATE, CORIACEE, LUNGHE FINO A 30 CM CON ROBUSTO PICCIOLO. F. LYRATA HA FOGLIE MOLTO GRANDI (FINO A 60 CM DI LUNGHEZZA), LUCIDE E CORIACEE, A FORMA DI VIOLINO.",
                   Coltivazione = "La temperatura ideale è compresa fra 20 e 24 °C (minima 15 °C). La posizione deve essere luminosa per il beniamino, anche meno illuminata per i ficus a foglia grande e scura. Il terriccio deve essere torboso e leggero, ben drenato. Le annaffiature vanno somministrate con regolarità in estate e con riscaldamento acceso, dopo l’asciugatura del substrato. Da marzo a settembre si aggiunge un concime per piante verdi.",
                   Potatura = "",
                   Malattie = "",
                },

                new PianteAppartamento
                {
                   NomeComunePianta = "FILODENDRI",
                   NomeFamiglia = "Aracee",
                   NomeScientificoPianta = "Philodendron scandens, P. cordatum",
                   FotoPianta = "ms-appx:///Immagini/Appartamento/Filodendri/FILODENDRI.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Appartamento/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTE RAMPICANTI, DAI FUSTI SOTTILI CON FOGLIE DAL LUNGO PICCIOLO, OVALI O CUORIFORMI O SAGITTATE, LUNGHE E LARGHE FINO A 30 CM, CON APICE APPUNTITO E NERVATURE EVIDENTI, DI COLORE VERDE SCURO. SE DOTATE DEL NECESSARIO TUTORE COPERTO DI MUSCHIO, POSSONO RAGGIUNGERE I 2 M D’ALTEZZA. RESISTENTI E MOLTO LONGEVE (OLTRE 30 ANNI IN APPARTAMENTO), TOLLERANO L’ARIA INQUINATA (CHE PROVVEDONO A DEPURARE DALLE SOSTANZE VOLATILI NOCIVE).",
                   Coltivazione = "Tollerano fino a 7 °C, ma preferiscono l’intervallo tra 15 e 18 °C. Si adattano anche ad ambienti con poca luce, tendendo ad allungarsi verso la fonte più vicina. Desiderano un substrato torboso, leggero, fertile e ben drenato. Le annaffiature devono essere regolari ma non frequenti, su terriccio asciutto, soprattutto in estate e in inverno, con riscaldamento acceso. Si concimano da aprile a settembre una volta al mese.",
                   Potatura = "",
                   Malattie = "",
                },

                new PianteAppartamento
                {
                   NomeComunePianta = "HOYA",
                   NomeFamiglia = "Asclepiadacee",
                   NomeScientificoPianta = "Hoya carnosa",
                   FotoPianta = "ms-appx:///Immagini/Appartamento/Hoya/HOYA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Appartamento/Abete-*.jpg",

                   DescrizioneBotanica = "È UN RAMPICANTE CON RAMI LUNGHI E VOLUBILI CHE SI FISSANO AI SOSTEGNI TRAMITE RADICI AVVENTIZIE. LE FOGLIE, OVALI-OBLUNGHE, ACUMINATE E CARNOSE, SONO CEROSE, LUCIDE E DI COLORE VERDE INTENSO. I FIORI, STELLATI E CEROSI (DA CUI IL NOME FIORE DI CERA), DI COLORE BIANCO CON CENTRO ROSATO, IN INFIORESCENZE A OMBRELLA, COMPAIONO TRA APRILE E AGOSTO ED EMANANO UN INTENSO PROFUMO DI NOTTE. LO SCAPO FIORIFERO NON VA MAI TAGLIATO, PER NON IMPEDIRE LA SUCCESSIVA FIORITURA.",
                   Coltivazione = "Preferisce temperature comprese tra 15 e 18 °C (minima 12 °C). Desidera una posizione molto luminosa ma senza raggi diretti del sole. Ama un substrato fertile, leggero e torboso, ben drenato. Va annaﬃ  ata con costanza in estate, dopo che la terra si è asciugata; in inverno si dirada quasi completamente per fornire il necessario riposo alla pianta. Si concima con un prodotto per piante da fiore da marzo in poi.",
                   Potatura = "",
                   Malattie = "",
                },

                new PianteAppartamento
                {
                   NomeComunePianta = "KENZIA",
                   NomeFamiglia = "Palme",
                   NomeScientificoPianta = "Howea forsteriana",
                   FotoPianta = "ms-appx:///Immagini/Appartamento/Kenzia/KENZIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Appartamento/Abete-*.jpg",

                   DescrizioneBotanica = "PALMA CHE IN APPARTAMENTO RAGGIUNGE AL MASSIMO I 3 M D’ALTEZZA (ARRIVA A 18 M IN NATURA), DALLA CRESCITA MOLTO LENTA (PUÒ PRODURRE ANCHE SOLO UNA O DUE SOLE FOGLIE L’ANNO). POSSIEDE STELI LUNGHI 90 CM DA CUI SI DIPARTONO FOGLIE DALLE LAMINE PENNATE, CON SEGMENTI RICADENTI E APICI ACUMINATI, PORTATE DA UN PICCIOLO MOLTO LUNGO E FLESSIBILE; L’INGOMBRO IN LARGHEZZA PUÒ TOCCARE I 6 M, SE NON SI FISSANO LE FOGLIE A UN SUPPORTO. ",
                   Coltivazione = "Tollera temperature comprese fra 15 e 25 °C (minima 10 °C). Preferisce una posizione luminosa (senza raggi solari diretti) ma resiste anche con meno luce. Adattabile anche in fatto di terriccio che deve essere torboso e fertile. Si annaffia all’occorrenza in estate e con riscaldamento acceso, dopo che la terra è ben asciutta. Si concima una volta al mese durante la bella stagione. Il contenitore deve essere piccolo.",
                   Potatura = "",
                   Malattie = "",
                },

                new PianteAppartamento
                {
                   NomeComunePianta = "ORCHIDEE",
                   NomeFamiglia = "Orchidacee",
                   NomeScientificoPianta = "Phalaenopsis, Cymbidium, Dendrobium",
                   FotoPianta = "ms-appx:///Immagini/Appartamento/Orchidee/ORCHIDEE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Appartamento/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTE EPIFITE DAL CUI RIZOMA AFFIORANTE DALLA SUPERFICIE DEL SUBSTRATO SI ORIGINANO POCHE FOGLIE PERSISTENTI, OVALI O NASTRIFORMI, LUNGHE (FINO A 50 CM) E LARGHE (FINO A 8 CM) E STELI PIUTTOSTO CORTI, CHE PORTANO IN PRIMAVERA (DA MARZO IN POI) NUMEROSI FIORI (FINO A 10 PER OGNI STELO) GRANDI (FINO A 12 CM DI DIAMETRO), SPETTACOLARI E ARCHITETTONICI, MULTICOLORI (TUTTE LE TINTE TRANNE IL BLU), MOLTO DURATURI SIA SULLA PIANTA CHE COME RECISO.",
                   Coltivazione = "La temperatura preferita è compresa fra 18 e 22 °C (minima 12 °C). Necessitano anche di molta umidità ambientale, da fornire mediante vaporizzazioni giornaliere (non sui fiori). Amano avere molta luce, ma non il sole diretto. Il substrato è quello apposito per orchidee, costituito da cortecce, torba e materiale drenante. Si annaffiano quando sono del tutto asciutte. Si concimano dalla primavera con un prodotto apposito.",
                   Potatura = "",
                   Malattie = "",
                },

                new PianteAppartamento
                {
                   NomeComunePianta = "PACHIRA",
                   NomeFamiglia = "Bombacacee",
                   NomeScientificoPianta = "Pachira aquatica",
                   FotoPianta = "ms-appx:///Immagini/Appartamento/Pachira/PACHIRA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Appartamento/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTA SEMPREVERDE CHE IN NATURA RAGGIUNGE I 20 M D’ALTEZZA, MENTRE IN APPARTAMENTO PUÒ AL MASSIMO ARRIVARE A 2 METRI. VIENE DETTA ANCHE NOCE DEL MALABAR O DELLA GUYANA, DAL NOME DEI PAESI D’ORIGINE. VIENE SPESSO ALLEVATA AD ALBERELLO COMPOSTO DA DIVERSI FUSTI INTRECCIATI. HA GRANDI FOGLIE LUCIDE, LEGGERE, PENTALOBATE, COLOR VERDE SCURO. IN NATURA PRODUCE GRANDI FIORI PROFUMATI, BIANCO-CREMA, CON I PETALI ARRICCIATI VERSO LA BASE DEL FIORE.",
                   Coltivazione = "La temperatura ideale è compresa fra 15 e 20 °C (minima 12 °C). Desidera una posizione molto luminosa ma priva di raggi solari diretti. Si coltiva in un terriccio torboso, fertile e ben drenato. L’annaffiatura deve essere attenta: né eccessiva (solo su terriccio appena asciutto), né carente, perché è una pianta molto sensibile al bilancio idrico. Si somministra concime per piante verdi una volta al mese nella bella stagione.",
                   Potatura = "",
                   Malattie = "",
                },

                new PianteAppartamento
                {
                   NomeComunePianta = "PAPIRO",
                   NomeFamiglia = "Ciperacee",
                   NomeScientificoPianta = "Cyperus papyrus",
                   FotoPianta = "ms-appx:///Immagini/Appartamento/Papiro/PAPIRO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Appartamento/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTA RIZOMATOSA, ERBACEA, PERENNE, SEMPREVERDE E DELICATA, ALTA FINO A 2 M SE VIENE ALLEVATA IN VASO. HA FUSTI CON SEZIONE TRIANGOLARE CHE PORTANO ALLA SOMMITÀ INFIORESCENZE A OMBRELLA, GLOBOSE, PIUMOSE, DATE DA ELEMENTI ARCUATI (QUELLE CHE COMUNEMENTE VENGONO SCAMBIATE PER FOGLIE, MA IN REALTÀ SONO BRATTEE LUNGHE E STRETTE), LUNGHI 30 CM, CHE PROTEGGONO I FIORI, DEL TUTTO INSIGNIFICANTI DAL PUNTO DI VISTA DECORATIVO. ",
                   Coltivazione = "Preferisce temperature comprese fra 18 e 24 °C (minima 13 °C). Desidera una luminosità intensa, al riparo dai raggi diretti del sole. Il substrato deve essere torboso con molto materiale drenante: la pianta deve rimanere con la base del vaso immersa in acqua (da aggiungere man mano che cala, soprattutto in estate). Va concimata da marzo a settembre con un prodotto per piante verdi. Le “foglie” secche vanno rimosse.",
                   Potatura = "",
                   Malattie = "",
                },

                new PianteAppartamento
                {
                   NomeComunePianta = "POTOS",
                   NomeFamiglia = "Aracee",
                   NomeScientificoPianta = "Scindapsus aureus",
                   FotoPianta = "ms-appx:///Immagini/Appartamento/Potos/POTOS.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Appartamento/Abete-*.jpg",

                   DescrizioneBotanica = "RAMPICANTE SEMPREVERDE, DOTATO DI RADICI AEREE CHE SI SVILUPPANO DAI NODI. I TRALCI, GIALLI E FLESSIBILI, SI SVILUPPANO FINO A 3 M DI LUNGHEZZA. LE FOGLIE (CHE IN NATURA RAGGIUNGONO I 50 CM DI LUNGHEZZA) HANNO LAMINA OVATO-CUORIFORME, ACUMINATA, LUNGA 10 CM, DI COLORE VERDE SCREZIATO DI GIALLO. I FIORI, CHE RARAMENTE COMPAIONO IN APPARTAMENTO, SONO PICCOLISSIMI E PORTATI DA UNO SPADICE AVVOLTO DA UNA SPATA COLORATA. SI COLTIVA IN BASKET O SU TUTORE.",
                   Coltivazione = "La temperatura ideale è compresa fra 18 e 22 °C (minima 13 °C). Desidera molta luce, senza raggi solari diretti; se l’illuminazione è scarsa, le foglie perderanno le variegature. Il substrato deve essere torboso, leggero e ben drenato. Le annaffiature sono frequenti in estate e in inverno, con riscaldamento acceso, ma solo su terriccio ben asciutto. Gradisce vaporizzazioni del fogliame. Si concima da aprile a settembre.",
                   Potatura = "",
                   Malattie = "",
                },

                new PianteAppartamento
                {
                   NomeComunePianta = "SCEFFLERA",
                   NomeFamiglia = "Aracee",
                   NomeScientificoPianta = "Schefflera arboricola",
                   FotoPianta = "ms-appx:///Immagini/Appartamento/Scefflera/SCEFFLERA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Appartamento/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTA PERENNE, ORIGINARIA DI POLINESIA E INDONESIA, SEMPREVERDE, ARBUSTIVA, CHE IN VASO PUÒ RAGGIUNGERE I 2 M D’ALTEZZA. PRESENTA FOGLIE COMPOSTE DA ALMENO 7 FOGLIOLINE SPESSE E CORIACEE, CON FORMA A GOCCIA ROVESCIATA, DI COLORE VERDE INTENSO, POSTE ALL’ESTREMITÀ DI UNO STELO FOGLIARE, PORTATO DA UN UNICO FUSTO PRINCIPALE, IN GENERE NON RAMIFICATO. IN ALCUNE VARIETÀ LE FOGLIOLINE SONO VARIEGATE DI BIANCO, DI COLOR CREMA O DI GIALLO.",
                   Coltivazione = "Preferisce temperature comprese fra 18 e 22 °C (minima 13 °C). Desidera ambienti luminosi, soprattutto nel caso di esemplari a foglia variegata, ma privi del sole diretto. Richiede un terriccio fertile, leggero e torboso, ben drenato. Le annaffiature devono essere abbondanti in estate e in inverno, con riscaldamento acceso, lasciando asciugare il substrato. Le concimazioni vanno eseguite da aprile a settembre, una volta al mese.",
                   Potatura = "",
                   Malattie = "",
                },

                new PianteAppartamento
                {
                   NomeComunePianta = "SPATIFILLO",
                   NomeFamiglia = "Aracee",
                   NomeScientificoPianta = "Spatyphyllum wallisii",
                   FotoPianta = "ms-appx:///Immagini/Appartamento/Spatifillo/SPATIFILLO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Appartamento/Abete-*.jpg",

                   DescrizioneBotanica = "RIZOMATOSA PERENNE PRIVA DI FUSTO, PRESENTA FOGLIE PORTATE DA LUNGHI PICCIOLI CHE NASCONO DIRETTAMENTE DAL RIZOMA, CORIACEE, OBLUNGHE O LANCEOLATE, ACUMINATE, LUCIDE E CON NERVATURE MARCATE, DI COLORE VERDE SCURO. L’INFIORESCENZA, PORTATA DA STELI LUNGHI 25 CM CHE EMERGONO DAL CENTRO, È DATA DA UNO SPADICE, LUNGO 4 CM, DI FIORELLINI BIANCHI O GIALLO CREMA, AVVOLTO DA UNA SPATA BIANCA, LUNGA 10 CM, CONCAVA E CUSPIDATA, CHE MAN MANO DIVENTA VERDE. ",
                   Coltivazione = "Richiede temperature comprese fra 20 e 24 °C (minima 12 °C). La posizione deve essere molto luminosa, priva di raggi diretti. Il substrato preferito è a base di torba e materiale drenante. Richiede annaffiature costanti in tutte le stagioni, appena prima che il terriccio si asciughi. Per favorire la fioritura si somministra nell’acqua d’annaffiatura un fertilizzante liquido per piante da fiore, da marzo a settembre.",
                   Potatura = "",
                   Malattie = "",
                },

                new PianteAppartamento
                {
                   NomeComunePianta = "STELLA DI NATALE",
                   NomeFamiglia = "Euforbiacee",
                   NomeScientificoPianta = "Euphorbia pulcherrima",
                   FotoPianta = "ms-appx:///Immagini/Appartamento/Stella di Natale/STELLA DI NATALE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Appartamento/Abete-*.jpg",

                   DescrizioneBotanica = "IN VASO PUÒ RAGGIUNGERE 2 M D’ALTEZZA. È UN’ERBACEA MOLTO RAMIFICATA CHE PRESENTA FOGLIE GRANDI, DECIDUE, OVATO-ELLITTICHE, DENTATE O LOBATE, APPUNTITE. LE INFIORESCENZE SONO FORMATE DA NUMEROSI CIAZI (INFIORESCENZA TIPICA DELLE EUFORBIACEE) VERDASTRI CIRCONDATI DA BRATTEE SCARLATTE OGGI ANCHE BIANCHE O ROSA, DOPPIE O ARRICCIATE NELLE VARIE CULTIVAR FLORICOLE, LUNGHE FINO A 15 CM (CON UN DIAMETRO COMPLESSIVO DI 30 CM).",
                   Coltivazione = "Necessita di temperature comprese tra 15 e 18 °C (minima 13 °C). Gradisce ambienti molto luminosi, al riparo dalla luce diretta del sole. Il substrato deve essere fertile, leggero, ben drenato. Le annaffiature devono essere regolari in fioritura, ma solo dopo che il terriccio si è asciugato. Dopo la sfioritura si tagliano i rami a 30 cm d’altezza, si applica un periodo di riposo e si tratta l’esemplare come una normale pianta verde.",
                   Potatura = "",
                   Malattie = "",
                },

                new PianteAppartamento
                {
                   NomeComunePianta = "TILLANDSIA",
                   NomeFamiglia = "Bromeliacee",
                   NomeScientificoPianta = "Tillandsia cyanea",
                   FotoPianta = "ms-appx:///Immagini/Appartamento/Tillandsia/TILLANDSIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Appartamento/Abete-*.jpg",

                   DescrizioneBotanica = "SPECIE EPIFITA CON FOGLIE STRETTE, LUNGHE FINO A 40 CM E LARGHE 2,5 CM, DI COLORE ROSSO BRUNO ALLA BASE E STRIATE DI BRUNO, DISPOSTE A FORMARE UNA ROSETTA COMPATTA, DALLA QUALE EMERGE UN FUSTO, LUNGO 8 CM, CHE PORTA UN’INFIORESCENZA A SPIGA, LUNGA 10 CM, FORMATA DA BRATTEE ROSA O ROSSE CON SFUMATURE VERDI, ALL’ASCELLA DELLE QUALI SBOCCIANO FIORI A TRE PETALI DI COLORE AZZURRO-VIOLETTO. PUÒ RAGGIIUNGERE I 25 CM D’ALTEZZA E 30 DI DIAMETRO.",
                   Coltivazione = "La temperatura ideale è compresa tra 15 e 18 °C (minima 13 °C). Necessita di molta luce, non accompagnata dai raggi solari, e soprattutto di molta umidità, da ottenere vaporizzando l’esemplare anche più volte al giorno con acqua decalciﬁ cata. Il substrato è composto da torba e fibre di osmunda. Va annaffiata anche due volte al giorno in estate, al centro della rosetta. Si alleva su zattere o fili metallici.",
                   Potatura = "",
                   Malattie = "",
                },

                new PianteAppartamento
                {
                   NomeComunePianta = "TRADESCANZIA",
                   NomeFamiglia = "Commelinacee",
                   NomeScientificoPianta = "Tradescantia virginiana, T. purpurea",
                   FotoPianta = "ms-appx:///Immagini/Appartamento/Tradescanzia/TRADESCANZIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Appartamento/Abete-*.jpg",

                   DescrizioneBotanica = "T. VIRGINIANA HA PORTAMENTO ERETTO ED ESSENDO SEMIRUSTICA SI PUÒ ANCHE COLTIVARE IN GIARDINO, NEL SUD. RAGGIUNGE L’ALTEZZA DI 60 CM E HA FOGLIE NASTRIFORMI APPUNTITE DI COLORE VERDE SCURO. DA GIUGNO A SETTEMBRE PRODUCE FIORI DI 4 CM, DI COLORE BIANCO, ROSA, PORPORA, AZZURRO. T. PURPUREA HA PORTAMENTO PROSTRATO, CON FOGLIE OVALI DI COLORE VERDE PORPORA SULLA PAGINA SUPERIORE E ROSSO-PORPORA SU QUELLA INFERIORE. IN OTTOBRE PRODUCE FIORI PORPORA.",
                   Coltivazione = "Resiste fino a 7 °C. Ama posizioni molto luminose, senza contatto con i raggi solari. Il substrato preferito è fertile e leggero, ben drenato, ma tollera anche terricci torbosi o poveri. Necessita di annaffiature regolari per tutto il periodo estivo e quando il riscaldamento è acceso, attendendo che il terriccio si asciughi. Va concimata da marzo a ottobre. Ogni anno in primavera va rinvasata in un contenitore di poco più grande.",
                   Potatura = "",
                   Malattie = "",
                },

                new PianteAppartamento
                {
                   NomeComunePianta = "VIOLETTA AFRICANA",
                   NomeFamiglia = "Gesneriacee",
                   NomeScientificoPianta = "Saintpaulia jonantha",
                   FotoPianta = "ms-appx:///Immagini/Appartamento/Violetta Africana/VIOLETTA AFRICANA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Appartamento/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTA PRIVA DI FUSTO (ALTEZZA MAX 15 CM), CON FOGLIE DISPOSTE A ROSETTA, CUORIFORMI O TONDEGGIANTI, CARNOSE, PELOSE, DI COLORE VERDE SCURO, CON PAGINA INFERIORE SFUMATA DI ROSSO (ESISTONO ANCHE VARIETÀ CON FOGLIE FRASTAGLIATE E ONDULATE). I FIORI COMPAIONO TRA GIUGNO E OTTOBRE, IN INFIORESCENZE A CIMA DI 4-8 ESEMPLARI, SONO SEMPLICI, DI COLORE BLU, VIOLA, AZZURRO, BIANCO, ROSA (A SECONDA DELLE CULTIVAR) CON STAMI GIALLO ORO AL CENTRO.",
                   Coltivazione = "La temperatura preferita è compresa tra 18 e 20 °C (minima 15 °C), preferibilmente più alta di notte che di giorno. Richiedono molta luce, ma non i raggi solari diretti. Il terriccio deve essere appena acido, torboso, leggero, ben drenato. Le annaffiature devono essere più frequenti in estate, nel sottovaso, con acqua decalcificata, senza bagnare foglie e fiori. Da marzo a settembre si fornisce un concime per acidofile.",
                   Potatura = "",
                   Malattie = "",
                },

                new PianteAppartamento
                {
                   NomeComunePianta = "ZAMIA",
                   NomeFamiglia = "Zamiacee",
                   NomeScientificoPianta = "Zamia furfuracea",
                   FotoPianta = "ms-appx:///Immagini/Appartamento/Zamia/ZAMIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Appartamento/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTA PERENNE SEMPREVERDE, HA UN FUSTO TOZZO, PARZIALMENTE SOTTERRANEO, SENZA RAMIFICAZIONI, CHE FUNGE DA SERBATOIO DI ACQUA NEI PERIODI SECCHI. LE GIOVANI FOGLIE DA GIALLO CHIARO DIVENTANO VERDE OLIVA E SI COPRONO DI PELI ROSSASTRI. MAN MANO CHE CRESCE PRODUCE COPPIE DI FOGLIE; A FINE SVILUPPO, OGNI STELO, LUNGO FINO A 1 M, HA 24 FOGLIE SIMMETRICHE, POSTE A 45°. NELLE REGIONI CALDE PUÒ ESSERE COLTIVATA ANCHE ALL’APERTO. ",
                   Coltivazione = "Tollera basse temperature (fino a 3 °C) se il fusto è interamente sotto terra; altrimenti la temperatura ideale è fra 20 e 24 °C. Desidera molta luce e resiste ai raggi diretti del sole. Preferisce un terriccio ben drenato, con torba e argilla. Va annaﬃ  ata moderatamente quando il substrato è perfettamente asciutto. Tollera anche l’aria secca e i venti caldi e salmastri. Si concima una volta al mese da maggio a settembre.",
                   Potatura = "",
                   Malattie = "",
                },

                


            };

            return data;
        }

        // TODO WTS: Remove this once your MasterDetail pages are displaying real data
        public static async Task<IEnumerable<PianteAppartamento>> GetSampleModelDataAsync()
        {
            await Task.CompletedTask;

            return AllPianteAppartamento();
        }

        
    }
}
