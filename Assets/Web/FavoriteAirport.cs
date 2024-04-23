using System;
using System.Collections.Generic;

namespace Web
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
            return $"\n\t\tId: {id}\n\t\tName: {name}\n\t\tCity: {city}";
        }
    }

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
    
    [Serializable]
    public class RootObject
    {
        public List<Data> data;
    }
}