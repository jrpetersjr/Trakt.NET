﻿namespace TraktNet.Objects.Post.Tests.Syncs.Recommendations.Responses.Json.Writer
{
    using FluentAssertions;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Threading.Tasks;
    using Trakt.NET.Tests.Utility.Traits;
    using TraktNet.Objects.Get.Movies;
    using TraktNet.Objects.Get.Shows;
    using TraktNet.Objects.Post.Syncs.Recommendations;
    using TraktNet.Objects.Post.Syncs.Recommendations.Responses;
    using TraktNet.Objects.Post.Syncs.Recommendations.Responses.Json.Writer;
    using Xunit;

    [TestCategory("Objects.Post.Syncs.Recommendations.Responses.JsonWriter")]
    public partial class SyncRecommendationsPostResponseNotFoundGroupObjectJsonWriter_Tests
    {
        [Fact]
        public async Task Test_SyncRecommendationsPostResponseNotFoundGroupObjectJsonWriter_WriteObject_StringWriter_Exceptions()
        {
            var traktJsonWriter = new SyncRecommendationsPostResponseNotFoundGroupObjectJsonWriter();
            ITraktSyncRecommendationsPostResponseNotFoundGroup traktSyncRecommendationsPostResponseNotFoundGroup = new TraktSyncRecommendationsPostResponseNotFoundGroup();
            Func<Task<string>> action = () => traktJsonWriter.WriteObjectAsync(default(StringWriter), traktSyncRecommendationsPostResponseNotFoundGroup);
            await action.Should().ThrowAsync<ArgumentNullException>();
        }

        [Fact]
        public async Task Test_SyncRecommendationsPostResponseNotFoundGroupObjectJsonWriter_WriteObject_StringWriter_Complete()
        {
            ITraktSyncRecommendationsPostResponseNotFoundGroup traktSyncRecommendationsPostResponseNotFoundGroup = new TraktSyncRecommendationsPostResponseNotFoundGroup
            {
                Movies = new List<ITraktSyncRecommendationsPostMovie>
                {
                    new TraktSyncRecommendationsPostMovie
                    {
                        Ids = new TraktMovieIds
                        {
                            Imdb = "tt0000111"
                        }
                    }
                },
                Shows = new List<ITraktSyncRecommendationsPostShow>
                {
                    new TraktSyncRecommendationsPostShow
                    {
                        Ids = new TraktShowIds
                        {
                            Imdb = "tt0000222"
                        }
                    }
                }
            };

            using var stringWriter = new StringWriter();
            var traktJsonWriter = new SyncRecommendationsPostResponseNotFoundGroupObjectJsonWriter();
            string json = await traktJsonWriter.WriteObjectAsync(stringWriter, traktSyncRecommendationsPostResponseNotFoundGroup);
            json.Should().Be(@"{""movies"":[{""ids"":{""trakt"":0,""imdb"":""tt0000111""}}]," +
                             @"""shows"":[{""ids"":{""trakt"":0,""imdb"":""tt0000222""}}]}");
        }
    }
}
