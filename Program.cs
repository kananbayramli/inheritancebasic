using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceOdev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook NB = new Notebook();
            NB.marka = "Lenovo";
            NB.model = "c50";
            NB.islemci = "IS";
            NB.alisFiyat = 1500;
            NB.satisFiyat = 1600;
            NB.kompaniyaFiyat = 1000;
            NB.barkod = "1234578";

            LocalDatabase.YeniUrunEkle(NB);


            Notebook NB2 = new Notebook();
            NB2.marka = "Lenovo";
            NB2.model = "c50";
            NB2.islemci = "IS";
            NB2.alisFiyat = 1500;
            NB2.satisFiyat = 1600;
            NB2.kompaniyaFiyat = 1000;
            NB2.barkod = "1234578"; //Barkod eyni olduguna gore bu deyeri elave etmiyecek

            LocalDatabase.YeniUrunEkle(NB2);
        }
    }
}
