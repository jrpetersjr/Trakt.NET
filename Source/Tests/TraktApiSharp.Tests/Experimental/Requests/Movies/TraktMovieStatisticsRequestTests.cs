﻿namespace TraktApiSharp.Tests.Experimental.Requests.Movies
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TraktApiSharp.Experimental.Requests.Base.Get;
    using TraktApiSharp.Experimental.Requests.Movies;
    using TraktApiSharp.Objects.Basic;

    [TestClass]
    public class TraktMovieStatisticsRequestTests
    {
        [TestMethod, TestCategory("Requests"), TestCategory("Movies")]
        public void TestTraktMovieStatisticsRequestIsNotAbstract()
        {
            typeof(TraktMovieStatisticsRequest).IsAbstract.Should().BeFalse();
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Movies")]
        public void TestTraktMovieStatisticsRequestIsSealed()
        {
            typeof(TraktMovieStatisticsRequest).IsSealed.Should().BeTrue();
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Movies")]
        public void TestTraktMovieStatisticsRequestIsSubclassOfATraktSingleItemGetByIdRequest()
        {
            typeof(TraktMovieStatisticsRequest).IsSubclassOf(typeof(ATraktSingleItemGetByIdRequest<TraktStatistics>)).Should().BeTrue();
        }
    }
}
