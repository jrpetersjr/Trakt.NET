﻿namespace TraktApiSharp.Objects.Get.Episodes
{
    using System;
    using System.Collections.Generic;

    public interface ITraktEpisode
    {
        int? SeasonNumber { get; set; }

        int? EpisodeNumber { get; set; }

        string EpisodeTitle { get; set; }

        TraktEpisodeIds EpisodeIds { get; set; }

        int? AbsoluteEpisodeNumber { get; set; }

        string EpisodeOverview { get; set; }

        int? EpisodeRuntime { get; set; }

        float? EpisodeRating { get; set; }

        int? EpisodeVotes { get; set; }

        DateTime? EpisodeAiredFirstAt { get; set; }

        DateTime? EpisodeUpdatedAt { get; set; }

        IEnumerable<string> AvailableEpisodeTranslationLanguageCodes { get; set; }

        IEnumerable<TraktEpisodeTranslation> EpisodeTranslations { get; set; }
    }
}
