﻿namespace TraktNet.Objects.Post.Users.PersonalListItems.Responses
{
    using Objects.Post.Responses;

    /// <summary>
    /// Represents the response for an user personal list items remove post. See also <see cref="ITraktUserPersonalListItemsPost" />.
    /// <para>Contains the number of deleted and not found movies, shows, seasons, episodes and people.</para>
    /// </summary>
    public interface ITraktUserPersonalListItemsRemovePostResponse
    {
        /// <summary>
        /// A collection containing the number of deleted movies, shows, seasons, episodes and people.
        /// <para>Nullable</para>
        /// </summary>
        ITraktUserPersonalListItemsPostResponseGroup Deleted { get; set; }

        /// <summary>
        /// A collection containing the ids of movies, shows, seasons, episodes and people, which were not found.
        /// <para>Nullable</para>
        /// </summary>
        ITraktUserPersonalListItemsPostResponseNotFoundGroup NotFound { get; set; }

        /// <summary>
        /// Information about the updated list.
        /// <para>Nullable</para>
        /// </summary>
        ITraktPostResponseListData List { get; set; }
    }
}
