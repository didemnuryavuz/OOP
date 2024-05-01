using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ClassEncapsulation.Mobilyalar
{
    public enum Malzeme
    {
        Ahsap = 1,
        Demir,
        Celik,
        Plastik,
        KarbonFiber
    }
    public class Masa
    {
        public Renk Renk { get; set; }
        public Color Color { get; set; }
        public ConsoleColor Color2 { get; set; }
        public KnownColor KnownColor { get; set; }
        public int AyakSayisi { get; set; }
        public Malzeme Malzeme { get; set; }
    }
}
