using System;
using System.IO;
using _7_10_Prefs.Scripts.Save_LoadModule.Base;
using UnityEngine;

namespace _7_10_Prefs.Scripts.Save_LoadModule
{
    public class PersistentDataProvider : ITextLoader, ITextSaver
    {
        public string LoadText(string fileName)
        {
            string filePath = $"{Application.persistentDataPath}/{fileName}";
            
            if (File.Exists(filePath))
            {
                string fileContents = File.ReadAllText(filePath);
                return fileContents;
            }

            throw new Exception("Failed loading. \nFile path: " + filePath);
        }

        public void Save(string fileName, string text)
        {
            string filePath = $"{Application.persistentDataPath}/{fileName}";
            File.WriteAllText(filePath, text);
        }
    }
}