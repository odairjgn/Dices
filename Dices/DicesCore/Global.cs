﻿using System;
using System.Collections.Generic;
using System.IO;

namespace DicesCore
{
    public class Global
    {
        public const int MaxBytes = 1073741823;

        public static string ConfigFile
        {
            get
            {
                var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Dices", "Config.xml");

                var fi = new FileInfo(path);

                if (!fi.Directory?.Exists ?? true)
                    fi.Directory.Create();

                return path;
            }
        }

        public static Dictionary<string, double> Variaveis = new Dictionary<string, double>();
        public static DicesCore.Contexto.DicesContext Contexto { get; set; }
        public static IEnumerable<string> FontesValidas { get; set; }
    }
}