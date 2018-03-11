﻿namespace TraktApiSharp.Requests.Syncs.OAuth
{
    using Objects.Post.Syncs.Watchlist.Implementations;
    using Objects.Post.Syncs.Watchlist.Responses;

    internal sealed class SyncWatchlistAddRequest : ASyncPostRequest<ITraktSyncWatchlistPostResponse, TraktSyncWatchlistPost>
    {
        public override string UriTemplate => "sync/watchlist";
    }
}
