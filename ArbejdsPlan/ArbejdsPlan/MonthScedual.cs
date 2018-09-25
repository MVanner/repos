using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbejdsPlan
{
    class MonthScedual
    {
        string række = "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------";
        string dag = "| " + "Tid/Dage" + " | " + " | " + Dag + " | " + Dag + " | " + Dag + " | " + Dag + " | " + Dag + " | " + Dag + " | " + Dag + " | " + Dag + " | " + Dag + " | " + Dag + " | " + Dag + " | " + Dag + " | " + Dag + " | " + Dag + " | " + Dag + " | " + Dag + " | " + Dag + " | " + Dag + " | " + Dag + " | " + Dag + " | " + Dag + " | " + Dag + " | " + Dag + " | " + Dag + " | " + Dag + " | " + Dag + " | " + Dag + " | " + Dag + " | " + Dag + " | " + Dag + " |";
        string ansatte = "| " + "10 - 16" + " | " + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " |";
        string blank = "| " + " | " + " | " + " | " + " | " + " | " + " | " + " | " + " | " + " | " + " | " + " | " + " | " + " | " + " | " + " | " + " | " + " | " + " | " + " | " + " | " + " | " + " | " + " | " + " | " + " | " + " | " + " | " + " | " + " | " + " | " + " | " + " |";
        string ansatte2 = "| " + "16 - 23" + " | " + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " | " + Ansatte + " |";

        public void GenerateMonth()
        {
            string[] Dag = new string[7];
            Dag[0] = "Mandag";
            Dag[1] = "Tirsdag";
            Dag[2] = "Onsdag";
            Dag[3] = "Torsdag";
            Dag[4] = "Fredag";
            Dag[5] = "Lørdag";
            Dag[6] = "Søndag";
        }

        public string Tabel()
        {
            string tabel = "\n";
            tabel = tabel + række + "\n";
            tabel = tabel + dag + "\n";
            tabel = tabel + række + "\n";
            tabel = tabel + blank + "\n";
            tabel = tabel + ansatte + "\n";
            tabel = tabel + blank + "\n";
            tabel = tabel + række + "\n";
            tabel = tabel + blank + "\n";
            tabel = tabel + ansatte2 + "\n";
            tabel = tabel + blank + "\n";
            tabel = tabel + række + "\n";
            return tabel;
        }

    }
}

