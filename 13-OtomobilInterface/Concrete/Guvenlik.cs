using _13_OtomobilInterface.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_OtomobilInterface.Concrete
{
    public class Guvenlik :  IGuvenlik
    {
        public void OtomatikFrenYap()
        {
            Console.WriteLine("Otomatik Fren Yapabilir");
        }

        public void SeritTakipEt()
        {
            Console.WriteLine("Şerit Takip Sistemi Var");
        }

        public void UykuKontrolEt()
        {
            Console.WriteLine("Uyku Kontrol Edebilir");
        }
    }
}
