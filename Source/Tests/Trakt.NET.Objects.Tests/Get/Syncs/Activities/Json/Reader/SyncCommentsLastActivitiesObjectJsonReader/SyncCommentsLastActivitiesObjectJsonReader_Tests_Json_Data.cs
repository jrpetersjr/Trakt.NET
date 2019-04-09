﻿namespace TraktNet.Objects.Tests.Get.Syncs.Activities.Json.Reader
{
    public partial class SyncCommentsLastActivitiesObjectJsonReader_Tests
    {
        private const string JSON_COMPLETE =
            @"{
                ""liked_at"": ""2014-09-01T09:10:11.000Z""
              }";

        private const string JSON_NOT_VALID =
            @"{
                ""liked"": ""2014-09-01T09:10:11.000Z""
              }";
    }
}