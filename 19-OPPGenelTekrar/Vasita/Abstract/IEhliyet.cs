using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_OPPGenelTekrar.Vasita.Abstract
{
    public enum EhliyetTipi
    {
        A=1,
        B=2, 
        C=3, 
        D=4,
        E=5
    }
    public interface IEhliyet
    {
        public EhliyetTipi EhliyetTipi { get; set; }
        public bool EhliyetVarmi { get; set; }
    }
}
