using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace eurovizio
{
    class Dal
    {

        int ev;
        string eloado, cim;
        int helyezes;
        int pontszam;

        public Dal(MySqlDataReader dal)
        {
            Ev = dal.GetInt32(0);
            Eloado = dal.GetString(1);
            Cim = dal.GetString(2);
            Helyezes = dal.GetInt32(3);
            Pontszam = dal.GetInt32(4);
        }

        public int Ev { get => ev; set => ev = value; }
        public string Eloado { get => eloado; set => eloado = value; }
        public string Cim { get => cim; set => cim = value; }
        public int Helyezes { get => helyezes; set => helyezes = value; }
        public int Pontszam { get => pontszam; set => pontszam = value; }
    }
}
