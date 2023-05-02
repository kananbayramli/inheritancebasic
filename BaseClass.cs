using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceOdev
{
    public class BaseClass
    {
        public static int num = 1; // yarandigi zaman bir deyerini avtomatik alsin

        public BaseClass()
        {
            _id = num;
            num = num + 1;
        }

        private int _id;
        public int id
        {
            get { return _id; }
            private set
            {
                // id bir bir artacaq
                //_id = num;             //static oldugu ucun buurda id-e deyer vere bilmirik (constructor)
                //num = num + 1;

            }
        } //*
        private string _barkod;
        public string barkod 
        {
            get { return _barkod; }
            set 
            {
                bool kontrolIslem = LocalDatabase.dbBarkodControl(value);
                if (!kontrolIslem)  // deyer localdb-de yoxdur
                {
                    _barkod = value;
                }
                else 
                {
                    Console.WriteLine("Bu barkodla olan deyer artiq DataBasede movcuddur...");
                }
            
            }
        } //*




        public DateTime olushturmaTarih { get; set; }
        public int olushturanKullanici { get; set; }

        public DateTime guncellemeTarih { get; set; }
        public int guncelleyenKullanici { get; set; }

        public bool silindi { get; set; }


     
    }
}
