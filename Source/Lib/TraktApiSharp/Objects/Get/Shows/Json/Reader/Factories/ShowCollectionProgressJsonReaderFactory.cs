﻿namespace TraktApiSharp.Objects.Get.Shows.Json.Factories.Reader
{
    using Get.Shows.Json.Reader;
    using Objects.Json;
    using System;

    internal class ShowCollectionProgressJsonReaderFactory : IJsonReaderFactory<ITraktShowCollectionProgress>
    {
        public IObjectJsonReader<ITraktShowCollectionProgress> CreateObjectReader() => new ShowCollectionProgressObjectJsonReader();

        public IArrayJsonReader<ITraktShowCollectionProgress> CreateArrayReader()
        {
            throw new NotSupportedException($"A array json reader for {nameof(ITraktShowCollectionProgress)} is not supported.");
        }
    }
}