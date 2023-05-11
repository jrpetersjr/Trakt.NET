﻿namespace TraktNet.Objects.Post.Users.PersonalListItems
{
    using Get.Shows;
    using System.Collections.Generic;

    /// <summary>
    /// An user personal list items post show, containing the required show ids.
    /// <para>Can also contain optional seasons.</para>
    /// </summary>
    public class TraktUserPersonalListItemsPostShow : ITraktUserPersonalListItemsPostShow
    {
        /// <summary>Gets or sets the required show ids. See also <seealso cref="ITraktShowIds" />.</summary>
        public ITraktShowIds Ids { get; set; }

        /// <summary>
        /// An optional list of <see cref="ITraktUserPersonalListItemsPostShowSeason" />s.
        /// <para>
        /// If no seasons are set, the whole Trakt show will be added to the personal list.
        /// Otherwise, only the specified seasons and / or episodes will be added to the personal list.
        /// </para>
        /// </summary>
        public IList<ITraktUserPersonalListItemsPostShowSeason> Seasons { get; set; }

        /// <summary>Gets or sets the show notes.</summary>
        public string Notes { get; set; }
    }
}
