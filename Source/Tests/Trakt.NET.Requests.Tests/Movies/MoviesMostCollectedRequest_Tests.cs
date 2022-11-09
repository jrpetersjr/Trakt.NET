﻿namespace TraktNet.Requests.Tests.Movies
{
    using FluentAssertions;
    using System.Collections;
    using System.Collections.Generic;
    using Trakt.NET.Tests.Utility.Traits;
    using TraktNet.Enums;
    using TraktNet.Parameters;
    using TraktNet.Requests.Movies;
    using Xunit;

    [TestCategory("Requests.Movies.Lists")]
    public class MoviesMostCollectedRequest_Tests
    {
        [Fact]
        public void Test_MoviesMostCollectedRequest_Has_Valid_UriTemplate()
        {
            var request = new MoviesMostCollectedRequest();
            request.UriTemplate.Should().Be("movies/collected{/period}{?extended,page,limit,query,years,genres,languages,countries,runtimes,ratings,certifications}");
        }

        [Theory, ClassData(typeof(MoviesMostCollectedRequest_TestData))]
        public void Test_MoviesMostCollectedRequest_Returns_Valid_UriPathParameters(IDictionary<string, object> values,
                                                                                    IDictionary<string, object> expected)
        {
            values.Should().NotBeNull().And.HaveCount(expected.Count);

            if (expected.Count > 0)
                values.Should().Contain(expected);
        }

        public class MoviesMostCollectedRequest_TestData : IEnumerable<object[]>
        {
            private static readonly TraktExtendedInfo _extendedInfo = new TraktExtendedInfo { Full = true };
            private static readonly ITraktMovieFilter _filter = TraktFilter.NewMovieFilter().WithYears(2005, 2016).Build();
            private static readonly TraktTimePeriod _timePeriod = TraktTimePeriod.Monthly;
            private const int _page = 5;
            private const int _limit = 20;

            private static readonly MoviesMostCollectedRequest _request1 = new MoviesMostCollectedRequest();

            private static readonly MoviesMostCollectedRequest _request2 = new MoviesMostCollectedRequest
            {
                ExtendedInfo = _extendedInfo
            };

            private static readonly MoviesMostCollectedRequest _request3 = new MoviesMostCollectedRequest
            {
                Filter = _filter
            };

            private static readonly MoviesMostCollectedRequest _request4 = new MoviesMostCollectedRequest
            {
                Period = _timePeriod
            };

            private static readonly MoviesMostCollectedRequest _request5 = new MoviesMostCollectedRequest
            {
                Page = _page
            };

            private static readonly MoviesMostCollectedRequest _request6 = new MoviesMostCollectedRequest
            {
                Limit = _limit
            };

            private static readonly MoviesMostCollectedRequest _request7 = new MoviesMostCollectedRequest
            {
                ExtendedInfo = _extendedInfo,
                Filter = _filter
            };

            private static readonly MoviesMostCollectedRequest _request8 = new MoviesMostCollectedRequest
            {
                ExtendedInfo = _extendedInfo,
                Period = _timePeriod
            };

            private static readonly MoviesMostCollectedRequest _request9 = new MoviesMostCollectedRequest
            {
                ExtendedInfo = _extendedInfo,
                Page = _page
            };

            private static readonly MoviesMostCollectedRequest _request10 = new MoviesMostCollectedRequest
            {
                ExtendedInfo = _extendedInfo,
                Limit = _limit
            };

            private static readonly MoviesMostCollectedRequest _request11 = new MoviesMostCollectedRequest
            {
                ExtendedInfo = _extendedInfo,
                Page = _page,
                Limit = _limit
            };

            private static readonly MoviesMostCollectedRequest _request12 = new MoviesMostCollectedRequest
            {
                Filter = _filter,
                Period = _timePeriod
            };

            private static readonly MoviesMostCollectedRequest _request13 = new MoviesMostCollectedRequest
            {
                Filter = _filter,
                Page = _page
            };

            private static readonly MoviesMostCollectedRequest _request14 = new MoviesMostCollectedRequest
            {
                Filter = _filter,
                Limit = _limit
            };

            private static readonly MoviesMostCollectedRequest _request15 = new MoviesMostCollectedRequest
            {
                Filter = _filter,
                Page = _page,
                Limit = _limit
            };

            private static readonly MoviesMostCollectedRequest _request16 = new MoviesMostCollectedRequest
            {
                Period = _timePeriod,
                Page = _page
            };

            private static readonly MoviesMostCollectedRequest _request17 = new MoviesMostCollectedRequest
            {
                Period = _timePeriod,
                Limit = _limit
            };

            private static readonly MoviesMostCollectedRequest _request18 = new MoviesMostCollectedRequest
            {
                Period = _timePeriod,
                Page = _page,
                Limit = _limit
            };

            private static readonly MoviesMostCollectedRequest _request19 = new MoviesMostCollectedRequest
            {
                Page = _page,
                Limit = _limit
            };

            private static readonly MoviesMostCollectedRequest _request20 = new MoviesMostCollectedRequest
            {
                ExtendedInfo = _extendedInfo,
                Filter = _filter,
                Period = _timePeriod,
                Page = _page,
                Limit = _limit
            };

            private static readonly List<object[]> _data = new List<object[]>();

            public MoviesMostCollectedRequest_TestData()
            {
                SetupPathParamters();
            }

            private void SetupPathParamters()
            {
                var strExtendedInfo = _extendedInfo.ToString();
                var filterParameters = _filter.GetParameters();
                var strTimePeriod = _timePeriod.UriName;
                var strPage = _page.ToString();
                var strLimit = _limit.ToString();

                _data.Add(new object[] { _request1.GetUriPathParameters(), new Dictionary<string, object>() });

                _data.Add(new object[] { _request2.GetUriPathParameters(), new Dictionary<string, object>
                    {
                        ["extended"] = strExtendedInfo
                    }});

                _data.Add(new object[] { _request3.GetUriPathParameters(), new Dictionary<string, object>(filterParameters) });

                _data.Add(new object[] { _request4.GetUriPathParameters(), new Dictionary<string, object>
                    {
                        ["period"] = strTimePeriod
                    }});

                _data.Add(new object[] { _request5.GetUriPathParameters(), new Dictionary<string, object>
                    {
                        ["page"] = strPage
                    }});

                _data.Add(new object[] { _request6.GetUriPathParameters(), new Dictionary<string, object>
                    {
                        ["limit"] = strLimit
                    }});

                _data.Add(new object[] { _request7.GetUriPathParameters(), new Dictionary<string, object>(filterParameters)
                    {
                        ["extended"] = strExtendedInfo
                    }});

                _data.Add(new object[] { _request8.GetUriPathParameters(), new Dictionary<string, object>
                    {
                        ["extended"] = strExtendedInfo,
                        ["period"] = strTimePeriod
                    }});

                _data.Add(new object[] { _request9.GetUriPathParameters(), new Dictionary<string, object>
                    {
                        ["extended"] = strExtendedInfo,
                        ["page"] = strPage
                    }});

                _data.Add(new object[] { _request10.GetUriPathParameters(), new Dictionary<string, object>
                    {
                        ["extended"] = strExtendedInfo,
                        ["limit"] = strLimit
                    }});

                _data.Add(new object[] { _request11.GetUriPathParameters(), new Dictionary<string, object>
                    {
                        ["extended"] = strExtendedInfo,
                        ["page"] = strPage,
                        ["limit"] = strLimit
                    }});

                _data.Add(new object[] { _request12.GetUriPathParameters(), new Dictionary<string, object>(filterParameters)
                    {
                        ["period"] = strTimePeriod
                    }});

                _data.Add(new object[] { _request13.GetUriPathParameters(), new Dictionary<string, object>(filterParameters)
                    {
                        ["page"] = strPage
                    }});

                _data.Add(new object[] { _request14.GetUriPathParameters(), new Dictionary<string, object>(filterParameters)
                    {
                        ["limit"] = strLimit
                    }});

                _data.Add(new object[] { _request15.GetUriPathParameters(), new Dictionary<string, object>(filterParameters)
                    {
                        ["page"] = strPage,
                        ["limit"] = strLimit
                    }});

                _data.Add(new object[] { _request16.GetUriPathParameters(), new Dictionary<string, object>
                    {
                        ["period"] = strTimePeriod,
                        ["page"] = strPage
                    }});

                _data.Add(new object[] { _request17.GetUriPathParameters(), new Dictionary<string, object>
                    {
                        ["period"] = strTimePeriod,
                        ["limit"] = strLimit
                    }});

                _data.Add(new object[] { _request18.GetUriPathParameters(), new Dictionary<string, object>
                    {
                        ["period"] = strTimePeriod,
                        ["page"] = strPage,
                        ["limit"] = strLimit
                    }});

                _data.Add(new object[] { _request19.GetUriPathParameters(), new Dictionary<string, object>
                    {
                        ["page"] = strPage,
                        ["limit"] = strLimit
                    }});

                _data.Add(new object[] { _request20.GetUriPathParameters(), new Dictionary<string, object>(filterParameters)
                    {
                        ["extended"] = strExtendedInfo,
                        ["period"] = strTimePeriod,
                        ["page"] = strPage,
                        ["limit"] = strLimit
                    }});
            }

            public IEnumerator<object[]> GetEnumerator() => _data.GetEnumerator();

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}
