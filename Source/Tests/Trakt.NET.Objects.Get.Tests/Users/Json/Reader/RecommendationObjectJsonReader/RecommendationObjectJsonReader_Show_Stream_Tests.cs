﻿namespace TraktNet.Objects.Get.Tests.Users.Json.Reader
{
    using FluentAssertions;
    using System;
    using System.Threading.Tasks;
    using Trakt.NET.Tests.Utility;
    using Trakt.NET.Tests.Utility.Traits;
    using TraktNet.Enums;
    using TraktNet.Objects.Get.Users;
    using TraktNet.Objects.Get.Users.Json.Reader;
    using Xunit;

    [Category("Objects.Get.Users.JsonReader")]
    public partial class RecommendationObjectJsonReader_Tests
    {
        [Fact]
        public async Task Test_RecommendationObjectJsonReader_Show_ReadObject_From_Stream_Complete()
        {
            var jsonReader = new RecommendationObjectJsonReader();

            using var stream = JSON_SHOW_COMPLETE.ToStream();

            ITraktRecommendation traktRecommendation = await jsonReader.ReadObjectAsync(stream);

            traktRecommendation.Should().NotBeNull();
            traktRecommendation.Rank.Should().Be(1);
            traktRecommendation.ListedAt.Should().Be(DateTime.Parse("2014-09-01T09:10:11.000Z").ToUniversalTime());
            traktRecommendation.Type.Should().Be(TraktRecommendationObjectType.Show);
            traktRecommendation.Notes.Should().Be("Atmospheric for days.");
            traktRecommendation.Show.Should().NotBeNull();
            traktRecommendation.Show.Title.Should().Be("The Walking Dead");
            traktRecommendation.Show.Year.Should().Be(2010);
            traktRecommendation.Show.Ids.Should().NotBeNull();
            traktRecommendation.Show.Ids.Trakt.Should().Be(2U);
            traktRecommendation.Show.Ids.Slug.Should().Be("the-walking-dead");
            traktRecommendation.Show.Ids.Tvdb.Should().Be(153021U);
            traktRecommendation.Show.Ids.Imdb.Should().Be("tt1520211");
            traktRecommendation.Show.Ids.Tmdb.Should().Be(1402U);
            traktRecommendation.Movie.Should().BeNull();
        }

        [Fact]
        public async Task Test_RecommendationObjectJsonReader_Show_ReadObject_From_Stream_Incomplete_1()
        {
            var jsonReader = new RecommendationObjectJsonReader();

            using var stream = JSON_SHOW_INCOMPLETE_1.ToStream();

            ITraktRecommendation traktRecommendation = await jsonReader.ReadObjectAsync(stream);

            traktRecommendation.Should().NotBeNull();
            traktRecommendation.Rank.Should().BeNull();
            traktRecommendation.ListedAt.Should().Be(DateTime.Parse("2014-09-01T09:10:11.000Z").ToUniversalTime());
            traktRecommendation.Type.Should().Be(TraktRecommendationObjectType.Show);
            traktRecommendation.Notes.Should().Be("Atmospheric for days.");
            traktRecommendation.Show.Should().NotBeNull();
            traktRecommendation.Show.Title.Should().Be("The Walking Dead");
            traktRecommendation.Show.Year.Should().Be(2010);
            traktRecommendation.Show.Ids.Should().NotBeNull();
            traktRecommendation.Show.Ids.Trakt.Should().Be(2U);
            traktRecommendation.Show.Ids.Slug.Should().Be("the-walking-dead");
            traktRecommendation.Show.Ids.Tvdb.Should().Be(153021U);
            traktRecommendation.Show.Ids.Imdb.Should().Be("tt1520211");
            traktRecommendation.Show.Ids.Tmdb.Should().Be(1402U);
            traktRecommendation.Movie.Should().BeNull();
        }

        [Fact]
        public async Task Test_RecommendationObjectJsonReader_Show_ReadObject_From_Stream_Incomplete_2()
        {
            var jsonReader = new RecommendationObjectJsonReader();

            using var stream = JSON_SHOW_INCOMPLETE_2.ToStream();

            ITraktRecommendation traktRecommendation = await jsonReader.ReadObjectAsync(stream);

            traktRecommendation.Should().NotBeNull();
            traktRecommendation.Rank.Should().Be(1);
            traktRecommendation.ListedAt.Should().BeNull();
            traktRecommendation.Type.Should().Be(TraktRecommendationObjectType.Show);
            traktRecommendation.Notes.Should().Be("Atmospheric for days.");
            traktRecommendation.Show.Should().NotBeNull();
            traktRecommendation.Show.Title.Should().Be("The Walking Dead");
            traktRecommendation.Show.Year.Should().Be(2010);
            traktRecommendation.Show.Ids.Should().NotBeNull();
            traktRecommendation.Show.Ids.Trakt.Should().Be(2U);
            traktRecommendation.Show.Ids.Slug.Should().Be("the-walking-dead");
            traktRecommendation.Show.Ids.Tvdb.Should().Be(153021U);
            traktRecommendation.Show.Ids.Imdb.Should().Be("tt1520211");
            traktRecommendation.Show.Ids.Tmdb.Should().Be(1402U);
            traktRecommendation.Movie.Should().BeNull();
        }

        [Fact]
        public async Task Test_RecommendationObjectJsonReader_Show_ReadObject_From_Stream_Incomplete_3()
        {
            var jsonReader = new RecommendationObjectJsonReader();

            using var stream = JSON_SHOW_INCOMPLETE_3.ToStream();

            ITraktRecommendation traktRecommendation = await jsonReader.ReadObjectAsync(stream);

            traktRecommendation.Should().NotBeNull();
            traktRecommendation.Rank.Should().Be(1);
            traktRecommendation.ListedAt.Should().Be(DateTime.Parse("2014-09-01T09:10:11.000Z").ToUniversalTime());
            traktRecommendation.Type.Should().BeNull();
            traktRecommendation.Notes.Should().Be("Atmospheric for days.");
            traktRecommendation.Show.Should().NotBeNull();
            traktRecommendation.Show.Title.Should().Be("The Walking Dead");
            traktRecommendation.Show.Year.Should().Be(2010);
            traktRecommendation.Show.Ids.Should().NotBeNull();
            traktRecommendation.Show.Ids.Trakt.Should().Be(2U);
            traktRecommendation.Show.Ids.Slug.Should().Be("the-walking-dead");
            traktRecommendation.Show.Ids.Tvdb.Should().Be(153021U);
            traktRecommendation.Show.Ids.Imdb.Should().Be("tt1520211");
            traktRecommendation.Show.Ids.Tmdb.Should().Be(1402U);
            traktRecommendation.Movie.Should().BeNull();
        }

        [Fact]
        public async Task Test_RecommendationObjectJsonReader_Show_ReadObject_From_Stream_Incomplete_4()
        {
            var jsonReader = new RecommendationObjectJsonReader();

            using var stream = JSON_SHOW_INCOMPLETE_4.ToStream();

            ITraktRecommendation traktRecommendation = await jsonReader.ReadObjectAsync(stream);

            traktRecommendation.Should().NotBeNull();
            traktRecommendation.Rank.Should().Be(1);
            traktRecommendation.ListedAt.Should().Be(DateTime.Parse("2014-09-01T09:10:11.000Z").ToUniversalTime());
            traktRecommendation.Type.Should().Be(TraktRecommendationObjectType.Show);
            traktRecommendation.Notes.Should().BeNull();
            traktRecommendation.Show.Should().NotBeNull();
            traktRecommendation.Show.Title.Should().Be("The Walking Dead");
            traktRecommendation.Show.Year.Should().Be(2010);
            traktRecommendation.Show.Ids.Should().NotBeNull();
            traktRecommendation.Show.Ids.Trakt.Should().Be(2U);
            traktRecommendation.Show.Ids.Slug.Should().Be("the-walking-dead");
            traktRecommendation.Show.Ids.Tvdb.Should().Be(153021U);
            traktRecommendation.Show.Ids.Imdb.Should().Be("tt1520211");
            traktRecommendation.Show.Ids.Tmdb.Should().Be(1402U);
            traktRecommendation.Movie.Should().BeNull();
        }

        [Fact]
        public async Task Test_RecommendationObjectJsonReader_Show_ReadObject_From_Stream_Incomplete_5()
        {
            var jsonReader = new RecommendationObjectJsonReader();

            using var stream = JSON_SHOW_INCOMPLETE_5.ToStream();

            ITraktRecommendation traktRecommendation = await jsonReader.ReadObjectAsync(stream);

            traktRecommendation.Should().NotBeNull();
            traktRecommendation.Rank.Should().Be(1);
            traktRecommendation.ListedAt.Should().Be(DateTime.Parse("2014-09-01T09:10:11.000Z").ToUniversalTime());
            traktRecommendation.Type.Should().Be(TraktRecommendationObjectType.Show);
            traktRecommendation.Notes.Should().Be("Atmospheric for days.");
            traktRecommendation.Show.Should().BeNull();
            traktRecommendation.Movie.Should().BeNull();
        }

        [Fact]
        public async Task Test_RecommendationObjectJsonReader_Show_ReadObject_From_Stream_Incomplete_6()
        {
            var jsonReader = new RecommendationObjectJsonReader();

            using var stream = JSON_SHOW_INCOMPLETE_6.ToStream();

            ITraktRecommendation traktRecommendation = await jsonReader.ReadObjectAsync(stream);

            traktRecommendation.Should().NotBeNull();
            traktRecommendation.Rank.Should().Be(1);
            traktRecommendation.ListedAt.Should().BeNull();
            traktRecommendation.Type.Should().BeNull();
            traktRecommendation.Notes.Should().BeNull();
            traktRecommendation.Show.Should().BeNull();
            traktRecommendation.Movie.Should().BeNull();
        }

        [Fact]
        public async Task Test_RecommendationObjectJsonReader_Show_ReadObject_From_Stream_Incomplete_7()
        {
            var jsonReader = new RecommendationObjectJsonReader();

            using var stream = JSON_SHOW_INCOMPLETE_7.ToStream();

            ITraktRecommendation traktRecommendation = await jsonReader.ReadObjectAsync(stream);

            traktRecommendation.Should().NotBeNull();
            traktRecommendation.Rank.Should().BeNull();
            traktRecommendation.ListedAt.Should().Be(DateTime.Parse("2014-09-01T09:10:11.000Z").ToUniversalTime());
            traktRecommendation.Type.Should().BeNull();
            traktRecommendation.Notes.Should().BeNull();
            traktRecommendation.Show.Should().BeNull();
            traktRecommendation.Movie.Should().BeNull();
        }

        [Fact]
        public async Task Test_RecommendationObjectJsonReader_Show_ReadObject_From_Stream_Incomplete_8()
        {
            var jsonReader = new RecommendationObjectJsonReader();

            using var stream = JSON_SHOW_INCOMPLETE_8.ToStream();

            ITraktRecommendation traktRecommendation = await jsonReader.ReadObjectAsync(stream);

            traktRecommendation.Should().NotBeNull();
            traktRecommendation.Rank.Should().BeNull();
            traktRecommendation.ListedAt.Should().BeNull();
            traktRecommendation.Type.Should().Be(TraktRecommendationObjectType.Show);
            traktRecommendation.Notes.Should().BeNull();
            traktRecommendation.Show.Should().BeNull();
            traktRecommendation.Movie.Should().BeNull();
        }

        [Fact]
        public async Task Test_RecommendationObjectJsonReader_Show_ReadObject_From_Stream_Incomplete_9()
        {
            var jsonReader = new RecommendationObjectJsonReader();

            using var stream = JSON_SHOW_INCOMPLETE_9.ToStream();

            ITraktRecommendation traktRecommendation = await jsonReader.ReadObjectAsync(stream);

            traktRecommendation.Should().NotBeNull();
            traktRecommendation.Rank.Should().BeNull();
            traktRecommendation.ListedAt.Should().BeNull();
            traktRecommendation.Type.Should().BeNull();
            traktRecommendation.Notes.Should().Be("Atmospheric for days.");
            traktRecommendation.Show.Should().BeNull();
            traktRecommendation.Movie.Should().BeNull();
        }

        [Fact]
        public async Task Test_RecommendationObjectJsonReader_Show_ReadObject_From_Stream_Incomplete_10()
        {
            var jsonReader = new RecommendationObjectJsonReader();

            using var stream = JSON_SHOW_INCOMPLETE_10.ToStream();

            ITraktRecommendation traktRecommendation = await jsonReader.ReadObjectAsync(stream);

            traktRecommendation.Should().NotBeNull();
            traktRecommendation.Rank.Should().BeNull();
            traktRecommendation.ListedAt.Should().BeNull();
            traktRecommendation.Type.Should().BeNull();
            traktRecommendation.Notes.Should().BeNull();
            traktRecommendation.Show.Should().NotBeNull();
            traktRecommendation.Show.Title.Should().Be("The Walking Dead");
            traktRecommendation.Show.Year.Should().Be(2010);
            traktRecommendation.Show.Ids.Should().NotBeNull();
            traktRecommendation.Show.Ids.Trakt.Should().Be(2U);
            traktRecommendation.Show.Ids.Slug.Should().Be("the-walking-dead");
            traktRecommendation.Show.Ids.Tvdb.Should().Be(153021U);
            traktRecommendation.Show.Ids.Imdb.Should().Be("tt1520211");
            traktRecommendation.Show.Ids.Tmdb.Should().Be(1402U);
            traktRecommendation.Movie.Should().BeNull();
        }

        [Fact]
        public async Task Test_RecommendationObjectJsonReader_Show_ReadObject_From_Stream_Not_Valid_1()
        {
            var jsonReader = new RecommendationObjectJsonReader();

            using var stream = JSON_SHOW_NOT_VALID_1.ToStream();

            ITraktRecommendation traktRecommendation = await jsonReader.ReadObjectAsync(stream);

            traktRecommendation.Should().NotBeNull();
            traktRecommendation.Rank.Should().BeNull();
            traktRecommendation.ListedAt.Should().Be(DateTime.Parse("2014-09-01T09:10:11.000Z").ToUniversalTime());
            traktRecommendation.Type.Should().Be(TraktRecommendationObjectType.Show);
            traktRecommendation.Notes.Should().Be("Atmospheric for days.");
            traktRecommendation.Show.Should().NotBeNull();
            traktRecommendation.Show.Title.Should().Be("The Walking Dead");
            traktRecommendation.Show.Year.Should().Be(2010);
            traktRecommendation.Show.Ids.Should().NotBeNull();
            traktRecommendation.Show.Ids.Trakt.Should().Be(2U);
            traktRecommendation.Show.Ids.Slug.Should().Be("the-walking-dead");
            traktRecommendation.Show.Ids.Tvdb.Should().Be(153021U);
            traktRecommendation.Show.Ids.Imdb.Should().Be("tt1520211");
            traktRecommendation.Show.Ids.Tmdb.Should().Be(1402U);
            traktRecommendation.Movie.Should().BeNull();
        }

        [Fact]
        public async Task Test_RecommendationObjectJsonReader_Show_ReadObject_From_Stream_Not_Valid_2()
        {
            var jsonReader = new RecommendationObjectJsonReader();

            using var stream = JSON_SHOW_NOT_VALID_2.ToStream();

            ITraktRecommendation traktRecommendation = await jsonReader.ReadObjectAsync(stream);

            traktRecommendation.Should().NotBeNull();
            traktRecommendation.Rank.Should().Be(1);
            traktRecommendation.ListedAt.Should().BeNull();
            traktRecommendation.Type.Should().Be(TraktRecommendationObjectType.Show);
            traktRecommendation.Notes.Should().Be("Atmospheric for days.");
            traktRecommendation.Show.Should().NotBeNull();
            traktRecommendation.Show.Title.Should().Be("The Walking Dead");
            traktRecommendation.Show.Year.Should().Be(2010);
            traktRecommendation.Show.Ids.Should().NotBeNull();
            traktRecommendation.Show.Ids.Trakt.Should().Be(2U);
            traktRecommendation.Show.Ids.Slug.Should().Be("the-walking-dead");
            traktRecommendation.Show.Ids.Tvdb.Should().Be(153021U);
            traktRecommendation.Show.Ids.Imdb.Should().Be("tt1520211");
            traktRecommendation.Show.Ids.Tmdb.Should().Be(1402U);
            traktRecommendation.Movie.Should().BeNull();
        }

        [Fact]
        public async Task Test_RecommendationObjectJsonReader_Show_ReadObject_From_Stream_Not_Valid_3()
        {
            var jsonReader = new RecommendationObjectJsonReader();

            using var stream = JSON_SHOW_NOT_VALID_3.ToStream();

            ITraktRecommendation traktRecommendation = await jsonReader.ReadObjectAsync(stream);

            traktRecommendation.Should().NotBeNull();
            traktRecommendation.Rank.Should().Be(1);
            traktRecommendation.ListedAt.Should().Be(DateTime.Parse("2014-09-01T09:10:11.000Z").ToUniversalTime());
            traktRecommendation.Type.Should().BeNull();
            traktRecommendation.Notes.Should().Be("Atmospheric for days.");
            traktRecommendation.Show.Should().NotBeNull();
            traktRecommendation.Show.Title.Should().Be("The Walking Dead");
            traktRecommendation.Show.Year.Should().Be(2010);
            traktRecommendation.Show.Ids.Should().NotBeNull();
            traktRecommendation.Show.Ids.Trakt.Should().Be(2U);
            traktRecommendation.Show.Ids.Slug.Should().Be("the-walking-dead");
            traktRecommendation.Show.Ids.Tvdb.Should().Be(153021U);
            traktRecommendation.Show.Ids.Imdb.Should().Be("tt1520211");
            traktRecommendation.Show.Ids.Tmdb.Should().Be(1402U);
            traktRecommendation.Movie.Should().BeNull();
        }

        [Fact]
        public async Task Test_RecommendationObjectJsonReader_Show_ReadObject_From_Stream_Not_Valid_4()
        {
            var jsonReader = new RecommendationObjectJsonReader();

            using var stream = JSON_SHOW_NOT_VALID_4.ToStream();

            ITraktRecommendation traktRecommendation = await jsonReader.ReadObjectAsync(stream);

            traktRecommendation.Should().NotBeNull();
            traktRecommendation.Rank.Should().Be(1);
            traktRecommendation.ListedAt.Should().Be(DateTime.Parse("2014-09-01T09:10:11.000Z").ToUniversalTime());
            traktRecommendation.Type.Should().Be(TraktRecommendationObjectType.Show);
            traktRecommendation.Notes.Should().BeNull();
            traktRecommendation.Show.Should().NotBeNull();
            traktRecommendation.Show.Title.Should().Be("The Walking Dead");
            traktRecommendation.Show.Year.Should().Be(2010);
            traktRecommendation.Show.Ids.Should().NotBeNull();
            traktRecommendation.Show.Ids.Trakt.Should().Be(2U);
            traktRecommendation.Show.Ids.Slug.Should().Be("the-walking-dead");
            traktRecommendation.Show.Ids.Tvdb.Should().Be(153021U);
            traktRecommendation.Show.Ids.Imdb.Should().Be("tt1520211");
            traktRecommendation.Show.Ids.Tmdb.Should().Be(1402U);
            traktRecommendation.Movie.Should().BeNull();
        }

        [Fact]
        public async Task Test_RecommendationObjectJsonReader_Show_ReadObject_From_Stream_Not_Valid_5()
        {
            var jsonReader = new RecommendationObjectJsonReader();

            using var stream = JSON_SHOW_NOT_VALID_5.ToStream();

            ITraktRecommendation traktRecommendation = await jsonReader.ReadObjectAsync(stream);

            traktRecommendation.Should().NotBeNull();
            traktRecommendation.Rank.Should().Be(1);
            traktRecommendation.ListedAt.Should().Be(DateTime.Parse("2014-09-01T09:10:11.000Z").ToUniversalTime());
            traktRecommendation.Type.Should().Be(TraktRecommendationObjectType.Show);
            traktRecommendation.Notes.Should().Be("Atmospheric for days.");
            traktRecommendation.Show.Should().BeNull();
            traktRecommendation.Movie.Should().BeNull();
        }

        [Fact]
        public async Task Test_RecommendationObjectJsonReader_Show_ReadObject_From_Stream_Not_Valid_6()
        {
            var jsonReader = new RecommendationObjectJsonReader();

            using var stream = JSON_SHOW_NOT_VALID_6.ToStream();

            ITraktRecommendation traktRecommendation = await jsonReader.ReadObjectAsync(stream);

            traktRecommendation.Should().NotBeNull();
            traktRecommendation.Rank.Should().BeNull();
            traktRecommendation.ListedAt.Should().BeNull();
            traktRecommendation.Type.Should().BeNull();
            traktRecommendation.Notes.Should().BeNull();
            traktRecommendation.Show.Should().BeNull();
            traktRecommendation.Movie.Should().BeNull();
        }
    }
}
