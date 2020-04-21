using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace Piante_e_Fiori.Services
{
    public class Library1
    {
        //LIBRERIA PER SALVARE E CARICARE LO STATO DI UN TEXTBLOCK
        public string LoadSetting(string keyLoad)
        {
            if (ApplicationData.Current.LocalSettings.Values[keyLoad] != null)
            {
                return ApplicationData.Current.LocalSettings.Values[keyLoad].ToString();
            }
            else
                return string.Empty;
        }

        public void SaveSettings(string keySave, string valueToSave)
        {
            ApplicationData.Current.LocalSettings.Values[keySave] = valueToSave;
        }

        //LIBRERIA PER SALVARE E CARICARE LO STATO DI UN RADIOBUTTON E DI UN TOOGLE SWITCH (da Alessio Lafrate)       
        public bool LoadSettingBool(string keyLoad)
        {
            if (ApplicationData.Current.LocalSettings.Values[keyLoad] != null)
            {
                return (bool)ApplicationData.Current.LocalSettings.Values[keyLoad];
            }
            else
                return false;
        }
        public void SaveSettingsBool(string keySave, bool valueToSave)
        {
            ApplicationData.Current.LocalSettings.Values[keySave] = valueToSave;
        }


    }
}

//ESEMPIO DA USARE NELLA PAGINA DI CODICE PER TOOGLE SWITCH
//inizialize component
//Visualizza_nascondi_pulsanti_menu_ToggleSwitch.IsOn = library2.LoadSettingBool("Visualizza-nascondi pulsanti menu");
//pulsante salva
//library2.SaveSettingsBool("Visualizza-nascondi pulsanti menu", Visualizza_nascondi_pulsanti_menu_ToggleSwitch.IsOn);
