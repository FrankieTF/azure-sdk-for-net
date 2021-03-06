// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Query result of the prediction images that were sent to your prediction
    /// endpoint.
    /// </summary>
    public partial class PredictionQueryResult
    {
        /// <summary>
        /// Initializes a new instance of the PredictionQueryResult class.
        /// </summary>
        public PredictionQueryResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PredictionQueryResult class.
        /// </summary>
        /// <param name="token">Prediction Query Token.</param>
        /// <param name="results">Result of an image prediction
        /// request.</param>
        public PredictionQueryResult(PredictionQueryToken token = default(PredictionQueryToken), IList<StoredImagePrediction> results = default(IList<StoredImagePrediction>))
        {
            Token = token;
            Results = results;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets prediction Query Token.
        /// </summary>
        [JsonProperty(PropertyName = "token")]
        public PredictionQueryToken Token { get; set; }

        /// <summary>
        /// Gets result of an image prediction request.
        /// </summary>
        [JsonProperty(PropertyName = "results")]
        public IList<StoredImagePrediction> Results { get; private set; }

    }
}
