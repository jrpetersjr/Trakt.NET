﻿namespace TraktNet.Objects.Get.Tests.Users.Json.Reader
{
    public partial class AccountSettingsObjectJsonReader_Tests
    {
        private const string JSON_COMPLETE =
            @"{
                ""timezone"": ""America/Los_Angeles"",
                ""time_24hr"": true,
                ""cover_image"": ""https://walter.trakt.us/images/movies/000/001/545/fanarts/original/0abb604492.jpg?1406095042"",
                ""token"": ""60fa34c4f5e7f093ecc5a2d16d691e24"",
                ""date_format"": ""dmy""
              }";

        private const string JSON_INCOMPLETE_1 =
            @"{
                ""time_24hr"": true,
                ""cover_image"": ""https://walter.trakt.us/images/movies/000/001/545/fanarts/original/0abb604492.jpg?1406095042"",
                ""token"": ""60fa34c4f5e7f093ecc5a2d16d691e24"",
                ""date_format"": ""dmy""
              }";

        private const string JSON_INCOMPLETE_2 =
            @"{
                ""timezone"": ""America/Los_Angeles"",
                ""cover_image"": ""https://walter.trakt.us/images/movies/000/001/545/fanarts/original/0abb604492.jpg?1406095042"",
                ""token"": ""60fa34c4f5e7f093ecc5a2d16d691e24"",
                ""date_format"": ""dmy""
              }";

        private const string JSON_INCOMPLETE_3 =
            @"{
                ""timezone"": ""America/Los_Angeles"",
                ""time_24hr"": true,
                ""token"": ""60fa34c4f5e7f093ecc5a2d16d691e24"",
                ""date_format"": ""dmy""
              }";

        private const string JSON_INCOMPLETE_4 =
            @"{
                ""timezone"": ""America/Los_Angeles"",
                ""time_24hr"": true,
                ""cover_image"": ""https://walter.trakt.us/images/movies/000/001/545/fanarts/original/0abb604492.jpg?1406095042"",
                ""date_format"": ""dmy""
              }";

        private const string JSON_INCOMPLETE_5 =
            @"{
                ""timezone"": ""America/Los_Angeles"",
                ""time_24hr"": true,
                ""cover_image"": ""https://walter.trakt.us/images/movies/000/001/545/fanarts/original/0abb604492.jpg?1406095042"",
                ""token"": ""60fa34c4f5e7f093ecc5a2d16d691e24""
              }";

        private const string JSON_INCOMPLETE_6 =
            @"{
                ""timezone"": ""America/Los_Angeles""
              }";

        private const string JSON_INCOMPLETE_7 =
            @"{
                ""time_24hr"": true
              }";

        private const string JSON_INCOMPLETE_8 =
            @"{
                ""cover_image"": ""https://walter.trakt.us/images/movies/000/001/545/fanarts/original/0abb604492.jpg?1406095042""
              }";

        private const string JSON_INCOMPLETE_9 =
            @"{
                ""token"": ""60fa34c4f5e7f093ecc5a2d16d691e24""
              }";

        private const string JSON_INCOMPLETE_10 =
            @"{
                ""date_format"": ""dmy""
              }";

        private const string JSON_NOT_VALID_1 =
            @"{
                ""tz"": ""America/Los_Angeles"",
                ""time_24hr"": true,
                ""cover_image"": ""https://walter.trakt.us/images/movies/000/001/545/fanarts/original/0abb604492.jpg?1406095042"",
                ""token"": ""60fa34c4f5e7f093ecc5a2d16d691e24"",
                ""date_format"": ""dmy""
              }";

        private const string JSON_NOT_VALID_2 =
            @"{
                ""timezone"": ""America/Los_Angeles"",
                ""time"": true,
                ""cover_image"": ""https://walter.trakt.us/images/movies/000/001/545/fanarts/original/0abb604492.jpg?1406095042"",
                ""token"": ""60fa34c4f5e7f093ecc5a2d16d691e24"",
                ""date_format"": ""dmy""
              }";

        private const string JSON_NOT_VALID_3 =
            @"{
                ""timezone"": ""America/Los_Angeles"",
                ""time_24hr"": true,
                ""ci"": ""https://walter.trakt.us/images/movies/000/001/545/fanarts/original/0abb604492.jpg?1406095042"",
                ""token"": ""60fa34c4f5e7f093ecc5a2d16d691e24"",
                ""date_format"": ""dmy""
              }";

        private const string JSON_NOT_VALID_4 =
            @"{
                ""timezone"": ""America/Los_Angeles"",
                ""time_24hr"": true,
                ""cover_image"": ""https://walter.trakt.us/images/movies/000/001/545/fanarts/original/0abb604492.jpg?1406095042"",
                ""tk"": ""60fa34c4f5e7f093ecc5a2d16d691e24"",
                ""date_format"": ""dmy""
              }";

        private const string JSON_NOT_VALID_5 =
            @"{
                ""timezone"": ""America/Los_Angeles"",
                ""time_24hr"": true,
                ""cover_image"": ""https://walter.trakt.us/images/movies/000/001/545/fanarts/original/0abb604492.jpg?1406095042"",
                ""token"": ""60fa34c4f5e7f093ecc5a2d16d691e24"",
                ""df"": ""dmy""
              }";

        private const string JSON_NOT_VALID_6 =
            @"{
                ""tz"": ""America/Los_Angeles"",
                ""time"": true,
                ""ci"": ""https://walter.trakt.us/images/movies/000/001/545/fanarts/original/0abb604492.jpg?1406095042"",
                ""tk"": ""60fa34c4f5e7f093ecc5a2d16d691e24"",
                ""df"": ""dmy""
              }";
    }
}
