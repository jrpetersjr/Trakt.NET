namespace TraktNet.Modules.Tests.TraktMoviesModule
{
    using FluentAssertions;
    using System;
    using System.Net;
    using System.Threading.Tasks;
    using Trakt.NET.Tests.Utility;
    using Trakt.NET.Tests.Utility.Traits;
    using TraktNet.Exceptions;
    using TraktNet.Objects.Get.Movies;
    using TraktNet.Parameters;
    using TraktNet.Responses;
    using Xunit;

    [TestCategory("Modules.Movies")]
    public partial class TraktMoviesModule_Tests
    {
        private const string GET_MOST_RECOMMENDED_MOVIES_URI = "movies/recommended";

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostRecommendedMovies()
        {
            TraktClient client = TestUtility.GetMockClient(GET_MOST_RECOMMENDED_MOVIES_URI,
                                                           MOST_RECOMMENDED_MOVIES_JSON, 1, 10, 1, MOST_RECOMMENDED_ITEM_COUNT);

            TraktPagedResponse<ITraktMostRecommendedMovie> response = await client.Movies.GetMostRecommendedMoviesAsync();

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(MOST_RECOMMENDED_ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(MOST_RECOMMENDED_ITEM_COUNT);
            response.Limit.Should().Be(10u);
            response.Page.Should().Be(1u);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostRecommendedMovies_Filtered()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_RECOMMENDED_MOVIES_URI}?{FILTER}",
                                                           MOST_RECOMMENDED_MOVIES_JSON, 1, 10, 1, MOST_RECOMMENDED_ITEM_COUNT);

            TraktPagedResponse<ITraktMostRecommendedMovie> response = await client.Movies.GetMostRecommendedMoviesAsync(null, null, FILTER);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(MOST_RECOMMENDED_ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(MOST_RECOMMENDED_ITEM_COUNT);
            response.Limit.Should().Be(10u);
            response.Page.Should().Be(1u);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostRecommendedMovies_With_TimePeriod()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_RECOMMENDED_MOVIES_URI}/{TIME_PERIOD.UriName}",
                                                           MOST_RECOMMENDED_MOVIES_JSON, 1, 10, 1, MOST_RECOMMENDED_ITEM_COUNT);

            TraktPagedResponse<ITraktMostRecommendedMovie> response = await client.Movies.GetMostRecommendedMoviesAsync(TIME_PERIOD);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(MOST_RECOMMENDED_ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(MOST_RECOMMENDED_ITEM_COUNT);
            response.Limit.Should().Be(10u);
            response.Page.Should().Be(1u);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostRecommendedMovies_With_TimePeriod_Filtered()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_RECOMMENDED_MOVIES_URI}/{TIME_PERIOD.UriName}?{FILTER}",
                                                           MOST_RECOMMENDED_MOVIES_JSON, 1, 10, 1, MOST_RECOMMENDED_ITEM_COUNT);

            TraktPagedResponse<ITraktMostRecommendedMovie> response = await client.Movies.GetMostRecommendedMoviesAsync(TIME_PERIOD, null, FILTER);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(MOST_RECOMMENDED_ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(MOST_RECOMMENDED_ITEM_COUNT);
            response.Limit.Should().Be(10u);
            response.Page.Should().Be(1u);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostRecommendedMovies_With_ExtendedInfo()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_RECOMMENDED_MOVIES_URI}?extended={EXTENDED_INFO}",
                                                           MOST_RECOMMENDED_MOVIES_JSON, 1, 10, 1, MOST_RECOMMENDED_ITEM_COUNT);

            TraktPagedResponse<ITraktMostRecommendedMovie> response = await client.Movies.GetMostRecommendedMoviesAsync(null, EXTENDED_INFO);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(MOST_RECOMMENDED_ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(MOST_RECOMMENDED_ITEM_COUNT);
            response.Limit.Should().Be(10u);
            response.Page.Should().Be(1u);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostRecommendedMovies_With_ExtendedInfo_Filtered()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_RECOMMENDED_MOVIES_URI}?extended={EXTENDED_INFO}&{FILTER}",
                                                           MOST_RECOMMENDED_MOVIES_JSON, 1, 10, 1, MOST_RECOMMENDED_ITEM_COUNT);

            TraktPagedResponse<ITraktMostRecommendedMovie> response = await client.Movies.GetMostRecommendedMoviesAsync(null, EXTENDED_INFO, FILTER);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(MOST_RECOMMENDED_ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(MOST_RECOMMENDED_ITEM_COUNT);
            response.Limit.Should().Be(10u);
            response.Page.Should().Be(1u);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostRecommendedMovies_With_Page()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_RECOMMENDED_MOVIES_URI}?page={PAGE}",
                                                           MOST_RECOMMENDED_MOVIES_JSON, PAGE, 10, 1, MOST_RECOMMENDED_ITEM_COUNT);

            var pagedParameters = new TraktPagedParameters(PAGE);
            TraktPagedResponse<ITraktMostRecommendedMovie> response = await client.Movies.GetMostRecommendedMoviesAsync(null, null, null, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(MOST_RECOMMENDED_ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(MOST_RECOMMENDED_ITEM_COUNT);
            response.Limit.Should().Be(10u);
            response.Page.Should().Be(PAGE);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostRecommendedMovies_With_Page_Filtered()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_RECOMMENDED_MOVIES_URI}?page={PAGE}&{FILTER}",
                                                           MOST_RECOMMENDED_MOVIES_JSON, PAGE, 10, 1, MOST_RECOMMENDED_ITEM_COUNT);

            var pagedParameters = new TraktPagedParameters(PAGE);
            TraktPagedResponse<ITraktMostRecommendedMovie> response = await client.Movies.GetMostRecommendedMoviesAsync(null, null, FILTER, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(MOST_RECOMMENDED_ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(MOST_RECOMMENDED_ITEM_COUNT);
            response.Limit.Should().Be(10u);
            response.Page.Should().Be(PAGE);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostRecommendedMovies_With_Limit()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_RECOMMENDED_MOVIES_URI}?limit={LIMIT}",
                                                           MOST_RECOMMENDED_MOVIES_JSON, 1, LIMIT, 1, MOST_RECOMMENDED_ITEM_COUNT);

            var pagedParameters = new TraktPagedParameters(null, LIMIT);
            TraktPagedResponse<ITraktMostRecommendedMovie> response = await client.Movies.GetMostRecommendedMoviesAsync(null, null, null, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(MOST_RECOMMENDED_ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(MOST_RECOMMENDED_ITEM_COUNT);
            response.Limit.Should().Be(LIMIT);
            response.Page.Should().Be(1u);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostRecommendedMovies_With_Limit_Filtered()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_RECOMMENDED_MOVIES_URI}?limit={LIMIT}&{FILTER}",
                                                           MOST_RECOMMENDED_MOVIES_JSON, 1, LIMIT, 1, MOST_RECOMMENDED_ITEM_COUNT);

            var pagedParameters = new TraktPagedParameters(null, LIMIT);
            TraktPagedResponse<ITraktMostRecommendedMovie> response = await client.Movies.GetMostRecommendedMoviesAsync(null, null, FILTER, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(MOST_RECOMMENDED_ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(MOST_RECOMMENDED_ITEM_COUNT);
            response.Limit.Should().Be(LIMIT);
            response.Page.Should().Be(1u);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostRecommendedMovies_With_TimePeriod_And_ExtendedInfo()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_RECOMMENDED_MOVIES_URI}/{TIME_PERIOD.UriName}?extended={EXTENDED_INFO}",
                                                           MOST_RECOMMENDED_MOVIES_JSON, 1, 10, 1, MOST_RECOMMENDED_ITEM_COUNT);

            TraktPagedResponse<ITraktMostRecommendedMovie> response = await client.Movies.GetMostRecommendedMoviesAsync(TIME_PERIOD, EXTENDED_INFO);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(MOST_RECOMMENDED_ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(MOST_RECOMMENDED_ITEM_COUNT);
            response.Limit.Should().Be(10u);
            response.Page.Should().Be(1u);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostRecommendedMovies_With_TimePeriod_And_ExtendedInfo_Filtered()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_RECOMMENDED_MOVIES_URI}/{TIME_PERIOD.UriName}?{FILTER}&extended={EXTENDED_INFO}",
                                                           MOST_RECOMMENDED_MOVIES_JSON, 1, 10, 1, MOST_RECOMMENDED_ITEM_COUNT);

            TraktPagedResponse<ITraktMostRecommendedMovie> response = await client.Movies.GetMostRecommendedMoviesAsync(TIME_PERIOD, EXTENDED_INFO, FILTER);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(MOST_RECOMMENDED_ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(MOST_RECOMMENDED_ITEM_COUNT);
            response.Limit.Should().Be(10u);
            response.Page.Should().Be(1u);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostRecommendedMovies_With_TimePeriod_And_Page()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_RECOMMENDED_MOVIES_URI}/{TIME_PERIOD.UriName}?page={PAGE}",
                                                           MOST_RECOMMENDED_MOVIES_JSON, PAGE, 10, 1, MOST_RECOMMENDED_ITEM_COUNT);

            var pagedParameters = new TraktPagedParameters(PAGE);
            TraktPagedResponse<ITraktMostRecommendedMovie> response = await client.Movies.GetMostRecommendedMoviesAsync(TIME_PERIOD, null, null, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(MOST_RECOMMENDED_ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(MOST_RECOMMENDED_ITEM_COUNT);
            response.Limit.Should().Be(10u);
            response.Page.Should().Be(PAGE);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostRecommendedMovies_With_TimePeriod_And_Page_Filtered()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_RECOMMENDED_MOVIES_URI}/{TIME_PERIOD.UriName}?page={PAGE}&{FILTER}",
                                                           MOST_RECOMMENDED_MOVIES_JSON, PAGE, 10, 1, MOST_RECOMMENDED_ITEM_COUNT);

            var pagedParameters = new TraktPagedParameters(PAGE);
            TraktPagedResponse<ITraktMostRecommendedMovie> response = await client.Movies.GetMostRecommendedMoviesAsync(TIME_PERIOD, null, FILTER, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(MOST_RECOMMENDED_ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(MOST_RECOMMENDED_ITEM_COUNT);
            response.Limit.Should().Be(10u);
            response.Page.Should().Be(PAGE);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostRecommendedMovies_With_TimePeriod_And_Limit()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_RECOMMENDED_MOVIES_URI}/{TIME_PERIOD.UriName}?limit={LIMIT}",
                                                           MOST_RECOMMENDED_MOVIES_JSON, 1, LIMIT, 1, MOST_RECOMMENDED_ITEM_COUNT);

            var pagedParameters = new TraktPagedParameters(null, LIMIT);
            TraktPagedResponse<ITraktMostRecommendedMovie> response = await client.Movies.GetMostRecommendedMoviesAsync(TIME_PERIOD, null, null, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(MOST_RECOMMENDED_ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(MOST_RECOMMENDED_ITEM_COUNT);
            response.Limit.Should().Be(LIMIT);
            response.Page.Should().Be(1u);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostRecommendedMovies_With_TimePeriod_And_Limit_Filtered()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_RECOMMENDED_MOVIES_URI}/{TIME_PERIOD.UriName}?limit={LIMIT}&{FILTER}",
                                                           MOST_RECOMMENDED_MOVIES_JSON, 1, LIMIT, 1, MOST_RECOMMENDED_ITEM_COUNT);

            var pagedParameters = new TraktPagedParameters(null, LIMIT);
            TraktPagedResponse<ITraktMostRecommendedMovie> response = await client.Movies.GetMostRecommendedMoviesAsync(TIME_PERIOD, null, FILTER, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(MOST_RECOMMENDED_ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(MOST_RECOMMENDED_ITEM_COUNT);
            response.Limit.Should().Be(LIMIT);
            response.Page.Should().Be(1u);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostRecommendedMovies_With_ExtendedInfo_And_Page()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_RECOMMENDED_MOVIES_URI}?extended={EXTENDED_INFO}&page={PAGE}",
                                                           MOST_RECOMMENDED_MOVIES_JSON, PAGE, 10, 1, MOST_RECOMMENDED_ITEM_COUNT);

            var pagedParameters = new TraktPagedParameters(PAGE);
            TraktPagedResponse<ITraktMostRecommendedMovie> response = await client.Movies.GetMostRecommendedMoviesAsync(null, EXTENDED_INFO, null, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(MOST_RECOMMENDED_ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(MOST_RECOMMENDED_ITEM_COUNT);
            response.Limit.Should().Be(10u);
            response.Page.Should().Be(PAGE);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostRecommendedMovies_With_ExtendedInfo_And_Page_Filtered()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_RECOMMENDED_MOVIES_URI}?extended={EXTENDED_INFO}&{FILTER}&page={PAGE}",
                                                           MOST_RECOMMENDED_MOVIES_JSON, PAGE, 10, 1, MOST_RECOMMENDED_ITEM_COUNT);

            var pagedParameters = new TraktPagedParameters(PAGE);
            TraktPagedResponse<ITraktMostRecommendedMovie> response = await client.Movies.GetMostRecommendedMoviesAsync(null, EXTENDED_INFO, FILTER, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(MOST_RECOMMENDED_ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(MOST_RECOMMENDED_ITEM_COUNT);
            response.Limit.Should().Be(10u);
            response.Page.Should().Be(PAGE);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostRecommendedMovies_With_ExtendedInfo_And_Limit()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_RECOMMENDED_MOVIES_URI}?extended={EXTENDED_INFO}&limit={LIMIT}",
                                                           MOST_RECOMMENDED_MOVIES_JSON, 1, LIMIT, 1, MOST_RECOMMENDED_ITEM_COUNT);

            var pagedParameters = new TraktPagedParameters(null, LIMIT);
            TraktPagedResponse<ITraktMostRecommendedMovie> response = await client.Movies.GetMostRecommendedMoviesAsync(null, EXTENDED_INFO, null, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(MOST_RECOMMENDED_ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(MOST_RECOMMENDED_ITEM_COUNT);
            response.Limit.Should().Be(LIMIT);
            response.Page.Should().Be(1u);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostRecommendedMovies_With_ExtendedInfo_And_Limit_Filtered()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_RECOMMENDED_MOVIES_URI}?extended={EXTENDED_INFO}&{FILTER}&limit={LIMIT}",
                                                           MOST_RECOMMENDED_MOVIES_JSON, 1, LIMIT, 1, MOST_RECOMMENDED_ITEM_COUNT);

            var pagedParameters = new TraktPagedParameters(null, LIMIT);
            TraktPagedResponse<ITraktMostRecommendedMovie> response = await client.Movies.GetMostRecommendedMoviesAsync(null, EXTENDED_INFO, FILTER, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(MOST_RECOMMENDED_ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(MOST_RECOMMENDED_ITEM_COUNT);
            response.Limit.Should().Be(LIMIT);
            response.Page.Should().Be(1u);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostRecommendedMovies_With_Page_And_Limit()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_RECOMMENDED_MOVIES_URI}?page={PAGE}&limit={LIMIT}",
                                                           MOST_RECOMMENDED_MOVIES_JSON, PAGE, LIMIT, 1, MOST_RECOMMENDED_ITEM_COUNT);

            var pagedParameters = new TraktPagedParameters(PAGE, LIMIT);
            TraktPagedResponse<ITraktMostRecommendedMovie> response = await client.Movies.GetMostRecommendedMoviesAsync(null, null, null, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(MOST_RECOMMENDED_ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(MOST_RECOMMENDED_ITEM_COUNT);
            response.Limit.Should().Be(LIMIT);
            response.Page.Should().Be(PAGE);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostRecommendedMovies_With_Page_And_Limit_Filtered()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_RECOMMENDED_MOVIES_URI}?page={PAGE}&limit={LIMIT}&{FILTER}",
                                                           MOST_RECOMMENDED_MOVIES_JSON, PAGE, LIMIT, 1, MOST_RECOMMENDED_ITEM_COUNT);

            var pagedParameters = new TraktPagedParameters(PAGE, LIMIT);
            TraktPagedResponse<ITraktMostRecommendedMovie> response = await client.Movies.GetMostRecommendedMoviesAsync(null, null, FILTER, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(MOST_RECOMMENDED_ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(MOST_RECOMMENDED_ITEM_COUNT);
            response.Limit.Should().Be(LIMIT);
            response.Page.Should().Be(PAGE);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostRecommendedMovies_With_ExtendedInfo_And_Page_And_Limit()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_RECOMMENDED_MOVIES_URI}?extended={EXTENDED_INFO}&page={PAGE}&limit={LIMIT}",
                                                           MOST_RECOMMENDED_MOVIES_JSON, PAGE, LIMIT, 1, MOST_RECOMMENDED_ITEM_COUNT);

            var pagedParameters = new TraktPagedParameters(PAGE, LIMIT);
            TraktPagedResponse<ITraktMostRecommendedMovie> response = await client.Movies.GetMostRecommendedMoviesAsync(null, EXTENDED_INFO, null, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(MOST_RECOMMENDED_ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(MOST_RECOMMENDED_ITEM_COUNT);
            response.Limit.Should().Be(LIMIT);
            response.Page.Should().Be(PAGE);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostRecommendedMovies_With_ExtendedInfo_And_Page_And_Limit_Filtered()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_RECOMMENDED_MOVIES_URI}?extended={EXTENDED_INFO}&page={PAGE}&limit={LIMIT}&{FILTER}",
                                                           MOST_RECOMMENDED_MOVIES_JSON, PAGE, LIMIT, 1, MOST_RECOMMENDED_ITEM_COUNT);

            var pagedParameters = new TraktPagedParameters(PAGE, LIMIT);
            TraktPagedResponse<ITraktMostRecommendedMovie> response = await client.Movies.GetMostRecommendedMoviesAsync(null, EXTENDED_INFO, FILTER, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(MOST_RECOMMENDED_ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(MOST_RECOMMENDED_ITEM_COUNT);
            response.Limit.Should().Be(LIMIT);
            response.Page.Should().Be(PAGE);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostRecommendedMovies_With_TimePeriod_And_Page_And_Limit()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_RECOMMENDED_MOVIES_URI}/{TIME_PERIOD.UriName}?page={PAGE}&limit={LIMIT}",
                                                           MOST_RECOMMENDED_MOVIES_JSON, PAGE, LIMIT, 1, MOST_RECOMMENDED_ITEM_COUNT);

            var pagedParameters = new TraktPagedParameters(PAGE, LIMIT);
            TraktPagedResponse<ITraktMostRecommendedMovie> response = await client.Movies.GetMostRecommendedMoviesAsync(TIME_PERIOD, null, null, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(MOST_RECOMMENDED_ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(MOST_RECOMMENDED_ITEM_COUNT);
            response.Limit.Should().Be(LIMIT);
            response.Page.Should().Be(PAGE);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostRecommendedMovies_With_TimePeriod_And_Page_And_Limit_Filtered()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_RECOMMENDED_MOVIES_URI}/{TIME_PERIOD.UriName}?page={PAGE}&{FILTER}&limit={LIMIT}",
                                                           MOST_RECOMMENDED_MOVIES_JSON, PAGE, LIMIT, 1, MOST_RECOMMENDED_ITEM_COUNT);

            var pagedParameters = new TraktPagedParameters(PAGE, LIMIT);
            TraktPagedResponse<ITraktMostRecommendedMovie> response = await client.Movies.GetMostRecommendedMoviesAsync(TIME_PERIOD, null, FILTER, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(MOST_RECOMMENDED_ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(MOST_RECOMMENDED_ITEM_COUNT);
            response.Limit.Should().Be(LIMIT);
            response.Page.Should().Be(PAGE);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostRecommendedMovies_Complete()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_RECOMMENDED_MOVIES_URI}/{TIME_PERIOD.UriName}?extended={EXTENDED_INFO}&page={PAGE}&limit={LIMIT}",
                                                           MOST_RECOMMENDED_MOVIES_JSON, PAGE, LIMIT, 1, MOST_RECOMMENDED_ITEM_COUNT);

            var pagedParameters = new TraktPagedParameters(PAGE, LIMIT);
            TraktPagedResponse<ITraktMostRecommendedMovie> response = await client.Movies.GetMostRecommendedMoviesAsync(TIME_PERIOD, EXTENDED_INFO, null, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(MOST_RECOMMENDED_ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(MOST_RECOMMENDED_ITEM_COUNT);
            response.Limit.Should().Be(LIMIT);
            response.Page.Should().Be(PAGE);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetMostRecommendedMovies_Complete_Filtered()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_MOST_RECOMMENDED_MOVIES_URI}/{TIME_PERIOD.UriName}?extended={EXTENDED_INFO}&page={PAGE}&limit={LIMIT}&{FILTER}",
                                                           MOST_RECOMMENDED_MOVIES_JSON, PAGE, LIMIT, 1, MOST_RECOMMENDED_ITEM_COUNT);

            var pagedParameters = new TraktPagedParameters(PAGE, LIMIT);
            TraktPagedResponse<ITraktMostRecommendedMovie> response = await client.Movies.GetMostRecommendedMoviesAsync(TIME_PERIOD, EXTENDED_INFO, FILTER, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(MOST_RECOMMENDED_ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(MOST_RECOMMENDED_ITEM_COUNT);
            response.Limit.Should().Be(LIMIT);
            response.Page.Should().Be(PAGE);
            response.PageCount.Should().HaveValue().And.Be(1);
        }

        [Theory]
        [InlineData(HttpStatusCode.NotFound, typeof(TraktNotFoundException))]
        [InlineData(HttpStatusCode.Unauthorized, typeof(TraktAuthorizationException))]
        [InlineData(HttpStatusCode.BadRequest, typeof(TraktBadRequestException))]
        [InlineData(HttpStatusCode.Forbidden, typeof(TraktForbiddenException))]
        [InlineData(HttpStatusCode.MethodNotAllowed, typeof(TraktMethodNotFoundException))]
        [InlineData(HttpStatusCode.Conflict, typeof(TraktConflictException))]
        [InlineData(HttpStatusCode.InternalServerError, typeof(TraktServerException))]
        [InlineData(HttpStatusCode.BadGateway, typeof(TraktBadGatewayException))]
        [InlineData(HttpStatusCode.PreconditionFailed, typeof(TraktPreconditionFailedException))]
        [InlineData(HttpStatusCode.UnprocessableEntity, typeof(TraktValidationException))]
        [InlineData(HttpStatusCode.TooManyRequests, typeof(TraktRateLimitException))]
        [InlineData(HttpStatusCode.ServiceUnavailable, typeof(TraktServerUnavailableException))]
        [InlineData(HttpStatusCode.GatewayTimeout, typeof(TraktServerUnavailableException))]
        [InlineData((HttpStatusCode)520, typeof(TraktServerUnavailableException))]
        [InlineData((HttpStatusCode)521, typeof(TraktServerUnavailableException))]
        [InlineData((HttpStatusCode)522, typeof(TraktServerUnavailableException))]
        public async Task Test_TraktMoviesModule_GetMostRecommendedMovies_Throws_API_Exception(HttpStatusCode statusCode, Type exceptionType)
        {
            TraktClient client = TestUtility.GetMockClient(GET_MOST_RECOMMENDED_MOVIES_URI, statusCode);

            try
            {
                await client.Movies.GetMostRecommendedMoviesAsync();
                Assert.False(true);
            }
            catch (Exception exception)
            {
                (exception.GetType() == exceptionType).Should().BeTrue();
            }
        }
    }
}