﻿namespace TraktApiSharp.Tests.Objects.Get.People.Credits.JsonReader
{
    using FluentAssertions;
    using System.IO;
    using System.Threading.Tasks;
    using TestUtils;
    using Traits;
    using TraktApiSharp.Objects.Get.People.Credits.JsonReader;
    using Xunit;

    [Category("Objects.Get.People.Credits.JsonReader")]
    public partial class TraktPersonMovieCreditsCrewItemObjectJsonReader_Tests
    {
        [Fact]
        public async Task Test_TraktPersonMovieCreditsCrewItemObjectJsonReader_ReadObject_From_Stream_Complete()
        {
            var jsonReader = new TraktPersonMovieCreditsCrewItemObjectJsonReader();

            using (var stream = JSON_COMPLETE.ToStream())
            {
                var movieCreditsCrewItem = await jsonReader.ReadObjectAsync(stream);

                movieCreditsCrewItem.Should().NotBeNull();
                movieCreditsCrewItem.Job.Should().Be("Director");
                movieCreditsCrewItem.Movie.Should().NotBeNull();
                movieCreditsCrewItem.Movie.Title.Should().Be("Star Wars: The Force Awakens");
                movieCreditsCrewItem.Movie.Year.Should().Be(2015);
                movieCreditsCrewItem.Movie.Ids.Should().NotBeNull();
                movieCreditsCrewItem.Movie.Ids.Trakt.Should().Be(94024U);
                movieCreditsCrewItem.Movie.Ids.Slug.Should().Be("star-wars-the-force-awakens-2015");
                movieCreditsCrewItem.Movie.Ids.Imdb.Should().Be("tt2488496");
                movieCreditsCrewItem.Movie.Ids.Tmdb.Should().Be(140607U);
            }
        }

        [Fact]
        public async Task Test_TraktPersonMovieCreditsCrewItemObjectJsonReader_ReadObject_From_Stream_Incomplete_1()
        {
            var jsonReader = new TraktPersonMovieCreditsCrewItemObjectJsonReader();

            using (var stream = JSON_INCOMPLETE_1.ToStream())
            {
                var movieCreditsCrewItem = await jsonReader.ReadObjectAsync(stream);

                movieCreditsCrewItem.Should().NotBeNull();
                movieCreditsCrewItem.Job.Should().BeNull();
                movieCreditsCrewItem.Movie.Should().NotBeNull();
                movieCreditsCrewItem.Movie.Title.Should().Be("Star Wars: The Force Awakens");
                movieCreditsCrewItem.Movie.Year.Should().Be(2015);
                movieCreditsCrewItem.Movie.Ids.Should().NotBeNull();
                movieCreditsCrewItem.Movie.Ids.Trakt.Should().Be(94024U);
                movieCreditsCrewItem.Movie.Ids.Slug.Should().Be("star-wars-the-force-awakens-2015");
                movieCreditsCrewItem.Movie.Ids.Imdb.Should().Be("tt2488496");
                movieCreditsCrewItem.Movie.Ids.Tmdb.Should().Be(140607U);
            }
        }

        [Fact]
        public async Task Test_TraktPersonMovieCreditsCrewItemObjectJsonReader_ReadObject_From_Stream_Incomplete_2()
        {
            var jsonReader = new TraktPersonMovieCreditsCrewItemObjectJsonReader();

            using (var stream = JSON_INCOMPLETE_2.ToStream())
            {
                var movieCreditsCrewItem = await jsonReader.ReadObjectAsync(stream);

                movieCreditsCrewItem.Should().NotBeNull();
                movieCreditsCrewItem.Job.Should().Be("Director");
                movieCreditsCrewItem.Movie.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_TraktPersonMovieCreditsCrewItemObjectJsonReader_ReadObject_From_Stream_Not_Valid_1()
        {
            var jsonReader = new TraktPersonMovieCreditsCrewItemObjectJsonReader();

            using (var stream = JSON_NOT_VALID_1.ToStream())
            {
                var movieCreditsCrewItem = await jsonReader.ReadObjectAsync(stream);

                movieCreditsCrewItem.Should().NotBeNull();
                movieCreditsCrewItem.Job.Should().BeNull();
                movieCreditsCrewItem.Movie.Should().NotBeNull();
                movieCreditsCrewItem.Movie.Title.Should().Be("Star Wars: The Force Awakens");
                movieCreditsCrewItem.Movie.Year.Should().Be(2015);
                movieCreditsCrewItem.Movie.Ids.Should().NotBeNull();
                movieCreditsCrewItem.Movie.Ids.Trakt.Should().Be(94024U);
                movieCreditsCrewItem.Movie.Ids.Slug.Should().Be("star-wars-the-force-awakens-2015");
                movieCreditsCrewItem.Movie.Ids.Imdb.Should().Be("tt2488496");
                movieCreditsCrewItem.Movie.Ids.Tmdb.Should().Be(140607U);
            }
        }

        [Fact]
        public async Task Test_TraktPersonMovieCreditsCrewItemObjectJsonReader_ReadObject_From_Stream_Not_Valid_2()
        {
            var jsonReader = new TraktPersonMovieCreditsCrewItemObjectJsonReader();

            using (var stream = JSON_NOT_VALID_2.ToStream())
            {
                var movieCreditsCrewItem = await jsonReader.ReadObjectAsync(stream);

                movieCreditsCrewItem.Should().NotBeNull();
                movieCreditsCrewItem.Job.Should().Be("Director");
                movieCreditsCrewItem.Movie.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_TraktPersonMovieCreditsCrewItemObjectJsonReader_ReadObject_From_Stream_Not_Valid_3()
        {
            var jsonReader = new TraktPersonMovieCreditsCrewItemObjectJsonReader();

            using (var stream = JSON_NOT_VALID_3.ToStream())
            {
                var movieCreditsCrewItem = await jsonReader.ReadObjectAsync(stream);

                movieCreditsCrewItem.Should().NotBeNull();
                movieCreditsCrewItem.Job.Should().BeNull();
                movieCreditsCrewItem.Movie.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_TraktPersonMovieCreditsCrewItemObjectJsonReader_ReadObject_From_Stream_Null()
        {
            var jsonReader = new TraktPersonMovieCreditsCrewItemObjectJsonReader();

            var movieCreditsCrewItem = await jsonReader.ReadObjectAsync(default(Stream));
            movieCreditsCrewItem.Should().BeNull();
        }

        [Fact]
        public async Task Test_TraktPersonMovieCreditsCrewItemObjectJsonReader_ReadObject_From_Stream_Empty()
        {
            var jsonReader = new TraktPersonMovieCreditsCrewItemObjectJsonReader();

            using (var stream = string.Empty.ToStream())
            {
                var movieCreditsCrewItem = await jsonReader.ReadObjectAsync(stream);
                movieCreditsCrewItem.Should().BeNull();
            }
        }
    }
}
