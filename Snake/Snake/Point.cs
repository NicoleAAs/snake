﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Point
    {
        public int x, y;
        public char sym;

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
