﻿namespace TraktNet.Objects.Basic.Tests.Json.Reader
{
    using FluentAssertions;
    using System.Threading.Tasks;
    using Trakt.NET.Tests.Utility;
    using Trakt.NET.Tests.Utility.Traits;
    using TraktNet.Enums;
    using TraktNet.Objects.Basic.Json.Reader;
    using Xunit;

    [TestCategory("Objects.Basic.JsonReader")]
    public partial class SearchResultObjectJsonReader_Tests
    {
        [Fact]
        public async Task Test_SearchResultObjectJsonReader_Person_ReadObject_From_Stream_Complete()
        {
            var jsonReader = new SearchResultObjectJsonReader();

            using (var stream = TYPE_PERSON_JSON_COMPLETE.ToStream())
            {
                var traktSearchResultItem = await jsonReader.ReadObjectAsync(stream);

                traktSearchResultItem.Should().NotBeNull();
                traktSearchResultItem.Type.Should().Be(TraktSearchResultType.Person);
                traktSearchResultItem.Score.Should().Be(46.29501f);
                traktSearchResultItem.Person.Should().NotBeNull();
                traktSearchResultItem.Person.Name.Should().Be("Bryan Cranston");
                traktSearchResultItem.Person.Ids.Should().NotBeNull();
                traktSearchResultItem.Person.Ids.Trakt.Should().Be(297737U);
                traktSearchResultItem.Person.Ids.Slug.Should().Be("bryan-cranston");
                traktSearchResultItem.Person.Ids.Imdb.Should().Be("nm0186505");
                traktSearchResultItem.Person.Ids.Tmdb.Should().Be(17419U);
                traktSearchResultItem.Person.Ids.TvRage.Should().Be(1797U);

                traktSearchResultItem.Movie.Should().BeNull();
                traktSearchResultItem.Show.Should().BeNull();
                traktSearchResultItem.Episode.Should().BeNull();
                traktSearchResultItem.List.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_SearchResultObjectJsonReader_Person_ReadObject_From_Stream_Incomplete_1()
        {
            var jsonReader = new SearchResultObjectJsonReader();

            using (var stream = TYPE_PERSON_JSON_INCOMPLETE_1.ToStream())
            {
                var traktSearchResultItem = await jsonReader.ReadObjectAsync(stream);

                traktSearchResultItem.Should().NotBeNull();
                traktSearchResultItem.Type.Should().BeNull();
                traktSearchResultItem.Score.Should().Be(46.29501f);
                traktSearchResultItem.Person.Should().NotBeNull();
                traktSearchResultItem.Person.Name.Should().Be("Bryan Cranston");
                traktSearchResultItem.Person.Ids.Should().NotBeNull();
                traktSearchResultItem.Person.Ids.Trakt.Should().Be(297737U);
                traktSearchResultItem.Person.Ids.Slug.Should().Be("bryan-cranston");
                traktSearchResultItem.Person.Ids.Imdb.Should().Be("nm0186505");
                traktSearchResultItem.Person.Ids.Tmdb.Should().Be(17419U);
                traktSearchResultItem.Person.Ids.TvRage.Should().Be(1797U);

                traktSearchResultItem.Movie.Should().BeNull();
                traktSearchResultItem.Show.Should().BeNull();
                traktSearchResultItem.Episode.Should().BeNull();
                traktSearchResultItem.List.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_SearchResultObjectJsonReader_Person_ReadObject_From_Stream_Incomplete_2()
        {
            var jsonReader = new SearchResultObjectJsonReader();

            using (var stream = TYPE_PERSON_JSON_INCOMPLETE_2.ToStream())
            {
                var traktSearchResultItem = await jsonReader.ReadObjectAsync(stream);

                traktSearchResultItem.Should().NotBeNull();
                traktSearchResultItem.Type.Should().Be(TraktSearchResultType.Person);
                traktSearchResultItem.Score.Should().BeNull();
                traktSearchResultItem.Person.Should().NotBeNull();
                traktSearchResultItem.Person.Name.Should().Be("Bryan Cranston");
                traktSearchResultItem.Person.Ids.Should().NotBeNull();
                traktSearchResultItem.Person.Ids.Trakt.Should().Be(297737U);
                traktSearchResultItem.Person.Ids.Slug.Should().Be("bryan-cranston");
                traktSearchResultItem.Person.Ids.Imdb.Should().Be("nm0186505");
                traktSearchResultItem.Person.Ids.Tmdb.Should().Be(17419U);
                traktSearchResultItem.Person.Ids.TvRage.Should().Be(1797U);

                traktSearchResultItem.Movie.Should().BeNull();
                traktSearchResultItem.Show.Should().BeNull();
                traktSearchResultItem.Episode.Should().BeNull();
                traktSearchResultItem.List.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_SearchResultObjectJsonReader_Person_ReadObject_From_Stream_Incomplete_3()
        {
            var jsonReader = new SearchResultObjectJsonReader();

            using (var stream = TYPE_PERSON_JSON_INCOMPLETE_3.ToStream())
            {
                var traktSearchResultItem = await jsonReader.ReadObjectAsync(stream);

                traktSearchResultItem.Should().NotBeNull();
                traktSearchResultItem.Type.Should().Be(TraktSearchResultType.Person);
                traktSearchResultItem.Score.Should().Be(46.29501f);
                traktSearchResultItem.Person.Should().BeNull();

                traktSearchResultItem.Movie.Should().BeNull();
                traktSearchResultItem.Show.Should().BeNull();
                traktSearchResultItem.Episode.Should().BeNull();
                traktSearchResultItem.List.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_SearchResultObjectJsonReader_Person_ReadObject_From_Stream_Incomplete_4()
        {
            var jsonReader = new SearchResultObjectJsonReader();

            using (var stream = TYPE_PERSON_JSON_INCOMPLETE_4.ToStream())
            {
                var traktSearchResultItem = await jsonReader.ReadObjectAsync(stream);

                traktSearchResultItem.Should().NotBeNull();
                traktSearchResultItem.Type.Should().Be(TraktSearchResultType.Person);
                traktSearchResultItem.Score.Should().BeNull();
                traktSearchResultItem.Person.Should().BeNull();

                traktSearchResultItem.Movie.Should().BeNull();
                traktSearchResultItem.Show.Should().BeNull();
                traktSearchResultItem.Episode.Should().BeNull();
                traktSearchResultItem.List.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_SearchResultObjectJsonReader_Person_ReadObject_From_Stream_Incomplete_5()
        {
            var jsonReader = new SearchResultObjectJsonReader();

            using (var stream = TYPE_PERSON_JSON_INCOMPLETE_5.ToStream())
            {
                var traktSearchResultItem = await jsonReader.ReadObjectAsync(stream);

                traktSearchResultItem.Should().NotBeNull();
                traktSearchResultItem.Type.Should().BeNull();
                traktSearchResultItem.Score.Should().Be(46.29501f);
                traktSearchResultItem.Person.Should().BeNull();

                traktSearchResultItem.Movie.Should().BeNull();
                traktSearchResultItem.Show.Should().BeNull();
                traktSearchResultItem.Episode.Should().BeNull();
                traktSearchResultItem.List.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_SearchResultObjectJsonReader_Person_ReadObject_From_Stream_Incomplete_6()
        {
            var jsonReader = new SearchResultObjectJsonReader();

            using (var stream = TYPE_PERSON_JSON_INCOMPLETE_6.ToStream())
            {
                var traktSearchResultItem = await jsonReader.ReadObjectAsync(stream);

                traktSearchResultItem.Should().NotBeNull();
                traktSearchResultItem.Type.Should().BeNull();
                traktSearchResultItem.Score.Should().BeNull();
                traktSearchResultItem.Person.Should().NotBeNull();
                traktSearchResultItem.Person.Name.Should().Be("Bryan Cranston");
                traktSearchResultItem.Person.Ids.Should().NotBeNull();
                traktSearchResultItem.Person.Ids.Trakt.Should().Be(297737U);
                traktSearchResultItem.Person.Ids.Slug.Should().Be("bryan-cranston");
                traktSearchResultItem.Person.Ids.Imdb.Should().Be("nm0186505");
                traktSearchResultItem.Person.Ids.Tmdb.Should().Be(17419U);
                traktSearchResultItem.Person.Ids.TvRage.Should().Be(1797U);

                traktSearchResultItem.Movie.Should().BeNull();
                traktSearchResultItem.Show.Should().BeNull();
                traktSearchResultItem.Episode.Should().BeNull();
                traktSearchResultItem.List.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_SearchResultObjectJsonReader_Person_ReadObject_From_Stream_Not_Valid_1()
        {
            var jsonReader = new SearchResultObjectJsonReader();

            using (var stream = TYPE_PERSON_JSON_NOT_VALID_1.ToStream())
            {
                var traktSearchResultItem = await jsonReader.ReadObjectAsync(stream);

                traktSearchResultItem.Should().NotBeNull();
                traktSearchResultItem.Type.Should().BeNull();
                traktSearchResultItem.Score.Should().Be(46.29501f);
                traktSearchResultItem.Person.Should().NotBeNull();
                traktSearchResultItem.Person.Name.Should().Be("Bryan Cranston");
                traktSearchResultItem.Person.Ids.Should().NotBeNull();
                traktSearchResultItem.Person.Ids.Trakt.Should().Be(297737U);
                traktSearchResultItem.Person.Ids.Slug.Should().Be("bryan-cranston");
                traktSearchResultItem.Person.Ids.Imdb.Should().Be("nm0186505");
                traktSearchResultItem.Person.Ids.Tmdb.Should().Be(17419U);
                traktSearchResultItem.Person.Ids.TvRage.Should().Be(1797U);

                traktSearchResultItem.Movie.Should().BeNull();
                traktSearchResultItem.Show.Should().BeNull();
                traktSearchResultItem.Episode.Should().BeNull();
                traktSearchResultItem.List.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_SearchResultObjectJsonReader_Person_ReadObject_From_Stream_Not_Valid_2()
        {
            var jsonReader = new SearchResultObjectJsonReader();

            using (var stream = TYPE_PERSON_JSON_NOT_VALID_2.ToStream())
            {
                var traktSearchResultItem = await jsonReader.ReadObjectAsync(stream);

                traktSearchResultItem.Should().NotBeNull();
                traktSearchResultItem.Type.Should().Be(TraktSearchResultType.Person);
                traktSearchResultItem.Score.Should().BeNull();
                traktSearchResultItem.Person.Should().NotBeNull();
                traktSearchResultItem.Person.Name.Should().Be("Bryan Cranston");
                traktSearchResultItem.Person.Ids.Should().NotBeNull();
                traktSearchResultItem.Person.Ids.Trakt.Should().Be(297737U);
                traktSearchResultItem.Person.Ids.Slug.Should().Be("bryan-cranston");
                traktSearchResultItem.Person.Ids.Imdb.Should().Be("nm0186505");
                traktSearchResultItem.Person.Ids.Tmdb.Should().Be(17419U);
                traktSearchResultItem.Person.Ids.TvRage.Should().Be(1797U);

                traktSearchResultItem.Movie.Should().BeNull();
                traktSearchResultItem.Show.Should().BeNull();
                traktSearchResultItem.Episode.Should().BeNull();
                traktSearchResultItem.List.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_SearchResultObjectJsonReader_Person_ReadObject_From_Stream_Not_Valid_3()
        {
            var jsonReader = new SearchResultObjectJsonReader();

            using (var stream = TYPE_PERSON_JSON_NOT_VALID_3.ToStream())
            {
                var traktSearchResultItem = await jsonReader.ReadObjectAsync(stream);

                traktSearchResultItem.Should().NotBeNull();
                traktSearchResultItem.Type.Should().Be(TraktSearchResultType.Person);
                traktSearchResultItem.Score.Should().Be(46.29501f);
                traktSearchResultItem.Person.Should().BeNull();

                traktSearchResultItem.Movie.Should().BeNull();
                traktSearchResultItem.Show.Should().BeNull();
                traktSearchResultItem.Episode.Should().BeNull();
                traktSearchResultItem.List.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_SearchResultObjectJsonReader_Person_ReadObject_From_Stream_Not_Valid_4()
        {
            var jsonReader = new SearchResultObjectJsonReader();

            using (var stream = TYPE_PERSON_JSON_NOT_VALID_4.ToStream())
            {
                var traktSearchResultItem = await jsonReader.ReadObjectAsync(stream);

                traktSearchResultItem.Should().NotBeNull();
                traktSearchResultItem.Type.Should().BeNull();
                traktSearchResultItem.Score.Should().BeNull();
                traktSearchResultItem.Person.Should().BeNull();
                traktSearchResultItem.Movie.Should().BeNull();
                traktSearchResultItem.Show.Should().BeNull();
                traktSearchResultItem.Episode.Should().BeNull();
                traktSearchResultItem.List.Should().BeNull();
            }
        }
    }
}
