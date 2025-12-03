using Klijent.Domen;
using System;
using System.Collections.Generic;
using System.Text;
using Zajednicki.Domen;

namespace SO
{
    public class VratiPrijateljeSO : SystemOperationsBase
    {
        private Korisnik id;
        public List<Korisnik> lista;
        public VratiPrijateljeSO(Korisnik k)
        {
            id = k;
           
        }
        protected override void ExecuteConcreteOperation()
        {
            List<IObjekat> x = broker.GetAllJoin(id, id.Id);
            lista = new List<Korisnik>();
            if (x != null)
            {
                foreach (var obj in x)
                    lista.Add((Korisnik)obj);
            }
        }
    }
}
