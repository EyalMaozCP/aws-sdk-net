/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// Container for the parameters to the CreateMediaLiveConnectorPipeline operation.
    /// Creates a streaming media pipeline in an Amazon Chime SDK meeting.
    /// </summary>
    public partial class CreateMediaLiveConnectorPipelineRequest : AmazonChimeSDKMediaPipelinesRequest
    {
        private string _clientRequestToken;
        private List<LiveConnectorSinkConfiguration> _sinks = new List<LiveConnectorSinkConfiguration>();
        private List<LiveConnectorSourceConfiguration> _sources = new List<LiveConnectorSourceConfiguration>();
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// The token assigned to the client making the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=64)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property Sinks. 
        /// <para>
        /// The media pipeline's data sinks.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<LiveConnectorSinkConfiguration> Sinks
        {
            get { return this._sinks; }
            set { this._sinks = value; }
        }

        // Check to see if Sinks property is set
        internal bool IsSetSinks()
        {
            return this._sinks != null && this._sinks.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// The media pipeline's data sources.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<LiveConnectorSourceConfiguration> Sources
        {
            get { return this._sources; }
            set { this._sources = value; }
        }

        // Check to see if Sources property is set
        internal bool IsSetSources()
        {
            return this._sources != null && this._sources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the media pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}