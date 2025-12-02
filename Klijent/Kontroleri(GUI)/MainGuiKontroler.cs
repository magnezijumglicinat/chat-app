using Klijent.Domen;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Zajednicki;

namespace Klijent.Kontroleri_GUI_
{
    public class MainGuiKontroler
    {
        public static MainGuiKontroler instance;
        public static MainGuiKontroler Instance
        {
            get
            {
                if (instance == null)
                    instance = new MainGuiKontroler();
                return instance;
            }
        }

        internal async Task<string> Pretrazi(string msgtext)
        {
            try
            {
                if (msgtext.IsWhiteSpace())
                    throw new Exception("aaa");
                Komunikacija.Instance.Connect();
                Odgovor o = await Komunikacija.Instance.Pretrazi(msgtext);
                if (!o.Uspesno)
                {
                    MessageBox.Show("Ne postoji korisnik sa tim korisnickim imenom.");
                    throw new Exception("aaa");
                }

                return msgtext;
                    
            }
            catch (Exception x)
            {
                return "greska";
            }
        }
    }
}
