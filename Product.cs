using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceOdev
{
    public class Product:BaseClass
    {
        public string marka { get; set; } // qeyd etdiyimiz markalar ancaq elave oluna biler
        public string model { get; set; }


        private decimal _alisFiyat;
        public decimal alisFiyat {
            get { return _alisFiyat; } 
            set{
                if (value < 0)
                {
                    Console.WriteLine("Alish qiymeti 0-dan ashagi ola bilmez...");
                }
                else 
                { 
                    _alisFiyat = value;
                }
            
            }      
        } // 0 dan balaca ola bilmez


        private decimal _satisFiyat;
        public decimal satisFiyat 
        {
            get { return _satisFiyat; }

            set
            {
                if (value <= _alisFiyat)
                {
                    Console.WriteLine("Bizede bir xeyir qalsin...");
                }
                else 
                {
                    _satisFiyat = value;
                }
            
            }
        
        } //alisfiyatdan balaca ola bilmez



        private decimal _kompaniyaFiyat;
        public decimal kompaniyaFiyat {
            get { return _kompaniyaFiyat; }
            set 
            {
                if (value < 0)
                { Console.WriteLine(" kompaniya qiymeti 0-dan kicik ola bilmez..."); }
                else { _kompaniyaFiyat = value; }
            }
        
        } //kompaniyafiyat 0dan balaca ola bilmez
    }
}
