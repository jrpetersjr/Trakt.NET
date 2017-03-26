﻿namespace TraktApiSharp.Objects.JsonReader.Get.Seasons
{
    using Newtonsoft.Json;
    using Objects.Get.Seasons;
    using System.Collections.Generic;
    using System.IO;
    using TraktApiSharp.Objects.Get.Seasons.Implementations;

    internal class TraktSeasonArrayJsonReader : ITraktArrayJsonReader<TraktSeason>
    {
        public IEnumerable<TraktSeason> ReadArray(string json)
        {
            if (string.IsNullOrEmpty(json))
                return null;

            using (var reader = new StringReader(json))
            using (var jsonReader = new JsonTextReader(reader))
            {
                return ReadArray(jsonReader);
            }
        }

        public IEnumerable<TraktSeason> ReadArray(JsonTextReader jsonReader)
        {
            if (jsonReader == null)
                return null;

            if (jsonReader.Read() && jsonReader.TokenType == JsonToken.StartArray)
            {
                var seasonReader = new TraktSeasonObjectJsonReader();
                var traktSeasons = new List<TraktSeason>();

                var traktSeason = seasonReader.ReadObject(jsonReader);

                while (traktSeason != null)
                {
                    traktSeasons.Add(traktSeason);
                    traktSeason = seasonReader.ReadObject(jsonReader);
                }

                return traktSeasons;
            }

            return null;
        }
    }
}
