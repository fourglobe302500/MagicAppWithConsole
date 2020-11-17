using System.Collections.Generic;
using System;
using MagicLib;
using System.Linq;
using MagicLib.DataAcess;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            int widthSize = 120;
            int heightSize = 30;
            Console.SetWindowSize(widthSize, heightSize);
            Console.SetBufferSize(widthSize, heightSize);
            Console.ForegroundColor = ConsoleColor.Cyan;
        }
    }
}
