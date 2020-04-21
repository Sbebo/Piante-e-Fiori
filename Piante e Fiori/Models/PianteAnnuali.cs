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
//21 PIANTE ANNUALI
    public class PianteAnnuali
    {
        public string NomeComunePianta { get; set; }
        public string NomeFamiglia { get; set; }
        public string NomeScientificoPianta { get; set; }
        public string FotoPianta { get; set; }
        public string SourceGalleryFotografica { get; set; }

        public string DescrizioneBotanica { get; set; }
        public string Coltivazione { get; set; }
        public string Malattie { get; set; }
        public string Propagazione { get; set; }
        public string Potatura { get; set; }


    }

    public static class PianteAnnualiDataService
    {
        private static IEnumerable<PianteAnnuali> AllPianteAnnuali()
        {
            // The following is order summary data
            var data = new ObservableCollection<PianteAnnuali>
            {
               
                new PianteAnnuali
                {
                   NomeComunePianta = "BOCCA DI LEONE",
                   NomeFamiglia = "Scrofulariacee",
                   NomeScientificoPianta = "Antirrhinum majus",
                   FotoPianta = "ms-appx:///Immagini/Annuali/Bocca di Leone/BOCCA DI LEONE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Annuali/Abete-*.jpg",

                   DescrizioneBotanica = "PERENNE UTILIZZATA COME ANNUALE, ALTA DA 25 A 120 CM A SECONDA DELLA VARIETÀ (LE PICCOLE SONO INDICATE PER BORDURE E IN VASO, LE GRANDI PER AIUOLE E FIORI RECISI), CON FUSTO LIGNIFICATO ALLA BASE E FOGLIE OVALI, PICCOLE. DA MAGGIO A NOVEMBRE PRODUCE INFIORESCENZE A GRAPPOLO, ERETTE, CON NUMEROSI FIORI DALLA COROLLA TUBULOSA, RIGONFIA ALLA BASE, CHE TERMINA, ALL’ESTREMITÀ OPPOSTA, CON DUE FORMAZIONI SIMILI A DUE LABBRA (DA CUI IL NOME COMUNE).",
                   Coltivazione = "Tollera l’inverno della Val Padana, ma dal secondo anno fiorisce sempre meno. È facilissima da riprodurre da seme (in aprile), anche per autorisemina. Necessita del pieno sole, di un terriccio fertile e molto ben drenato, di concimazioni da maggio a settembre con un prodotto liquido per piante da fiore. Le annaffiature estive devono essere costanti in vaso. Eliminare sempre le infiorescenze appassite.",
                   Propagazione = "",
                   Malattie = "",
                },

                new PianteAnnuali
                {
                   NomeComunePianta = "CALCEOLARIA",
                   NomeFamiglia = "Scrofulariacee",
                   NomeScientificoPianta = "Calceolaria x herbeo hybrida",
                   FotoPianta = "ms-appx:///Immagini/Annuali/Calceolaria/CALCEOLARIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Annuali/Abete-*.jpg",

                   DescrizioneBotanica = "BIENNALE, SI TROVA IN VENDITA AL SECONDO ANNO DI VITA, PRONTA PER LA FIORITURA. ALTA FINO A 40 CM DI ALTEZZA, HA FUSTO ERETTO E GRANDI FOGLIE RUVIDE COLOR VERDE TENERO. I FIORI, CHE COMPAIONO TRA MAGGIO E LUGLIO, HANNO LA PARTE INFERIORE RIGONFIA E CAVA, SORMONTATA DA UN LABBRO SUPERIORE, CHE LI FA ASSOMIGLIARE A PICCOLE PANTOFOLE. I COLORI VARIANO DAL GIALLO ALL’ARANCIO, AL ROSSO, AL MARRONE, SPESSO PUNTINATI A CONTRASTO. SI ALLEVA IN VASO.",
                   Coltivazione = "In caso di semina in casa, la temperatura deve sempre rimanere sopra i 12 °C. Desidera un terriccio fresco e sempre ben drenato. Preferisce una posizione molto luminosa, ma al riparo dai raggi solari. Va annaffiata in abbondanza in estate, quando il substrato sta per asciugarsi, ma senza ristagni idrici. Da aprile a luglio, durante la fioritura, va concimata ogni 15 giorni con un prodotto liquido per piante da fiore.",
                   Malattie = "",
                },

                new PianteAnnuali
                {
                   NomeComunePianta = "COELUS",
                   NomeFamiglia = "Labiate",
                   NomeScientificoPianta = "Coleus blumei (sinonimo Solenostemon b.)",
                   FotoPianta = "ms-appx:///Immagini/Annuali/Coleus/COLEUS.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Annuali/Abete-*.jpg",

                   DescrizioneBotanica = "PERENNE COLTIVATA COME ANNUALE (DOPO IL PRIMO ANNO LA PIANTA “SI SFORMA”), ALTA 40 CM AL MASSIMO. DECORATIVA PER LE FOGLIE OPPOSTE, OVATO-ACUMINATE E DENTELLATE AI MARGINI, CARATTERIZZATE DA LAMINA DIVERSAMENTE COLORATA, A SECONDA DELLA VARIETÀ, CON SCREZIATURE VERDI, ROSSE, MARRONI, GIALLE. I FIORELLINI, INSIGNIFICANTI, DI COLORE BLU-VIOLA RIUNITI IN SPIGHE, SE COMPAIONO, VANNO SUBITO ELIMINATI PER NON TOGLIERE BELLEZZA AL FOGLIAME.",
                   Coltivazione = "Non tollera temperature inferioria ai 12 °C. Si può riprodurre per talea, da prelevare in agosto. Per mantenere vivi i colori del fogliame deve ricevere molta luce, ma non i raggi diretti del sole. Vuole un substrato torboso, fertile e leggero. Necessita di abbondanti annaffiature estive, soprattutto se coltivato in vaso. Va concimato ogni 15 giorni. In piena terra si utilizza per formare dense aiuole a bassa manutenzione.",
                   Malattie = "",
                },

                new PianteAnnuali
                {
                   NomeComunePianta = "CRESTA DI GALLO",
                   NomeFamiglia = "Amarantacee",
                   NomeScientificoPianta = "Celosia argentea",
                   FotoPianta = "ms-appx:///Immagini/Annuali/Cresta di Gallo/CRESTA DI GALLO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Annuali/Abete-*.jpg",

                   DescrizioneBotanica = "ANNUALE, ALTA FINO A 30 CM, CON FOGLIE LANCEOLATO-OVATE, DI COLORE VERDE CHIARO. DA MAGGIO A DICEMBRE PRODUCE VISTOSE INFIORESCENZE VELLUTATE A SPIGA, CHE IN C. A. CRISTATA HANNO LA FORMA DI UN VENTAGLIO RIGIDO LARGO FINO A 12 CM E IN C. A. PLUMOSA DI UN GRUPPO DI PIUMINI, ALTO FINO A 15 CENTIMETRI. I FIORI SONO BIANCHI, GIALLI, ROSA, ARANCIO, ROSSI O PORPORA. LE INFIORESCENZE SI POSSONO TAGLIARE, ESSICCARE E USARE PER DECORAZIONI INVERNALI.",
                   Coltivazione = "Si semina in febbraio in serra calda o si acquista in aprile, prossima alla fioritura. Adatta al vaso e come decorazione di piccole aiuole. Ama posizioni luminose ma non soleggiate. Il terriccio deve essere a base di torba e sabbia, ben drenato. Va annaffiata con regolarità per tutta l’estate, aggiungendo ogni 15 giorni una dose di concime liquido per piante da fiore. Non sopporta temperature inferiori a 12 °C.",
                   Malattie = "",
                },

                new PianteAnnuali
                {
                   NomeComunePianta = "DIASCIA",
                   NomeFamiglia = "Scrofulariacee",
                   NomeScientificoPianta = "Diascia barberae",
                   FotoPianta = "ms-appx:///Immagini/Annuali/Diascia/DIASCIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Annuali/Abete-*.jpg",

                   DescrizioneBotanica = "PERENNE ALLEVATA COME ANNUALE (FIORISCE MENO DAL SECONDO ANNO), ALTA FINO A 30 CM, CON SOTTILI FUSTI FLESSIBILI E PROSTRATI, ORNATI DA SOTTILI FOGLIE QUASI AGHIFORMI, DI COLORE VERDE CHIARO. DA APRILE A OTTOBRE PRODUCE PICCOLE SPIGHE APICALI DI FIORELLINI DI COLORE ROSSO, ARANCIONE, GIALLO, ROSA, BIANCO. VERSATILE NELL’UTILIZZO: IN VASO E IN BASKET, IN FIORIERA CON UN PICCOLO TRALICCIO, IN BORDURE MISTE ALL’INGLESE, SU SCARPATELLE E MURETTI.",
                   Coltivazione = "In inverno la parte aerea si secca per rispuntare in primavera, se la temperatura non è scesa sotto 0 °C. Si riproduce per seme, in marzo. Desidera un’esposizione soleggiata su un terreno fertile, sciolto, ben drenato. Va annaffiata in estate ogni volta che il substrato si è asciugato. Si concima ogni 15 giorni con un fertilizzante liquido per piante da fiore. Eliminare con regolarità i fiori appassiti.",
                   Malattie = "",
                },

                new PianteAnnuali
                {
                   NomeComunePianta = "ESCOLZIA",
                   NomeFamiglia = "Papaveracee",
                   NomeScientificoPianta = "Eschscholtzia californica",
                   FotoPianta = "ms-appx:///Immagini/Annuali/Escolzia/ESCOLZIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Annuali/Abete-*.jpg",

                   DescrizioneBotanica = "CHIAMATA ANCHE PAPAVERO DELLA CALIFORNIA, È UNA PERENNE COLTIVATA COME ANNUALE. FORMA DENSE ROSETTE DI FOGLIE AMPIE, MOLTO FRASTAGLIATE, DI COLORE GRIGIO-VERDE, DA CUI SI DIPARTONO FUSTI SOTTILI, ALTI FINO A 30 CM, CHE PORTANO GRANDI FIORI SINGOLI, DI COLORE GIALLO, ARANCIO, BIANCO O ROSSO. LA FIORITURA DURA DA MAGGIO AD AGOSTO E I CESPI TENDONO AD ALLARGARSI MOLTO, RIEMPIENDO TUTTO LO SPAZIO A DISPOSIZIONE. VA PERCIÒ COLTIVATA IN PIENA TERRA.",
                   Coltivazione = "Non tollera temperature inferiori ai 15 °C. Si riproduce da seme, in marzo. Richiede posizioni molto soleggiate e spazi ampi. Preferisce terreni sciolti e fertili, ma si adatta anche ad altre tipologie, sempre molto ben drenati. Va annaffiata con moderazione, dopo che il substrato si è asciugato. Ogni 20 giorni è gradita una concimazione con un prodotto liquido per piante da fiore. Eliminare sempre i fiori appassiti.",
                   Malattie = "",
                },

                new PianteAnnuali
                {
                   NomeComunePianta = "GAZANIA",
                   NomeFamiglia = "Composite",
                   NomeScientificoPianta = "Gazania x hybrida",
                   FotoPianta = "ms-appx:///Immagini/Annuali/Gazania/GAZANIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Annuali/Abete-*.jpg",

                   DescrizioneBotanica = "PERENNE COLTIVATA COME ANNUALE, CON FUSTI RAMIFICATI, RAGGIUNGE L’ALTEZZA DI 40 CM. HA FOGLIE LANCEOLATE, DENTATE E DI COLOR VERDE SCURO SULLA PAGINA SUPERIORE E GRIGIO SU QUELLA INFERIORE. DA MAGGIO A OTTOBRE PRODUCE CAPOLINI, SIMILI ALLE MARGHERITE, DEL DIAMETRO DI 8 CM, GIALLI, ARANCIO, ROSA, ROSSO, MARRONE. I FIORI VENGONO PRODOTTI E SI APRONO SOLO SE SONO BEN ILLUMINATI DAI RAGGI SOLARI E LA SERA, CON L’UMIDITÀ NOT TURNA, SI CHIUDONO.",
                   Coltivazione = "Teme temperature inferiori a 10 °C. Può essere coltivata in vaso (del diametro di almeno 24 cm) o in piena terra per aiuole decorative. Richiede il pieno sole e un substrato fertile e ben drenato. Va annaﬃ  ata in abbondanza, appena prima che il terriccio si sia asciugato. Va concimata ogni 15 giorni con un prodotto liquido per piante da ﬁ ore. I capolini sﬁ oriti vanno sempre prontamente eliminati.",
                   Malattie = "",
                },

                new PianteAnnuali
                {
                   NomeComunePianta = "GLOSSINIA",
                   NomeFamiglia = "Gesneriacee",
                   NomeScientificoPianta = "Sinningia speciosa (sinonimo Gloxinia s.)",
                   FotoPianta = "ms-appx:///Immagini/Annuali/Glossinia/GLOSSINIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Annuali/Abete-*.jpg",

                   DescrizioneBotanica = "PERENNE COLTIVATA COME ANNUALE, CON FUSTI CARNOSI MOLTO CORTI, ALTI AL MASSIMO 10 CENTIMETRI. HA FOGLIE GRANDI, OVATO-OBLUNGHE, CARNOSE, FINEMENTE PELOSE E DI COLORE VERDE SCURO, FACILI ALLA ROTTURA SE VENGONO URTATE. DA MAGGIO AD AGOSTO PRODUCE MOLTI FIORI, DEL DIAMETRO DI 10 CM, SEMPLICI, SEMIDOPPI O DOPPI, VELLUTATI E SPETTACOLARI, DI COLORE BIANCO, ROSA, ROSSO, PORPORA, VIOLETTO E ANCHE MISTO, A SECONDA DELLE VARIETÀ FLORICOLE.",
                   Coltivazione = "Teme temperature inferiori a 15 °C: va coltivata in vaso, all’aperto in posizione luminosa ma ombreggiata in estate, altrimenti in appartamento, sempre fuori dalla portata dei raggi solari. Desidera un terriccio leggero, fertile, ben drenato. Va annaffiata regolarmente in estate, prima che il substrato si asciughi, senza bagnare foglie e fiori. Ogni 15 giorni va concimata con un prodotto per piante da fiore. Eliminare i fiori appassiti.",
                   Malattie = "",
                },

                new PianteAnnuali
                {
                   NomeComunePianta = "IMPATIENS",
                   NomeFamiglia = "Balsaminacee",
                   NomeScientificoPianta = "Impatiens walleriana",
                   FotoPianta = "ms-appx:///Immagini/Annuali/Impatiens/IMPATIENS.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Annuali/Abete-*.jpg",

                   DescrizioneBotanica = "PERENNE TRATTATA DA ANNUALE, ALTA FINO A 30 CM, CON FUSTI SUCCULENTI E FOGLIE ALTERNE, ELLITTICO-LANCEOLATE. DA MAGGIO A OTTOBRE SI APRONO I FIORI, SOLITARI O RAGGRUPPATI, PIATTI, CON UN CORTO TUBO CHE TERMINA IN UNO SPERONE E LA COROLLA DI CINQUE PETALI, SEMPLICI O DOPPI, BIANCHI, ARANCIO, ROSA, ROSSI, LAVANDA, VIOLA O BICOLORI A SECONDA DELLE VARIETÀ FLORICOLE. FRA QUESTE SI RICORDA ‘NUOVA GUINEA’, DAI FIORI MOLTO GRANDI, E ‘SUNPATIENS’, ADATTO AL PIENO SOLE.",
                   Coltivazione = "Resiste fino a temperature di 12 °C. Si riproduce da seme, in marzo. Desidera una posizione ombreggiata ma luminosa. Vuole un terriccio fertile, fresco, ben drenato. Le annaffiature devono essere abbondanti in estate, soprattutto se coltivato in vaso, ma senza ristagni idrici. Ogni 15 giorni va concimato con un fertilizzante liquido per piante da fiore. In piena terra si impiega per bordure o come decorazione di aiuole.",
                   Malattie = "",
                },

                new PianteAnnuali
                {
                   NomeComunePianta = "LANTANA",
                   NomeFamiglia = "Verbenacee",
                   NomeScientificoPianta = "Lantana camara",
                   FotoPianta = "ms-appx:///Immagini/Annuali/Lantana/LANTANA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Annuali/Abete-*.jpg",

                   DescrizioneBotanica = "PERENNE DI SOLITO COLTIVATA COME ANNUALE (DAL SECONDO ANNO LA FIORITURA DIMINUISCE), HA FUSTI SOTTILI CHE TENDONO A LIGNIFICARE E AD ALLUNGARSI FINO A 50 CM D’ALTEZZA. LE FOGLIE ELLITTICHE, DENTATE E RUVIDE HANNO COLORE VERDE SCURO. DA MAGGIO AD AGOSTO PRODUCE PICCOLI FIORI RIUNITI IN CORIMBI GLOBOSI, LARGHI 5 CM, ALL’ASCELLA DELLE FOGLIE, DI COLORE MISTO (BIANCO E GIALLO, GIALLO E VIOLA, ARANCIO E ROSSO) CHE CAMBIA PREVALENZA NEL CORSO DELLA STAGIONE. ",
                   Coltivazione = "Non sopporta temperature inferiori a 10 °C. Si riproduce da talea prelevata in settembre. Ama posizioni molto soleggiate (a mezz’ombra in Meridione). Il substrato deve essere fertile e sciolto, molto ben drenato. Durante tutta la fioritura va concimata con un prodotto liquido per piante da fiore. Le annaffiature devono essere frequenti in vaso o su suoli molto sciolti, dopo che la terra si è asciugata.",
                   Malattie = "",
                },

                new PianteAnnuali
                {
                   NomeComunePianta = "LOBELIA",
                   NomeFamiglia = "Campanulacee",
                   NomeScientificoPianta = "Lobelia erinus",
                   FotoPianta = "ms-appx:///Immagini/Annuali/Lobelia/LOBELIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Annuali/Abete-*.jpg",

                   DescrizioneBotanica = "ANNUALE CON PORTAMENTO PROSTRATO, ALTA FINO A 15 CM, INDICATA PER PICCOLE AIUOLE, BORDURE, BASKET O CASSETTE DA BALCONE. HA SOTTILI FUSTI FLESSIBILI E MORBIDI, DI COLORE VERDE O ROSSO, E PICCOLE FOGLIE DENTATE, TENERE, COLOR VERDE INTENSO. DA MAGGIO A OTTOBRE PRODUCE IN CONTINUAZIONE, SENZA SOSTA, UNA CASCATA DI PICCOLI FIORI TUBOLARI, SEMPLICI, DI COLORE VIOLA INTENSO (MA ANCHE BLU, AZZURRI, BIANCHI O ROSA NELLE VARIETÀ FLORICOLE).",
                   Coltivazione = "Tollera temperature fino a 8 °C. Si riproduce da seme, in aprile, anche per autorisemina. Desidera la mezz’ombra e comunque non il sole pieno dell’estate. Il substrato deve essere fertile, sciolto e ben drenato. Richiede molta acqua durante l’estate e nei punti meno ombreggiati. Ogni 15 giorni gradisce mezza dose di fertilizzante liquido per piante da fiore. Non sporca e non necessita di eliminazione dei fiori appassiti.",
                   Malattie = "",
                },

                new PianteAnnuali
                {
                   NomeComunePianta = "NASTURZIO",
                   NomeFamiglia = "Tropeolacee",
                   NomeScientificoPianta = "Tropaeolum majus",
                   FotoPianta = "ms-appx:///Immagini/Annuali/Nasturzio/NASTURZIO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Annuali/Abete-*.jpg",

                   DescrizioneBotanica = "PERENNE, MA COLTIVATA COME ANNUALE, IN VASO SI UTILIZZA COME RICADENTE NELLE CASSETTE AL BALCONE. HA FUSTI SOTTILI CHIARI E FOGLIE TONDEGGIANTI E PELTATE (CON IL PICCIOLO INSERITO DIRETTAMENTE NELLA LAMINA, ANZICHÉ SUL BORDO). DA GIUGNO A OTTOBRE PRODUCE FIORI SPERONATI, DI 5 CM DI DIAMETRO, DI COLORE GIALLO, ARANCIO, ROSSO. PER IL CONTENITORE SONO ADATTE LE CULTIVAR DEI GRUPPI JEWEL MIXED (30 CM D’ALTEZZA) O TOM THUMB (25 CM D’ALTEZZA).",
                   Coltivazione = "Sopporta fino a 5 °C. Si ottiene da seme, in marzo. Richiede una posizione a mezz’ombra, comunque non esposta al sole del mezzogiorno estivo. Il substrato migliore è leggero, sciolto, non molto ricco (è preferibile un vaso piccolo, che lo costringe a fiorire anziché produrre foglie). Necessita di molta acqua in estate e va concimato una volta al mese con un prodotto per piante da fiore. È consigliabile eliminare le corolle appassite.",
                   Malattie = "",
                },

                new PianteAnnuali
                {
                   NomeComunePianta = "OSTEOSPERMUM (DIMORFOTECA)",
                   NomeFamiglia = "Composite",
                   NomeScientificoPianta = "Dimorphoteca ",
                   FotoPianta = "ms-appx:///Immagini/Annuali/Dimorfoteca/DIMORFOTECA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Annuali/Abete-*.jpg",

                   DescrizioneBotanica = "PERENNE COLTIVATA DI SOLITO COME ANNUALE, ADATTA AD AIUOLE SCENOGRAFICHE, BORDURE VISTOSE O COLTIVAZIONE IN VASO (GRANDE, DAI 24 CM IN SU). FORMA DENSI CESPI DI FOGLIE LANCEOLATE, CEROSE E CUOIOSE, DA CUI SI ERGONO NUMEROSISSIMI FUSTI CHE PORTANO, DA APRILE A OTTOBRE, FIORI SIMILI A MARGHERITE, DI DIAMETRO DI 5 CM, DI COLORE BIANCO, ROSA, GIALLO, ROSSO O VIOLA, IN GENERE CON CENTRO DI COLORE PIÙ SCURO (CON PETALI A CUCCHIAIO IN ALCUNE VARIETÀ).",
                   Coltivazione = "Quando la temperatura scende sotto gli 8 °C la parte aerea si secca e scompare, per rigermogliare dalle radici nella primavera successiva (con fioriture ridotte se è in vaso). Vuole una posizione in pieno sole ma al riparo dai venti. Necessita di un substrato fertile, sciolto e ben drenato e di annaVature estive costanti, dopo che il terriccio si è asciugato. Si concima una volta al mese, con prodotti per piante da fiore.",
                   Malattie = "",
                },

                new PianteAnnuali
                {
                   NomeComunePianta = "PETUNIA E SURFINIA",
                   NomeFamiglia = "Solanacee",
                   NomeScientificoPianta = "Petunia x hybrida, Surfinia",
                   FotoPianta = "ms-appx:///Immagini/Annuali/Petunia/PETUNIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Annuali/Abete-*.jpg",

                   DescrizioneBotanica = "PERENNI COLTIVATE COME ANNUALI (NEL SECONDO ANNO FIORISCONO MENO), DAI FUSTI PELOSI, RAMIFICATI E VISCHIOSI, CON FOGLIE OPPOSTE, APPICCICOSE, DI COLORE VERDE CHIARO. PETUNIA HA PORTAMENTO ERETTO (ALTA FINO A 30 CM); SURFINIA HA RAMI RICADENTI (FINO A 1 M). DA APRILE A OTTOBRE PRODUCONO FIORI SOLITARI, IMBUTIFORMI, SEMPLICI O DOPPI, BIANCHI, GIALLI, SALMONE, ROSA, ROSSI, VIOLA O BICOLORI. ‘MILLION BELLS’ HA TAGLIA RIDOTTA, CALIBRACHOA È ADDIRITTURA NANA (ALTA 15 CM).",
                   Coltivazione = "Petunia tollera temperature fino a 5 °C, le altre specie e varietà fino a 10 °C. Desiderano posizioni a mezz’ombra, non al sole del mezzogiorno estivo. Amano terra fertile, leggera, ben drenata. Richiedono molta acqua in estate, su terra appena asciutta. Vanno concimate ogni 10 giorni con un prodotto per piante da fiore. E' bene eliminare i fiori appassiti. Adatte alla vita in vaso, tranne Surfinia che è specifica per i basket. ",
                   Malattie = "",
                },

                new PianteAnnuali
                {
                   NomeComunePianta = "PORTULACA",
                   NomeFamiglia = "Portulacacee",
                   NomeScientificoPianta = "Portulaca oleracea",
                   FotoPianta = "ms-appx:///Immagini/Annuali/Portulaca/PORTULACA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Annuali/Abete-*.jpg",

                   DescrizioneBotanica = "ANNUALE SUCCULENTA, CON FUSTI CILINDRICI, ROSSASTRI, SEMIPROSTRATI (ALTEZZA E LUNGHEZZA MASSIME 15 CM). HA FOGLIE CORTE, CILINDRICHE, CARNOSE, DI COLORE VERDE BRILLANTE. DA MAGGIO A SETTEMBRE PRODUCE FIORI SEMPLICI O DOPPI, A FORMA DI COPPA, DEL DIAMETRO FINO A 5 CM, CON PETALI LUCIDI E SETOSI, BIANCHI, GIALLI, ARANCIO, ROSA, ROSSI O PORPORA. I FIORI SI APRONO AL MATTINO CON IL SOLE E SI CHIUDONO NEL POMERIGGIO O CON LA PIOGGIA. NUMEROSE LE VARIETÀ FLORICOLE.",
                   Coltivazione = "Resiste fino a 10°C. Si ricava da seme, in aprile, anche per autorisemina (nelle varietà fertili). Necessita del pieno sole, tollera la mezz’ombra. Desidera un terriccio sciolto, fertile, molto ben drenato. Si annaffia all’occorrenza in estate, se le foglie si serrano sui fusti. La concimazione è ridotta a una volta al mese, con prodotti per piante da fiore. Adatta a bordure strette, giardini rocciosi, vasi, cassette e basket.",
                   Malattie = "",
                },

                new PianteAnnuali
                {
                   NomeComunePianta = "PRIMULA",
                   NomeFamiglia = "Primulacee",
                   NomeScientificoPianta = "Primula x polyantha",
                   FotoPianta = "ms-appx:///Immagini/Annuali/Primula/PRIMULA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Annuali/Abete-*.jpg",

                   DescrizioneBotanica = "PERENNE IN GENERE COLTIVATA COME ANNUALE, RUSTICA, È PRIVA DI FUSTO. LE FOGLIE RADICALI SONO DISPOSTE A ROSETTA E HANNO LAMINA OVALE, BOLLOSA, COLOR VERDE CHIARO. DA GENNAIO AD APRILE PRODUCE FIORI RIUNITI IN INFIORESCENZE A OMBRELLA, DI COLORE BIANCO, GIALLO, ROSA, ROSSO, AZZURRO, VIOLA, SEMPLICI O DOPPI. ADATTA A CIOTOLE E CASSETTE (DOVE DI SOLITO NON SUPERANO L’ESTATE), MA ANCHE AL PIEDE DI ALBERI CADUCIFOGLI O DI UNA SIEPE SPOGLIANTE.",
                   Coltivazione = "In fioritura tollera fino a +3 °C, mentre durante il riposo invernale, in piena terra, resiste fino a –10 °C, perdendo la parte aerea, che si riforma in primavera. Richiede il sole in fioritura, ma l’ombra in primavera ed estate. Desidera un substrato fresco e fertile, ben drenato, da mantenere costantemente inumidito, specie in estate. Va concimata con stallatico in autunno e con prodotti per piante da fiore da gennaio in poi.",
                   Malattie = "",
                },

                new PianteAnnuali
                {
                   NomeComunePianta = "SALVIA DA FIORE",
                   NomeFamiglia = "Labiate",
                   NomeScientificoPianta = "Salvia splendens",
                   FotoPianta = "ms-appx:///Immagini/Annuali/Salvia da Fiore/SALVIA DA FIORE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Annuali/Abete-*.jpg",

                   DescrizioneBotanica = "PERENNE DI SOLITO COLTIVATA COME ANNUALE, CON UN FUSTO ESILE ED ERBACEO, È ALTA FINO A 30 CM. HA FOGLIE OVATO-LANCEOLATE CON MARGINI DENTATI, DI COLORE VERDE BRILLANTE. DA MAGGIO A OTTOBRE PRODUCE INCESSANTEMENTE SPIGHE TERMINALI DI FIORI INSIGNIFICANTI MA CIRCONDATI DA BRATTEE ROSSO VIVO (ROSSO MATTONE, ROSA O PORPORA NELLE VARIETÀ FLORICOLE), CHE SPESSO VENGONO SCAMBIATE PROPRIO PER I FIORI. IDEALE IN AIUOLE, BORDURE, CASSETTE, VASETTI.",
                   Coltivazione = "Soffre già sotto i 10 °C. Si riproduce da talea, ricavata in agosto. Richiede il sole pieno, ma resiste anche in mezz’ombra. Desidera un terriccio fertile, fresco, ben drenato. Necessita di annaffiature costanti in estate, soprattutto in vaso, appena il substrato si è asciugato. È bene fornire concime liquido per piante da fiore ogni 15 giorni nell’acqua d’irrigazione. Bisogna eliminare le spighe appassite per prolungare la fioritura.",
                   Malattie = "",
                },

                 new PianteAnnuali
                {
                   NomeComunePianta = "SCAEVOLA",
                   NomeFamiglia = "Godenacee",
                   NomeScientificoPianta = "Scaevola aemula",
                   FotoPianta = "ms-appx:///Immagini/Annuali/Scaevola/SCAEVOLA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Annuali/Abete-*.jpg",

                   DescrizioneBotanica = "PERENNE UTILIZZATA COME ANNUALE, CON FUSTI DAPPRIMA ERETTI E POI RICADENTI, FLESSIBILI, LUNGHI FINO A 30 CM, A FORMARE DENSI CESPUGLIETTI, DA IMPIEGARE COME TAPPEZZANTE IN GIARDINO E SU MURETTI, OPPURE IN CASSETTE AL BALCONE O IN BASKET. HA FOGLIOLINE LANCEOLATE, CONSISTENTI, DI COLORE VERDE SCURO. DA MARZO A SETTEMBRE PRODUCE INCESSANTEMENTE PICCOLI FIORI A FORMA DI VENTAGLIO, COLOR PORPORA, BLU O VIOLA, CON OCCHIO GIALLO O BIANCO.",
                   Coltivazione = "Soffre a temperature inferiori a 10 °C e soprattutto in caso di piogge prolungate: desidera un terriccio molto sciolto, leggero, con drenaggio perfetto, soprattutto in piena terra. Va annaffiata con regolarità in estate, specialmente se è in vaso, ma solo dopo che il substrato si è asciugato. Desidera il sole o la mezz’ombra. Si concima ogni 15 giorni. In inverno può essere ricoverata in appartamento, in una stanza fresca.",
                   Malattie = "",
                },

                new PianteAnnuali
                {
                   NomeComunePianta = "TAGETE",
                   NomeFamiglia = "Composite",
                   NomeScientificoPianta = "Tagetes patula",
                   FotoPianta = "ms-appx:///Immagini/Annuali/TAgete/TAGETE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Annuali/Abete-*.jpg",

                   DescrizioneBotanica = "CHIAMATA ANCHE GAROFANO D’INDIA, È UN’ANNUALE DAL FUSTO CORTO (MASSIMO 30 CM D’ALTEZZA) ORNATO DA FOGLIE PROFONDAMENTE INCISE, DI COLORE VERDE SCURO. DA MAGGIO A OTTOBRE PRODUCE CAPOLINI APICALI SOLITARI, SEMPLICI O DOPPI, DEL DIAMETRO DI 5 CM, DI COLORE GIALLO, ARANCIO, ROSSO O MARRONE. TUTTA LA PIANTA, SE SPEZZATA, EMANA UN ODORE INTENSO E SGRADEVOLE (VIENE DETTA ANCHE ERBA PUZZOLA) CHE PERÒ ALLONTANA I PARASSITI ANIMALI.",
                   Coltivazione = "Teme temperature di 10 °C. Si riproduce da seme, in marzo. Ama le posizioni soleggiate. Desidera un terriccio fertile, sciolto, ben drenato. Va annaffiata con regolarità in estate, appena prima che il substrato si asciughi. Si concima ogni 15 giorni con un fertilizzante liquido per piante da fiore. I fiori appassiti vanno costantemente eliminati. Si utilizza in aiuole, come bordura bassa, in vasi e cassette da balcone.",
                   Malattie = "",
                },

                new PianteAnnuali
                {
                   NomeComunePianta = "VERBENA",
                   NomeFamiglia = "Verbenacee",
                   NomeScientificoPianta = "Verbena x hybrida",
                   FotoPianta = "ms-appx:///Immagini/Annuali/Verbena/VERBENA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Annuali/Abete-*.jpg",

                   DescrizioneBotanica = "PERENNE IMPIEGATA COME ANNUALE (NEL SECONDO ANNO FIORISCE MENO), DAI FUSTI ERETTI E QUADRANGOLARI, CHE POSSONO RAGGIUNGERE I 30 CM D’ALTEZZA; LA PIANTA TENDE AD ALLARGARSI. HA FOGLIE OVALI DAL MARGINE DENTELLATO. DA MAGGIO A OTTOBRE PRODUCE PICCOLI FIORI SIMILI A PRIMULE, RIUNITI IN INFIORESCENZE A SPIGA TERMINALE, DAL PROFUMO GRADEVOLE E PENETRANTE, NEI COLORI BIANCO, ROSA, SALMONE, ROSSO, PORPORA, VIOLA, ANCHE BICOLORI.",
                   Coltivazione = "Teme temperature di 8 °C. Si moltiplica per seme, in marzo, o per talea, in agosto. Ama il sole pieno e il terriccio fertile, sciolto, ben drenato. Desidera annaffiature regolari in estate, soprattutto in vaso, senza bagnare il fogliame (sensibile al mal bianco). Va concimata ogni 15 giorni con un prodotto per piante da fiore. È la pianta ideale per aiuole oppure in cassette da balcone (esistono varietà anche per il basket).",
                   Malattie = "",
                },

                new PianteAnnuali
                {
                   NomeComunePianta = "ZINNIA",
                   NomeFamiglia = "Composite",
                   NomeScientificoPianta = "Zinnia elegans",
                   FotoPianta = "ms-appx:///Immagini/Annuali/Zinnia/ZINNIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Annuali/Abete-*.jpg",

                   DescrizioneBotanica = "ANNUALE CON FUSTI MORBIDI PER UN’ALTEZZA VARIABILE FRA 30 E 120 CM A SECONDA DELLE VARIETÀ, PER COSTITUIRE FOLTI CESPUGLI ERETTI E RAMIFICATI. LE FOGLIE SONO OVALI, COLOR VERDE SCURO. DA MAGGIO A OTTOBRE PRODUCE GRANDI FIORI (FINO A 12 CM DI DIAMETRO) SOLITARI A FORMA DI MARGHERITA, SEMPLICI O DOPPI, IN TUTTI I COLORI TRANNE IL BLU, ANCHE BICOLORI O SCREZIATI. SI IMPIEGA IN VASI E CASSETTE DA BALCONE (CULTIVAR BASSE), IN AIUOLE (CV. MEDIE), PER BORDURE (CV. ALTE).",
                   Coltivazione = "Temperaure di 10 °C ne interrompono il ciclo vitale. Si riproduce da seme, in marzo. Necessita del pieno sole e di un substrato leggero, fertile e ben drenato (ma si adattano ad altre tipologie). Va annaffiata con costanza durante l’estate, appena il terriccio si è asciugato, soprattutto in vaso. Ogni 15 giorni è bene concimare con un prodotto per piante da fiore. Occorre eliminare con cura i fiori appassiti.",
                   Malattie = "",
                },


               


            };

            return data;
        }

        // TODO WTS: Remove this once your MasterDetail pages are displaying real data
        public static async Task<IEnumerable<PianteAnnuali>> GetSampleModelDataAsync()
        {
            await Task.CompletedTask;

            return AllPianteAnnuali();
        }

        
    }
}
