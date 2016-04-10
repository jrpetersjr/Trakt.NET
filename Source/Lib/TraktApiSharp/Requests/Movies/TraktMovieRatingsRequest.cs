﻿namespace TraktApiSharp.Requests.Movies
{
    using Base.Get;
    using Objects.Movies;

    internal class TraktMovieRatingsRequest : TraktGetByIdRequest<TraktMovieRating, TraktMovieRating>
    {
        internal TraktMovieRatingsRequest(TraktClient client) : base(client) { }

        protected override TraktAuthenticationRequirement AuthenticationRequirement => TraktAuthenticationRequirement.NotRequired;

        protected override string UriTemplate => "movies/{id}/ratings";

        protected override TraktRequestObjectType RequestObjectType => TraktRequestObjectType.Movies;

        protected override bool IsListResult => false;
    }
}
