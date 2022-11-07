﻿namespace TraktNet.Requests.Recommendations.OAuth
{
    using Base;
    using Exceptions;
    using Extensions;
    using Interfaces;
    using System.Collections.Generic;

    internal abstract class AUserRecommendationHideRequest : ADeleteRequest, IHasId
    {
        public string Id { get; set; }

        public abstract RequestObjectType RequestObjectType { get; }

        public override IDictionary<string, object> GetUriPathParameters() => new Dictionary<string, object> { ["id"] = Id };

        public override void Validate()
        {
            if (Id == null)
                throw new TraktRequestValidationException(nameof(Id), "id must not be null");

            if (Id == string.Empty || Id.ContainsSpace())
                throw new TraktRequestValidationException(nameof(Id), "id or slug not valid");
        }
    }
}
