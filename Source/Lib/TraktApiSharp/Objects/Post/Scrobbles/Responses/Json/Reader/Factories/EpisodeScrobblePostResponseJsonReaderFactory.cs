﻿namespace TraktApiSharp.Objects.Post.Scrobbles.Responses.Json.Factories.Reader
{
    using Objects.Json;
    using Post.Scrobbles.Responses.Json.Reader;
    using System;

    internal class EpisodeScrobblePostResponseJsonReaderFactory : IJsonReaderFactory<ITraktEpisodeScrobblePostResponse>
    {
        public IObjectJsonReader<ITraktEpisodeScrobblePostResponse> CreateObjectReader() => new EpisodeScrobblePostResponseObjectJsonReader();

        public IArrayJsonReader<ITraktEpisodeScrobblePostResponse> CreateArrayReader()
        {
            throw new NotSupportedException($"A array json reader for {nameof(ITraktEpisodeScrobblePostResponse)} is not supported.");
        }
    }
}