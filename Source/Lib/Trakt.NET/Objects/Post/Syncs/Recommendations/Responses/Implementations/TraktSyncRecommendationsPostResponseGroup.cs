﻿namespace TraktNet.Objects.Post.Syncs.Recommendations.Responses
{
    /// <summary>A collection containing the number of movies and shows.</summary>
    public class TraktSyncRecommendationsPostResponseGroup : ITraktSyncRecommendationsPostResponseGroup
    {
        /// <summary>Gets or sets the number of movies.</summary>
        public int? Movies { get; set; }

        /// <summary>Gets or sets the number of shows.</summary>
        public int? Shows { get; set; }
    }
}
