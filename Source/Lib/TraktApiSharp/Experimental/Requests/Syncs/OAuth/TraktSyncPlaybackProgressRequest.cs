﻿namespace TraktApiSharp.Experimental.Requests.Syncs.OAuth
{
    using Enums;
    using Objects.Get.Syncs.Playback;
    using System.Collections.Generic;

    internal sealed class TraktSyncPlaybackProgressRequest : ATraktSyncListRequest<TraktSyncPlaybackProgressItem>
    {
        internal TraktSyncPlaybackProgressRequest(TraktClient client) : base(client) { }

        internal TraktSyncType Type { get; set; }

        public override IDictionary<string, object> GetUriPathParameters()
        {
            var uriParams = base.GetUriPathParameters();

            if (Type != null && Type != TraktSyncType.Unspecified)
                uriParams.Add("type", Type.UriName);

            return uriParams;
        }

        public override string UriTemplate => "sync/playback{/type}{?limit}";
    }
}
