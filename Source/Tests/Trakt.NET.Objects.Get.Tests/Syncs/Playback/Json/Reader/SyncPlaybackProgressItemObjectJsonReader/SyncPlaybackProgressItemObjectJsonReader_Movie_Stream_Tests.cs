﻿namespace TraktNet.Objects.Get.Tests.Syncs.Playback.Json.Reader
{
    using FluentAssertions;
    using System;
    using System.Threading.Tasks;
    using Trakt.NET.Tests.Utility;
    using Trakt.NET.Tests.Utility.Traits;
    using TraktNet.Enums;
    using TraktNet.Objects.Get.Syncs.Playback.Json.Reader;
    using Xunit;

    [TestCategory("Objects.Get.Syncs.Playback.JsonReader")]
    public partial class SyncPlaybackProgressItemObjectJsonReader_Tests
    {
        [Fact]
        public async Task Test_SyncPlaybackProgressItemObjectJsonReader_Movie_ReadObject_From_Stream_Complete()
        {
            var jsonReader = new SyncPlaybackProgressItemObjectJsonReader();

            using (var stream = TYPE_MOVIE_JSON_COMPLETE.ToStream())
            {
                var traktPlaybackProgressItem = await jsonReader.ReadObjectAsync(stream);

                traktPlaybackProgressItem.Should().NotBeNull();
                traktPlaybackProgressItem.Id.Should().Be(37U);
                traktPlaybackProgressItem.Progress.Should().Be(65.5f);
                traktPlaybackProgressItem.PausedAt.Should().Be(DateTime.Parse("2015-01-25T22:01:32.000Z").ToUniversalTime());
                traktPlaybackProgressItem.Type.Should().Be(TraktSyncType.Movie);
                traktPlaybackProgressItem.Movie.Should().NotBeNull();
                traktPlaybackProgressItem.Movie.Title.Should().Be("Star Wars: The Force Awakens");
                traktPlaybackProgressItem.Movie.Year.Should().Be(2015);
                traktPlaybackProgressItem.Movie.Ids.Should().NotBeNull();
                traktPlaybackProgressItem.Movie.Ids.Trakt.Should().Be(94024U);
                traktPlaybackProgressItem.Movie.Ids.Slug.Should().Be("star-wars-the-force-awakens-2015");
                traktPlaybackProgressItem.Movie.Ids.Imdb.Should().Be("tt2488496");
                traktPlaybackProgressItem.Movie.Ids.Tmdb.Should().Be(140607U);

                traktPlaybackProgressItem.Show.Should().BeNull();
                traktPlaybackProgressItem.Episode.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_SyncPlaybackProgressItemObjectJsonReader_Movie_ReadObject_From_Stream_Incomplete_1()
        {
            var jsonReader = new SyncPlaybackProgressItemObjectJsonReader();

            using (var stream = TYPE_MOVIE_JSON_INCOMPLETE_1.ToStream())
            {
                var traktPlaybackProgressItem = await jsonReader.ReadObjectAsync(stream);

                traktPlaybackProgressItem.Should().NotBeNull();
                traktPlaybackProgressItem.Id.Should().Be(0U);
                traktPlaybackProgressItem.Progress.Should().Be(65.5f);
                traktPlaybackProgressItem.PausedAt.Should().Be(DateTime.Parse("2015-01-25T22:01:32.000Z").ToUniversalTime());
                traktPlaybackProgressItem.Type.Should().Be(TraktSyncType.Movie);
                traktPlaybackProgressItem.Movie.Should().NotBeNull();
                traktPlaybackProgressItem.Movie.Title.Should().Be("Star Wars: The Force Awakens");
                traktPlaybackProgressItem.Movie.Year.Should().Be(2015);
                traktPlaybackProgressItem.Movie.Ids.Should().NotBeNull();
                traktPlaybackProgressItem.Movie.Ids.Trakt.Should().Be(94024U);
                traktPlaybackProgressItem.Movie.Ids.Slug.Should().Be("star-wars-the-force-awakens-2015");
                traktPlaybackProgressItem.Movie.Ids.Imdb.Should().Be("tt2488496");
                traktPlaybackProgressItem.Movie.Ids.Tmdb.Should().Be(140607U);

                traktPlaybackProgressItem.Show.Should().BeNull();
                traktPlaybackProgressItem.Episode.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_SyncPlaybackProgressItemObjectJsonReader_Movie_ReadObject_From_Stream_Incomplete_2()
        {
            var jsonReader = new SyncPlaybackProgressItemObjectJsonReader();

            using (var stream = TYPE_MOVIE_JSON_INCOMPLETE_2.ToStream())
            {
                var traktPlaybackProgressItem = await jsonReader.ReadObjectAsync(stream);

                traktPlaybackProgressItem.Should().NotBeNull();
                traktPlaybackProgressItem.Id.Should().Be(37U);
                traktPlaybackProgressItem.Progress.Should().BeNull();
                traktPlaybackProgressItem.PausedAt.Should().Be(DateTime.Parse("2015-01-25T22:01:32.000Z").ToUniversalTime());
                traktPlaybackProgressItem.Type.Should().Be(TraktSyncType.Movie);
                traktPlaybackProgressItem.Movie.Should().NotBeNull();
                traktPlaybackProgressItem.Movie.Title.Should().Be("Star Wars: The Force Awakens");
                traktPlaybackProgressItem.Movie.Year.Should().Be(2015);
                traktPlaybackProgressItem.Movie.Ids.Should().NotBeNull();
                traktPlaybackProgressItem.Movie.Ids.Trakt.Should().Be(94024U);
                traktPlaybackProgressItem.Movie.Ids.Slug.Should().Be("star-wars-the-force-awakens-2015");
                traktPlaybackProgressItem.Movie.Ids.Imdb.Should().Be("tt2488496");
                traktPlaybackProgressItem.Movie.Ids.Tmdb.Should().Be(140607U);

                traktPlaybackProgressItem.Show.Should().BeNull();
                traktPlaybackProgressItem.Episode.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_SyncPlaybackProgressItemObjectJsonReader_Movie_ReadObject_From_Stream_Incomplete_3()
        {
            var jsonReader = new SyncPlaybackProgressItemObjectJsonReader();

            using (var stream = TYPE_MOVIE_JSON_INCOMPLETE_3.ToStream())
            {
                var traktPlaybackProgressItem = await jsonReader.ReadObjectAsync(stream);

                traktPlaybackProgressItem.Should().NotBeNull();
                traktPlaybackProgressItem.Id.Should().Be(37U);
                traktPlaybackProgressItem.Progress.Should().Be(65.5f);
                traktPlaybackProgressItem.PausedAt.Should().BeNull();
                traktPlaybackProgressItem.Type.Should().Be(TraktSyncType.Movie);
                traktPlaybackProgressItem.Movie.Should().NotBeNull();
                traktPlaybackProgressItem.Movie.Title.Should().Be("Star Wars: The Force Awakens");
                traktPlaybackProgressItem.Movie.Year.Should().Be(2015);
                traktPlaybackProgressItem.Movie.Ids.Should().NotBeNull();
                traktPlaybackProgressItem.Movie.Ids.Trakt.Should().Be(94024U);
                traktPlaybackProgressItem.Movie.Ids.Slug.Should().Be("star-wars-the-force-awakens-2015");
                traktPlaybackProgressItem.Movie.Ids.Imdb.Should().Be("tt2488496");
                traktPlaybackProgressItem.Movie.Ids.Tmdb.Should().Be(140607U);

                traktPlaybackProgressItem.Show.Should().BeNull();
                traktPlaybackProgressItem.Episode.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_SyncPlaybackProgressItemObjectJsonReader_Movie_ReadObject_From_Stream_Incomplete_4()
        {
            var jsonReader = new SyncPlaybackProgressItemObjectJsonReader();

            using (var stream = TYPE_MOVIE_JSON_INCOMPLETE_4.ToStream())
            {
                var traktPlaybackProgressItem = await jsonReader.ReadObjectAsync(stream);

                traktPlaybackProgressItem.Should().NotBeNull();
                traktPlaybackProgressItem.Id.Should().Be(37U);
                traktPlaybackProgressItem.Progress.Should().Be(65.5f);
                traktPlaybackProgressItem.PausedAt.Should().Be(DateTime.Parse("2015-01-25T22:01:32.000Z").ToUniversalTime());
                traktPlaybackProgressItem.Type.Should().BeNull();
                traktPlaybackProgressItem.Movie.Should().NotBeNull();
                traktPlaybackProgressItem.Movie.Title.Should().Be("Star Wars: The Force Awakens");
                traktPlaybackProgressItem.Movie.Year.Should().Be(2015);
                traktPlaybackProgressItem.Movie.Ids.Should().NotBeNull();
                traktPlaybackProgressItem.Movie.Ids.Trakt.Should().Be(94024U);
                traktPlaybackProgressItem.Movie.Ids.Slug.Should().Be("star-wars-the-force-awakens-2015");
                traktPlaybackProgressItem.Movie.Ids.Imdb.Should().Be("tt2488496");
                traktPlaybackProgressItem.Movie.Ids.Tmdb.Should().Be(140607U);

                traktPlaybackProgressItem.Show.Should().BeNull();
                traktPlaybackProgressItem.Episode.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_SyncPlaybackProgressItemObjectJsonReader_Movie_ReadObject_From_Stream_Incomplete_5()
        {
            var jsonReader = new SyncPlaybackProgressItemObjectJsonReader();

            using (var stream = TYPE_MOVIE_JSON_INCOMPLETE_5.ToStream())
            {
                var traktPlaybackProgressItem = await jsonReader.ReadObjectAsync(stream);

                traktPlaybackProgressItem.Should().NotBeNull();
                traktPlaybackProgressItem.Id.Should().Be(37U);
                traktPlaybackProgressItem.Progress.Should().Be(65.5f);
                traktPlaybackProgressItem.PausedAt.Should().Be(DateTime.Parse("2015-01-25T22:01:32.000Z").ToUniversalTime());
                traktPlaybackProgressItem.Type.Should().Be(TraktSyncType.Movie);
                traktPlaybackProgressItem.Movie.Should().BeNull();

                traktPlaybackProgressItem.Show.Should().BeNull();
                traktPlaybackProgressItem.Episode.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_SyncPlaybackProgressItemObjectJsonReader_Movie_ReadObject_From_Stream_Incomplete_6()
        {
            var jsonReader = new SyncPlaybackProgressItemObjectJsonReader();

            using (var stream = TYPE_MOVIE_JSON_INCOMPLETE_6.ToStream())
            {
                var traktPlaybackProgressItem = await jsonReader.ReadObjectAsync(stream);

                traktPlaybackProgressItem.Should().NotBeNull();
                traktPlaybackProgressItem.Id.Should().Be(37U);
                traktPlaybackProgressItem.Progress.Should().BeNull();
                traktPlaybackProgressItem.PausedAt.Should().BeNull();
                traktPlaybackProgressItem.Type.Should().BeNull();
                traktPlaybackProgressItem.Movie.Should().BeNull();

                traktPlaybackProgressItem.Show.Should().BeNull();
                traktPlaybackProgressItem.Episode.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_SyncPlaybackProgressItemObjectJsonReader_Movie_ReadObject_From_Stream_Incomplete_7()
        {
            var jsonReader = new SyncPlaybackProgressItemObjectJsonReader();

            using (var stream = TYPE_MOVIE_JSON_INCOMPLETE_7.ToStream())
            {
                var traktPlaybackProgressItem = await jsonReader.ReadObjectAsync(stream);

                traktPlaybackProgressItem.Should().NotBeNull();
                traktPlaybackProgressItem.Id.Should().Be(0);
                traktPlaybackProgressItem.Progress.Should().Be(65.5f);
                traktPlaybackProgressItem.PausedAt.Should().BeNull();
                traktPlaybackProgressItem.Type.Should().BeNull();
                traktPlaybackProgressItem.Movie.Should().BeNull();

                traktPlaybackProgressItem.Show.Should().BeNull();
                traktPlaybackProgressItem.Episode.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_SyncPlaybackProgressItemObjectJsonReader_Movie_ReadObject_From_Stream_Incomplete_8()
        {
            var jsonReader = new SyncPlaybackProgressItemObjectJsonReader();

            using (var stream = TYPE_MOVIE_JSON_INCOMPLETE_8.ToStream())
            {
                var traktPlaybackProgressItem = await jsonReader.ReadObjectAsync(stream);

                traktPlaybackProgressItem.Should().NotBeNull();
                traktPlaybackProgressItem.Id.Should().Be(0U);
                traktPlaybackProgressItem.Progress.Should().BeNull();
                traktPlaybackProgressItem.PausedAt.Should().Be(DateTime.Parse("2015-01-25T22:01:32.000Z").ToUniversalTime());
                traktPlaybackProgressItem.Type.Should().BeNull();
                traktPlaybackProgressItem.Movie.Should().BeNull();

                traktPlaybackProgressItem.Show.Should().BeNull();
                traktPlaybackProgressItem.Episode.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_SyncPlaybackProgressItemObjectJsonReader_Movie_ReadObject_From_Stream_Incomplete_9()
        {
            var jsonReader = new SyncPlaybackProgressItemObjectJsonReader();

            using (var stream = TYPE_MOVIE_JSON_INCOMPLETE_9.ToStream())
            {
                var traktPlaybackProgressItem = await jsonReader.ReadObjectAsync(stream);

                traktPlaybackProgressItem.Should().NotBeNull();
                traktPlaybackProgressItem.Id.Should().Be(0U);
                traktPlaybackProgressItem.Progress.Should().BeNull();
                traktPlaybackProgressItem.PausedAt.Should().BeNull();
                traktPlaybackProgressItem.Type.Should().Be(TraktSyncType.Movie);
                traktPlaybackProgressItem.Movie.Should().BeNull();

                traktPlaybackProgressItem.Show.Should().BeNull();
                traktPlaybackProgressItem.Episode.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_SyncPlaybackProgressItemObjectJsonReader_Movie_ReadObject_From_Stream_Incomplete_10()
        {
            var jsonReader = new SyncPlaybackProgressItemObjectJsonReader();

            using (var stream = TYPE_MOVIE_JSON_INCOMPLETE_10.ToStream())
            {
                var traktPlaybackProgressItem = await jsonReader.ReadObjectAsync(stream);

                traktPlaybackProgressItem.Should().NotBeNull();
                traktPlaybackProgressItem.Id.Should().Be(0U);
                traktPlaybackProgressItem.Progress.Should().BeNull();
                traktPlaybackProgressItem.PausedAt.Should().BeNull();
                traktPlaybackProgressItem.Type.Should().BeNull();
                traktPlaybackProgressItem.Movie.Should().NotBeNull();
                traktPlaybackProgressItem.Movie.Title.Should().Be("Star Wars: The Force Awakens");
                traktPlaybackProgressItem.Movie.Year.Should().Be(2015);
                traktPlaybackProgressItem.Movie.Ids.Should().NotBeNull();
                traktPlaybackProgressItem.Movie.Ids.Trakt.Should().Be(94024U);
                traktPlaybackProgressItem.Movie.Ids.Slug.Should().Be("star-wars-the-force-awakens-2015");
                traktPlaybackProgressItem.Movie.Ids.Imdb.Should().Be("tt2488496");
                traktPlaybackProgressItem.Movie.Ids.Tmdb.Should().Be(140607U);

                traktPlaybackProgressItem.Show.Should().BeNull();
                traktPlaybackProgressItem.Episode.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_SyncPlaybackProgressItemObjectJsonReader_Movie_ReadObject_From_Stream_Not_Valid_1()
        {
            var jsonReader = new SyncPlaybackProgressItemObjectJsonReader();

            using (var stream = TYPE_MOVIE_JSON_NOT_VALID_1.ToStream())
            {
                var traktPlaybackProgressItem = await jsonReader.ReadObjectAsync(stream);

                traktPlaybackProgressItem.Should().NotBeNull();
                traktPlaybackProgressItem.Id.Should().Be(0U);
                traktPlaybackProgressItem.Progress.Should().Be(65.5f);
                traktPlaybackProgressItem.PausedAt.Should().Be(DateTime.Parse("2015-01-25T22:01:32.000Z").ToUniversalTime());
                traktPlaybackProgressItem.Type.Should().Be(TraktSyncType.Movie);
                traktPlaybackProgressItem.Movie.Should().NotBeNull();
                traktPlaybackProgressItem.Movie.Title.Should().Be("Star Wars: The Force Awakens");
                traktPlaybackProgressItem.Movie.Year.Should().Be(2015);
                traktPlaybackProgressItem.Movie.Ids.Should().NotBeNull();
                traktPlaybackProgressItem.Movie.Ids.Trakt.Should().Be(94024U);
                traktPlaybackProgressItem.Movie.Ids.Slug.Should().Be("star-wars-the-force-awakens-2015");
                traktPlaybackProgressItem.Movie.Ids.Imdb.Should().Be("tt2488496");
                traktPlaybackProgressItem.Movie.Ids.Tmdb.Should().Be(140607U);

                traktPlaybackProgressItem.Show.Should().BeNull();
                traktPlaybackProgressItem.Episode.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_SyncPlaybackProgressItemObjectJsonReader_Movie_ReadObject_From_Stream_Not_Valid_2()
        {
            var jsonReader = new SyncPlaybackProgressItemObjectJsonReader();

            using (var stream = TYPE_MOVIE_JSON_NOT_VALID_2.ToStream())
            {
                var traktPlaybackProgressItem = await jsonReader.ReadObjectAsync(stream);

                traktPlaybackProgressItem.Should().NotBeNull();
                traktPlaybackProgressItem.Id.Should().Be(37U);
                traktPlaybackProgressItem.Progress.Should().BeNull();
                traktPlaybackProgressItem.PausedAt.Should().Be(DateTime.Parse("2015-01-25T22:01:32.000Z").ToUniversalTime());
                traktPlaybackProgressItem.Type.Should().Be(TraktSyncType.Movie);
                traktPlaybackProgressItem.Movie.Should().NotBeNull();
                traktPlaybackProgressItem.Movie.Title.Should().Be("Star Wars: The Force Awakens");
                traktPlaybackProgressItem.Movie.Year.Should().Be(2015);
                traktPlaybackProgressItem.Movie.Ids.Should().NotBeNull();
                traktPlaybackProgressItem.Movie.Ids.Trakt.Should().Be(94024U);
                traktPlaybackProgressItem.Movie.Ids.Slug.Should().Be("star-wars-the-force-awakens-2015");
                traktPlaybackProgressItem.Movie.Ids.Imdb.Should().Be("tt2488496");
                traktPlaybackProgressItem.Movie.Ids.Tmdb.Should().Be(140607U);

                traktPlaybackProgressItem.Show.Should().BeNull();
                traktPlaybackProgressItem.Episode.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_SyncPlaybackProgressItemObjectJsonReader_Movie_ReadObject_From_Stream_Not_Valid_3()
        {
            var jsonReader = new SyncPlaybackProgressItemObjectJsonReader();

            using (var stream = TYPE_MOVIE_JSON_NOT_VALID_3.ToStream())
            {
                var traktPlaybackProgressItem = await jsonReader.ReadObjectAsync(stream);

                traktPlaybackProgressItem.Should().NotBeNull();
                traktPlaybackProgressItem.Id.Should().Be(37U);
                traktPlaybackProgressItem.Progress.Should().Be(65.5f);
                traktPlaybackProgressItem.PausedAt.Should().BeNull();
                traktPlaybackProgressItem.Type.Should().Be(TraktSyncType.Movie);
                traktPlaybackProgressItem.Movie.Should().NotBeNull();
                traktPlaybackProgressItem.Movie.Title.Should().Be("Star Wars: The Force Awakens");
                traktPlaybackProgressItem.Movie.Year.Should().Be(2015);
                traktPlaybackProgressItem.Movie.Ids.Should().NotBeNull();
                traktPlaybackProgressItem.Movie.Ids.Trakt.Should().Be(94024U);
                traktPlaybackProgressItem.Movie.Ids.Slug.Should().Be("star-wars-the-force-awakens-2015");
                traktPlaybackProgressItem.Movie.Ids.Imdb.Should().Be("tt2488496");
                traktPlaybackProgressItem.Movie.Ids.Tmdb.Should().Be(140607U);

                traktPlaybackProgressItem.Show.Should().BeNull();
                traktPlaybackProgressItem.Episode.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_SyncPlaybackProgressItemObjectJsonReader_Movie_ReadObject_From_Stream_Not_Valid_4()
        {
            var jsonReader = new SyncPlaybackProgressItemObjectJsonReader();

            using (var stream = TYPE_MOVIE_JSON_NOT_VALID_4.ToStream())
            {
                var traktPlaybackProgressItem = await jsonReader.ReadObjectAsync(stream);

                traktPlaybackProgressItem.Should().NotBeNull();
                traktPlaybackProgressItem.Id.Should().Be(37U);
                traktPlaybackProgressItem.Progress.Should().Be(65.5f);
                traktPlaybackProgressItem.PausedAt.Should().Be(DateTime.Parse("2015-01-25T22:01:32.000Z").ToUniversalTime());
                traktPlaybackProgressItem.Type.Should().BeNull();
                traktPlaybackProgressItem.Movie.Should().NotBeNull();
                traktPlaybackProgressItem.Movie.Title.Should().Be("Star Wars: The Force Awakens");
                traktPlaybackProgressItem.Movie.Year.Should().Be(2015);
                traktPlaybackProgressItem.Movie.Ids.Should().NotBeNull();
                traktPlaybackProgressItem.Movie.Ids.Trakt.Should().Be(94024U);
                traktPlaybackProgressItem.Movie.Ids.Slug.Should().Be("star-wars-the-force-awakens-2015");
                traktPlaybackProgressItem.Movie.Ids.Imdb.Should().Be("tt2488496");
                traktPlaybackProgressItem.Movie.Ids.Tmdb.Should().Be(140607U);

                traktPlaybackProgressItem.Show.Should().BeNull();
                traktPlaybackProgressItem.Episode.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_SyncPlaybackProgressItemObjectJsonReader_Movie_ReadObject_From_Stream_Not_Valid_5()
        {
            var jsonReader = new SyncPlaybackProgressItemObjectJsonReader();

            using (var stream = TYPE_MOVIE_JSON_NOT_VALID_5.ToStream())
            {
                var traktPlaybackProgressItem = await jsonReader.ReadObjectAsync(stream);

                traktPlaybackProgressItem.Should().NotBeNull();
                traktPlaybackProgressItem.Id.Should().Be(37U);
                traktPlaybackProgressItem.Progress.Should().Be(65.5f);
                traktPlaybackProgressItem.PausedAt.Should().Be(DateTime.Parse("2015-01-25T22:01:32.000Z").ToUniversalTime());
                traktPlaybackProgressItem.Type.Should().Be(TraktSyncType.Movie);
                traktPlaybackProgressItem.Movie.Should().BeNull();

                traktPlaybackProgressItem.Show.Should().BeNull();
                traktPlaybackProgressItem.Episode.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_SyncPlaybackProgressItemObjectJsonReader_Movie_ReadObject_From_Stream_Not_Valid_6()
        {
            var jsonReader = new SyncPlaybackProgressItemObjectJsonReader();

            using (var stream = TYPE_MOVIE_JSON_NOT_VALID_6.ToStream())
            {
                var traktPlaybackProgressItem = await jsonReader.ReadObjectAsync(stream);

                traktPlaybackProgressItem.Should().NotBeNull();
                traktPlaybackProgressItem.Id.Should().Be(0U);
                traktPlaybackProgressItem.Progress.Should().BeNull();
                traktPlaybackProgressItem.PausedAt.Should().BeNull();
                traktPlaybackProgressItem.Type.Should().BeNull();
                traktPlaybackProgressItem.Movie.Should().BeNull();
                traktPlaybackProgressItem.Show.Should().BeNull();
                traktPlaybackProgressItem.Episode.Should().BeNull();
            }
        }
    }
}
