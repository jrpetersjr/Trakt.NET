﻿namespace TraktApiSharp.Objects.Post.Syncs.Collection.Responses.Json.Factories.Reader
{
    using Objects.Json;
    using Post.Syncs.Collection.Responses.Json.Reader;
    using System;

    internal class SyncCollectionRemovePostResponseJsonReaderFactory : IJsonReaderFactory<ITraktSyncCollectionRemovePostResponse>
    {
        public IObjectJsonReader<ITraktSyncCollectionRemovePostResponse> CreateObjectReader() => new SyncCollectionRemovePostResponseObjectJsonReader();

        public IArrayJsonReader<ITraktSyncCollectionRemovePostResponse> CreateArrayReader()
        {
            throw new NotSupportedException($"A array json reader for {nameof(ITraktSyncCollectionRemovePostResponse)} is not supported.");
        }
    }
}