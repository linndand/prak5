using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prak5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
            numbers.CariNilaiMin(20, 21);
            numbers.CariNilaiMin(100, 20, 11);
            numbers.CariNilaiMax(20, 21);
            numbers.CariNilaiMax(100, 20, 11);
        }
    }
}
