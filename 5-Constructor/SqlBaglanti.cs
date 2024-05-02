using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Constructor
{
    public class SqlBaglanti

        //Singleton Patten 
    {
        static SqlConnection baglanti;
        private SqlBaglanti()  //Private cekme nedeni her gelen sql nesnesinde ctor newlememeli.
        {
            baglanti = new SqlConnection();
        }
        public static SqlConnection BaglantiVer()
        {
            //Baglantiya bir kere girme hakki verir.

            if (baglanti==null)
            {
                baglanti = new SqlConnection();
            }
           return baglanti;
        }
    }
}
