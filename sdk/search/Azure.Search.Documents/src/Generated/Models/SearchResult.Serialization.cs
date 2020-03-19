// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Models
{
    internal partial class SearchResult
    {
        internal static SearchResult DeserializeSearchResult(JsonElement element)
        {
            SearchResult result = new SearchResult();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@search.score"))
                {
                    result.Score = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("@search.highlights"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Highlights = new Dictionary<string, IList<string>>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        IList<string> value = new List<string>();
                        foreach (var item in property0.Value.EnumerateArray())
                        {
                            value.Add(item.GetString());
                        }
                        result.Highlights.Add(property0.Name, value);
                    }
                    continue;
                }
                result.Add(property.Name, property.Value.GetObject());
            }
            return result;
        }
    }
}