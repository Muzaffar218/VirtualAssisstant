// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

namespace MyAssistant1.TokenExchange
{
    public interface ITokenExchangeConfig
    {
        string Provider { get; set; }

        string ConnectionName { get; set; }
    }
}