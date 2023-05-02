namespace TraktNet.Objects.Get.Tests.Shows.Json.Reader
{
    using FluentAssertions;
    using Newtonsoft.Json;
    using System;
    using System.IO;
    using System.Threading.Tasks;
    using Trakt.NET.Tests.Utility.Traits;
    using TraktNet.Objects.Get.Shows;
    using TraktNet.Objects.Get.Shows.Json.Reader;
    using Xunit;

    [TestCategory("Objects.Get.Shows.JsonReader")]
    public partial class ShowCertificationObjectJsonReader_Tests
    {
        [Fact]
        public async Task Test_ShowCertificationObjectJsonReader_ReadObject_From_JsonReader_Complete()
        {
            var traktJsonReader = new ShowCertificationObjectJsonReader();

            using (var reader = new StringReader(JSON_COMPLETE))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var traktShowCertification = await traktJsonReader.ReadObjectAsync(jsonReader);

                traktShowCertification.Should().NotBeNull();
                traktShowCertification.Certification.Should().Be("TV-MA");
                traktShowCertification.CountryCode.Should().Be("us");
            }
        }

        [Fact]
        public async Task Test_ShowCertificationObjectJsonReader_ReadObject_From_JsonReader_Incomplete_1()
        {
            var traktJsonReader = new ShowCertificationObjectJsonReader();

            using (var reader = new StringReader(JSON_INCOMPLETE_1))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var traktShowCertification = await traktJsonReader.ReadObjectAsync(jsonReader);

                traktShowCertification.Should().NotBeNull();
                traktShowCertification.Certification.Should().BeNull();
                traktShowCertification.CountryCode.Should().Be("us");
            }
        }

        [Fact]
        public async Task Test_ShowCertificationObjectJsonReader_ReadObject_From_JsonReader_Incomplete_2()
        {
            var traktJsonReader = new ShowCertificationObjectJsonReader();

            using (var reader = new StringReader(JSON_INCOMPLETE_2))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var traktShowCertification = await traktJsonReader.ReadObjectAsync(jsonReader);

                traktShowCertification.Should().NotBeNull();
                traktShowCertification.Certification.Should().Be("TV-MA");
                traktShowCertification.CountryCode.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_ShowCertificationObjectJsonReader_ReadObject_From_JsonReader_Not_Valid_1()
        {
            var traktJsonReader = new ShowCertificationObjectJsonReader();

            using (var reader = new StringReader(JSON_NOT_VALID_1))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var traktShowCertification = await traktJsonReader.ReadObjectAsync(jsonReader);

                traktShowCertification.Should().NotBeNull();
                traktShowCertification.Certification.Should().BeNull();
                traktShowCertification.CountryCode.Should().Be("us");
            }
        }

        [Fact]
        public async Task Test_ShowCertificationObjectJsonReader_ReadObject_From_JsonReader_Not_Valid_2()
        {
            var traktJsonReader = new ShowCertificationObjectJsonReader();

            using (var reader = new StringReader(JSON_NOT_VALID_2))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var traktShowCertification = await traktJsonReader.ReadObjectAsync(jsonReader);

                traktShowCertification.Should().NotBeNull();
                traktShowCertification.Certification.Should().Be("TV-MA");
                traktShowCertification.CountryCode.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_ShowCertificationObjectJsonReader_ReadObject_From_JsonReader_Not_Valid_3()
        {
            var traktJsonReader = new ShowCertificationObjectJsonReader();

            using (var reader = new StringReader(JSON_NOT_VALID_3))
            using (var jsonReader = new JsonTextReader(reader))
            {
                var traktShowCertification = await traktJsonReader.ReadObjectAsync(jsonReader);

                traktShowCertification.Should().NotBeNull();
                traktShowCertification.Certification.Should().BeNull();
                traktShowCertification.CountryCode.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_ShowCertificationObjectJsonReader_ReadObject_From_JsonReader_Null()
        {
            var traktJsonReader = new ShowCertificationObjectJsonReader();
            Func<Task<ITraktShowCertification>> traktShowCertification = () => traktJsonReader.ReadObjectAsync(default(JsonTextReader));
            await traktShowCertification.Should().ThrowAsync<ArgumentNullException>();
        }

        [Fact]
        public async Task Test_ShowCertificationObjectJsonReader_ReadObject_From_JsonReader_Empty()
        {
            var traktJsonReader = new ShowCertificationObjectJsonReader();
            using var reader = new StringReader(string.Empty);
            using var jsonReader = new JsonTextReader(reader);
            var traktShowCertification = await traktJsonReader.ReadObjectAsync(jsonReader);
            traktShowCertification.Should().BeNull();
        }
    }
}