﻿namespace TraktNet.Objects.Post.Users.PersonalListItems
{
    using Get.Episodes;

    /// <summary>An user personal list items post episode, containing the required episode ids.</summary>
    public interface ITraktUserPersonalListItemsPostEpisode
    {
        /// <summary>Gets or sets the required episode ids. See also <seealso cref="ITraktEpisodeIds" />.</summary>
        ITraktEpisodeIds Ids { get; set; }

        /// <summary>Gets or sets the episode notes.</summary>
        string Notes { get; set; }
    }
}
