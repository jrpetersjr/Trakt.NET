﻿namespace TraktApiSharp.Objects.Get.Movies.Json.Factories.Reader
{
    using Get.Movies.Json.Reader;
    using Objects.Json;

    internal class MostPWCMovieJsonReaderFactory : IJsonReaderFactory<ITraktMostPWCMovie>
    {
        public IObjectJsonReader<ITraktMostPWCMovie> CreateObjectReader() => new MostPWCMovieObjectJsonReader();

        public IArrayJsonReader<ITraktMostPWCMovie> CreateArrayReader() => new MostPWCMovieArrayJsonReader();
    }
}