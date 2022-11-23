// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading;
using System.Threading.Tasks;

namespace MSStore.CLI.Services
{
    internal interface IImageConverter
    {
        Task<bool> ConvertIcoToPngAsync(string sourceFilePath, string destinationFilePath, CancellationToken ct);
    }
}