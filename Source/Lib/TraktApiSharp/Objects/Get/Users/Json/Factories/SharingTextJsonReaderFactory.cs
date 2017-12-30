﻿namespace TraktApiSharp.Objects.Get.Users.Json.Factories
{
    using Get.Users.Json.Reader;
    using Objects.Json;
    using System;

    internal class SharingTextJsonReaderFactory : IJsonIOFactory<ITraktSharingText>
    {
        public IObjectJsonReader<ITraktSharingText> CreateObjectReader() => new SharingTextObjectJsonReader();

        public IArrayJsonReader<ITraktSharingText> CreateArrayReader()
        {
            throw new NotSupportedException($"A array json reader for {nameof(ITraktSharingText)} is not supported.");
        }

        public IObjectJsonReader<ITraktSharingText> CreateObjectWriter()
        {
            throw new NotImplementedException();
        }

        public IArrayJsonReader<ITraktSharingText> CreateArrayWriter()
        {
            throw new NotImplementedException();
        }
    }
}
