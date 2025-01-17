// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary>
    /// The direction for the resource provider connection.
    /// Serialized Name: ResourceProviderConnection
    /// </summary>
    public readonly partial struct HDInsightResourceProviderConnection : IEquatable<HDInsightResourceProviderConnection>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HDInsightResourceProviderConnection"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HDInsightResourceProviderConnection(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InboundValue = "Inbound";
        private const string OutboundValue = "Outbound";

        /// <summary>
        /// Inbound
        /// Serialized Name: ResourceProviderConnection.Inbound
        /// </summary>
        public static HDInsightResourceProviderConnection Inbound { get; } = new HDInsightResourceProviderConnection(InboundValue);
        /// <summary>
        /// Outbound
        /// Serialized Name: ResourceProviderConnection.Outbound
        /// </summary>
        public static HDInsightResourceProviderConnection Outbound { get; } = new HDInsightResourceProviderConnection(OutboundValue);
        /// <summary> Determines if two <see cref="HDInsightResourceProviderConnection"/> values are the same. </summary>
        public static bool operator ==(HDInsightResourceProviderConnection left, HDInsightResourceProviderConnection right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HDInsightResourceProviderConnection"/> values are not the same. </summary>
        public static bool operator !=(HDInsightResourceProviderConnection left, HDInsightResourceProviderConnection right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HDInsightResourceProviderConnection"/>. </summary>
        public static implicit operator HDInsightResourceProviderConnection(string value) => new HDInsightResourceProviderConnection(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HDInsightResourceProviderConnection other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HDInsightResourceProviderConnection other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
