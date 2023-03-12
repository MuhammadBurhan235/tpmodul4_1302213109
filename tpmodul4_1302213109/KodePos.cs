using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302213109
{
    internal class KodePos
    {
        private Dictionary<string, string> tabelKodePos = new Dictionary<string, string>
        {
            {"Batununggal", "40266"},
            {"A. Kujangsari", "40287"},
            {"Mengger", "40267"},
            {"Wates", "40256"},
            {"Cijaura", "40287"},
            {"Jatisari", "40286"},
            {"Margasari", "40286"},
            {"Sekejati", "40286"},
            {"Kebonwaru", "40272"},
            {"Maleer", "40274"},
            {"Samoja", "40273"}
        };

        public string getKodePos(string kelurahan)
        {
            if (tabelKodePos.ContainsKey(kelurahan))
            {
                return tabelKodePos[kelurahan];
            }
            else
            {
                return "Kode pos tidak ditemukan.";
            }
        }
    }

    class Program_KP
    {
        static void Main_KP(string[] args)
        {
            KodePos kodepos = new KodePos();

            Console.WriteLine(kodepos.getKodePos("Batununggal")); // Output: 40266
            Console.WriteLine(kodepos.getKodePos("A. Kujangsari")); // Output: 40287
            Console.WriteLine(kodepos.getKodePos("Mengger")); // Output: 40267
            Console.WriteLine(kodepos.getKodePos("Wates")); // Output: 40256
            Console.WriteLine(kodepos.getKodePos("Cijaura")); // Output: 40287
            Console.WriteLine(kodepos.getKodePos("Jatisari")); // Output: 40286
            Console.WriteLine(kodepos.getKodePos("Margasari")); // Output: 40286
            Console.WriteLine(kodepos.getKodePos("Sekejati")); // Output: 40286
            Console.WriteLine(kodepos.getKodePos("Kebonwaru")); // Output: 40272
            Console.WriteLine(kodepos.getKodePos("Maleer")); // Output: 40274
            Console.WriteLine(kodepos.getKodePos("Samoja")); // Output: 40273
            Console.WriteLine(kodepos.getKodePos("Cilaki")); // Output: Kode pos tidak ditemukan.
        }
    }
}
