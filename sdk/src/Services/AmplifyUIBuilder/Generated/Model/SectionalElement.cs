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
 * Do not modify this file. This file is generated from the amplifyuibuilder-2021-08-11.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AmplifyUIBuilder.Model
{
    /// <summary>
    /// Stores the configuration information for a visual helper element for a form. A sectional
    /// element can be a header, a text block, or a divider. These elements are static and
    /// not associated with any data.
    /// </summary>
    public partial class SectionalElement
    {
        private int? _level;
        private string _orientation;
        private FieldPosition _position;
        private string _text;
        private string _type;

        /// <summary>
        /// Gets and sets the property Level. 
        /// <para>
        /// Specifies the size of the font for a <code>Heading</code> sectional element. Valid
        /// values are <code>1 | 2 | 3 | 4 | 5 | 6</code>.
        /// </para>
        /// </summary>
        public int Level
        {
            get { return this._level.GetValueOrDefault(); }
            set { this._level = value; }
        }

        // Check to see if Level property is set
        internal bool IsSetLevel()
        {
            return this._level.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Orientation. 
        /// <para>
        /// Specifies the orientation for a <code>Divider</code> sectional element. Valid values
        /// are <code>horizontal</code> or <code>vertical</code>.
        /// </para>
        /// </summary>
        public string Orientation
        {
            get { return this._orientation; }
            set { this._orientation = value; }
        }

        // Check to see if Orientation property is set
        internal bool IsSetOrientation()
        {
            return this._orientation != null;
        }

        /// <summary>
        /// Gets and sets the property Position. 
        /// <para>
        /// Specifies the position of the text in a field for a <code>Text</code> sectional element.
        /// </para>
        /// </summary>
        public FieldPosition Position
        {
            get { return this._position; }
            set { this._position = value; }
        }

        // Check to see if Position property is set
        internal bool IsSetPosition()
        {
            return this._position != null;
        }

        /// <summary>
        /// Gets and sets the property Text. 
        /// <para>
        /// The text for a <code>Text</code> sectional element.
        /// </para>
        /// </summary>
        public string Text
        {
            get { return this._text; }
            set { this._text = value; }
        }

        // Check to see if Text property is set
        internal bool IsSetText()
        {
            return this._text != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of sectional element. Valid values are <code>Heading</code>, <code>Text</code>,
        /// and <code>Divider</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}