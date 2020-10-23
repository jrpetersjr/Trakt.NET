﻿namespace TraktNet.Objects.Basic.Tests.Json.Reader
{
    using FluentAssertions;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Threading.Tasks;
    using Trakt.NET.Tests.Utility;
    using Trakt.NET.Tests.Utility.Traits;
    using TraktNet.Objects.Basic;
    using TraktNet.Objects.Json;
    using Xunit;

    [Category("Objects.Basic.JsonReader")]
    public partial class CrewArrayJsonReader_Tests
    {
        [Fact]
        public async Task Test_CrewArrayJsonReader_ReadArray_From_Stream_Empty_Array()
        {
            var jsonReader = new ArrayJsonReader<ITraktCrew>();

            using (var stream = JSON_EMPTY_ARRAY.ToStream())
            {
                IEnumerable<ITraktCrew> traktCrews = await jsonReader.ReadArrayAsync(stream);
                traktCrews.Should().NotBeNull().And.BeEmpty();
            }
        }

        [Fact]
        public async Task Test_CrewArrayJsonReader_ReadArray_From_Stream_Complete()
        {
            var jsonReader = new ArrayJsonReader<ITraktCrew>();

            using (var stream = JSON_COMPLETE.ToStream())
            {
                IEnumerable<ITraktCrew> traktCrews = await jsonReader.ReadArrayAsync(stream);

                traktCrews.Should().NotBeNull();
                ITraktCrew[] crews = traktCrews.ToArray();

                crews[0].Production.Should().NotBeNull().And.HaveCount(1);
                ITraktCrewMember[] productionCrew = crews[0].Production.ToArray();

                productionCrew[0].Should().NotBeNull();
                productionCrew[0].Jobs.Should().NotBeNull().And.HaveCount(1).And.Contain("Producer");
                productionCrew[0].Person.Should().NotBeNull();
                productionCrew[0].Person.Name.Should().Be("Bryan Cranston");
                productionCrew[0].Person.Ids.Should().NotBeNull();
                productionCrew[0].Person.Ids.Trakt.Should().Be(297737U);
                productionCrew[0].Person.Ids.Slug.Should().Be("bryan-cranston");
                productionCrew[0].Person.Ids.Imdb.Should().Be("nm0186505");
                productionCrew[0].Person.Ids.Tmdb.Should().Be(17419U);
                productionCrew[0].Person.Ids.TvRage.Should().Be(1797U);

                crews[0].Art.Should().BeNull();
                crews[0].Crew.Should().BeNull();
                crews[0].CostumeAndMakeup.Should().BeNull();
                crews[0].Directing.Should().BeNull();
                crews[0].Writing.Should().BeNull();
                crews[0].Sound.Should().BeNull();
                crews[0].Camera.Should().BeNull();
                crews[0].Lighting.Should().BeNull();
                crews[0].VisualEffects.Should().BeNull();
                crews[0].Editing.Should().BeNull();

                crews[1].Production.Should().NotBeNull().And.HaveCount(1);
                productionCrew = crews[1].Production.ToArray();

                productionCrew[0].Should().NotBeNull();
                productionCrew[0].Jobs.Should().NotBeNull().And.HaveCount(1).And.Contain("Producer");
                productionCrew[0].Person.Should().NotBeNull();
                productionCrew[0].Person.Name.Should().Be("Bryan Cranston");
                productionCrew[0].Person.Ids.Should().NotBeNull();
                productionCrew[0].Person.Ids.Trakt.Should().Be(297737U);
                productionCrew[0].Person.Ids.Slug.Should().Be("bryan-cranston");
                productionCrew[0].Person.Ids.Imdb.Should().Be("nm0186505");
                productionCrew[0].Person.Ids.Tmdb.Should().Be(17419U);
                productionCrew[0].Person.Ids.TvRage.Should().Be(1797U);

                crews[1].Art.Should().BeNull();
                crews[1].Crew.Should().BeNull();
                crews[1].CostumeAndMakeup.Should().BeNull();
                crews[1].Directing.Should().BeNull();
                crews[1].Writing.Should().BeNull();
                crews[1].Sound.Should().BeNull();
                crews[1].Camera.Should().BeNull();
                crews[1].Lighting.Should().BeNull();
                crews[1].VisualEffects.Should().BeNull();
                crews[1].Editing.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_CrewArrayJsonReader_ReadArray_From_Stream_Incomplete_1()
        {
            var jsonReader = new ArrayJsonReader<ITraktCrew>();

            using (var stream = JSON_INCOMPLETE_1.ToStream())
            {
                IEnumerable<ITraktCrew> traktCrews = await jsonReader.ReadArrayAsync(stream);

                traktCrews.Should().NotBeNull();
                ITraktCrew[] crews = traktCrews.ToArray();

                crews[0].Production.Should().NotBeNull().And.HaveCount(1);
                ITraktCrewMember[] productionCrew = crews[0].Production.ToArray();

                productionCrew[0].Should().NotBeNull();
                productionCrew[0].Jobs.Should().NotBeNull().And.HaveCount(1).And.Contain("Producer");
                productionCrew[0].Person.Should().NotBeNull();
                productionCrew[0].Person.Name.Should().Be("Bryan Cranston");
                productionCrew[0].Person.Ids.Should().NotBeNull();
                productionCrew[0].Person.Ids.Trakt.Should().Be(297737U);
                productionCrew[0].Person.Ids.Slug.Should().Be("bryan-cranston");
                productionCrew[0].Person.Ids.Imdb.Should().Be("nm0186505");
                productionCrew[0].Person.Ids.Tmdb.Should().Be(17419U);
                productionCrew[0].Person.Ids.TvRage.Should().Be(1797U);

                crews[0].Art.Should().BeNull();
                crews[0].Crew.Should().BeNull();
                crews[0].CostumeAndMakeup.Should().BeNull();
                crews[0].Directing.Should().BeNull();
                crews[0].Writing.Should().BeNull();
                crews[0].Sound.Should().BeNull();
                crews[0].Camera.Should().BeNull();
                crews[0].Lighting.Should().BeNull();
                crews[0].VisualEffects.Should().BeNull();
                crews[0].Editing.Should().BeNull();

                crews[1].Production.Should().NotBeNull().And.HaveCount(1);
                productionCrew = crews[1].Production.ToArray();

                productionCrew[0].Should().NotBeNull();
                productionCrew[0].Jobs.Should().NotBeNull().And.HaveCount(1).And.Contain("Producer");
                productionCrew[0].Person.Should().BeNull();

                crews[1].Art.Should().BeNull();
                crews[1].Crew.Should().BeNull();
                crews[1].CostumeAndMakeup.Should().BeNull();
                crews[1].Directing.Should().BeNull();
                crews[1].Writing.Should().BeNull();
                crews[1].Sound.Should().BeNull();
                crews[1].Camera.Should().BeNull();
                crews[1].Lighting.Should().BeNull();
                crews[1].VisualEffects.Should().BeNull();
                crews[1].Editing.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_CrewArrayJsonReader_ReadArray_From_Stream_Incomplete_2()
        {
            var jsonReader = new ArrayJsonReader<ITraktCrew>();

            using (var stream = JSON_INCOMPLETE_2.ToStream())
            {
                IEnumerable<ITraktCrew> traktCrews = await jsonReader.ReadArrayAsync(stream);

                traktCrews.Should().NotBeNull();
                ITraktCrew[] crews = traktCrews.ToArray();

                crews[0].Production.Should().NotBeNull().And.HaveCount(1);
                ITraktCrewMember[] productionCrew = crews[0].Production.ToArray();

                productionCrew[0].Should().NotBeNull();
                productionCrew[0].Jobs.Should().NotBeNull().And.HaveCount(1).And.Contain("Producer");
                productionCrew[0].Person.Should().BeNull();

                crews[0].Art.Should().BeNull();
                crews[0].Crew.Should().BeNull();
                crews[0].CostumeAndMakeup.Should().BeNull();
                crews[0].Directing.Should().BeNull();
                crews[0].Writing.Should().BeNull();
                crews[0].Sound.Should().BeNull();
                crews[0].Camera.Should().BeNull();
                crews[0].Lighting.Should().BeNull();
                crews[0].VisualEffects.Should().BeNull();
                crews[0].Editing.Should().BeNull();

                crews[1].Production.Should().NotBeNull().And.HaveCount(1);
                productionCrew = crews[1].Production.ToArray();

                productionCrew[0].Should().NotBeNull();
                productionCrew[0].Jobs.Should().NotBeNull().And.HaveCount(1).And.Contain("Producer");
                productionCrew[0].Person.Should().NotBeNull();
                productionCrew[0].Person.Name.Should().Be("Bryan Cranston");
                productionCrew[0].Person.Ids.Should().NotBeNull();
                productionCrew[0].Person.Ids.Trakt.Should().Be(297737U);
                productionCrew[0].Person.Ids.Slug.Should().Be("bryan-cranston");
                productionCrew[0].Person.Ids.Imdb.Should().Be("nm0186505");
                productionCrew[0].Person.Ids.Tmdb.Should().Be(17419U);
                productionCrew[0].Person.Ids.TvRage.Should().Be(1797U);

                crews[1].Art.Should().BeNull();
                crews[1].Crew.Should().BeNull();
                crews[1].CostumeAndMakeup.Should().BeNull();
                crews[1].Directing.Should().BeNull();
                crews[1].Writing.Should().BeNull();
                crews[1].Sound.Should().BeNull();
                crews[1].Camera.Should().BeNull();
                crews[1].Lighting.Should().BeNull();
                crews[1].VisualEffects.Should().BeNull();
                crews[1].Editing.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_CrewArrayJsonReader_ReadArray_From_Stream_Not_Valid_1()
        {
            var jsonReader = new ArrayJsonReader<ITraktCrew>();

            using (var stream = JSON_NOT_VALID_1.ToStream())
            {
                IEnumerable<ITraktCrew> traktCrews = await jsonReader.ReadArrayAsync(stream);

                traktCrews.Should().NotBeNull();
                ITraktCrew[] crews = traktCrews.ToArray();

                crews[0].Production.Should().NotBeNull().And.HaveCount(1);
                ITraktCrewMember[] productionCrew = crews[0].Production.ToArray();

                productionCrew[0].Should().NotBeNull();
                productionCrew[0].Jobs.Should().BeNull();
                productionCrew[0].Person.Should().NotBeNull();
                productionCrew[0].Person.Name.Should().Be("Bryan Cranston");
                productionCrew[0].Person.Ids.Should().NotBeNull();
                productionCrew[0].Person.Ids.Trakt.Should().Be(297737U);
                productionCrew[0].Person.Ids.Slug.Should().Be("bryan-cranston");
                productionCrew[0].Person.Ids.Imdb.Should().Be("nm0186505");
                productionCrew[0].Person.Ids.Tmdb.Should().Be(17419U);
                productionCrew[0].Person.Ids.TvRage.Should().Be(1797U);

                crews[0].Art.Should().BeNull();
                crews[0].Crew.Should().BeNull();
                crews[0].CostumeAndMakeup.Should().BeNull();
                crews[0].Directing.Should().BeNull();
                crews[0].Writing.Should().BeNull();
                crews[0].Sound.Should().BeNull();
                crews[0].Camera.Should().BeNull();
                crews[0].Lighting.Should().BeNull();
                crews[0].VisualEffects.Should().BeNull();
                crews[0].Editing.Should().BeNull();

                crews[1].Production.Should().NotBeNull().And.HaveCount(1);
                productionCrew = crews[1].Production.ToArray();

                productionCrew[0].Should().NotBeNull();
                productionCrew[0].Jobs.Should().NotBeNull().And.HaveCount(1).And.Contain("Producer");
                productionCrew[0].Person.Should().NotBeNull();
                productionCrew[0].Person.Name.Should().Be("Bryan Cranston");
                productionCrew[0].Person.Ids.Should().NotBeNull();
                productionCrew[0].Person.Ids.Trakt.Should().Be(297737U);
                productionCrew[0].Person.Ids.Slug.Should().Be("bryan-cranston");
                productionCrew[0].Person.Ids.Imdb.Should().Be("nm0186505");
                productionCrew[0].Person.Ids.Tmdb.Should().Be(17419U);
                productionCrew[0].Person.Ids.TvRage.Should().Be(1797U);

                crews[1].Art.Should().BeNull();
                crews[1].Crew.Should().BeNull();
                crews[1].CostumeAndMakeup.Should().BeNull();
                crews[1].Directing.Should().BeNull();
                crews[1].Writing.Should().BeNull();
                crews[1].Sound.Should().BeNull();
                crews[1].Camera.Should().BeNull();
                crews[1].Lighting.Should().BeNull();
                crews[1].VisualEffects.Should().BeNull();
                crews[1].Editing.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_CrewArrayJsonReader_ReadArray_From_Stream_Not_Valid_2()
        {
            var jsonReader = new ArrayJsonReader<ITraktCrew>();

            using (var stream = JSON_NOT_VALID_2.ToStream())
            {
                IEnumerable<ITraktCrew> traktCrews = await jsonReader.ReadArrayAsync(stream);

                traktCrews.Should().NotBeNull();
                ITraktCrew[] crews = traktCrews.ToArray();

                crews[0].Production.Should().NotBeNull().And.HaveCount(1);
                ITraktCrewMember[] productionCrew = crews[0].Production.ToArray();

                productionCrew[0].Should().NotBeNull();
                productionCrew[0].Jobs.Should().NotBeNull().And.HaveCount(1).And.Contain("Producer");
                productionCrew[0].Person.Should().NotBeNull();
                productionCrew[0].Person.Name.Should().Be("Bryan Cranston");
                productionCrew[0].Person.Ids.Should().NotBeNull();
                productionCrew[0].Person.Ids.Trakt.Should().Be(297737U);
                productionCrew[0].Person.Ids.Slug.Should().Be("bryan-cranston");
                productionCrew[0].Person.Ids.Imdb.Should().Be("nm0186505");
                productionCrew[0].Person.Ids.Tmdb.Should().Be(17419U);
                productionCrew[0].Person.Ids.TvRage.Should().Be(1797U);

                crews[0].Art.Should().BeNull();
                crews[0].Crew.Should().BeNull();
                crews[0].CostumeAndMakeup.Should().BeNull();
                crews[0].Directing.Should().BeNull();
                crews[0].Writing.Should().BeNull();
                crews[0].Sound.Should().BeNull();
                crews[0].Camera.Should().BeNull();
                crews[0].Lighting.Should().BeNull();
                crews[0].VisualEffects.Should().BeNull();
                crews[0].Editing.Should().BeNull();

                crews[1].Production.Should().NotBeNull().And.HaveCount(1);
                productionCrew = crews[1].Production.ToArray();

                productionCrew[0].Should().NotBeNull();
                productionCrew[0].Jobs.Should().BeNull();
                productionCrew[0].Person.Should().NotBeNull();
                productionCrew[0].Person.Name.Should().Be("Bryan Cranston");
                productionCrew[0].Person.Ids.Should().NotBeNull();
                productionCrew[0].Person.Ids.Trakt.Should().Be(297737U);
                productionCrew[0].Person.Ids.Slug.Should().Be("bryan-cranston");
                productionCrew[0].Person.Ids.Imdb.Should().Be("nm0186505");
                productionCrew[0].Person.Ids.Tmdb.Should().Be(17419U);
                productionCrew[0].Person.Ids.TvRage.Should().Be(1797U);

                crews[1].Art.Should().BeNull();
                crews[1].Crew.Should().BeNull();
                crews[1].CostumeAndMakeup.Should().BeNull();
                crews[1].Directing.Should().BeNull();
                crews[1].Writing.Should().BeNull();
                crews[1].Sound.Should().BeNull();
                crews[1].Camera.Should().BeNull();
                crews[1].Lighting.Should().BeNull();
                crews[1].VisualEffects.Should().BeNull();
                crews[1].Editing.Should().BeNull();
            }
        }

        [Fact]
        public async Task Test_CrewArrayJsonReader_ReadArray_From_Stream_Not_Valid_3()
        {
            var jsonReader = new ArrayJsonReader<ITraktCrew>();

            using (var stream = JSON_NOT_VALID_3.ToStream())
            {
                IEnumerable<ITraktCrew> traktCrews = await jsonReader.ReadArrayAsync(stream);

                traktCrews.Should().NotBeNull();
                ITraktCrew[] crews = traktCrews.ToArray();

                crews[0].Production.Should().NotBeNull().And.HaveCount(1);
                ITraktCrewMember[] productionCrew = crews[0].Production.ToArray();

                productionCrew[0].Should().NotBeNull();
                productionCrew[0].Jobs.Should().BeNull();
                productionCrew[0].Person.Should().NotBeNull();
                productionCrew[0].Person.Name.Should().Be("Bryan Cranston");
                productionCrew[0].Person.Ids.Should().NotBeNull();
                productionCrew[0].Person.Ids.Trakt.Should().Be(297737U);
                productionCrew[0].Person.Ids.Slug.Should().Be("bryan-cranston");
                productionCrew[0].Person.Ids.Imdb.Should().Be("nm0186505");
                productionCrew[0].Person.Ids.Tmdb.Should().Be(17419U);
                productionCrew[0].Person.Ids.TvRage.Should().Be(1797U);

                crews[0].Art.Should().BeNull();
                crews[0].Crew.Should().BeNull();
                crews[0].CostumeAndMakeup.Should().BeNull();
                crews[0].Directing.Should().BeNull();
                crews[0].Writing.Should().BeNull();
                crews[0].Sound.Should().BeNull();
                crews[0].Camera.Should().BeNull();
                crews[0].Lighting.Should().BeNull();
                crews[0].VisualEffects.Should().BeNull();
                crews[0].Editing.Should().BeNull();

                crews[1].Production.Should().NotBeNull().And.HaveCount(1);
                productionCrew = crews[1].Production.ToArray();

                productionCrew[0].Should().NotBeNull();
                productionCrew[0].Jobs.Should().BeNull();
                productionCrew[0].Person.Should().NotBeNull();
                productionCrew[0].Person.Name.Should().Be("Bryan Cranston");
                productionCrew[0].Person.Ids.Should().NotBeNull();
                productionCrew[0].Person.Ids.Trakt.Should().Be(297737U);
                productionCrew[0].Person.Ids.Slug.Should().Be("bryan-cranston");
                productionCrew[0].Person.Ids.Imdb.Should().Be("nm0186505");
                productionCrew[0].Person.Ids.Tmdb.Should().Be(17419U);
                productionCrew[0].Person.Ids.TvRage.Should().Be(1797U);

                crews[1].Art.Should().BeNull();
                crews[1].Crew.Should().BeNull();
                crews[1].CostumeAndMakeup.Should().BeNull();
                crews[1].Directing.Should().BeNull();
                crews[1].Writing.Should().BeNull();
                crews[1].Sound.Should().BeNull();
                crews[1].Camera.Should().BeNull();
                crews[1].Lighting.Should().BeNull();
                crews[1].VisualEffects.Should().BeNull();
                crews[1].Editing.Should().BeNull();
            }
        }

        [Fact]
        public void Test_CrewArrayJsonReader_ReadArray_From_Stream_Null()
        {
            var jsonReader = new ArrayJsonReader<ITraktCrew>();
            Func<Task<IEnumerable<ITraktCrew>>> traktCrews = () => jsonReader.ReadArrayAsync(default(Stream));
            traktCrews.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public async Task Test_CrewArrayJsonReader_ReadArray_From_Stream_Empty()
        {
            var jsonReader = new ArrayJsonReader<ITraktCrew>();

            using (var stream = string.Empty.ToStream())
            {
                IEnumerable<ITraktCrew> traktCrews = await jsonReader.ReadArrayAsync(stream);
                traktCrews.Should().BeNull();
            }
        }
    }
}
