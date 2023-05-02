using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritanceOdev
{
    public static class LocalDatabase
    {
        private static ArrayList DB = new ArrayList();

        public static void YeniUrunEkle(BaseClass data)
        {
            if (data != null && !string.IsNullOrEmpty(data.barkod))
            { 
                DB.Add(data);
            }
        }

        public static bool dbBarkodControl(string barkod) 
        {
            if (DB != null && DB.Count > 0) 
            {
                for (int i = 0; i < DB.Count; i++ ) 
                {
                    BaseClass bc = (BaseClass)DB[i];
                    if (bc.barkod == barkod) 
                    {
                        return true;
                    }
                }
            
            }
            return false;

        }
        

    }
}
