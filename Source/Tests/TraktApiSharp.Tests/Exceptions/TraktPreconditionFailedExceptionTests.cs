﻿namespace TraktApiSharp.Tests.Exceptions
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TraktApiSharp.Exceptions;

    [TestClass]
    public class TraktPreconditionFailedExceptionTests
    {
        [TestMethod]
        public void TestTraktPreconditionFailedExceptionBaseClass()
        {
            var exception = new TraktPreconditionFailedException("");

            exception.Should().BeAssignableTo<TraktException>();
        }

        [TestMethod]
        public void TestTraktPreconditionFailedExceptionConstructor()
        {
            var message = "exception message";

            var exception = new TraktPreconditionFailedException(message);

            exception.Message.Should().Be(message);
            exception.StatusCode.Should().Be(System.Net.HttpStatusCode.PreconditionFailed);
            exception.RequestUrl.Should().BeNullOrEmpty();
            exception.RequestBody.Should().BeNullOrEmpty();
        }
    }
}
