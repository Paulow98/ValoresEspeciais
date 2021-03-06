﻿using System;
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

            int a = int.MaxValue;
            short b = short.MaxValue;
            long c = long.MaxValue;

            Console.WriteLine($"Overflow de Int: {a + 6}");
            Console.WriteLine($"Overflow de Short: {b + short.MaxValue + 10}");
            Console.WriteLine($"Overflow de Long: {c + 50}");
            Console.WriteLine();
            float d = float.MaxValue;
            double e = double.MaxValue;

            Console.WriteLine($"Overflow de Float: {d + 2}");
            Console.WriteLine($"Overflow de Double: {e + 2}");
            Console.WriteLine();
            d = float.MinValue;
            e = double.MinValue;
            Console.WriteLine($"Underflow de Float: {d - 2}");
            Console.WriteLine($"Underflow de Double: {e - 2}");

            int x = 0;
            Console.WriteLine($"O valor de x é {x}, mas usando a operacao x++ ele é:{x++}, apos a operacao ele é:{x} ");
            Console.WriteLine($"O valor de x é {x}, mas usando a operação ++x ele é:{++x}, ja mudando seu valor quando apresentado");


            Console.ReadKey();


        }
    }
}
