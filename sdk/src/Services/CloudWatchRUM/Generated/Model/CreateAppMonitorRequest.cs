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
 * Do not modify this file. This file is generated from the rum-2018-05-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudWatchRUM.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAppMonitor operation.
    /// Creates a Amazon CloudWatch RUM app monitor, which collects telemetry data from your
    /// application and sends that data to RUM. The data includes performance and reliability
    /// information such as page load time, client-side errors, and user behavior.
    /// 
    ///  
    /// <para>
    /// You use this operation only to create a new app monitor. To update an existing app
    /// monitor, use <a href="https://docs.aws.amazon.com/cloudwatchrum/latest/APIReference/API_UpdateAppMonitor.html">UpdateAppMonitor</a>
    /// instead.
    /// </para>
    ///  
    /// <para>
    /// After you create an app monitor, sign in to the CloudWatch RUM console to get the
    /// JavaScript code snippet to add to your web application. For more information, see
    /// <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/monitoring/CloudWatch-RUM-find-code-snippet.html">How
    /// do I find a code snippet that I've already generated?</a> 
    /// </para>
    /// </summary>
    public partial class CreateAppMonitorRequest : AmazonCloudWatchRUMRequest
    {
        private AppMonitorConfiguration _appMonitorConfiguration;
        private bool? _cwLogEnabled;
        private string _domain;
        private string _name;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property AppMonitorConfiguration. 
        /// <para>
        /// A structure that contains much of the configuration data for the app monitor. If you
        /// are using Amazon Cognito for authorization, you must include this structure in your
        /// request, and it must include the ID of the Amazon Cognito identity pool to use for
        /// authorization. If you don't include <code>AppMonitorConfiguration</code>, you must
        /// set up your own authorization method. For more information, see <a href="https://docs.aws.amazon.com/monitoring/CloudWatch-RUM-get-started-authorization.html">Authorize
        /// your application to send data to Amazon Web Services</a>.
        /// </para>
        ///  
        /// <para>
        /// If you omit this argument, the sample rate used for RUM is set to 10% of the user
        /// sessions.
        /// </para>
        /// </summary>
        public AppMonitorConfiguration AppMonitorConfiguration
        {
            get { return this._appMonitorConfiguration; }
            set { this._appMonitorConfiguration = value; }
        }

        // Check to see if AppMonitorConfiguration property is set
        internal bool IsSetAppMonitorConfiguration()
        {
            return this._appMonitorConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CwLogEnabled. 
        /// <para>
        /// Data collected by RUM is kept by RUM for 30 days and then deleted. This parameter
        /// specifies whether RUM sends a copy of this telemetry data to Amazon CloudWatch Logs
        /// in your account. This enables you to keep the telemetry data for more than 30 days,
        /// but it does incur Amazon CloudWatch Logs charges.
        /// </para>
        ///  
        /// <para>
        /// If you omit this parameter, the default is <code>false</code>.
        /// </para>
        /// </summary>
        public bool CwLogEnabled
        {
            get { return this._cwLogEnabled.GetValueOrDefault(); }
            set { this._cwLogEnabled = value; }
        }

        // Check to see if CwLogEnabled property is set
        internal bool IsSetCwLogEnabled()
        {
            return this._cwLogEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Domain. 
        /// <para>
        /// The top-level internet domain name for which your application has administrative authority.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=253)]
        public string Domain
        {
            get { return this._domain; }
            set { this._domain = value; }
        }

        // Check to see if Domain property is set
        internal bool IsSetDomain()
        {
            return this._domain != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A name for the app monitor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Assigns one or more tags (key-value pairs) to the app monitor.
        /// </para>
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values.
        /// </para>
        ///  
        /// <para>
        /// Tags don't have any semantic meaning to Amazon Web Services and are interpreted strictly
        /// as strings of characters.
        /// </para>
        ///  <pre><code> &lt;p&gt;You can associate as many as 50 tags with an app monitor.&lt;/p&gt;
        /// &lt;p&gt;For more information, see &lt;a href=&quot;https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html&quot;&gt;Tagging
        /// Amazon Web Services resources&lt;/a&gt;.&lt;/p&gt; </code></pre>
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

    }
}