﻿namespace TraktNet.Objects.Post.Users.PersonalListItems
{
    using Get.People;
    using Objects.Json;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// An user personal list items post, containing all movies, shows, episodes and / or people,
    /// which should be added to an user's personal list.
    /// </summary>
    public class TraktUserPersonalListItemsPost : ITraktUserPersonalListItemsPost
    {
        /// <summary>
        /// An optional list of <see cref="ITraktUserPersonalListItemsPostMovie" />s.
        /// <para>Each <see cref="ITraktUserPersonalListItemsPostMovie" /> must have at least a valid Trakt id.</para>
        /// </summary>
        public IEnumerable<ITraktUserPersonalListItemsPostMovie> Movies { get; set; }

        /// <summary>
        /// An optional list of <see cref="ITraktUserPersonalListItemsPostShow" />s.
        /// <para>Each <see cref="ITraktUserPersonalListItemsPostShow" /> must have at least a valid Trakt id.</para>
        /// </summary>
        public IEnumerable<ITraktUserPersonalListItemsPostShow> Shows { get; set; }

        /// <summary>
        /// An optional list of <see cref="ITraktPerson" />s.
        /// <para>Each <see cref="ITraktPerson" /> must have at least a valid Trakt id and a name.</para>
        /// </summary>
        public IEnumerable<ITraktPerson> People { get; set; }

        public Task<string> ToJson(CancellationToken cancellationToken = default)
        {
            IObjectJsonWriter<ITraktUserPersonalListItemsPost> objectJsonWriter = JsonFactoryContainer.CreateObjectWriter<ITraktUserPersonalListItemsPost>();
            return objectJsonWriter.WriteObjectAsync(this, cancellationToken);
        }

        public void Validate()
        {
            // TODO
        }
    }
}
