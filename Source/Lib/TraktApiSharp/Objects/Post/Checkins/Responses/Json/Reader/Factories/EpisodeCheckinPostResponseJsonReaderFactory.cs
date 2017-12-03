﻿namespace TraktApiSharp.Objects.Post.Checkins.Responses.Json.Factories.Reader
{
    using Objects.Json;
    using Post.Checkins.Responses.Json.Reader;
    using System;

    internal class EpisodeCheckinPostResponseJsonReaderFactory : IJsonReaderFactory<ITraktEpisodeCheckinPostResponse>
    {
        public IObjectJsonReader<ITraktEpisodeCheckinPostResponse> CreateObjectReader() => new EpisodeCheckinPostResponseObjectJsonReader();

        public IArrayJsonReader<ITraktEpisodeCheckinPostResponse> CreateArrayReader()
        {
            throw new NotSupportedException($"A array json reader for {nameof(ITraktEpisodeCheckinPostResponse)} is not supported.");
        }
    }
}