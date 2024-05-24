using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace eurovizio
{
    class Verseny
    {
        int ev;
        DateTime datum;
        string varos;
        string orszag;
        int induloszam;

        public Verseny(MySqlDataReader verseny)
        {
            Ev = Convert.ToInt32(verseny.GetString(0));
            Datum = Convert.ToDateTime(verseny.GetString(1));
            Varos = verseny.GetString(2);
            Orszag = verseny.GetString(3);
            Induloszam = Convert.ToInt32(verseny.GetString(4));
        }

        public int Ev { get => ev; set => ev = value; }
        public DateTime Datum { get => datum; set => datum = value; }
        public string Varos { get => varos; set => varos = value; }
        public string Orszag { get => orszag; set => orszag = value; }
        public int Induloszam { get => induloszam; set => induloszam = value; }
    }
}
