using _18_GenericRepository.Okul.Abstract;
using _18_GenericRepository.Okul.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_GenericRepository.Okul.Manager
{
    public class OgrenciManager :BaseManager<Ogrenci,int>
    {
        public override void Delete(Ogrenci entity)
        {
            if (entity==null )
            {
                Console.WriteLine("Silinecek Kayit Bulunamadi");
            }
            if (entity.BorcuVarMi==true)
            {
                Console.WriteLine("Borcu nedeniyle Kayit Silinemez ");
            }
            else
            {
                base.Delete(entity);
            }
        }
    }

}
