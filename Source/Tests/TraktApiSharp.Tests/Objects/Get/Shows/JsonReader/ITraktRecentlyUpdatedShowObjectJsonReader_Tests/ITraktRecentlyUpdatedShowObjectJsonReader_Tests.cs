﻿namespace TraktApiSharp.Tests.Objects.Get.Shows.JsonReader
{
    using FluentAssertions;
    using Traits;
    using TraktApiSharp.Objects.Get.Shows;
    using TraktApiSharp.Objects.Get.Shows.JsonReader;
    using TraktApiSharp.Objects.JsonReader;
    using Xunit;

    [Category("Objects.Get.Shows.JsonReader")]
    public partial class ITraktRecentlyUpdatedShowObjectJsonReader_Tests
    {
        [Fact]
        public void Test_ITraktRecentlyUpdatedShowObjectJsonReader_Implements_ITraktObjectJsonReader_Interface()
        {
            typeof(ITraktRecentlyUpdatedShowObjectJsonReader).GetInterfaces().Should().Contain(typeof(ITraktObjectJsonReader<ITraktRecentlyUpdatedShow>));
        }
    }
}