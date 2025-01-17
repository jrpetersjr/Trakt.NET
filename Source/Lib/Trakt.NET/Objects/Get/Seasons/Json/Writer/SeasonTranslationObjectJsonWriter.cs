﻿namespace TraktNet.Objects.Get.Seasons.Json.Writer
{
    using Newtonsoft.Json;
    using Objects.Json;
    using System.Threading;
    using System.Threading.Tasks;

    internal class SeasonTranslationObjectJsonWriter : AObjectJsonWriter<ITraktSeasonTranslation>
    {
        public override async Task WriteObjectAsync(JsonTextWriter jsonWriter, ITraktSeasonTranslation obj, CancellationToken cancellationToken = default)
        {
            CheckJsonTextWriter(jsonWriter);
            await jsonWriter.WriteStartObjectAsync(cancellationToken).ConfigureAwait(false);

            if (!string.IsNullOrEmpty(obj.Title))
            {
                await jsonWriter.WritePropertyNameAsync(JsonProperties.PROPERTY_NAME_TITLE, cancellationToken).ConfigureAwait(false);
                await jsonWriter.WriteValueAsync(obj.Title, cancellationToken).ConfigureAwait(false);
            }

            if (!string.IsNullOrEmpty(obj.Overview))
            {
                await jsonWriter.WritePropertyNameAsync(JsonProperties.PROPERTY_NAME_OVERVIEW, cancellationToken).ConfigureAwait(false);
                await jsonWriter.WriteValueAsync(obj.Overview, cancellationToken).ConfigureAwait(false);
            }

            if (!string.IsNullOrEmpty(obj.LanguageCode))
            {
                await jsonWriter.WritePropertyNameAsync(JsonProperties.PROPERTY_NAME_LANGUAGE, cancellationToken).ConfigureAwait(false);
                await jsonWriter.WriteValueAsync(obj.LanguageCode, cancellationToken).ConfigureAwait(false);
            }

            await jsonWriter.WriteEndObjectAsync(cancellationToken).ConfigureAwait(false);
        }
    }
}
