﻿namespace TraktApiSharp.Objects.Get.Seasons.Json.Factories
{
    using Get.Seasons.Json.Reader;
    using Objects.Json;

    internal class SeasonWatchedProgressJsonReaderFactory : IJsonIOFactory<ITraktSeasonWatchedProgress>
    {
        public IObjectJsonReader<ITraktSeasonWatchedProgress> CreateObjectReader() => new SeasonWatchedProgressObjectJsonReader();

        public IArrayJsonReader<ITraktSeasonWatchedProgress> CreateArrayReader() => new SeasonWatchedProgressArrayJsonReader();

        public IObjectJsonReader<ITraktSeasonWatchedProgress> CreateObjectWriter()
        {
            throw new System.NotImplementedException();
        }

        public IArrayJsonReader<ITraktSeasonWatchedProgress> CreateArrayWriter()
        {
            throw new System.NotImplementedException();
        }
    }
}
