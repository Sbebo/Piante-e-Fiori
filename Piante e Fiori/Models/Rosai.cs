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
//26 ROSE
//MANCA LA FOTO PRINCIPALE. SI PUO' ELIMINARE LA GALLERY
    public class Rosai
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
//NomeCounePianta è in relatà il nome scientifico
//NomeScientifico è in realà il gruppo es: ibride perpetue

    }

    public static class RosaiDataService
    {
        private static IEnumerable<Rosai> AllRosai()
        {
            // The following is order summary data
            var data = new ObservableCollection<Rosai>
            {
               
                new Rosai
                {
                   NomeComunePianta = "BARON GIROD DE L'AIN",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Ibride Perpetue",
                   FotoPianta = "ms-appx:///Immagini/ROSAI/BARON GIROD DE LAIN.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ROSAI/Abete-*.jpg",

                   DescrizioneBotanica = "APPARTIENE AL GRUPPO DELLE IBRIDE PERPETUE, ROSE COMPARSE A PARTIRE DAL 1830, MA QUASI TUTTE DATATE NELLA SECONDA METÀ DELL’800: ‘BARON GIROD DE L’AIN’ È STATA CREATA DA REVERCHON, IN FRANCIA, NEL 1897. È UN ARBUSTO DENSO, DELLE DIMENSIONI DI 1,2 M DI ALTEZZA E CIRCA 0,9 M DI LARGHEZZA, CON SPINE RIGIDE E FORTI E FOGLIE CORIACEE VERDE SCURO. RIFIORENTE, PRODUCE FIORI DOPPI CREMISI, A FORMA DI COPPA, CON I PETALI DI ASPETTO SMARGINATO E ORLATI DA UNA LINEA BIANCA.",
                   Coltivazione = "Si utilizza per creare bordure di media altezza, ma anche per la coltivazione in vaso (dimensioni minime 50 cm di lato e profondità). È una varietà che colpisce per il particolare, brillante colore dei fiori e per la leggera sfrangiatura dei petali. Il portamento è un po’ disordinato, ma i fiori sono molto profumati e si prestano a essere impiegati anche recisi. Spesso veniva piantata in testa ai filari di viti per segnalare l’attacco di oidio.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rosai
                {
                   NomeComunePianta = "BONICA 82",
                   NomeFamiglia = "Rose Paesaggistiche",
                   NomeScientificoPianta = "Rosacee",
                   FotoPianta = "ms-appx:///Immagini/ROSAI/BONICA 82.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ROSAI/Abete-*.jpg",

                   DescrizioneBotanica = "NATA NEL 1985, È ANCORA UNA DELLE ROSE MODERNE PIÙ VENDUTE IN EUROPA, GRAZIE ALLA DELICATEZZA DEL COLORE DEI SUOI FIORI UNITA ALLA RUSTICITÀ DELLA PIANTA, ROBUSTO CESPUGLIO CHE SOPPORTA TEMPERATURE ANCHE DI -30 °C. DOPO LA PRIMA FIORITURA, PER STIMOLARE LA SUCCESSIVA, È OPPORTUNO TAGLIARE I FIORI APPASSITI PRIMA CHE SI FORMINO LE BACCHE E CONCIMARE CON AZOTO, MANTENENDO SEMPRE UN’ADEGUATA IRRIGAZIONE. È PRATICAMENTE ESENTE DA MALATTIE.",
                   Coltivazione = "Rosa paesaggistica ideale per formare siepi e aiuole di media altezza. Fiorisce abbondantemente a primavera in corimbi di 5-15 fiori, non profumati, color rosa chiaro, del diametro di 6 cm ciascuno, protraendo la fioritura fino a dicembre. I fiori si possono utilizzare anche come reciso. Il portamento è a cespuglio, e raggiunge al massimo 1,5 m. Si pota una sola volta l’anno, passata la stagione fredda, a fine inverno.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rosai
                {
                   NomeComunePianta = "CÉCILE BRUNNER",
                   NomeFamiglia = "Noisette Cinesi",
                   NomeScientificoPianta = "Rosacee",
                   FotoPianta = "ms-appx:///Immagini/ROSAI/CECILE BRUNNER.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ROSAI/Abete-*.jpg",

                   DescrizioneBotanica = "APPARTENENTE AL GRUPPO DELLE CHINENSIS, È STATA CREATA NEL 1894 E VIENE CHIAMATA ANCHE SWEETHEART O ROSA DEGLI INNAMORATI. I FIORI, DELLA GRANDEZZA DI UN DITALE, SONO COLOR ROSA PORCELLANA, PORTATI IN MAZZI DI 15-20 E PIÙ COROLLE, TUTTE PROFUMATISSIME (EVOCANTI LE SPEZIE E IL MUSCHIO CON UNA NOTA AGRUMATA). ALLA FINE DELL‘800 E ALL’INIZIO DEL 900, DIVENNE IL FIORE PREFERITO DAGLI UOMINI DI CLASSE, DA PORTARE ALL’OCCHIELLO. RIFIORISCE IN SETTEMBRE.",
                   Coltivazione = "È sarmentosa, vigorosa, a crescita rapida, con lunghi tralci di colore rossiccio che si protendono facilmente verso l’alto (fino a 8 m di lunghezza/altezza): può essere utilizzata per coprire muri, recinzioni, pali, colonne ecc., mentre avvolta intorno ad alberi produce un effetto molto romantico. Resiste anche a mezz’ombra, dove fiorisce ugualmente bene, mentre un sole troppo intenso può bruciare i boccioli delicati.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rosai
                {
                   NomeComunePianta = "CHAPEAU DE NAPOLÉON",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Centifolia",
                   FotoPianta = "ms-appx:///Immagini/ROSAI/CHAPEAU DE NAPOLEON.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ROSAI/Abete-*.jpg",

                   DescrizioneBotanica = "APPARTENENTE AL GRUPPO DELLE ROSE CENTIFOLIA, È DI ORIGINI SCONOSCIUTE; FU RINVENUTA IN UN MURO DIROCCATO A FRIBURGO NEL 1820. I RAMETTI FIORALI SI RIEMPIONO DI BOCCIOLI CON CARATTERISTICHE FRANGE CHE CONFERISCONO LORO L’ASPETTO DI UNA FELUCA, DA CUI IL NOME. I FIORI SONO RICCHISSIMI DI PETALI (OLTRE 100), DI COLOR ROSA CARICO ARGENTATO, A FORMA DI COPPA PROFONDA (MA DIVENTANO PIATTI A SCHIUSURA COMPLETA), PROFUMATISSIMI; LA VARIETÀ NON È RIFIORENTE.",
                   Coltivazione = "Il rosaio giovane ha un portamento ricurvo e lasso, i rami tendono a piegarsi verso il terreno quando la fioritura è al massimo, a causa del peso dei fiori. A maturità, i rami diventano molto alti e il portamento diviene più scompigliato. Tutto l’arbusto è dotato di numerose spine; i rametti, e soprattutto i peduncoli, sono del tutto ricoperti da una fitta trama di piccole spine. I grossi cinorrodi sono di color rosso scuro.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rosai
                {
                   NomeComunePianta = "DOROTHY PERKINS",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Rambler",
                   FotoPianta = "ms-appx:///Immagini/ROSAI/DOROTHY PERKINS.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ROSAI/Abete-*.jpg",

                   DescrizioneBotanica = "FA PARTE DEL GRUPPO DELLE SARMENTOSE WICHURAIANA: LA WICHURAIANA È UNA ROSA BOTANICA SCOPERTA IN CINA ATTORNO AL 1860, CHE IN NATURA SI TROVA SOTTO FORMA PROSTRATA O RAMPICANTE. UNA VOLTA GIUNTA IN EUROPA E NEGLI STATI UNITI, È STATA UTILIZZATA DAGLI IBRIDATORI PER DARE VITA A UNA SERIE DI VARIETÀ ECCEZIONALI, FRA CUI ‘DOROTHY PERKINS’. LA FIORITURA, CHE GENERALMENTE SI VERIFICA IN GIUGNO, È CON CASCATE DI FIORI ROSA CHIARO, DOPPI.",
                   Coltivazione = "Creata negli Stati Uniti nel 1902, è una rosa molto famosa, caratterizzata dalla presenza di occasionali fiori bianchi fra i grappoli; i fiori hanno 15-25 petali, senza profumo. Non è rifiorente, lo è invece la sua forma migliorata ‘Super Dorothy’. Ha fogliame brillante, lucido e verde scuro. Alta fino a 3 m, si presta a coprire recinzioni, colonne e anche alberi morti, così come alla coltivazione in vaso. Non ama le zone fredde.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rosai
                {
                   NomeComunePianta = "GERTRUDE JEKYLL",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Rose inglesi",
                   FotoPianta = "ms-appx:///Immagini/ROSAI/GERTRUDE JEKYLL.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ROSAI/Abete-*.jpg",

                   DescrizioneBotanica = "CREATA DA DAVID AUSTIN NEL 1986 È UNA ROSA INGLESE VIGOROSA E DALLA CRESCITA ERETTA DI QUEST’ULTIMA. I FIORI SONO DAPPRIMA PICCOLI CON PETALI BEN AVVOLTI A SPIRALE, CHE POI SI APRONO IN SORPRENDENTI, GRANDI COROLLE IN FORMA DI ARMONIOSA ROSETTA, DI COLORE ROSA INTENSO E DAL PROFUMO ARMONIOSO E BEN EQUILIBRATO, DI ROSA ANTICA. L’ARBUSTO, ALTO E GAGLIARDO (FINO A 1,5 M), È ADATTO A ESSERE COLLOCATO NELL’ULTIMA FILA DI UNA BORDURA.",
                   Coltivazione = "Dedicata alla memoria della nota scrittrice inglese (1843-1932), la cui passione per il giardinaggio la portò a creare più di 400 giardini nel Regno Unito, in Europa e negli Stati Uniti. La varietà, nominata rosa preferita in Inghilterra nel 2006, è una delle migliori e più popolari rose di David Austin. Grazie all’intenso profumo, è stata selezionata per ottenere l’essenza di rosa, che in Gran Bretagna non si produceva da 250 anni.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rosai
                {
                   NomeComunePianta = "GLOIRE DE DIJOM",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Tea",
                   FotoPianta = "ms-appx:///Immagini/ROSAI/GLOIRE DE DIJOM.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ROSAI/Abete-*.jpg",

                   DescrizioneBotanica = "APPARTIENE ALLE TEA, ROSE LANGUIDE DAI BOCCIOLI APPUNTITI CHE NASCONO DA STELI ESILI, SOTTILI, SPESSO RECLINATI, UN GRUPPO POPOLARISSIMO NELLA SECONDA METÀ DELL’800. TRA LORO POCHE MA PREZIOSISSIME RAMPICANTI, FRA CUI ‘GLOIRE DE DIJON’. LA BREVE E INTENSA STAGIONE DEL LORO SUCCESSO HA COMINCIATO A VOLGERE AL TERMINE CON L’AVVENTO DELLE PIÙ ROBUSTE E VIVACI IBRIDE DI TEA. MA LE VARIETÀ CHE SONO RIMASTE NEL CUORE DEI GIARDINIERI SONO DI ASSOLUTO VALORE.",
                   Coltivazione = "Creata in Francia nel 1853, ha fiori globosi, appiattiti quando sono completamente aperti, divisi in quarti. Il colore varia dal giallo chiaro all’albicocca, con sfumature rosate. È molto rifiorente. Non ama i posti umidi e con poco sole, probabilmente non ha più il vigore di un tempo, anche se le dimensioni massime sono ragguardevoli (3,5 x 3,5 m). È una delle poche rose che tollera la posizione vicino ai muri a nord.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rosai
                {
                   NomeComunePianta = "HEIDETRAUM",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Paesaggistiche - Tapezzanti",
                   FotoPianta = "ms-appx:///Immagini/ROSAI/HEIDETRAUM.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ROSAI/Abete-*.jpg",

                   DescrizioneBotanica = "È UNA COPRISUOLO, INDICATA PER LA CREAZIONE DI MACCHIE COLORATE IN GIARDINO, ACCOMPAGNATE AD ALTRI ARBUSTI BASSI E COMPATTI, ED È ADATTA PER QUALSIASI TIPO DI AMBIENTE, URBANO E PRIVATO: BORDURE, AIUOLE, GIARDINI, GRANDI PARCHI E SCARPATE. SELEZIONATA NEL 1990, HA VINTO BEN 5 MEDAGLIE D’ORO INTERNAZIONALI. SUE CARATTERISTICHE PRINCIPALI SONO LA GRANDE RESISTENZA ALLE MALATTIE, ALL’INQUINAMENTO E L’ELEVATO GRADO DI RUSTICITÀ (-25 °C).",
                   Coltivazione = "Ha fiori semidoppi, di colore rosa carico quasi fucsia, portati in mazzetti molto densi; la fioritura è continua da maggio ai primi geli, per un’eccezionale rifiorenza. Il portamento del cespuglio è compatto, anche se non molto ingombrante (dimensioni massime 0,6 x 0,6 m). Il fogliame è semipersistente. Viene molto apprezzata soprattutto per le esigenze davvero ridotte al minimo in rapporto alla bella fioritura.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rosai
                {
                   NomeComunePianta = "ICEBERG",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Floribunda",
                   FotoPianta = "ms-appx:///Immagini/ROSAI/ICEBERG.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ROSAI/Abete-*.jpg",

                   DescrizioneBotanica = "È UNA FLORIBUNDA (VARIETÀ MODERNA), CREATA DA KORDES NEL 1958. RIFIORENTE, È IN PRODUZIONE DA MAGGIO A NOVEMBRE. IL FIORE È PORTATO SUI RAMI DELL’ANNO E LA MANUTENZIONE È ABBASTANZA SEMPLICE. QUESTE ROSE VENGONO ANCHE CHIAMATE ‘ROSE A GRAPPOLO’, PERCHÉ PORTANO PIÙ BOCCIOLI LUNGO IL MEDESIMO RAMO. SONO PERFETTE PER CREARE MACCHIE DI COLORE DI GRANDE EFFETTO E SE NE CONSIGLIA UN UTILIZZO A GRUPPI DI ALMENO 3-5 PIANTE DELLA STESSA VARIETÀ.",
                   Coltivazione = "Tra le floribunde è forse la rosa più diffusa. È un arbusto alto (dimensioni massime 1,5 x 0,9) con foglie piuttosto rade, verde chiaro e lucido. Se lasciata senza potature forma un arbusto di buone dimensioni. Ha boccioli piccoli, che si aprono in fiori semidoppi, bianco puro, prodotti in abbondanza per tutto l’arco dell’estate (la rifiorenza è ottima). Ne è stata ricavata anche la forma climbing (rampicante).",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rosai
                {
                   NomeComunePianta = "M.ME ISAAC PEREIRE",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Bourbon",
                   FotoPianta = "ms-appx:///Immagini/ROSAI/M.ME ISAAC PEREIRE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ROSAI/Abete-*.jpg",

                   DescrizioneBotanica = "ROSA SARMENTOSA TRA LE PIÙ APPREZZATE E AMATE GRAZIE ALLA BELLEZZA IMPAGABILE DEI SUOI FIORI, CHE SONO GRANDI, DI FORMA A ROSETTA E DOTATI DI UN PROFUMO INTENSO E DOLCE. L’INTENSITÀ DELLA FIORITURA PRIMAVERILE È ECCEZIONALE ED È SEGUITA, IN AUTUNNO, DA UNA SECONDA FIORITURA, MENO GENEROSA DELLA PRIMA. LA CRESCITA È MODERATAMENTE RAPIDA, HA PORTAMENTO FLESSUOSO E SI DIMOSTRA INDICATA PER COPRIRE PICCOLI ARCHI. LE FOGLIE SONO DI MEDIA DIMENSIONE.",
                   Coltivazione = "La pianta mostra una discreta vigoria anche se può soffrire per attacchi di macchia nera (ticchiolatura). Si presta a essere coltivata in vaso (grande, può raggiungere i 2 m d’altezza) e, grazie ai lunghi steli, i fiori si possono recidere per porli in vaso. Idonea anche per coprire pilastri, graticci o muretti. Ha un’ottima rusticità (resiste fino a –25 °C). Non va potata, se non per svecchiare il cespo.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rosai
                {
                   NomeComunePianta = "NEW DAWN",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Rambler",
                   FotoPianta = "ms-appx:///Immagini/ROSAI/NEW DAWN.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ROSAI/Abete-*.jpg",

                   DescrizioneBotanica = "CREATA DA DREER NEL 1930, DERIVA DALLA MUTAZIONE GENETICA DEL ROBUSTO RAMBLER IBRIDO DI WICHURAIANA ‘DR. W. FLEET’, DA CUI HA PRESO IL GRANDE VIGORE E LA NOTEVOLE RESISTENZA ALLE MALATTIE (MACCHIA NERA E MAL BIANCO). È UNA RAMPICANTE ARMONIOSA, CON RAMI LUNGHI FINO A 5 METRI, DA FAR ARRAMPICARE SU UN SUPPORTO STABILE (TRALICCIO, ALBERO, PILASTRO ECC.); HA FOGLIE PICCOLE, VERDE SCURO BRILLANTE. TOLLERA POSIZIONI SEMIOMBREGGIATE.",
                   Coltivazione = " Ha fiori di media grandezza con una tonalità di rosa pallidissimo argentato e profumo fresco, dall’aroma di mela verde e gelsomino. Sfoggia un’eccezionale prima fioritura seguita poi, per tutta la stagione, da corolle più rade. Va potato regolarmente secondo le regole classiche delle climber, in modo che possa generare un buon numero di nuovi getti alla base che andranno a sostituire i rami vecchi.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rosai
                {
                   NomeComunePianta = "PAT AUSTIN",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Rose inglesI",
                   FotoPianta = "ms-appx:///Immagini/ROSAI/PAT AUSTIN.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ROSAI/Abete-*.jpg",

                   DescrizioneBotanica = "CREATA NEL 1995, PORTA IL NOME DELLA MOGLIE DI DAVID AUSTIN E HA FIORI DI UN COLORE COMPLETAMENTE NUOVO NELLE ROSE INGLESI. LE COROLLE SONO DI UN RAME BRILLANTE, GIALLO RAMATO AL ROVESCIO, E CREANO UN EFFETTO SIMILE ALLA AUSTRIAN COPPER (R. FOETIDA BICOLOR). I FIORI SONO GRANDI E A FORMA DI COPPA PROFONDA, CARATTERISTICA CHE EVIDENZIA IL CONTRASTO TRA I DUE VERSI DELLA COROLLA. EMANANO UNA DOLCE FRAGRANZA DI TÈ CALDA E SENSUALE.",
                   Coltivazione = " Le forti tonalità delle corolle possano trovare una collocazione nel roseto, nelle bordure o nel giardino in generale. Pat Austin può donare a una bordura di rose dai toni più tenui una nota di brillante colore, anche se è importante non eccedere! Le dimensioni massime sono di 1,2 x 1 m: è un arbusto medio o basso, quindi può essere coltivata anche in vaso, se grande (minimo 50 cm), oppure come rampicante.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rosai
                {
                   NomeComunePianta = "PATIO",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Patio - Miniatura",
                   FotoPianta = "ms-appx:///Immagini/ROSAI/PATIO.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ROSAI/Abete-*.jpg",

                   DescrizioneBotanica = "PATIO È IL NOME DI UNA LINEA DI ROSE CHE COMPRENDE NUMEROSE VARIETÀ MOLTO COMPATTE, CON CRESCITA DAI 30 AI 50 CM, ADATTE A ESSERE PIANTATE IN GIARDINI, BALCONI, TERRAZZE E SEPOLCRI. È UNA GAMMA DI PIANTE MOLTO RESISTENTI ALLE MALATTIE, ALLE AVVERSITÀ, ALL’INQUINAMENTO, I CUI ESEMPLARI VANNO POSIZIONATI A UN INTERVALLO DI CIRCA 25 CM UNO DALL’ALTRO. FRA LE VARIETÀ, ‘APRICOT CLEMENTINE’, ‘BIJOU D’OR’, ‘CLEMENTINE’, ‘HONEYMILK’, ‘ORANGE BABYFLOR’, ‘PINK B.’, ‘SUGAR BABY’.",
                   Coltivazione = "Si tratta di rose a metà strada tra le miniatura e le rose a cespuglio da aiuola. Molto spesso vengono coltivate in vaso, purché non sia una normale fioriera da gerani, dalla capienza insufficiente. L’altezza in piena terra è di 50-60 cm. Il portamento è compatto e il cespuglio ben rifiorente. In giardino possono formare una piccola siepe. I fiori hanno un diametro di 5-8 cm. Categoria non molto diffusa in Italia tra i collezionisti.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rosai
                {
                   NomeComunePianta = "PAUL NEYRON",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Ibridi perpetue",
                   FotoPianta = "ms-appx:///Immagini/ROSAI/PAUL NEYRON.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ROSAI/Abete-*.jpg",

                   DescrizioneBotanica = "È UN IBRIDO PERENNE CREATO DA LEVET NEL 1869 IN FRANCIA. FORMA UN CESPUGLIO COMPATTO DI 0,9 X 60 CM, QUASI DEL TUTTO PRIVO DI SPINE, CON FOGLIE NON MOLTO GRANDI, DAL CARATTERISTICO COLORE VERDE LEGGERMENTE PIÙ CHIARO DEL NORMALE PER UNA ROSA, POCO LUCIDO E TENDENTE ALL’OPACO. IL PORTAMENTO È SEMPRE ERETTO, ANCHE SE NON SEMPRE ORDINATO. FAMOSA PER ESSERE STATA CITATA DA TOMASI DI LAMPEDUSA NEL ROMANZO IL GATTOPARDO.",
                   Coltivazione = " Produce fiori molto grandi, di color rosa carico sfumato di lilla che non schiarisce. I petali sono serrati al centro, con un caratteristico effetto che richiama a tratti il fiore di una rosa inglese. La corolla appare più disordinata quando è completamente aperta ed emana un profumo delizioso e intenso. È un rosaio molto rifiorente, le cui corolle sono adatte anche come fiore reciso (hanno una discreta durata).",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },


                new Rosai
                {
                   NomeComunePianta = "PEACE",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Ibridi di Tea",
                   FotoPianta = "ms-appx:///Immagini/ROSAI/PEACE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ROSAI/Abete-*.jpg",

                   DescrizioneBotanica = "FAMOSISSIMA ROSA (ALTA FINO A 1,2 M) CREATA DA MEILLAND NEL 1945, CHIAMATA ‘GIOIA’ IN ITALIA, IN FRANCIA ‘M.ME A. MEILLAND’, IN GERMANIA ‘GLORI’A DEI E NEGLI STATI UNITI ‘PEACE’. CINQUE ANNI DOPO LA COMPARSA DEL CESPUGLIO, FU OTTENUTA DA BRADY LA MUTAZIONE RAMPICANTE, ALTRETTANTO ECCEZIONALE E VIGOROSA, CON I MEDESIMI FIORI E BUONA RIFIORENZA. FAMOSISSIMA PER IL DOLCE, INCONFONDIBILE PROFUMO E I GRANDI FIORI GIALLI CON SFUMATURE ROSA AI BORDI.",
                   Coltivazione = " Si utilizza per siepi di medio sviluppo, è molto rustica tranne che nel primo anno dopo l’impianto, quando va pacciamata al piede. Si pota una volta l’anno, alla fine dell’inverno. I fiori sono adatti da recidere, in quanto anche tagliati si rivelano molto durevoli. Il cespuglio è vigoroso con belle foglie lucide, di colore verde scuro. È mediamente resistente alle malattie. Fra le sue mutazioni c’è ‘Chicago Peace’, rosa più scuro.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rosai
                {
                   NomeComunePianta = "PIERRE DE RONSARD",
                   NomeFamiglia = "Climber",
                   NomeScientificoPianta = "",
                   FotoPianta = "ms-appx:///Immagini/ROSAI/PIERRE DE RONSARD.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ROSAI/Abete-*.jpg",

                   DescrizioneBotanica = "‘PIERRE DE RONSARD’ (CONOSCIUTA ANCHE COME ‘EDEN ROSE’)È UNA ROSA MODERNA CREATA DA MEILLAND NEL 1987. I FIORI COLPISCONO PER LA GRAZIA, IL RICHIAMO ALLA BELLEZZA DELLE ROSE ANTICHE E LA FINEZZA DELLA PORCELLANA. È UN RAMPICANTE CHE ARRIVA A TOCCARE I 3,5-4 M CON UNO SVILUPPO IN ORIZZONTALE DI 2,5-3 METRI. L’ARBUSTO HA PORTAMENTO COMPATTO, MA NON È MOLTO VIGOROSO E NON CRESCE RAPIDAMENTE, SOPRATTUTTO NEL PRIMO ANNO. NON HA MOLTISSIME SPINE.",
                   Coltivazione = " I fiori sono grandi, a coppa profonda e ricchi di petali che si aprono in diversi giorni. Il bocciolo è pieno, striato di un verde pastello che sfuma in avorio; man mano che si apre, si evidenzia il centro di color rosa acceso. A fioritura completata il rosa sfuma in una gradazione molto più chiara e i fiori si aprono e si appiattiscono, assumendo un portamento più lasso e abbandonato sul picciolo. I fiori temono la pioggia.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rosai
                {
                   NomeComunePianta = "ROSA BANKSIAE",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Rambler",
                   FotoPianta = "ms-appx:///Immagini/ROSAI/ROSA BANKSIAE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ROSAI/Abete-*.jpg",

                   DescrizioneBotanica = "DI QUESTA ROSA ANTICA ESISTONO DIVERSE VARIETÀ. LA R. BANKSIAE LUTESCENS HA BISOGNO DI UN MURO RIPARATO ED ESPOSTO AL SOLE E, NELLE ZONE PARTICOLARMENTE FREDDE, VIENE DANNEGGIATA DAL GELO. PRIMA DI QUASI TUTTE LE ROSE, I SUOI RAMI LUNGHI SOTTILI SI RIEMPIONO DI FIORI CHE DURANO PER ALCUNE SETTIMANE E CHE, CON IL LORO GIALLO RADIOSO, COPRONO L’INTERO SOSTEGNO. I RAMI SI SVILUPPANO VIGOROSI: VANNO INDIRIZZATI OPPURE CONTENUTI CON ADEGUATE POTATURE.",
                   Coltivazione = " R. banksiae alba plena è altrettanto vigorosa; ha minuscoli fiori bianchi che profumano di violetta e sbocciano a partire da fine aprile; è stata introdotta da William Kerr a Kew da Canton nel 1807. R. banksiae lutea è meno vigorosa delle precedenti; ha preziosi fiori giallo burro doppi, che ricordano in miniatura quelli delle rose inglesi. R. banksiae rosea è un rampicante vigoroso, che produce fiori di colore rosa.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rosai
                {
                   NomeComunePianta = "ROSA CENTIFOLIA",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Centifolia",
                   FotoPianta = "ms-appx:///Immagini/ROSAI/ROSA CENTIFOLIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ROSAI/Abete-*.jpg",

                   DescrizioneBotanica = "NON RIFIORENTE DI ORIGINE SCONOSCIUTA, VIE NE DETTA ANCHE ROSA DI PROVENZA O CAVOLO, A CAUSA DELLA DISPOSIZIONE DEI PETALI CHE SI SOVRAPPONGONO FRA LORO. SONO BENADATTA BILI AI VARI TIPI DI TERRENO. DI RAPIDO ACCRE SCIMENTO, POSSONO SUPERARE 1,80 M D’ALTEZ ZA ANCHE SE VENGONO POTATE IN MODO DE CISO. LE FOGLIE SONO VERDI, SPESSO BORDATE IN ROSSO. I FIORI PENDULI POSSIEDONO FORMA GLOBOSA E SONO RICCHI DI PETALI; I GROSSI CI NORRODI SONO OVALI.",
                   Coltivazione = "In natura non esiste una specie rispondente a questo nome, perché l’origine di R. x centifolia è dovuta a un complesso di ibridi fra R. gallica, R. moschata, R. canina e R. x damascena (Damask, forse originaria del Medio Oriente). Tra le varietà, la meglio conosciuta è ‘Chapeau de Napoléon’. Molto bella è anche ‘Célina’, con fiori abbastanza grandi, dai petali rosa e lavanda, i quali racchiudono stami di color oro.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rosai
                {
                   NomeComunePianta = "ROSA CHINENSIS",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Rose cinesi",
                   FotoPianta = "ms-appx:///Immagini/ROSAI/ROSA CHINENSIS.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ROSAI/Abete-*.jpg",

                   DescrizioneBotanica = "RIFIORENTE DAL PORTAMENTO LEGGERO E ARIOSO, CON FUSTI PIUTTOSTO SOTTILI E FIORITURE PROLUNGATE. I FIORI SONO ABBASTANZA PICCOLI, CON COROLLA DOPPIA O SEMIDOPPIA, SOLITAMENTE SUI TONI DEL ROSA. PER LA MODESTA ALTEZZA (AL MASSIMO 1,2 M) SI POSSONO IMPIEGARE IN SITUAZIONI IN CUI UN TOCCO DI CLASSE È PIÙ DESIDERABILE DI UN EFFETTO CROMATICO D’IMPATTO. LE VARIETÀ DERIVATE DALLA FORMA ORIGINARIA, OGGI SCOMPARSA, HANNO UN’ENORME VARIABILITÀ.",
                   Coltivazione = " La varietà più diffusa è ‘Mutabilis’, i cui fiori cambiano colore con il tempo: dal giallo iniziale diventano poi rosa-salmone, rame e inﬁ ne cremisi scuro. Ma esistono anche ‘Minima’ (alta 20-25 cm), ‘Crimson Bengal’ (fiori rosso scuro e grandi), ‘Semperﬂ orens’ (che non interrompe mai la fioritura), ‘Old Blush China’ (portamento elegante, fiori piccoli e graziosi, color rosa chiaro, in fiore fin quasi a Natale).",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rosai
                {
                   NomeComunePianta = "ROSA FILIPES 'KIFTSGATE'",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Rambler",
                   FotoPianta = "ms-appx:///Immagini/ROSAI/ROSA FILIPES KIFTSGATE.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ROSAI/Abete-*.jpg",

                   DescrizioneBotanica = "R. FILIPES È ORIGINARIA DELLA CINA OCCIDENTALE, DA DOVE FU INTRODOTTA IN EUROPA NEL 1908. ‘KIFTSGATE’ È UNA VARIETÀ DI R. FILIPES TROVATA NEI GIARDINI OMONIMI. È UN ROSAIO CHE HA BISOGNO DI GRANDI SPAZI, PERCHÈ PUÒ RAGGIUNGERE I 12 M DI LUNGHEZZA/ALTEZZA. È UTILIZZATA PER COPRIRE MURI, ANCHE ALTI E LUNGHI, INTERE PERGOLE, PORTICATI A PARTIRE DALLE COLONNE, ALBERI MORTI, RECINZIONI DI METALLO, MURATURA O LEGNO ANCHE MOLTO ESTESE ECC. ",
                   Coltivazione = " Ha piccoli fiori semplici o semidoppi, bianchi, riuniti in enormi corimbi profumati a formare grandi mazzi di colore bianco crema dal profumo intenso e speziato. Dai fiori derivano migliaia di cinorrodi (frutti) piccoli e di colore rosso: è una rosa che viene annoverata nella categoria dei rosai da bacca, molto decorativi anche in autunno, a condizione di non tagliare i fiori appassiti, se non in piccola parte.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rosai
                {
                   NomeComunePianta = "ROSA GALLICA",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Gallica",
                   FotoPianta = "ms-appx:///Immagini/ROSAI/ROSA GALLICA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ROSAI/Abete-*.jpg",

                   DescrizioneBotanica = "NON RIFIORENTE DI ANTICA ORIGINE, FORSE FRANCESE, È PROVVISTA DI PORTAMENTO COMPATTO CON RAMI ERETTI E SOLITAMENTE NON SUPERA 1,2 M D’ALTEZZA. LE FOGLIE SONO DI UN BEL VERDE SCURO E APPAIONO PIUTTOSTO RUVIDE, MENTRE LE INFIORESCENZE A FIORI PIATTI ED ERETTI SUPERANO NETTAMENTE IL FOGLIAME. I CINORRODI HANNO FORMA TONDEGGIANTE. SONO ADATTE PER IL PRIMO PIANO DI QUALUNQUE TIPO DI DECORAZIONE ARBUSTIVA, COSÌ COME PER FORMARE SIEPI.",
                   Coltivazione = " In natura esiste la specie propriamente denominata R. gallica, che vive in un vasto areale compreso fra l’Europa centro-meridionale e il Caucaso. Per il giardino una delle rappresentanti più famose nel gruppo degli ibridi è la ‘Complicata’: molto robusta e vigorosa, con grandi fiori di colore rosa brillante e stami di un bel giallo oro, può anche venire impiegata come sarmentosa. Interessante anche ‘La Belle Sultane’.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rosai
                {
                   NomeComunePianta = "ROSA MOSCHATA",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Rose botaniche",
                   FotoPianta = "ms-appx:///Immagini/ROSAI/ROSA MOSCHATA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ROSAI/Abete-*.jpg",

                   DescrizioneBotanica = "LA FORTUNA DI QUESTA NON RIFIORENTE FU DECRETATA DURANTE L’EPOCA DELLA REGINA VITTORIA, NELLA SECONDA METÀ DEL XIX SECOLO. SI TRATTAVA DI UNA ROSA NATA DA ROSE CENTIFOLIA FRUTTO DI MUTAZIONI GENETICHE SPONTANEE, LA CUI PRINCIPALE CARATTERISTICA È LEGATA ALLA FORMAZIONE DI UNA PATINA MUSCHIATA CHE SI DISTRIBUISCE SUI SEPALI E SUGLI STELI FIORALI, PRODUCENDO UN’ESSENZA AROMATICA. UN PAIO DI QUESTI IBRIDI FIORISCE ANCHE IN AUTUNNO.",
                   Coltivazione = "Una varietà molto vigorosa di R. moschata è ‘Gloire des Mousseux’, dotata di fiori molto grandi, profumati e pluripetali, di un bel rosa chiaro che, con il trascorrere dei giorni, diventa quasi evanescente. Al contrario un’altra varietà, ‘Alfred de Dalmas’, sfoggia fiori piccoli, semidoppi, che però sono ugualmente profumati e di color rosa crema; tollera terreni poveri e la mezz’ombra, così come la coltivazione in vaso.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rosai
                {
                   NomeComunePianta = "ROSA PIMPINELLIFOLIA",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Rose botaniche",
                   FotoPianta = "ms-appx:///Immagini/ROSAI/ROSA PIMPINELLIFOLIA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ROSAI/Abete-*.jpg",

                   DescrizioneBotanica = "PRESENTE, FORSE IN MODO SPONTANEO, IN MOLTE AREE DELL’EUROPA SETTENTRIONALE, IN NATURA VIVE SU SUOLI CALCAREI. NON HA GRANDI DIMENSIONI: RAGGIUNGE UN MASSIMO DI CIRCA 1,2 X 1,2 METRI. TENDE A PRODURRE MOLTI POLLONI, UNA BUONA PARTE DEI QUALI VA ELIMINATA PER NON INDEBOLIRE LA PIANTA. I RAMI, COMPLETAMENTE ARMATI DI SPINE POCO ROBUSTE, SONO COPERTI DA UN PICCOLO E AFFASCINANTE FOGLIAME SIMILE A QUELLO DELLE FELCI, LEGGERMENTE AROMATICO.",
                   Coltivazione = "Fiorisce nella prima decade di maggio con fiori semidoppi a globo di un bianco crema con sfumature rosate, del diametro di 5 cm e dotati un profumo rinfrescante e intenso. Non è resistentissima alle basse temperature: nella zona alpina è preferibile coltivarla in posizione riparata dai venti gelidi e ben soleggiata anche d’inverno, pacciamandone la base con foglie secche in abbondanza, tenute ferme con pietre.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rosai
                {
                   NomeComunePianta = "ROSA ROXBURGHII",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Rose botaniche",
                   FotoPianta = "ms-appx:///Immagini/ROSAI/ROSA ROXBURGHII.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ROSAI/Abete-*.jpg",

                   DescrizioneBotanica = "ROSA SELVATICA DI ORIGINE CINESE, INTRODOTTA IN EUROPA NEI PRIMI ANNI DEL 1900. VENNE SCOPERTA PRIMA LA CULTIVAR ROXBURGHII PLENA DAI FIORI DOPPI, E SOLO IN UN SECONDO MOMENTO LA VARIETÀ SPONTANEA CON FIORE A 5 PETALI. È UN ARBUSTO A CRESCITA LENTA CHE RAGGIUNGE LE DIMENSIONI MASSIME DI CIRCA 2,5 X 2,5 METRI. È L’UNICA ROSA SELVATICA AD AVER PERSO L’ATTITUDINE DI LIANACEA. I FIORI SONO BIANCO ROSATI, APPAIONO IN MAGGIO NELLA SPECIE, ANCHE IN SETTEMBRE NELLA CULTIVAR.",
                   Coltivazione = "Con l’età il suo tronco si sfoglia formando piccoli rotoli simili a pergamena: risulta particolarmente decorativa persino in inverno e merita in giardino una posizione ben in vista anche dall’abitazione. Si può impiegare per siepi alte. Tollera anche una collocazione in mezz’ombra. Dai fiori nascono particolari cinorrodi che a maturità divengono gialli; assomigliano nell’aspetto ai ricci dell’ippocastano.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rosai
                {
                   NomeComunePianta = "ROSA SERICEA PTERACANTHA",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Rose botaniche",
                   FotoPianta = "ms-appx:///Immagini/ROSAI/ROSA SERICEA PTERACANTHA.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ROSAI/Abete-*.jpg",

                   DescrizioneBotanica = "ORIGINARIA DELLA CINA, SCOPERTA DAL REVERENDO FABER NEL 1886 E INTRODOTTA DA WILSON NEL 1901, È UN GRANDE ARBUSTO RUSTICO. LE FOGLIE, SIMILI A QUELLE DELLE FELCI, SONO LUNGHE 4-10 CM E DIVISE IN 11-19 FOGLIOLINE, VERDE SCURO, OBLUNGHE, GLABRE, DENTATE, TALVOLTA CON SPINE SULLA NERVATURA INFERIORE. I FIORI SONO BIANCHI, SOLITARI, DI 4 CM DI DIAMETRO, A 4 PETALI DISPOSTI A CROCE DI MALTA, ANZICHÈ 5. I FRUTTI, LUNGHI 2 CM, SONO PIRIFORMI, ROSSI CON PEDUNCOLO GIALLO.",
                   Coltivazione = "La forma pteracantha ha spine bellissime, traslucide, larghe 4 cm alla base, piatte e sottili, rosso brillante. Si sviluppano per tutta la lunghezza dei rami nuovi e hanno l’aspetto di piccole ali. Per favorire la produzione di getti giovani con spine decorative, la pianta va potata energicamente in inverno o inizio primavera. Le spine dei rami vecchi perdono il loro colore. I fiori sono più piccoli rispetto alla specie.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },

                new Rosai
                {
                   NomeComunePianta = "THE FAIRY",
                   NomeFamiglia = "Rosacee",
                   NomeScientificoPianta = "Rose tapezzanti",
                   FotoPianta = "ms-appx:///Immagini/ROSAI/THE FAIRY.jpg",
                   SourceGalleryFotografica = $"ms-appx:///Immagini/ROSAI/Abete-*.jpg",

                   DescrizioneBotanica = "‘THE FAIRY’ È STATA CREATA NEL 1932 ED È UN’OTTIMA COPRISUOLO, TANTO CHE IL TERMINE GROUND-COVER LE SI ADDICE PERFETTAMENTE. È FRA LE ROSE PIÙ DIFFUSE ANCHE PER LA SUA FACILITÀ DI COLTIVAZIONE. HA UN PORTAMENTO ESPANSO E TAPPEZZANTE. IL FOGLIAME È PICCOLO, AGGRAZIATO, DI COLOR VERDE MEDIO, LUCIDO ED È COSÌ FITTO DA COPRIRE IL TERRENO SOTTOSTANTE. SOFFRE, NEI CLIMI PIÙ UMIDI, IL MAL BIANCO E LA TICCHIOLATURA, MA NON RISENTE DELL’ATTACCO DI QUESTE PATOLOGIE.",
                   Coltivazione = "Produce da 10 a 40 fiori, piccole rosette increspate, che porta in piccoli mazzi, che riempiono i lunghi rami. Fiorisce a stagione inoltrata, ma la fioritura prosegue fino all’inizio dell’inverno. Il colore è rosa vivace che, con l’avanzare della maturità del fiore, schiarisce quasi fino al bianco nelle esposizioni più assolate. È scarsamente profumata o addirittura inodore nella maggior parte dei casi. Perfetta nelle bordure miste.",
                   Propagazione = "",
                   Potatura = "",
                   Malattie = "",
                },
                


            };

            return data;
        }

        // TODO WTS: Remove this once your MasterDetail pages are displaying real data
        public static async Task<IEnumerable<Rosai>> GetSampleModelDataAsync()
        {
            await Task.CompletedTask;

            return AllRosai();
        }

        
    }
}
