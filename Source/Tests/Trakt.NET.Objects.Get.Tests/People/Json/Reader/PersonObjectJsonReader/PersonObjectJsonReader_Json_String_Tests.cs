﻿namespace TraktNet.Objects.Get.Tests.People.Json.Reader
{
    using FluentAssertions;
    using System;
    using System.Threading.Tasks;
    using Trakt.NET.Tests.Utility.Traits;
    using TraktNet.Objects.Get.People;
    using TraktNet.Objects.Get.People.Json.Reader;
    using Xunit;

    [TestCategory("Objects.Get.People.JsonReader")]
    public partial class PersonObjectJsonReader_Tests
    {
        [Fact]
        public async Task Test_PersonObjectJsonReader_ReadObject_From_Json_String_Minimal_Complete()
        {
            var jsonReader = new PersonObjectJsonReader();

            var traktPerson = await jsonReader.ReadObjectAsync(MINIMAL_JSON_COMPLETE);

            traktPerson.Should().NotBeNull();
            traktPerson.Name.Should().Be("Bryan Cranston");
            traktPerson.Ids.Should().NotBeNull();
            traktPerson.Ids.Trakt.Should().Be(297737U);
            traktPerson.Ids.Slug.Should().Be("bryan-cranston");
            traktPerson.Ids.Imdb.Should().Be("nm0186505");
            traktPerson.Ids.Tmdb.Should().Be(17419U);
            traktPerson.Ids.TvRage.Should().Be(1797U);
            traktPerson.Biography.Should().BeNullOrEmpty();
            traktPerson.Birthday.Should().NotHaveValue();
            traktPerson.Death.Should().NotHaveValue();
            traktPerson.Age.Should().Be(0);
            traktPerson.Birthplace.Should().BeNullOrEmpty();
            traktPerson.Homepage.Should().BeNullOrEmpty();
            traktPerson.Gender.Should().BeNullOrEmpty();
            traktPerson.KnownForDepartment.Should().BeNullOrEmpty();
            traktPerson.SocialIds.Should().BeNull();
        }

        [Fact]
        public async Task Test_PersonObjectJsonReader_ReadObject_From_Json_String_Minimal_Not_Valid_1()
        {
            var jsonReader = new PersonObjectJsonReader();

            var traktPerson = await jsonReader.ReadObjectAsync(MINIMAL_JSON_NOT_VALID);

            traktPerson.Should().NotBeNull();
            traktPerson.Name.Should().BeNull();
            traktPerson.Ids.Should().BeNull();
            traktPerson.Biography.Should().BeNullOrEmpty();
            traktPerson.Birthday.Should().NotHaveValue();
            traktPerson.Death.Should().NotHaveValue();
            traktPerson.Age.Should().Be(0);
            traktPerson.Birthplace.Should().BeNullOrEmpty();
            traktPerson.Homepage.Should().BeNullOrEmpty();
            traktPerson.Gender.Should().BeNullOrEmpty();
            traktPerson.KnownForDepartment.Should().BeNullOrEmpty();
            traktPerson.SocialIds.Should().BeNull();
        }

        [Fact]
        public async Task Test_PersonObjectJsonReader_ReadObject_From_Json_String_Full_Complete()
        {
            var jsonReader = new PersonObjectJsonReader();

            var traktPerson = await jsonReader.ReadObjectAsync(FULL_JSON_COMPLETE);

            traktPerson.Should().NotBeNull();
            traktPerson.Name.Should().Be("Bryan Cranston");
            traktPerson.Ids.Should().NotBeNull();
            traktPerson.Ids.Trakt.Should().Be(297737U);
            traktPerson.Ids.Slug.Should().Be("bryan-cranston");
            traktPerson.Ids.Imdb.Should().Be("nm0186505");
            traktPerson.Ids.Tmdb.Should().Be(17419U);
            traktPerson.Ids.TvRage.Should().Be(1797U);
            traktPerson.Biography.Should().Be("Bryan Lee Cranston(born March 7, 1956) is an American actor, voice actor, writer and director.He is perhaps best known for his roles as Hal, the father in the Fox situation comedy Malcolm in the Middle, and as Walter White in the AMC drama series Breaking Bad, for which he has won three consecutive Outstanding Lead Actor in a Drama Series Emmy Awards. Other notable roles include Dr. Tim Whatley on Seinfeld, Doug Heffernan's neighbor in The King of Queens, Astronaut Buzz Aldrin in From the Earth to the Moon, and Ted Mosby's boss on How I Met Your Mother. Description above from the Wikipedia article Bryan Cranston, licensed under CC-BY-SA, full list of contributors on Wikipedia.");
            traktPerson.Birthday.Should().Be(DateTime.Parse("1956-03-07T00:00:00Z").ToUniversalTime());
            traktPerson.Death.Should().Be(DateTime.Parse("2016-04-06T00:00:00Z").ToUniversalTime());
            traktPerson.Age.Should().Be(60);
            traktPerson.Birthplace.Should().Be("San Fernando Valley, California, USA");
            traktPerson.Homepage.Should().Be("http://www.bryancranston.com/");
            traktPerson.Gender.Should().Be("male");
            traktPerson.KnownForDepartment.Should().Be("acting");
            traktPerson.SocialIds.Should().NotBeNull();
            traktPerson.SocialIds.Twitter.Should().Be("BryanCranston");
            traktPerson.SocialIds.Facebook.Should().Be("thebryancranston");
            traktPerson.SocialIds.Instagram.Should().Be("bryancranston");
            traktPerson.SocialIds.Wikipedia.Should().Be("Bryan_Cranston");
        }

        [Fact]
        public async Task Test_PersonObjectJsonReader_ReadObject_From_Json_String_Full_Not_Valid_1()
        {
            var jsonReader = new PersonObjectJsonReader();

            var traktPerson = await jsonReader.ReadObjectAsync(FULL_JSON_NOT_VALID);

            traktPerson.Should().NotBeNull();
            traktPerson.Name.Should().BeNull();
            traktPerson.Ids.Should().BeNull();
            traktPerson.Biography.Should().BeNull();
            traktPerson.Birthday.Should().BeNull();
            traktPerson.Death.Should().BeNull();
            traktPerson.Age.Should().Be(0);
            traktPerson.Birthplace.Should().BeNull();
            traktPerson.Homepage.Should().BeNull();
            traktPerson.Gender.Should().BeNullOrEmpty();
            traktPerson.KnownForDepartment.Should().BeNullOrEmpty();
            traktPerson.SocialIds.Should().BeNull();
        }

        [Fact]
        public async Task Test_PersonObjectJsonReader_ReadObject_From_Json_String_Null()
        {
            var jsonReader = new PersonObjectJsonReader();
            Func<Task<ITraktPerson>> traktPerson = () => jsonReader.ReadObjectAsync(default(string));
            await traktPerson.Should().ThrowAsync<ArgumentNullException>();
        }

        [Fact]
        public async Task Test_PersonObjectJsonReader_ReadObject_From_Json_String_Empty()
        {
            var jsonReader = new PersonObjectJsonReader();

            var traktPerson = await jsonReader.ReadObjectAsync(string.Empty);
            traktPerson.Should().BeNull();
        }
    }
}
