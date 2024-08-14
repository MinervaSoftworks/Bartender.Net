﻿using Bartender.Net.Framework.Selection;

namespace Bartender.Net.REST {
    public interface IApiRequestClient {
        Task<IApiResponse<T>?> GetAsync<T> (RequestConfiguration config, AccessLevel accessLevel) where T : class;
        Task<KeyValidationStatus> ValidateKeyAsync (string key, AccessLevel requiredLevel);
    }
}