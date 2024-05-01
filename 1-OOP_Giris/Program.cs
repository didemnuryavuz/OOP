using _1_OOP_Giris.BilgisayarParcalari;
using System.Diagnostics.Metrics;
using System;

namespace _1_OOP_Giris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //***************ENUM***************
            //Bu yapı yazılım dilinde enum, enumaration ya da enum sabitleri olarak adlandırılır.
            //Değişkenlerin alabileceği değerlerin sabit (belli) olduğu durumlarda programı daha okunabilir hale getirmek için kullanılır.
            //Programda birçok değişkene tek tek sayısal değer vermek yerine "enum" kullanılabilir.
            //Özet olarak "enum" yapısı sayıları anlamlı şekilde isimlendirerek kullanabilmeye izin verir.
            //Enumlar Default degeri integer'dir. Ama : koyarak 
            //tam sayi degiskenleri atanabilir

            #region Ogrenci
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Id = 1;
            ogrenci.Ad = "Berkle";
            ogrenci.Soyad = "Yavuz";
            ogrenci.SetTcNo("12345678912");
            //  Console.WriteLine("*******" + ogrenci.GetTcNo()); 
            #endregion

            #region Bigisayar Instance

            //1. Yontem Instance
            AnaKart anaKart = new AnaKart();
            anaKart.RamTipi = RamTipi.DDR2;
            anaKart.Wifi = true;
            anaKart.Fiyat = 120.3f;

            //2. Yontem Instance

            CPU cpu = new ();

            //3. Yontem Instance

            Ram ram = new Ram() 
            {
                Marka = "Kingston",
                Model = "DDR5",
                Kapasite = 8,
                Fiyat = 111.45f
            };

            PowerSupplier powerSupplier = new PowerSupplier()
            {
                Marka = "XYZ",
                Model = "ABC",
                Fiyat = 78
            };

            Kasa kasa = new Kasa()
            {
                Marka = "Asus",
                Model = "ABC",
                PowerSupplier = powerSupplier,
                Fiyat = 90
            };

            // Buradaki Tanimlamada Bilgisayar Nesnesinin ihtiyac duydugu alanlar
            // Daha onceden intance aldigimiz nesnelerden atamasi yapilir

            Bilgisayar bilgisayar = new Bilgisayar()
            {
                Anakart = anaKart,
                BilgisayarTipi = BilgisayarTipi.Ogrenci,
                Cpu = cpu,
                Ram = ram,
                Kasa = kasa,
                Fiyat = 1000
            };

            //2. Yol 

            Bilgisayar bilgisayar1 = new Bilgisayar()
            {
                Anakart = new AnaKart()
                {
                    Marka = "Gigabyte",
                    Model = "QWE",
                    Fiyat = 130
                },
                Cpu = new CPU
                {
                    Marka = "intel",
                    Model = "i9",
                    CoreSayisi = 12,
                    Fiyat = 300
                },
                Kasa = new Kasa
                {
                    Marka = "ASUS",
                    Model = "ZXC",
                    Fiyat = 80,
                    PowerSupplier = new PowerSupplier { Marka = "XYZ" }
                }
            };



            #endregion

            #region Object Veri Tipi

            //Her Turlu Veri Tipini alabilir.Veri Tipi Atasidir.
            object obj = new object();
            obj = DateTime.Now;
            obj = 12;
            obj = "Deneme 123";

            #endregion

        }

        public class Ogrenci
        {
            public int Id;       //Field
            public string Ad;
            public string Soyad;
            public string TcNo;

            //Property =>Ozellik
            public string GSM { get; set; }  //Bos Prop , Kontrolsüz Veri
            public string TcKimlik           //Kontrollü veri atama 
            {
                get
                {
                    return TcNo.Substring(7);
                } 
                
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        Console.WriteLine("TC Alani boş olamaz");
                        return;
                    }

                    foreach (char ch in value)
                    {
                        if (!char.IsDigit(ch))
                        {
                            Console.WriteLine("Girilen ifade icerisinde sayisal olmayan degerler var.");
                        }
                        return;
                    }
                    if (value[0].ToString() == "0")
                    {
                        Console.WriteLine("Tc No 0 ile baslayamaz");
                        return;
                    }
                    if (TcNo.Length==11)
                    {
                        TcNo = value;
                        return;
                    }
                    else
                    {
                        Console.WriteLine("Eksik yada fazla karakter girdiniz.");
                        return;
                    }
                }
            
            }  
            
            //Ogrenci Classinin Methodlarindan
            public void SetTcNo(string tcNo)
            {
                if (tcNo.Length != 11)
                {
                    Console.WriteLine("Eksik yada fazla karakter girdiniz.");
                }

                else if (tcNo.Length==11)
                {
                    TcNo= tcNo;
                }
            }

            public string GetTcNo()
            {
                return TcNo.Substring(7);
            }
        }
    }
}
