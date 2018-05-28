﻿namespace TraktApiSharp.Tests.Modules.TraktCheckinsModule
{
    using System;
    using TraktApiSharp.Objects.Basic;
    using TraktApiSharp.Objects.Basic.Implementations;
    using TraktApiSharp.Objects.Get.Episodes;
    using TraktApiSharp.Objects.Get.Episodes.Implementations;
    using TraktApiSharp.Objects.Get.Movies;
    using TraktApiSharp.Objects.Get.Movies.Implementations;
    using TraktApiSharp.Objects.Get.Shows;
    using TraktApiSharp.Objects.Get.Shows.Implementations;

    public partial class TraktCheckinsModule_Tests
    {
        private const string CHECKIN_URI = "checkin";
        private const string APP_VERSION = "app_version";
        private readonly DateTime APP_BUILD_DATE = DateTime.UtcNow;
        private const string MESSAGE = "checkin message";
        private const string FOURSQUARE_VENUE_ID = "venue id";
        private const string FOURSQUARE_VENUE_NAME = "venue name";

        private readonly ITraktSharing SHARING = new TraktSharing
        {
            Facebook = true,
            Google = false,
            Twitter = true
        };

        private ITraktMovie Movie { get; }
        private ITraktEpisode Episode { get; }
        private ITraktShow Show { get; }

        public TraktCheckinsModule_Tests()
        {
            Movie = new TraktMovie
            {
                Title = "Guardians of the Galaxy",
                Year = 2014,
                Ids = new TraktMovieIds
                {
                    Trakt = 28,
                    Slug = "guardians-of-the-galaxy-2014",
                    Imdb = "tt2015381",
                    Tmdb = 118340
                }
            };

            Episode = new TraktEpisode
            {
                Number = 1,
                SeasonNumber = 1,
                Ids = new TraktEpisodeIds
                {
                    Trakt = 16,
                    Tvdb = 349232,
                    Imdb = "tt0959621",
                    Tmdb = 62085,
                    TvRage = 637041
                }
            };

            Show = new TraktShow { Title = "Breaking Bad" };
        }

        private const string MOVIE_CHECKIN_POST_RESPONSE_JSON =
            @"{
                ""id"": 3373536619,
                ""watched_at"": ""2014-08-06T01:11:37.953Z"",
                ""sharing"": {
                  ""facebook"": true,
                  ""twitter"": true,
                  ""tumblr"": false
                },
                ""movie"": {
                  ""title"": ""Guardians of the Galaxy"",
                  ""year"": 2014,
                  ""ids"": {
                    ""trakt"": 28,
                    ""slug"": ""guardians-of-the-galaxy-2014"",
                    ""imdb"": ""tt2015381"",
                    ""tmdb"": 118340
                  }
                }
              }";

        private const string EPISODE_CHECKIN_POST_RESPONSE_JSON =
            @"{
                ""id"": 3373536620,
                ""watched_at"": ""2014-08-06T06:54:36.859Z"",
                ""sharing"": {
                  ""facebook"": true,
                  ""twitter"": true,
                  ""tumblr"": false
                },
                ""episode"": {
                  ""season"": 1,
                  ""number"": 1,
                  ""title"": ""Pilot"",
                  ""ids"": {
                    ""trakt"": 16,
                    ""tvdb"": 349232,
                    ""imdb"": ""tt0959621"",
                    ""tmdb"": 62085,
                    ""tvrage"": 637041
                  }
                },
                ""show"": {
                  ""title"": ""Breaking Bad"",
                  ""year"": 2008,
                  ""ids"": {
                    ""trakt"": 1,
                    ""slug"": ""breaking-bad"",
                    ""tvdb"": 81189,
                    ""imdb"": ""tt0903747"",
                    ""tmdb"": 1396,
                    ""tvrage"": 18164
                  }
                }
              }";
    }
}
