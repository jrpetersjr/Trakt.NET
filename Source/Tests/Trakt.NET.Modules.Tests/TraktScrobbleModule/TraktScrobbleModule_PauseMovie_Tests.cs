﻿namespace TraktNet.Modules.Tests.TraktScrobbleModule
{
    using FluentAssertions;
    using System;
    using System.Net;
    using System.Threading.Tasks;
    using Trakt.NET.Tests.Utility;
    using Trakt.NET.Tests.Utility.Traits;
    using TraktNet.Enums;
    using TraktNet.Exceptions;
    using TraktNet.Extensions;
    using TraktNet.Objects.Post.Scrobbles;
    using TraktNet.Objects.Post.Scrobbles.Responses;
    using TraktNet.Responses;
    using Xunit;

    [TestCategory("Modules.Scrobble")]
    public partial class TraktScrobbleModule_Tests
    {
        [Fact]
        public async Task Test_TraktScrobbleModule_PauseMovie()
        {
            ITraktMovieScrobblePost moviePauseScrobblePost = new TraktMovieScrobblePost
            {
                Movie = Movie,
                Progress = PAUSE_PROGRESS
            };

            string postJson = await TestUtility.SerializeObject(moviePauseScrobblePost);
            postJson.Should().NotBeNullOrEmpty();

            TraktClient client = TestUtility.GetOAuthMockClient(SCROBBLE_PAUSE_URI, postJson, MOVIE_PAUSE_SCROBBLE_POST_RESPONSE_JSON);
            TraktResponse<ITraktMovieScrobblePostResponse> response = await client.Scrobble.PauseMovieAsync(moviePauseScrobblePost);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull();

            ITraktMovieScrobblePostResponse responseValue = response.Value;

            responseValue.Id.Should().Be(0);
            responseValue.Action.Should().Be(TraktScrobbleActionType.Pause);
            responseValue.Progress.Should().Be(PAUSE_PROGRESS);
            responseValue.Sharing.Should().NotBeNull();
            responseValue.Sharing.Twitter.Should().BeFalse();
            responseValue.Sharing.Tumblr.Should().BeFalse();
            responseValue.Movie.Should().NotBeNull();
            responseValue.Movie.Title.Should().Be("Guardians of the Galaxy");
            responseValue.Movie.Year.Should().Be(2014);
            responseValue.Movie.Ids.Should().NotBeNull();
            responseValue.Movie.Ids.Trakt.Should().Be(28U);
            responseValue.Movie.Ids.Slug.Should().Be("guardians-of-the-galaxy-2014");
            responseValue.Movie.Ids.Imdb.Should().Be("tt2015381");
            responseValue.Movie.Ids.Tmdb.Should().Be(118340U);
        }

        [Fact]
        public async Task Test_TraktScrobbleModule_PauseMovie_With_AppVersion()
        {
            ITraktMovieScrobblePost moviePauseScrobblePost = new TraktMovieScrobblePost
            {
                Movie = Movie,
                Progress = PAUSE_PROGRESS,
                AppVersion = APP_VERSION
            };

            string postJson = await TestUtility.SerializeObject(moviePauseScrobblePost);
            postJson.Should().NotBeNullOrEmpty();

            TraktClient client = TestUtility.GetOAuthMockClient(SCROBBLE_PAUSE_URI, postJson, MOVIE_PAUSE_SCROBBLE_POST_RESPONSE_JSON);
            TraktResponse<ITraktMovieScrobblePostResponse> response = await client.Scrobble.PauseMovieAsync(moviePauseScrobblePost);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull();

            ITraktMovieScrobblePostResponse responseValue = response.Value;

            responseValue.Id.Should().Be(0);
            responseValue.Action.Should().Be(TraktScrobbleActionType.Pause);
            responseValue.Progress.Should().Be(PAUSE_PROGRESS);
            responseValue.Sharing.Should().NotBeNull();
            responseValue.Sharing.Twitter.Should().BeFalse();
            responseValue.Sharing.Tumblr.Should().BeFalse();
            responseValue.Movie.Should().NotBeNull();
            responseValue.Movie.Title.Should().Be("Guardians of the Galaxy");
            responseValue.Movie.Year.Should().Be(2014);
            responseValue.Movie.Ids.Should().NotBeNull();
            responseValue.Movie.Ids.Trakt.Should().Be(28U);
            responseValue.Movie.Ids.Slug.Should().Be("guardians-of-the-galaxy-2014");
            responseValue.Movie.Ids.Imdb.Should().Be("tt2015381");
            responseValue.Movie.Ids.Tmdb.Should().Be(118340U);
        }

        [Fact]
        public async Task Test_TraktScrobbleModule_PauseMovie_With_AppDate()
        {
            ITraktMovieScrobblePost moviePauseScrobblePost = new TraktMovieScrobblePost
            {
                Movie = Movie,
                Progress = PAUSE_PROGRESS,
                AppDate = APP_BUILD_DATE.ToTraktDateString()
            };

            string postJson = await TestUtility.SerializeObject(moviePauseScrobblePost);
            postJson.Should().NotBeNullOrEmpty();

            TraktClient client = TestUtility.GetOAuthMockClient(SCROBBLE_PAUSE_URI, postJson, MOVIE_PAUSE_SCROBBLE_POST_RESPONSE_JSON);
            TraktResponse<ITraktMovieScrobblePostResponse> response = await client.Scrobble.PauseMovieAsync(moviePauseScrobblePost);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull();

            ITraktMovieScrobblePostResponse responseValue = response.Value;

            responseValue.Id.Should().Be(0);
            responseValue.Action.Should().Be(TraktScrobbleActionType.Pause);
            responseValue.Progress.Should().Be(PAUSE_PROGRESS);
            responseValue.Sharing.Should().NotBeNull();
            responseValue.Sharing.Twitter.Should().BeFalse();
            responseValue.Sharing.Tumblr.Should().BeFalse();
            responseValue.Movie.Should().NotBeNull();
            responseValue.Movie.Title.Should().Be("Guardians of the Galaxy");
            responseValue.Movie.Year.Should().Be(2014);
            responseValue.Movie.Ids.Should().NotBeNull();
            responseValue.Movie.Ids.Trakt.Should().Be(28U);
            responseValue.Movie.Ids.Slug.Should().Be("guardians-of-the-galaxy-2014");
            responseValue.Movie.Ids.Imdb.Should().Be("tt2015381");
            responseValue.Movie.Ids.Tmdb.Should().Be(118340U);
        }

        [Fact]
        public async Task Test_TraktScrobbleModule_PauseMovie_With_AppVersion_And_AppDate()
        {
            ITraktMovieScrobblePost moviePauseScrobblePost = new TraktMovieScrobblePost
            {
                Movie = Movie,
                Progress = PAUSE_PROGRESS,
                AppVersion = APP_VERSION,
                AppDate = APP_BUILD_DATE.ToTraktDateString()
            };

            string postJson = await TestUtility.SerializeObject(moviePauseScrobblePost);
            postJson.Should().NotBeNullOrEmpty();

            TraktClient client = TestUtility.GetOAuthMockClient(SCROBBLE_PAUSE_URI, postJson, MOVIE_PAUSE_SCROBBLE_POST_RESPONSE_JSON);
            TraktResponse<ITraktMovieScrobblePostResponse> response = await client.Scrobble.PauseMovieAsync(moviePauseScrobblePost);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull();

            ITraktMovieScrobblePostResponse responseValue = response.Value;

            responseValue.Id.Should().Be(0);
            responseValue.Action.Should().Be(TraktScrobbleActionType.Pause);
            responseValue.Progress.Should().Be(PAUSE_PROGRESS);
            responseValue.Sharing.Should().NotBeNull();
            responseValue.Sharing.Twitter.Should().BeFalse();
            responseValue.Sharing.Tumblr.Should().BeFalse();
            responseValue.Movie.Should().NotBeNull();
            responseValue.Movie.Title.Should().Be("Guardians of the Galaxy");
            responseValue.Movie.Year.Should().Be(2014);
            responseValue.Movie.Ids.Should().NotBeNull();
            responseValue.Movie.Ids.Trakt.Should().Be(28U);
            responseValue.Movie.Ids.Slug.Should().Be("guardians-of-the-galaxy-2014");
            responseValue.Movie.Ids.Imdb.Should().Be("tt2015381");
            responseValue.Movie.Ids.Tmdb.Should().Be(118340U);
        }

        [Fact]
        public async Task Test_TraktScrobbleModule_PauseMovie_Complete()
        {
            ITraktMovieScrobblePost moviePauseScrobblePost = new TraktMovieScrobblePost
            {
                Movie = Movie,
                Progress = PAUSE_PROGRESS,
                AppVersion = APP_VERSION,
                AppDate = APP_BUILD_DATE.ToTraktDateString()
            };

            string postJson = await TestUtility.SerializeObject(moviePauseScrobblePost);
            postJson.Should().NotBeNullOrEmpty();

            TraktClient client = TestUtility.GetOAuthMockClient(SCROBBLE_PAUSE_URI, postJson, MOVIE_PAUSE_SCROBBLE_POST_RESPONSE_JSON);
            TraktResponse<ITraktMovieScrobblePostResponse> response = await client.Scrobble.PauseMovieAsync(moviePauseScrobblePost);

            response.Should().NotBeNull();
            response.IsSuccess.Should().BeTrue();
            response.HasValue.Should().BeTrue();
            response.Value.Should().NotBeNull();

            ITraktMovieScrobblePostResponse responseValue = response.Value;

            responseValue.Id.Should().Be(0);
            responseValue.Action.Should().Be(TraktScrobbleActionType.Pause);
            responseValue.Progress.Should().Be(PAUSE_PROGRESS);
            responseValue.Sharing.Should().NotBeNull();
            responseValue.Sharing.Twitter.Should().BeFalse();
            responseValue.Sharing.Tumblr.Should().BeFalse();
            responseValue.Movie.Should().NotBeNull();
            responseValue.Movie.Title.Should().Be("Guardians of the Galaxy");
            responseValue.Movie.Year.Should().Be(2014);
            responseValue.Movie.Ids.Should().NotBeNull();
            responseValue.Movie.Ids.Trakt.Should().Be(28U);
            responseValue.Movie.Ids.Slug.Should().Be("guardians-of-the-galaxy-2014");
            responseValue.Movie.Ids.Imdb.Should().Be("tt2015381");
            responseValue.Movie.Ids.Tmdb.Should().Be(118340U);
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
        public async Task Test_TraktScrobbleModule_PauseMovie_Throws_API_Exception(HttpStatusCode statusCode, Type exceptionType)
        {
            ITraktMovieScrobblePost moviePauseScrobblePost = new TraktMovieScrobblePost
            {
                Movie = Movie,
                Progress = PAUSE_PROGRESS
            };

            TraktClient client = TestUtility.GetOAuthMockClient(SCROBBLE_PAUSE_URI, statusCode);

            try
            {
                await client.Scrobble.PauseMovieAsync(moviePauseScrobblePost);
                Assert.False(true);
            }
            catch (Exception exception)
            {
                (exception.GetType() == exceptionType).Should().BeTrue();
            }
        }
    }
}
