﻿namespace TraktNet.Objects.Post.Tests.Syncs.Recommendations.Json.Writer
{
    using FluentAssertions;
    using System;
    using System.IO;
    using System.Threading.Tasks;
    using Trakt.NET.Tests.Utility.Traits;
    using TraktNet.Objects.Get.Movies;
    using TraktNet.Objects.Post.Syncs.Recommendations;
    using TraktNet.Objects.Post.Syncs.Recommendations.Json.Writer;
    using Xunit;

    [Category("Objects.Post.Syncs.Recommendations.JsonWriter")]
    public partial class SyncRecommendationsPostMovieObjectJsonWriter_Tests
    {
        [Fact]
        public async Task Test_SyncRecommendationsPostMovieObjectJsonWriter_WriteObject_StringWriter_Exceptions()
        {
            var traktJsonWriter = new SyncRecommendationsPostMovieObjectJsonWriter();
            ITraktSyncRecommendationsPostMovie traktSyncRecommendationsPostMovie = new TraktSyncRecommendationsPostMovie();
            Func<Task<string>> action = () => traktJsonWriter.WriteObjectAsync(default(StringWriter), traktSyncRecommendationsPostMovie);
            await action.Should().ThrowAsync<ArgumentNullException>();
        }

        [Fact]
        public async Task Test_SyncRecommendationsPostMovieObjectJsonWriter_WriteObject_StringWriter_Complete()
        {
            ITraktSyncRecommendationsPostMovie traktSyncRecommendationsPostMovie = new TraktSyncRecommendationsPostMovie
            {
                Title = "Batman Begins",
                Year = 2005,
                Ids = new TraktMovieIds
                {
                    Trakt = 1,
                    Slug = "batman-begins-2005",
                    Imdb = "tt0372784",
                    Tmdb = 272
                },
                Notes = "One of Chritian Bale's most iconic roles."
            };

            using var stringWriter = new StringWriter();
            var traktJsonWriter = new SyncRecommendationsPostMovieObjectJsonWriter();
            string json = await traktJsonWriter.WriteObjectAsync(stringWriter, traktSyncRecommendationsPostMovie);
            json.Should().Be(@"{""title"":""Batman Begins"",""year"":2005," +
                             @"""ids"":{""trakt"":1,""slug"":""batman-begins-2005""," +
                             @"""imdb"":""tt0372784"",""tmdb"":272}," +
                             @"""notes"":""One of Chritian Bale's most iconic roles.""}");
        }
    }
}