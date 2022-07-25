﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FFXIVHSLib
{
    /// <summary>
    /// Class that handles paths used by both WPF and Unity.<br />
    /// Any path that is a directory will end with "Directory", and the
    /// returned string will end with a '\' backslash.<br />
    /// It is safe to assume that if a directory is returned, then it exists.
    /// </summary>
    public static class FFXIVHSPaths
    {
        //TODO decide on a main path or make it like a setting or something
        private const string root = @"C:\Users\choco\Documents\HousingSim\Out";
        private const string GameDirectory = @"C:\Program Files (x86)\SquareEnix\FINAL FANTASY XIV - A Realm Reborn\";

        private static void CreateDirectoryIfNotExists(string path)
        {
            if (!Directory.Exists(path))
                Directory.CreateDirectory(path);
        }

        public static string GetGameDirectory()
        {
            //If this doesn't exist just stop messing with me.
            return GameDirectory;
        }

        public static string GetRootDirectory()
        {
            CreateDirectoryIfNotExists(root);
            return root;
        }

        public static string GetWardSettingsJson()
        {
            string path = Path.Combine(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\")), "WardSettings.json");

            return path;
        }

        public static string GetWardInfoJson()
        {
            string path = Path.Combine(GetRootDirectory(), "WardInfo.json");

            return path;
        }

        public static string GetTerritoryDirectory(Territory territory)
        {
            string path = Path.Combine(root, territory.ToString().ToLowerInvariant() + "\\");

            CreateDirectoryIfNotExists(path);

            return path;
        }

        public static string GetTerritoryDirectory(string territory)
        {
            string path = Path.Combine(root, territory.ToLowerInvariant() + "\\");

            CreateDirectoryIfNotExists(path);

            return path;
        }

        public static string GetTerritoryObjectsDirectory(Territory territory)
        {
            string path = Path.Combine(GetTerritoryDirectory(territory), "objects\\");

            CreateDirectoryIfNotExists(path);

            return path;
        }

        public static string GetTerritoryObjectsDirectory(string territory)
        {
            string path = Path.Combine(GetTerritoryDirectory(territory), "objects\\");

            CreateDirectoryIfNotExists(path);

            return path;
        }

        public static string GetTerritoryJson(string territory)
        {
            string path = Path.Combine(GetTerritoryDirectory(territory), territory.ToLowerInvariant() + ".json");

            return path;
        }

        public static string GetTerritoryJson(Territory territory)
        {
            string path = Path.Combine(GetTerritoryDirectory(territory), territory.ToString().ToLowerInvariant() + ".json");

            return path;
        }

        public static string GetWardLandsetJson(Territory territory)
        {
            string path = Path.Combine(GetTerritoryDirectory(territory), "Landset.json");

            return path;
        }

        public static string GetHousingExteriorDirectory()
        {
            string path = Path.Combine(root, "HousingExterior\\");

            CreateDirectoryIfNotExists(path);

            return path;
        }

        public static string GetHousingExteriorObjectsDirectory()
        {
            string path = Path.Combine(GetHousingExteriorDirectory(), "objects\\");

            CreateDirectoryIfNotExists(path);

            return path;
        }

        public static string GetHousingExteriorJson()
        {
            string path = Path.Combine(GetHousingExteriorDirectory(), "HousingExterior.json");

            return path;
        }

        public static string GetHousingExteriorBlueprintSetJson()
        {
            string path = Path.Combine(GetHousingExteriorDirectory(), "HousingExteriorBlueprintSet.json");

            return path;
        }
    }
}
