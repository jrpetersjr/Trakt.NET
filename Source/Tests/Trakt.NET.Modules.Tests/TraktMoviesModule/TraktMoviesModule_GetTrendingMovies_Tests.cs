﻿namespace TraktNet.Modules.Tests.TraktMoviesModule
{
    using FluentAssertions;
    using System;
    using System.Net;
    using System.Threading.Tasks;
    using Trakt.NET.Tests.Utility;
    using Trakt.NET.Tests.Utility.Traits;
    using TraktNet.Exceptions;
    using TraktNet.Objects.Get.Movies;
    using TraktNet.Requests.Parameters;
    using TraktNet.Responses;
    using Xunit;

    [Category("Modules.Movies")]
    public partial class TraktMoviesModule_Tests
    {
        private const string GET_TRENDING_MOVIES_URI = "movies/trending";

        [Fact]
        public async Task Test_TraktMoviesModule_GetTrendingMovies()
        {
            TraktClient client = TestUtility.GetMockClient(GET_TRENDING_MOVIES_URI,
                                                           TRENDING_MOVIES_JSON, 1, 10, 1, ITEM_COUNT, USER_COUNT);

            TraktPagedResponse<ITraktTrendingMovie> response = await client.Movies.GetTrendingMoviesAsync();

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(ITEM_COUNT);
            response.Limit.Should().Be(10u);
            response.Page.Should().Be(1u);
            response.PageCount.Should().HaveValue().And.Be(1);
            response.TrendingUserCount.Should().HaveValue().And.Be(USER_COUNT);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetTrendingMovies_Filtered()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_TRENDING_MOVIES_URI}?{FILTER}",
                                                           TRENDING_MOVIES_JSON, 1, 10, 1, ITEM_COUNT, USER_COUNT);

            var response = await client.Movies.GetTrendingMoviesAsync(null, FILTER);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(ITEM_COUNT);
            response.Limit.Should().Be(10u);
            response.Page.Should().Be(1u);
            response.PageCount.Should().HaveValue().And.Be(1);
            response.TrendingUserCount.Should().HaveValue().And.Be(USER_COUNT);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetTrendingMovies_With_ExtendedInfo()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_TRENDING_MOVIES_URI}?extended={EXTENDED_INFO}",
                                                           TRENDING_MOVIES_JSON, 1, 10, 1, ITEM_COUNT, USER_COUNT);

            var response = await client.Movies.GetTrendingMoviesAsync(EXTENDED_INFO);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(ITEM_COUNT);
            response.Limit.Should().Be(10u);
            response.Page.Should().Be(1u);
            response.PageCount.Should().HaveValue().And.Be(1);
            response.TrendingUserCount.Should().HaveValue().And.Be(USER_COUNT);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetTrendingMovies_With_ExtendedInfo_Filtered()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_TRENDING_MOVIES_URI}?extended={EXTENDED_INFO}&{FILTER}",
                                                           TRENDING_MOVIES_JSON, 1, 10, 1, ITEM_COUNT, USER_COUNT);

            var response = await client.Movies.GetTrendingMoviesAsync(EXTENDED_INFO, FILTER);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(ITEM_COUNT);
            response.Limit.Should().Be(10u);
            response.Page.Should().Be(1u);
            response.PageCount.Should().HaveValue().And.Be(1);
            response.TrendingUserCount.Should().HaveValue().And.Be(USER_COUNT);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetTrendingMovies_With_Page()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_TRENDING_MOVIES_URI}?page={PAGE}",
                                                           TRENDING_MOVIES_JSON, PAGE, 10, 1, ITEM_COUNT, USER_COUNT);

            var pagedParameters = new TraktPagedParameters(PAGE);
            var response = await client.Movies.GetTrendingMoviesAsync(null, null, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(ITEM_COUNT);
            response.Limit.Should().Be(10u);
            response.Page.Should().Be(PAGE);
            response.PageCount.Should().HaveValue().And.Be(1);
            response.TrendingUserCount.Should().HaveValue().And.Be(USER_COUNT);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetTrendingMovies_With_Page_Filtered()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_TRENDING_MOVIES_URI}?{FILTER}&page={PAGE}",
                                                           TRENDING_MOVIES_JSON, PAGE, 10, 1, ITEM_COUNT, USER_COUNT);

            var pagedParameters = new TraktPagedParameters(PAGE);
            var response = await client.Movies.GetTrendingMoviesAsync(null, FILTER, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(ITEM_COUNT);
            response.Limit.Should().Be(10u);
            response.Page.Should().Be(PAGE);
            response.PageCount.Should().HaveValue().And.Be(1);
            response.TrendingUserCount.Should().HaveValue().And.Be(USER_COUNT);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetTrendingMovies_With_ExtendedInfo_And_Page()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_TRENDING_MOVIES_URI}?extended={EXTENDED_INFO}&page={PAGE}",
                                                           TRENDING_MOVIES_JSON, PAGE, 10, 1, ITEM_COUNT, USER_COUNT);

            var pagedParameters = new TraktPagedParameters(PAGE);
            var response = await client.Movies.GetTrendingMoviesAsync(EXTENDED_INFO, null, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(ITEM_COUNT);
            response.Limit.Should().Be(10u);
            response.Page.Should().Be(PAGE);
            response.PageCount.Should().HaveValue().And.Be(1);
            response.TrendingUserCount.Should().HaveValue().And.Be(USER_COUNT);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetTrendingMovies_With_ExtendedInfo_And_Page_Filtered()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_TRENDING_MOVIES_URI}?extended={EXTENDED_INFO}&page={PAGE}&{FILTER}",
                                                           TRENDING_MOVIES_JSON, PAGE, 10, 1, ITEM_COUNT, USER_COUNT);

            var pagedParameters = new TraktPagedParameters(PAGE);
            var response = await client.Movies.GetTrendingMoviesAsync(EXTENDED_INFO, FILTER, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(ITEM_COUNT);
            response.Limit.Should().Be(10u);
            response.Page.Should().Be(PAGE);
            response.PageCount.Should().HaveValue().And.Be(1);
            response.TrendingUserCount.Should().HaveValue().And.Be(USER_COUNT);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetTrendingMovies_With_Limit()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_TRENDING_MOVIES_URI}?limit={LIMIT}",
                                                           TRENDING_MOVIES_JSON, 1, LIMIT, 1, ITEM_COUNT, USER_COUNT);

            var pagedParameters = new TraktPagedParameters(null, LIMIT);
            var response = await client.Movies.GetTrendingMoviesAsync(null, null, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(ITEM_COUNT);
            response.Limit.Should().Be(LIMIT);
            response.Page.Should().Be(1u);
            response.PageCount.Should().HaveValue().And.Be(1);
            response.TrendingUserCount.Should().HaveValue().And.Be(USER_COUNT);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetTrendingMovies_With_Limit_Filtered()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_TRENDING_MOVIES_URI}?{FILTER}&limit={LIMIT}",
                                                           TRENDING_MOVIES_JSON, 1, LIMIT, 1, ITEM_COUNT, USER_COUNT);

            var pagedParameters = new TraktPagedParameters(null, LIMIT);
            var response = await client.Movies.GetTrendingMoviesAsync(null, FILTER, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(ITEM_COUNT);
            response.Limit.Should().Be(LIMIT);
            response.Page.Should().Be(1u);
            response.PageCount.Should().HaveValue().And.Be(1);
            response.TrendingUserCount.Should().HaveValue().And.Be(USER_COUNT);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetTrendingMovies_With_ExtendedInfo_And_Limit()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_TRENDING_MOVIES_URI}?extended={EXTENDED_INFO}&limit={LIMIT}",
                                                           TRENDING_MOVIES_JSON, 1, LIMIT, 1, ITEM_COUNT, USER_COUNT);

            var pagedParameters = new TraktPagedParameters(null, LIMIT);
            var response = await client.Movies.GetTrendingMoviesAsync(EXTENDED_INFO, null, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(ITEM_COUNT);
            response.Limit.Should().Be(LIMIT);
            response.Page.Should().Be(1u);
            response.PageCount.Should().HaveValue().And.Be(1);
            response.TrendingUserCount.Should().HaveValue().And.Be(USER_COUNT);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetTrendingMovies_With_ExtendedInfo_And_Limit_Filtered()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_TRENDING_MOVIES_URI}?extended={EXTENDED_INFO}&limit={LIMIT}&{FILTER}",
                                                           TRENDING_MOVIES_JSON, 1, LIMIT, 1, ITEM_COUNT, USER_COUNT);

            var pagedParameters = new TraktPagedParameters(null, LIMIT);
            var response = await client.Movies.GetTrendingMoviesAsync(EXTENDED_INFO, FILTER, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(ITEM_COUNT);
            response.Limit.Should().Be(LIMIT);
            response.Page.Should().Be(1u);
            response.PageCount.Should().HaveValue().And.Be(1);
            response.TrendingUserCount.Should().HaveValue().And.Be(USER_COUNT);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetTrendingMovies_With_Page_And_Limit()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_TRENDING_MOVIES_URI}?page={PAGE}&limit={LIMIT}",
                                                           TRENDING_MOVIES_JSON, PAGE, LIMIT, 1, ITEM_COUNT, USER_COUNT);

            var pagedParameters = new TraktPagedParameters(PAGE, LIMIT);
            var response = await client.Movies.GetTrendingMoviesAsync(null, null, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(ITEM_COUNT);
            response.Limit.Should().Be(LIMIT);
            response.Page.Should().Be(PAGE);
            response.PageCount.Should().HaveValue().And.Be(1);
            response.TrendingUserCount.Should().HaveValue().And.Be(USER_COUNT);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetTrendingMovies_With_Page_And_Limit_Filtered()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_TRENDING_MOVIES_URI}?page={PAGE}&limit={LIMIT}&{FILTER}",
                                                           TRENDING_MOVIES_JSON, PAGE, LIMIT, 1, ITEM_COUNT, USER_COUNT);

            var pagedParameters = new TraktPagedParameters(PAGE, LIMIT);
            var response = await client.Movies.GetTrendingMoviesAsync(null, FILTER, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(ITEM_COUNT);
            response.Limit.Should().Be(LIMIT);
            response.Page.Should().Be(PAGE);
            response.PageCount.Should().HaveValue().And.Be(1);
            response.TrendingUserCount.Should().HaveValue().And.Be(USER_COUNT);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetTrendingMovies_Complete()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_TRENDING_MOVIES_URI}?extended={EXTENDED_INFO}&page={PAGE}&limit={LIMIT}",
                                                           TRENDING_MOVIES_JSON, PAGE, LIMIT, 1, ITEM_COUNT, USER_COUNT);

            var pagedParameters = new TraktPagedParameters(PAGE, LIMIT);
            var response = await client.Movies.GetTrendingMoviesAsync(EXTENDED_INFO, null, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(ITEM_COUNT);
            response.Limit.Should().Be(LIMIT);
            response.Page.Should().Be(PAGE);
            response.PageCount.Should().HaveValue().And.Be(1);
            response.TrendingUserCount.Should().HaveValue().And.Be(USER_COUNT);
        }

        [Fact]
        public async Task Test_TraktMoviesModule_GetTrendingMovies_Complete_Filtered()
        {
            TraktClient client = TestUtility.GetMockClient($"{GET_TRENDING_MOVIES_URI}?extended={EXTENDED_INFO}&page={PAGE}&limit={LIMIT}&{FILTER}",
                                                           TRENDING_MOVIES_JSON, PAGE, LIMIT, 1, ITEM_COUNT, USER_COUNT);

            var pagedParameters = new TraktPagedParameters(PAGE, LIMIT);
            var response = await client.Movies.GetTrendingMoviesAsync(EXTENDED_INFO, FILTER, pagedParameters);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull().And.HaveCount(ITEM_COUNT);
            response.ItemCount.Should().HaveValue().And.Be(ITEM_COUNT);
            response.Limit.Should().Be(LIMIT);
            response.Page.Should().Be(PAGE);
            response.PageCount.Should().HaveValue().And.Be(1);
            response.TrendingUserCount.Should().HaveValue().And.Be(USER_COUNT);
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
        public async Task Test_TraktMoviesModule_GetTrendingMovies_Throws_API_Exception(HttpStatusCode statusCode, Type exceptionType)
        {
            TraktClient client = TestUtility.GetMockClient(GET_TRENDING_MOVIES_URI, statusCode);

            try
            {
                await client.Movies.GetTrendingMoviesAsync();
                Assert.False(true);
            }
            catch (Exception exception)
            {
                (exception.GetType() == exceptionType).Should().BeTrue();
            }
        }
    }
}
