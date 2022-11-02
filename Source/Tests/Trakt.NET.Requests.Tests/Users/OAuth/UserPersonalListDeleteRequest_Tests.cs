﻿namespace TraktNet.Requests.Tests.Users.OAuth
{
    using FluentAssertions;
    using System;
    using System.Collections.Generic;
    using Trakt.NET.Tests.Utility.Traits;
    using TraktNet.Exceptions;
    using TraktNet.Requests.Base;
    using TraktNet.Requests.Users.OAuth;
    using Xunit;

    [TestCategory("Requests.Users.OAuth")]
    public class UserPersonalListDeleteRequest_Tests
    {
        [Fact]
        public void Test_UserPersonalListDeleteRequest_Has_AuthorizationRequirement_Required()
        {
            var request = new UserPersonalListDeleteRequest();
            request.AuthorizationRequirement.Should().Be(AuthorizationRequirement.Required);
        }

        [Fact]
        public void Test_UserPersonalListDeleteRequest_Returns_Valid_RequestObjectType()
        {
            var requestMock = new UserPersonalListDeleteRequest();
            requestMock.RequestObjectType.Should().Be(RequestObjectType.Lists);
        }

        [Fact]
        public void Test_UserPersonalListDeleteRequest_Has_Valid_UriTemplate()
        {
            var request = new UserPersonalListDeleteRequest();
            request.UriTemplate.Should().Be("users/{username}/lists/{id}");
        }

        [Fact]
        public void Test_UserPersonalListDeleteRequest_Returns_Valid_UriPathParameters()
        {
            var request = new UserPersonalListDeleteRequest { Username = "username", Id = "123" };

            request.GetUriPathParameters().Should().NotBeNull()
                                                   .And.HaveCount(2)
                                                   .And.Contain(new Dictionary<string, object>
                                                   {
                                                       ["username"] = "username",
                                                       ["id"] = "123"
                                                   });
        }

        [Fact]
        public void Test_UserPersonalListDeleteRequest_Validate_Throws_Exceptions()
        {
            // username is null
            var request = new UserPersonalListDeleteRequest { Id = "123" };

            Action act = () => request.Validate();
            act.Should().Throw<TraktRequestValidationException>();

            // empty username
            request = new UserPersonalListDeleteRequest { Username = string.Empty, Id = "123" };

            act = () => request.Validate();
            act.Should().Throw<TraktRequestValidationException>();

            // username with spaces
            request = new UserPersonalListDeleteRequest { Username = "invalid username", Id = "123" };

            act = () => request.Validate();
            act.Should().Throw<TraktRequestValidationException>();

            // id is null
            request = new UserPersonalListDeleteRequest { Username = "username" };

            act = () => request.Validate();
            act.Should().Throw<TraktRequestValidationException>();

            // empty id
            request = new UserPersonalListDeleteRequest { Username = "username", Id = string.Empty };

            act = () => request.Validate();
            act.Should().Throw<TraktRequestValidationException>();

            // id with spaces
            request = new UserPersonalListDeleteRequest { Username = "username", Id = "invalid id" };

            act = () => request.Validate();
            act.Should().Throw<TraktRequestValidationException>();
        }
    }
}
