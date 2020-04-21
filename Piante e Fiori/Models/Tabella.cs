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

    public class Tabella
    {
        public string Tipo { get; set; }
        public string Categoria { get; set; }
        public string NomeComunePianta { get; set; }
        public string NomeFamiglia { get; set; }
        public string NomeScientificoPianta { get; set; }
        public string FotoPianta { get; set; }
        public string Esposizione { get; set; }
        public string Esposizione1 { get; set; }

        public string Colore { get; set; }
        public string Fioritura { get; set; }
        public string Dimensioni { get; set; }
        

    }

    public static class TabellaDataService
    {
        private static IEnumerable<Tabella> AllTabella()
        {
            // The following is order summary data
            var data = new ObservableCollection<Tabella>
            {
               
                new Tabella
                {
                   Tipo = "ERBACEE",
                   Categoria = "ANNUALI",
                   Esposizione = "ms-appx:///Assets/Sun.png",
                   NomeComunePianta = "Agerato",
                   NomeFamiglia = "",
                   NomeScientificoPianta = "",
                   FotoPianta = "ms-appx:///Immagini/",                                   
                   Colore = "lilla, blu, bianco ",
                   Fioritura = "primavera, estate, autunno",
                   Dimensioni = "Medie (da cm 30 a 60)",
                },

                new Tabella
                {
                   Tipo = "ERBACEE",
                   Categoria = "ANNUALI",
                   Esposizione = "ms-appx:///Assets/Sun.png",
                   NomeComunePianta = "Arctotide",
                   NomeFamiglia = "",
                   NomeScientificoPianta = "",
                   FotoPianta = "ms-appx:///",
                   Colore = "tutti i colori",
                   Fioritura = "estate, autunno",
                   Dimensioni = "Medie (da cm 30 a 60)",
                },

                new Tabella
                {
                   Tipo = "ERBACEE",
                   Categoria = "ANNUALI",
                   Esposizione = "ms-appx:///Assets/Sun.png",
                   NomeComunePianta = "Astro regina Margherita",
                   NomeFamiglia = "",
                   NomeScientificoPianta = "",
                   FotoPianta = "ms-appx:///Immagini/",
                   Colore = "tutti i colori",
                   Fioritura = "primavera, estate, autunno",
                   Dimensioni = "Medie (da cm 30 a 60)",
                },

                new Tabella
                {
                   Tipo = "ERBACEE",
                   Categoria = "",
                   Esposizione = "ms-appx:///Assets/Sun.png",
                   NomeComunePianta = "",
                   NomeFamiglia = "",
                   NomeScientificoPianta = "",
                   FotoPianta = "ms-appx:///Immagini/",
                   Colore = "",
                   Fioritura = "",
                   Dimensioni = "Medie (da cm 30 a 60)",
                },


            };

            return data;
        }

        // TODO WTS: Remove this once your MasterDetail pages are displaying real data
        //public static async Task<IEnumerable<Tabella>> GetSampleModelDataAsync()
        //{
        //    await Task.CompletedTask;
        //
         //   return AllTabella();
        //}

        public static ObservableCollection<Tabella> GetGridSampleData()
        {
            return new ObservableCollection<Tabella>(AllTabella());
        }

    }
}
