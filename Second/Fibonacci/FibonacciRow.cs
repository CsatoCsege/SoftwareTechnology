using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class FibonacciRow
    {
        //sima változó public int Index
        //propfull -születésből életkor kiszamítasa
        public int Index { get; set; } //proberty
        public int Value { get; set; }
        public string BUTA { get; set; }
        //ctor -kontruktor methodus, neve = osztaly neve, mindig public, nincs viszatérési érték
        //kezdő értékek beállitas
        public FibonacciRow()
        {
            BUTA = "😀";
        }
        public FibonacciRow(int index, int value)
        {
            Index = index;
            Value = value;
            BUTA = "SZEX";
        }
    }
}
