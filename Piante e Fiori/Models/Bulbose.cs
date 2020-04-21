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
//31 BULBOSE E TUBEROSE PRAIMAVERILI ED ESTIVE
    public class Bulbose
    {
        public string NomeComunePianta { get; set; }
        public string NomeFamiglia { get; set; }
        public string NomeScientificoPianta { get; set; }
        public string FotoPianta { get; set; }
        public string SourceGalleryFotografica { get; set; }

        public string DescrizioneBotanica { get; set; }
        public string Coltivazione { get; set; }
        public string Potatura { get; set; }
        public string Malattie { get; set; }
        public string AltreCaratteristiche { get; set; }


    }

    public static class BulboseDataService
    {
        private static IEnumerable<Bulbose> AllBulbose()
        {
            // The following is order summary data
            var data = new ObservableCollection<Bulbose>
            {
               
                new Bulbose
                {
                   NomeComunePianta = "AGAPANTO",
                   NomeFamiglia = "Liliacee",
                   NomeScientificoPianta = "Agapanthus",
                   FotoPianta = "ms-appx:///Immagini/Bulbose/Agapanto/AGAPANTO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Bulbose/Abete-*.jpg",

                   DescrizioneBotanica = "BULBOSA PERENNE APPREZZATA PER IL FOGLIAME A NASTRO E ARCUATO, MA SOPRATTUTTO PER LE SPETTACOLARI INFIORESCENZE ESTIVE. I FIORI, BLU, AZZURRI O BIANCHI (NELLE VARIETÀ), SONO A CAMPANELLA APERTA, PORTATI IN INFIORESCENZE A OMBRELLA SU STELI ERETTI, ALTI 1 M E PIÙ. LE SPECIE PIÙ COMUNI SONO A. AFRICANUS, A. CAMPANULATUS, A. PRAECOX; INNUMEREVOLI SONO LE VARIETÀ FLORICOLE. VIENE UTILIZZATO IN BORDURE, CONTRO MURETTI O PARETI; SI PUÒ IMPIEGARE COME RECISO.",
                   Coltivazione = "Piante rustiche, tollerano, se poste in piena terra, fino a –10 °C. Vivono bene anche su pendii aridi o vicino alle coste marine. Gradiscono il pieno sole ma tollerano la mezz’ombra; sono indifferenti alla natura del terreno purché abbiano acqua a sufficienza in primavera ed estate. Alla fine dell’inverno le foglie appassite vanno recise alla base. Si piantano a 15 cm di profondità e a distanza di 30-60 cm fra l’uno e l’altro. ",
                   Potatura = "",
                   Malattie = "",
                },

                new Bulbose
                {
                   NomeComunePianta = "ALLIUM",
                   NomeFamiglia = "Liliacee",
                   NomeScientificoPianta = "Allium",
                   FotoPianta = "ms-appx:///Immagini/Bulbose/Allium/ALLIUM.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Bulbose/Abete-*.jpg",

                   DescrizioneBotanica = "BEN 700 SPECIE FORMANO QUESTO GENERE, LO STESSO DELLE PIANTE DA ORTO; AGLIO, PORRO E CIPOLLA. GLI ALLIUM ORNAMENTALI SFOGGIANO FIORI VISTOSAMENTE COLORATI, RACCOLTI IN OMBRELLE SFERICHE PIÙ O MENO GRANDI. SI DISTINGUONO PRINCIPALMENTE DUE GRUPPI: GLI ALLIUM DI TAGLIA MEDIO-BASSA (10-60 CM) E QUELLI ALTI (60-150 CM), DAI FIORI ROSA, ROSSI, AZZURRI, GIALLI, VIOLA ECC. FRA I PRIMI SI ANNOVERANO A. KARATAVIENSE E A. MOLY; FRA I SECONDI A. CHRISTOPHII E A. GIGANTEUM.",
                   Coltivazione = "Bulbo rustico (resiste fino a –15 °C), gradisce una posizione aperta e soleggiata, con un terreno fertile, ben drenato. I bulbi si piantano in primavera o autunno, a profondità di 10-12 cm e distanza fra loro di 10-20 cm, effettuando una sola concimazione in primavera. Quelli di taglia bassa sono indicati per la coltivazione in vaso o nel giardino roccioso; quelli alti come esemplari singoli in aiuole o come fiori recisi.",
                   Potatura = "",
                   Malattie = "",
                },

                 new Bulbose
                {
                   NomeComunePianta = "ALSTROEMERIA",
                   NomeFamiglia = "Liliacee",
                   NomeScientificoPianta = "Alstoemeria",
                   FotoPianta = "ms-appx:///Immagini/Bulbose/Alstroemeria/ALSTROEMERIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Bulbose/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTA RIZOMATOSA E TUBEROSA, CARATTERIZ ZATA DA FUSTI ERETTI, ALTI 30120 CM, COSPARSI DI FOGLIE FRA LE QUALI, IN TARDA PRIMAVERA, SBOCCIANO I FIORI DALLA FORMA IRREGOLARE E BAROCCA, IN TUTTI I COLORI TRANNE L’AZZUR RO, IL BLU E IL VIOLA, FIAMMEGGIATI O STRIATI. SI COLTIVANO IN GENERE LE NUMEROSE VARIETÀ FLORICOLE, FRA CUI I GRUPPI OLANDESE E DR. SALTER, SELEZIONATI ANCHE PER LA PRODUZIO NE DI FIORI RECISI: LE COROLLE, INFATTI, HANNO UNA LUNGA DURATA NELL’ACQUA PULITA.",
                   Coltivazione = "Specie rustica, che tollera temperature ﬁ no a –10 °C soprattutto se la radice viene protetta con una pacciamatura di paglia o foglie secche, gradisce un’esposizione al sole o a mezz’ombra, su un terreno ricco, ben drenato e leggermente acido. Si pianta in autunno o in primavera, a profondità di 15-20 cm e a distanza di 40-70 cm tra un tubero e l’altro. Adatta per giardini naturalistici, sotto gli alberi o su pendii, e in bordura.",
                   Malattie = "",
                },

                 new Bulbose
                {
                   NomeComunePianta = "AMARILLIS",
                   NomeFamiglia = "Amarillidacee",
                   NomeScientificoPianta = "Amaryllis, Hippeastrum",
                   FotoPianta = "ms-appx:///Immagini/Bulbose/Amarillis/AMARILLIS.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Bulbose/Abete-*.jpg",

                   DescrizioneBotanica = "AMARYLLIS È UN BULBO SEMIRUSTICO, IDONEO ANCHE ALLA PIANTAGIONE ALL’APERTO IN CLIMI NON TROPPO FREDDI. A. BELLADONNA PORTA LUNGHE OMBRELLE DI FIORI ROSA CARICO LUNGHI CIRCA 10 CM; LE FOGLIE COMPAIONO E MUOIONO PRIMA DEI FIORI. HIPPEASTRUM È IL CLASSICO BULBO DA COLTIVARE IN VASO IN APPARTAMENTO PER AVERE LA FIORITURA NEL PERIODO NATALIZIO. NE ESISTONO NUMEROSE VARIETÀ FLORICOLE, CHE PRODUCONO GRANDI FIORI IN VARIE TINTE PRIMA DI EMETTERE IL FOGLIAME.",
                   Coltivazione = "Entrambi i bulbi temono il freddo intenso. Si piantano in autunno, avendo cura di far sporgere il bulbo dalla terra per circa un terzo. L’amarillis, in giardino, richiede una posizione soleggiata e ben drenata. L’ippeastro, in vaso, va annaffiato con regolarità ma senza eccedere. Vanno concimati in abbondanza solo dopo la fioritura, per ricostituire le sostanze di riserva per la rifioritura nell’anno successivo.",
                   Malattie = "",
                },

                 new Bulbose
                {
                   NomeComunePianta = "ANEMONE",
                   NomeFamiglia = "Ranunculacee",
                   NomeScientificoPianta = "Anemone",
                   FotoPianta = "ms-appx:///Immagini/Bulbose/Anemone/ANEMONE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Bulbose/Abete-*.jpg",

                   DescrizioneBotanica = "IL GENERE COMPRENDE OLTRE 100 SPECIE SPONTANEE, MOLTE DELLE QUALI VIVONO ANCHE NEI BOSCHI ITALIANI. TUTTE PRESENTANO FIORI A FORMA DI STELLA O DI COPPA, CON CINQUE O PIÙ PETALI DI VARI COLORI. SI DISTINGUONO GLI ANEMONI A FIORITURA PRIMAVERILE (A RADICI TUBEROSE E RIZOMATOSE), COME A. BLANDA, A. CORONARIA E A. NEMOROSA, E QUELLI A FIORITURA ESTIVO-AUTUNNALE (A RADICI FIBROSE), COME A. HUPEHENSIS E A. HYBRIDA: QUESTI ULTIMI SONO ADATTI ALLE BORDURE.",
                   Coltivazione = "Molte specie boschive sono del tutto rustiche (fino a –15 °C) e gradiscono un terreno ricco, umido e ben drenato, in leggera mezz’ombra. Quelle a radice tuberosa prediligono il sole pieno e un periodo di dormienza asciutto. Il pH del suolo deve aggirarsi attorno a 6,5-7. Le specie rizomatose, se lasciate indisturbate in condizioni idonee, negli anni formano densi tappeti di foglie delicate e di fiori coloratissimi.",
                   Malattie = "",
                },

                 new Bulbose
                {
                   NomeComunePianta = "ARUM O GIGARO",
                   NomeFamiglia = "Aracee",
                   NomeScientificoPianta = "Arum",
                   FotoPianta = "ms-appx:///Immagini/Bulbose/Arum/ARUM.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Bulbose/Abete-*.jpg",

                   DescrizioneBotanica = "GENERE CHE COMPRENDE 26 SPECIE DALLE FOGLIE GRANDI E MOLTO DECORATIVE E DAI FIORI PRIMAVERILI CON GRANDI SPATE ()L’INVOLUCRO CHE AVVOLGE LO SPADICE FIORALE GIALLO) IN VARI COLORI, A VOLTE PROFUMATI E ALTRE MALEODORANTI. LE SPECIE PIÙ COMUNEMENTE UTILIZZATE IN GIARDINO SONO A. ITALICUM, COLTIVATO SOPRATTUTTO PER IL BEL FOGLIAME (LA VARIETÀ MARMORATUM HA FOGLIE VARIEGATE DI BIANCO CREMA), E A. CRETICUM, DOTATO DI SPATE PROFUMATE LUNGHE FINO A 25 CENTIMETRI.",
                   Coltivazione = "I tuberi, che non temono il gelo, si mettono a dimora in autunno o primavera, in posizione a mezz’ombra, riparata dai venti freddi e su terreno ben drenato e ricco di humus. Durante l’estate il tubero va mantenuto all’asciutto, mentre nel periodo vegetativo va annaffiato con moderazione e concimato con un prodotto bilanciato. La profondità di piantagione è di 10-15 cm, la distanza tra i tuberi di 30 centimetri.",
                   Malattie = "",
                },

                 new Bulbose
                {
                   NomeComunePianta = "BEGONIA TUBEROSA",
                   NomeFamiglia = "Begoniacee",
                   NomeScientificoPianta = "Begonia",
                   FotoPianta = "ms-appx:///Immagini/Bulbose/Begonia/BEGONIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Bulbose/Abete-*.jpg",

                   DescrizioneBotanica = "SONO CIRCA 1.500 LE SPECIE DI BEGONIA ESISTENTI, ALTE DA POCHI CENTIMETRI A 3 M, ERETTE O PENDENTI, MA TUTTE CON FIORI SGARGIANTI E SPETTACOLARI FOGLIE ASIMMETRICHE. IN GIARDINO SI UTILIZZANO IN PARTICOLARE B. X TUBERHYBRIDA, CHE PRODUCE GRANDI FIORI MULTICOLORI SEMPLICI O DOPPI TRA FOGLIE VERDI SCURE, E B. SEMPERFLORENS (RIZOMATOSA), DI PICCOLE DIMENSIONI E CON PICCOLI MA NUMEROSI FIORI PRODOTTI DI CONTINUO, DALLA PRIMAVERA ALL’AUTUNNO.",
                   Coltivazione = " Le begonie non resistono al di sotto degli 8 °C: alle soglie dell’autunno, quando il freddo fa avvizzire il fogliame, i tuberi vanno espiantati e ricoverati in luogo fresco e protetto. Si pongono a dimora, anche in vaso, in primavera, a profondità di 3-5 cm e a distanza di 30-40 cm uno dall’altro. Necessitano di terriccio fertile, da mantenere leggermente umido ma senza ristagni, e di molto concime ogni 15 giorni.",
                   Malattie = "",
                },

                 new Bulbose
                {
                   NomeComunePianta = "BUCANEVE E CAMPANELLINO",
                   NomeFamiglia = "Amarillidacee",
                   NomeScientificoPianta = "Galanthus nivalis, Leucojum vernum",
                   FotoPianta = "ms-appx:///Immagini/Bulbose/Bucaneve/BUCANEVE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Bulbose/Abete-*.jpg",

                   DescrizioneBotanica = "BUCANEVE E CAMPANELLINO SI DIFFERENZIANO SOLO PER IL FATTO DI AVERE I FIORI ORLATI DI VERDE IL PRIMO, COMPLETAMENTE BIANCHI IL SECONDO. ENTRAMBI SONO BULBI DI PICCOLE DIMENSIONI (ALTEZZA MASSIMA 20 CM) CHE PRODUCONO I FIORI IN GENNAIO-FEBBRAIO, ANCHE EMERGENTI DALLA COLTRE DI NEVE, TRA IL CIUFFO DI ESILI FOGLIE, A PREANNUNCIARE LA PRIMAVERA. ESISTONO NUMEROSE VARIETÀ FLORICOLE DI GALANTHUS, ALCUNE DELLE QUALI A FIORE PROFUMATO.",
                   Coltivazione = "Entrambi sono bulbi molto rustici (resistono fino a –15 °C), che non temono gelate e nevicate persistenti. Si coltivano a mezz’ombra, su terreno ricco, umido, ben drenato, ponendo i bulbi a 10 cm di profondità e a distanza di 8-15 cm uno dall’altro. Si prestano ambedue a collocazioni naturalistiche, perché tendono a naturalizzarsi moltiplicandosi da soli, fino a regalare tappeti fioriti nel cuore dell’inverno. ",
                   Malattie = "",
                },

                 new Bulbose
                {
                   NomeComunePianta = "CANNA D’INDIA",
                   NomeFamiglia = "Cannacee",
                   NomeScientificoPianta = "Canna",
                   FotoPianta = "ms-appx:///Immagini/Bulbose/Canna/CANNA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Bulbose/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTA RIZOMATOSA DI CUI OGGI SI COLTIVA NON PIÙ LA SPECIE, CANNA INDICA, BENSÌ LE NUMEROSISSIME VARIETÀ FLORICOLE, SELEZIONATE PER I COLORI E LE VARIEGATURE E SCREZIATURE DEI FIORI: DAL BIANCO AL MARRONE, CON L’ESCLUSIONE DELL’AZZURRO, DEL BLU E DEL VIOLA. SI FA APPREZZARE ANCHE PER L’ELEGANZA DELLE FOGLIE, GRANDI ED ERETTE, DI COLORE VERDE CHIARO O SCURO, BRONZO, VIOLACEO, TALVOLTA VENATE DI BIANCO O GIALLO. RAGGIUNGE UN’ALTEZZA MASSIMA DI 150 CENTIMETRI.",
                   Coltivazione = "Il rzoma soffre sotto lo zero, quindi le radici vanno ritirate dal terreno nelle zone più fredde. Ama un’esposizione soleggiata, un terreno ricco, morbido e umido, ma ben drenato, con concimazioni frequenti per tutta l’estate. La radice si pianta in aprile a 8 cm di profondità e 30-50 cm di distanza tra una e l’altra. Facilissima da coltivare e poco esigente, si adatta anche al vaso ed è idonea per bordure o in aiuole.",
                   Malattie = "",
                },

                 new Bulbose
                {
                   NomeComunePianta = "CHIONODOXA",
                   NomeFamiglia = "Liliacee",
                   NomeScientificoPianta = "Chionodoxa",
                   FotoPianta = "ms-appx:///Immagini/Bulbose/Chionodoxa/CHIONODOXA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Bulbose/Abete-*.jpg",

                   DescrizioneBotanica = "IL GENERE COMPRENDE 6 SPECIE, PARENTI DEI GIACINTI E SIMILI ALLE SCILLE. HANNO FOGLIE BASALI LINEARI E PRODUCONO IN PRIMAVERA RACEMI DI FIORI AZZURRI, BIANCHI O ROSA. LE SPECIE PIÙ UTILIZZATE SONO C. LUCILIAE (7-20 CM D’ALTEZZA) CON RACEMI DI 14 CM NEI TRE COLORI; C. FORBESII (FINO A 30 CM) E C. SARDENSIS CON FIORI DALL’INTENSO BLU GENZIANA. SI UTILIZZANO ANCHE COME FIORE RECISO, MA PRINCIPALMENTE SI LASCIANO INSELVATICHIRE, PIANTANDOLE IN GRANDI MASSE.",
                   Coltivazione = "Resiste al freddo (fino a –15 °C) e va piantata in autunno a una profondità di 8 cm e a una distanza di 5 cm tra un bulbo e l’altro. Necessita di una buona esposizione al sole o in leggera mezz’ombra, di un terreno ben drenato e soffice, e di basse temperature invernali, che inducono la fioritura. Tollerano la posizione in pendio, sotto la chioma di alberi decidui o davanti alle bordure di arbusti caducifogli.",
                   Malattie = "",
                },

                new Bulbose
                {
                   NomeComunePianta = "CICLAMINO",
                   NomeFamiglia = "Primulacee",
                   NomeScientificoPianta = "Cyclamen",
                   FotoPianta = "ms-appx:///Immagini/Bulbose/Ciclamino/CICLAMINO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Bulbose/Abete-*.jpg",

                   DescrizioneBotanica = "IL GENERE COMPRENDE 19 SPECIE CON RADICE A TUBERO DISCOIDALE E APPIATTITO. HA FOGLIE CARNOSE A FORMA DI CUORE, VARIAMENTE SCREZIATE DI GRIGIO SU FONDO VERDE SCURO. I FIORI PENDULI, COMPOSTI DA 5 PETALI, SONO BIANCHI, ROSA, ROSSI O VIOLA. C. PERSICUM È IL CICLAMINO DEI FIORISTI, ESISTENTE IN MOLTEPLICI VARIETÀ FLORICOLE. C. HEDERIFOLIUM E C. NEAPOLITANUM SONO LE SPECIE DI BOSCO, RUSTICHE (TOLLERANO FINO A -15 °C), LA PRIMA DELLE QUALI HA FIORI PROFUMATI.",
                   Coltivazione = "Desidera un terriccio leggero, soffice, fertile, umido, ben drenato, ricco di humus. Si pianta in autunno, a 3-5 cm di profondità (il tubero deve leggermente affiorare in superficie) e distanziando gli esemplari di 10-15 centimetri. Preferisce la mezz’ombra o l’ombra piena. Si concima in prossimità della fioritura, che avviene in autunno. Le specie spontanee sono adatte al giardino, sotto grandi alberi decidui o sempreverdi.",
                   Malattie = "",
                },

                new Bulbose
                {
                   NomeComunePianta = "COLCHICO",
                   NomeFamiglia = "Colchicacee",
                   NomeScientificoPianta = "Colchicum",
                   FotoPianta = "ms-appx:///Immagini/Bulbose/Colchico/COLCHICO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Bulbose/Abete-*.jpg",

                   DescrizioneBotanica = "MOLTO SIMILE AL CROCO, IL FALSO ZAFFERANO O COLCHICO PRODUCE GRAZIOSISSIMI FIORI, DIRETTAMENTE DAL BULBO (E OGNUNO NE PRODUCE UN BUON NUMERO), PRATICAMENTE PRIVI DI FUSTO. I FIORI, LILLA O ROSA, RARAMENTE BIANCHI, SONO AUTUNNALI: DA SETTEMBRE A NOVEMBRE FORMANO BELLISSIME MACCHIE DI COLORE NELLE BORDURE E IN MEZZO AI PRATI. C. LUTEUM SI DISTINGUE IN QUANTO FIORISCE IN FEBBRAIO E HA FIORI GIALLI. LE FOGLIE SONO GRANDI, LUCIDE, LANCEOLATE.",
                   Coltivazione = "Del tutto rustici, i bulbo-tuberi possono rimanere per molti anni indisturbati nel terreno. Si piantano in gruppi di almeno 6 tuberi, a una profondità di 8 cm, in agosto o settembre, in posizioni aperte, al sole o in ombra filtrata. Esigono un terreno fertile, ben drenato, mai secco: una pacciamtura lo manterrà umido nei mesi caldi. Ai prati si addicono le specie C. autumnale e C. speciosum; le varietà sono adatte a roccaglie e bordure.",
                   Malattie = "",
                },

                 new Bulbose
                {
                   NomeComunePianta = "CROCO",
                   NomeFamiglia = "Iridacee",
                   NomeScientificoPianta = "Crocus",
                   FotoPianta = "ms-appx:///Immagini/Bulbose/Croco/CROCO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Bulbose/Abete-*.jpg",

                   DescrizioneBotanica = "PICCOLO E DELIZIOSO, IL CROCO È IL PRIMO ANNUNCIO DI PRIMAVERA: GIÀ A FINE INVERNO, QUANDO ANCORA C’È LA NEVE, APRE I SUOI FIORI CAMPANULATI, SU STELI CORTISSIMI, BIANCHI, GIALLI, VIOLA, STRIATI O SFUMATI. FA CAPOLINO NEI PRATI NATURALI, NELLE BORDURE DI TAPPEZZANTI, NEI VASI DEL BALBONE. DOPO I FIORI COMPAIONO LE FOGLIE, LUNGHE E SOTTILI, CON UNA NERVATURA CENTRALE CHIARA. LASCIATI NEL TERRENO, I CROCHI SI RIPRODUCONO SPONTENEAMENTE DONANDO RICCHE FIORITURE.",
                   Coltivazione = "Amano essere coltivati sotto i raggi filtrati del sole, per esempio ai piedi di un albero caducifoglie o di un arbusto leggero, ma prosperano anche al centro dei tappeti erbosi. Si piantano all’inizio dell’autunno a una profondità di 7,5 cm e a una distanza di circa 10 centimetri. Non hanno esigenze riguardo al terreno, purché sia ben drenato. Anche se non sono bellissime, le foglie non vanno recise finché non sono appassite.",
                   Malattie = "",
                },

                 new Bulbose
                {
                   NomeComunePianta = "CROCOSMIA (MONTBRETIA)",
                   NomeFamiglia = "Iridacee",
                   NomeScientificoPianta = "Crocosmia",
                   FotoPianta = "ms-appx:///Immagini/Bulbose/Crocosmia/CROCOSMIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Bulbose/Abete-*.jpg",

                   DescrizioneBotanica = "TRA LUGLIO E SETTEMBRE QUESTA BELLA PIANTA, ALTA CIRCA 60 CM, DALLE LUNGHE FOGLIE LINEARI E LANCEOLATE, PRODUCE SPIGHE DECORATIVE DI FIORI A CALICE COLORATISSIMI, MOLTO APPREZZATI ANCHE COME FIORI RECISI. C. MASONORUM, SPLENDIDA NELLE BORDURE, HA FIORI ARANCIO DISPOSTI SU DUE FILE A FIORITURA PROGRESSIVA. C. ‘LUCIFER’ SI DISTINGUE PER LE BELLE FOGLIE AGUZZE E IL ROSSO PROFONDO E VELLUTATO DEI SUOI FIORI, CHE PRODUCE CONTINUAMENTE NEL CORSO DELL’ESTATE.",
                   Coltivazione = "Adatta alle zone a clima dolce, si coltiva in pieno sole, in terreno ben drenato; accetta anche suoli leggeri e sabbiosi, mentre non tollera quelli pesanti che fanno marcire i cormi (da migliorare aggiungendo ghiaietto). L’effetto migliore si ottiene piantandone in quantità, creando macchie di colore, meglio se circolari e ampie almeno 50 centimetri. I cormi si interrano a una profondità di 10 cm e a una distanza di 10-15 centimetri.",
                   Malattie = "",
                },

                 new Bulbose
                {
                   NomeComunePianta = "DALIA",
                   NomeFamiglia = "Iridacee",
                   NomeScientificoPianta = "Dahlia",
                   FotoPianta = "ms-appx:///Immagini/Bulbose/Dalia/DALIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Bulbose/Abete-*.jpg",

                   DescrizioneBotanica = "LE SUE COROLLE (IN FIORE TRA LUGLIO E OTTOBRE) SONO SPLENDIDE E VIVACI, MULTICOLORI E MULTIFORMI: ESISTONO MIGLIAIA DI IBRIDI DI DALIA, A FIORE SEMPLICE, A FIORE D’ORCHIDEA, D’ANEMONE, DI PEONIA, A PALLA, A COLLARETTO, A POMPON, A CACTUS E SEMICACTUS, SIA GRANDI SIA MIGNON; LE TINTE, SGARGIANTI, ATTRAVERSANO TUTTA LA GAMMA DEI COLORI, TALVOLTA MESCOLANDONE DUE NELLO STESSO FIORE. I FUSTI POSSONO ESSERE ALTI FINO A 1,5 METRI. LE FOGLIE SONO OPPOSTE E PENNATE.",
                   Coltivazione = "Le dalie prosperano al sole, in terreno ben drenato, sabbioso-argilloso, ricco di sostanza organica. I tuberi si piantano tra marzo e maggio, a una profondità di 10-15 cm. Dopo l’emissione dei germogli, va aggiunto una volta al mese del fertilizzante liquido, fino a settembre. Le piante alte richiedono un tutore, da piantare contemporaneamente al tubero e a cui verranno legati i fusti. Le dalie nane sono adatte ai vasi. ",
                   Malattie = "",
                },

                 new Bulbose
                {
                   NomeComunePianta = "ERANTHIS",
                   NomeFamiglia = "Ranuncolacee",
                   NomeScientificoPianta = "Eranthis hyemalis",
                   FotoPianta = "ms-appx:///Immagini/Bulbose/Erantis/ERANTIS.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Bulbose/Abete-*.jpg",

                   DescrizioneBotanica = "COME DICE IL NOME STESSO (HIEMS = INVERNO, IN LATINO) SFIDA IL GELO DI FEBBRAIO PER FORMARE UN TAPPETO DENSO DI FIORELLINI CHE ILLUMINA IL GIARDINO ANCORA SPOGLIO. NOTO ANCHE COME ACONITO INVERNALE, PRODUCE FIORI SOLITARI LARGHI 2-4 CM, DI UN BEL GIALLO VIVIDO, INCORNICIATI DALLE FOGLIE CHE FORMANO UN DECORATIVO COLLETTO INTORNO ALLA COROLLA. L’EFFETTO MIGLIORE SI OTTIENE PIANTANDO GLI ERNATHIS SECONDO UNO SCHEMA INFORMALE E LIBERO, COME IN NATURA.",
                   Coltivazione = "Spontaneo nei boschi, ama condizioni analoghe, come avviene ai piedi di alberi e arbusti caducifoglie, che assicurino sole in inverno e ombra nella bella stagione, quando le chiome schermano la luce. Ama i terreni ricchi di materia organica, che conservano l’umidità nella stagione calda. Le radici tuberose si interrano a inizio autunno a 5 cm di profondità. Si diffonde spontaneamente tramite i semi, formando belle colonie.",
                   Malattie = "",
                },

                 new Bulbose
                {
                   NomeComunePianta = "EREMURUS",
                   NomeFamiglia = "Liliacee",
                   NomeScientificoPianta = "Eremurus stenophyllus",
                   FotoPianta = "ms-appx:///Immagini/Bulbose/Eremurus/EREMURUS.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Bulbose/Abete-*.jpg",

                   DescrizioneBotanica = "SPETTACOLARE E APPARISCENTE, QUESTA PIANTA PUÒ RAGGIUNGERE I 3 M D’ALTEZZA E ADORNA IL GIARDINO CON LE SUE PANNOCCHIE FITTE DI FIORELLINI GIALLI, BIANCHI, ROSA, ARANCIO O ROSSI, CHE SI APRONO PROGRESSIVAMENTE DONANDO ALLA PIANTA UN ASPETTO CURIOSO E ASSICURANDO UNA FIORITURA DURATURA PER TUTTA L’ESTATE, A PARTIRE DA METÀ GIUGNO E FINO AD AGOSTO. LE FOGLIE SONO NUMEROSE, STRETTE, LUNGHE 30-40 CM, COLOR VERDE SALVIA. È MOLTO APPREZZATO PER I FIORI RECISI.",
                   Coltivazione = "La radice tuberosa, formata da grosse radici carnose, si interra in autunno a 10 cm di profondità e mantenendo la distanza tra gli esemplari di almeno 30 centimetri. Allo stato spontaneo, dalla Turchia alla Cina e ai piedi dell’Himalaya, cresce sui rilievi pietrosi e nei suoli pesanti dei pascoli; necessita di un terreno sabbioso, ben drenato, con una buona percentuale di sostanza organica. Ama il pieno sole, ma cresce bene anche in ombra parziale.",
                   Malattie = "",
                },

                 new Bulbose
                {
                   NomeComunePianta = "EUCOMIS",
                   NomeFamiglia = "Liliacee",
                   NomeScientificoPianta = "Eucomis",
                   FotoPianta = "ms-appx:///Immagini/Bulbose/Eucomis/EUCOMIS.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Bulbose/Abete-*.jpg",

                   DescrizioneBotanica = "ORIGINARIO DEL SUDAFRICA, L’EUCOMIS È OGGI COLTIVATO ANCHE IN EUROPA E APPREZZATO PER IL SUO ASPETTO ESOTICO. DALLA BASE SI DIPARTE UNA ROSETTA VISTOSA E AMPIA DI POCHE GRANDI FOGLIE, AL CENTRO DELLA QUALE SI INNALZA, DA LUGLIO A SETTEMBRE, LA SPIGA FIORALE, COMPOSTA DA PICCOLISSIMI FIORELLINI STELLATI (2-3 CM DI DIAMETRO), SORMONTATI DA UN CARATTERISTICO CIUFFETTO DI FOGLIOLINE. LE SPECIE SONO BIANCO-VERDE O GIALLE, MA ESISTONO VARIETÀ CON FIORI BIANCHI O ROSATI.",
                   Coltivazione = "L’eucomis si coltiva all’aperto in zona a clima mite, in posizioni riparate, al sole perché non ama l’ombra o la mezz’ombra. Nelle zone con inverni freddi è opportuno proteggere il terreno con un fitto strato di pacciamatura. I bulbi vanno piantati a 15 cm di profondità e a distanza di 20-25 cm l’uno dall’altro, in terreni sabbiosi e fertili, ben drenati. Possono essere coltivati in contenitore, rinvasando ogni 2-3 anni in autunno.",
                   Malattie = "",
                },

                 new Bulbose
                {
                   NomeComunePianta = "FRESIA ",
                   NomeFamiglia = "Iridacee",
                   NomeScientificoPianta = "Freesia",
                   FotoPianta = "ms-appx:///Immagini/Bulbose/Fresia/FRESIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Bulbose/Abete-*.jpg",

                   DescrizioneBotanica = "ACCANTO ALLE VARIETÀ PRIMAVERILI ESISTONO ORA (E SONO PIÙ DIFFUSI) DIVERSI IBRIDI ESTIVI, E ACCANTO ALLE TRADIZIONALI FRESIE A FIORE SINGOLO (F. ‘SINGLE’)ESISTONO ANCHE SPLENDIDE VARIETÀ A FIORE DOPPIO (F. ‘DOUBLE’). CRESCONO DA BULBO-TUBERO, PRODUCONO FUSTI SOTTILI ALTI DA 30 A 45 CM, CHE PORTANO FRA GIUGNO E SETTEMBRE I GRAZIOSI FIORI A TROMBETTA, PROFUMATISSIMI E DI VARI COLORI BRILLANTI: GIALLO, ARANCIO, ROSA, ROSSO, AZZURRO, VIOLA, BIANCO.",
                   Coltivazione = "Temono il gelo e si possono coltivare all’aperto nelle regioni a clima temperato, in posizione calda, riparata e soleggiata; altrimenti è preferibile la coltivazione in vaso, da riparare in inverno. I bulbo-tuberi si interrano a una profondità di 7-8 cm, con una distanza di circa 10 cm tra loro, in terreno fertile e leggero. Gli ibridi estivi fioriscono tra giugno e settembre, e vanno annaffiati abbondantemente in estate.",
                   Malattie = "",
                },

                 new Bulbose
                {
                   NomeComunePianta = "FRITILLARIA",
                   NomeFamiglia = "Liliacee",
                   NomeScientificoPianta = "Fritillaria",
                   FotoPianta = "ms-appx:///Immagini/Bulbose/Fritillaria/FRITILLARIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Bulbose/Abete-*.jpg",

                   DescrizioneBotanica = "PROVENIENTE DALLA PERSIA E DAL KASHMIR, FRITILLARIA IMPERIALIS HA STELI ALTI 1 M E INFIORESCENZE PARTICOLARI MOLTO APPARISCENTI, COMPOSTE DA UNA CORONA DI CAMPANELLE RECLINATE GIALLE (‘MAXIMA LUTEA’), ARANCIO O ROSSE (‘RUBRA MAXIMA’), SORMONTATE DA UN CIUFFO DI FOGLIE VERDI RIVOLTE ALL’INSÙ. F. MELEAGRIS, DI TAGLIA BASSA (20-25 CM), MOSTRA FIORI MOLTO CURIOSI: PICCOLE CAMPANULE DI DIVERSI COLORI; A PETALI QUDRETTATI OPPURE BRUNI O BIANCHI VENATI DI VERDE.",
                   Coltivazione = "La fritillaria teme il gelo, richiede un clima temperato e una collocazione in mezz’ombra. Il bulbo di F. imperialis si interra in terreno fertile e ben drenato, a una profondità di 20 cm, avvolto in un pugno di sabbia e leggermente inclinato (per evitare ristagni idrici sul bulbo). Piantati in masse fitte (10 elementi) sul fondo del prato o del giardino, o a ridosso di un muro di cinta, creano belle macchie cromatiche.",
                   Malattie = "",
                },

                new Bulbose
                {
                   NomeComunePianta = "GIACINTO",
                   NomeFamiglia = "Liliacee",
                   NomeScientificoPianta = "Hyacinthus orientalis",
                   FotoPianta = "ms-appx:///Immagini/Bulbose/Giacinto/GIACINTO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Bulbose/Abete-*.jpg",

                   DescrizioneBotanica = "IL SUO PROFUMO È INTENSO E INCONFONDIBILE. IL GIACINTO FIORISCE NEI PRIMI GIORNI DI PRIMAVERA SFOGGIANDO I SUOI CARATTERISTICI FIORI, SEMPLICI O DOPPI, SUI TONI CHE VANNO DAL BIANCO AL ROSA AL BLU, PASSANDO PER LE SFUMATURE DEL GIALLO, ARANCIO E VIOLA. TUTTE LE VARIETÀ DI GIACINTO SONO ALTE CIRCA 25 CM, DI CUI 15 SONO OCCUPATI DALLE INFIORESCENZE: DENSE SPIGHE DI GRAZIOSI FIORELLINI (2-3 CM) IMBUTIFORMI. IL GIACINTO È ADATTO ALLA FORZATURA IN CASA PER L’INVERNO.",
                   Coltivazione = "Facilissima, robusta, poco esigente: ecco una bulbosa ideale anche per i principianti. I bulbi si interrano a 10 cm di profondità direttamente in giardino (dove possono rimanere indisturbati per anni, moltiplicandosi spontaneamente) o nei vasi del balcone, tra ottobre e novembre, in terreno ben drenato, al sole o alla mezz’ombra. Nelle aiuole e bordure, meglio piantarli in gruppi di almeno 5 per un buon impatto. ",
                   Malattie = "",
                },

                new Bulbose
                {
                   NomeComunePianta = "GLADIOLO",
                   NomeFamiglia = "Iridacee",
                   NomeScientificoPianta = "Gladiolus",
                   FotoPianta = "ms-appx:///Immagini/Bulbose/Gladiolo/GLADIOLO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Bulbose/Abete-*.jpg",

                   DescrizioneBotanica = "LE SUE LUNGHE SPIGHE DENSE DI GRANDI FIORI COLORATI SONO UN VERO SPETTACOLO NEL CUORE DELL’ESTATE. AL GLADIOLO VA RISERVATO UN POSTO DI RILIEVO IN GIARDINO, DOVE PIANTARLO IN GRUPPI PER IL MASSIMO EFFETTO. LE NUMEROSE VARIETÀ OFFRONO UN VENTAGLIO AMPIO E SGARGIANTE DI COLORI (ECCETTO IL BLU), INCLUSE STRIATURE, SFUMATURE E MACCHIE A CONTRASTO SUI PETALI. OLTRE AI FIORI (OTTIMI ANCHE RECISI) ANCHE LE LUNGHE FOGLIE A SPADA HANNO UN RUOLO DECORATIVO.",
                   Coltivazione = "I cormi si piantano in primavera o a inizio estate in posizioni soleggiate, aperte, in terreno fertile e ben drenato, neutro o leggermente acido. Si interrano a 10-15 cm di profondità e a 10-20 cm di distanza tra loro, in gruppi di almeno 6, come sfondo di un’aiuola o una bordura o in un punto vuoto tra piante più basse. Temono il gelo, quindi vanno dissotterrati in autunno e riparati. In vaso occorre garantire un ottimo drenaggio.",
                   Malattie = "",
                },

                 new Bulbose
                {
                   NomeComunePianta = "GLORIOSA",
                   NomeFamiglia = "Liliacee",
                   NomeScientificoPianta = "Gloriosa",
                   FotoPianta = "ms-appx:///Immagini/Bulbose/Gloriosa/GLORIOSA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Bulbose/Abete-*.jpg",

                   DescrizioneBotanica = "MERAVIGLIOSA CREATURA D’ASPETTO ESOTICO E CURIOSO, LA GLORIOSA È UNA DELLE POCHISSIME BULBOSE CON PORTAMENTO RAMPICANTE: AIUTATA DA UN SOSTEGNO, SI ARRAMPICA PER UN PAIO DI METRI E REGALA IN ESTATE FIORI APPARISCENTI, LARGHI FINO A 10 CM, CON LUNGHI TEPALI ONDULATI E INCURVATI, SLANCIATI VERSO L’ALTO, TRA IL FUCSIA E LO SCARLATTO, ORLATI DI GIALLO. LE PIÙ BELLE E DIFFUSE SONO G. SUPERBA (TEPALI ARANCIO INCRESPATI) E G. ROTHSCHILDIANA (GIALLA E CREMISI).",
                   Coltivazione = "Originaria dell’Africa tropicale, la gloriosa fiorisce tra giugno e agosto. È una pianta delicata, che si può coltivare all’aperto nelle zone a clima mite, in pieno sole e in posizione riparata dal vento. I grossi tuberi si interrano in primavera in vaso, in serra, a 16-18 °C, in un miscuglio di terra, sabbia e torba, oppure in piena terra a giugno. Chiede innaffiature regolari e concimazioni quindicinali. I sottili fusti necessitano di sostegni.",
                   Malattie = "",
                },

                 new Bulbose
                {
                   NomeComunePianta = "IRIS",
                   NomeFamiglia = "Iridacee",
                   NomeScientificoPianta = "Iris",
                   FotoPianta = "ms-appx:///Immagini/Bulbose/Iris/IRIS.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Bulbose/Abete-*.jpg",

                   DescrizioneBotanica = "ESISTONO CIRCA 300 SPECIE DI IRIS, TRA RIZOMATOSE E BULBOSE. QUESTE ULTIME SONO CARATTERIZZATE DA UNA FORMA PARTICOLARE DEI FIORI, CON SEI SEGMENTI SALDATI ALLA BASE, DI CUI TRE ESTERNI E RICURVI E TRE INTERNI ED ERETTI, E PRESENTANO COLORI VARIABILI DAL BIANCO, AL GIALLO, AL BLU E VIOLA. I PIÙ COLTIVATI SONO GLI IBRIDI OLANDESI (I. HOLLANDICA), A FIORITURA PRIMAVERILE, PRINCIPALMENTE SUI TONI DEL BLU, ALTI CIRCA 60 CM, OTTIMI ANCHE DA RECIDERE.",
                   Coltivazione = "I bulbi si piantano in giardino in bordure e aiuole, ma anche in vaso, a circa 10 cm di profondità e altrettanti di distanza l’uno dall’altro, per ottenere una macchia di colore compatta, di grande impatto soprattutto scegliendo un’unica varietà. Sono adatti a posizioni luminose, in terreni sabbiosi, lavorati, ricchi di sostanza organica e ben drenati. Rustici e facili, i bulbi si possono lasciare indisturbati nel suolo, dove fioriranno anno dopo anno.",
                   Malattie = "",
                },

                 new Bulbose
                {
                   NomeComunePianta = "LILIUM",
                   NomeFamiglia = "Liliacee",
                   NomeScientificoPianta = "Lilium",
                   FotoPianta = "ms-appx:///Immagini/Bulbose/Lilium/LILIUM.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Bulbose/Abete-*.jpg",

                   DescrizioneBotanica = "RE DEI BULBI ESTIVI, AMATO IN TUTTO IL MONDO PER LA SUA BELLEZZA FOLGORANTE, IL PROFUMO INEBRIANTE, LA GENEROSITÀ DELLA FIORITURA, IL GIGLIO ARRICCHISCE DI COLORE MACCHIE DI ARBUSTI, MARGINI DEI PRATI, BORDURE DI ERBACEE, GRANDI VASI SUL TERRAZZO. I NUMEROSISSIMI IBRIDI OFFRONO SPLENDIDI FIORI SOLITARI O RACCOLTI IN RACEMI, TUTTI CON 6 TEPALI, IN UNA GAMMA INESAURIBILE DI COLORI (ECCETO IL BLU), PURI O DECLINATI IN SFUMATURE E MACULATURE.",
                   Coltivazione = "Facile da coltivare, il giglio cresce bene sia al sole che alla mezz’ombra, in terreno ben drenato, anche un po’ acido. I bulbi si interrano in autunno, a 15 cm di profondità, distanziandoli di 30 cm, a gruppi dispari (3 o 5). Meglio dare loro una posizione riparata perché i venti potrebbero spezzarne i fusti. Lilium regale (alto fino a 2 m) è tra i più spettacolari, facili, affdabili e profumati; inoltre tollera anche i suoli un po’ calcarei.",
                   Malattie = "",
                },

                 new Bulbose
                {
                   NomeComunePianta = "MUGHETTO",
                   NomeFamiglia = "Liliacee",
                   NomeScientificoPianta = "Convallaria majalis",
                   FotoPianta = "ms-appx:///Immagini/Bulbose/Mughetto/Mughetto.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Bulbose/Abete-*.jpg",

                   DescrizioneBotanica = "SPONTANEO NEI SOTTOBOSCHI DEL NORDAMERICA E DI GRAN PARTE D’EUROPA, IL MUGHETTO È AMATO PER IL SUO PROFUMO DOLCISSIMO ED È ASSOCIATO AL MESE DI MAGGIO (DA CUI L’AGGETTIVO MAJALIS, RIFERITO A TALE MESE). OTTIMO TAPPEZZANTE PER LE ZONE OMBREGGIATE, RAPPRESENTA IL FIORELLINO IDEALE PER DECORARE I TAPPETI ERBOSI IN POSIZIONE FRESCA. GLI STELI PORTANO GRAPPOLI DI 6-12 FIORELLINI CAMPANULATI, CEROSI, PENDULI, GENERALMENTE BIANCHI MA ANCHE ROSA (C. M. ROSEA).",
                   Coltivazione = "Prosperano in terreni sempre freschi e umidi (ma senza ristagni), ricchi di humus, parzialmente o del tutto ombreggiati, per esempio alla base di alberi o arbusti. I rizomi si piantano a fine autunno, ravvicinati, appena sotto la superficie del suolo, che va coperto con una pacciamatura. Ideali per i principianti, i mughetti sono facili, del tutto rustici, resistenti al gelo e si prestano benissimo anche alla coltivazione in vaso.",
                   Malattie = "",
                },

                 new Bulbose
                {
                   NomeComunePianta = "MUSCARI",
                   NomeFamiglia = "Liliacee",
                   NomeScientificoPianta = "Muscari",
                   FotoPianta = "ms-appx:///Immagini/Bulbose/Muscari/MUSCARI.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Bulbose/Abete-*.jpg",

                   DescrizioneBotanica = "INAUGURA LA PRIMAVERA CON I SUOI INCANTEVOLI FIORELLINI SUI TONI DELL’AZZURRO E DEL BLU, NUMEROSI, BRILLANTI E DELICATAMENTE PROFUMATI. LE PIANTINE, ALTE DA 10 A 30 CM, FORMANO UN BELLISSIMO COLPO D’OCCHIO NEL PRIMO PIANO DELLE AIUOLE E NEI VASI. FIORISCONO IN APRILE E ATTIRANO LE API. M. ARMENIACUM È IL PIÙ FACILE, HA FIORI AZZURRO INTENSO ED È PERFETTO PER ROCCAGLIE, PRATI E ALLA BASE DELGI ARBUSTI. M. BOTRYOIDES ‘ALBUM’ HA FIORI BIANCHI E PROFUMATI.",
                   Coltivazione = "Sono tra le bulbose più facili da coltivare: rustiche e inesigenti, non temono il gelo e possono essere praticamente dimenticate nel terreno o nel vaso. I muscari preferiscono terreni ben drenati e prediligono le posizioni soleggiate, ma accettano anche la mezz’ombra, dove tuttavia la fioritura sarà meno generosa. Si interrano a gruppi, in ottobre, a 7-10 cm di profondità, distanziati di circa 10 cm tra loro anche più fitti se coltivati in vaso.",
                   Malattie = "",
                },

                 new Bulbose
                {
                   NomeComunePianta = "ORNITOGALO",
                   NomeFamiglia = "Liliacee",
                   NomeScientificoPianta = "Ornithogalum",
                   FotoPianta = "ms-appx:///Immagini/Bulbose/Ornitogalo/ORNITOGALO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Bulbose/Abete-*.jpg",

                   DescrizioneBotanica = "I FIORELLINI (2-3 CM) BIANCHI A FORMA DI STELLA SBOCCIANO IN GRAZIOSI GRAPPOLI A PARTIRE DALLA FINE DI MARZO. GLI ORNITOGALI SONO ELEGANTI, RUSTICI E PERFETTI DA NATURALIZZARE NELLE ROCCAGLIE, NEI TAPPETI ERBOSI, NELLE AIUOLE, DOVE FORMANO NEL TEMPO COLONIE VIVACI E DENSE. O. NUTANS HA FIORI SFUMATI DI ARGENTO E VENATI DI VERDE; O. UMBELLATUM HA BEI FIORI CANDIDI RIVOLTI VERSO L’ALTO; O. THYRSOIDES È TRA I PIÙ ORNAMENTALI, MA È DELICATO E VA RIPARATO IN INVERNO.",
                   Coltivazione = "I bulbi vanno collocati in posizione luminosa o in ombra leggera; si adattano ai più comuni terreni da giardino, meglio se mediamente ricchi di sostanza organica, assolutamente ben drenati. Si interrano in autunno, in numero dispari (3 o 5), a 10 cm di profondità e distanziati l’uno dall’altro di 5-7 centimetri. Ottimi come tappezzanti alla base di alberi e arbusti, sono molto rustici, resistenti e facili da inselvatichire.",
                   Malattie = "",
                },

                 new Bulbose
                {
                   NomeComunePianta = "SCILLA",
                   NomeFamiglia = "Liliacee",
                   NomeScientificoPianta = "Scilla",
                   FotoPianta = "ms-appx:///Immagini/Bulbose/Scilla/SCILLA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Bulbose/Abete-*.jpg",

                   DescrizioneBotanica = "PIANTA MINUTA (10-15 CM D’ALTEZZA), SE LE SI PERMETTE DI RIMANERE NEL TERRENO SI NATURALIZZA FACILMENTE FORMANDO NEGLI ANNI VERI E PROPRI TAPPETI FIORITI: A INIZIO PRIMAVERA, I FIORELLINI AZZURRI O BIANCHI CREANO UN RICAMO DENSO E SPETTACOLARE. S. SIBERICA, LA SPECIE PIÙ DIFFUSA, HA FIORELLINI PENDULI CAMPANULATI AZZURRI O BIANCHI; S. MISCHTSCHENKOANA PRODUCE RACEMI CON POCHI FIORI A CAMPANA LARGA BIANCO CELESTE VENATI DI AZZURRO.",
                   Coltivazione = "Per ottenere il massimo risultato, basta piantarne in quantità, nel prato, nella roccaglia, sotto un albero, ai piedi di un arbusto. Sono bulbose molto rustiche che tollerano benissimo il gelo. Si interrano in autunno, a una profondità di 5-10 cm, anche molto ravvicinate (5 cm), senza seguire uno schema ordinato, in terreni preferibilmente freschi e ricchi di humus, ben drenati. Sono perfette anche per la coltivazione in vaso.",
                   Malattie = "",
                },

                 new Bulbose
                {
                   NomeComunePianta = "TULBAGHIA",
                   NomeFamiglia = "Armarillidacee",
                   NomeScientificoPianta = "Tulbaghia",
                   FotoPianta = "ms-appx:///Immagini/Bulbose/Tulbaghia/TULBAGHIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Bulbose/Abete-*.jpg",

                   DescrizioneBotanica = "DA AGOSTO FINO AL CUORE DELL’AUTUNNO, IN OTTOBRE INOLTRATO, PRODUCE, SU STELI ALTI E SOTTILI (ANCHE 50 CM), GRAZIOSE OMBRELLE COMPOSTE DA FIORI A FORMA DI STELLA, DAL DELICATO PROFUMO, BIANCO-ARANCIATI OPPURE ROSATI-LAVANDA. HA FOGLIE STRETTE E ALLUNGATE (40 CM CIRCA), VERDE-GRIGIASTRE, CHE FORMANO DEI CIUFFI DENSI E FOLTI DECORATIVI ANCHE QUANDO NON SONO FIORITI. LA SPECIE PIÙ DIFFUSA È T. VIOLACEA (SIN. T. FRAGRANS O T. PULCHELLA).",
                   Coltivazione = "Originaria dell’Africa, è una pianta delicata che teme il gelo e resiste bene alla siccità. Adatta al giardino solo in clima mite, dà grande soddisfazione se coltivata in vaso, anche in appartamento. I bulbo-tuberi devono essere interrati a una profondità di circa 8 cm, mantenendo una distanza di circa 10 cm tra loro, in terreno leggero, sabbioso e dotato di un ottimo drenaggio, in posizione soleggiata e riparata dai venti.",
                   Malattie = "",
                },

                 new Bulbose
                {
                   NomeComunePianta = "TULIPANO",
                   NomeFamiglia = "Liliacee",
                   NomeScientificoPianta = "Tulipa",
                   FotoPianta = "ms-appx:///Immagini/Bulbose/Tulipano/TULIPANO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/Bulbose/Abete-*.jpg",

                   DescrizioneBotanica = "DA QUANDO ARRIVARONO DALL’ORIENTE NEL SEICENTO, I TULIPANI HANNO CONQUISTATO L’EUROPA FINO A DIVENTARE LE BULBOSE PIÙ AMATE E DIFFUSE. DA ALLORA SONO STATE SELZIONATE MIGLIAIA DI VARIETÀ E IBRIDI. MOLTO APPREZZATI SONO QUELLI A FIORE DI PEONIA (BIANCHI O ROSA), A FIORE DI GIGLIO (PETALI APPUNTITI), I PAPPAGALLO (PETALI SFRANGIATI) E I REMBRANDT (FIORI STRIATI E MACCHIATI). MOLTO RICERCATI I TULIPANI NERI (‘NEGRITA’, ‘ABSALON’, ‘BLACK PARROT’, ‘HAVRAN’, ‘QUEEN OF THE NIGHT’) E VERDI (‘ARTIST’, ‘DANCING SHOW’, ‘FLOROSA’) E QUELLI BOTANICI (TULIPA KAUFMANNIANA, T. GREIGII). ",
                   Coltivazione = "Nella maggior parte delle varietà i bulbi vanno interrati tra ottobre e novembre, a circa 15 cm di profondità e a 10 cm di distanza, in terreno leggero, preferibilmente alcalino, ben drenato (sono molto sensibili ai ristagni idrici), in gruppi o file, in posizioni soleggiate, anche alla base di alberi caducifoglie.",
                   Malattie = "",
                },



            };

            return data;
        }

        // TODO WTS: Remove this once your MasterDetail pages are displaying real data
        public static async Task<IEnumerable<Bulbose>> GetSampleModelDataAsync()
        {
            await Task.CompletedTask;

            return AllBulbose();
        }

        
    }
}
