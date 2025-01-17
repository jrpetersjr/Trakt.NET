﻿namespace TraktNet.Parameters.Tests.Filter
{
    using FluentAssertions;
    using System.Collections.Generic;
    using Trakt.NET.Tests.Utility.Traits;
    using TraktNet.Enums;
    using TraktNet.Parameters;
    using Xunit;

    [TestCategory("Parameters.Filter")]
    public partial class TraktShowFilterBuilder_Tests
    {
        [Fact]
        public void Test_TraktFilter_ShowFilterBuilder_ToString_Empty()
        {
            ITraktShowFilter filter = TraktFilter.NewShowFilter().Build();
            filter.ToString().Should().NotBeNull().And.BeEmpty();
        }

        [Fact]
        public void Test_TraktFilter_ShowFilterBuilder_WithQuery_ToString()
        {
            ITraktShowFilter filter = TraktFilter.NewShowFilter()
                .WithQuery("test query")
                .Build();

            filter.ToString().Should().Be("query=test query");
        }

        [Fact]
        public void Test_TraktFilter_ShowFilterBuilder_WithYear_ToString()
        {
            ITraktShowFilter filter = TraktFilter.NewShowFilter()
                .WithYear(2022)
                .Build();

            filter.ToString().Should().Be("years=2022");
        }

        [Fact]
        public void Test_TraktFilter_ShowFilterBuilder_WithYears_ToString()
        {
            ITraktShowFilter filter = TraktFilter.NewShowFilter()
                .WithYears(2020, 2022)
                .Build();

            filter.ToString().Should().Be("years=2020-2022");
        }

        [Fact]
        public void Test_TraktFilter_ShowFilterBuilder_WithGenres_Params_ToString()
        {
            ITraktShowFilter filter = TraktFilter.NewShowFilter()
                .WithGenres("action", "drama")
                .Build();

            filter.ToString().Should().Be("genres=action,drama");
        }

        [Fact]
        public void Test_TraktFilter_ShowFilterBuilder_WithGenres_ToString()
        {
            ITraktShowFilter filter = TraktFilter.NewShowFilter()
                .WithGenres(new List<string> { "action", "drama" })
                .Build();

            filter.ToString().Should().Be("genres=action,drama");
        }

        [Fact]
        public void Test_TraktFilter_ShowFilterBuilder_WithLanguages_Params_ToString()
        {
            ITraktShowFilter filter = TraktFilter.NewShowFilter()
                .WithLanguages("de", "en")
                .Build();

            filter.ToString().Should().Be("languages=de,en");
        }

        [Fact]
        public void Test_TraktFilter_ShowFilterBuilder_WithLanguages_ToString()
        {
            ITraktShowFilter filter = TraktFilter.NewShowFilter()
                .WithLanguages(new List<string> { "de", "en" })
                .Build();

            filter.ToString().Should().Be("languages=de,en");
        }

        [Fact]
        public void Test_TraktFilter_ShowFilterBuilder_WithCountries_Params_ToString()
        {
            ITraktShowFilter filter = TraktFilter.NewShowFilter()
                .WithCountries("de", "us")
                .Build();

            filter.ToString().Should().Be("countries=de,us");
        }

        [Fact]
        public void Test_TraktFilter_ShowFilterBuilder_WithCountries_ToString()
        {
            ITraktShowFilter filter = TraktFilter.NewShowFilter()
                .WithCountries(new List<string> { "de", "us" })
                .Build();

            filter.ToString().Should().Be("countries=de,us");
        }

        [Fact]
        public void Test_TraktFilter_ShowFilterBuilder_WithRuntimes_ToString()
        {
            ITraktShowFilter filter = TraktFilter.NewShowFilter()
                .WithRuntimes(90, 120)
                .Build();

            filter.ToString().Should().Be("runtimes=90-120");
        }

        [Fact]
        public void Test_TraktFilter_ShowFilterBuilder_WithStudios_Params_ToString()
        {
            ITraktShowFilter filter = TraktFilter.NewShowFilter()
                .WithStudios("marvel-studios", "disney-studios")
                .Build();

            filter.ToString().Should().Be("studios=marvel-studios,disney-studios");
        }

        [Fact]
        public void Test_TraktFilter_ShowFilterBuilder_WithStudios_ToString()
        {
            ITraktShowFilter filter = TraktFilter.NewShowFilter()
                .WithStudios(new List<string> { "marvel-studios", "disney-studios" })
                .Build();

            filter.ToString().Should().Be("studios=marvel-studios,disney-studios");
        }

        [Fact]
        public void Test_TraktFilter_ShowFilterBuilder_WithRatings_ToString()
        {
            ITraktShowFilter filter = TraktFilter.NewShowFilter()
                .WithRatings(70, 90)
                .Build();

            filter.ToString().Should().Be("ratings=70-90");
        }

        [Fact]
        public void Test_TraktFilter_ShowFilterBuilder_WithVotes_ToString()
        {
            ITraktShowFilter filter = TraktFilter.NewShowFilter()
                .WithVotes(7000, 9000)
                .Build();

            filter.ToString().Should().Be("votes=7000-9000");
        }

        [Fact]
        public void Test_TraktFilter_ShowFilterBuilder_WithCertifications_Params_ToString()
        {
            ITraktShowFilter filter = TraktFilter.NewShowFilter()
                .WithCertifications("pg-13", "tv-pg")
                .Build();

            filter.ToString().Should().Be("certifications=pg-13,tv-pg");
        }

        [Fact]
        public void Test_TraktFilter_ShowFilterBuilder_WithCertifications_ToString()
        {
            ITraktShowFilter filter = TraktFilter.NewShowFilter()
                .WithCertifications(new List<string> { "pg-13", "tv-pg" })
                .Build();

            filter.ToString().Should().Be("certifications=pg-13,tv-pg");
        }

        [Fact]
        public void Test_TraktFilter_ShowFilterBuilder_WithTMDBRatings_ToString()
        {
            ITraktShowFilter filter = TraktFilter.NewShowFilter()
                .WithTMDBRatings(7, 9)
                .Build();

            filter.ToString().Should().Be("tmdb_ratings=7.0-9.0");
        }

        [Fact]
        public void Test_TraktFilter_ShowFilterBuilder_WithTMDBVotes_ToString()
        {
            ITraktShowFilter filter = TraktFilter.NewShowFilter()
                .WithTMDBVotes(7000, 9000)
                .Build();

            filter.ToString().Should().Be("tmdb_votes=7000-9000");
        }

        [Fact]
        public void Test_TraktFilter_ShowFilterBuilder_WithIMDBRatings_ToString()
        {
            ITraktShowFilter filter = TraktFilter.NewShowFilter()
                .WithIMDBRatings(7, 9)
                .Build();

            filter.ToString().Should().Be("imdb_ratings=7.0-9.0");
        }

        [Fact]
        public void Test_TraktFilter_ShowFilterBuilder_WithIMDBVotes_ToString()
        {
            ITraktShowFilter filter = TraktFilter.NewShowFilter()
                .WithIMDBVotes(7000, 9000)
                .Build();

            filter.ToString().Should().Be("imdb_votes=7000-9000");
        }

        [Fact]
        public void Test_TraktFilter_ShowFilterBuilder_WithNetworks_Params_ToString()
        {
            ITraktShowFilter filter = TraktFilter.NewShowFilter()
                .WithNetworks("HBO", "Netflix")
                .Build();

            filter.ToString().Should().Be("networks=HBO,Netflix");
        }

        [Fact]
        public void Test_TraktFilter_ShowFilterBuilder_WithNetworks_ToString()
        {
            ITraktShowFilter filter = TraktFilter.NewShowFilter()
                .WithNetworks(new List<string> { "HBO", "Netflix" })
                .Build();

            filter.ToString().Should().Be("networks=HBO,Netflix");
        }

        [Fact]
        public void Test_TraktFilter_ShowFilterBuilder_WithStates_Params_ToString()
        {
            var state1 = TraktShowStatus.Continuing;
            var state2 = TraktShowStatus.InProduction;

            ITraktShowFilter filter = TraktFilter.NewShowFilter()
                .WithStates(state1, state2)
                .Build();

            filter.ToString().Should().Be($"status={state1.UriName},{state2.UriName}");
        }

        [Fact]
        public void Test_TraktFilter_ShowFilterBuilder_WithStates_ToString()
        {
            var state1 = TraktShowStatus.Continuing;
            var state2 = TraktShowStatus.InProduction;

            ITraktShowFilter filter = TraktFilter.NewShowFilter()
                .WithStates(new List<TraktShowStatus> { state1, state2 })
                .Build();

            filter.ToString().Should().Be($"status={state1.UriName},{state2.UriName}");
        }

        [Fact]
        public void Test_TraktFilter_ShowFilterBuilder_ToString_Year()
        {
            var state1 = TraktShowStatus.Continuing;
            var state2 = TraktShowStatus.InProduction;

            ITraktShowFilter filter = TraktFilter.NewShowFilter()
                .WithQuery("test query")
                .WithYears(2020, 2022)
                .WithYear(2022) // should overwrite WithYears()
                .WithGenres("action", "drama")
                .WithLanguages("de", "en")
                .WithCountries("de", "us")
                .WithRuntimes(90, 120)
                .WithStudios("marvel-studios", "disney-studios")
                .WithRatings(70, 90)
                .WithVotes(7000, 9000)
                .WithCertifications("pg-13", "tv-pg")
                .WithTMDBRatings(7, 9)
                .WithTMDBVotes(7000, 9000)
                .WithIMDBRatings(7, 9)
                .WithIMDBVotes(7000, 9000)
                .WithNetworks("HBO", "Netflix")
                .WithStates(state1, state2)
                .Build();

            filter.ToString().Should().Be("query=test query" +
                                          "&years=2022" +
                                          "&genres=action,drama" +
                                          "&languages=de,en" +
                                          "&countries=de,us" +
                                          "&runtimes=90-120" +
                                          "&studios=marvel-studios,disney-studios" +
                                          "&certifications=pg-13,tv-pg" +
                                          "&networks=HBO,Netflix" +
                                          $"&status={state1.UriName},{state2.UriName}" +
                                          "&ratings=70-90" +
                                          "&votes=7000-9000" +
                                          "&tmdb_ratings=7.0-9.0" +
                                          "&tmdb_votes=7000-9000" +
                                          "&imdb_ratings=7.0-9.0" +
                                          "&imdb_votes=7000-9000");
        }

        [Fact]
        public void Test_TraktFilter_ShowFilterBuilder_ToString_Years()
        {
            var state1 = TraktShowStatus.Continuing;
            var state2 = TraktShowStatus.InProduction;

            ITraktShowFilter filter = TraktFilter.NewShowFilter()
                .WithQuery("test query")
                .WithYear(2022)
                .WithYears(2020, 2022) // should overwrite WithYear()
                .WithGenres("action", "drama")
                .WithLanguages("de", "en")
                .WithCountries("de", "us")
                .WithRuntimes(90, 120)
                .WithStudios("marvel-studios", "disney-studios")
                .WithRatings(70, 90)
                .WithVotes(7000, 9000)
                .WithCertifications("pg-13", "tv-pg")
                .WithTMDBRatings(7, 9)
                .WithTMDBVotes(7000, 9000)
                .WithIMDBRatings(7, 9)
                .WithIMDBVotes(7000, 9000)
                .WithNetworks("HBO", "Netflix")
                .WithStates(state1, state2)
                .Build();

            filter.ToString().Should().Be("query=test query" +
                                          "&years=2020-2022" +
                                          "&genres=action,drama" +
                                          "&languages=de,en" +
                                          "&countries=de,us" +
                                          "&runtimes=90-120" +
                                          "&studios=marvel-studios,disney-studios" +
                                          "&certifications=pg-13,tv-pg" +
                                          "&networks=HBO,Netflix" +
                                          $"&status={state1.UriName},{state2.UriName}" +
                                          "&ratings=70-90" +
                                          "&votes=7000-9000" +
                                          "&tmdb_ratings=7.0-9.0" +
                                          "&tmdb_votes=7000-9000" +
                                          "&imdb_ratings=7.0-9.0" +
                                          "&imdb_votes=7000-9000");
        }
    }
}
