﻿namespace TraktNet.Objects.Basic
{
    using System.Collections.Generic;

    /// <summary>A collection of crew members in different categories.</summary>
    public interface ITraktCrew
    {
        /// <summary>
        /// Gets or sets a list of crew members in the production category. See also <seealso cref="ITraktCrewMember" />.
        /// <para>Nullable</para>
        /// </summary>
        IList<ITraktCrewMember> Production { get; set; }

        /// <summary>
        /// Gets or sets a list of crew members in the art category. See also <seealso cref="ITraktCrewMember" />.
        /// <para>Nullable</para>
        /// </summary>
        IList<ITraktCrewMember> Art { get; set; }

        /// <summary>
        /// Gets or sets a list of crew members. See also <seealso cref="ITraktCrewMember" />.
        /// <para>Nullable</para>
        /// </summary>
        IList<ITraktCrewMember> Crew { get; set; }

        /// <summary>
        /// Gets or sets a list of crew members in the costume and make-up category. See also <seealso cref="ITraktCrewMember" />.
        /// <para>Nullable</para>
        /// </summary>
        IList<ITraktCrewMember> CostumeAndMakeup { get; set; }

        /// <summary>
        /// Gets or sets a list of crew members in the directing category. See also <seealso cref="ITraktCrewMember" />.
        /// <para>Nullable</para>
        /// </summary>
        IList<ITraktCrewMember> Directing { get; set; }

        /// <summary>
        /// Gets or sets a list of crew members in the writing category. See also <seealso cref="ITraktCrewMember" />.
        /// <para>Nullable</para>
        /// </summary>
        IList<ITraktCrewMember> Writing { get; set; }

        /// <summary>
        /// Gets or sets a list of crew members in the sound category. See also <seealso cref="ITraktCrewMember" />.
        /// <para>Nullable</para>
        /// </summary>
        IList<ITraktCrewMember> Sound { get; set; }

        /// <summary>
        /// Gets or sets a list of crew members in the camera category. See also <seealso cref="ITraktCrewMember" />.
        /// <para>Nullable</para>
        /// </summary>
        IList<ITraktCrewMember> Camera { get; set; }

        /// <summary>
        /// Gets or sets a list of crew members in the lighting category. See also <seealso cref="ITraktCrewMember" />.
        /// <para>Nullable</para>
        /// </summary>
        IList<ITraktCrewMember> Lighting { get; set; }

        /// <summary>
        /// Gets or sets a list of crew members in the visual effects category. See also <seealso cref="ITraktCrewMember" />.
        /// <para>Nullable</para>
        /// </summary>
        IList<ITraktCrewMember> VisualEffects { get; set; }

        /// <summary>
        /// Gets or sets a list of crew members in the editing category. See also <seealso cref="ITraktCrewMember" />.
        /// <para>Nullable</para>
        /// </summary>
        IList<ITraktCrewMember> Editing { get; set; }
    }
}
