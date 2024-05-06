using _13_OtomobilInterface.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_OtomobilInterface.Concrete
{
    public class Otomobil : BaseOtomobil 
    {
        public List<IKonfor> Konfors { get; set; }
        public List<IMultiMedya> MultiMedyas { get; set; }
        public List<IGuvenlik> Guvenliks { get; set; }

    }
}
