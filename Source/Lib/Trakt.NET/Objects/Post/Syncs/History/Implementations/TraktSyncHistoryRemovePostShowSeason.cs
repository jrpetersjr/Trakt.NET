﻿namespace TraktNet.Objects.Post.Syncs.History
{
    using System.Collections.Generic;

    /// <summary>A Trakt history post season, containing the required season number and optional episodes.</summary>
    public class TraktSyncHistoryRemovePostShowSeason : ITraktSyncHistoryRemovePostShowSeason
    {
        /// <summary>Gets or sets the required season number of the Trakt season.</summary>
        public int Number { get; set; }

        /// <summary>
        /// An optional list of <see cref="ITraktSyncHistoryRemovePostShowEpisode" />s.
        /// <para>
        /// If no episodes are set, the whole Trakt season will be added to the history.
        /// Otherwise, only the specified episodes will be added to the history.
        /// </para>
        /// </summary>
        public IEnumerable<ITraktSyncHistoryRemovePostShowEpisode> Episodes { get; set; }
    }
}
