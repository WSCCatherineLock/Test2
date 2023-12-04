﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Classic_Snake_Game
{
    internal class Settings
    {

        public static int Width { get; set; }
        public static int Height { get; set; }

        public static string directions;

        public Settings()
        {
            Width = 16;
            Height = 16;
            directions = "left";
        }
    }
}
