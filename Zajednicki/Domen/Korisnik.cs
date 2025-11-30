using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using Zajednicki.Domen;

namespace Klijent.Domen
{
    public class Korisnik : IObjekat
    {
        public int Id { get; set; }
        public string Korisnicko_ime { get; set; }
        public string Lozinka { get; set; }
        public string nazivTabele { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public object koloneNaziv { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string vrednostiNaziv { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string kljucPrimarni { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string kljucSpoljni { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string kriterijumWhere { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Korisnik(string korisnicko_ime, string lozinka)
        {
 
            Korisnicko_ime = korisnicko_ime;
            Lozinka = lozinka;
        }

        public List<IObjekat> vratiObjekte(SqlDataReader dr)
        {
            throw new NotImplementedException();
        }

        public List<IObjekat> vratiObjekteJoin(SqlDataReader dr)
        {
            throw new NotImplementedException();
        }

        public IObjekat vratiObjekat(SqlDataReader dr)
        {
            throw new NotImplementedException();
        }

        public IObjekat vratiObjekatJoin(SqlDataReader dr)
        {
            throw new NotImplementedException();
        }
    }
}
