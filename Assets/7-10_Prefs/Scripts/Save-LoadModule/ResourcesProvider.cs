using System;
using _7_10_Prefs.Scripts.Save_LoadModule.Base;
using UnityEngine;

namespace _7_10_Prefs.Scripts.Save_LoadModule
{
    public class ResourcesProvider : ITextLoader
    {
        public string LoadText(string fileName)
        {
            TextAsset textAsset = Resources.Load<TextAsset>(fileName);
            
            if (textAsset != null)
            {
                return textAsset.text;
            }
            
            throw new Exception("Failed to load text file: " + fileName);
        }
    }
}