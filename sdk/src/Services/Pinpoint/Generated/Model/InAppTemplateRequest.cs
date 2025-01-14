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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// InApp Template Request.
    /// </summary>
    public partial class InAppTemplateRequest
    {
        private List<InAppMessageContent> _content = new List<InAppMessageContent>();
        private Dictionary<string, string> _customConfig = new Dictionary<string, string>();
        private Layout _layout;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _templateDescription;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// The content of the message, can include up to 5 modals. Each modal must contain a
        /// message, a header, and background color. ImageUrl and buttons are optional.
        /// </para>
        /// </summary>
        public List<InAppMessageContent> Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null && this._content.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CustomConfig. 
        /// <para>
        /// Custom config to be sent to client.
        /// </para>
        /// </summary>
        public Dictionary<string, string> CustomConfig
        {
            get { return this._customConfig; }
            set { this._customConfig = value; }
        }

        // Check to see if CustomConfig property is set
        internal bool IsSetCustomConfig()
        {
            return this._customConfig != null && this._customConfig.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Layout. 
        /// <para>
        /// The layout of the message.
        /// </para>
        /// </summary>
        public Layout Layout
        {
            get { return this._layout; }
            set { this._layout = value; }
        }

        // Check to see if Layout property is set
        internal bool IsSetLayout()
        {
            return this._layout != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A string-to-string map of key-value pairs that defines the tags to associate with
        /// the message template. Each tag consists of a required tag key and an associated tag
        /// value.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TemplateDescription. 
        /// <para>
        /// The description of the template.
        /// </para>
        /// </summary>
        public string TemplateDescription
        {
            get { return this._templateDescription; }
            set { this._templateDescription = value; }
        }

        // Check to see if TemplateDescription property is set
        internal bool IsSetTemplateDescription()
        {
            return this._templateDescription != null;
        }

    }
}