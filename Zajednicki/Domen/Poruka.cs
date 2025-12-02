using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Zajednicki.Domen
{
    public class Poruka: IObjekat
    {
        public int Id { get; set; }
        public int primalac_id { get; set; }
        public int posiljalac_id { get; set; }
        public string poruka_text { get; set; }
        public string nazivTabele { get; set; } = "Poruka";
        public object koloneNaziv { get; set; } = "id,primalac,posiljalac,poruka_text,datum";
        public string vrednostiNaziv { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string kljucPrimarni { get; set; } = "id";
        public string kljucSpoljni { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string kriterijumWhere { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DateTime datum;

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
