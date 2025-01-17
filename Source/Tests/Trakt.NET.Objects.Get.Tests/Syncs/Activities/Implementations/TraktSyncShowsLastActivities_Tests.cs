﻿namespace TraktNet.Objects.Get.Tests.Syncs.Activities.Implementations
{
    using FluentAssertions;
    using System;
    using System.Threading.Tasks;
    using Trakt.NET.Tests.Utility.Traits;
    using TraktNet.Objects.Get.Syncs.Activities;
    using TraktNet.Objects.Get.Syncs.Activities.Json.Reader;
    using Xunit;

    [TestCategory("Objects.Get.Syncs.Activities.Implementations")]
    public class TraktSyncShowsLastActivities_Tests
    {
        [Fact]
        public void Test_TraktSyncShowsLastActivities_Default_Constructor()
        {
            var showsLastActivities = new TraktSyncShowsLastActivities();

            showsLastActivities.RatedAt.Should().BeNull();
            showsLastActivities.WatchlistedAt.Should().BeNull();
            showsLastActivities.RecommendationsAt.Should().BeNull();
            showsLastActivities.CommentedAt.Should().BeNull();
            showsLastActivities.HiddenAt.Should().BeNull();
        }

        [Fact]
        public async Task Test_TraktSyncShowsLastActivities_From_Json()
        {
            var jsonReader = new SyncShowsLastActivitiesObjectJsonReader();
            var showsLastActivities = await jsonReader.ReadObjectAsync(JSON) as TraktSyncShowsLastActivities;

            showsLastActivities.Should().NotBeNull();
            showsLastActivities.RatedAt.Should().Be(DateTime.Parse("2014-11-20T06:51:30.305Z").ToUniversalTime());
            showsLastActivities.WatchlistedAt.Should().Be(DateTime.Parse("2014-11-19T22:02:41.308Z").ToUniversalTime());
            showsLastActivities.RecommendationsAt.Should().Be(DateTime.Parse("2014-11-20T06:51:30.325Z").ToUniversalTime());
            showsLastActivities.CommentedAt.Should().Be(DateTime.Parse("2014-11-20T06:51:30.325Z").ToUniversalTime());
            showsLastActivities.HiddenAt.Should().Be(DateTime.Parse("2014-11-20T06:51:30.325Z").ToUniversalTime());
        }

        private const string JSON =
            @"{
                ""rated_at"": ""2014-11-20T06:51:30.305Z"",
                ""watchlisted_at"": ""2014-11-19T22:02:41.308Z"",
                ""recommendations_at"": ""2014-11-20T06:51:30.325Z"",
                ""commented_at"": ""2014-11-20T06:51:30.325Z"",
                ""hidden_at"": ""2014-11-20T06:51:30.325Z""
              }";
    }
}
