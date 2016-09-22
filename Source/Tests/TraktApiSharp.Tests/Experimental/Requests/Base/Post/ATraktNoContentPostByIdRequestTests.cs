﻿namespace TraktApiSharp.Tests.Experimental.Requests.Base.Post
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TraktApiSharp.Experimental.Requests.Base;
    using TraktApiSharp.Experimental.Requests.Base.Post;
    using TraktApiSharp.Experimental.Requests.Interfaces;

    [TestClass]
    public class ATraktNoContentPostByIdRequestTests
    {
        [TestMethod]
        public void TestATraktNoContentPostByIdRequestIsAbstract()
        {
            typeof(ATraktNoContentPostByIdRequest<>).IsAbstract.Should().BeTrue();
        }

        [TestMethod]
        public void TestATraktNoContentPostByIdRequestIsSubclassOfATraktNoContentRequest()
        {
            typeof(ATraktNoContentPostByIdRequest<float>).IsSubclassOf(typeof(ATraktNoContentRequest)).Should().BeTrue();
        }

        [TestMethod]
        public void TestATraktNoContentPostByIdRequestHasGenericTypeParameter()
        {
            typeof(ATraktNoContentPostByIdRequest<>).ContainsGenericParameters.Should().BeTrue();
            typeof(ATraktNoContentPostByIdRequest<float>).GenericTypeArguments.Should().NotBeEmpty().And.HaveCount(1);
        }

        [TestMethod]
        public void TestATraktNoContentPostByIdRequestImplementsITraktRequestInterface()
        {
            typeof(ATraktNoContentPostByIdRequest<>).GetInterfaces().Should().Contain(typeof(ITraktRequest));
        }

        [TestMethod]
        public void TestATraktNoContentPostByIdRequestImplementsITraktHasRequestBodyInterface()
        {
            typeof(ATraktNoContentPostByIdRequest<float>).GetInterfaces().Should().Contain(typeof(ITraktHasRequestBody<float>));
        }

        [TestMethod]
        public void TestATraktNoContentPostByIdRequestImplementsITraktHasIdInterface()
        {
            typeof(ATraktNoContentPostByIdRequest<>).GetInterfaces().Should().Contain(typeof(ITraktHasId));
        }
    }
}
