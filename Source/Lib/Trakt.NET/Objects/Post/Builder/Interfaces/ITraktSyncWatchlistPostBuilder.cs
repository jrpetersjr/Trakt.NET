﻿namespace TraktNet.Objects.Post.Builder
{
    using Capabilities;
    using Post.Syncs.Watchlist;

    public interface ITraktSyncWatchlistPostBuilder
        : ITraktPostBuilder<ITraktSyncWatchlistPost>,
          ITraktPostBuilderWithMovie<ITraktSyncWatchlistPostBuilder, ITraktSyncWatchlistPost>,
          ITraktPostBuilderWithMovies<ITraktSyncWatchlistPostBuilder, ITraktSyncWatchlistPost>,
          ITraktPostBuilderWithShow<ITraktSyncWatchlistPostBuilder, ITraktSyncWatchlistPost>,
          ITraktPostBuilderWithShows<ITraktSyncWatchlistPostBuilder, ITraktSyncWatchlistPost>,
          ITraktPostBuilderAddShowWithSeasons<ITraktSyncWatchlistPostBuilder, ITraktSyncWatchlistPost>,
          ITraktPostBuilderAddShowWithSeasonsCollection<ITraktSyncWatchlistPostBuilder, ITraktSyncWatchlistPost, PostSeasons>,
          ITraktPostBuilderWithEpisode<ITraktSyncWatchlistPostBuilder, ITraktSyncWatchlistPost>,
          ITraktPostBuilderWithEpisodes<ITraktSyncWatchlistPostBuilder, ITraktSyncWatchlistPost>
    {
    }
}
