﻿namespace TraktApiSharp.Tests.Objects.Get.Episodes.JsonReader
{
    using FluentAssertions;
    using Traits;
    using TraktApiSharp.Objects.Get.Episodes;
    using TraktApiSharp.Objects.Get.Episodes.JsonReader;
    using TraktApiSharp.Objects.JsonReader;
    using Xunit;

    [Category("Objects.Get.Episodes.JsonReader")]
    public partial class ITraktEpisodeWatchedProgressObjectJsonReader_Tests
    {
        [Fact]
        public void Test_ITraktEpisodeWatchedProgressObjectJsonReader_Implements_ITraktObjectJsonReader_Interface()
        {
            typeof(ITraktEpisodeWatchedProgressObjectJsonReader).GetInterfaces().Should().Contain(typeof(ITraktObjectJsonReader<ITraktEpisodeWatchedProgress>));
        }
    }
}