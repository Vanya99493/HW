using System;

namespace _13_15_JSON_Web.Scripts.DataStructures
{
    [Serializable]
    public class Attributes
    {
        public Airport airport;
        public string note;

        public override string ToString()
        {
            return $"\n\tAirport: {airport}\n\tNote: {note}";
        }
    }
}