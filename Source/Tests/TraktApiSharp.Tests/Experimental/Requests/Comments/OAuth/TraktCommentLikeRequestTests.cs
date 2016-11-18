﻿namespace TraktApiSharp.Tests.Experimental.Requests.Comments.OAuth
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TraktApiSharp.Experimental.Requests.Base.Post.Bodyless;
    using TraktApiSharp.Experimental.Requests.Comments.OAuth;
    using TraktApiSharp.Experimental.Requests.Interfaces;

    [TestClass]
    public class TraktCommentLikeRequestTests
    {
        [TestMethod, TestCategory("Requests"), TestCategory("Comments"), TestCategory("With OAuth")]
        public void TestTraktCommentLikeRequestIsNotAbstract()
        {
            typeof(TraktCommentLikeRequest).IsAbstract.Should().BeFalse();
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Comments"), TestCategory("With OAuth")]
        public void TestTraktCommentLikeRequestIsSealed()
        {
            typeof(TraktCommentLikeRequest).IsSealed.Should().BeTrue();
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Comments"), TestCategory("With OAuth")]
        public void TestTraktCommentLikeRequestIsSubclassOfATraktNoContentBodylessPostByIdRequest()
        {
            typeof(TraktCommentLikeRequest).IsSubclassOf(typeof(ATraktNoContentBodylessPostByIdRequest)).Should().BeTrue();
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Comments"), TestCategory("With OAuth")]
        public void TestTraktCommentLikeRequestHasValidUriTemplate()
        {
            var request = new TraktCommentLikeRequest(null);
            request.UriTemplate.Should().Be("comments/{id}/like");
        }

        [TestMethod, TestCategory("Requests"), TestCategory("Comments"), TestCategory("With OAuth")]
        public void TestTraktCommentLikeRequestImplementsITraktObjectRequestInterface()
        {
            typeof(TraktCommentLikeRequest).GetInterfaces().Should().Contain(typeof(ITraktObjectRequest));
        }
    }
}