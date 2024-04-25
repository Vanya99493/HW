using _7_10_Prefs.Scripts.Save_LoadModule.Base;
using UnityEngine;

namespace _7_10_Prefs.Scripts.Save_LoadModule
{
    public class PlayerPrefsProvider : ITextLoader, ITextSaver
    {
        public string LoadText(string keyName)
        {
            return PlayerPrefs.GetString(keyName);
        }

        public void Save(string keyName, string text)
        {
            PlayerPrefs.SetString(keyName, text);
        }
    }
}