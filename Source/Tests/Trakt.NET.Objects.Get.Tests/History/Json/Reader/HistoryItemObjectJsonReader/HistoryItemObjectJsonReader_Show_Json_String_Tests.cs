﻿namespace TraktNet.Objects.Get.Tests.History.Json.Reader
{
    using FluentAssertions;
    using System;
    using System.Threading.Tasks;
    using Trakt.NET.Tests.Utility.Traits;
    using TraktNet.Enums;
    using TraktNet.Objects.Get.History.Json.Reader;
    using Xunit;

    [TestCategory("Objects.Get.History.JsonReader")]
    public partial class HistoryItemObjectJsonReader_Tests
    {
        [Fact]
        public async Task Test_HistoryItemObjectJsonReader_Show_ReadObject_From_Json_String_Complete()
        {
            var jsonReader = new HistoryItemObjectJsonReader();

            var traktHistoryItem = await jsonReader.ReadObjectAsync(TYPE_SHOW_JSON_COMPLETE);

            traktHistoryItem.Should().NotBeNull();
            traktHistoryItem.Id.Should().Be(1982348UL);
            traktHistoryItem.WatchedAt.Should().Be(DateTime.Parse("2013-06-15T05:54:27.000Z").ToUniversalTime());
            traktHistoryItem.Action.Should().Be(TraktHistoryActionType.Checkin);
            traktHistoryItem.Type.Should().Be(TraktSyncItemType.Show);
            traktHistoryItem.Show.Should().NotBeNull();
            traktHistoryItem.Show.Title.Should().Be("Game of Thrones");
            traktHistoryItem.Show.Year.Should().Be(2011);
            traktHistoryItem.Show.Ids.Should().NotBeNull();
            traktHistoryItem.Show.Ids.Trakt.Should().Be(1390U);
            traktHistoryItem.Show.Ids.Slug.Should().Be("game-of-thrones");
            traktHistoryItem.Show.Ids.Tvdb.Should().Be(121361U);
            traktHistoryItem.Show.Ids.Imdb.Should().Be("tt0944947");
            traktHistoryItem.Show.Ids.Tmdb.Should().Be(1399U);
            traktHistoryItem.Show.Ids.TvRage.Should().Be(24493U);

            traktHistoryItem.Movie.Should().BeNull();
            traktHistoryItem.Season.Should().BeNull();
            traktHistoryItem.Episode.Should().BeNull();
        }

        [Fact]
        public async Task Test_HistoryItemObjectJsonReader_Show_ReadObject_From_Json_String_Incomplete_1()
        {
            var jsonReader = new HistoryItemObjectJsonReader();

            var traktHistoryItem = await jsonReader.ReadObjectAsync(TYPE_SHOW_JSON_INCOMPLETE_1);

            traktHistoryItem.Should().NotBeNull();
            traktHistoryItem.Id.Should().Be(0UL);
            traktHistoryItem.WatchedAt.Should().Be(DateTime.Parse("2013-06-15T05:54:27.000Z").ToUniversalTime());
            traktHistoryItem.Action.Should().Be(TraktHistoryActionType.Checkin);
            traktHistoryItem.Type.Should().Be(TraktSyncItemType.Show);
            traktHistoryItem.Show.Should().NotBeNull();
            traktHistoryItem.Show.Title.Should().Be("Game of Thrones");
            traktHistoryItem.Show.Year.Should().Be(2011);
            traktHistoryItem.Show.Ids.Should().NotBeNull();
            traktHistoryItem.Show.Ids.Trakt.Should().Be(1390U);
            traktHistoryItem.Show.Ids.Slug.Should().Be("game-of-thrones");
            traktHistoryItem.Show.Ids.Tvdb.Should().Be(121361U);
            traktHistoryItem.Show.Ids.Imdb.Should().Be("tt0944947");
            traktHistoryItem.Show.Ids.Tmdb.Should().Be(1399U);
            traktHistoryItem.Show.Ids.TvRage.Should().Be(24493U);

            traktHistoryItem.Movie.Should().BeNull();
            traktHistoryItem.Season.Should().BeNull();
            traktHistoryItem.Episode.Should().BeNull();
        }

        [Fact]
        public async Task Test_HistoryItemObjectJsonReader_Show_ReadObject_From_Json_String_Incomplete_2()
        {
            var jsonReader = new HistoryItemObjectJsonReader();

            var traktHistoryItem = await jsonReader.ReadObjectAsync(TYPE_SHOW_JSON_INCOMPLETE_2);

            traktHistoryItem.Should().NotBeNull();
            traktHistoryItem.Id.Should().Be(1982348UL);
            traktHistoryItem.WatchedAt.Should().BeNull();
            traktHistoryItem.Action.Should().Be(TraktHistoryActionType.Checkin);
            traktHistoryItem.Type.Should().Be(TraktSyncItemType.Show);
            traktHistoryItem.Show.Should().NotBeNull();
            traktHistoryItem.Show.Title.Should().Be("Game of Thrones");
            traktHistoryItem.Show.Year.Should().Be(2011);
            traktHistoryItem.Show.Ids.Should().NotBeNull();
            traktHistoryItem.Show.Ids.Trakt.Should().Be(1390U);
            traktHistoryItem.Show.Ids.Slug.Should().Be("game-of-thrones");
            traktHistoryItem.Show.Ids.Tvdb.Should().Be(121361U);
            traktHistoryItem.Show.Ids.Imdb.Should().Be("tt0944947");
            traktHistoryItem.Show.Ids.Tmdb.Should().Be(1399U);
            traktHistoryItem.Show.Ids.TvRage.Should().Be(24493U);

            traktHistoryItem.Movie.Should().BeNull();
            traktHistoryItem.Season.Should().BeNull();
            traktHistoryItem.Episode.Should().BeNull();
        }

        [Fact]
        public async Task Test_HistoryItemObjectJsonReader_Show_ReadObject_From_Json_String_Incomplete_3()
        {
            var jsonReader = new HistoryItemObjectJsonReader();

            var traktHistoryItem = await jsonReader.ReadObjectAsync(TYPE_SHOW_JSON_INCOMPLETE_3);

            traktHistoryItem.Should().NotBeNull();
            traktHistoryItem.Id.Should().Be(1982348UL);
            traktHistoryItem.WatchedAt.Should().Be(DateTime.Parse("2013-06-15T05:54:27.000Z").ToUniversalTime());
            traktHistoryItem.Action.Should().BeNull();
            traktHistoryItem.Type.Should().Be(TraktSyncItemType.Show);
            traktHistoryItem.Show.Should().NotBeNull();
            traktHistoryItem.Show.Title.Should().Be("Game of Thrones");
            traktHistoryItem.Show.Year.Should().Be(2011);
            traktHistoryItem.Show.Ids.Should().NotBeNull();
            traktHistoryItem.Show.Ids.Trakt.Should().Be(1390U);
            traktHistoryItem.Show.Ids.Slug.Should().Be("game-of-thrones");
            traktHistoryItem.Show.Ids.Tvdb.Should().Be(121361U);
            traktHistoryItem.Show.Ids.Imdb.Should().Be("tt0944947");
            traktHistoryItem.Show.Ids.Tmdb.Should().Be(1399U);
            traktHistoryItem.Show.Ids.TvRage.Should().Be(24493U);

            traktHistoryItem.Movie.Should().BeNull();
            traktHistoryItem.Season.Should().BeNull();
            traktHistoryItem.Episode.Should().BeNull();
        }

        [Fact]
        public async Task Test_HistoryItemObjectJsonReader_Show_ReadObject_From_Json_String_Incomplete_4()
        {
            var jsonReader = new HistoryItemObjectJsonReader();

            var traktHistoryItem = await jsonReader.ReadObjectAsync(TYPE_SHOW_JSON_INCOMPLETE_4);

            traktHistoryItem.Should().NotBeNull();
            traktHistoryItem.Id.Should().Be(1982348UL);
            traktHistoryItem.WatchedAt.Should().Be(DateTime.Parse("2013-06-15T05:54:27.000Z").ToUniversalTime());
            traktHistoryItem.Action.Should().Be(TraktHistoryActionType.Checkin);
            traktHistoryItem.Type.Should().BeNull();
            traktHistoryItem.Show.Should().NotBeNull();
            traktHistoryItem.Show.Title.Should().Be("Game of Thrones");
            traktHistoryItem.Show.Year.Should().Be(2011);
            traktHistoryItem.Show.Ids.Should().NotBeNull();
            traktHistoryItem.Show.Ids.Trakt.Should().Be(1390U);
            traktHistoryItem.Show.Ids.Slug.Should().Be("game-of-thrones");
            traktHistoryItem.Show.Ids.Tvdb.Should().Be(121361U);
            traktHistoryItem.Show.Ids.Imdb.Should().Be("tt0944947");
            traktHistoryItem.Show.Ids.Tmdb.Should().Be(1399U);
            traktHistoryItem.Show.Ids.TvRage.Should().Be(24493U);

            traktHistoryItem.Movie.Should().BeNull();
            traktHistoryItem.Season.Should().BeNull();
            traktHistoryItem.Episode.Should().BeNull();
        }

        [Fact]
        public async Task Test_HistoryItemObjectJsonReader_Show_ReadObject_From_Json_String_Incomplete_5()
        {
            var jsonReader = new HistoryItemObjectJsonReader();

            var traktHistoryItem = await jsonReader.ReadObjectAsync(TYPE_SHOW_JSON_INCOMPLETE_5);

            traktHistoryItem.Should().NotBeNull();
            traktHistoryItem.Id.Should().Be(1982348UL);
            traktHistoryItem.WatchedAt.Should().Be(DateTime.Parse("2013-06-15T05:54:27.000Z").ToUniversalTime());
            traktHistoryItem.Action.Should().Be(TraktHistoryActionType.Checkin);
            traktHistoryItem.Type.Should().Be(TraktSyncItemType.Show);
            traktHistoryItem.Show.Should().BeNull();

            traktHistoryItem.Movie.Should().BeNull();
            traktHistoryItem.Season.Should().BeNull();
            traktHistoryItem.Episode.Should().BeNull();
        }

        [Fact]
        public async Task Test_HistoryItemObjectJsonReader_Show_ReadObject_From_Json_String_Incomplete_6()
        {
            var jsonReader = new HistoryItemObjectJsonReader();

            var traktHistoryItem = await jsonReader.ReadObjectAsync(TYPE_SHOW_JSON_INCOMPLETE_6);

            traktHistoryItem.Should().NotBeNull();
            traktHistoryItem.Id.Should().Be(1982348UL);
            traktHistoryItem.WatchedAt.Should().BeNull();
            traktHistoryItem.Action.Should().BeNull();
            traktHistoryItem.Type.Should().BeNull();
            traktHistoryItem.Show.Should().BeNull();

            traktHistoryItem.Movie.Should().BeNull();
            traktHistoryItem.Season.Should().BeNull();
            traktHistoryItem.Episode.Should().BeNull();
        }

        [Fact]
        public async Task Test_HistoryItemObjectJsonReader_Show_ReadObject_From_Json_String_Incomplete_7()
        {
            var jsonReader = new HistoryItemObjectJsonReader();

            var traktHistoryItem = await jsonReader.ReadObjectAsync(TYPE_SHOW_JSON_INCOMPLETE_7);

            traktHistoryItem.Should().NotBeNull();
            traktHistoryItem.Id.Should().Be(0UL);
            traktHistoryItem.WatchedAt.Should().Be(DateTime.Parse("2013-06-15T05:54:27.000Z").ToUniversalTime());
            traktHistoryItem.Action.Should().BeNull();
            traktHistoryItem.Type.Should().BeNull();
            traktHistoryItem.Show.Should().BeNull();

            traktHistoryItem.Movie.Should().BeNull();
            traktHistoryItem.Season.Should().BeNull();
            traktHistoryItem.Episode.Should().BeNull();
        }

        [Fact]
        public async Task Test_HistoryItemObjectJsonReader_Show_ReadObject_From_Json_String_Incomplete_8()
        {
            var jsonReader = new HistoryItemObjectJsonReader();

            var traktHistoryItem = await jsonReader.ReadObjectAsync(TYPE_SHOW_JSON_INCOMPLETE_8);

            traktHistoryItem.Should().NotBeNull();
            traktHistoryItem.Id.Should().Be(0UL);
            traktHistoryItem.WatchedAt.Should().BeNull();
            traktHistoryItem.Action.Should().Be(TraktHistoryActionType.Checkin);
            traktHistoryItem.Type.Should().BeNull();
            traktHistoryItem.Show.Should().BeNull();

            traktHistoryItem.Movie.Should().BeNull();
            traktHistoryItem.Season.Should().BeNull();
            traktHistoryItem.Episode.Should().BeNull();
        }

        [Fact]
        public async Task Test_HistoryItemObjectJsonReader_Show_ReadObject_From_Json_String_Incomplete_9()
        {
            var jsonReader = new HistoryItemObjectJsonReader();

            var traktHistoryItem = await jsonReader.ReadObjectAsync(TYPE_SHOW_JSON_INCOMPLETE_9);

            traktHistoryItem.Should().NotBeNull();
            traktHistoryItem.Id.Should().Be(0UL);
            traktHistoryItem.WatchedAt.Should().BeNull();
            traktHistoryItem.Action.Should().BeNull();
            traktHistoryItem.Type.Should().Be(TraktSyncItemType.Show);
            traktHistoryItem.Show.Should().BeNull();

            traktHistoryItem.Movie.Should().BeNull();
            traktHistoryItem.Season.Should().BeNull();
            traktHistoryItem.Episode.Should().BeNull();
        }

        [Fact]
        public async Task Test_HistoryItemObjectJsonReader_Show_ReadObject_From_Json_String_Incomplete_10()
        {
            var jsonReader = new HistoryItemObjectJsonReader();

            var traktHistoryItem = await jsonReader.ReadObjectAsync(TYPE_SHOW_JSON_INCOMPLETE_10);

            traktHistoryItem.Should().NotBeNull();
            traktHistoryItem.Id.Should().Be(0UL);
            traktHistoryItem.WatchedAt.Should().BeNull();
            traktHistoryItem.Action.Should().BeNull();
            traktHistoryItem.Type.Should().BeNull();
            traktHistoryItem.Show.Should().NotBeNull();
            traktHistoryItem.Show.Title.Should().Be("Game of Thrones");
            traktHistoryItem.Show.Year.Should().Be(2011);
            traktHistoryItem.Show.Ids.Should().NotBeNull();
            traktHistoryItem.Show.Ids.Trakt.Should().Be(1390U);
            traktHistoryItem.Show.Ids.Slug.Should().Be("game-of-thrones");
            traktHistoryItem.Show.Ids.Tvdb.Should().Be(121361U);
            traktHistoryItem.Show.Ids.Imdb.Should().Be("tt0944947");
            traktHistoryItem.Show.Ids.Tmdb.Should().Be(1399U);
            traktHistoryItem.Show.Ids.TvRage.Should().Be(24493U);

            traktHistoryItem.Movie.Should().BeNull();
            traktHistoryItem.Season.Should().BeNull();
            traktHistoryItem.Episode.Should().BeNull();
        }

        [Fact]
        public async Task Test_HistoryItemObjectJsonReader_Show_ReadObject_From_Json_String_Not_Valid_1()
        {
            var jsonReader = new HistoryItemObjectJsonReader();

            var traktHistoryItem = await jsonReader.ReadObjectAsync(TYPE_SHOW_JSON_NOT_VALID_1);

            traktHistoryItem.Should().NotBeNull();
            traktHistoryItem.Id.Should().Be(0UL);
            traktHistoryItem.WatchedAt.Should().Be(DateTime.Parse("2013-06-15T05:54:27.000Z").ToUniversalTime());
            traktHistoryItem.Action.Should().Be(TraktHistoryActionType.Checkin);
            traktHistoryItem.Type.Should().Be(TraktSyncItemType.Show);
            traktHistoryItem.Show.Should().NotBeNull();
            traktHistoryItem.Show.Title.Should().Be("Game of Thrones");
            traktHistoryItem.Show.Year.Should().Be(2011);
            traktHistoryItem.Show.Ids.Should().NotBeNull();
            traktHistoryItem.Show.Ids.Trakt.Should().Be(1390U);
            traktHistoryItem.Show.Ids.Slug.Should().Be("game-of-thrones");
            traktHistoryItem.Show.Ids.Tvdb.Should().Be(121361U);
            traktHistoryItem.Show.Ids.Imdb.Should().Be("tt0944947");
            traktHistoryItem.Show.Ids.Tmdb.Should().Be(1399U);
            traktHistoryItem.Show.Ids.TvRage.Should().Be(24493U);

            traktHistoryItem.Movie.Should().BeNull();
            traktHistoryItem.Season.Should().BeNull();
            traktHistoryItem.Episode.Should().BeNull();
        }

        [Fact]
        public async Task Test_HistoryItemObjectJsonReader_Show_ReadObject_From_Json_String_Not_Valid_2()
        {
            var jsonReader = new HistoryItemObjectJsonReader();

            var traktHistoryItem = await jsonReader.ReadObjectAsync(TYPE_SHOW_JSON_NOT_VALID_2);

            traktHistoryItem.Should().NotBeNull();
            traktHistoryItem.Id.Should().Be(1982348UL);
            traktHistoryItem.WatchedAt.Should().BeNull();
            traktHistoryItem.Action.Should().Be(TraktHistoryActionType.Checkin);
            traktHistoryItem.Type.Should().Be(TraktSyncItemType.Show);
            traktHistoryItem.Show.Should().NotBeNull();
            traktHistoryItem.Show.Title.Should().Be("Game of Thrones");
            traktHistoryItem.Show.Year.Should().Be(2011);
            traktHistoryItem.Show.Ids.Should().NotBeNull();
            traktHistoryItem.Show.Ids.Trakt.Should().Be(1390U);
            traktHistoryItem.Show.Ids.Slug.Should().Be("game-of-thrones");
            traktHistoryItem.Show.Ids.Tvdb.Should().Be(121361U);
            traktHistoryItem.Show.Ids.Imdb.Should().Be("tt0944947");
            traktHistoryItem.Show.Ids.Tmdb.Should().Be(1399U);
            traktHistoryItem.Show.Ids.TvRage.Should().Be(24493U);

            traktHistoryItem.Movie.Should().BeNull();
            traktHistoryItem.Season.Should().BeNull();
            traktHistoryItem.Episode.Should().BeNull();
        }

        [Fact]
        public async Task Test_HistoryItemObjectJsonReader_Show_ReadObject_From_Json_String_Not_Valid_3()
        {
            var jsonReader = new HistoryItemObjectJsonReader();

            var traktHistoryItem = await jsonReader.ReadObjectAsync(TYPE_SHOW_JSON_NOT_VALID_3);

            traktHistoryItem.Should().NotBeNull();
            traktHistoryItem.Id.Should().Be(1982348UL);
            traktHistoryItem.WatchedAt.Should().Be(DateTime.Parse("2013-06-15T05:54:27.000Z").ToUniversalTime());
            traktHistoryItem.Action.Should().BeNull();
            traktHistoryItem.Type.Should().Be(TraktSyncItemType.Show);
            traktHistoryItem.Show.Should().NotBeNull();
            traktHistoryItem.Show.Title.Should().Be("Game of Thrones");
            traktHistoryItem.Show.Year.Should().Be(2011);
            traktHistoryItem.Show.Ids.Should().NotBeNull();
            traktHistoryItem.Show.Ids.Trakt.Should().Be(1390U);
            traktHistoryItem.Show.Ids.Slug.Should().Be("game-of-thrones");
            traktHistoryItem.Show.Ids.Tvdb.Should().Be(121361U);
            traktHistoryItem.Show.Ids.Imdb.Should().Be("tt0944947");
            traktHistoryItem.Show.Ids.Tmdb.Should().Be(1399U);
            traktHistoryItem.Show.Ids.TvRage.Should().Be(24493U);

            traktHistoryItem.Movie.Should().BeNull();
            traktHistoryItem.Season.Should().BeNull();
            traktHistoryItem.Episode.Should().BeNull();
        }

        [Fact]
        public async Task Test_HistoryItemObjectJsonReader_Show_ReadObject_From_Json_String_Not_Valid_4()
        {
            var jsonReader = new HistoryItemObjectJsonReader();

            var traktHistoryItem = await jsonReader.ReadObjectAsync(TYPE_SHOW_JSON_NOT_VALID_4);

            traktHistoryItem.Should().NotBeNull();
            traktHistoryItem.Id.Should().Be(1982348UL);
            traktHistoryItem.WatchedAt.Should().Be(DateTime.Parse("2013-06-15T05:54:27.000Z").ToUniversalTime());
            traktHistoryItem.Action.Should().Be(TraktHistoryActionType.Checkin);
            traktHistoryItem.Type.Should().BeNull();
            traktHistoryItem.Show.Should().NotBeNull();
            traktHistoryItem.Show.Title.Should().Be("Game of Thrones");
            traktHistoryItem.Show.Year.Should().Be(2011);
            traktHistoryItem.Show.Ids.Should().NotBeNull();
            traktHistoryItem.Show.Ids.Trakt.Should().Be(1390U);
            traktHistoryItem.Show.Ids.Slug.Should().Be("game-of-thrones");
            traktHistoryItem.Show.Ids.Tvdb.Should().Be(121361U);
            traktHistoryItem.Show.Ids.Imdb.Should().Be("tt0944947");
            traktHistoryItem.Show.Ids.Tmdb.Should().Be(1399U);
            traktHistoryItem.Show.Ids.TvRage.Should().Be(24493U);

            traktHistoryItem.Movie.Should().BeNull();
            traktHistoryItem.Season.Should().BeNull();
            traktHistoryItem.Episode.Should().BeNull();
        }

        [Fact]
        public async Task Test_HistoryItemObjectJsonReader_Show_ReadObject_From_Json_String_Not_Valid_5()
        {
            var jsonReader = new HistoryItemObjectJsonReader();

            var traktHistoryItem = await jsonReader.ReadObjectAsync(TYPE_SHOW_JSON_NOT_VALID_5);

            traktHistoryItem.Should().NotBeNull();
            traktHistoryItem.Id.Should().Be(1982348UL);
            traktHistoryItem.WatchedAt.Should().Be(DateTime.Parse("2013-06-15T05:54:27.000Z").ToUniversalTime());
            traktHistoryItem.Action.Should().Be(TraktHistoryActionType.Checkin);
            traktHistoryItem.Type.Should().Be(TraktSyncItemType.Show);
            traktHistoryItem.Show.Should().BeNull();

            traktHistoryItem.Movie.Should().BeNull();
            traktHistoryItem.Season.Should().BeNull();
            traktHistoryItem.Episode.Should().BeNull();
        }

        [Fact]
        public async Task Test_HistoryItemObjectJsonReader_Show_ReadObject_From_Json_String_Not_Valid_6()
        {
            var jsonReader = new HistoryItemObjectJsonReader();

            var traktHistoryItem = await jsonReader.ReadObjectAsync(TYPE_SHOW_JSON_NOT_VALID_6);

            traktHistoryItem.Should().NotBeNull();
            traktHistoryItem.Id.Should().Be(0UL);
            traktHistoryItem.WatchedAt.Should().BeNull();
            traktHistoryItem.Action.Should().BeNull();
            traktHistoryItem.Type.Should().BeNull();
            traktHistoryItem.Show.Should().BeNull();
            traktHistoryItem.Movie.Should().BeNull();
            traktHistoryItem.Season.Should().BeNull();
            traktHistoryItem.Episode.Should().BeNull();
        }
    }
}
