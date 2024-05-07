using _19_OPPGenelTekrar.Loglama.Abstract;
using _19_OPPGenelTekrar.Loglama.Concrete;
using _19_OPPGenelTekrar.Vasita.Abstract;
using _19_OPPGenelTekrar.Vasita.Concrete;

namespace _19_OPPGenelTekrar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Loglama Ornegi
            FileLogger fileLogger = new FileLogger();
            //FileLogger fileLogger = new FileLogger();
            //EmailLooger emailLogger = new EmailLooger();
            //emailLogger.Email = "ali@gmail.com";
            //DatabaseLogger dblogger  = new DatabaseLogger();

            //ILogger fileLogger1 = new FileLogger();
            //ILogger emailLogger1 = new EmailLooger();
            //emailLogger1.Logla("DEneme");
            ILogger dblogger1 = new DatabaseLogger();
            //Logger logger = new Logger(fileLogger);

            //Logger logger1 = new Logger(emailLooger);
            //logger.Logolustur("Test");
            //SmsLogger smsLogger = new SmsLogger();  

            //NewLogger logger = new(fileLogger);
            //NewLogger logger1 = new(emailLogger);
            //NewLogger logger3 = new(dblogger);
            //NewLogger logger4 = new(smsLogger);



            #endregion

            #region Kaptan Sofor Ve Vasita Ornegi
            Otomobil reno = new Otomobil();
            Minibus transporter = new Minibus();
            Otobus mercedes = new Otobus();
            Tir volvo = new Tir();

            #region Interface Kullanamadan onceki durum
            //Sofor sofor1 = new(reno);
            //Sofor sofor2 = new(transporter);
            //Sofor sofor3 = new(mercedes);
            //Sofor sofor4 = new(volvo); 
            #endregion

            #region Interface ile NewSofor Kullanimi
            ICollection<ISurulebilir> araclar = new HashSet<ISurulebilir>();
            araclar.Add(volvo);
            araclar.Add(mercedes);
            araclar.Add(transporter);
            araclar.Add(reno);
            NewSofor makamsofor1 = new NewSofor(reno) { EhliyetTipi = EhliyetTipi.B };
            makamsofor1.AracKullan();

            NewSofor genelSofor = new NewSofor(araclar) { EhliyetTipi = EhliyetTipi.C };

            genelSofor.AraclariKullan();
            #endregion
            #endregion
        }
    }
}

