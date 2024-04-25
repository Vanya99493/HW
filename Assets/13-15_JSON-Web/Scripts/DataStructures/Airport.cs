using System;

namespace _13_15_JSON_Web.Scripts.DataStructures
{
    [Serializable]
    public class Airport
    {
        public int id;
        public string name;
        public string city;
        public string country;
        public string iata;
        public string icao;
        public string latitude;
        public string longitude;
        public int altitude;
        public string timezone;

        public override string ToString()
        {
            return $"\n\t\tId: {id}" +
                   $"\n\t\tName: {name}" +
                   $"\n\t\tCity: {city}" +
                   $"\n\t\tCountry: {country}" +
                   $"\n\t\tIATA: {iata}" +
                   $"\n\t\tICAO: {icao}" +
                   $"\n\t\tLatitude: {latitude}" +
                   $"\n\t\tLongitude: {longitude}" +
                   $"\n\t\tAltitude: {altitude}" +
                   $"\n\t\tTimeZone: {timezone}";
        }
    }
}