using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("int: " + "Min:" + int.MinValue + " Max: " + int.MaxValue);
            Console.WriteLine("uint: " + "Min:" + uint.MinValue + " Max: " + uint.MaxValue);
            Console.WriteLine("short: " + "Min:" + short.MinValue + " Max: " + short.MaxValue);
            Console.WriteLine("ushort: " + "Min:" + ushort.MinValue + " Max: " + ushort.MaxValue);
            Console.WriteLine("byte: " + "Min:" + byte.MinValue + " Max: " + byte.MaxValue);
            Console.WriteLine("sbyte: " + "Min:" + sbyte.MinValue + " Max: " + sbyte.MaxValue);
            Console.WriteLine("float: " + "Min:" + float.MinValue + " Max: " + float.MaxValue);
            Console.WriteLine("decimal: " + "Min:" + decimal.MinValue + " Max: " + decimal.MaxValue);
            Console.WriteLine("double: " + "Min:" + double.MinValue + " Max: " + double.MaxValue);
            Console.WriteLine("long: " + "Min:" + long.MinValue + " Max: " + long.MaxValue);
            Console.WriteLine("ulong: " + "Min:" + ulong.MinValue + " Max: " + ulong.MaxValue);
            Console.WriteLine("char: " + "Min:" + char.MinValue + " Max: " + char.MaxValue);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Float negative infinity:" + float.NegativeInfinity + " positive infinity:" + float.PositiveInfinity + " NaN:" + float.NaN);
            Console.WriteLine("Double negative infinity:" + double.NegativeInfinity + " positive infinity:" + double.PositiveInfinity + " NaN:" + double.NaN);



        }
    }
}
