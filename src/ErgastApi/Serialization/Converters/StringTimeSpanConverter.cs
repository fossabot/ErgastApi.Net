﻿using System;
using Newtonsoft.Json;

namespace ErgastApi.Serialization.Converters
{
    public class StringTimeSpanConverter : JsonConverter
    {
        private static readonly string[] Formats =
        {
            "hh':'mm':'ss",
            "hh':'mm':'ss'.'fff",
            "h':'mm':'ss'.'fff",
            "mm':'ss'.'fff",
            "m':'ss'.'fff"
        };

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType != JsonToken.String)
                throw new JsonException($"Wrong token type '{reader.TokenType}' for reading TimeStamp in format 'hh:mm:ss.fff'.");

            var value = (string) reader.Value;

            TimeSpan result;
            if (TimeSpan.TryParseExact(value, Formats, null, out result))
                return result;

            return null;
        }

        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }
    }
}
