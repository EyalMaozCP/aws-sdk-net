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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a security group and Amazon Web Services account ID pair.
    /// 
    ///  <note> 
    /// <para>
    /// We are retiring EC2-Classic on August 15, 2022. We recommend that you migrate from
    /// EC2-Classic to a VPC. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-migrate.html">Migrate
    /// from EC2-Classic to a VPC</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UserIdGroupPair
    {
        private string _description;
        private string _groupId;
        private string _groupName;
        private string _peeringStatus;
        private string _userId;
        private string _vpcId;
        private string _vpcPeeringConnectionId;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description for the security group rule that references this user ID group pair.
        /// </para>
        ///  
        /// <para>
        /// Constraints: Up to 255 characters in length. Allowed characters are a-z, A-Z, 0-9,
        /// spaces, and ._-:/()#,@[]+=;{}!$*
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property GroupId. 
        /// <para>
        /// The ID of the security group.
        /// </para>
        /// </summary>
        public string GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        // Check to see if GroupId property is set
        internal bool IsSetGroupId()
        {
            return this._groupId != null;
        }

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the security group. In a request, use this parameter for a security group
        /// in EC2-Classic or a default VPC only. For a security group in a nondefault VPC, use
        /// the security group ID. 
        /// </para>
        ///  
        /// <para>
        /// For a referenced security group in another VPC, this value is not returned if the
        /// referenced security group is deleted.
        /// </para>
        /// </summary>
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property PeeringStatus. 
        /// <para>
        /// The status of a VPC peering connection, if applicable.
        /// </para>
        /// </summary>
        public string PeeringStatus
        {
            get { return this._peeringStatus; }
            set { this._peeringStatus = value; }
        }

        // Check to see if PeeringStatus property is set
        internal bool IsSetPeeringStatus()
        {
            return this._peeringStatus != null;
        }

        /// <summary>
        /// Gets and sets the property UserId. 
        /// <para>
        /// The ID of an Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// For a referenced security group in another VPC, the account ID of the referenced security
        /// group is returned in the response. If the referenced security group is deleted, this
        /// value is not returned.
        /// </para>
        ///  
        /// <para>
        /// [EC2-Classic] Required when adding or removing rules that reference a security group
        /// in another Amazon Web Services account.
        /// </para>
        /// </summary>
        public string UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        // Check to see if UserId property is set
        internal bool IsSetUserId()
        {
            return this._userId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the VPC for the referenced security group, if applicable.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcPeeringConnectionId. 
        /// <para>
        /// The ID of the VPC peering connection, if applicable.
        /// </para>
        /// </summary>
        public string VpcPeeringConnectionId
        {
            get { return this._vpcPeeringConnectionId; }
            set { this._vpcPeeringConnectionId = value; }
        }

        // Check to see if VpcPeeringConnectionId property is set
        internal bool IsSetVpcPeeringConnectionId()
        {
            return this._vpcPeeringConnectionId != null;
        }

    }
}