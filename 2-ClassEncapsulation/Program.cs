using _2_ClassEncapsulation.Mobilyalar;

namespace _2_ClassEncapsulation
{
    internal class Program
    {
        /*
         *  Mobilyalar icin Masa,sandalye,yemekTakimi , YatakOdasi takimi,
         *  Bahçe takimi,ÇocukOdasi Takimi
         * 
         * 
         * Telefonlar : Sabit Telefon, Cep Telefonu ,Akilli Telefonlar 
         * 
         * Araçlar : Otomobil , Kamyon , Otobus ,Motorsiklet
         */

        static void Main(string[] args)
        {
            #region Yemek Takimi
            // Yemek Takimi instance alma 1. Yol
            YemekTakimi yemekTakimi = new YemekTakimi();
            yemekTakimi.Masa = new Masa();
            yemekTakimi.Sandalyeler = new List<Sandalye>();
            yemekTakimi.Sandalyeler.Add(new Sandalye() { AyakSayisi = 4, KumasTipi = KumasTipi.KESME, Malzeme = Malzeme.Ahsap, Renk = Renk.Kirmizi });


            // YemekTakimi 2. Yol NEsneleri onceden tek tek olusturup 
            //YemekTakimi Nesnesinin property'lerine atama yapmaktir
            Masa yemekMasasi = new Masa()
            {

                Renk = Renk.Mavi,
                Color = new System.Drawing.Color(),
                Color2 = ConsoleColor.Black,
                KnownColor = System.Drawing.KnownColor.Blue
            };

            Sandalye sandalye1 = new Sandalye()
            {
                AyakSayisi = 4,
                KumasTipi = KumasTipi.KESME,
                Malzeme = Malzeme.Ahsap,
                Renk = Renk.Kirmizi,
            };
            Sandalye sandalye2 = new Sandalye()
            {
                AyakSayisi = 4,
                KumasTipi = KumasTipi.KESME,
                Malzeme = Malzeme.Ahsap,
                Renk = Renk.Kirmizi,
            };
            Sandalye sandalye3 = new Sandalye()
            {
                AyakSayisi = 4,
                KumasTipi = KumasTipi.KESME,
                Malzeme = Malzeme.Ahsap,
                Renk = Renk.Kirmizi,
            };

            yemekTakimi.Sandalyeler.Add(sandalye1);
            yemekTakimi.Sandalyeler.Add(sandalye2);
            yemekTakimi.Sandalyeler.Add(sandalye3);

            // Console.WriteLine($"Yemek Odasi 1 adet masa ve {yemekTakimi.Sandalyeler.Count} adet sandalyeden olusmaktadir"); 
            #endregion

            #region Akilli Telefon

            // AkilliCepTelefonu samsung = new AkilliCepTelefonu
            // {
            //     Bluetooth =true,
            //     DahiliHazifa=128,
            //     NFC = true,
            //     ParmakIzi = true,
            //     YuzTanima = true
            // };  
            #endregion



        }
    }
}
