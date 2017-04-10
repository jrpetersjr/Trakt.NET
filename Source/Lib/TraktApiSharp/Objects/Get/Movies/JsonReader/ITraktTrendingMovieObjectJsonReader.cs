﻿namespace TraktApiSharp.Objects.Get.Movies.JsonReader
{
    using Implementations;
    using Newtonsoft.Json;
    using Objects.Get.Movies;
    using Objects.JsonReader;
    using System;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    internal class ITraktTrendingMovieObjectJsonReader : ITraktObjectJsonReader<ITraktTrendingMovie>
    {
        private const string PROPERTY_NAME_WATCHERS = "watchers";
        private const string PROPERTY_NAME_MOVIE = "movie";

        public Task<ITraktTrendingMovie> ReadObjectAsync(string json, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (string.IsNullOrEmpty(json))
                return Task.FromResult(default(ITraktTrendingMovie));

            using (var reader = new StringReader(json))
            using (var jsonReader = new JsonTextReader(reader))
            {
                return ReadObjectAsync(jsonReader, cancellationToken);
            }
        }

        public Task<ITraktTrendingMovie> ReadObjectAsync(Stream stream, CancellationToken cancellationToken = default(CancellationToken))
        {
            throw new NotImplementedException();
        }

        public async Task<ITraktTrendingMovie> ReadObjectAsync(JsonTextReader jsonReader, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (jsonReader == null)
                return await Task.FromResult(default(ITraktTrendingMovie));

            if (await jsonReader.ReadAsync(cancellationToken) && jsonReader.TokenType == JsonToken.StartObject)
            {
                var movieObjectReader = new ITraktMovieObjectJsonReader();
                ITraktTrendingMovie traktTrendingMovie = new TraktTrendingMovie();

                while (await jsonReader.ReadAsync(cancellationToken) && jsonReader.TokenType == JsonToken.PropertyName)
                {
                    var propertyName = jsonReader.Value.ToString();

                    switch (propertyName)
                    {
                        case PROPERTY_NAME_WATCHERS:
                            traktTrendingMovie.Watchers = await jsonReader.ReadAsInt32Async(cancellationToken);
                            break;
                        case PROPERTY_NAME_MOVIE:
                            traktTrendingMovie.Movie = await movieObjectReader.ReadObjectAsync(jsonReader, cancellationToken);
                            break;
                        default:
                            await JsonReaderHelper.ReadAndIgnoreInvalidContentAsync(jsonReader, cancellationToken);
                            break;
                    }
                }

                return traktTrendingMovie;
            }

            return await Task.FromResult(default(ITraktTrendingMovie));
        }
    }
}