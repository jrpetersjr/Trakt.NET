﻿namespace TraktNet.Objects.Post.Syncs.Recommendations.Responses
{
    /// <summary>
    /// Represents the response for a recommendations post. See also <see cref="ITraktSyncRecommendationsPost" />.
    /// <para>Contains the number of added, existing and not found movies and shows.</para>
    /// </summary>
    public class TraktSyncRecommendationsPostResponse : ITraktSyncRecommendationsPostResponse
    {
        /// <summary>
        /// A collection containing the number of added movies and shows.
        /// <para>Nullable</para>
        /// </summary>
        public ITraktSyncRecommendationsPostResponseGroup Added { get; set; }

        /// <summary>
        /// A collection containing the number of existing movies and shows.
        /// <para>Nullable</para>
        /// </summary>
        public ITraktSyncRecommendationsPostResponseGroup Existing { get; set; }

        /// <summary>
        /// A collection containing the ids of movies and shows, which were not found.
        /// <para>Nullable</para>
        /// </summary>
        public ITraktSyncRecommendationsPostResponseNotFoundGroup NotFound { get; set; }
    }
}