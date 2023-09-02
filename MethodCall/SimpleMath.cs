using System;
using System.Collections.Generic;
using System.Text;

namespace MethodCall
{
    class SimpleMath
    {
        public static int Half(int half)
        {
            half = half / 2;
            return half;
        }

        public static int Double(int doubleNum)
        {
            doubleNum = doubleNum * 2;
            return doubleNum;
        }

        public static int Square(int square)
        {
            square = square * square;
            return square;
        }
    }
}
