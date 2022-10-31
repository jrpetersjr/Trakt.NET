﻿namespace TraktNet.Objects.Get.Tests.Movies.Json.Reader
{
    using FluentAssertions;
    using Newtonsoft.Json;
    using System;
    using System.IO;
    using System.Threading.Tasks;
    using Trakt.NET.Tests.Utility.Traits;
    using TraktNet.Objects.Get.Movies;
    using TraktNet.Objects.Get.Movies.Json.Reader;
    using Xunit;

    [TestCategory("Objects.Get.Movies.JsonReader")]
    public partial class BoxOfficeMovieObjectJsonReader_Tests
    {
        [Fact]
        public async Task Test_BoxOfficeMovieObjectJsonReader_ReadObject_From_JsonReader_Complete()
        {
            var traktJsonReader = new BoxOfficeMovieObjectJsonReader();

            using (var reader = new StringReader(JSON_COMPLETE))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var traktBoxOfficeMovie = await traktJsonReader.ReadObjectAsync(jsonReader);

                traktBoxOfficeMovie.Should().NotBeNull();
                traktBoxOfficeMovie.Revenue.Should().Be(166007347);
                traktBoxOfficeMovie.Movie.Should().NotBeNull();
                traktBoxOfficeMovie.Movie.Title.Should().Be("Star Wars: The Force Awakens");
                traktBoxOfficeMovie.Movie.Year.Should().Be(2015);
                traktBoxOfficeMovie.Movie.Ids.Should().NotBeNull();
                traktBoxOfficeMovie.Movie.Ids.Trakt.Should().Be(94024U);
                traktBoxOfficeMovie.Movie.Ids.Slug.Should().Be("star-wars-the-force-awakens-2015");
                traktBoxOfficeMovie.Movie.Ids.Imdb.Should().Be("tt2488496");
                traktBoxOfficeMovie.Movie.Ids.Tmdb.Should().Be(140607U);
            }
        }

        [Fact]
        public async Task Test_BoxOfficeMovieObjectJsonReader_ReadObject_From_JsonReader_Incomplete_1()
        {
            var traktJsonReader = new BoxOfficeMovieObjectJsonReader();

            using (var reader = new StringReader(JSON_INCOMPLETE_1))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var traktBoxOfficeMovie = await traktJsonReader.ReadObjectAsync(jsonReader);

                traktBoxOfficeMovie.Should().NotBeNull();
                traktBoxOfficeMovie.Revenue.Should().Be(166007347);
                traktBoxOfficeMovie.Movie.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_BoxOfficeMovieObjectJsonReader_ReadObject_From_JsonReader_Incomplete_2()
        {
            var traktJsonReader = new BoxOfficeMovieObjectJsonReader();

            using (var reader = new StringReader(JSON_INCOMPLETE_2))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var traktBoxOfficeMovie = await traktJsonReader.ReadObjectAsync(jsonReader);

                traktBoxOfficeMovie.Should().NotBeNull();
                traktBoxOfficeMovie.Revenue.Should().BeNull();
                traktBoxOfficeMovie.Movie.Should().NotBeNull();
                traktBoxOfficeMovie.Movie.Title.Should().Be("Star Wars: The Force Awakens");
                traktBoxOfficeMovie.Movie.Year.Should().Be(2015);
                traktBoxOfficeMovie.Movie.Ids.Should().NotBeNull();
                traktBoxOfficeMovie.Movie.Ids.Trakt.Should().Be(94024U);
                traktBoxOfficeMovie.Movie.Ids.Slug.Should().Be("star-wars-the-force-awakens-2015");
                traktBoxOfficeMovie.Movie.Ids.Imdb.Should().Be("tt2488496");
                traktBoxOfficeMovie.Movie.Ids.Tmdb.Should().Be(140607U);
            }
        }

        [Fact]
        public async Task Test_BoxOfficeMovieObjectJsonReader_ReadObject_From_JsonReader_Not_Valid_1()
        {
            var traktJsonReader = new BoxOfficeMovieObjectJsonReader();

            using (var reader = new StringReader(JSON_NOT_VALID_1))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var traktBoxOfficeMovie = await traktJsonReader.ReadObjectAsync(jsonReader);

                traktBoxOfficeMovie.Should().NotBeNull();
                traktBoxOfficeMovie.Revenue.Should().BeNull();
                traktBoxOfficeMovie.Movie.Should().NotBeNull();
                traktBoxOfficeMovie.Movie.Title.Should().Be("Star Wars: The Force Awakens");
                traktBoxOfficeMovie.Movie.Year.Should().Be(2015);
                traktBoxOfficeMovie.Movie.Ids.Should().NotBeNull();
                traktBoxOfficeMovie.Movie.Ids.Trakt.Should().Be(94024U);
                traktBoxOfficeMovie.Movie.Ids.Slug.Should().Be("star-wars-the-force-awakens-2015");
                traktBoxOfficeMovie.Movie.Ids.Imdb.Should().Be("tt2488496");
                traktBoxOfficeMovie.Movie.Ids.Tmdb.Should().Be(140607U);
            }
        }

        [Fact]
        public async Task Test_BoxOfficeMovieObjectJsonReader_ReadObject_From_JsonReader_Not_Valid_2()
        {
            var traktJsonReader = new BoxOfficeMovieObjectJsonReader();

            using (var reader = new StringReader(JSON_NOT_VALID_2))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var traktBoxOfficeMovie = await traktJsonReader.ReadObjectAsync(jsonReader);

                traktBoxOfficeMovie.Should().NotBeNull();
                traktBoxOfficeMovie.Revenue.Should().Be(166007347);
                traktBoxOfficeMovie.Movie.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_BoxOfficeMovieObjectJsonReader_ReadObject_From_JsonReader_Not_Valid_3()
        {
            var traktJsonReader = new BoxOfficeMovieObjectJsonReader();

            using (var reader = new StringReader(JSON_NOT_VALID_3))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var traktBoxOfficeMovie = await traktJsonReader.ReadObjectAsync(jsonReader);

                traktBoxOfficeMovie.Should().NotBeNull();
                traktBoxOfficeMovie.Revenue.Should().BeNull();
                traktBoxOfficeMovie.Movie.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_BoxOfficeMovieObjectJsonReader_ReadObject_From_JsonReader_Null()
        {
            var traktJsonReader = new BoxOfficeMovieObjectJsonReader();
            Func<Task<ITraktBoxOfficeMovie>> traktBoxOfficeMovie = () => traktJsonReader.ReadObjectAsync(default(JsonTextReader));
            await traktBoxOfficeMovie.Should().ThrowAsync<ArgumentNullException>();
        }

        [Fact]
        public async Task Test_BoxOfficeMovieObjectJsonReader_ReadObject_From_JsonReader_Empty()
        {
            var traktJsonReader = new BoxOfficeMovieObjectJsonReader();

            using (var reader = new StringReader(string.Empty))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var traktBoxOfficeMovie = await traktJsonReader.ReadObjectAsync(jsonReader);
                traktBoxOfficeMovie.Should().BeNull();
            }
        }
    }
}
