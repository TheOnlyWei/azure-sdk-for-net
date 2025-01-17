// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Blob index tag based filtering for blob objects. </summary>
    public partial class ManagementPolicyTagFilter
    {
        /// <summary> Initializes a new instance of ManagementPolicyTagFilter. </summary>
        /// <param name="name"> This is the filter tag name, it can have 1 - 128 characters. </param>
        /// <param name="operator"> This is the comparison operator which is used for object comparison and filtering. Only == (equality operator) is currently supported. </param>
        /// <param name="value"> This is the filter tag value field used for tag based filtering, it can have 0 - 256 characters. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="operator"/> or <paramref name="value"/> is null. </exception>
        public ManagementPolicyTagFilter(string name, string @operator, string value)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (@operator == null)
            {
                throw new ArgumentNullException(nameof(@operator));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Name = name;
            Operator = @operator;
            Value = value;
        }

        /// <summary> This is the filter tag name, it can have 1 - 128 characters. </summary>
        public string Name { get; set; }
        /// <summary> This is the comparison operator which is used for object comparison and filtering. Only == (equality operator) is currently supported. </summary>
        public string Operator { get; set; }
        /// <summary> This is the filter tag value field used for tag based filtering, it can have 0 - 256 characters. </summary>
        public string Value { get; set; }
    }
}
