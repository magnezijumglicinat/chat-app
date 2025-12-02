using Klijent.Domen;
using System;
using System.Collections.Generic;
using System.Text;
using Zajednicki.Domen;

namespace SO
{
    public class PretraziSO : SystemOperationsBase
    {
        private string msgText;
        Korisnik k = new Korisnik();
        public bool Uspesno = false;
        public PretraziSO(string msgText)
        {
            this.msgText = msgText;
            k.Korisnicko_ime = msgText;
            k.koloneNaziv = "id,korisnicko_ime";
            k.kriterijumWhere = $"korisnicko_ime = '{k.Korisnicko_ime}'";
        }
        protected override void ExecuteConcreteOperation()
        {
            if ((Korisnik)broker.getCriteria(k) != null)
                Uspesno = true;

        }
    }
}
