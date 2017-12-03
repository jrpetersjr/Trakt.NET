﻿namespace TraktApiSharp.Objects.Basic.Json.Factories.Reader
{
    using Objects.Basic.Json.Reader;
    using Objects.Json;
    using System;

    internal class StatisticsJsonReaderFactory : IJsonReaderFactory<ITraktStatistics>
    {
        public IObjectJsonReader<ITraktStatistics> CreateObjectReader() => new StatisticsObjectJsonReader();

        public IArrayJsonReader<ITraktStatistics> CreateArrayReader()
        {
            throw new NotSupportedException($"A array json reader for {nameof(ITraktStatistics)} is not supported.");
        }
    }
}