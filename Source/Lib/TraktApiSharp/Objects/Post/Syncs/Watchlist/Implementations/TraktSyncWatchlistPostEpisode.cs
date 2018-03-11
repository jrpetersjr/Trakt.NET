﻿namespace TraktApiSharp.Objects.Post.Syncs.Watchlist.Implementations
{
    using Get.Episodes;

    /// <summary>A Trakt watchlist post episode, containing the required episode ids.</summary>
    public class TraktSyncWatchlistPostEpisode : ITraktSyncWatchlistPostEpisode
    {
        /// <summary>Gets or sets the required episode ids. See also <seealso cref="ITraktEpisodeIds" />.</summary>
        public ITraktEpisodeIds Ids { get; set; }
    }
}
