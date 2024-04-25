using System;

namespace _13_15_JSON_Web.Scripts.DataStructures
{
    [Serializable]
    public class Data
    {
        public string id;
        public string type;
        public Attributes attributes;

        public override string ToString()
        {
            return $"Id: {id}\nType: {type}\nAttributes: {attributes}";
        }
    }
}