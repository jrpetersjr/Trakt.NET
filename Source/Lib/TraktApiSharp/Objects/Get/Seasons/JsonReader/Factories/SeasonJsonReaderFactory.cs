﻿namespace TraktApiSharp.Objects.Get.Seasons.JsonReader.Factories
{
    using Objects.JsonReader;

    internal class SeasonJsonReaderFactory : IJsonReaderFactory<ITraktSeason>
    {
        public IObjectJsonReader<ITraktSeason> CreateObjectReader() => new TraktSeasonObjectJsonReader();

        public IArrayJsonReader<ITraktSeason> CreateArrayReader() => new SeasonArrayJsonReader();
    }
}
