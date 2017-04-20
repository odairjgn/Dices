using System;
using System.Collections.Generic;
using System.IO;
using DicesCore.Extensoes;

namespace DicesCore
{
    public class Global
    {
        public const int MaxBytes = 1073741823;
        private const string RootFolder = "Dices";
        private const string DBFolder = "Database";

        public static string RootDirectory => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), RootFolder).GarantirExistenciaPasta();
        public static string DatabaseDirectory => Path.Combine(RootDirectory, DBFolder).GarantirExistenciaPasta();

        public static string ConfigFile => Path.Combine(RootDirectory, "Config.xml");
        public static string DbFile => Path.Combine(DatabaseDirectory, "DicesDatabase.sdf");

        public static Dictionary<string, double> Variaveis = new Dictionary<string, double>();
        public static DicesCore.Contexto.DicesContext Contexto { get; set; }
        public static IEnumerable<string> FontesValidas { get; set; }
    }
}
