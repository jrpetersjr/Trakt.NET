﻿namespace TraktApiSharp.Objects.Post.Syncs.History.Responses.Json.Factories.Reader
{
    using Objects.Json;
    using Post.Syncs.History.Responses.Json.Reader;
    using System;

    internal class SyncHistoryRemovePostResponseNotFoundGroupJsonReaderFactory : IJsonReaderFactory<ITraktSyncHistoryRemovePostResponseNotFoundGroup>
    {
        public IObjectJsonReader<ITraktSyncHistoryRemovePostResponseNotFoundGroup> CreateObjectReader() => new SyncHistoryRemovePostResponseNotFoundGroupObjectJsonReader();

        public IArrayJsonReader<ITraktSyncHistoryRemovePostResponseNotFoundGroup> CreateArrayReader()
        {
            throw new NotSupportedException($"A array json reader for {nameof(ITraktSyncHistoryRemovePostResponseNotFoundGroup)} is not supported.");
        }
    }
}