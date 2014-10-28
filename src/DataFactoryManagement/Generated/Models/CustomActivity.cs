// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.DataFactories.Models;

namespace Microsoft.Azure.Management.DataFactories.Models
{
    /// <summary>
    /// Custom activity.
    /// </summary>
    public partial class CustomActivity : Activity
    {
        private CustomActivityProperties _transformation;
        
        /// <summary>
        /// Optional. Custom activity properties.
        /// </summary>
        public CustomActivityProperties Transformation
        {
            get { return this._transformation; }
            set { this._transformation = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the CustomActivity class.
        /// </summary>
        public CustomActivity()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the CustomActivity class with
        /// required arguments.
        /// </summary>
        public CustomActivity(string name)
            : this()
        {
            if (name == null)
            {
                throw new ArgumentNullException("name");
            }
            this.Name = name;
        }
    }
}
